namespace CSharp_Inventory
{
    partial class ItemManagementForm
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
            this.ManageItemsLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.ItemNameTextbox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CustomersListLabel = new System.Windows.Forms.Label();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomesManagementTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomesManagementTopPanel
            // 
            this.CustomesManagementTopPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.CustomesManagementTopPanel.Controls.Add(this.ClosingLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.InventorySystemLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.ManageItemsLabel);
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
            // ManageItemsLabel
            // 
            this.ManageItemsLabel.AutoSize = true;
            this.ManageItemsLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageItemsLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ManageItemsLabel.Location = new System.Drawing.Point(409, 55);
            this.ManageItemsLabel.Name = "ManageItemsLabel";
            this.ManageItemsLabel.Size = new System.Drawing.Size(450, 70);
            this.ManageItemsLabel.TabIndex = 1;
            this.ManageItemsLabel.Text = "Manage Items";
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
            this.HomeButton.TabIndex = 17;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextbox.Location = new System.Drawing.Point(253, 369);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(218, 31);
            this.PriceTextbox.TabIndex = 25;
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Enabled = false;
            this.QuantityTextbox.Location = new System.Drawing.Point(253, 318);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(218, 31);
            this.QuantityTextbox.TabIndex = 24;
            // 
            // ItemNameTextbox
            // 
            this.ItemNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemNameTextbox.Location = new System.Drawing.Point(253, 265);
            this.ItemNameTextbox.Name = "ItemNameTextbox";
            this.ItemNameTextbox.Size = new System.Drawing.Size(218, 31);
            this.ItemNameTextbox.TabIndex = 23;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.PriceLabel.Location = new System.Drawing.Point(121, 369);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(67, 28);
            this.PriceLabel.TabIndex = 22;
            this.PriceLabel.Text = "Price: ";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.QuantityLabel.Location = new System.Drawing.Point(121, 318);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(101, 28);
            this.QuantityLabel.TabIndex = 21;
            this.QuantityLabel.Text = "Quantity: ";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemNameLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.ItemNameLabel.Location = new System.Drawing.Point(121, 265);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(125, 28);
            this.ItemNameLabel.TabIndex = 20;
            this.ItemNameLabel.Text = "Item Name: ";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.IdLabel.Location = new System.Drawing.Point(121, 213);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(41, 28);
            this.IdLabel.TabIndex = 19;
            this.IdLabel.Text = "Id: ";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.CategoryLabel.Location = new System.Drawing.Point(121, 423);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryLabel.Size = new System.Drawing.Size(105, 28);
            this.CategoryLabel.TabIndex = 26;
            this.CategoryLabel.Text = "Category: ";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(253, 423);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(218, 33);
            this.CategoryComboBox.TabIndex = 28;
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(253, 480);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(218, 111);
            this.DescriptionRichTextBox.TabIndex = 29;
            this.DescriptionRichTextBox.Text = "";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Enabled = false;
            this.IdTextbox.Location = new System.Drawing.Point(253, 210);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(218, 31);
            this.IdTextbox.TabIndex = 33;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.DescriptionLabel.Location = new System.Drawing.Point(121, 480);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionLabel.Size = new System.Drawing.Size(126, 28);
            this.DescriptionLabel.TabIndex = 34;
            this.DescriptionLabel.Text = "Description: ";
            // 
            // CustomersListLabel
            // 
            this.CustomersListLabel.AutoSize = true;
            this.CustomersListLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersListLabel.ForeColor = System.Drawing.Color.RosyBrown;
            this.CustomersListLabel.Location = new System.Drawing.Point(724, 139);
            this.CustomersListLabel.Name = "CustomersListLabel";
            this.CustomersListLabel.Size = new System.Drawing.Size(242, 47);
            this.CustomersListLabel.TabIndex = 36;
            this.CustomersListLabel.Text = "List of Items";
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AllowUserToAddRows = false;
            this.ItemsDataGridView.AllowUserToDeleteRows = false;
            this.ItemsDataGridView.AllowUserToResizeColumns = false;
            this.ItemsDataGridView.AllowUserToResizeRows = false;
            this.ItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ItemsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ItemsDataGridView.Location = new System.Drawing.Point(565, 213);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsDataGridView.RowHeadersWidth = 51;
            this.ItemsDataGridView.RowTemplate.Height = 33;
            this.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGridView.ShowCellToolTips = false;
            this.ItemsDataGridView.ShowEditingIcon = false;
            this.ItemsDataGridView.Size = new System.Drawing.Size(568, 454);
            this.ItemsDataGridView.TabIndex = 35;
            this.ItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridView_CellContentClick);
            this.ItemsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ItemsDataGridView_RowPostPaint);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ClearButton.Location = new System.Drawing.Point(249, 675);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 40;
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
            this.EditButton.Location = new System.Drawing.Point(249, 619);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 29);
            this.EditButton.TabIndex = 39;
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
            this.DelButton.Location = new System.Drawing.Point(373, 619);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(94, 29);
            this.DelButton.TabIndex = 38;
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
            this.AddButton.Location = new System.Drawing.Point(128, 619);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 37;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomersListLabel);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.ItemNameTextbox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.CustomesManagementTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemManagementForm";
            this.Load += new System.EventHandler(this.ItemManagementForm_Load);
            this.CustomesManagementTopPanel.ResumeLayout(false);
            this.CustomesManagementTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel CustomesManagementTopPanel;
        private Label ClosingLabel;
        private Label InventorySystemLabel;
        private Label ManageItemsLabel;
        private Button HomeButton;
        private TextBox PriceTextbox;
        private TextBox QuantityTextbox;
        private TextBox ItemNameTextbox;
        private Label PriceLabel;
        private Label QuantityLabel;
        private Label ItemNameLabel;
        private Label IdLabel;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private RichTextBox DescriptionRichTextBox;
        private TextBox IdTextbox;
        private Label DescriptionLabel;
        private Label CustomersListLabel;
        private DataGridView ItemsDataGridView;
        private Button ClearButton;
        private Button EditButton;
        private Button DelButton;
        private Button AddButton;
    }
}