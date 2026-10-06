using System.Collections;
using muni_class_library;
using municipality_app.Services;

namespace municipality_app
{
    public partial class AnnouncementWindow : Form
    {

        private readonly AnnouncementServices _announcementService;

        // Complete list retrieved from the API.
        private List<Announcement> _allAnnouncements = new List<Announcement>();


        // Queue used for the announcements currently being displayed.
        private Queue<Announcement> _displayQueue = new Queue<Announcement>();

        // Stack containing recently selected/viewed announcements.
        private Stack<Announcement> _recentlyViewed = new Stack<Announcement>();

        // Hashtable used for fast announcement lookup.
        private Hashtable _announcementTable = new Hashtable();

        private Hashtable _categoryTable = new Hashtable();

        // Search history.
        private Queue<string> _searchHistory = new Queue<string>();

        private const int MaxSearchHistory = 10;
        private const int MaxRecentlyViewed = 20;

        private Announcement? _selectedAnnouncement;

        // FORM STATE
        private bool _isLoading;
        private bool _isApplyingFilters;


        public AnnouncementWindow()
        {
            InitializeComponent();

            _announcementService = new AnnouncementServices();

            ConfigureForm();
            ConfigureControls();
        }

        private void ConfigureForm()
        {
            KeyPreview = true;

            StartPosition = FormStartPosition.CenterScreen;

            MinimumSize = new Size(1100, 700);

            FormBorderStyle = FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = true;
        }


        private void ConfigureControls()
        {
            if (materialMaskedTextBox1 != null)
            {
                materialMaskedTextBox1.TextChanged -= SearchTextChanged;

                materialMaskedTextBox1.TextChanged += SearchTextChanged;
            }

            // Category
            if (eventCategoryComboBox != null)
            {
                eventCategoryComboBox.SelectedIndexChanged -= CategoryFilterChanged;

                eventCategoryComboBox.SelectedIndexChanged += CategoryFilterChanged;
            }

            // Dates
            if (dateFromPicker != null)
            {
                dateFromPicker.ValueChanged -= DateFilterChanged;

                dateFromPicker.ValueChanged += DateFilterChanged;
            }

            if (dateToPicker != null)
            {
                dateToPicker.ValueChanged -= DateFilterChanged;

                dateToPicker.ValueChanged += DateFilterChanged;
            }


            // Refresh
            if (materialButton1 != null)
            {
                materialButton1.Click -= RefreshButton_Click;

                materialButton1.Click += RefreshButton_Click;
            }


            // Clear filters
            if (clearFiltersButton != null)
            {
                clearFiltersButton.Click -= ClearFiltersButton_Click;

                clearFiltersButton.Click += ClearFiltersButton_Click;
            }


            // Post announcement
            if (postAnnouncementButton != null)
            {
                postAnnouncementButton.Click -= postAnnouncementButton_Click;

                postAnnouncementButton.Click += postAnnouncementButton_Click;
            }


            // List selection
            if (listView1 != null)
            {
                listView1.SelectedIndexChanged -= ListView1_SelectedIndexChanged;

                listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            }

            // Keyboard
            KeyDown -= AnnouncementWindow_KeyDown;

            KeyDown += AnnouncementWindow_KeyDown;


            // Form load
            Load -= AnnouncementWindow_Load;

            Load += AnnouncementWindow_Load;


            // Form resize
            Resize -= AnnouncementWindow_Resize;

            Resize += AnnouncementWindow_Resize;
        }



        // FORM LOAD
        private async void AnnouncementWindow_Load(object? sender, EventArgs e)
        {
            try
            {
                ConfigureDatePickers();

                LoadCategoryFilter();

                ClearSelectedAnnouncement();

                LayoutResponsiveControls();

                await LoadAnnouncementsAsync();
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while opening the announcements window.", ex);
            }
        }


        // DATE PICKER CONFIGURATION
        private void ConfigureDatePickers()
        {

            dateFromPicker.MinDate = new DateTime(2000, 1, 1);

            dateFromPicker.MaxDate = new DateTime(2099, 12, 31);

            dateToPicker.MinDate = new DateTime(2000, 1, 1);

            dateToPicker.MaxDate = new DateTime(2099, 12, 31);


            // Initially show all practical announcement dates.
            dateFromPicker.Value = new DateTime(2000, 1, 1);

            dateToPicker.Value = new DateTime(2099, 12, 31);
        }


        // CATEGORY FILTER
        private void LoadCategoryFilter()
        {
            eventCategoryComboBox.Items.Clear();

            eventCategoryComboBox.Items.Add("All Categories");

            eventCategoryComboBox.Items.Add("General");

            eventCategoryComboBox.Items.Add("Service Notice");

            eventCategoryComboBox.Items.Add("Community Event");

            eventCategoryComboBox.Items.Add("Public Meeting");

            eventCategoryComboBox.Items.Add("Emergency Notice");

            eventCategoryComboBox.Items.Add("Road Closure");

            eventCategoryComboBox.Items.Add("Water Services");

            eventCategoryComboBox.Items.Add("Electricity Services");

            eventCategoryComboBox.Items.Add("Waste Management");

            eventCategoryComboBox.Items.Add("Public Safety");

            eventCategoryComboBox.Items.Add("Awareness Event");

            eventCategoryComboBox.SelectedIndex = 0;
        }


        // LOAD ANNOUNCEMENTS
        private async Task LoadAnnouncementsAsync()
        {
            if (_isLoading)
                return;

            _isLoading = true;

            try
            {
                SetLoadingState(true);

                List<Announcement> announcements = await _announcementService.GetAllAnnouncementsAsync();

                _allAnnouncements = announcements?.Where(a => a != null).ToList() ?? new List<Announcement>();

                BuildAnnouncementTable();

                BuildCategoryTable();


                // Clear current selection.
                _selectedAnnouncement = null;


                // Apply current filters.
                ApplyFilters();
            }
            catch (Exception ex)
            {
                ShowError("Failed to load announcements.", ex);
            }
            finally
            {
                _isLoading = false;

                SetLoadingState(false);
            }
        }


        // BUILD HASH TABLE

        private void BuildAnnouncementTable()
        {
            _announcementTable.Clear();

            foreach (Announcement announcement in _allAnnouncements)
            {
                if (announcement == null)
                    continue;


                // Lookup by AnnouncementId.
                _announcementTable[announcement.AnnouncementId] = announcement;

                // Lookup by RowKey.
                if (!string.IsNullOrWhiteSpace(announcement.RowKey))
                {
                    _announcementTable[announcement.RowKey] = announcement;
                }
            }
        }


        // BUILD CATEGORY HASH TABLE
        private void BuildCategoryTable()
        {
            _categoryTable.Clear();

            foreach (Announcement announcement in _allAnnouncements)
            {
                string category = GetCategory(announcement);


                if (!_categoryTable.ContainsKey(category))
                {
                    _categoryTable[category] = new List<Announcement>();
                }


                var categoryList = (List<Announcement>)_categoryTable[category];

                categoryList.Add(announcement);
            }
        }


        // SEARCH FILTER
        private void SearchTextChanged(object? sender, EventArgs e)
        {
            string searchText = materialMaskedTextBox1.Text.Trim();


            if (!string.IsNullOrWhiteSpace(searchText))
            {
                AddSearchToHistory(searchText);
            }

            ApplyFilters();
        }


        // CATEGORY FILTER
        private void CategoryFilterChanged(object? sender, EventArgs e)
        {
            ApplyFilters();
        }


        // DATE FILTER
        private void DateFilterChanged(object? sender, EventArgs e)
        {
            if (_isApplyingFilters)
                return;


            ApplyFilters();
        }


        // APPLY FILTERS
        private void ApplyFilters()
        {
            if (_isApplyingFilters)
                return;

            if (_allAnnouncements == null)
                return;


            _isApplyingFilters = true;

            try
            {
                DateTime fromDate = dateFromPicker.Value.Date;

                DateTime toDate = dateToPicker.Value.Date;


                // Validate date range
                if (fromDate > toDate)
                {
                    resultCountLabel.Text = "Invalid date range";

                    listView1.Items.Clear();

                    recommendationInfoLabel.Text = "Please select a valid date range.";

                    return;
                }


                string searchText = materialMaskedTextBox1.Text.Trim();


                string selectedCategory = eventCategoryComboBox.SelectedItem?.ToString() ?? "All Categories";


                // Get candidate list
                IEnumerable<Announcement> candidates;


                /*
                 * The category Hashtable gives us a smaller candidate
                 * collection when a specific category is selected.
                 */

                if (selectedCategory != "All Categories" && _categoryTable.ContainsKey(selectedCategory))
                {
                    candidates = (List<Announcement>)_categoryTable[selectedCategory];
                }
                else
                {
                    candidates = _allAnnouncements;
                }


                // Apply text and date filters
                List<Announcement> filtered =
                    candidates
                        .Where(a =>
                        {
                            if (a == null)
                                return false;



                            // Compare announcement dates as DATE ONLY.
                            DateTime announcementDate = a.AnnouncementDate.Date;


                            bool matchesDate = announcementDate >= fromDate && announcementDate <= toDate;


                            if (!matchesDate)
                                return false;


                            bool matchesCategory = selectedCategory == "All Categories" || string.Equals(GetCategory(a), selectedCategory, StringComparison.OrdinalIgnoreCase);


                            if (!matchesCategory)
                                return false;


                            if (string.IsNullOrWhiteSpace(searchText))
                            {
                                return true;
                            }


                            return MatchesSearch(a, searchText);
                        })
                        .ToList();


                // Add recommendation scores

                List<Announcement> ranked = RankAnnouncements(filtered);

                // Display
                DisplayAnnouncements(ranked);


                // Update statistics
                UpdateStatistics();


                // Recommendation information
                UpdateRecommendationInformation(ranked);
            }
            finally
            {
                _isApplyingFilters = false;
            }
        }


        // SEARCH MATCHING
        private bool MatchesSearch(Announcement announcement, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return true;


            string search = searchText.ToLowerInvariant();


            string title = announcement.Title?.ToLowerInvariant() ?? string.Empty;


            string description = announcement.Description?.ToLowerInvariant() ?? string.Empty;


            string location = announcement.Location?.ToLowerInvariant() ?? string.Empty;


            string category = GetCategory(announcement).ToLowerInvariant();


            return title.Contains(search)
                || description.Contains(search)
                || location.Contains(search)
                || category.Contains(search);
        }


        // RANK ANNOUNCEMENTS
        private List<Announcement> RankAnnouncements(List<Announcement> announcements)
        {
            if (announcements.Count == 0)
                return announcements;


            DateTime today = DateTime.Today;


            var scored =
                announcements
                    .Select(announcement =>
                    {
                        int score =
                            CalculateRecommendationScore(
                                announcement,
                                today);

                        return new
                        {
                            Announcement = announcement,
                            Score = score
                        };
                    })
                    .OrderByDescending(x => x.Score)
                    .ThenBy(x =>
                        x.Announcement.AnnouncementDate.Date)
                    .ToList();


            return scored.Select(x => x.Announcement).ToList();
        }


        // RECOMMENDATION SCORE
        private int CalculateRecommendationScore(Announcement announcement, DateTime today)
        {
            int score = 0;


            // Upcoming announcements
            DateTime announcementDate = announcement.AnnouncementDate.Date;


            if (announcementDate >= today)
            {
                int daysAway = (announcementDate - today).Days;


                if (daysAway == 0)
                {
                    score += 30;
                }
                else if (daysAway <= 3)
                {
                    score += 25;
                }
                else if (daysAway <= 7)
                {
                    score += 20;
                }
                else if (daysAway <= 30)
                {
                    score += 10;
                }
            }
            else
            {
                // Recent past announcements
                int daysOld = (today - announcementDate).Days;


                if (daysOld <= 7)
                {
                    score += 8;
                }
            }


            // Search history
            int historyWeight = 1;


            foreach (string search in _searchHistory.Reverse())
            {
                if (string.IsNullOrWhiteSpace(search))
                    continue;


                string normalizedSearch = search.Trim().ToLowerInvariant();


                if (ContainsText(announcement.Title, normalizedSearch))
                {
                    score += 10 * historyWeight;
                }


                if (ContainsText(announcement.Description, normalizedSearch))
                {
                    score += 6 * historyWeight;
                }


                if (ContainsText(announcement.Location, normalizedSearch))
                {
                    score += 5 * historyWeight;
                }


                if (ContainsText(GetCategory(announcement), normalizedSearch))
                {
                    score += 8 * historyWeight;
                }


                historyWeight++;


                if (historyWeight > 5)
                    break;
            }


            // Recently viewed
            int viewPosition = 0;

            foreach (Announcement viewed in _recentlyViewed)
            {
                viewPosition++;


                if (IsSameAnnouncement(viewed, announcement))
                {
                    score -= 5;


                    // Very recently viewed.
                    if (viewPosition <= 3)
                    {
                        score -= 5;
                    }

                    break;
                }
            }


            // Category preference
            string announcementCategory = GetCategory(announcement);


            int categoryPosition = 0;


            foreach (Announcement viewed in _recentlyViewed)
            {
                categoryPosition++;


                if (string.Equals(GetCategory(viewed), announcementCategory, StringComparison.OrdinalIgnoreCase))
                {
                    score += Math.Max(1, 8 - categoryPosition);
                    break;
                }
            }

            return score;
        }


        // SEARCH HISTORY
        private void AddSearchToHistory(string searchText)
        {
            searchText = searchText.Trim();


            if (string.IsNullOrWhiteSpace(searchText))
            {
                return;
            }


            // Don't repeatedly add the exact same search.
            if (_searchHistory.Any(s => string.Equals(s, searchText, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            _searchHistory.Enqueue(searchText);

            while (_searchHistory.Count > MaxSearchHistory)
            {
                _searchHistory.Dequeue();
            }
        }


        // DISPLAY ANNOUNCEMENTS
        private void DisplayAnnouncements(List<Announcement> announcements)
        {
            if (listView1 == null)
                return;

            _displayQueue = new Queue<Announcement>(announcements);

            listView1.BeginUpdate();

            try
            {
                listView1.Items.Clear();


                while (_displayQueue.Count > 0)
                {
                    Announcement announcement = _displayQueue.Dequeue();

                    ListViewItem item = new ListViewItem(announcement.AnnouncementId.ToString());

                    item.SubItems.Add(announcement.Title ?? "Untitled Announcement");

                    item.SubItems.Add(GetCategory(announcement));

                    item.SubItems.Add(announcement.AnnouncementDate.Date.ToString("dd MMM yyyy"));

                    item.SubItems.Add(announcement.Location ?? "");

                    item.Tag = announcement;

                    listView1.Items.Add(item);
                }
            }
            finally
            {
                listView1.EndUpdate();
            }


            resultCountLabel.Text = $"{announcements.Count} announcement(s) found";


            if (announcements.Count == 0)
            {
                ClearSelectedAnnouncement();

                recommendationInfoLabel.Text = "No announcements match the selected filters.";
            }
        }


        // LIST VIEW SELECTION
        private void ListView1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }


            ListViewItem item = listView1.SelectedItems[0];


            if (item.Tag is Announcement announcement)
            {
                ShowAnnouncementDetails(announcement);

                AddRecentlyViewed(announcement);
            }
        }


        // SHOW DETAILS
        private void ShowAnnouncementDetails(Announcement announcement)
        {
            _selectedAnnouncement = announcement;

            selectedTitleLabel.Text = string.IsNullOrWhiteSpace(announcement.Title) ? "Untitled Announcement" : announcement.Title;

            selectedCategoryLabel.Text = $"Category: {GetCategory(announcement)}";

            selectedDateLabel.Text = $"Date: {announcement.AnnouncementDate.Date:dd MMMM yyyy}";

            selectedLocationLabel.Text = $"Location: {(string.IsNullOrWhiteSpace(announcement.Location) ? "Not specified" : announcement.Location)}";

            selectedDescriptionLabel.Text = string.IsNullOrWhiteSpace(announcement.Description) ? "No description available." : announcement.Description;
        }


        // RECENTLY VIEWED STACK
        private void AddRecentlyViewed(Announcement announcement)
        {
            if (announcement == null)
                return;


            if (_recentlyViewed.Any(a => IsSameAnnouncement(a, announcement)))
            {
                return;
            }

            _recentlyViewed.Push(announcement);


            while (_recentlyViewed.Count > MaxRecentlyViewed)
            {

                Announcement[] current = _recentlyViewed.ToArray();

                _recentlyViewed = new Stack<Announcement>(current.Take(MaxRecentlyViewed));
            }
        }


        // FIND ANNOUNCEMENT USING HASHTABLE
        private Announcement? FindAnnouncement(int announcementId)
        {
            if (_announcementTable.ContainsKey(announcementId))
            {
                return _announcementTable[announcementId] as Announcement;
            }

            return null;
        }


        private Announcement? FindAnnouncement(string rowKey)
        {
            if (string.IsNullOrWhiteSpace(rowKey))
                return null;


            if (_announcementTable.ContainsKey(rowKey))
            {
                return _announcementTable[rowKey] as Announcement;
            }
            return null;
        }


        // STATISTICS
        private void UpdateStatistics()
        {
            DateTime today = DateTime.Today;


            // Total
            totalAnnouncementsLabel.Text = _allAnnouncements.Count.ToString();


            // This week
            DateTime startOfWeek = StartOfWeek(today, DayOfWeek.Monday);


            DateTime endOfWeek = startOfWeek.AddDays(6);


            int thisWeek = _allAnnouncements.Count(
                    a =>
                    {
                        DateTime date = a.AnnouncementDate.Date;

                        return date >= startOfWeek && date <= endOfWeek;
                    });


            thisWeekLabel.Text = thisWeek.ToString();


            // Upcoming
            int upcoming =
                _allAnnouncements.Count(a => a.AnnouncementDate.Date >= today);


            upcomingLabel.Text = upcoming.ToString();


            // Recommended
            int recommended = CalculateRecommendedCount();


            recommendedLabel.Text = recommended.ToString();
        }


        private int CalculateRecommendedCount()
        {
            if (_allAnnouncements.Count == 0)
                return 0;


            DateTime today = DateTime.Today;


            return _allAnnouncements.Select(a => CalculateRecommendationScore(a, today))
                .Count(score => score > 10);
        }


        // RECOMMENDATION INFORMATION
        private void UpdateRecommendationInformation(List<Announcement> announcements)
        {
            if (announcements.Count == 0)
            {
                recommendationInfoLabel.Text = "No recommendations available.";
                return;
            }


            bool hasSearchHistory = _searchHistory.Count > 0;


            bool hasViewHistory = _recentlyViewed.Count > 0;


            if (hasSearchHistory || hasViewHistory)
            {
                recommendationInfoLabel.Text = "Announcements are ranked using your recent searches, viewed content, category interests and upcoming dates.";
            }
            else
            {
                recommendationInfoLabel.Text = "Announcements are ranked by relevance and upcoming dates.";
            }
        }


        // POST ANNOUNCEMENT
        private void postAnnouncementButton_Click(object? sender, EventArgs e)
        {
            using PostAnnouncementForm form = new PostAnnouncementForm();


            DialogResult result = form.ShowDialog(this);


            if (result == DialogResult.OK && form.CreatedAnnouncement != null)
            {

                _ = ReloadAfterPostAsync();
            }
        }


        private async Task ReloadAfterPostAsync()
        {
            try
            {
                await LoadAnnouncementsAsync();
            }
            catch (Exception ex)
            {
                ShowError("The announcement was saved, but the list could not be refreshed.", ex);
            }
        }


        // REFRESH
        private async void RefreshButton_Click(object? sender, EventArgs e)
        {
            await LoadAnnouncementsAsync();
        }


        // CLEAR FILTERS
        private void ClearFiltersButton_Click(object? sender, EventArgs e)
        {
            _isApplyingFilters = true;

            try
            {
                materialMaskedTextBox1.Clear();


                eventCategoryComboBox.SelectedIndex = 0;

                dateFromPicker.Value = new DateTime(2000, 1, 1);


                dateToPicker.Value = new DateTime(2099, 12, 31);
            }
            finally
            {
                _isApplyingFilters = false;
            }


            ClearSelectedAnnouncement();

            ApplyFilters();
        }


        // CLEAR DETAILS
        private void ClearSelectedAnnouncement()
        {
            _selectedAnnouncement = null;


            selectedTitleLabel.Text = "Select an announcement";


            selectedCategoryLabel.Text = "Category: —";


            selectedDateLabel.Text = "Date: —";


            selectedLocationLabel.Text = "Location: —";


            selectedDescriptionLabel.Text = "Select an announcement from the list to view its details.";
        }


        // LOADING STATE
        private void SetLoadingState(bool loading)
        {
            if (postAnnouncementButton != null)
            {
                postAnnouncementButton.Enabled = !loading;
            }


            if (materialButton1 != null)
            {
                materialButton1.Enabled = !loading;
            }


            if (clearFiltersButton != null)
            {
                clearFiltersButton.Enabled = !loading;
            }


            Cursor = loading ? Cursors.WaitCursor : Cursors.Default;
        }


        // RESPONSIVE LAYOUT
        private void AnnouncementWindow_Resize(object? sender, EventArgs e)
        {
            LayoutResponsiveControls();
        }


        private void LayoutResponsiveControls()
        {
            if (Width < 1)
                return;


            if (Width < 1200)
            {
                if (recommendationInfoLabel != null)
                {
                    recommendationInfoLabel.MaximumSize =
                        new Size(Math.Max(300, Width - 100), 0);
                }
            }
        }


        // KEYBOARD SHORTCUTS
        private void AnnouncementWindow_KeyDown(object? sender, KeyEventArgs e)
        {
            // Ctrl + F = focus search
            if (e.Control && e.KeyCode == Keys.F)
            {
                materialMaskedTextBox1.Focus();

                e.SuppressKeyPress = true;

                return;
            }


            // F5 = refresh
            if (e.KeyCode == Keys.F5)
            {
                e.SuppressKeyPress = true;

                _ = LoadAnnouncementsAsync();

                return;
            }


            // Escape = clear filters
            if (e.KeyCode == Keys.Escape)
            {
                ClearFiltersButton_Click(null, EventArgs.Empty);

                e.SuppressKeyPress = true;

                return;
            }
        }


        // DATE HELPERS
        private static DateTime StartOfWeek(DateTime date, DayOfWeek startOfWeek)
        {
            int difference = (7 + (date.DayOfWeek - startOfWeek)) % 7;

            return date.Date.AddDays(-difference);
        }


        // CATEGORY HELPER
        private static string GetCategory(Announcement announcement)
        {
            if (announcement == null)
                return "General";

            return string.IsNullOrWhiteSpace(announcement.Category) ? "General" : announcement.Category.Trim();
        }


        // TEXT HELPER
        private static bool ContainsText(string? source, string search)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return false;
            }


            return source.Contains(search, StringComparison.OrdinalIgnoreCase);
        }


        // ANNOUNCEMENT COMPARISON
        private static bool IsSameAnnouncement(Announcement first, Announcement second)
        {
            if (first == null || second == null)
            {
                return false;
            }


            if (first.AnnouncementId != 0 && second.AnnouncementId != 0)
            {
                return first.AnnouncementId == second.AnnouncementId;
            }


            if (!string.IsNullOrWhiteSpace(first.RowKey) && !string.IsNullOrWhiteSpace(second.RowKey))
            {
                return string.Equals(first.RowKey, second.RowKey, StringComparison.OrdinalIgnoreCase);
            }

            return ReferenceEquals(first, second);
        }


        // ERROR HANDLING
        private void ShowError(string message, Exception ex)
        {
            MessageBox.Show(
                $"{message}\n\n{ex.Message}",
                "Announcements",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


        // FORM DISPOSAL
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _displayQueue.Clear();

            _recentlyViewed.Clear();

            _announcementTable.Clear();

            _categoryTable.Clear();

            _searchHistory.Clear();

            base.OnFormClosed(e);
        }

        private void totalCaptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            using PostAnnouncementForm form = new PostAnnouncementForm();


            DialogResult result = form.ShowDialog(this);


            if (result == DialogResult.OK && form.CreatedAnnouncement != null)
            {

                _ = ReloadAfterPostAsync();
            }
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}