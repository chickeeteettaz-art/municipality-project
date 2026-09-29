using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace municipality_app
{
    partial class AnnouncementWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private Panel headerPanel;
        private Panel contentPanel;


        private Label municipalityLabel;
        private Label pageTitleLabel;
        private Label pageSubtitleLabel;

        private Button postAnnouncementButton;


        private Label sectionTitleLabel;
        private Label sectionSubtitleLabel;


        private Panel totalCard;
        private Panel weekCard;
        private Panel upcomingCard;
        private Panel recommendedCard;

        private Label totalCaptionLabel;
        private Label thisWeekCaptionLabel;
        private Label upcomingCaptionLabel;
        private Label recommendedCaptionLabel;

        private Label totalAnnouncementsLabel;
        private Label thisWeekLabel;
        private Label upcomingLabel;
        private Label recommendedLabel;


        private Panel filterPanel;

        private Label searchLabel;
        private Label categoryLabel;
        private Label dateFromLabel;
        private Label dateToLabel;

        private MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialComboBox eventCategoryComboBox;

        private DateTimePicker dateFromPicker;
        private DateTimePicker dateToPicker;

        private MaterialButton materialButton1;

        private Button clearFiltersButton;


        private Label resultCountLabel;
        private Label recommendationInfoLabel;

        private Panel resultsPanel;

        private MaterialListView listView1;

        private ColumnHeader AnnouncementNumber;
        private ColumnHeader Title;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;

        
        private Panel detailsPanel;

        private Label detailsHeaderLabel;
        private Label selectedTitleLabel;
        private Label selectedCategoryLabel;
        private Label selectedDateLabel;
        private Label selectedLocationLabel;
        private Label selectedDescriptionLabel;

       
        private TableLayoutPanel contentLayout;
        private TableLayoutPanel statisticsLayout;
        private TableLayoutPanel filterLayout;
        private TableLayoutPanel resultsLayout;

        

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            headerPanel = new Panel();
            btnPublish = new Button();
            municipalityLabel = new Label();
            pageTitleLabel = new Label();
            pageSubtitleLabel = new Label();
            postAnnouncementButton = new Button();
            contentPanel = new Panel();
            contentLayout = new TableLayoutPanel();
            sectionTitleLabel = new Label();
            sectionSubtitleLabel = new Label();
            statisticsLayout = new TableLayoutPanel();
            totalCard = new Panel();
            totalAnnouncementsLabel = new Label();
            totalCaptionLabel = new Label();
            weekCard = new Panel();
            thisWeekLabel = new Label();
            thisWeekCaptionLabel = new Label();
            upcomingCard = new Panel();
            upcomingLabel = new Label();
            upcomingCaptionLabel = new Label();
            recommendedCard = new Panel();
            recommendedLabel = new Label();
            recommendedCaptionLabel = new Label();
            filterPanel = new Panel();
            filterLayout = new TableLayoutPanel();
            searchLabel = new Label();
            categoryLabel = new Label();
            dateFromLabel = new Label();
            dateToLabel = new Label();
            materialMaskedTextBox1 = new MaterialMaskedTextBox();
            eventCategoryComboBox = new MaterialComboBox();
            dateFromPicker = new DateTimePicker();
            dateToPicker = new DateTimePicker();
            materialButton1 = new MaterialButton();
            clearFiltersButton = new Button();
            recommendationInfoLabel = new Label();
            resultCountLabel = new Label();
            resultsLayout = new TableLayoutPanel();
            resultsPanel = new Panel();
            listView1 = new MaterialListView();
            AnnouncementNumber = new ColumnHeader();
            Title = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            detailsPanel = new Panel();
            selectedDescriptionLabel = new Label();
            selectedLocationLabel = new Label();
            selectedDateLabel = new Label();
            selectedCategoryLabel = new Label();
            selectedTitleLabel = new Label();
            detailsHeaderLabel = new Label();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            contentLayout.SuspendLayout();
            statisticsLayout.SuspendLayout();
            totalCard.SuspendLayout();
            weekCard.SuspendLayout();
            upcomingCard.SuspendLayout();
            recommendedCard.SuspendLayout();
            filterPanel.SuspendLayout();
            filterLayout.SuspendLayout();
            resultsLayout.SuspendLayout();
            resultsPanel.SuspendLayout();
            detailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(25, 72, 120);
            headerPanel.Controls.Add(btnPublish);
            headerPanel.Controls.Add(municipalityLabel);
            headerPanel.Controls.Add(pageTitleLabel);
            headerPanel.Controls.Add(pageSubtitleLabel);
            headerPanel.Controls.Add(postAnnouncementButton);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(38, 15, 38, 15);
            headerPanel.Size = new Size(1400, 125);
            headerPanel.TabIndex = 1;
            headerPanel.Paint += headerPanel_Paint;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPublish.Location = new Point(1083, 45);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(179, 44);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Post Announcement";
            btnPublish.UseVisualStyleBackColor = true;
            btnPublish.Click += btnPublish_Click;
            // 
            // municipalityLabel
            // 
            municipalityLabel.AutoSize = true;
            municipalityLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            municipalityLabel.ForeColor = Color.FromArgb(205, 228, 247);
            municipalityLabel.Location = new Point(38, 12);
            municipalityLabel.Name = "municipalityLabel";
            municipalityLabel.Size = new Size(174, 21);
            municipalityLabel.TabIndex = 0;
            municipalityLabel.Text = "MUNICIPAL SERVICES";
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            pageTitleLabel.ForeColor = Color.White;
            pageTitleLabel.Location = new Point(35, 35);
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(474, 54);
            pageTitleLabel.TabIndex = 1;
            pageTitleLabel.Text = "Announcements & Notices";
            // 
            // pageSubtitleLabel
            // 
            pageSubtitleLabel.AutoSize = true;
            pageSubtitleLabel.Font = new Font("Segoe UI", 9.5F);
            pageSubtitleLabel.ForeColor = Color.FromArgb(220, 235, 250);
            pageSubtitleLabel.Location = new Point(38, 82);
            pageSubtitleLabel.Name = "pageSubtitleLabel";
            pageSubtitleLabel.Size = new Size(607, 21);
            pageSubtitleLabel.TabIndex = 2;
            pageSubtitleLabel.Text = "Keeping residents informed about municipal services, notices and community updates.";
            // 
            // postAnnouncementButton
            // 
            postAnnouncementButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            postAnnouncementButton.BackColor = Color.White;
            postAnnouncementButton.Cursor = Cursors.Hand;
            postAnnouncementButton.FlatAppearance.BorderSize = 0;
            postAnnouncementButton.FlatStyle = FlatStyle.Flat;
            postAnnouncementButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            postAnnouncementButton.ForeColor = Color.FromArgb(25, 72, 120);
            postAnnouncementButton.Location = new Point(2350, 40);
            postAnnouncementButton.Name = "postAnnouncementButton";
            postAnnouncementButton.Size = new Size(205, 48);
            postAnnouncementButton.TabIndex = 3;
            postAnnouncementButton.Text = "+  Post Announcement";
            postAnnouncementButton.UseVisualStyleBackColor = false;
            postAnnouncementButton.Click += postAnnouncementButton_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(245, 247, 250);
            contentPanel.Controls.Add(contentLayout);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 125);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(30, 20, 30, 25);
            contentPanel.Size = new Size(1400, 725);
            contentPanel.TabIndex = 0;
            // 
            // contentLayout
            // 
            contentLayout.ColumnCount = 1;
            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentLayout.Controls.Add(sectionTitleLabel, 0, 0);
            contentLayout.Controls.Add(sectionSubtitleLabel, 0, 1);
            contentLayout.Controls.Add(statisticsLayout, 0, 2);
            contentLayout.Controls.Add(filterPanel, 0, 3);
            contentLayout.Controls.Add(resultCountLabel, 0, 4);
            contentLayout.Controls.Add(resultsLayout, 0, 5);
            contentLayout.Dock = DockStyle.Fill;
            contentLayout.Location = new Point(30, 20);
            contentLayout.Name = "contentLayout";
            contentLayout.RowCount = 6;
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentLayout.Size = new Size(1340, 680);
            contentLayout.TabIndex = 0;
            // 
            // sectionTitleLabel
            // 
            sectionTitleLabel.Dock = DockStyle.Fill;
            sectionTitleLabel.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            sectionTitleLabel.ForeColor = Color.FromArgb(40, 40, 40);
            sectionTitleLabel.Location = new Point(3, 0);
            sectionTitleLabel.Name = "sectionTitleLabel";
            sectionTitleLabel.Size = new Size(1334, 50);
            sectionTitleLabel.TabIndex = 0;
            sectionTitleLabel.Text = "Latest municipal information";
            sectionTitleLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // sectionSubtitleLabel
            // 
            sectionSubtitleLabel.Dock = DockStyle.Fill;
            sectionSubtitleLabel.Font = new Font("Segoe UI", 9.5F);
            sectionSubtitleLabel.ForeColor = Color.FromArgb(110, 110, 110);
            sectionSubtitleLabel.Location = new Point(3, 50);
            sectionSubtitleLabel.Name = "sectionSubtitleLabel";
            sectionSubtitleLabel.Size = new Size(1334, 30);
            sectionSubtitleLabel.TabIndex = 1;
            sectionSubtitleLabel.Text = "Search, filter and discover announcements relevant to you.";
            sectionSubtitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statisticsLayout
            // 
            statisticsLayout.ColumnCount = 4;
            statisticsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statisticsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statisticsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statisticsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statisticsLayout.Controls.Add(totalCard, 0, 0);
            statisticsLayout.Controls.Add(weekCard, 1, 0);
            statisticsLayout.Controls.Add(upcomingCard, 2, 0);
            statisticsLayout.Controls.Add(recommendedCard, 3, 0);
            statisticsLayout.Dock = DockStyle.Fill;
            statisticsLayout.Location = new Point(3, 83);
            statisticsLayout.Name = "statisticsLayout";
            statisticsLayout.RowCount = 1;
            statisticsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statisticsLayout.Size = new Size(1334, 99);
            statisticsLayout.TabIndex = 2;
            // 
            // totalCard
            // 
            totalCard.BackColor = Color.White;
            totalCard.Controls.Add(totalAnnouncementsLabel);
            totalCard.Controls.Add(totalCaptionLabel);
            totalCard.Dock = DockStyle.Fill;
            totalCard.Location = new Point(0, 5);
            totalCard.Margin = new Padding(0, 5, 8, 5);
            totalCard.Name = "totalCard";
            totalCard.Size = new Size(325, 89);
            totalCard.TabIndex = 0;
            // 
            // totalAnnouncementsLabel
            // 
            totalAnnouncementsLabel.AutoSize = true;
            totalAnnouncementsLabel.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold);
            totalAnnouncementsLabel.ForeColor = Color.FromArgb(25, 72, 120);
            totalAnnouncementsLabel.Location = new Point(20, 10);
            totalAnnouncementsLabel.Name = "totalAnnouncementsLabel";
            totalAnnouncementsLabel.Size = new Size(44, 52);
            totalAnnouncementsLabel.TabIndex = 0;
            totalAnnouncementsLabel.Text = "0";
            // 
            // totalCaptionLabel
            // 
            totalCaptionLabel.AutoSize = true;
            totalCaptionLabel.Font = new Font("Segoe UI", 9F);
            totalCaptionLabel.ForeColor = Color.Gray;
            totalCaptionLabel.Location = new Point(20, 62);
            totalCaptionLabel.Name = "totalCaptionLabel";
            totalCaptionLabel.Size = new Size(150, 20);
            totalCaptionLabel.TabIndex = 1;
            totalCaptionLabel.Text = "Total announcements";
            totalCaptionLabel.Click += totalCaptionLabel_Click;
            // 
            // weekCard
            // 
            weekCard.BackColor = Color.White;
            weekCard.Controls.Add(thisWeekLabel);
            weekCard.Controls.Add(thisWeekCaptionLabel);
            weekCard.Dock = DockStyle.Fill;
            weekCard.Location = new Point(341, 5);
            weekCard.Margin = new Padding(8, 5, 8, 5);
            weekCard.Name = "weekCard";
            weekCard.Size = new Size(317, 89);
            weekCard.TabIndex = 1;
            // 
            // thisWeekLabel
            // 
            thisWeekLabel.AutoSize = true;
            thisWeekLabel.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold);
            thisWeekLabel.ForeColor = Color.FromArgb(25, 72, 120);
            thisWeekLabel.Location = new Point(18, 10);
            thisWeekLabel.Name = "thisWeekLabel";
            thisWeekLabel.Size = new Size(44, 52);
            thisWeekLabel.TabIndex = 0;
            thisWeekLabel.Text = "0";
            // 
            // thisWeekCaptionLabel
            // 
            thisWeekCaptionLabel.AutoSize = true;
            thisWeekCaptionLabel.Font = new Font("Segoe UI", 9F);
            thisWeekCaptionLabel.ForeColor = Color.Gray;
            thisWeekCaptionLabel.Location = new Point(18, 62);
            thisWeekCaptionLabel.Name = "thisWeekCaptionLabel";
            thisWeekCaptionLabel.Size = new Size(138, 20);
            thisWeekCaptionLabel.TabIndex = 1;
            thisWeekCaptionLabel.Text = "Published this week";
            // 
            // upcomingCard
            // 
            upcomingCard.BackColor = Color.White;
            upcomingCard.Controls.Add(upcomingLabel);
            upcomingCard.Controls.Add(upcomingCaptionLabel);
            upcomingCard.Dock = DockStyle.Fill;
            upcomingCard.Location = new Point(674, 5);
            upcomingCard.Margin = new Padding(8, 5, 8, 5);
            upcomingCard.Name = "upcomingCard";
            upcomingCard.Size = new Size(317, 89);
            upcomingCard.TabIndex = 2;
            // 
            // upcomingLabel
            // 
            upcomingLabel.AutoSize = true;
            upcomingLabel.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold);
            upcomingLabel.ForeColor = Color.FromArgb(25, 72, 120);
            upcomingLabel.Location = new Point(18, 10);
            upcomingLabel.Name = "upcomingLabel";
            upcomingLabel.Size = new Size(44, 52);
            upcomingLabel.TabIndex = 0;
            upcomingLabel.Text = "0";
            // 
            // upcomingCaptionLabel
            // 
            upcomingCaptionLabel.AutoSize = true;
            upcomingCaptionLabel.Font = new Font("Segoe UI", 9F);
            upcomingCaptionLabel.ForeColor = Color.Gray;
            upcomingCaptionLabel.Location = new Point(18, 62);
            upcomingCaptionLabel.Name = "upcomingCaptionLabel";
            upcomingCaptionLabel.Size = new Size(186, 20);
            upcomingCaptionLabel.TabIndex = 1;
            upcomingCaptionLabel.Text = "Upcoming announcements";
            // 
            // recommendedCard
            // 
            recommendedCard.BackColor = Color.White;
            recommendedCard.Controls.Add(recommendedLabel);
            recommendedCard.Controls.Add(recommendedCaptionLabel);
            recommendedCard.Dock = DockStyle.Fill;
            recommendedCard.Location = new Point(1007, 5);
            recommendedCard.Margin = new Padding(8, 5, 0, 5);
            recommendedCard.Name = "recommendedCard";
            recommendedCard.Size = new Size(327, 89);
            recommendedCard.TabIndex = 3;
            // 
            // recommendedLabel
            // 
            recommendedLabel.AutoSize = true;
            recommendedLabel.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold);
            recommendedLabel.ForeColor = Color.FromArgb(25, 72, 120);
            recommendedLabel.Location = new Point(18, 10);
            recommendedLabel.Name = "recommendedLabel";
            recommendedLabel.Size = new Size(44, 52);
            recommendedLabel.TabIndex = 0;
            recommendedLabel.Text = "0";
            // 
            // recommendedCaptionLabel
            // 
            recommendedCaptionLabel.AutoSize = true;
            recommendedCaptionLabel.Font = new Font("Segoe UI", 9F);
            recommendedCaptionLabel.ForeColor = Color.Gray;
            recommendedCaptionLabel.Location = new Point(19, 62);
            recommendedCaptionLabel.Name = "recommendedCaptionLabel";
            recommendedCaptionLabel.Size = new Size(161, 20);
            recommendedCaptionLabel.TabIndex = 1;
            recommendedCaptionLabel.Text = "Recommended for you";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.White;
            filterPanel.Controls.Add(filterLayout);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(3, 188);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(15, 10, 15, 10);
            filterPanel.Size = new Size(1334, 94);
            filterPanel.TabIndex = 3;
            // 
            // filterLayout
            // 
            filterLayout.ColumnCount = 7;
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            filterLayout.Controls.Add(searchLabel, 0, 0);
            filterLayout.Controls.Add(categoryLabel, 1, 0);
            filterLayout.Controls.Add(dateFromLabel, 2, 0);
            filterLayout.Controls.Add(dateToLabel, 3, 0);
            filterLayout.Controls.Add(materialMaskedTextBox1, 0, 1);
            filterLayout.Controls.Add(eventCategoryComboBox, 1, 1);
            filterLayout.Controls.Add(dateFromPicker, 2, 1);
            filterLayout.Controls.Add(dateToPicker, 3, 1);
            filterLayout.Controls.Add(materialButton1, 4, 1);
            filterLayout.Controls.Add(clearFiltersButton, 5, 1);
            filterLayout.Controls.Add(recommendationInfoLabel, 6, 1);
            filterLayout.Dock = DockStyle.Fill;
            filterLayout.Location = new Point(15, 10);
            filterLayout.Name = "filterLayout";
            filterLayout.RowCount = 2;
            filterLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            filterLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            filterLayout.Size = new Size(1304, 74);
            filterLayout.TabIndex = 0;
            // 
            // searchLabel
            // 
            searchLabel.Dock = DockStyle.Fill;
            searchLabel.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            searchLabel.ForeColor = Color.FromArgb(75, 75, 75);
            searchLabel.Location = new Point(3, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(384, 25);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "SEARCH";
            searchLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // categoryLabel
            // 
            categoryLabel.Dock = DockStyle.Fill;
            categoryLabel.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            categoryLabel.ForeColor = Color.FromArgb(75, 75, 75);
            categoryLabel.Location = new Point(393, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(220, 25);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "CATEGORY";
            categoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateFromLabel
            // 
            dateFromLabel.Dock = DockStyle.Fill;
            dateFromLabel.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            dateFromLabel.ForeColor = Color.FromArgb(75, 75, 75);
            dateFromLabel.Location = new Point(619, 0);
            dateFromLabel.Name = "dateFromLabel";
            dateFromLabel.Size = new Size(157, 25);
            dateFromLabel.TabIndex = 2;
            dateFromLabel.Text = "FROM DATE";
            dateFromLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateToLabel
            // 
            dateToLabel.Dock = DockStyle.Fill;
            dateToLabel.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            dateToLabel.ForeColor = Color.FromArgb(75, 75, 75);
            dateToLabel.Location = new Point(782, 0);
            dateToLabel.Name = "dateToLabel";
            dateToLabel.Size = new Size(157, 25);
            dateToLabel.TabIndex = 3;
            dateToLabel.Text = "TO DATE";
            dateToLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Dock = DockStyle.Fill;
            materialMaskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.Hint = "Search title, description or location";
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(0, 27);
            materialMaskedTextBox1.Margin = new Padding(0, 2, 8, 2);
            materialMaskedTextBox1.Mask = "";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(382, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 0;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // eventCategoryComboBox
            // 
            eventCategoryComboBox.AutoResize = false;
            eventCategoryComboBox.BackColor = Color.FromArgb(255, 255, 255);
            eventCategoryComboBox.Depth = 0;
            eventCategoryComboBox.Dock = DockStyle.Fill;
            eventCategoryComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            eventCategoryComboBox.DropDownHeight = 174;
            eventCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            eventCategoryComboBox.DropDownWidth = 121;
            eventCategoryComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            eventCategoryComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            eventCategoryComboBox.IntegralHeight = false;
            eventCategoryComboBox.ItemHeight = 43;
            eventCategoryComboBox.Location = new Point(390, 27);
            eventCategoryComboBox.Margin = new Padding(0, 2, 8, 2);
            eventCategoryComboBox.MaxDropDownItems = 4;
            eventCategoryComboBox.MouseState = MaterialSkin.MouseState.OUT;
            eventCategoryComboBox.Name = "eventCategoryComboBox";
            eventCategoryComboBox.Size = new Size(218, 49);
            eventCategoryComboBox.StartIndex = 0;
            eventCategoryComboBox.TabIndex = 1;
            // 
            // dateFromPicker
            // 
            dateFromPicker.Dock = DockStyle.Fill;
            dateFromPicker.Font = new Font("Segoe UI", 9F);
            dateFromPicker.Format = DateTimePickerFormat.Short;
            dateFromPicker.Location = new Point(616, 28);
            dateFromPicker.Margin = new Padding(0, 3, 8, 3);
            dateFromPicker.Name = "dateFromPicker";
            dateFromPicker.Size = new Size(155, 27);
            dateFromPicker.TabIndex = 2;
            dateFromPicker.ValueChanged += DateFilterChanged;
            // 
            // dateToPicker
            // 
            dateToPicker.Dock = DockStyle.Fill;
            dateToPicker.Font = new Font("Segoe UI", 9F);
            dateToPicker.Format = DateTimePickerFormat.Short;
            dateToPicker.Location = new Point(779, 28);
            dateToPicker.Margin = new Padding(0, 3, 8, 3);
            dateToPicker.Name = "dateToPicker";
            dateToPicker.Size = new Size(155, 27);
            dateToPicker.TabIndex = 3;
            dateToPicker.ValueChanged += DateFilterChanged;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Fill;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(947, 27);
            materialButton1.Margin = new Padding(5, 2, 5, 2);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(100, 45);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "Refresh";
            materialButton1.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.Click += RefreshButton_Click;
            // 
            // clearFiltersButton
            // 
            clearFiltersButton.BackColor = Color.White;
            clearFiltersButton.Cursor = Cursors.Hand;
            clearFiltersButton.Dock = DockStyle.Fill;
            clearFiltersButton.FlatAppearance.BorderColor = Color.FromArgb(25, 72, 120);
            clearFiltersButton.FlatStyle = FlatStyle.Flat;
            clearFiltersButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            clearFiltersButton.ForeColor = Color.FromArgb(25, 72, 120);
            clearFiltersButton.Location = new Point(1057, 27);
            clearFiltersButton.Margin = new Padding(5, 2, 5, 2);
            clearFiltersButton.Name = "clearFiltersButton";
            clearFiltersButton.Size = new Size(115, 45);
            clearFiltersButton.TabIndex = 5;
            clearFiltersButton.Text = "Clear Filters";
            clearFiltersButton.UseVisualStyleBackColor = false;
            // 
            // recommendationInfoLabel
            // 
            recommendationInfoLabel.Dock = DockStyle.Fill;
            recommendationInfoLabel.Font = new Font("Segoe UI", 8.5F);
            recommendationInfoLabel.ForeColor = Color.FromArgb(90, 90, 90);
            recommendationInfoLabel.Location = new Point(1180, 25);
            recommendationInfoLabel.Name = "recommendationInfoLabel";
            recommendationInfoLabel.Size = new Size(121, 49);
            recommendationInfoLabel.TabIndex = 6;
            recommendationInfoLabel.Text = "Results are ranked by relevance";
            recommendationInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultCountLabel
            // 
            resultCountLabel.Dock = DockStyle.Fill;
            resultCountLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            resultCountLabel.ForeColor = Color.FromArgb(85, 85, 85);
            resultCountLabel.Location = new Point(3, 285);
            resultCountLabel.Name = "resultCountLabel";
            resultCountLabel.Size = new Size(1334, 35);
            resultCountLabel.TabIndex = 4;
            resultCountLabel.Text = "0 announcements";
            resultCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // resultsLayout
            // 
            resultsLayout.ColumnCount = 2;
            resultsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            resultsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            resultsLayout.Controls.Add(resultsPanel, 0, 0);
            resultsLayout.Controls.Add(detailsPanel, 1, 0);
            resultsLayout.Dock = DockStyle.Fill;
            resultsLayout.Location = new Point(3, 323);
            resultsLayout.Name = "resultsLayout";
            resultsLayout.RowCount = 1;
            resultsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            resultsLayout.Size = new Size(1334, 354);
            resultsLayout.TabIndex = 5;
            // 
            // resultsPanel
            // 
            resultsPanel.BackColor = Color.White;
            resultsPanel.Controls.Add(listView1);
            resultsPanel.Dock = DockStyle.Fill;
            resultsPanel.Location = new Point(0, 0);
            resultsPanel.Margin = new Padding(0, 0, 8, 0);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Size = new Size(885, 354);
            resultsPanel.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.AutoSizeTable = false;
            listView1.BackColor = Color.FromArgb(255, 255, 255);
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { AnnouncementNumber, Title, columnHeader1, columnHeader2, columnHeader3 });
            listView1.Depth = 0;
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 0);
            listView1.MinimumSize = new Size(200, 100);
            listView1.MouseLocation = new Point(-1, -1);
            listView1.MouseState = MaterialSkin.MouseState.OUT;
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.OwnerDraw = true;
            listView1.Size = new Size(885, 354);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // AnnouncementNumber
            // 
            AnnouncementNumber.Text = "ID";
            AnnouncementNumber.Width = 70;
            // 
            // Title
            // 
            Title.Text = "Announcement";
            Title.Width = 270;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Category";
            columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Location";
            columnHeader3.Width = 220;
            // 
            // detailsPanel
            // 
            detailsPanel.BackColor = Color.White;
            detailsPanel.Controls.Add(selectedDescriptionLabel);
            detailsPanel.Controls.Add(selectedLocationLabel);
            detailsPanel.Controls.Add(selectedDateLabel);
            detailsPanel.Controls.Add(selectedCategoryLabel);
            detailsPanel.Controls.Add(selectedTitleLabel);
            detailsPanel.Controls.Add(detailsHeaderLabel);
            detailsPanel.Dock = DockStyle.Fill;
            detailsPanel.Location = new Point(901, 0);
            detailsPanel.Margin = new Padding(8, 0, 0, 0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Padding = new Padding(22, 20, 22, 20);
            detailsPanel.Size = new Size(433, 354);
            detailsPanel.TabIndex = 1;
            // 
            // selectedDescriptionLabel
            // 
            selectedDescriptionLabel.Dock = DockStyle.Fill;
            selectedDescriptionLabel.Font = new Font("Segoe UI", 9.5F);
            selectedDescriptionLabel.ForeColor = Color.FromArgb(65, 65, 65);
            selectedDescriptionLabel.Location = new Point(22, 228);
            selectedDescriptionLabel.Name = "selectedDescriptionLabel";
            selectedDescriptionLabel.Padding = new Padding(0, 15, 0, 0);
            selectedDescriptionLabel.Size = new Size(389, 106);
            selectedDescriptionLabel.TabIndex = 0;
            selectedDescriptionLabel.Text = "Select an announcement from the list to view its details.";
            // 
            // selectedLocationLabel
            // 
            selectedLocationLabel.Dock = DockStyle.Top;
            selectedLocationLabel.Font = new Font("Segoe UI", 9F);
            selectedLocationLabel.ForeColor = Color.FromArgb(100, 100, 100);
            selectedLocationLabel.Location = new Point(22, 183);
            selectedLocationLabel.Name = "selectedLocationLabel";
            selectedLocationLabel.Size = new Size(389, 45);
            selectedLocationLabel.TabIndex = 1;
            selectedLocationLabel.Text = "Location: —";
            selectedLocationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectedDateLabel
            // 
            selectedDateLabel.Dock = DockStyle.Top;
            selectedDateLabel.Font = new Font("Segoe UI", 9F);
            selectedDateLabel.ForeColor = Color.FromArgb(100, 100, 100);
            selectedDateLabel.Location = new Point(22, 155);
            selectedDateLabel.Name = "selectedDateLabel";
            selectedDateLabel.Size = new Size(389, 28);
            selectedDateLabel.TabIndex = 2;
            selectedDateLabel.Text = "Date: —";
            selectedDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectedCategoryLabel
            // 
            selectedCategoryLabel.Dock = DockStyle.Top;
            selectedCategoryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            selectedCategoryLabel.ForeColor = Color.FromArgb(25, 72, 120);
            selectedCategoryLabel.Location = new Point(22, 125);
            selectedCategoryLabel.Name = "selectedCategoryLabel";
            selectedCategoryLabel.Size = new Size(389, 30);
            selectedCategoryLabel.TabIndex = 3;
            selectedCategoryLabel.Text = "Category: —";
            selectedCategoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectedTitleLabel
            // 
            selectedTitleLabel.Dock = DockStyle.Top;
            selectedTitleLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            selectedTitleLabel.ForeColor = Color.FromArgb(40, 40, 40);
            selectedTitleLabel.Location = new Point(22, 55);
            selectedTitleLabel.Name = "selectedTitleLabel";
            selectedTitleLabel.Size = new Size(389, 70);
            selectedTitleLabel.TabIndex = 4;
            selectedTitleLabel.Text = "Select an announcement";
            selectedTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // detailsHeaderLabel
            // 
            detailsHeaderLabel.Dock = DockStyle.Top;
            detailsHeaderLabel.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            detailsHeaderLabel.ForeColor = Color.FromArgb(25, 72, 120);
            detailsHeaderLabel.Location = new Point(22, 20);
            detailsHeaderLabel.Name = "detailsHeaderLabel";
            detailsHeaderLabel.Size = new Size(389, 35);
            detailsHeaderLabel.TabIndex = 5;
            detailsHeaderLabel.Text = "Announcement Details";
            detailsHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AnnouncementWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1400, 850);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 10F);
            KeyPreview = true;
            MinimumSize = new Size(1100, 700);
            Name = "AnnouncementWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Municipal Services - Announcements";
            Load += AnnouncementWindow_Load;
            KeyDown += AnnouncementWindow_KeyDown;
            Resize += AnnouncementWindow_Resize;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentLayout.ResumeLayout(false);
            statisticsLayout.ResumeLayout(false);
            totalCard.ResumeLayout(false);
            totalCard.PerformLayout();
            weekCard.ResumeLayout(false);
            weekCard.PerformLayout();
            upcomingCard.ResumeLayout(false);
            upcomingCard.PerformLayout();
            recommendedCard.ResumeLayout(false);
            recommendedCard.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterLayout.ResumeLayout(false);
            filterLayout.PerformLayout();
            resultsLayout.ResumeLayout(false);
            resultsPanel.ResumeLayout(false);
            detailsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPublish;
    }
}