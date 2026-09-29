using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using muni_class_library;
using municipality_app.Services;

namespace municipality_app
{
    public partial class PostAnnouncementForm : Form
    {
        private readonly AnnouncementServices _announcementService;

        public Announcement? CreatedAnnouncement { get; private set; }

        private bool _isSaving = false;

        public PostAnnouncementForm()
        {
            InitializeComponent();

            _announcementService =
                new AnnouncementServices();

            ConfigureForm();
        }

        // ============================================================
        // FORM CONFIGURATION
        // ============================================================

        private void ConfigureForm()
        {
            dtpAnnouncementDate.Value =
                DateTime.Today;

            dtpAnnouncementDate.MinDate =
                DateTime.Today;

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }

            txtTitle.MaxLength = 150;

            txtLocation.MaxLength = 200;

            txtDescription.MaxLength = 5000;

            btnSave.Enabled = true;

            btnCancel.Enabled = true;
        }

        // ============================================================
        // FORM LOAD
        // ============================================================

        private void PostAnnouncementForm_Load(
            object? sender,
            EventArgs e)
        {
            txtTitle.Focus();
        }

        // ============================================================
        // KEYBOARD SHORTCUTS
        // ============================================================

        private void PostAnnouncementForm_KeyDown(
            object? sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (!_isSaving)
                {
                    CloseFormWithoutSaving();

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        // ============================================================
        // SAVE ANNOUNCEMENT
        // ============================================================

        private async void btnSave_Click(
            object? sender,
            EventArgs e)
        {
            if (_isSaving)
            {
                return;
            }

            if (!ValidateAnnouncement())
            {
                return;
            }

            Announcement announcement =
                BuildAnnouncement();

            SetSavingState(true);

            try
            {
                CreatedAnnouncement =
                    await _announcementService
                        .CreateAnnouncementAsync(
                            announcement);

                MessageBox.Show(
                    "The announcement has been saved successfully.",
                    "Announcement Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult =
                    DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    GetFriendlyErrorMessage(ex),
                    "Unable to Save Announcement",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (!IsDisposed)
                {
                    SetSavingState(false);
                }
            }
        }

        // ============================================================
        // BUILD ANNOUNCEMENT
        // ============================================================

        private Announcement BuildAnnouncement()
        {
            /*
             * IMPORTANT:
             *
             * AnnouncementDate represents a calendar date rather
             * than a specific local time.
             *
             * Setting the DateTime Kind to UTC prevents the Azure
             * Table SDK from rejecting DateTimeKind.Local.
             *
             * This also preserves the selected calendar date.
             */

            DateTime selectedDate =
                dtpAnnouncementDate.Value.Date;

            DateTime utcDate =
                DateTime.SpecifyKind(
                    selectedDate,
                    DateTimeKind.Utc);

            Announcement announcement =
                new Announcement
                {
                    PartitionKey = "Announcements",

                    RowKey =
                        Guid.NewGuid().ToString(),

                    AnnouncementId =
                        GenerateAnnouncementId(),

                    Title =
                        txtTitle.Text.Trim(),

                    Description =
                        txtDescription.Text.Trim(),

                    Category =
                        cmbCategory.SelectedItem?
                            .ToString(),

                    AnnouncementDate =
                        utcDate,

                    Location =
                        txtLocation.Text.Trim()
                };

            return announcement;
        }

        // ============================================================
        // VALIDATION
        // ============================================================

        private bool ValidateAnnouncement()
        {
            string title =
                txtTitle.Text.Trim();

            string description =
                txtDescription.Text.Trim();

            string location =
                txtLocation.Text.Trim();

            string? category =
                cmbCategory.SelectedItem?
                    .ToString();

            if (string.IsNullOrWhiteSpace(title))
            {
                ShowValidationMessage(
                    "Please enter an announcement title.",
                    txtTitle);

                return false;
            }

            if (title.Length < 5)
            {
                ShowValidationMessage(
                    "The announcement title should contain at least 5 characters.",
                    txtTitle);

                return false;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show(
                    "Please select an announcement category.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                ShowValidationMessage(
                    "Please enter an announcement description.",
                    txtDescription);

                return false;
            }

            if (description.Length < 10)
            {
                ShowValidationMessage(
                    "The announcement description should contain at least 10 characters.",
                    txtDescription);

                return false;
            }

            if (string.IsNullOrWhiteSpace(location))
            {
                ShowValidationMessage(
                    "Please enter the announcement location.",
                    txtLocation);

                return false;
            }

            if (location.Length < 2)
            {
                ShowValidationMessage(
                    "Please enter a valid announcement location.",
                    txtLocation);

                return false;
            }

            return true;
        }

        // ============================================================
        // VALIDATION MESSAGE
        // ============================================================

        private void ShowValidationMessage(
            string message,
            Control control)
        {
            MessageBox.Show(
                message,
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            control.Focus();

            if (control is TextBox textBox)
            {
                textBox.SelectAll();
            }
        }

        // ============================================================
        // GENERATE ID
        // ============================================================

        private int GenerateAnnouncementId()
        {
            /*
             * A random positive integer is used because the current
             * Announcement model contains an AnnouncementId field.
             *
             * RowKey remains the unique Azure Table identifier.
             */

            return Random.Shared.Next(
                100000,
                999999999);
        }

        // ============================================================
        // SAVE STATE
        // ============================================================

        private void SetSavingState(
            bool saving)
        {
            _isSaving = saving;

            btnSave.Enabled =
                !saving;

            btnCancel.Enabled =
                !saving;

            txtTitle.Enabled =
                !saving;

            cmbCategory.Enabled =
                !saving;

            txtDescription.Enabled =
                !saving;

            dtpAnnouncementDate.Enabled =
                !saving;

            txtLocation.Enabled =
                !saving;

            if (saving)
            {
                btnSave.Text =
                    "Saving...";

                Cursor =
                    Cursors.WaitCursor;
            }
            else
            {
                btnSave.Text =
                    "Save Announcement";

                Cursor =
                    Cursors.Default;
            }
        }

 

        // ============================================================
        // CLOSE FORM
        // ============================================================

        private void CloseFormWithoutSaving()
        {
            DialogResult =
                DialogResult.Cancel;

            Close();
        }

        // ============================================================
        // ERROR HANDLING
        // ============================================================

        private string GetFriendlyErrorMessage(
            Exception exception)
        {
            Exception currentException =
                exception;

            while (currentException.InnerException != null)
            {
                currentException =
                    currentException.InnerException;
            }

            string message =
                currentException.Message;

            if (string.IsNullOrWhiteSpace(message))
            {
                return
                    "An unexpected error occurred while saving the announcement.";
            }

            return
                "The announcement could not be saved.\n\n" +
                message;
        }
    }
}