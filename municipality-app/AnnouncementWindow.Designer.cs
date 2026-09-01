namespace municipality_app
{
    partial class AnnouncementWindow
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            listView1 = new MaterialSkin.Controls.MaterialListView();
            AnnouncementNumber = new ColumnHeader();
            Title = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel2 = new Panel();
            panel3 = new Panel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            eventCategoryComboBox = new MaterialSkin.Controls.MaterialComboBox();
            materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 95);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Screenshot_2026_08_24_154722_removebg_preview;
            pictureBox1.Location = new Point(286, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(526, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            listView1.Location = new Point(39, 219);
            listView1.MinimumSize = new Size(200, 100);
            listView1.MouseLocation = new Point(-1, -1);
            listView1.MouseState = MaterialSkin.MouseState.OUT;
            listView1.Name = "listView1";
            listView1.OwnerDraw = true;
            listView1.Size = new Size(1025, 667);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // AnnouncementNumber
            // 
            AnnouncementNumber.Text = "Announcement Id";
            AnnouncementNumber.Width = 150;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Description";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Location";
            columnHeader3.Width = 250;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 761);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(materialButton1);
            panel3.Controls.Add(eventCategoryComboBox);
            panel3.Controls.Add(materialMaskedTextBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(39, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(1058, 60);
            panel3.TabIndex = 4;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(885, 9);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(78, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "Search";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // eventCategoryComboBox
            // 
            eventCategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            eventCategoryComboBox.AutoResize = false;
            eventCategoryComboBox.BackColor = Color.FromArgb(255, 255, 255);
            eventCategoryComboBox.Depth = 0;
            eventCategoryComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            eventCategoryComboBox.DropDownHeight = 174;
            eventCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            eventCategoryComboBox.DropDownWidth = 121;
            eventCategoryComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            eventCategoryComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            eventCategoryComboBox.FormattingEnabled = true;
            eventCategoryComboBox.IntegralHeight = false;
            eventCategoryComboBox.ItemHeight = 43;
            eventCategoryComboBox.Location = new Point(612, 6);
            eventCategoryComboBox.MaxDropDownItems = 4;
            eventCategoryComboBox.MouseState = MaterialSkin.MouseState.OUT;
            eventCategoryComboBox.Name = "eventCategoryComboBox";
            eventCategoryComboBox.Size = new Size(243, 49);
            eventCategoryComboBox.StartIndex = 0;
            eventCategoryComboBox.TabIndex = 1;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.Hint = "Search term";
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(273, 6);
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
            materialMaskedTextBox1.Size = new Size(312, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 0;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-312, 225);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(312, 37);
            materialDrawer1.TabIndex = 1;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1064, 219);
            panel4.Name = "panel4";
            panel4.Size = new Size(33, 701);
            panel4.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(39, 886);
            panel5.Name = "panel5";
            panel5.Size = new Size(1025, 34);
            panel5.TabIndex = 6;
            // 
            // AnnouncementWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 923);
            Controls.Add(listView1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(materialDrawer1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AnnouncementWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Events and announcements";
            Load += AnnouncementWindow_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialListView listView1;
        private ColumnHeader AnnouncementNumber;
        private ColumnHeader Title;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel panel2;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox eventCategoryComboBox;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
    }
}