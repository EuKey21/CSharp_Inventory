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
using CSharp_Inventory.Models;
using CSharp_Inventory.DataProcessing;

namespace CSharp_Inventory
{
    public partial class UsersManagementForm : Form
    {
        const string table = "UserTable";
        const string primaryKeyLabel = "Username";

        public UsersManagementForm()
        {
            InitializeComponent();
        }
        
        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm() == true)
            {
                if (Config.Connection.IsDataUnique(table, primaryKeyLabel, UsernameTextbox.Text) == true)
                {
                    PersonModel person = new PersonModel();
                    person.UserName = UsernameTextbox.Text;
                    person.Password = PasswordTextbox.Text;
                    person.FirstName = FirstNameTextbox.Text;
                    person.LastName = LastNameTextbox.Text;
                    person.Gender = char.Parse(GenderTextbox.Text.ToUpper());
                    person.Age = int.Parse(AgeTextbox.Text);
                    person.Email = EmailTextbox.Text;

                    Config.Connection.AddPerson(person);
                    MessageBox.Show("User Successfully Added");
                    UsersDataGridView.DataSource = Config.Connection.PopulateTable(table);
                }
                else
                {
                    MessageBox.Show("Username already existed");
                }
            }
                
        }

        private bool ValidateForm()
        {
            if (UsernameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (PasswordTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }
            else if (PasswordTextbox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters");
            }

            if (FirstNameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (LastNameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (GenderTextbox.Text.Length != 0
                && char.Parse(GenderTextbox.Text.ToUpper()) != 'M'
                && char.Parse(GenderTextbox.Text.ToUpper()) != 'F'
                )
            {
                MessageBox.Show("Please enter M or F for gender, or leave it blank");
                return false;
            }

            if (AgeTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }
            else if (AgeTextbox.Text.Length < 0)
            {
                MessageBox.Show("No negative age");
            }

            if (EmailTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }
            else
            {
                int valid = 0;
                foreach (char c in EmailTextbox.Text)
                {
                    if (c == '@')
                    {
                        valid += 1;
                    }
                    if (c == '.')
                    {
                        valid *= 5;
                        break;
                    }
                }
                if (valid != 5)
                {
                    MessageBox.Show("Invalid Email address");
                    return false;
                }
            }

            return true;
        }

        private void UsersManagementForm_Load(object sender, EventArgs e)
        {
            UsersDataGridView.DataSource = Config.Connection.PopulateTable(table);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please select record to be deleted");
            }
            else
            {
                // validate if record exists
                if (Config.Connection.IsDataUnique(table, primaryKeyLabel, UsernameTextbox.Text) == false)
                {
                    Config.Connection.DeleteRecord(table, primaryKeyLabel, UsernameTextbox.Text);
                    MessageBox.Show("User Successfully Deleted");
                    UsersDataGridView.DataSource = Config.Connection.PopulateTable(table);
                }
                else
                {
                    MessageBox.Show("This usernamer does not exist");
                }
                    
            }

        }

        private void UsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = UsersDataGridView.Rows[e.RowIndex];

                UsernameTextbox.Text = row.Cells[0].Value.ToString();
                PasswordTextbox.Text = row.Cells[1].Value.ToString();
                FirstNameTextbox.Text = row.Cells[2].Value.ToString();
                LastNameTextbox.Text = row.Cells[3].Value.ToString();
                GenderTextbox.Text = row.Cells[4].Value.ToString();
                AgeTextbox.Text = row.Cells[5].Value.ToString();
                EmailTextbox.Text = row.Cells[6].Value.ToString();
            } 
        }

        private void UsersDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SharedMethods.PrintRowNumToGridView(sender, e);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UsernameTextbox.Clear();
            PasswordTextbox.Clear();
            FirstNameTextbox.Clear();
            LastNameTextbox.Clear();
            GenderTextbox.Clear();
            AgeTextbox.Clear();
            EmailTextbox.Clear();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                // validate if record exists
                if (Config.Connection.IsDataUnique(table, primaryKeyLabel, UsernameTextbox.Text) == false)
                {
                    PersonModel person = new PersonModel();
                    person.UserName = UsernameTextbox.Text;
                    person.Password = PasswordTextbox.Text;
                    person.FirstName = FirstNameTextbox.Text;
                    person.LastName = LastNameTextbox.Text;
                    person.Gender = char.Parse(GenderTextbox.Text.ToUpper());
                    person.Age = int.Parse(AgeTextbox.Text);
                    person.Email = EmailTextbox.Text;

                    Config.Connection.EditPerson(person);
                    MessageBox.Show("User Successfully Edited");
                    UsersDataGridView.DataSource = Config.Connection.PopulateTable(table);
                }
                else
                {
                    MessageBox.Show("Username is not allowed to be edited");
                }
                    
            }
        }
    }
}
