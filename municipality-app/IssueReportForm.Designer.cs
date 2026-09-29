namespace municipality_app
{
    partial class IssueReportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainPanel = new Panel();
            this.scrollPanel = new Panel();
            this.contentPanel = new Panel();

            this.headerPanel = new Panel();
            this.headerTitleLabel = new Label();
            this.headerSubtitleLabel = new Label();
            this.btnViewReports = new Button();

            this.progressPanel = new Panel();
            this.progressTitleLabel = new Label();
            this.progressPercentLabel = new Label();
            this.reportingProgressBar = new ProgressBar();

            this.detailsPanel = new Panel();
            this.detailsTitleLabel = new Label();

            this.titleLabel = new Label();
            this.titleTextBox = new TextBox();

            this.locationLabel = new Label();
            this.locationTextBox = new TextBox();

            this.serviceTypeLabel = new Label();
            this.serviceTypeComboBox = new ComboBox();

            this.descriptionPanel = new Panel();
            this.descriptionTitleLabel = new Label();
            this.descriptionTextBox = new RichTextBox();

            this.attachmentPanel = new Panel();
            this.attachmentTitleLabel = new Label();
            this.uploadFileButton = new Button();
            this.fileNameLabel = new Label();
            this.fileNameTxt = new Label();
            this.fileLabel = new Label();

            this.previewPanel = new Panel();
            this.previewTitleLabel = new Label();
            this.pbxImage = new PictureBox();
            this.previewPlaceholderLabel = new Label();

            this.footerPanel = new Panel();
            this.submitButton = new Button();
            this.cancelButton = new Button();

            this.mainPanel.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();

            this.headerPanel.SuspendLayout();
            this.progressPanel.SuspendLayout();

            this.detailsPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.attachmentPanel.SuspendLayout();
            this.previewPanel.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.pbxImage)).BeginInit();

            this.footerPanel.SuspendLayout();

            this.SuspendLayout();

            // ==========================================================
            // MAIN PANEL
            // ==========================================================

            this.mainPanel.Dock = DockStyle.Fill;
            this.mainPanel.BackColor =
                Color.FromArgb(245, 247, 250);
            this.mainPanel.Padding =
                new Padding(0);

            // ==========================================================
            // SCROLL PANEL
            // ==========================================================

            this.scrollPanel.Dock =
                DockStyle.Fill;

            this.scrollPanel.AutoScroll =
                true;

            this.scrollPanel.BackColor =
                Color.FromArgb(245, 247, 250);

            // ==========================================================
            // CONTENT PANEL
            // ==========================================================

            this.contentPanel.BackColor =
                Color.FromArgb(245, 247, 250);

            this.contentPanel.Location =
                new Point(0, 0);

            this.contentPanel.Size =
                new Size(1050, 1050);

            this.contentPanel.MinimumSize =
                new Size(850, 1050);

            // ==========================================================
            // HEADER
            // ==========================================================

            this.headerPanel.BackColor =
                Color.FromArgb(25, 118, 160);

            this.headerPanel.Location =
                new Point(20, 20);

            this.headerPanel.Size =
                new Size(1010, 105);

            this.headerTitleLabel.AutoSize = true;

            this.headerTitleLabel.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);

            this.headerTitleLabel.ForeColor =
                Color.White;

            this.headerTitleLabel.Location =
                new Point(25, 18);

            this.headerTitleLabel.Text =
                "Report a Community Issue";

            this.headerSubtitleLabel.AutoSize = true;

            this.headerSubtitleLabel.Font =
                new Font(
                    "Segoe UI",
                    10F);

            this.headerSubtitleLabel.ForeColor =
                Color.FromArgb(
                    220,
                    240,
                    250);

            this.headerSubtitleLabel.Location =
                new Point(28, 62);

            this.headerSubtitleLabel.Text =
                "Help us keep your community safe, clean and connected.";

            // View issues

            this.btnViewReports.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.btnViewReports.BackColor =
                Color.White;

            this.btnViewReports.FlatStyle =
                FlatStyle.Flat;

            this.btnViewReports.FlatAppearance.BorderSize =
                0;

            this.btnViewReports.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.btnViewReports.ForeColor =
                Color.FromArgb(25, 118, 160);

            this.btnViewReports.Size =
                new Size(125, 40);

            this.btnViewReports.Location =
                new Point(
                    860,
                    32);

            this.btnViewReports.Text =
                "View Issues";

            this.btnViewReports.Cursor =
                Cursors.Hand;

            this.btnViewReports.Click +=
                new EventHandler(
                    this.btnViewReports_Click);

            this.headerPanel.Controls.Add(
                this.headerTitleLabel);

            this.headerPanel.Controls.Add(
                this.headerSubtitleLabel);

            this.headerPanel.Controls.Add(
                this.btnViewReports);

            // ==========================================================
            // PROGRESS
            // ==========================================================

            this.progressPanel.BackColor =
                Color.White;

            this.progressPanel.Location =
                new Point(20, 140);

            this.progressPanel.Size =
                new Size(1010, 75);

            this.progressTitleLabel.AutoSize =
                true;

            this.progressTitleLabel.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.progressTitleLabel.ForeColor =
                Color.FromArgb(70, 78, 88);

            this.progressTitleLabel.Location =
                new Point(20, 12);

            this.progressTitleLabel.Text =
                "REPORTING PROGRESS";

            this.progressPercentLabel.AutoSize =
                true;

            this.progressPercentLabel.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.progressPercentLabel.ForeColor =
                Color.FromArgb(25, 118, 160);

            this.progressPercentLabel.Location =
                new Point(940, 12);

            this.progressPercentLabel.Text =
                "0%";

            this.reportingProgressBar.Location =
                new Point(20, 40);

            this.reportingProgressBar.Size =
                new Size(970, 12);

            this.reportingProgressBar.Minimum = 0;
            this.reportingProgressBar.Maximum = 100;
            this.reportingProgressBar.Value = 0;

            this.progressPanel.Controls.Add(
                this.progressTitleLabel);

            this.progressPanel.Controls.Add(
                this.progressPercentLabel);

            this.progressPanel.Controls.Add(
                this.reportingProgressBar);

            // ==========================================================
            // DETAILS
            // ==========================================================

            this.detailsPanel.BackColor =
                Color.White;

            this.detailsPanel.Location =
                new Point(20, 235);

            this.detailsPanel.Size =
                new Size(490, 350);

            this.detailsTitleLabel.AutoSize = true;

            this.detailsTitleLabel.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            this.detailsTitleLabel.ForeColor =
                Color.FromArgb(40, 48, 58);

            this.detailsTitleLabel.Location =
                new Point(25, 20);

            this.detailsTitleLabel.Text =
                "Issue Details";

            // Title

            this.titleLabel.AutoSize = true;

            this.titleLabel.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.titleLabel.ForeColor =
                Color.FromArgb(90, 98, 108);

            this.titleLabel.Location =
                new Point(25, 65);

            this.titleLabel.Text =
                "Issue title";

            this.titleTextBox.Font =
                new Font(
                    "Segoe UI",
                    11F);

            this.titleTextBox.Location =
                new Point(25, 88);

            this.titleTextBox.Size =
                new Size(440, 32);

            this.titleTextBox.BorderStyle =
                BorderStyle.FixedSingle;

            this.titleTextBox.MaxLength = 50;

            // Location

            this.locationLabel.AutoSize = true;

            this.locationLabel.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.locationLabel.ForeColor =
                Color.FromArgb(90, 98, 108);

            this.locationLabel.Location =
                new Point(25, 135);

            this.locationLabel.Text =
                "Location";

            this.locationTextBox.Font =
                new Font(
                    "Segoe UI",
                    11F);

            this.locationTextBox.Location =
                new Point(25, 158);

            this.locationTextBox.Size =
                new Size(440, 32);

            this.locationTextBox.BorderStyle =
                BorderStyle.FixedSingle;

            this.locationTextBox.MaxLength = 50;

            // Service

            this.serviceTypeLabel.AutoSize = true;

            this.serviceTypeLabel.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.serviceTypeLabel.ForeColor =
                Color.FromArgb(90, 98, 108);

            this.serviceTypeLabel.Location =
                new Point(25, 205);

            this.serviceTypeLabel.Text =
                "Service category";

            this.serviceTypeComboBox.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.serviceTypeComboBox.Font =
                new Font(
                    "Segoe UI",
                    11F);

            this.serviceTypeComboBox.Location =
                new Point(25, 228);

            this.serviceTypeComboBox.Size =
                new Size(440, 33);

            this.serviceTypeComboBox.Items.AddRange(
                new object[]
                {
                    "Roads",
                    "Sanitation",
                    "Utilities"
                });

            this.serviceTypeComboBox.SelectedIndex = -1;

            this.detailsPanel.Controls.Add(
                this.detailsTitleLabel);

            this.detailsPanel.Controls.Add(
                this.titleLabel);

            this.detailsPanel.Controls.Add(
                this.titleTextBox);

            this.detailsPanel.Controls.Add(
                this.locationLabel);

            this.detailsPanel.Controls.Add(
                this.locationTextBox);

            this.detailsPanel.Controls.Add(
                this.serviceTypeLabel);

            this.detailsPanel.Controls.Add(
                this.serviceTypeComboBox);

            // ==========================================================
            // DESCRIPTION
            // ==========================================================

            this.descriptionPanel.BackColor =
                Color.White;

            this.descriptionPanel.Location =
                new Point(530, 235);

            this.descriptionPanel.Size =
                new Size(500, 350);

            this.descriptionTitleLabel.AutoSize =
                true;

            this.descriptionTitleLabel.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            this.descriptionTitleLabel.ForeColor =
                Color.FromArgb(40, 48, 58);

            this.descriptionTitleLabel.Location =
                new Point(25, 20);

            this.descriptionTitleLabel.Text =
                "Describe the Issue";

            this.descriptionTextBox.Font =
                new Font(
                    "Segoe UI",
                    10.5F);

            this.descriptionTextBox.Location =
                new Point(25, 65);

            this.descriptionTextBox.Size =
                new Size(450, 255);

            this.descriptionTextBox.BorderStyle =
                BorderStyle.FixedSingle;

            this.descriptionTextBox.ScrollBars =
                RichTextBoxScrollBars.Vertical;

            this.descriptionTextBox.WordWrap = true;

            this.descriptionPanel.Controls.Add(
                this.descriptionTitleLabel);

            this.descriptionPanel.Controls.Add(
                this.descriptionTextBox);

            // ==========================================================
            // ATTACHMENT
            // ==========================================================

            this.attachmentPanel.BackColor =
                Color.White;

            this.attachmentPanel.Location =
                new Point(20, 605);

            this.attachmentPanel.Size =
                new Size(490, 260);

            this.attachmentTitleLabel.AutoSize =
                true;

            this.attachmentTitleLabel.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            this.attachmentTitleLabel.ForeColor =
                Color.FromArgb(40, 48, 58);

            this.attachmentTitleLabel.Location =
                new Point(25, 20);

            this.attachmentTitleLabel.Text =
                "Supporting Evidence";

            // Upload button

            this.uploadFileButton.BackColor =
                Color.FromArgb(25, 118, 160);

            this.uploadFileButton.FlatStyle =
                FlatStyle.Flat;

            this.uploadFileButton.FlatAppearance.BorderSize =
                0;

            this.uploadFileButton.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.uploadFileButton.ForeColor =
                Color.White;

            this.uploadFileButton.Location =
                new Point(25, 65);

            this.uploadFileButton.Size =
                new Size(440, 50);

            this.uploadFileButton.Text =
                "＋   Upload Supporting File";

            this.uploadFileButton.Cursor =
                Cursors.Hand;

            this.uploadFileButton.Enabled =
                false;

            this.uploadFileButton.Click +=
                new EventHandler(
                    this.uploadFileButton_Click);

            // File label

            this.fileNameLabel.AutoSize =
                true;

            this.fileNameLabel.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.fileNameLabel.ForeColor =
                Color.FromArgb(90, 98, 108);

            this.fileNameLabel.Location =
                new Point(25, 135);

            this.fileNameLabel.Text =
                "Selected file:";

            this.fileNameTxt.AutoEllipsis =
                true;

            this.fileNameTxt.Font =
                new Font(
                    "Segoe UI",
                    9F);

            this.fileNameTxt.ForeColor =
                Color.FromArgb(25, 118, 160);

            this.fileNameTxt.Location =
                new Point(25, 160);

            this.fileNameTxt.Size =
                new Size(440, 40);

            this.fileNameTxt.Text =
                "No file selected";

            this.fileLabel.Visible = false;

            this.attachmentPanel.Controls.Add(
                this.attachmentTitleLabel);

            this.attachmentPanel.Controls.Add(
                this.uploadFileButton);

            this.attachmentPanel.Controls.Add(
                this.fileNameLabel);

            this.attachmentPanel.Controls.Add(
                this.fileNameTxt);

            this.attachmentPanel.Controls.Add(
                this.fileLabel);

            // ==========================================================
            // PREVIEW
            // ==========================================================

            this.previewPanel.BackColor =
                Color.White;

            this.previewPanel.Location =
                new Point(530, 605);

            this.previewPanel.Size =
                new Size(500, 260);

            this.previewTitleLabel.AutoSize =
                true;

            this.previewTitleLabel.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            this.previewTitleLabel.ForeColor =
                Color.FromArgb(40, 48, 58);

            this.previewTitleLabel.Location =
                new Point(25, 20);

            this.previewTitleLabel.Text =
                "Image Preview";

            this.pbxImage.BackColor =
                Color.FromArgb(245, 247, 250);

            this.pbxImage.BorderStyle =
                BorderStyle.FixedSingle;

            this.pbxImage.Location =
                new Point(25, 60);

            this.pbxImage.Size =
                new Size(450, 175);

            this.pbxImage.SizeMode =
                PictureBoxSizeMode.Zoom;

            this.pbxImage.Visible = false;

            this.previewPlaceholderLabel.AutoSize =
                false;

            this.previewPlaceholderLabel.Text =
                "No image selected";

            this.previewPlaceholderLabel.TextAlign =
                ContentAlignment.MiddleCenter;

            this.previewPlaceholderLabel.Font =
                new Font(
                    "Segoe UI",
                    9F);

            this.previewPlaceholderLabel.ForeColor =
                Color.Gray;

            this.previewPlaceholderLabel.BackColor =
                Color.FromArgb(245, 247, 250);

            this.previewPlaceholderLabel.Location =
                new Point(25, 60);

            this.previewPlaceholderLabel.Size =
                new Size(450, 175);

            this.previewPanel.Controls.Add(
                this.previewTitleLabel);

            this.previewPanel.Controls.Add(
                this.pbxImage);

            this.previewPanel.Controls.Add(
                this.previewPlaceholderLabel);

            // ==========================================================
            // FOOTER
            // ==========================================================

            this.footerPanel.BackColor =
                Color.FromArgb(245, 247, 250);

            this.footerPanel.Location =
                new Point(20, 885);

            this.footerPanel.Size =
                new Size(1010, 80);

            // Submit

            this.submitButton.BackColor =
                Color.FromArgb(25, 118, 160);

            this.submitButton.FlatStyle =
                FlatStyle.Flat;

            this.submitButton.FlatAppearance.BorderSize =
                0;

            this.submitButton.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.submitButton.ForeColor =
                Color.White;

            this.submitButton.Size =
                new Size(160, 45);

            this.submitButton.Location =
                new Point(515, 15);

            this.submitButton.Text =
                "Submit Report";

            this.submitButton.Cursor =
                Cursors.Hand;

            this.submitButton.Enabled =
                false;

            this.submitButton.Click +=
                new EventHandler(
                    this.submitButton_Click);

            // Cancel

            this.cancelButton.BackColor =
                Color.White;

            this.cancelButton.FlatStyle =
                FlatStyle.Flat;

            this.cancelButton.FlatAppearance.BorderColor =
                Color.FromArgb(210, 215, 220);

            this.cancelButton.Font =
                new Font(
                    "Segoe UI",
                    10F);

            this.cancelButton.ForeColor =
                Color.FromArgb(70, 78, 88);

            this.cancelButton.Size =
                new Size(120, 45);

            this.cancelButton.Location =
                new Point(685, 15);

            this.cancelButton.Text =
                "Cancel";

            this.cancelButton.Cursor =
                Cursors.Hand;

            this.cancelButton.Click +=
                new EventHandler(
                    this.cancelButton_Click);

            this.footerPanel.Controls.Add(
                this.submitButton);

            this.footerPanel.Controls.Add(
                this.cancelButton);

            // ==========================================================
            // ADD EVERYTHING TO CONTENT PANEL
            // ==========================================================

            this.contentPanel.Controls.Add(
                this.headerPanel);

            this.contentPanel.Controls.Add(
                this.progressPanel);

            this.contentPanel.Controls.Add(
                this.detailsPanel);

            this.contentPanel.Controls.Add(
                this.descriptionPanel);

            this.contentPanel.Controls.Add(
                this.attachmentPanel);

            this.contentPanel.Controls.Add(
                this.previewPanel);

            this.contentPanel.Controls.Add(
                this.footerPanel);

            // ==========================================================
            // SCROLL PANEL
            // ==========================================================

            this.scrollPanel.Controls.Add(
                this.contentPanel);

            // ==========================================================
            // MAIN PANEL
            // ==========================================================

            this.mainPanel.Controls.Add(
                this.scrollPanel);

            this.Controls.Add(
                this.mainPanel);

            // ==========================================================
            // FORM
            // ==========================================================

            this.AutoScaleDimensions =
                new SizeF(8F, 20F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.ClientSize =
                new Size(1100, 750);

            this.MinimumSize =
                new Size(800, 600);

            this.BackColor =
                Color.FromArgb(245, 247, 250);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "Municipal Services - Report Issue";

            this.FormBorderStyle =
                FormBorderStyle.Sizable;

            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.Load +=
                new EventHandler(
                    this.ServiceRequestForm_Load);

            // ==========================================================

            ((System.ComponentModel.ISupportInitialize)
                (this.pbxImage)).EndInit();

            this.footerPanel.ResumeLayout(false);

            this.previewPanel.ResumeLayout(false);
            this.previewPanel.PerformLayout();

            this.attachmentPanel.ResumeLayout(false);
            this.attachmentPanel.PerformLayout();

            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();

            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();

            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();

            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();

            this.contentPanel.ResumeLayout(false);

            this.scrollPanel.ResumeLayout(false);

            this.mainPanel.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel scrollPanel;
        private Panel contentPanel;

        private Panel headerPanel;
        private Label headerTitleLabel;
        private Label headerSubtitleLabel;
        private Button btnViewReports;

        private Panel progressPanel;
        private Label progressTitleLabel;
        private Label progressPercentLabel;
        private ProgressBar reportingProgressBar;

        private Panel detailsPanel;
        private Label detailsTitleLabel;

        private Label titleLabel;
        private TextBox titleTextBox;

        private Label locationLabel;
        private TextBox locationTextBox;

        private Label serviceTypeLabel;
        private ComboBox serviceTypeComboBox;

        private Panel descriptionPanel;
        private Label descriptionTitleLabel;
        private RichTextBox descriptionTextBox;

        private Panel attachmentPanel;
        private Label attachmentTitleLabel;
        private Button uploadFileButton;
        private Label fileNameLabel;
        private Label fileNameTxt;
        private Label fileLabel;

        private Panel previewPanel;
        private Label previewTitleLabel;
        private PictureBox pbxImage;
        private Label previewPlaceholderLabel;

        private Panel footerPanel;
        private Button submitButton;
        private Button cancelButton;
    }
}