namespace municipality_app.Views
{
    partial class PetView
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
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            searchTerm = new TextBox();
            searchButton = new Button();
            petListView = new ListView();
            deleteButton = new Button();
            editPetButton = new Button();
            addNewPetButton = new Button();
            petId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            petName = new TextBox();
            label4 = new Label();
            petType = new TextBox();
            petColor = new Label();
            petColour = new TextBox();
            savePet = new Button();
            cancelButton = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 69);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 69);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 381);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(addNewPetButton);
            tabPage1.Controls.Add(editPetButton);
            tabPage1.Controls.Add(deleteButton);
            tabPage1.Controls.Add(petListView);
            tabPage1.Controls.Add(searchButton);
            tabPage1.Controls.Add(searchTerm);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 348);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cancelButton);
            tabPage2.Controls.Add(savePet);
            tabPage2.Controls.Add(petColor);
            tabPage2.Controls.Add(petColour);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(petType);
            tabPage2.Controls.Add(petName);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(petId);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 348);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchTerm
            // 
            searchTerm.Location = new Point(8, 23);
            searchTerm.Name = "searchTerm";
            searchTerm.Size = new Size(503, 27);
            searchTerm.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(517, 21);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // petListView
            // 
            petListView.Location = new Point(8, 56);
            petListView.Name = "petListView";
            petListView.Size = new Size(603, 239);
            petListView.TabIndex = 2;
            petListView.UseCompatibleStateImageBehavior = false;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(617, 126);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // editPetButton
            // 
            editPetButton.Location = new Point(617, 91);
            editPetButton.Name = "editPetButton";
            editPetButton.Size = new Size(94, 29);
            editPetButton.TabIndex = 4;
            editPetButton.Text = "Edit";
            editPetButton.UseVisualStyleBackColor = true;
            // 
            // addNewPetButton
            // 
            addNewPetButton.Location = new Point(617, 56);
            addNewPetButton.Name = "addNewPetButton";
            addNewPetButton.Size = new Size(94, 29);
            addNewPetButton.TabIndex = 5;
            addNewPetButton.Text = "Add new";
            addNewPetButton.UseVisualStyleBackColor = true;
            // 
            // petId
            // 
            petId.Location = new Point(32, 54);
            petId.Name = "petId";
            petId.Size = new Size(174, 27);
            petId.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 31);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Pet ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 97);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Pet name:";
            // 
            // petName
            // 
            petName.Location = new Point(32, 120);
            petName.Name = "petName";
            petName.Size = new Size(174, 27);
            petName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 97);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 4;
            label4.Text = "Pet Type:";
            // 
            // petType
            // 
            petType.Location = new Point(257, 120);
            petType.Name = "petType";
            petType.Size = new Size(174, 27);
            petType.TabIndex = 3;
            // 
            // petColor
            // 
            petColor.AutoSize = true;
            petColor.Location = new Point(32, 168);
            petColor.Name = "petColor";
            petColor.Size = new Size(72, 20);
            petColor.TabIndex = 6;
            petColor.Text = "Pet Color:";
            // 
            // petColour
            // 
            petColour.Location = new Point(32, 191);
            petColour.Name = "petColour";
            petColour.Size = new Size(399, 27);
            petColour.TabIndex = 5;
            // 
            // savePet
            // 
            savePet.Location = new Point(32, 242);
            savePet.Name = "savePet";
            savePet.Size = new Size(204, 29);
            savePet.TabIndex = 7;
            savePet.Text = "Save";
            savePet.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(242, 242);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(189, 29);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox searchTerm;
        private TabPage tabPage2;
        private Button addNewPetButton;
        private Button editPetButton;
        private Button deleteButton;
        private ListView petListView;
        private Button searchButton;
        private Button cancelButton;
        private Button savePet;
        private Label petColor;
        private TextBox petColour;
        private Label label4;
        private Label label3;
        private TextBox petType;
        private TextBox petName;
        private Label label2;
        private TextBox petId;
    }
}