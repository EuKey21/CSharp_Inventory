namespace CSharp_Inventory
{
    partial class HomePageFrom
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
            this.CustomesManagementTopPanel = new System.Windows.Forms.Panel();
            this.ClosingLabel = new System.Windows.Forms.Label();
            this.InventorySystemLabel = new System.Windows.Forms.Label();
            this.HomePageLabel = new System.Windows.Forms.Label();
            this.ManageUserButton = new System.Windows.Forms.Button();
            this.ManageSupplierButton = new System.Windows.Forms.Button();
            this.ManageCustomerButton = new System.Windows.Forms.Button();
            this.ManageItemCategoryButton = new System.Windows.Forms.Button();
            this.ManageItemButton = new System.Windows.Forms.Button();
            this.ManageStockButton = new System.Windows.Forms.Button();
            this.ManageSaleButton = new System.Windows.Forms.Button();
            this.ViewTradeHistoryButton = new System.Windows.Forms.Button();
            this.CustomesManagementTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomesManagementTopPanel
            // 
            this.CustomesManagementTopPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.CustomesManagementTopPanel.Controls.Add(this.ClosingLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.InventorySystemLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.HomePageLabel);
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
            // HomePageLabel
            // 
            this.HomePageLabel.AutoSize = true;
            this.HomePageLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomePageLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.HomePageLabel.Location = new System.Drawing.Point(439, 55);
            this.HomePageLabel.Name = "HomePageLabel";
            this.HomePageLabel.Size = new System.Drawing.Size(372, 70);
            this.HomePageLabel.TabIndex = 1;
            this.HomePageLabel.Text = "Home Page";
            // 
            // ManageUserButton
            // 
            this.ManageUserButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ManageUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageUserButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageUserButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ManageUserButton.Location = new System.Drawing.Point(67, 162);
            this.ManageUserButton.Name = "ManageUserButton";
            this.ManageUserButton.Size = new System.Drawing.Size(431, 72);
            this.ManageUserButton.TabIndex = 16;
            this.ManageUserButton.Text = "Manage User";
            this.ManageUserButton.UseVisualStyleBackColor = false;
            this.ManageUserButton.Click += new System.EventHandler(this.ManageUserButton_Click);
            // 
            // ManageSupplierButton
            // 
            this.ManageSupplierButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ManageSupplierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageSupplierButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageSupplierButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ManageSupplierButton.Location = new System.Drawing.Point(67, 285);
            this.ManageSupplierButton.Name = "ManageSupplierButton";
            this.ManageSupplierButton.Size = new System.Drawing.Size(431, 72);
            this.ManageSupplierButton.TabIndex = 17;
            this.ManageSupplierButton.Text = "Manage Supplier";
            this.ManageSupplierButton.UseVisualStyleBackColor = false;
            this.ManageSupplierButton.Click += new System.EventHandler(this.ManageSupplierButton_Click);
            // 
            // ManageCustomerButton
            // 
            this.ManageCustomerButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ManageCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageCustomerButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageCustomerButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ManageCustomerButton.Location = new System.Drawing.Point(67, 410);
            this.ManageCustomerButton.Name = "ManageCustomerButton";
            this.ManageCustomerButton.Size = new System.Drawing.Size(431, 72);
            this.ManageCustomerButton.TabIndex = 18;
            this.ManageCustomerButton.Text = "Manage Customer";
            this.ManageCustomerButton.UseVisualStyleBackColor = false;
            this.ManageCustomerButton.Click += new System.EventHandler(this.ManageCustomerButton_Click);
            // 
            // ManageItemCategoryButton
            // 
            this.ManageItemCategoryButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ManageItemCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageItemCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageItemCategoryButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageItemCategoryButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ManageItemCategoryButton.Location = new System.Drawing.Point(67, 538);
            this.ManageItemCategoryButton.Name = "ManageItemCategoryButton";
            this.ManageItemCategoryButton.Size = new System.Drawing.Size(431, 72);
            this.ManageItemCategoryButton.TabIndex = 19;
            this.ManageItemCategoryButton.Text = "Manage Item Category";
            this.ManageItemCategoryButton.UseVisualStyleBackColor = false;
            this.ManageItemCategoryButton.Click += new System.EventHandler(this.ManageItemCategoryButton_Click);
            // 
            // ManageItemButton
            // 
            this.ManageItemButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ManageItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageItemButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageItemButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ManageItemButton.Location = new System.Drawing.Point(724, 162);
            this.ManageItemButton.Name = "ManageItemButton";
            this.ManageItemButton.Size = new System.Drawing.Size(431, 72);
            this.ManageItemButton.TabIndex = 20;
            this.ManageItemButton.Text = "Manage Item";
            this.ManageItemButton.UseVisualStyleBackColor = false;
            this.ManageItemButton.Click += new System.EventHandler(this.ManageItemButton_Click);
            // 
            // ManageStockButton
            // 
            this.ManageStockButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ManageStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageStockButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageStockButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ManageStockButton.Location = new System.Drawing.Point(724, 285);
            this.ManageStockButton.Name = "ManageStockButton";
            this.ManageStockButton.Size = new System.Drawing.Size(431, 72);
            this.ManageStockButton.TabIndex = 21;
            this.ManageStockButton.Text = "Manage Stock";
            this.ManageStockButton.UseVisualStyleBackColor = false;
            this.ManageStockButton.Click += new System.EventHandler(this.ManageStockButton_Click);
            // 
            // ManageSaleButton
            // 
            this.ManageSaleButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ManageSaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageSaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageSaleButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageSaleButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ManageSaleButton.Location = new System.Drawing.Point(724, 410);
            this.ManageSaleButton.Name = "ManageSaleButton";
            this.ManageSaleButton.Size = new System.Drawing.Size(431, 72);
            this.ManageSaleButton.TabIndex = 22;
            this.ManageSaleButton.Text = "Manage Sale";
            this.ManageSaleButton.UseVisualStyleBackColor = false;
            this.ManageSaleButton.Click += new System.EventHandler(this.ManageSaleButton_Click);
            // 
            // ViewTradeHistoryButton
            // 
            this.ViewTradeHistoryButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ViewTradeHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewTradeHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTradeHistoryButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewTradeHistoryButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ViewTradeHistoryButton.Location = new System.Drawing.Point(724, 538);
            this.ViewTradeHistoryButton.Name = "ViewTradeHistoryButton";
            this.ViewTradeHistoryButton.Size = new System.Drawing.Size(431, 72);
            this.ViewTradeHistoryButton.TabIndex = 23;
            this.ViewTradeHistoryButton.Text = "View Trade History";
            this.ViewTradeHistoryButton.UseVisualStyleBackColor = false;
            this.ViewTradeHistoryButton.Click += new System.EventHandler(this.ViewTradeHistoryButton_Click);
            // 
            // HomePageFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ViewTradeHistoryButton);
            this.Controls.Add(this.ManageSaleButton);
            this.Controls.Add(this.ManageStockButton);
            this.Controls.Add(this.ManageItemButton);
            this.Controls.Add(this.ManageItemCategoryButton);
            this.Controls.Add(this.ManageCustomerButton);
            this.Controls.Add(this.ManageSupplierButton);
            this.Controls.Add(this.ManageUserButton);
            this.Controls.Add(this.CustomesManagementTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomePageFrom";
            this.CustomesManagementTopPanel.ResumeLayout(false);
            this.CustomesManagementTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel CustomesManagementTopPanel;
        private Label ClosingLabel;
        private Label InventorySystemLabel;
        private Label HomePageLabel;
        private Button ManageUserButton;
        private Button ManageSupplierButton;
        private Button ManageCustomerButton;
        private Button ManageItemCategoryButton;
        private Button ManageItemButton;
        private Button ManageStockButton;
        private Button ManageSaleButton;
        private Button ViewTradeHistoryButton;
    }
}