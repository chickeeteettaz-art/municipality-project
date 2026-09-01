using MaterialSkin;
using MaterialSkin.Controls;
using muni_class_library;
using System;
using System.IO;                          // ← needed for Path, Directory, File
using System.Windows.Forms;

namespace municipality_app
{
    public partial class IssueReportForm : MaterialForm
    {
       public List<IssueReport> issueReports = new List<IssueReport>();
        public string filePath = "";
        public IssueReportForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue500,
                Primary.LightBlue700,
                Primary.LightBlue300,
                Accent.LightBlue200,
                TextShade.WHITE);

            // Attach events so the progress bar updates while the user types / selects
            locationTextBox.TextChanged += (s, e) => UpdateProgressBar();
            titleTextBox.TextChanged += (s, e) => UpdateProgressBar();
            descriptionTextBox.TextChanged += (s, e) => UpdateProgressBar();
            serviceTypeComboBox.SelectedIndexChanged += (s, e) => UpdateProgressBar();  // better than TextChanged for ComboBox

            //prevent the user from submitting the form until all required fields are filled
            uploadFileButton.Enabled = false;

            
        }


        public void UpdateProgressBar()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(locationTextBox.Text))
                progress += 20;

            if (!string.IsNullOrWhiteSpace(titleTextBox.Text))
                progress += 20;

            if (!string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                progress += 20;
                uploadFileButton.Enabled = true;  // Enable the upload button when description is filled
            }
                

            if (!string.IsNullOrWhiteSpace(serviceTypeComboBox.Text))
                progress += 20;

            // File is considered filled when a real filename is present
            if (!string.IsNullOrWhiteSpace(fileNameTxt.Text) && fileNameTxt.Text != "file.ex")
                progress += 20;

            reportingProgressBar.Value = progress;
            if (reportingProgressBar.Value == 100)
            {
                submitButton.Enabled = true;
                MessageBox.Show($"Congradulations! You have completed the form.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        private void ServiceRequestForm_Load(object sender, EventArgs e)
        {
            // Optional: set initial progress
            UpdateProgressBar();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            IssueReport issue = new IssueReport()
            {
                IssueId = Guid.NewGuid().ToString(),
                Title = titleTextBox.Text,
                Location = locationTextBox.Text,
                Description = descriptionTextBox.Text,
                FilePath = fileLabel.Text,
                IssueCategory = serviceTypeComboBox.Text,
            };
            
            issueReports.Add(issue);

            MessageBox.Show($"You have successfully submitted the form.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

            titleTextBox.Text = string.Empty;
            locationTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            fileLabel.Text = string.Empty;

            uploadFileButton.Enabled = false;
            serviceTypeComboBox.Text = string.Empty;
            fileNameTxt.Text = "file.ex";
            pbxImage.Image = null;
            reportingProgressBar.Value = 20;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Only allow supported file types
                openFileDialog.Filter =
                    "Supported Files (*.doc;*.docx;*.txt;*.pdf;*.png;*.jpg;*.jpeg)|" +
                    "*.doc;*.docx;*.txt;*.pdf;*.png;*.jpg;*.jpeg";

                openFileDialog.Title = "Select a file to upload";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                string sourcePath = openFileDialog.FileName;

                // Double-check the extension
                string extension = Path.GetExtension(sourcePath).ToLowerInvariant();

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

                if (!allowedExtensions.Contains(extension))
                {
                    MessageBox.Show(
                        "Invalid file type. Please select a DOC, DOCX, TXT, PDF, PNG, JPG, or JPEG file.",
                        "Invalid File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string destinationFolder = Path.Combine(
                    Application.StartupPath,
                    "Uploads");

                try
                {
                    Directory.CreateDirectory(destinationFolder);

                    string fileName = Path.GetFileName(sourcePath);
                    string destinationPath = Path.Combine(
                        destinationFolder,
                        fileName);

                    // Copy the file
                    File.Copy(
                        sourcePath,
                        destinationPath,
                        overwrite: true);

                    // Update UI
                    fileNameTxt.Text = fileName;
                    fileLabel.Text = destinationPath;

                    // If the file is an image, display it
                    if (extension == ".png" ||
                        extension == ".jpg" ||
                        extension == ".jpeg")
                    {
                        // Dispose the previous image to prevent memory leaks
                        if (pbxImage.Image != null)
                        {
                            pbxImage.Image.Dispose();
                            pbxImage.Image = null;
                        }

                        // Load a copy of the image so the file isn't locked
                        using (FileStream stream = new FileStream(
                            destinationPath,
                            FileMode.Open,
                            FileAccess.Read))
                        {
                            using (Image tempImage = Image.FromStream(stream))
                            {
                                pbxImage.Image = new Bitmap(tempImage);
                            }
                        }

                        // Stretch the image to fit the PictureBox
                        pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        // Clear the PictureBox for non-image files
                        if (pbxImage.Image != null)
                        {
                            pbxImage.Image.Dispose();
                            pbxImage.Image = null;
                        }
                    }

                    // Recalculate progress
                    UpdateProgressBar();

                    MessageBox.Show(
                        $"File uploaded successfully to:\n{destinationPath}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error uploading file:\n{ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            // empty
        }
    }
}