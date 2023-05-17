using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSharp_Inventory
{
    public partial class UsersManagementForm : Form
    {
        public UsersManagementForm()
        {
            InitializeComponent();
        }

        SqlConnector sqlConnector = new SqlConnector();
        
        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel();
            person.UserName = UsernameTextbox.Text;
            person.Password = PasswordTextbox.Text;
            person.FirstName = FirstNameTextbox.Text;
            person.LastName = LastNameTextbox.Text;
            person.Gender = char.Parse(GenderTextbox.Text);
            person.Age = int.Parse(AgeTextbox.Text);
            person.Email = EmailTextbox.Text;

            sqlConnector.AddPerson(person);


        }
    }
}
