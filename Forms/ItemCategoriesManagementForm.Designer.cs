namespace CSharp_Inventory
{
    partial class ItemCategoriesManagementForm
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
            this.CustomesManagementTopPanel = new System.Windows.Forms.Panel();
            this.ClosingLabel = new System.Windows.Forms.Label();
            this.InventorySystemLabel = new System.Windows.Forms.Label();
            this.ManageCustomersLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryTextbox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CategoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.CatgeoriesListLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomesManagementTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomesManagementTopPanel
            // 
            this.CustomesManagementTopPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.CustomesManagementTopPanel.Controls.Add(this.ClosingLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.InventorySystemLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.ManageCustomersLabel);
            this.CustomesManagementTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomesManagementTopPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomesManagementTopPanel.Name = "CustomesManagementTopPanel";
            this.CustomesManagementTopPanel.Size = new System.Drawing.Size(1280, 125);
            this.CustomesManagementTopPanel.TabIndex = 1;
            // 
            // ClosingLabel
            // 
            this.ClosingLabel.AutoSize = true;
            this.ClosingLabel.BackColor = System.Drawing.Color.IndianRed;
            this.ClosingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosingLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClosingLabel.Location = new System.Drawing.Point(1236, 0);
            this.ClosingLabel.Name = "ClosingLabel";
            this.ClosingLabel.Size = new System.Drawing.Size(44, 46);
            this.ClosingLabel.TabIndex = 19;
            this.ClosingLabel.Text = "X";
            this.ClosingLabel.Click += new System.EventHandler(this.ClosingLabel_Click);
            // 
            // InventorySystemLabel
            // 
            this.InventorySystemLabel.AutoSize = true;
            this.InventorySystemLabel.BackColor = System.Drawing.Color.MistyRose;
            this.InventorySystemLabel.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InventorySystemLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.InventorySystemLabel.Location = new System.Drawing.Point(0, 0);
            this.InventorySystemLabel.Name = "InventorySystemLabel";
            this.InventorySystemLabel.Size = new System.Drawing.Size(322, 44);
            this.InventorySystemLabel.TabIndex = 2;
            this.InventorySystemLabel.Text = "Inventory System";
            // 
            // ManageCustomersLabel
            // 
            this.ManageCustomersLabel.AutoSize = true;
            this.ManageCustomersLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageCustomersLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ManageCustomersLabel.Location = new System.Drawing.Point(272, 55);
            this.ManageCustomersLabel.Name = "ManageCustomersLabel";
            this.ManageCustomersLabel.Size = new System.Drawing.Size(716, 70);
            this.ManageCustomersLabel.TabIndex = 1;
            this.ManageCustomersLabel.Text = "Manage Item Category";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.BurlyWood;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.SystemColors.Info;
            this.HomeButton.Location = new System.Drawing.Point(12, 131);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(161, 55);
            this.HomeButton.TabIndex = 16;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // IdTextbox
            // 
            this.IdTextbox.Enabled = false;
            this.IdTextbox.Location = new System.Drawing.Point(257, 238);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(218, 31);
            this.IdTextbox.TabIndex = 36;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.CategoryLabel.Location = new System.Drawing.Point(136, 293);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(105, 28);
            this.CategoryLabel.TabIndex = 35;
            this.CategoryLabel.Text = "Category: ";
            // 
            // CategoryTextbox
            // 
            this.CategoryTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryTextbox.Location = new System.Drawing.Point(257, 290);
            this.CategoryTextbox.Name = "CategoryTextbox";
            this.CategoryTextbox.Size = new System.Drawing.Size(218, 31);
            this.CategoryTextbox.TabIndex = 34;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.IdLabel.Location = new System.Drawing.Point(136, 241);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(37, 28);
            this.IdLabel.TabIndex = 33;
            this.IdLabel.Text = "ID:";
            // 
            // CategoriesDataGridView
            // 
            this.CategoriesDataGridView.AllowUserToAddRows = false;
            this.CategoriesDataGridView.AllowUserToDeleteRows = false;
            this.CategoriesDataGridView.AllowUserToResizeColumns = false;
            this.CategoriesDataGridView.AllowUserToResizeRows = false;
            this.CategoriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CategoriesDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.CategoriesDataGridView.Location = new System.Drawing.Point(572, 235);
            this.CategoriesDataGridView.Name = "CategoriesDataGridView";
            this.CategoriesDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CategoriesDataGridView.RowHeadersWidth = 51;
            this.CategoriesDataGridView.RowTemplate.Height = 33;
            this.CategoriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesDataGridView.ShowCellToolTips = false;
            this.CategoriesDataGridView.ShowEditingIcon = false;
            this.CategoriesDataGridView.Size = new System.Drawing.Size(568, 454);
            this.CategoriesDataGridView.TabIndex = 37;
            this.CategoriesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesDataGridView_CellContentClick);
            this.CategoriesDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.CategoriesDataGridView_RowPostPaint);
            // 
            // CatgeoriesListLabel
            // 
            this.CatgeoriesListLabel.AutoSize = true;
            this.CatgeoriesListLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CatgeoriesListLabel.ForeColor = System.Drawing.Color.RosyBrown;
            this.CatgeoriesListLabel.Location = new System.Drawing.Point(642, 168);
            this.CatgeoriesListLabel.Name = "CatgeoriesListLabel";
            this.CatgeoriesListLabel.Size = new System.Drawing.Size(449, 47);
            this.CatgeoriesListLabel.TabIndex = 38;
            this.CatgeoriesListLabel.Text = "List of Item Categories";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ClearButton.Location = new System.Drawing.Point(257, 404);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 42;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.BurlyWood;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.SystemColors.Info;
            this.EditButton.Location = new System.Drawing.Point(257, 348);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 29);
            this.EditButton.TabIndex = 41;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.BurlyWood;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.FlatAppearance.BorderSize = 0;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.DelButton.Location = new System.Drawing.Point(381, 348);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(94, 29);
            this.DelButton.TabIndex = 40;
            this.DelButton.Text = "DEL";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.BurlyWood;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.Info;
            this.AddButton.Location = new System.Drawing.Point(136, 348);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 39;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemCategoriesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CatgeoriesListLabel);
            this.Controls.Add(this.CategoriesDataGridView);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryTextbox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.CustomesManagementTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemCategoriesManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemCategoriesManagementForm";
            this.Load += new System.EventHandler(this.ItemCategoriesManagementForm_Load);
            this.CustomesManagementTopPanel.ResumeLayout(false);
            this.CustomesManagementTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel CustomesManagementTopPanel;
        private Label ClosingLabel;
        private Label InventorySystemLabel;
        private Label ManageCustomersLabel;
        private Button HomeButton;
        private TextBox IdTextbox;
        private Label CategoryLabel;
        private TextBox CategoryTextbox;
        private Label IdLabel;
        private DataGridView CategoriesDataGridView;
        private Label CatgeoriesListLabel;
        private Button ClearButton;
        private Button EditButton;
        private Button DelButton;
        private Button AddButton;
    }
}