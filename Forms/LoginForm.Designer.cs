namespace CSharp_inventory
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.ClearLable = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClosingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.ShowPasswordCheckbox);
            this.LoginPanel.Controls.Add(this.ClearLable);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PasswordTextbox);
            this.LoginPanel.Controls.Add(this.UsernameTextbox);
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Location = new System.Drawing.Point(200, 100);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(400, 600);
            this.LoginPanel.TabIndex = 0;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(50, 376);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(112, 28);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password: ";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(50, 327);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(117, 28);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ShowPasswordCheckbox
            // 
            this.ShowPasswordCheckbox.AutoSize = true;
            this.ShowPasswordCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordCheckbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowPasswordCheckbox.ForeColor = System.Drawing.Color.Crimson;
            this.ShowPasswordCheckbox.Location = new System.Drawing.Point(171, 524);
            this.ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            this.ShowPasswordCheckbox.Size = new System.Drawing.Size(179, 27);
            this.ShowPasswordCheckbox.TabIndex = 6;
            this.ShowPasswordCheckbox.Text = "Show Password";
            this.ShowPasswordCheckbox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckbox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckbox_CheckedChanged);
            // 
            // ClearLable
            // 
            this.ClearLable.AutoSize = true;
            this.ClearLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearLable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearLable.ForeColor = System.Drawing.Color.Crimson;
            this.ClearLable.Location = new System.Drawing.Point(62, 524);
            this.ClearLable.Name = "ClearLable";
            this.ClearLable.Size = new System.Drawing.Size(63, 23);
            this.ClearLable.TabIndex = 5;
            this.ClearLable.Text = "Clear";
            this.ClearLable.Click += new System.EventHandler(this.ClearLable_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.BurlyWood;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Info;
            this.LoginButton.Location = new System.Drawing.Point(50, 450);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(300, 60);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.Location = new System.Drawing.Point(171, 376);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(179, 31);
            this.PasswordTextbox.TabIndex = 3;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextbox.Location = new System.Drawing.Point(171, 327);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(179, 31);
            this.UsernameTextbox.TabIndex = 2;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LoginLabel.Location = new System.Drawing.Point(125, 35);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(150, 62);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(200, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inventory System";
            // 
            // ClosingLabel
            // 
            this.ClosingLabel.AutoSize = true;
            this.ClosingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosingLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClosingLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClosingLabel.Location = new System.Drawing.Point(3, 0);
            this.ClosingLabel.Name = "ClosingLabel";
            this.ClosingLabel.Size = new System.Drawing.Size(44, 46);
            this.ClosingLabel.TabIndex = 3;
            this.ClosingLabel.Text = "X";
            this.ClosingLabel.Click += new System.EventHandler(this.ClosingLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.ClosingLabel);
            this.panel1.Location = new System.Drawing.Point(735, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginPanel);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel LoginPanel;
        private Button LoginButton;
        private TextBox PasswordTextbox;
        private TextBox UsernameTextbox;
        private Label LoginLabel;
        private Label label2;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private PictureBox pictureBox1;
        private CheckBox ShowPasswordCheckbox;
        private Label ClearLable;
        private Label ClosingLabel;
        private Panel panel1;
    }
}