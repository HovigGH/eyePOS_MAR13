using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class EmployeeLogInForm : Form
    {
        //strings for db
        //connection and sql strings
        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        string sqlstr = "SELECT * FROM employee";
        public EmployeeLogInForm()
        {
            InitializeComponent();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool authorize = false;
            //data table
            DataTable vt = new DataTable();
            // this.Hide();
            //  this.Close();
            if (valid())
            {
                try
                {
                    OleDbDataAdapter dad = new OleDbDataAdapter(sqlstr, constr);
                    dad.Fill(vt);
                    dad.Dispose();
                    dad = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                if (IsDigitsOnly(txtUserName.Text))
                {
                    for (int i = 0; i < vt.Rows.Count; i++)
                    {
                        if (Convert.ToInt16(vt.Rows[i][0]) == Convert.ToInt16(txtUserName.Text))
                        {
                            if (Convert.ToString(vt.Rows[i][3]) == txtPassword.Text)
                            {
                                authorize = true;
                                if (Convert.ToString(vt.Rows[i][4]) == "admin")
                                {
                                    EmployeeForm1 employeeForm1 = new EmployeeForm1("admin");
                                    this.Hide();
                                    employeeForm1.Show();
                                }
                            }
                        }

                    }
                    if (!authorize)
                    {
                        MessageBox.Show("Authentication Failed, try again with correct user id and password");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid username");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
            }
            else
                MessageBox.Show("Eneter user Id and password to log in");

        }
        bool valid()
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
                return false;
            return true;
        }
        //check if text is digit nubers only
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
        }
    }
}
