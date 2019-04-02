using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//This form gets the information regarding the new customer
namespace MultiFaceRec
{
	public partial class UserInfoForm : Form
	{
        //DB variables
        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
		//info from the customer
		bool dateOfBithChecked = false;
		string gender = null;
        public UserInfoForm()
		{
            InitializeComponent();
			dateTimePickerDOB.CustomFormat = "dd-MM-yyyy";  //set the format for the date-time picker
            this.WindowState = FormWindowState.Maximized;
            dateTimePickerDOB.MaxDate = DateTime.Today;       //Constructor
        }

        private void submitButton_Click(object sender, EventArgs e)
		{
            //submit
            //check the inputs entered
            if(checkInput() == true && dialogBox("Customer profile will be created", "Create customer profile") == true)
            {
                //connect to the DB and insert the info
                    try
                    {
                        using (var con = new OleDbConnection())
                        {
                            con.ConnectionString = connectionStr;
                            con.Open();

                            using (var com = new OleDbCommand())
                            {
                                com.Connection = con;
                                com.CommandText = "INSERT INTO customers ([cust_name],[cust_email],[cust_dob],[cust_address],[cust_post][gender]) " +
                                                  "VALUES (@cust_name,@cust_email,@cust_dob,@cust_address,@cust_post,@cust_gender)";
                                //set insert values
                                com.Parameters.AddWithValue("@cust_name", nameTB.Text);
                                com.Parameters.AddWithValue("@cust_email", emailTB.Text);
                                com.Parameters.AddWithValue("@cust_dob", dateTimePickerDOB.Value);
                                com.Parameters.AddWithValue("@cust_address", addressTB.Text);
                                com.Parameters.AddWithValue("@cust_post", postalTB.Text);
								com.Parameters.AddWithValue("@cust_gender", gender);
								com.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("A new customer profile has been created.","New customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not Saved: " + ex.Message);
                    }
                //if successfully inserted  
                this.Hide();
                CustScanForm custscan = new CustScanForm("CustomerTypeForm", "new");
                custscan.ShowDialog();
            }     
		}

        //Back to home form
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //time picker change event
        private void dateTimePicker1_ValueChange(object sender, EventArgs e)
        {
            dateOfBithChecked = true;
        }
        
        //takes the user to checkout form whitout entering info
		private void skipButton_Click(object sender, EventArgs e)
		{
			/*
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
                        //set insert values
                        com.Parameters.AddWithValue("@cust_name", "");
                        com.Parameters.AddWithValue("@cust_email", "");
                        com.Parameters.AddWithValue("@cust_dob", "");
                        com.Parameters.AddWithValue("@cust_address", "");
                        com.Parameters.AddWithValue("@cust_post", "");
						com.Parameters.AddWithValue("@cust_gender", "");
						com.ExecuteNonQuery();
                    }
                }
                //MessageBox.Show("A new customer profile has been created.","New customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Saved: " + ex.Message);
            }
			*/
            this.Hide();
            CustScanForm custscan = new CustScanForm("CustomerTypeForm", "guest");
            custscan.ShowDialog();
            this.Close();
        }

        //A function which validates the user input
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
            return true;
        }

        //a method to get custom message boxes 
        public bool dialogBox(string message, string title)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                MessageBox.Show("No Changes.", title);

            return false;
        }

        //the events makes sure the user checked the gender radio button
        private void radioBtns_CheckedChanged(object sender, EventArgs e)
        {
			if (maleRadio.Checked)
				gender = "M";
			else if (femaleRadio.Checked)
				gender = "F";
			else
				gender = "O";
        }

		private void dataInfo_Click(object sender, EventArgs e)
		{
			string message = "Information collected will be used to direct promotional emails, coupons, and your purchase receipts to you.\n" +
				"A photo will be taken of your face in order to allow for quicker login in the future.\n"
				+ "We will NOT share any information or photos with third parties. Any information collected will be used in internal demographics analysis.";
			string title = "Disclaimer";

			MessageBox.Show(message, title);
		}
	}
}
