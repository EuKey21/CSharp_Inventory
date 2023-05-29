namespace CSharp_inventory
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            UsernameTextbox.Clear();
            PasswordTextbox.Clear();
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckbox.Checked == true)
            {
                PasswordTextbox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextbox.PasswordChar = '*';
            }
        }

        private void ClearLable_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}