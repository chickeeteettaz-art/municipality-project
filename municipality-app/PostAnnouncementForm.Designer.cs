using System.Drawing;
using System.Windows.Forms;

namespace municipality_app
{
    partial class PostAnnouncementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Panel contentPanel;
        private Panel footerPanel;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel dateLocationLayout;

        private Label lblMunicipalServices;
        private Label lblPageTitle;
        private Label lblPageSubtitle;

        private Label lblSectionTitle;
        private Label lblSectionDescription;

        private Label lblTitle;
        private TextBox txtTitle;

        private Label lblCategory;
        private ComboBox cmbCategory;

        private Label lblDescription;
        private TextBox txtDescription;

        private Label lblDate;
        private DateTimePicker dtpAnnouncementDate;

        private Label lblLocation;
        private TextBox txtLocation;

        private Button btnCancel;
        private Button btnSave;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            lblMunicipalServices = new Label();
            lblPageTitle = new Label();
            lblPageSubtitle = new Label();
            contentPanel = new Panel();
            mainLayout = new TableLayoutPanel();
            lblSectionTitle = new Label();
            lblSectionDescription = new Label();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            descriptionAndDetails = new TableLayoutPanel();
            txtDescription = new TextBox();
            dateLocationLayout = new TableLayoutPanel();
            lblDate = new Label();
            lblLocation = new Label();
            dtpAnnouncementDate = new DateTimePicker();
            txtLocation = new TextBox();
            footerPanel = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            descriptionAndDetails.SuspendLayout();
            dateLocationLayout.SuspendLayout();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(25, 72, 120);
            headerPanel.Controls.Add(lblMunicipalServices);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(lblPageSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(45, 18, 45, 15);
            headerPanel.Size = new Size(1302, 145);
            headerPanel.TabIndex = 2;
            // 
            // lblMunicipalServices
            // 
            lblMunicipalServices.AutoSize = true;
            lblMunicipalServices.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMunicipalServices.ForeColor = Color.FromArgb(190, 220, 245);
            lblMunicipalServices.Location = new Point(45, 15);
            lblMunicipalServices.Name = "lblMunicipalServices";
            lblMunicipalServices.Size = new Size(179, 23);
            lblMunicipalServices.TabIndex = 0;
            lblMunicipalServices.Text = "MUNICIPAL SERVICES";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(42, 40);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(473, 60);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Create Announcement";
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new Font("Segoe UI", 10.5F);
            lblPageSubtitle.ForeColor = Color.FromArgb(220, 235, 248);
            lblPageSubtitle.Location = new Point(45, 92);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(600, 25);
            lblPageSubtitle.TabIndex = 2;
            lblPageSubtitle.Text = "Publish important municipal information for residents and the community.";
            // 
            // contentPanel
            // 
            contentPanel.AutoScroll = true;
            contentPanel.BackColor = Color.FromArgb(245, 247, 250);
            contentPanel.Controls.Add(mainLayout);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 145);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(45, 28, 45, 20);
            contentPanel.Size = new Size(1302, 599);
            contentPanel.TabIndex = 0;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(lblSectionTitle, 0, 0);
            mainLayout.Controls.Add(lblSectionDescription, 0, 1);
            mainLayout.Controls.Add(lblTitle, 0, 2);
            mainLayout.Controls.Add(txtTitle, 0, 3);
            mainLayout.Controls.Add(lblCategory, 0, 4);
            mainLayout.Controls.Add(cmbCategory, 0, 5);
            mainLayout.Controls.Add(lblDescription, 0, 6);
            mainLayout.Controls.Add(descriptionAndDetails, 0, 7);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(45, 28);
            mainLayout.Margin = new Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 8;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 233F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.Size = new Size(1212, 551);
            mainLayout.TabIndex = 0;
            // 
            // lblSectionTitle
            // 
            lblSectionTitle.Dock = DockStyle.Fill;
            lblSectionTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblSectionTitle.ForeColor = Color.FromArgb(35, 45, 55);
            lblSectionTitle.Location = new Point(3, 0);
            lblSectionTitle.Name = "lblSectionTitle";
            lblSectionTitle.Size = new Size(1206, 55);
            lblSectionTitle.TabIndex = 0;
            lblSectionTitle.Text = "Announcement Information";
            lblSectionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSectionDescription
            // 
            lblSectionDescription.Dock = DockStyle.Fill;
            lblSectionDescription.Font = new Font("Segoe UI", 9F);
            lblSectionDescription.ForeColor = Color.FromArgb(105, 115, 125);
            lblSectionDescription.Location = new Point(3, 55);
            lblSectionDescription.Name = "lblSectionDescription";
            lblSectionDescription.Size = new Size(1206, 30);
            lblSectionDescription.TabIndex = 1;
            lblSectionDescription.Text = "Enter the information residents will see when this announcement is published.";
            lblSectionDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(50, 60, 70);
            lblTitle.Location = new Point(3, 85);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1206, 55);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Announcement Title *";
            lblTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Dock = DockStyle.Fill;
            txtTitle.Font = new Font("Segoe UI", 11F);
            txtTitle.Location = new Point(0, 145);
            txtTitle.Margin = new Padding(0, 5, 0, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Enter a clear announcement title";
            txtTitle.Size = new Size(1212, 32);
            txtTitle.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(50, 60, 70);
            lblCategory.Location = new Point(3, 170);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(1206, 55);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Announcement Category *";
            lblCategory.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10.5F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "General", "Service Notice", "Community Event", "Public Meeting", "Emergency Notice", "Road Closure", "Water Services", "Electricity Services", "Waste Management", "Public Safety", "Awareness Event" });
            cmbCategory.Location = new Point(0, 230);
            cmbCategory.Margin = new Padding(0, 5, 0, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(1212, 31);
            cmbCategory.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Top;
            lblDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(50, 60, 70);
            lblDescription.Location = new Point(3, 255);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1206, 27);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description *";
            lblDescription.TextAlign = ContentAlignment.BottomLeft;
            // 
            // descriptionAndDetails
            // 
            descriptionAndDetails.ColumnCount = 1;
            descriptionAndDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            descriptionAndDetails.Controls.Add(txtDescription, 0, 0);
            descriptionAndDetails.Controls.Add(dateLocationLayout, 0, 1);
            descriptionAndDetails.Dock = DockStyle.Fill;
            descriptionAndDetails.Location = new Point(3, 321);
            descriptionAndDetails.Name = "descriptionAndDetails";
            descriptionAndDetails.RowCount = 2;
            descriptionAndDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            descriptionAndDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            descriptionAndDetails.Size = new Size(1206, 227);
            descriptionAndDetails.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Segoe UI", 10.5F);
            txtDescription.Location = new Point(0, 5);
            txtDescription.Margin = new Padding(0, 5, 0, 10);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter the full announcement details...";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(1206, 117);
            txtDescription.TabIndex = 0;
            // 
            // dateLocationLayout
            // 
            dateLocationLayout.ColumnCount = 2;
            dateLocationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            dateLocationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            dateLocationLayout.Controls.Add(lblDate, 0, 0);
            dateLocationLayout.Controls.Add(lblLocation, 1, 0);
            dateLocationLayout.Controls.Add(dtpAnnouncementDate, 0, 1);
            dateLocationLayout.Controls.Add(txtLocation, 1, 1);
            dateLocationLayout.Dock = DockStyle.Fill;
            dateLocationLayout.Location = new Point(0, 132);
            dateLocationLayout.Margin = new Padding(0);
            dateLocationLayout.Name = "dateLocationLayout";
            dateLocationLayout.RowCount = 2;
            dateLocationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            dateLocationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            dateLocationLayout.Size = new Size(1206, 95);
            dateLocationLayout.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.Dock = DockStyle.Fill;
            lblDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(50, 60, 70);
            lblDate.Location = new Point(3, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(416, 30);
            lblDate.TabIndex = 0;
            lblDate.Text = "Announcement Date *";
            lblDate.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblLocation
            // 
            lblLocation.Dock = DockStyle.Fill;
            lblLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblLocation.ForeColor = Color.FromArgb(50, 60, 70);
            lblLocation.Location = new Point(425, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(778, 30);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location *";
            lblLocation.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dtpAnnouncementDate
            // 
            dtpAnnouncementDate.Dock = DockStyle.Fill;
            dtpAnnouncementDate.Font = new Font("Segoe UI", 10.5F);
            dtpAnnouncementDate.Format = DateTimePickerFormat.Short;
            dtpAnnouncementDate.Location = new Point(0, 35);
            dtpAnnouncementDate.Margin = new Padding(0, 5, 15, 5);
            dtpAnnouncementDate.Name = "dtpAnnouncementDate";
            dtpAnnouncementDate.Size = new Size(407, 31);
            dtpAnnouncementDate.TabIndex = 2;
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Dock = DockStyle.Fill;
            txtLocation.Font = new Font("Segoe UI", 10.5F);
            txtLocation.Location = new Point(422, 35);
            txtLocation.Margin = new Padding(0, 5, 0, 5);
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "e.g. Municipal Hall, Community Centre, Ward 5";
            txtLocation.Size = new Size(784, 31);
            txtLocation.TabIndex = 3;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.White;
            footerPanel.Controls.Add(btnCancel);
            footerPanel.Controls.Add(btnSave);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 744);
            footerPanel.Name = "footerPanel";
            footerPanel.Padding = new Padding(45, 12, 45, 12);
            footerPanel.Size = new Size(1302, 85);
            footerPanel.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(25, 72, 120);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1000, 18);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 50);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save Announcement";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // PostAnnouncementForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            CancelButton = btnCancel;
            ClientSize = new Size(1302, 829);
            Controls.Add(contentPanel);
            Controls.Add(footerPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 10F);
            KeyPreview = true;
            MinimumSize = new Size(900, 700);
            Name = "PostAnnouncementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Municipal Services - Post Announcement";
            Load += PostAnnouncementForm_Load;
            KeyDown += PostAnnouncementForm_KeyDown;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            descriptionAndDetails.ResumeLayout(false);
            descriptionAndDetails.PerformLayout();
            dateLocationLayout.ResumeLayout(false);
            dateLocationLayout.PerformLayout();
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel descriptionAndDetails;
    }
}