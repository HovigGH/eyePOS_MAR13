using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//This form gets authentication for the employees whenver needed. It connects to employee table
namespace MultiFaceRec
{
    public partial class EmployeeLogInForm : Form
    {
        //strings for db
        //connection and sql strings
        //this form is called by welcome Form and CustScanForm
        string beenCalledBy = "";
        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        string sqlstr = "SELECT * FROM employee";
        //Constructor
        public EmployeeLogInForm(string text)
        {
            beenCalledBy = text;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            txtPassword.PasswordChar = '*';
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool authorize = false;
            DataTable vt = new DataTable();        //data table
            //if the inputs are valid go to the DB
            if (valid())
            {
                //Exception Handlling for any errors
                //Fill the data table with all the employee info
                try
                {
                    OleDbDataAdapter dad = new OleDbDataAdapter(sqlstr, constr);
                    dad.Fill(vt);
                    dad.Dispose();
                    dad = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex, "No Photo availble", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //Check to make sure if username contains any non numeric characters
                if (IsDigitsOnly(txtUserName.Text))
                {
                    for (int i = 0; i < vt.Rows.Count; i++)
                    {
                        //Check the user ID entered with the corresponding one in the Data table
                        if (Convert.ToInt16(vt.Rows[i][0]) == Convert.ToInt16(txtUserName.Text))
                        {
                            //If username found chech the entered password
                            if (Convert.ToString(vt.Rows[i][3]) == txtPassword.Text)
                            {
                                authorize = true; //authorization been granted
                                 //if this form was called from the welcome form 
                                 //if the logged in employee is an admin, pass it to EmployeeForm1
                                 if (beenCalledBy == "WelcomeForm" && Convert.ToString(vt.Rows[i][4]) == "admin")
                                 {
									this.Hide();
									EmployeeForm1 employeeForm1 = new EmployeeForm1("admin");
									employeeForm1.ShowDialog();
									this.Close();
								 }
                                //if the logged in employee is a regular employee, pass it to EmployeeForm1
                                if (beenCalledBy == "WelcomeForm" && Convert.ToString(vt.Rows[i][4]) == "regular")
                                 {
									this.Hide();
									EmployeeForm1 employeeForm1 = new EmployeeForm1("regular");
									employeeForm1.ShowDialog();
									this.Close();
                                 }
                                //if this form was called from the CustScan form loopback
                                else if (beenCalledBy == "CustScanForm")
                                {
                                    this.Hide();
									CustScanForm custScanForm = new CustScanForm("EmployeeLoginForm","CustScanForm");
                                    custScanForm.ShowDialog();
									this.Close();
                                }
                            }
                        }
                    }
                    //in case authentication fails
                    if (!authorize)
                    {
                        MessageBox.Show("Authentication Failed, try again with correct user id and password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                    }
                }
                //in case of non valid username
                else
                {
                    MessageBox.Show("Please enter a valid username.");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
            }
            else
                MessageBox.Show("Enter a User ID and password to log in.");
        }
        
        //Event Handller to clear buttons text
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }

        //Event Handller to go back to home page
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //check if textboxes have values
        public bool valid()
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

    }
}
