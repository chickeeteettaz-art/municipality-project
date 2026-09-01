namespace municipality_app
{
    partial class ViewIssuesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlControls;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnViewIssues;
        private Button btnClear;

        private Label lblSearch;
        private Label lblStatus;

        private DataGridView dgvIssues;

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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();

            pnlControls = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnViewIssues = new Button();
            btnClear = new Button();
            lblStatus = new Label();

            dgvIssues = new DataGridView();

            pnlHeader.SuspendLayout();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIssues).BeginInit();

            SuspendLayout();

            // =====================================================
            // pnlHeader
            // =====================================================

            pnlHeader.BackColor = Color.FromArgb(31, 78, 121);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 105);
            pnlHeader.TabIndex = 0;

            // =====================================================
            // lblTitle
            // =====================================================

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font(
                "Segoe UI",
                22F,
                FontStyle.Bold);

            lblTitle.ForeColor = Color.White;

            lblTitle.Location = new Point(30, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(183, 41);

            lblTitle.TabIndex = 0;
            lblTitle.Text = "Municipal Issues";

            // =====================================================
            // lblSubtitle
            // =====================================================

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);

            lblSubtitle.ForeColor = Color.WhiteSmoke;

            lblSubtitle.Location = new Point(33, 64);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(380, 23);

            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text =
                "View and manage reported municipal issues";

            // Add header controls
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);

            // =====================================================
            // pnlControls
            // =====================================================

            pnlControls.BackColor = Color.White;
            pnlControls.Dock = DockStyle.Top;
            pnlControls.Location = new Point(0, 105);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(1000, 105);
            pnlControls.TabIndex = 1;

            // =====================================================
            // lblSearch
            // =====================================================

            lblSearch.AutoSize = true;
            lblSearch.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            lblSearch.Location = new Point(30, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(57, 23);

            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";

            // =====================================================
            // txtSearch
            // =====================================================

            txtSearch.Font = new Font(
                "Segoe UI",
                10F);

            txtSearch.Location = new Point(30, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText =
                "Search title, location, category or description...";

            txtSearch.Size = new Size(390, 30);
            txtSearch.TabIndex = 1;

            // =====================================================
            // btnSearch
            // =====================================================

            btnSearch.BackColor = Color.FromArgb(31, 78, 121);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;

            btnSearch.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            btnSearch.ForeColor = Color.White;

            btnSearch.Location = new Point(435, 47);
            btnSearch.Name = "btnSearch";

            btnSearch.Size = new Size(110, 33);
            btnSearch.TabIndex = 2;

            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;

            btnSearch.Click += btnSearch_Click;

            // =====================================================
            // btnViewIssues
            // =====================================================

            btnViewIssues.BackColor =
                Color.FromArgb(40, 167, 69);

            btnViewIssues.FlatAppearance.BorderSize = 0;
            btnViewIssues.FlatStyle = FlatStyle.Flat;

            btnViewIssues.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            btnViewIssues.ForeColor = Color.White;

            btnViewIssues.Location =
                new Point(650, 47);

            btnViewIssues.Name =
                "btnViewIssues";

            btnViewIssues.Size =
                new Size(145, 33);

            btnViewIssues.TabIndex = 3;
            btnViewIssues.Text = "View Issues";

            btnViewIssues.UseVisualStyleBackColor =
                false;

            btnViewIssues.Click +=
                btnViewIssues_Click;

            // =====================================================
            // btnClear
            // =====================================================

            btnClear.BackColor =
                Color.FromArgb(108, 117, 125);

            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;

            btnClear.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            btnClear.ForeColor = Color.White;

            btnClear.Location =
                new Point(810, 47);

            btnClear.Name =
                "btnClear";

            btnClear.Size =
                new Size(110, 33);

            btnClear.TabIndex = 4;
            btnClear.Text = "Clear Table";

            btnClear.UseVisualStyleBackColor =
                false;

            btnClear.Click += btnClear_Click;

            // =====================================================
            // lblStatus
            // =====================================================

            lblStatus.AutoSize = true;

            lblStatus.Font = new Font(
                "Segoe UI",
                9F);

            lblStatus.ForeColor =
                Color.FromArgb(80, 80, 80);

            lblStatus.Location =
                new Point(650, 18);

            lblStatus.Name =
                "lblStatus";

            lblStatus.Size =
                new Size(100, 20);

            lblStatus.TabIndex = 5;

            lblStatus.Text =
                "No issues loaded";

            // Add controls to control panel
            pnlControls.Controls.Add(lblSearch);
            pnlControls.Controls.Add(txtSearch);
            pnlControls.Controls.Add(btnSearch);
            pnlControls.Controls.Add(btnViewIssues);
            pnlControls.Controls.Add(btnClear);
            pnlControls.Controls.Add(lblStatus);

            // =====================================================
            // dgvIssues
            // =====================================================

            dgvIssues.AllowUserToAddRows = false;
            dgvIssues.AllowUserToDeleteRows = false;
            dgvIssues.AllowUserToResizeRows = false;

            dgvIssues.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvIssues.BackgroundColor =
                Color.White;

            dgvIssues.BorderStyle =
                BorderStyle.None;

            dgvIssues.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvIssues.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvIssues.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor =
                        Color.FromArgb(31, 78, 121),

                    ForeColor = Color.White,

                    Font = new Font(
                        "Segoe UI",
                        10F,
                        FontStyle.Bold),

                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft,

                    Padding =
                        new Padding(5)
                };

            dgvIssues.ColumnHeadersHeight = 40;

            dgvIssues.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    Font = new Font(
                        "Segoe UI",
                        9F),

                    SelectionBackColor =
                        Color.FromArgb(214, 229, 245),

                    SelectionForeColor =
                        Color.Black,

                    Padding =
                        new Padding(5),

                    BackColor =
                        Color.White,

                    ForeColor =
                        Color.FromArgb(40, 40, 40)
                };

            dgvIssues.Dock =
                DockStyle.Fill;

            dgvIssues.EnableHeadersVisualStyles =
                false;

            dgvIssues.GridColor =
                Color.FromArgb(230, 230, 230);

            dgvIssues.Location =
                new Point(0, 210);

            dgvIssues.MultiSelect =
                false;

            dgvIssues.Name =
                "dgvIssues";

            dgvIssues.ReadOnly =
                true;

            dgvIssues.RowHeadersVisible =
                false;

            dgvIssues.RowTemplate.Height =
                38;

            dgvIssues.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvIssues.Size =
                new Size(1000, 485);

            dgvIssues.TabIndex = 2;

            // =====================================================
            // ViewIssuesForm
            // =====================================================

            AutoScaleDimensions =
                new SizeF(8F, 20F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(245, 247, 250);

            ClientSize =
                new Size(1000, 695);

            Controls.Add(dgvIssues);
            Controls.Add(pnlControls);
            Controls.Add(pnlHeader);

            MinimumSize =
                new Size(850, 550);

            Name =
                "ViewIssuesForm";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Municipal Issues";

            Load +=
                ViewIssuesForm_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();

            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)dgvIssues)
                .EndInit();

            ResumeLayout(false);
        }

        #endregion
    }
}