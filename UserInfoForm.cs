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
	public partial class UserInfoForm : Form
	{
        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        bool dateOfBithChecked = false, gender = false;
		public UserInfoForm()
		{
            InitializeComponent();
			dateTimePickerDOB.CustomFormat = "dd-MM-yyyy";

		}

		private void submitButton_Click(object sender, EventArgs e)
		{
            //submit
            if(checkInput() == true && dialogBox("Customer profile will be created", "Create customer profile") == true)
            {
                    try
                    {
                        using (var con = new OleDbConnection())
                        {
                            con.ConnectionString = connectionStr;
                            con.Open();

                            using (var com = new OleDbCommand())
                        {
                            com.Connection = con;
                                com.CommandText = "INSERT INTO customers ([cust_name],[cust_email],[cust_dob],[cust_address],[cust_post]) " +
                                                  "VALUES (@cust_name,@cust_email,@cust_dob,@cust_address,@cust_post)";

                                com.Parameters.AddWithValue("@cust_name", nameTB.Text);
                                com.Parameters.AddWithValue("@cust_email", emailTB.Text);
                                com.Parameters.AddWithValue("@cust_dob", dateTimePickerDOB.Value);
                                com.Parameters.AddWithValue("@cust_address", addressTB.Text);
                                com.Parameters.AddWithValue("@cust_post", postalTB.Text);

                            com.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("A new customer profile has been created.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not Saved: " + ex.Message);
                    }
              
                this.Close();
            }

            
		}

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChange(object sender, EventArgs e)
        {
            dateOfBithChecked = true;
        }
        
        public bool checkInput()
        {
            if (nameTB.Text == "" || emailTB.Text == "" || countryTB.Text == "" || addressTB.Text == "" || postalTB.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.");
                return false;
            }
            else if (dateOfBithChecked == false)
            {
                MessageBox.Show("Please enter your date of birth.");
                return false;
            }
            else if (gender == false)
            {
                MessageBox.Show("Please select a gender.");
                return false;
            }
            return true;
        }

        public bool dialogBox(string message, string title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                MessageBox.Show("No Changes.", title);

            return false;
        }

		private void UserInfoForm_Load(object sender, EventArgs e)
		{

		}

		private void skipButton_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void radioBtns_CheckedChanged(object sender, EventArgs e)
        {
            gender = true;
        }
    }
}
