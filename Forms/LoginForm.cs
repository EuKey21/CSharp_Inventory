using CSharp_Inventory;
using CSharp_Inventory.DataProcessing;
using CSharp_Inventory.Models;

namespace CSharp_inventory
{
    public partial class LoginForm : Form
    {
        // for testing
        private void CreateAdmin()
        {
            PersonModel admin = new PersonModel();
            admin.UserName = "Admin";
            admin.Password = "12345678";
            admin.FirstName = "admin";
            admin.LastName = "admin";
            admin.Gender = 'M';
            admin.Age = 0;
            admin.Email = "admin@admin.com";
            Config.Connection.AddPerson(admin);
        }

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
            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;

            if(Config.Connection.ValidateLogin(username, password))
            {
                MessageBox.Show("Successfully Login");
                PersonModel user = Config.Connection.GetPerson(username);
                HomePageFrom childForm = new HomePageFrom(user);
                Hide();
                childForm.Show();
            }
            else
            {
                MessageBox.Show("No Matching User");
                ClearInput();
            }
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Terminate the application? ", "Warning", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Create an Admin if there is none for testing purpose
            if (!Config.Connection.IsDataUnique(Table.User, Table.UserColumn.UserName, "Admin"))
            {
                CreateAdmin();
            }

        }
    }
}