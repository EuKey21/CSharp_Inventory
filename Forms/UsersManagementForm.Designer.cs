namespace CSharp_Inventory
{
    partial class UsersManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UsersManagementTopPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClosingLabel = new System.Windows.Forms.Label();
            this.InventorySystemLabel = new System.Windows.Forms.Label();
            this.ManageUserLabel = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.HomeButton = new System.Windows.Forms.Button();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.GenderTextbox = new System.Windows.Forms.TextBox();
            this.AgeTextbox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UsersListLable = new System.Windows.Forms.Label();
            this.UsersManagementTopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersManagementTopPanel
            // 
            this.UsersManagementTopPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.UsersManagementTopPanel.Controls.Add(this.panel1);
            this.UsersManagementTopPanel.Controls.Add(this.InventorySystemLabel);
            this.UsersManagementTopPanel.Controls.Add(this.ManageUserLabel);
            this.UsersManagementTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersManagementTopPanel.Location = new System.Drawing.Point(0, 0);
            this.UsersManagementTopPanel.Name = "UsersManagementTopPanel";
            this.UsersManagementTopPanel.Size = new System.Drawing.Size(1280, 125);
            this.UsersManagementTopPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.ClosingLabel);
            this.panel1.Location = new System.Drawing.Point(1236, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 20;
            // 
            // ClosingLabel
            // 
            this.ClosingLabel.AutoSize = true;
            this.ClosingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosingLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClosingLabel.Location = new System.Drawing.Point(0, 2);
            this.ClosingLabel.Name = "ClosingLabel";
            this.ClosingLabel.Size = new System.Drawing.Size(44, 46);
            this.ClosingLabel.TabIndex = 20;
            this.ClosingLabel.Text = "X";
            this.ClosingLabel.Click += new System.EventHandler(this.ClosingLabel_Click);
            // 
            // InventorySystemLabel
            // 
            this.InventorySystemLabel.AutoSize = true;
            this.InventorySystemLabel.BackColor = System.Drawing.Color.MistyRose;
            this.InventorySystemLabel.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InventorySystemLabel.ForeColor = System.Drawing.Color.Maroon;
            this.InventorySystemLabel.Location = new System.Drawing.Point(0, 0);
            this.InventorySystemLabel.Name = "InventorySystemLabel";
            this.InventorySystemLabel.Size = new System.Drawing.Size(322, 44);
            this.InventorySystemLabel.TabIndex = 1;
            this.InventorySystemLabel.Text = "Inventory System";
            // 
            // ManageUserLabel
            // 
            this.ManageUserLabel.AutoSize = true;
            this.ManageUserLabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.ManageUserLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageUserLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ManageUserLabel.Location = new System.Drawing.Point(420, 55);
            this.ManageUserLabel.Name = "ManageUserLabel";
            this.ManageUserLabel.Size = new System.Drawing.Size(442, 70);
            this.ManageUserLabel.TabIndex = 0;
            this.ManageUserLabel.Text = "Manage Users";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextbox.Location = new System.Drawing.Point(257, 235);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(218, 31);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(136, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username: ";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.BurlyWood;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.Info;
            this.AddButton.Location = new System.Drawing.Point(136, 604);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.BurlyWood;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.FlatAppearance.BorderSize = 0;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.DelButton.Location = new System.Drawing.Point(381, 604);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(94, 29);
            this.DelButton.TabIndex = 4;
            this.DelButton.Text = "DEL";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.BurlyWood;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.SystemColors.Info;
            this.EditButton.Location = new System.Drawing.Point(257, 604);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 29);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.PasswordLabel.Location = new System.Drawing.Point(136, 288);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(108, 28);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password: ";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.FirstNameLabel.Location = new System.Drawing.Point(136, 337);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(121, 28);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "First Name: ";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.LastNameLabel.Location = new System.Drawing.Point(136, 387);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(119, 28);
            this.LastNameLabel.TabIndex = 8;
            this.LastNameLabel.Text = "Last Name: ";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.EmailLabel.Location = new System.Drawing.Point(136, 547);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(71, 28);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email: ";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.Location = new System.Drawing.Point(257, 288);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(218, 31);
            this.PasswordTextbox.TabIndex = 10;
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNameTextbox.Location = new System.Drawing.Point(257, 337);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(218, 31);
            this.FirstNameTextbox.TabIndex = 11;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNameTextbox.Location = new System.Drawing.Point(257, 387);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(218, 31);
            this.LastNameTextbox.TabIndex = 12;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextbox.Location = new System.Drawing.Point(257, 544);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(218, 31);
            this.EmailTextbox.TabIndex = 13;
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.AllowUserToResizeColumns = false;
            this.UsersDataGridView.AllowUserToResizeRows = false;
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.UsersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.UsersDataGridView.Location = new System.Drawing.Point(572, 235);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersDataGridView.RowHeadersWidth = 30;
            this.UsersDataGridView.RowTemplate.Height = 33;
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGridView.ShowCellToolTips = false;
            this.UsersDataGridView.ShowEditingIcon = false;
            this.UsersDataGridView.Size = new System.Drawing.Size(568, 454);
            this.UsersDataGridView.TabIndex = 14;
            this.UsersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellContentClick);
            this.UsersDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.UsersDataGridView_RowPostPaint);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.BurlyWood;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.SystemColors.Info;
            this.HomeButton.Location = new System.Drawing.Point(12, 131);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(161, 55);
            this.HomeButton.TabIndex = 15;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenderLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.GenderLabel.Location = new System.Drawing.Point(136, 442);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenderLabel.Size = new System.Drawing.Size(91, 28);
            this.GenderLabel.TabIndex = 16;
            this.GenderLabel.Text = "Gender: ";
            // 
            // GenderTextbox
            // 
            this.GenderTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GenderTextbox.Location = new System.Drawing.Point(257, 439);
            this.GenderTextbox.Name = "GenderTextbox";
            this.GenderTextbox.Size = new System.Drawing.Size(218, 31);
            this.GenderTextbox.TabIndex = 17;
            // 
            // AgeTextbox
            // 
            this.AgeTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeTextbox.Location = new System.Drawing.Point(257, 492);
            this.AgeTextbox.Name = "AgeTextbox";
            this.AgeTextbox.Size = new System.Drawing.Size(218, 31);
            this.AgeTextbox.TabIndex = 18;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.AgeLabel.Location = new System.Drawing.Point(136, 495);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(53, 28);
            this.AgeLabel.TabIndex = 19;
            this.AgeLabel.Text = "Age:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ClearButton.Location = new System.Drawing.Point(257, 660);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UsersListLable
            // 
            this.UsersListLable.AutoSize = true;
            this.UsersListLable.BackColor = System.Drawing.Color.AntiqueWhite;
            this.UsersListLable.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsersListLable.ForeColor = System.Drawing.Color.RosyBrown;
            this.UsersListLable.Location = new System.Drawing.Point(744, 161);
            this.UsersListLable.Name = "UsersListLable";
            this.UsersListLable.Size = new System.Drawing.Size(238, 47);
            this.UsersListLable.TabIndex = 22;
            this.UsersListLable.Text = "List of Users";
            // 
            // UsersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.UsersListLable);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.AgeTextbox);
            this.Controls.Add(this.GenderTextbox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.UsersManagementTopPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UsersManagementForm";
            this.Load += new System.EventHandler(this.UsersManagementForm_Load);
            this.UsersManagementTopPanel.ResumeLayout(false);
            this.UsersManagementTopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel UsersManagementTopPanel;
        private Label ManageUserLabel;
        private Label InventorySystemLabel;
        private TextBox UsernameTextbox;
        private Label label1;
        private Button AddButton;
        private Button DelButton;
        private Button EditButton;
        private Label PasswordLabel;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label EmailLabel;
        private TextBox PasswordTextbox;
        private TextBox FirstNameTextbox;
        private TextBox LastNameTextbox;
        private TextBox EmailTextbox;
        private DataGridView UsersDataGridView;
        private Button HomeButton;
        private Label GenderLabel;
        private TextBox GenderTextbox;
        private TextBox AgeTextbox;
        private Label AgeLabel;
        private Panel panel1;
        private Label ClosingLabel;
        private Button ClearButton;
        private Label UsersListLable;
    }
}