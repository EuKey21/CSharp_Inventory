namespace CSharp_Inventory
{
    partial class SaleManagmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomesManagementTopPanel = new System.Windows.Forms.Panel();
            this.ClosingLabel = new System.Windows.Forms.Label();
            this.InventorySystemLabel = new System.Windows.Forms.Label();
            this.CreateSaleLabel = new System.Windows.Forms.Label();
            this.SalePriceTextbox = new System.Windows.Forms.TextBox();
            this.AddSaleItemButton = new System.Windows.Forms.Button();
            this.SaleItemsListLabel = new System.Windows.Forms.Label();
            this.SaleItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.StockPriceLabel = new System.Windows.Forms.Label();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.CustomesManagementTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomesManagementTopPanel
            // 
            this.CustomesManagementTopPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.CustomesManagementTopPanel.Controls.Add(this.ClosingLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.InventorySystemLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.CreateSaleLabel);
            this.CustomesManagementTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomesManagementTopPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomesManagementTopPanel.Name = "CustomesManagementTopPanel";
            this.CustomesManagementTopPanel.Size = new System.Drawing.Size(1280, 125);
            this.CustomesManagementTopPanel.TabIndex = 4;
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
            // CreateSaleLabel
            // 
            this.CreateSaleLabel.AutoSize = true;
            this.CreateSaleLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateSaleLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CreateSaleLabel.Location = new System.Drawing.Point(409, 55);
            this.CreateSaleLabel.Name = "CreateSaleLabel";
            this.CreateSaleLabel.Size = new System.Drawing.Size(418, 70);
            this.CreateSaleLabel.TabIndex = 1;
            this.CreateSaleLabel.Text = "Manage Sale";
            // 
            // SalePriceTextbox
            // 
            this.SalePriceTextbox.Enabled = false;
            this.SalePriceTextbox.Location = new System.Drawing.Point(288, 269);
            this.SalePriceTextbox.Name = "SalePriceTextbox";
            this.SalePriceTextbox.Size = new System.Drawing.Size(250, 31);
            this.SalePriceTextbox.TabIndex = 95;
            // 
            // AddSaleItemButton
            // 
            this.AddSaleItemButton.BackColor = System.Drawing.Color.BurlyWood;
            this.AddSaleItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSaleItemButton.FlatAppearance.BorderSize = 0;
            this.AddSaleItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSaleItemButton.ForeColor = System.Drawing.SystemColors.Info;
            this.AddSaleItemButton.Location = new System.Drawing.Point(807, 562);
            this.AddSaleItemButton.Name = "AddSaleItemButton";
            this.AddSaleItemButton.Size = new System.Drawing.Size(190, 29);
            this.AddSaleItemButton.TabIndex = 94;
            this.AddSaleItemButton.Text = "ADD SALE ITEM";
            this.AddSaleItemButton.UseVisualStyleBackColor = false;
            this.AddSaleItemButton.Click += new System.EventHandler(this.AddSaleItemButton_Click);
            // 
            // SaleItemsListLabel
            // 
            this.SaleItemsListLabel.AutoSize = true;
            this.SaleItemsListLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaleItemsListLabel.ForeColor = System.Drawing.Color.RosyBrown;
            this.SaleItemsListLabel.Location = new System.Drawing.Point(737, 139);
            this.SaleItemsListLabel.Name = "SaleItemsListLabel";
            this.SaleItemsListLabel.Size = new System.Drawing.Size(336, 47);
            this.SaleItemsListLabel.TabIndex = 93;
            this.SaleItemsListLabel.Text = "List of Sale Items";
            // 
            // SaleItemsDataGridView
            // 
            this.SaleItemsDataGridView.AllowUserToAddRows = false;
            this.SaleItemsDataGridView.AllowUserToDeleteRows = false;
            this.SaleItemsDataGridView.AllowUserToResizeColumns = false;
            this.SaleItemsDataGridView.AllowUserToResizeRows = false;
            this.SaleItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SaleItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.SaleItemsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.SaleItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.SaleItemsDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.SaleItemsDataGridView.Location = new System.Drawing.Point(625, 210);
            this.SaleItemsDataGridView.Name = "SaleItemsDataGridView";
            this.SaleItemsDataGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleItemsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.SaleItemsDataGridView.RowHeadersWidth = 51;
            this.SaleItemsDataGridView.RowTemplate.Height = 33;
            this.SaleItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SaleItemsDataGridView.ShowCellToolTips = false;
            this.SaleItemsDataGridView.ShowEditingIcon = false;
            this.SaleItemsDataGridView.Size = new System.Drawing.Size(568, 320);
            this.SaleItemsDataGridView.TabIndex = 92;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(288, 325);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(250, 31);
            this.DateTimePicker.TabIndex = 91;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(288, 210);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(250, 33);
            this.CustomerComboBox.TabIndex = 90;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ClearButton.Location = new System.Drawing.Point(238, 611);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(175, 29);
            this.ClearButton.TabIndex = 89;
            this.ClearButton.Text = "CLEAR ORDER";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.BurlyWood;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.ForeColor = System.Drawing.SystemColors.Info;
            this.CreateButton.Location = new System.Drawing.Point(121, 562);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(410, 29);
            this.CreateButton.TabIndex = 88;
            this.CreateButton.Text = "CREATE ORDER";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.DescriptionLabel.Location = new System.Drawing.Point(121, 379);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionLabel.Size = new System.Drawing.Size(126, 28);
            this.DescriptionLabel.TabIndex = 87;
            this.DescriptionLabel.Text = "Description: ";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(288, 379);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(250, 151);
            this.DescriptionRichTextBox.TabIndex = 86;
            this.DescriptionRichTextBox.Text = "";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.DateLabel.Location = new System.Drawing.Point(121, 328);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateLabel.Size = new System.Drawing.Size(65, 28);
            this.DateLabel.TabIndex = 85;
            this.DateLabel.Text = "Date: ";
            // 
            // StockPriceLabel
            // 
            this.StockPriceLabel.AutoSize = true;
            this.StockPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StockPriceLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.StockPriceLabel.Location = new System.Drawing.Point(121, 272);
            this.StockPriceLabel.Name = "StockPriceLabel";
            this.StockPriceLabel.Size = new System.Drawing.Size(110, 28);
            this.StockPriceLabel.TabIndex = 84;
            this.StockPriceLabel.Text = "Sale Price: ";
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SupplierNameLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.SupplierNameLabel.Location = new System.Drawing.Point(121, 210);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(171, 28);
            this.SupplierNameLabel.TabIndex = 83;
            this.SupplierNameLabel.Text = "Customer Name: ";
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
            this.HomeButton.TabIndex = 82;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // SaleManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.SalePriceTextbox);
            this.Controls.Add(this.AddSaleItemButton);
            this.Controls.Add(this.SaleItemsListLabel);
            this.Controls.Add(this.SaleItemsDataGridView);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.StockPriceLabel);
            this.Controls.Add(this.SupplierNameLabel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.CustomesManagementTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleManagmentForm";
            this.Load += new System.EventHandler(this.SaleManagmentForm_Load);
            this.CustomesManagementTopPanel.ResumeLayout(false);
            this.CustomesManagementTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel CustomesManagementTopPanel;
        private Label ClosingLabel;
        private Label InventorySystemLabel;
        private Label CreateSaleLabel;
        private TextBox SalePriceTextbox;
        private Button AddSaleItemButton;
        private Label SaleItemsListLabel;
        private DataGridView SaleItemsDataGridView;
        private DateTimePicker DateTimePicker;
        private ComboBox CustomerComboBox;
        private Button ClearButton;
        private Button CreateButton;
        private Label DescriptionLabel;
        private RichTextBox DescriptionRichTextBox;
        private Label DateLabel;
        private Label StockPriceLabel;
        private Label SupplierNameLabel;
        private Button HomeButton;
    }
}