namespace municipality_app
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Header
        private Panel pnlHeader;
        private Label lblMunicipality;
        private Label lblSubtitle;
        private Label lblStatus;

        // Main content
        private Panel pnlContent;
        private Label lblWelcome;
        private Label lblWelcomeDescription;

        // Cards
        private MaterialSkin.Controls.MaterialCard cardReportIssue;
        private MaterialSkin.Controls.MaterialCard cardAnnouncements;
        private MaterialSkin.Controls.MaterialCard cardServiceRequest;

        // Card controls
        private PictureBox pbxReportIssue;
        private PictureBox pbxAnnouncements;
        private PictureBox pbxServiceRequest;

        private Label lblReportIssue;
        private Label lblReportDescription;
        private Label lblAnnouncements;
        private Label lblAnnouncementsDescription;
        private Label lblServiceRequest;
        private Label lblServiceDescription;

        private MaterialSkin.Controls.MaterialButton btnReportIssue;
        private MaterialSkin.Controls.MaterialButton btnAnnouncements;
        private MaterialSkin.Controls.MaterialButton btnServiceRequest;

        // Footer
        private Panel pnlFooter;
        private Label lblFooter;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblMunicipality = new Label();
            lblSubtitle = new Label();
            lblStatus = new Label();
            pnlContent = new Panel();
            lblWelcome = new Label();
            lblWelcomeDescription = new Label();
            cardReportIssue = new MaterialSkin.Controls.MaterialCard();
            pbxReportIssue = new PictureBox();
            lblReportIssue = new Label();
            lblReportDescription = new Label();
            btnReportIssue = new MaterialSkin.Controls.MaterialButton();
            cardAnnouncements = new MaterialSkin.Controls.MaterialCard();
            pbxAnnouncements = new PictureBox();
            lblAnnouncements = new Label();
            lblAnnouncementsDescription = new Label();
            btnAnnouncements = new MaterialSkin.Controls.MaterialButton();
            cardServiceRequest = new MaterialSkin.Controls.MaterialCard();
            pbxServiceRequest = new PictureBox();
            lblServiceRequest = new Label();
            lblServiceDescription = new Label();
            btnServiceRequest = new MaterialSkin.Controls.MaterialButton();
            pnlFooter = new Panel();
            lblFooter = new Label();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            cardReportIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxReportIssue).BeginInit();
            cardAnnouncements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAnnouncements).BeginInit();
            cardServiceRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxServiceRequest).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 55, 85);
            pnlHeader.Controls.Add(lblMunicipality);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblStatus);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1100, 100);
            pnlHeader.TabIndex = 2;
            // 
            // lblMunicipality
            // 
            lblMunicipality.AutoSize = true;
            lblMunicipality.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMunicipality.ForeColor = Color.White;
            lblMunicipality.Location = new Point(35, 18);
            lblMunicipality.Name = "lblMunicipality";
            lblMunicipality.Size = new Size(368, 46);
            lblMunicipality.TabIndex = 0;
            lblMunicipality.Text = "MUNICIPAL SERVICES";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(220, 230, 240);
            lblSubtitle.Location = new Point(38, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(226, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Your community. Your services.";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(220, 230, 240);
            lblStatus.Location = new Point(900, 39);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(122, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "● Services Online";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(245, 247, 250);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Controls.Add(lblWelcomeDescription);
            pnlContent.Controls.Add(cardReportIssue);
            pnlContent.Controls.Add(cardAnnouncements);
            pnlContent.Controls.Add(cardServiceRequest);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 100);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(40, 30, 40, 20);
            pnlContent.Size = new Size(1100, 540);
            pnlContent.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(35, 45, 55);
            lblWelcome.Location = new Point(40, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(609, 54);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Municipal Services";
            // 
            // lblWelcomeDescription
            // 
            lblWelcomeDescription.AutoSize = true;
            lblWelcomeDescription.Font = new Font("Segoe UI", 11F);
            lblWelcomeDescription.ForeColor = Color.FromArgb(100, 110, 120);
            lblWelcomeDescription.Location = new Point(43, 79);
            lblWelcomeDescription.Name = "lblWelcomeDescription";
            lblWelcomeDescription.Size = new Size(384, 25);
            lblWelcomeDescription.TabIndex = 1;
            lblWelcomeDescription.Text = "Access municipal services quickly and easily.";
            // 
            // cardReportIssue
            // 
            cardReportIssue.BackColor = Color.FromArgb(255, 255, 255);
            cardReportIssue.Controls.Add(pbxReportIssue);
            cardReportIssue.Controls.Add(lblReportIssue);
            cardReportIssue.Controls.Add(lblReportDescription);
            cardReportIssue.Controls.Add(btnReportIssue);
            cardReportIssue.Depth = 0;
            cardReportIssue.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardReportIssue.Location = new Point(40, 130);
            cardReportIssue.Margin = new Padding(10);
            cardReportIssue.MouseState = MaterialSkin.MouseState.HOVER;
            cardReportIssue.Name = "cardReportIssue";
            cardReportIssue.Padding = new Padding(20);
            cardReportIssue.Size = new Size(310, 330);
            cardReportIssue.TabIndex = 2;
            // 
            // pbxReportIssue
            // 
            pbxReportIssue.Cursor = Cursors.Hand;
            pbxReportIssue.Image = Properties.Resources.customer_service__1_;
            pbxReportIssue.Location = new Point(95, 20);
            pbxReportIssue.Name = "pbxReportIssue";
            pbxReportIssue.Size = new Size(120, 120);
            pbxReportIssue.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxReportIssue.TabIndex = 0;
            pbxReportIssue.TabStop = false;
            pbxReportIssue.Click += materialButton1_Click;
            // 
            // lblReportIssue
            // 
            lblReportIssue.AutoSize = true;
            lblReportIssue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReportIssue.ForeColor = Color.FromArgb(35, 45, 55);
            lblReportIssue.Location = new Point(83, 150);
            lblReportIssue.Name = "lblReportIssue";
            lblReportIssue.Size = new Size(192, 32);
            lblReportIssue.TabIndex = 1;
            lblReportIssue.Text = "Report an Issue";
            // 
            // lblReportDescription
            // 
            lblReportDescription.Font = new Font("Segoe UI", 9F);
            lblReportDescription.ForeColor = Color.FromArgb(110, 115, 120);
            lblReportDescription.Location = new Point(25, 180);
            lblReportDescription.Name = "lblReportDescription";
            lblReportDescription.Size = new Size(260, 45);
            lblReportDescription.TabIndex = 2;
            lblReportDescription.Text = "Report problems such as potholes, street lights and other municipal issues.";
            lblReportDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReportIssue
            // 
            btnReportIssue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReportIssue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReportIssue.Depth = 0;
            btnReportIssue.HighEmphasis = true;
            btnReportIssue.Icon = null;
            btnReportIssue.Location = new Point(95, 250);
            btnReportIssue.Margin = new Padding(4, 6, 4, 6);
            btnReportIssue.MouseState = MaterialSkin.MouseState.HOVER;
            btnReportIssue.Name = "btnReportIssue";
            btnReportIssue.NoAccentTextColor = Color.Empty;
            btnReportIssue.Size = new Size(120, 36);
            btnReportIssue.TabIndex = 0;
            btnReportIssue.Text = "REPORT ISSUE";
            btnReportIssue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReportIssue.UseAccentColor = false;
            btnReportIssue.UseVisualStyleBackColor = true;
            btnReportIssue.Click += materialButton1_Click;
            // 
            // cardAnnouncements
            // 
            cardAnnouncements.BackColor = Color.FromArgb(255, 255, 255);
            cardAnnouncements.Controls.Add(pbxAnnouncements);
            cardAnnouncements.Controls.Add(lblAnnouncements);
            cardAnnouncements.Controls.Add(lblAnnouncementsDescription);
            cardAnnouncements.Controls.Add(btnAnnouncements);
            cardAnnouncements.Depth = 0;
            cardAnnouncements.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardAnnouncements.Location = new Point(395, 130);
            cardAnnouncements.Margin = new Padding(10);
            cardAnnouncements.MouseState = MaterialSkin.MouseState.HOVER;
            cardAnnouncements.Name = "cardAnnouncements";
            cardAnnouncements.Padding = new Padding(20);
            cardAnnouncements.Size = new Size(310, 330);
            cardAnnouncements.TabIndex = 3;
            // 
            // pbxAnnouncements
            // 
            pbxAnnouncements.Cursor = Cursors.Hand;
            pbxAnnouncements.Image = Properties.Resources.megaphone;
            pbxAnnouncements.Location = new Point(95, 20);
            pbxAnnouncements.Name = "pbxAnnouncements";
            pbxAnnouncements.Size = new Size(120, 120);
            pbxAnnouncements.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAnnouncements.TabIndex = 0;
            pbxAnnouncements.TabStop = false;
            pbxAnnouncements.Click += materialButton2_Click;
            // 
            // lblAnnouncements
            // 
            lblAnnouncements.AutoSize = true;
            lblAnnouncements.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAnnouncements.ForeColor = Color.FromArgb(35, 45, 55);
            lblAnnouncements.Location = new Point(85, 150);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(201, 32);
            lblAnnouncements.TabIndex = 1;
            lblAnnouncements.Text = "Announcements";
            // 
            // lblAnnouncementsDescription
            // 
            lblAnnouncementsDescription.Font = new Font("Segoe UI", 9F);
            lblAnnouncementsDescription.ForeColor = Color.FromArgb(110, 115, 120);
            lblAnnouncementsDescription.Location = new Point(25, 180);
            lblAnnouncementsDescription.Name = "lblAnnouncementsDescription";
            lblAnnouncementsDescription.Size = new Size(260, 45);
            lblAnnouncementsDescription.TabIndex = 2;
            lblAnnouncementsDescription.Text = "Stay informed about municipal news, events, notices and important updates.";
            lblAnnouncementsDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAnnouncements.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAnnouncements.Depth = 0;
            btnAnnouncements.HighEmphasis = true;
            btnAnnouncements.Icon = null;
            btnAnnouncements.Location = new Point(95, 250);
            btnAnnouncements.Margin = new Padding(4, 6, 4, 6);
            btnAnnouncements.MouseState = MaterialSkin.MouseState.HOVER;
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.NoAccentTextColor = Color.Empty;
            btnAnnouncements.Size = new Size(125, 36);
            btnAnnouncements.TabIndex = 1;
            btnAnnouncements.Text = "VIEW UPDATES";
            btnAnnouncements.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAnnouncements.UseAccentColor = false;
            btnAnnouncements.UseVisualStyleBackColor = true;
            btnAnnouncements.Click += materialButton2_Click;
            // 
            // cardServiceRequest
            // 
            cardServiceRequest.BackColor = Color.FromArgb(255, 255, 255);
            cardServiceRequest.Controls.Add(pbxServiceRequest);
            cardServiceRequest.Controls.Add(lblServiceRequest);
            cardServiceRequest.Controls.Add(lblServiceDescription);
            cardServiceRequest.Controls.Add(btnServiceRequest);
            cardServiceRequest.Depth = 0;
            cardServiceRequest.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardServiceRequest.Location = new Point(750, 130);
            cardServiceRequest.Margin = new Padding(10);
            cardServiceRequest.MouseState = MaterialSkin.MouseState.HOVER;
            cardServiceRequest.Name = "cardServiceRequest";
            cardServiceRequest.Padding = new Padding(20);
            cardServiceRequest.Size = new Size(310, 330);
            cardServiceRequest.TabIndex = 4;
            // 
            // pbxServiceRequest
            // 
            pbxServiceRequest.Cursor = Cursors.Hand;
            pbxServiceRequest.Image = Properties.Resources.customer_care;
            pbxServiceRequest.Location = new Point(95, 20);
            pbxServiceRequest.Name = "pbxServiceRequest";
            pbxServiceRequest.Size = new Size(120, 120);
            pbxServiceRequest.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxServiceRequest.TabIndex = 0;
            pbxServiceRequest.TabStop = false;
            pbxServiceRequest.Click += materialButton3_Click;
            // 
            // lblServiceRequest
            // 
            lblServiceRequest.AutoSize = true;
            lblServiceRequest.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblServiceRequest.ForeColor = Color.FromArgb(35, 45, 55);
            lblServiceRequest.Location = new Point(61, 148);
            lblServiceRequest.Name = "lblServiceRequest";
            lblServiceRequest.Size = new Size(194, 32);
            lblServiceRequest.TabIndex = 1;
            lblServiceRequest.Text = "Service Request";
            // 
            // lblServiceDescription
            // 
            lblServiceDescription.Font = new Font("Segoe UI", 9F);
            lblServiceDescription.ForeColor = Color.FromArgb(110, 115, 120);
            lblServiceDescription.Location = new Point(25, 180);
            lblServiceDescription.Name = "lblServiceDescription";
            lblServiceDescription.Size = new Size(260, 45);
            lblServiceDescription.TabIndex = 2;
            lblServiceDescription.Text = "Request municipal services and access assistance from your municipality.";
            lblServiceDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnServiceRequest
            // 
            btnServiceRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnServiceRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnServiceRequest.Depth = 0;
            btnServiceRequest.HighEmphasis = true;
            btnServiceRequest.Icon = null;
            btnServiceRequest.Location = new Point(95, 250);
            btnServiceRequest.Margin = new Padding(4, 6, 4, 6);
            btnServiceRequest.MouseState = MaterialSkin.MouseState.HOVER;
            btnServiceRequest.Name = "btnServiceRequest";
            btnServiceRequest.NoAccentTextColor = Color.Empty;
            btnServiceRequest.Size = new Size(147, 36);
            btnServiceRequest.TabIndex = 2;
            btnServiceRequest.Text = "REQUEST SERVICE";
            btnServiceRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnServiceRequest.UseAccentColor = false;
            btnServiceRequest.UseVisualStyleBackColor = true;
            btnServiceRequest.Click += materialButton3_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(235, 238, 242);
            pnlFooter.Controls.Add(lblFooter);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 640);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1100, 60);
            pnlFooter.TabIndex = 1;
            // 
            // lblFooter
            // 
            lblFooter.Dock = DockStyle.Fill;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(100, 105, 110);
            lblFooter.Location = new Point(0, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(1100, 60);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Need assistance? Contact Municipal Support";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlContent);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1000, 650);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Municipal Services";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            cardReportIssue.ResumeLayout(false);
            cardReportIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxReportIssue).EndInit();
            cardAnnouncements.ResumeLayout(false);
            cardAnnouncements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAnnouncements).EndInit();
            cardServiceRequest.ResumeLayout(false);
            cardServiceRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxServiceRequest).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}