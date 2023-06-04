namespace CSharp_Inventory
{
    partial class TradeHistoryViewForm
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
            this.TradeHistoryLabel = new System.Windows.Forms.Label();
            this.TradeHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.NetIncomeTextbox = new System.Windows.Forms.TextBox();
            this.NetIncomeLabel = new System.Windows.Forms.Label();
            this.ViewItemButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.CustomesManagementTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TradeHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomesManagementTopPanel
            // 
            this.CustomesManagementTopPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.CustomesManagementTopPanel.Controls.Add(this.ClosingLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.InventorySystemLabel);
            this.CustomesManagementTopPanel.Controls.Add(this.TradeHistoryLabel);
            this.CustomesManagementTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomesManagementTopPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomesManagementTopPanel.Name = "CustomesManagementTopPanel";
            this.CustomesManagementTopPanel.Size = new System.Drawing.Size(1280, 125);
            this.CustomesManagementTopPanel.TabIndex = 2;
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
            // TradeHistoryLabel
            // 
            this.TradeHistoryLabel.AutoSize = true;
            this.TradeHistoryLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TradeHistoryLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TradeHistoryLabel.Location = new System.Drawing.Point(432, 55);
            this.TradeHistoryLabel.Name = "TradeHistoryLabel";
            this.TradeHistoryLabel.Size = new System.Drawing.Size(400, 70);
            this.TradeHistoryLabel.TabIndex = 1;
            this.TradeHistoryLabel.Text = "Trade History";
            // 
            // TradeHistoryDataGridView
            // 
            this.TradeHistoryDataGridView.AllowUserToAddRows = false;
            this.TradeHistoryDataGridView.AllowUserToDeleteRows = false;
            this.TradeHistoryDataGridView.AllowUserToResizeColumns = false;
            this.TradeHistoryDataGridView.AllowUserToResizeRows = false;
            this.TradeHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TradeHistoryDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TradeHistoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TradeHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TradeHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TradeHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.TradeHistoryDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.TradeHistoryDataGridView.Location = new System.Drawing.Point(73, 200);
            this.TradeHistoryDataGridView.Name = "TradeHistoryDataGridView";
            this.TradeHistoryDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TradeHistoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TradeHistoryDataGridView.RowHeadersWidth = 51;
            this.TradeHistoryDataGridView.RowTemplate.Height = 33;
            this.TradeHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TradeHistoryDataGridView.ShowCellToolTips = false;
            this.TradeHistoryDataGridView.ShowEditingIcon = false;
            this.TradeHistoryDataGridView.Size = new System.Drawing.Size(1138, 432);
            this.TradeHistoryDataGridView.TabIndex = 36;
            this.TradeHistoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TradeHistoryDataGridView_CellContentClick);
            // 
            // NetIncomeTextbox
            // 
            this.NetIncomeTextbox.Enabled = false;
            this.NetIncomeTextbox.Location = new System.Drawing.Point(598, 652);
            this.NetIncomeTextbox.Name = "NetIncomeTextbox";
            this.NetIncomeTextbox.Size = new System.Drawing.Size(218, 31);
            this.NetIncomeTextbox.TabIndex = 38;
            // 
            // NetIncomeLabel
            // 
            this.NetIncomeLabel.AutoSize = true;
            this.NetIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NetIncomeLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.NetIncomeLabel.Location = new System.Drawing.Point(457, 652);
            this.NetIncomeLabel.Name = "NetIncomeLabel";
            this.NetIncomeLabel.Size = new System.Drawing.Size(130, 28);
            this.NetIncomeLabel.TabIndex = 37;
            this.NetIncomeLabel.Text = "Net Income: ";
            // 
            // ViewItemButton
            // 
            this.ViewItemButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ViewItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewItemButton.FlatAppearance.BorderSize = 0;
            this.ViewItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewItemButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ViewItemButton.Location = new System.Drawing.Point(73, 651);
            this.ViewItemButton.Name = "ViewItemButton";
            this.ViewItemButton.Size = new System.Drawing.Size(128, 29);
            this.ViewItemButton.TabIndex = 39;
            this.ViewItemButton.Text = "View Items";
            this.ViewItemButton.UseVisualStyleBackColor = false;
            this.ViewItemButton.Click += new System.EventHandler(this.ViewItemButton_Click);
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
            this.HomeButton.TabIndex = 44;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // TradeHistoryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.ViewItemButton);
            this.Controls.Add(this.NetIncomeTextbox);
            this.Controls.Add(this.NetIncomeLabel);
            this.Controls.Add(this.TradeHistoryDataGridView);
            this.Controls.Add(this.CustomesManagementTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TradeHistoryViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TradeHistoryViewForm";
            this.Load += new System.EventHandler(this.TradeHistoryViewForm_Load);
            this.CustomesManagementTopPanel.ResumeLayout(false);
            this.CustomesManagementTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TradeHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel CustomesManagementTopPanel;
        private Label ClosingLabel;
        private Label InventorySystemLabel;
        private Label TradeHistoryLabel;
        private DataGridView TradeHistoryDataGridView;
        private TextBox NetIncomeTextbox;
        private Label NetIncomeLabel;
        private Button ViewItemButton;
        private Button HomeButton;
    }
}