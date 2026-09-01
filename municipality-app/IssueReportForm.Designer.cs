namespace municipality_app
{
    partial class IssueReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueReportForm));
            titleTextBox = new MaterialSkin.Controls.MaterialTextBox();
            serviceTypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            descriptionTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            uploadFileButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            submitButton = new MaterialSkin.Controls.MaterialButton();
            fileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            cancelButton = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            reportingProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox5 = new PictureBox();
            locationTextBox = new MaterialSkin.Controls.MaterialTextBox();
            fileNameTxt = new MaterialSkin.Controls.MaterialLabel();
            fileLabel = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            pictureBox6 = new PictureBox();
            pbxImage = new PictureBox();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Anchor = AnchorStyles.None;
            titleTextBox.AnimateReadOnly = false;
            titleTextBox.BorderStyle = BorderStyle.None;
            titleTextBox.Depth = 0;
            titleTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            titleTextBox.Hint = "Title";
            titleTextBox.LeadingIcon = null;
            titleTextBox.Location = new Point(137, 326);
            titleTextBox.MaxLength = 50;
            titleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            titleTextBox.Multiline = false;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(400, 50);
            titleTextBox.TabIndex = 2;
            titleTextBox.Text = "";
            titleTextBox.TrailingIcon = null;
            // 
            // serviceTypeComboBox
            // 
            serviceTypeComboBox.Anchor = AnchorStyles.None;
            serviceTypeComboBox.AutoResize = false;
            serviceTypeComboBox.BackColor = Color.FromArgb(255, 255, 255);
            serviceTypeComboBox.Depth = 0;
            serviceTypeComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            serviceTypeComboBox.DropDownHeight = 174;
            serviceTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            serviceTypeComboBox.DropDownWidth = 121;
            serviceTypeComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            serviceTypeComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            serviceTypeComboBox.FormattingEnabled = true;
            serviceTypeComboBox.IntegralHeight = false;
            serviceTypeComboBox.ItemHeight = 43;
            serviceTypeComboBox.Items.AddRange(new object[] { "Roads", "Sanitation", "Utilities" });
            serviceTypeComboBox.Location = new Point(137, 513);
            serviceTypeComboBox.MaxDropDownItems = 4;
            serviceTypeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            serviceTypeComboBox.Name = "serviceTypeComboBox";
            serviceTypeComboBox.Size = new Size(400, 49);
            serviceTypeComboBox.StartIndex = 0;
            serviceTypeComboBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.None;
            descriptionTextBox.BackColor = Color.FromArgb(255, 255, 255);
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.Depth = 0;
            descriptionTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            descriptionTextBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            descriptionTextBox.Hint = "Description";
            descriptionTextBox.Location = new Point(612, 345);
            descriptionTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(382, 324);
            descriptionTextBox.TabIndex = 4;
            descriptionTextBox.Text = "";
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.None;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(642, 306);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(85, 19);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "Description:";
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.None;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(uploadFileButton);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(204, 627);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(250, 125);
            materialCard1.TabIndex = 6;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(73, 92);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(93, 19);
            materialLabel4.TabIndex = 1;
            materialLabel4.Text = "Upload a File";
            // 
            // uploadFileButton
            // 
            uploadFileButton.Depth = 0;
            uploadFileButton.Icon = Properties.Resources.file;
            uploadFileButton.Location = new Point(91, 17);
            uploadFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            uploadFileButton.Name = "uploadFileButton";
            uploadFileButton.Size = new Size(59, 58);
            uploadFileButton.TabIndex = 0;
            uploadFileButton.Text = "materialFloatingActionButton1";
            uploadFileButton.UseVisualStyleBackColor = true;
            uploadFileButton.Click += uploadFileButton_Click;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.None;
            submitButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            submitButton.Depth = 0;
            submitButton.HighEmphasis = true;
            submitButton.Icon = Properties.Resources.send;
            submitButton.Location = new Point(391, 817);
            submitButton.Margin = new Padding(4, 6, 4, 6);
            submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            submitButton.Name = "submitButton";
            submitButton.NoAccentTextColor = Color.Empty;
            submitButton.Padding = new Padding(100, 0, 100, 0);
            submitButton.Size = new Size(103, 36);
            submitButton.TabIndex = 7;
            submitButton.Text = "Submit";
            submitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            submitButton.UseAccentColor = false;
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // fileNameLabel
            // 
            fileNameLabel.Anchor = AnchorStyles.None;
            fileNameLabel.AutoSize = true;
            fileNameLabel.Depth = 0;
            fileNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fileNameLabel.Location = new Point(204, 766);
            fileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(76, 19);
            fileNameLabel.TabIndex = 8;
            fileNameLabel.Text = "File Name:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(286, 766);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(1, 0);
            materialLabel6.TabIndex = 9;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.BackColor = Color.LightCoral;
            cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.ForeColor = Color.Cornsilk;
            cancelButton.HighEmphasis = false;
            cancelButton.Icon = Properties.Resources.cancel;
            cancelButton.Location = new Point(572, 817);
            cancelButton.Margin = new Padding(4, 6, 4, 6);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(155, 36);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Back to Menu";
            cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 336);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(107, 522);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(612, 306);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(391, 115);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(454, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // reportingProgressBar
            // 
            reportingProgressBar.Anchor = AnchorStyles.None;
            reportingProgressBar.Depth = 0;
            reportingProgressBar.ForeColor = SystemColors.MenuHighlight;
            reportingProgressBar.Location = new Point(247, 275);
            reportingProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            reportingProgressBar.Name = "reportingProgressBar";
            reportingProgressBar.Size = new Size(648, 5);
            reportingProgressBar.TabIndex = 15;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.None;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(502, 244);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(134, 19);
            materialLabel1.TabIndex = 16;
            materialLabel1.Text = "Reporting progress";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(107, 428);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // locationTextBox
            // 
            locationTextBox.Anchor = AnchorStyles.None;
            locationTextBox.AnimateReadOnly = false;
            locationTextBox.BorderStyle = BorderStyle.None;
            locationTextBox.Depth = 0;
            locationTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            locationTextBox.Hint = "Location";
            locationTextBox.LeadingIcon = null;
            locationTextBox.Location = new Point(137, 418);
            locationTextBox.MaxLength = 50;
            locationTextBox.MouseState = MaterialSkin.MouseState.OUT;
            locationTextBox.Multiline = false;
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(400, 50);
            locationTextBox.TabIndex = 17;
            locationTextBox.Text = "";
            locationTextBox.TrailingIcon = null;
            // 
            // fileNameTxt
            // 
            fileNameTxt.Anchor = AnchorStyles.None;
            fileNameTxt.AutoSize = true;
            fileNameTxt.Depth = 0;
            fileNameTxt.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fileNameTxt.Location = new Point(286, 766);
            fileNameTxt.MouseState = MaterialSkin.MouseState.HOVER;
            fileNameTxt.Name = "fileNameTxt";
            fileNameTxt.Size = new Size(43, 19);
            fileNameTxt.TabIndex = 19;
            fileNameTxt.Text = "file.ex";
            // 
            // fileLabel
            // 
            fileLabel.Anchor = AnchorStyles.None;
            fileLabel.AutoSize = true;
            fileLabel.Depth = 0;
            fileLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fileLabel.Location = new Point(340, 766);
            fileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(4, 19);
            fileLabel.TabIndex = 20;
            fileLabel.Text = "'";
            fileLabel.Visible = false;
            fileLabel.Click += materialLabel2_Click;
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.None;
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(pictureBox6);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(295, 98);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(123, 123);
            materialCard2.TabIndex = 21;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(27, 28);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 68);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // pbxImage
            // 
            pbxImage.Location = new Point(20, 599);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(167, 167);
            pbxImage.TabIndex = 22;
            pbxImage.TabStop = false;
            // 
            // IssueReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1100, 923);
            Controls.Add(pbxImage);
            Controls.Add(materialCard2);
            Controls.Add(pictureBox4);
            Controls.Add(fileLabel);
            Controls.Add(fileNameTxt);
            Controls.Add(pictureBox5);
            Controls.Add(locationTextBox);
            Controls.Add(materialLabel1);
            Controls.Add(reportingProgressBar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cancelButton);
            Controls.Add(materialLabel6);
            Controls.Add(fileNameLabel);
            Controls.Add(submitButton);
            Controls.Add(materialCard1);
            Controls.Add(materialLabel3);
            Controls.Add(descriptionTextBox);
            Controls.Add(serviceTypeComboBox);
            Controls.Add(titleTextBox);
            DrawerBackgroundWithAccent = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IssueReportForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Request Form";
            Load += ServiceRequestForm_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox titleTextBox;
        private MaterialSkin.Controls.MaterialComboBox serviceTypeComboBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox descriptionTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFloatingActionButton uploadFileButton;
        private MaterialSkin.Controls.MaterialButton submitButton;
        private MaterialSkin.Controls.MaterialLabel fileNameLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialProgressBar reportingProgressBar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialTextBox locationTextBox;
        private MaterialSkin.Controls.MaterialLabel fileNameTxt;
        private MaterialSkin.Controls.MaterialLabel fileLabel;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private PictureBox pictureBox6;
        private PictureBox pbxImage;
    }
}