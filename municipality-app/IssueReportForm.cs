using muni_class_library;
using municipality_app.Services;
using System.Drawing;
using System.IO;

namespace municipality_app
{
    public partial class IssueReportForm : Form
    {
        
        public List<IssueReport> issueReports = new List<IssueReport>();

        public IssueStorageService reports = new IssueStorageService();

        public string filePath = string.Empty;

        private bool completionMessageShown = false;

        private bool isSubmitting = false;


        
        public IssueReportForm()
        {
            InitializeComponent();

            ConfigureForm();

            ConfigureEvents();

            InitializeFormState();
        }

        private void ConfigureForm()
        {
            

            this.BackColor = Color.FromArgb(245, 247, 250);

            this.Font = new Font("Segoe UI", 9F);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.FormBorderStyle =
                FormBorderStyle.Sizable;

            this.MinimumSize =
                new Size(800, 600);

            this.MaximizeBox = true;
            this.MinimizeBox = true;

            // --------------------------------------------------------
            // Scroll behaviour
            // --------------------------------------------------------

            if (scrollPanel != null)
            {
                scrollPanel.AutoScroll = true;

                scrollPanel.HorizontalScroll.Enabled = false;
                scrollPanel.HorizontalScroll.Visible = false;
            }

            // --------------------------------------------------------
            // Header styling
            // --------------------------------------------------------

            if (headerPanel != null)
            {
                headerPanel.BackColor =
                    Color.FromArgb(25, 118, 160);
            }

            // --------------------------------------------------------
            // Button styling
            // --------------------------------------------------------

            ConfigureButton(
                submitButton,
                Color.FromArgb(25, 118, 160),
                Color.White);

            ConfigureButton(
                uploadFileButton,
                Color.FromArgb(25, 118, 160),
                Color.White);

            ConfigureButton(
                cancelButton,
                Color.White,
                Color.FromArgb(70, 78, 88));

            ConfigureButton(
                btnViewReports,
                Color.White,
                Color.FromArgb(25, 118, 160));

            // --------------------------------------------------------
            // Description
            // --------------------------------------------------------

            if (descriptionTextBox != null)
            {
                descriptionTextBox.ScrollBars =
                    RichTextBoxScrollBars.Vertical;

                descriptionTextBox.WordWrap = true;
            }

            // --------------------------------------------------------
            // Image preview
            // --------------------------------------------------------

            if (pbxImage != null)
            {
                pbxImage.SizeMode =
                    PictureBoxSizeMode.Zoom;

                pbxImage.BackColor =
                    Color.FromArgb(245, 247, 250);
            }

            // --------------------------------------------------------
            // Placeholder
            // --------------------------------------------------------

            if (previewPlaceholderLabel != null)
            {
                previewPlaceholderLabel.Text =
                    "No image selected";

                previewPlaceholderLabel.TextAlign =
                    ContentAlignment.MiddleCenter;

                previewPlaceholderLabel.ForeColor =
                    Color.Gray;
            }
        }


        // ============================================================
        // BUTTON STYLING
        // ============================================================

        private void ConfigureButton(
            Button button,
            Color backgroundColor,
            Color foregroundColor)
        {
            if (button == null)
                return;

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;

            button.BackColor =
                backgroundColor;

            button.ForeColor =
                foregroundColor;

            button.Cursor =
                Cursors.Hand;
        }


        // ============================================================
        // EVENTS
        // ============================================================

        private void ConfigureEvents()
        {
            // --------------------------------------------------------
            // Text fields
            // --------------------------------------------------------

            locationTextBox.TextChanged +=
                (s, e) => UpdateProgressBar();

            titleTextBox.TextChanged +=
                (s, e) => UpdateProgressBar();

            descriptionTextBox.TextChanged +=
                (s, e) => UpdateProgressBar();

            // --------------------------------------------------------
            // Service category
            // --------------------------------------------------------

            serviceTypeComboBox.SelectedIndexChanged +=
                (s, e) => UpdateProgressBar();

            // --------------------------------------------------------
            // Form resize
            // --------------------------------------------------------

            this.Resize +=
                IssueReportForm_Resize;

            // --------------------------------------------------------
            // Button hover effects
            // --------------------------------------------------------

            AddButtonHoverEffect(
                submitButton,
                Color.FromArgb(25, 118, 160),
                Color.FromArgb(20, 92, 125));

            AddButtonHoverEffect(
                uploadFileButton,
                Color.FromArgb(25, 118, 160),
                Color.FromArgb(20, 92, 125));

            AddButtonHoverEffect(
                cancelButton,
                Color.White,
                Color.FromArgb(235, 238, 241));

            AddButtonHoverEffect(
                btnViewReports,
                Color.White,
                Color.FromArgb(235, 238, 241));
        }


        // ============================================================
        // BUTTON HOVER EFFECT
        // ============================================================

        private void AddButtonHoverEffect(
            Button button,
            Color normalColor,
            Color hoverColor)
        {
            if (button == null)
                return;

            button.MouseEnter +=
                (s, e) =>
                {
                    if (button.Enabled)
                    {
                        button.BackColor =
                            hoverColor;
                    }
                };

            button.MouseLeave +=
                (s, e) =>
                {
                    if (button.Enabled)
                    {
                        button.BackColor =
                            normalColor;
                    }
                };
        }


        // ============================================================
        // INITIAL FORM STATE
        // ============================================================

        private void InitializeFormState()
        {
            // --------------------------------------------------------
            // Text fields
            // --------------------------------------------------------

            titleTextBox.Clear();

            locationTextBox.Clear();

            descriptionTextBox.Clear();

            // --------------------------------------------------------
            // Category
            // --------------------------------------------------------

            serviceTypeComboBox.SelectedIndex = -1;

            // --------------------------------------------------------
            // File information
            // --------------------------------------------------------

            fileNameTxt.Text =
                "No file selected";

            fileLabel.Text =
                string.Empty;

            filePath =
                string.Empty;

            // --------------------------------------------------------
            // Buttons
            // --------------------------------------------------------

            uploadFileButton.Enabled =
                false;

            submitButton.Enabled =
                false;

            // --------------------------------------------------------
            // Image
            // --------------------------------------------------------

            ClearImagePreview();

            // --------------------------------------------------------
            // Progress
            // --------------------------------------------------------

            reportingProgressBar.Minimum = 0;

            reportingProgressBar.Maximum = 100;

            reportingProgressBar.Value = 0;

            progressPercentLabel.Text =
                "0%";

            completionMessageShown = false;

            isSubmitting = false;

            // --------------------------------------------------------
            // Resize UI
            // --------------------------------------------------------

            IssueReportForm_Resize(
                this,
                EventArgs.Empty);

            UpdateProgressBar();
        }


        // ============================================================
        // FORM RESIZE
        // ============================================================

        private void IssueReportForm_Resize(
            object? sender,
            EventArgs e)
        {
            try
            {
                // ----------------------------------------------------
                // Keep content width responsive
                // ----------------------------------------------------

                if (scrollPanel != null &&
                    contentPanel != null)
                {
                    int availableWidth =
                        scrollPanel.ClientSize.Width;

                    if (availableWidth > 850)
                    {
                        contentPanel.Width =
                            availableWidth;
                    }
                    else
                    {
                        contentPanel.Width =
                            1050;
                    }
                }

                // ----------------------------------------------------
                // Header View Issues button
                // ----------------------------------------------------

                if (headerPanel != null &&
                    btnViewReports != null)
                {
                    btnViewReports.Left =
                        headerPanel.ClientSize.Width -
                        btnViewReports.Width -
                        25;
                }

                // ----------------------------------------------------
                // Progress percentage
                // ----------------------------------------------------

                if (progressPanel != null &&
                    progressPercentLabel != null)
                {
                    progressPercentLabel.Left =
                        progressPanel.ClientSize.Width -
                        progressPercentLabel.Width -
                        20;
                }

                // ----------------------------------------------------
                // Make the two-column cards responsive
                // ----------------------------------------------------

                if (contentPanel != null)
                {
                    int width =
                        contentPanel.ClientSize.Width;

                    if (width < 900)
                    {
                        // On smaller windows, keep the cards at
                        // their minimum usable width.
                        width = 900;
                    }

                    int horizontalPadding = 40;

                    int available =
                        width - horizontalPadding;

                    int cardWidth =
                        (available - 20) / 2;

                    if (cardWidth < 400)
                        cardWidth = 400;

                    // Details

                    if (detailsPanel != null)
                    {
                        detailsPanel.Width =
                            cardWidth;
                    }

                    // Description

                    if (descriptionPanel != null)
                    {
                        descriptionPanel.Left =
                            detailsPanel.Left +
                            detailsPanel.Width +
                            20;

                        descriptionPanel.Width =
                            cardWidth;
                    }

                    // Attachment

                    if (attachmentPanel != null)
                    {
                        attachmentPanel.Width =
                            cardWidth;
                    }

                    // Preview

                    if (previewPanel != null)
                    {
                        previewPanel.Left =
                            attachmentPanel.Left +
                            attachmentPanel.Width +
                            20;

                        previewPanel.Width =
                            cardWidth;
                    }
                }

                // ----------------------------------------------------
                // Refresh
                // ----------------------------------------------------

                contentPanel?.PerformLayout();
            }
            catch
            {
                // Ignore resize errors while controls are initializing
            }
        }


        // ============================================================
        // PROGRESS BAR
        // ============================================================

        public void UpdateProgressBar()
        {
            if (reportingProgressBar == null)
                return;

            int progress = 0;

            // --------------------------------------------------------
            // Title = 20%
            // --------------------------------------------------------

            if (!string.IsNullOrWhiteSpace(
                titleTextBox.Text))
            {
                progress += 20;
            }

            // --------------------------------------------------------
            // Location = 20%
            // --------------------------------------------------------

            if (!string.IsNullOrWhiteSpace(
                locationTextBox.Text))
            {
                progress += 20;
            }

            // --------------------------------------------------------
            // Description = 20%
            // --------------------------------------------------------

            if (!string.IsNullOrWhiteSpace(
                descriptionTextBox.Text))
            {
                progress += 20;
            }

            // --------------------------------------------------------
            // Service category = 20%
            // --------------------------------------------------------

            if (serviceTypeComboBox.SelectedIndex >= 0)
            {
                progress += 20;
            }

            // --------------------------------------------------------
            // File = 20%
            // --------------------------------------------------------

            bool fileSelected =
                !string.IsNullOrWhiteSpace(
                    fileNameTxt.Text)
                &&
                fileNameTxt.Text !=
                    "No file selected";

            if (fileSelected)
            {
                progress += 20;
            }

            // --------------------------------------------------------
            // Protect progress value
            // --------------------------------------------------------

            progress =
                Math.Max(0, Math.Min(100, progress));

            reportingProgressBar.Value =
                progress;

            // --------------------------------------------------------
            // Percentage
            // --------------------------------------------------------

            progressPercentLabel.Text =
                $"{progress}%";

            // --------------------------------------------------------
            // Determine if basic information is complete
            // --------------------------------------------------------

            bool basicInformationComplete =
                !string.IsNullOrWhiteSpace(
                    titleTextBox.Text)
                &&
                !string.IsNullOrWhiteSpace(
                    locationTextBox.Text)
                &&
                !string.IsNullOrWhiteSpace(
                    descriptionTextBox.Text)
                &&
                serviceTypeComboBox.SelectedIndex >= 0;

            // --------------------------------------------------------
            // Enable upload
            // --------------------------------------------------------

            uploadFileButton.Enabled =
                basicInformationComplete &&
                !isSubmitting;

            // --------------------------------------------------------
            // Enable submit
            // --------------------------------------------------------

            submitButton.Enabled =
                progress == 100 &&
                !isSubmitting;

            // --------------------------------------------------------
            // Completion message
            // --------------------------------------------------------

            if (progress == 100 &&
                !completionMessageShown)
            {
                completionMessageShown = true;

                MessageBox.Show(
                    "Congratulations!\n\n" +
                    "Your report is complete and ready to be submitted.",
                    "Report Ready",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            if (progress < 100)
            {
                completionMessageShown = false;
            }
        }


        // ============================================================
        // FORM LOAD
        // ============================================================

        private void ServiceRequestForm_Load(
            object? sender,
            EventArgs e)
        {
            IssueReportForm_Resize(
                this,
                EventArgs.Empty);

            UpdateProgressBar();
        }


        // ============================================================
        // SUBMIT REPORT
        // ============================================================

        private async void submitButton_Click(object? sender, EventArgs e)
        {
           
            if (isSubmitting)
                return;

            if (!ValidateForm())
                return;

            try
            {
                isSubmitting = true;

                submitButton.Enabled = false;

                uploadFileButton.Enabled = false;

                submitButton.Text =
                    "Submitting...";

                Cursor = Cursors.WaitCursor;

                IssueEntity issueEntity =
                    new IssueEntity()
                    {
                        PartitionKey = "issues",
                        RowKey = Guid.NewGuid().ToString(),
                        Title = titleTextBox.Text.Trim(),
                        Location = locationTextBox.Text.Trim(),
                        Description = descriptionTextBox.Text.Trim(),
                        FilePath = fileLabel.Text,
                        IssueCategory = serviceTypeComboBox.Text
                    };


                await reports.CreateIssueAsync(issueEntity);

                MessageBox.Show(
                    "Your issue has been successfully submitted.\n\n" +
                    "Thank you for helping improve your community.",
                    "Report Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

               
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to submit the issue.\n\n" +
                    ex.Message,
                    "Submission Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                isSubmitting = false;

                Cursor =
                    Cursors.Default;

                submitButton.Text =
                    "Submit Report";

                UpdateProgressBar();
            }
        }


        // ============================================================
        // VALIDATE FORM
        // ============================================================

        private bool ValidateForm()
        {
            // --------------------------------------------------------
            // Title
            // --------------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                titleTextBox.Text))
            {
                MessageBox.Show(
                    "Please enter a title for the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                titleTextBox.Focus();

                return false;
            }

            // --------------------------------------------------------
            // Location
            // --------------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                locationTextBox.Text))
            {
                MessageBox.Show(
                    "Please enter the location of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                locationTextBox.Focus();

                return false;
            }

            // --------------------------------------------------------
            // Description
            // --------------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                descriptionTextBox.Text))
            {
                MessageBox.Show(
                    "Please describe the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                descriptionTextBox.Focus();

                return false;
            }

            // --------------------------------------------------------
            // Category
            // --------------------------------------------------------

            if (serviceTypeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a service category:\n\n" +
                    "• Roads\n" +
                    "• Sanitation\n" +
                    "• Utilities",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                serviceTypeComboBox.Focus();

                return false;
            }

            // --------------------------------------------------------
            // File
            // --------------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                fileNameTxt.Text)
                ||
                fileNameTxt.Text ==
                    "No file selected")
            {
                MessageBox.Show(
                    "Please upload supporting evidence before submitting your report.",
                    "Attachment Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                uploadFileButton.Focus();

                return false;
            }

            return true;
        }


        // ============================================================
        // RESET FORM
        // ============================================================

        private void ResetForm()
        {
            // --------------------------------------------------------
            // Clear text
            // --------------------------------------------------------

            titleTextBox.Clear();

            locationTextBox.Clear();

            descriptionTextBox.Clear();

            // --------------------------------------------------------
            // Reset category
            // --------------------------------------------------------

            serviceTypeComboBox.SelectedIndex =
                -1;

            // --------------------------------------------------------
            // Reset file
            // --------------------------------------------------------

            fileNameTxt.Text =
                "No file selected";

            fileLabel.Text =
                string.Empty;

            filePath =
                string.Empty;

            // --------------------------------------------------------
            // Reset image
            // --------------------------------------------------------

            ClearImagePreview();

            // --------------------------------------------------------
            // Reset progress
            // --------------------------------------------------------

            reportingProgressBar.Value =
                0;

            progressPercentLabel.Text =
                "0%";

            // --------------------------------------------------------
            // Reset buttons
            // --------------------------------------------------------

            uploadFileButton.Enabled =
                false;

            submitButton.Enabled =
                false;

            // --------------------------------------------------------
            // Reset state
            // --------------------------------------------------------

            completionMessageShown =
                false;

            isSubmitting =
                false;

            // --------------------------------------------------------
            // Scroll back to top
            // --------------------------------------------------------

            if (scrollPanel != null)
            {
                scrollPanel.AutoScrollPosition =
                    new Point(0, 0);
            }

            UpdateProgressBar();
        }


        // ============================================================
        // CLEAR IMAGE PREVIEW
        // ============================================================

        private void ClearImagePreview()
        {
            if (pbxImage == null)
                return;

            if (pbxImage.Image != null)
            {
                Image oldImage =
                    pbxImage.Image;

                pbxImage.Image =
                    null;

                oldImage.Dispose();
            }

            pbxImage.Visible =
                false;

            if (previewPlaceholderLabel != null)
            {
                previewPlaceholderLabel.Visible =
                    true;
            }
        }

        private void uploadFileButton_Click(object? sender,EventArgs e)
        {
            if (isSubmitting)
                return;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter =
                    "Supported Files (*.doc;*.docx;*.txt;*.pdf;*.png;*.jpg;*.jpeg)|" +
                    "*.doc;*.docx;*.txt;*.pdf;*.png;*.jpg;*.jpeg";

                openFileDialog.Title = "Select Supporting Evidence";

                openFileDialog.Multiselect = false;

                openFileDialog.CheckFileExists =true;

                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string sourcePath = openFileDialog.FileName;

               
                string extension =
                    Path.GetExtension(sourcePath)
                    .ToLowerInvariant();

                string[] allowedExtensions =
                {
                    ".doc",
                    ".docx",
                    ".txt",
                    ".pdf",
                    ".png",
                    ".jpg",
                    ".jpeg"
                };

                if (!allowedExtensions.Contains(
                    extension))
                {
                    MessageBox.Show(
                        "Invalid file type.\n\n" +
                        "Supported file types are:\n" +
                        "DOC, DOCX, TXT, PDF, PNG, JPG and JPEG.",
                        "Invalid File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // ----------------------------------------------------
                // Create Uploads folder
                // ----------------------------------------------------

                string destinationFolder =
                    Path.Combine(
                        Application.StartupPath,
                        "Uploads");

                try
                {
                    Directory.CreateDirectory(
                        destinationFolder);

                    // ------------------------------------------------
                    // Get filename
                    // ------------------------------------------------

                    string originalFileName =
                        Path.GetFileName(sourcePath);

                    // ------------------------------------------------
                    // Prevent invalid path characters
                    // ------------------------------------------------

                    string safeFileName =
                        SanitizeFileName(
                            originalFileName);

                    string destinationPath =
                        Path.Combine(
                            destinationFolder,
                            safeFileName);

                    // ------------------------------------------------
                    // Avoid accidentally locking source file
                    // ------------------------------------------------

                    File.Copy(
                        sourcePath,
                        destinationPath,
                        true);

                    // ------------------------------------------------
                    // Store file path
                    // ------------------------------------------------

                    filePath =
                        destinationPath;

                    fileLabel.Text =
                        destinationPath;

                    fileNameTxt.Text =
                        safeFileName;

                    // ------------------------------------------------
                    // Image preview
                    // ------------------------------------------------

                    if (IsImageExtension(extension))
                    {
                        LoadImagePreview(
                            destinationPath);
                    }
                    else
                    {
                        ClearImagePreview();
                    }

                    // ------------------------------------------------
                    // Update progress
                    // ------------------------------------------------

                    UpdateProgressBar();

                    // ------------------------------------------------
                    // Success
                    // ------------------------------------------------

                    MessageBox.Show(
                        $"File added successfully.\n\n{safeFileName}",
                        "File Added",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show(
                        "The application does not have permission to save the selected file.\n\n" +
                        "Please check the application's folder permissions.",
                        "Access Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(
                        "The file could not be copied.\n\n" +
                        ex.Message,
                        "File Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An unexpected error occurred while uploading the file.\n\n" +
                        ex.Message,
                        "Upload Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        // ============================================================
        // IMAGE EXTENSION CHECK
        // ============================================================

        private bool IsImageExtension(
            string extension)
        {
            return extension == ".png"
                || extension == ".jpg"
                || extension == ".jpeg";
        }


        // ============================================================
        // LOAD IMAGE PREVIEW
        // ============================================================

        private void LoadImagePreview(
            string imagePath)
        {
            try
            {
                // ----------------------------------------------------
                // Remove old image
                // ----------------------------------------------------

                if (pbxImage.Image != null)
                {
                    Image oldImage =
                        pbxImage.Image;

                    pbxImage.Image =
                        null;

                    oldImage.Dispose();
                }

                // ----------------------------------------------------
                // Load image without locking the file
                // ----------------------------------------------------

                using (FileStream stream =
                       new FileStream(
                           imagePath,
                           FileMode.Open,
                           FileAccess.Read,
                           FileShare.Read))
                {
                    using (Image temporaryImage =
                           Image.FromStream(stream))
                    {
                        pbxImage.Image =
                            new Bitmap(
                                temporaryImage);
                    }
                }

                // ----------------------------------------------------
                // Show image
                // ----------------------------------------------------

                pbxImage.SizeMode =
                    PictureBoxSizeMode.Zoom;

                pbxImage.Visible =
                    true;

                previewPlaceholderLabel.Visible =
                    false;
            }
            catch (Exception ex)
            {
                pbxImage.Visible =
                    false;

                previewPlaceholderLabel.Visible =
                    true;

                MessageBox.Show(
                    "The file was uploaded, but the image preview could not be displayed.\n\n" +
                    ex.Message,
                    "Preview Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        // ============================================================
        // SANITIZE FILE NAME
        // ============================================================

        private string SanitizeFileName(
            string fileName)
        {
            foreach (char invalidChar in
                     Path.GetInvalidFileNameChars())
            {
                fileName =
                    fileName.Replace(
                        invalidChar,
                        '_');
            }

            return fileName;
        }


        // ============================================================
        // CANCEL
        // ============================================================

        private void cancelButton_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to leave this report?\n\n" +
                    "Any information you entered will be lost.",
                    "Cancel Report",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result ==
                DialogResult.Yes)
            {
                Close();
            }
        }


        // ============================================================
        // VIEW ISSUES
        // ============================================================

        private void btnViewReports_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                ViewIssuesForm viewIssuesForm =
                    new ViewIssuesForm();

                viewIssuesForm.StartPosition =
                    FormStartPosition.CenterScreen;

                viewIssuesForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to open the issues list.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // CLEANUP
        // ============================================================

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            // --------------------------------------------------------
            // Dispose image
            // --------------------------------------------------------

            if (pbxImage != null &&
                pbxImage.Image != null)
            {
                Image image =
                    pbxImage.Image;

                pbxImage.Image =
                    null;

                image.Dispose();
            }

            base.OnFormClosed(e);
        }
    }
}