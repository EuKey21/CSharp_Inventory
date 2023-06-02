using System.Windows.Forms;

namespace CSharp_Inventory
{
    partial class StockManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomesManagementTopPanel = new System.Windows.Forms.Panel();
            this.ClosingLabel = new System.Windows.Forms.Label();
            this.InventorySystemLabel = new System.Windows.Forms.Label();
            this.CreateStockLabel = new System.Windows.Forms.Label();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StockPriceLabel = new System.Windows.Forms.Label();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.StockItemsListLabel = new System.Windows.Forms.Label();
            this.StockItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddStockItemButton = new System.Windows.Forms.Button();
            this.StockPriceTextbox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SelectedSupplierLabel = new System.Windows.Forms.Label();
            this.CustomesManagementTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomesManagementTopPanel
            // 
            this.CustomesManagementTopPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.CustomesManagementTopPanel.Controls.Add(this.ClosingLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.InventorySystemLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.CreateStockLabel);
            this.CustomesManagementTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomesManagementTopPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomesManagementTopPanel.Name = "CustomesManagementTopPanel";
            this.CustomesManagementTopPanel.Size = new System.Drawing.Size(1280, 125);
            this.CustomesManagementTopPanel.TabIndex = 3;
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
            // CreateStockLabel
            // 
            this.CreateStockLabel.AutoSize = true;
            this.CreateStockLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateStockLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CreateStockLabel.Location = new System.Drawing.Point(409, 55);
            this.CreateStockLabel.Name = "CreateStockLabel";
            this.CreateStockLabel.Size = new System.Drawing.Size(407, 70);
            this.CreateStockLabel.TabIndex = 1;
            this.CreateStockLabel.Text = "Create Stock";
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(288, 210);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(250, 33);
            this.SupplierComboBox.TabIndex = 75;
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
            this.ClearButton.TabIndex = 74;
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
            this.CreateButton.TabIndex = 71;
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
            this.DescriptionLabel.TabIndex = 70;
            this.DescriptionLabel.Text = "Description: ";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(288, 379);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(250, 151);
            this.DescriptionRichTextBox.TabIndex = 68;
            this.DescriptionRichTextBox.Text = "";
            // 
            // StockPriceLabel
            // 
            this.StockPriceLabel.AutoSize = true;
            this.StockPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StockPriceLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.StockPriceLabel.Location = new System.Drawing.Point(121, 272);
            this.StockPriceLabel.Name = "StockPriceLabel";
            this.StockPriceLabel.Size = new System.Drawing.Size(122, 28);
            this.StockPriceLabel.TabIndex = 65;
            this.StockPriceLabel.Text = "Stock Price: ";
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SupplierNameLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.SupplierNameLabel.Location = new System.Drawing.Point(121, 210);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(158, 28);
            this.SupplierNameLabel.TabIndex = 63;
            this.SupplierNameLabel.Text = "Supplier Name: ";
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
            this.HomeButton.TabIndex = 61;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // StockItemsListLabel
            // 
            this.StockItemsListLabel.AutoSize = true;
            this.StockItemsListLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StockItemsListLabel.ForeColor = System.Drawing.Color.RosyBrown;
            this.StockItemsListLabel.Location = new System.Drawing.Point(625, 139);
            this.StockItemsListLabel.Name = "StockItemsListLabel";
            this.StockItemsListLabel.Size = new System.Drawing.Size(361, 47);
            this.StockItemsListLabel.TabIndex = 79;
            this.StockItemsListLabel.Text = "List of Stock Items";
            // 
            // StockItemsDataGridView
            // 
            this.StockItemsDataGridView.AllowUserToAddRows = false;
            this.StockItemsDataGridView.AllowUserToDeleteRows = false;
            this.StockItemsDataGridView.AllowUserToResizeColumns = false;
            this.StockItemsDataGridView.AllowUserToResizeRows = false;
            this.StockItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.StockItemsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StockItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.StockItemsDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.StockItemsDataGridView.Location = new System.Drawing.Point(625, 210);
            this.StockItemsDataGridView.Name = "StockItemsDataGridView";
            this.StockItemsDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockItemsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StockItemsDataGridView.RowHeadersWidth = 51;
            this.StockItemsDataGridView.RowTemplate.Height = 33;
            this.StockItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockItemsDataGridView.ShowCellToolTips = false;
            this.StockItemsDataGridView.ShowEditingIcon = false;
            this.StockItemsDataGridView.Size = new System.Drawing.Size(568, 320);
            this.StockItemsDataGridView.TabIndex = 78;
            // 
            // AddStockItemButton
            // 
            this.AddStockItemButton.BackColor = System.Drawing.Color.BurlyWood;
            this.AddStockItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStockItemButton.FlatAppearance.BorderSize = 0;
            this.AddStockItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStockItemButton.ForeColor = System.Drawing.SystemColors.Info;
            this.AddStockItemButton.Location = new System.Drawing.Point(807, 562);
            this.AddStockItemButton.Name = "AddStockItemButton";
            this.AddStockItemButton.Size = new System.Drawing.Size(190, 29);
            this.AddStockItemButton.TabIndex = 80;
            this.AddStockItemButton.Text = "ADD STOCK ITEM";
            this.AddStockItemButton.UseVisualStyleBackColor = false;
            this.AddStockItemButton.Click += new System.EventHandler(this.AddStockItemButton_Click);
            // 
            // StockPriceTextbox
            // 
            this.StockPriceTextbox.Enabled = false;
            this.StockPriceTextbox.Location = new System.Drawing.Point(288, 269);
            this.StockPriceTextbox.Name = "StockPriceTextbox";
            this.StockPriceTextbox.Size = new System.Drawing.Size(250, 31);
            this.StockPriceTextbox.TabIndex = 81;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(288, 325);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(250, 31);
            this.DateTimePicker.TabIndex = 77;
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
            this.DateLabel.TabIndex = 67;
            this.DateLabel.Text = "Date: ";
            // 
            // SelectedSupplierLabel
            // 
            this.SelectedSupplierLabel.AutoSize = true;
            this.SelectedSupplierLabel.BackColor = System.Drawing.Color.SeaShell;
            this.SelectedSupplierLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedSupplierLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SelectedSupplierLabel.Location = new System.Drawing.Point(992, 139);
            this.SelectedSupplierLabel.Name = "SelectedSupplierLabel";
            this.SelectedSupplierLabel.Size = new System.Drawing.Size(221, 47);
            this.SelectedSupplierLabel.TabIndex = 82;
            this.SelectedSupplierLabel.Text = "<supplier>";
            // 
            // StockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.SelectedSupplierLabel);
            this.Controls.Add(this.StockPriceTextbox);
            this.Controls.Add(this.AddStockItemButton);
            this.Controls.Add(this.StockItemsListLabel);
            this.Controls.Add(this.StockItemsDataGridView);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.SupplierComboBox);
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
            this.Name = "StockManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManagementForm";
            this.Load += new System.EventHandler(this.StockManagementForm_Load);
            this.CustomesManagementTopPanel.ResumeLayout(false);
            this.CustomesManagementTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel CustomesManagementTopPanel;
        private Label ClosingLabel;
        private Label InventorySystemLabel;
        private Label CreateStockLabel;
        private ComboBox SupplierComboBox;
        private Button ClearButton;
        private Button CreateButton;
        private Label DescriptionLabel;
        private RichTextBox DescriptionRichTextBox;
        private Label StockPriceLabel;
        private Label SupplierNameLabel;
        private Button HomeButton;
        private Label StockItemsListLabel;
        private DataGridView StockItemsDataGridView;
        private Button AddStockItemButton;
        private TextBox StockPriceTextbox;
        private DateTimePicker DateTimePicker;
        private Label DateLabel;
        private Label SelectedSupplierLabel;
    }
}