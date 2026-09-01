using muni_class_library;
using municipality_app.Services;

namespace municipality_app
{
    public partial class ViewIssuesForm : Form
    {
        private readonly IssueStorageService _issueService;

        private List<IssueEntity> _allIssues = new();

        public ViewIssuesForm()
        {
            InitializeComponent();

            _issueService = new IssueStorageService();
        }


        // =====================================================
        // FORM LOAD
        // =====================================================

        private async void ViewIssuesForm_Load(
            object sender,
            EventArgs e)
        {
            await LoadIssuesAsync();
        }


        // =====================================================
        // VIEW ISSUES BUTTON
        // =====================================================

        private async void btnViewIssues_Click(
            object sender,
            EventArgs e)
        {
            await LoadIssuesAsync();
        }


        // =====================================================
        // LOAD ISSUES
        // =====================================================

        private async Task LoadIssuesAsync()
        {
            try
            {
                btnViewIssues.Enabled = false;
                btnSearch.Enabled = false;

                lblStatus.Text = "Loading issues...";

                _allIssues =
                    await _issueService.GetIssuesAsync();

                DisplayIssues(_allIssues);

                lblStatus.Text =
                    $"{_allIssues.Count} issue(s) loaded";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Failed to load issues";

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnViewIssues.Enabled = true;
                btnSearch.Enabled = true;
            }
        }


        // =====================================================
        // DISPLAY ISSUES
        // =====================================================

        private void DisplayIssues(
            IEnumerable<IssueEntity> issues)
        {
            dgvIssues.DataSource = null;

            dgvIssues.DataSource =
                issues.Select(issue => new
                {
                    ID = issue.RowKey,
                    Title = issue.Title,
                    Location = issue.Location,
                    Category = issue.IssueCategory,
                    Description = issue.Description,
                    File = issue.FilePath,
                    Date = issue.Timestamp
                }).ToList();

            // Configure column headers

            if (dgvIssues.Columns.Count > 0)
            {
                dgvIssues.Columns["ID"].HeaderText =
                    "Issue ID";

                dgvIssues.Columns["Title"].HeaderText =
                    "Title";

                dgvIssues.Columns["Location"].HeaderText =
                    "Location";

                dgvIssues.Columns["Category"].HeaderText =
                    "Category";

                dgvIssues.Columns["Description"].HeaderText =
                    "Description";

                dgvIssues.Columns["File"].HeaderText =
                    "Attached File";

                dgvIssues.Columns["Date"].HeaderText =
                    "Date Reported";

                // Width adjustments

                dgvIssues.Columns["ID"].FillWeight = 20;
                dgvIssues.Columns["Title"].FillWeight = 25;
                dgvIssues.Columns["Location"].FillWeight = 25;
                dgvIssues.Columns["Category"].FillWeight = 20;
                dgvIssues.Columns["Description"].FillWeight = 45;
                dgvIssues.Columns["File"].FillWeight = 25;
                dgvIssues.Columns["Date"].FillWeight = 25;
            }
        }


        // =====================================================
        // SEARCH BUTTON
        // =====================================================

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            string searchText =
                txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                DisplayIssues(_allIssues);

                lblStatus.Text =
                    $"{_allIssues.Count} issue(s) loaded";

                return;
            }

            IEnumerable<IssueEntity> filteredIssues =
                _allIssues.Where(issue =>
                    (issue.Title ?? "")
                        .Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase)

                    ||

                    (issue.Location ?? "")
                        .Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase)

                    ||

                    (issue.Description ?? "")
                        .Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase)

                    ||

                    (issue.IssueCategory ?? "")
                        .Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase)

                    ||

                    (issue.RowKey ?? "")
                        .Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase)
                );

            List<IssueEntity> results =
                filteredIssues.ToList();

            DisplayIssues(results);

            lblStatus.Text =
                $"{results.Count} matching issue(s)";
        }


        // =====================================================
        // CLEAR TABLE
        // =====================================================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            dgvIssues.DataSource = null;

            txtSearch.Clear();

            lblStatus.Text =
                "Table cleared";
        }
    }
}