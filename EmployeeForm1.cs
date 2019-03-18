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
    public partial class EmployeeForm1 : Form
    {
        
        public EmployeeForm1(string accessLevel)
        {
            InitializeComponent();
            displayDataGridView();
            if (accessLevel == "admin")
            {
                btnEmployeeSettings.Visible = true;
            }
            else
            {
                btnEmployeeSettings.Visible = false;
            }
        }

        private void upcSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void btnNameSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInvButton_Click(object sender, EventArgs e)
        {

        }

        private void btnRefund_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnUserView_Click(object sender, EventArgs e)
        {

        }
        public void displayDataGridView()
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
            string sqlstr = "SELECT * FROM items";
            DataTable vt = new DataTable();

                try
                {
                    OleDbDataAdapter dad = new OleDbDataAdapter(sqlstr, constr);
                    dad.Fill(vt);
                    dad.Dispose();
                    dad = null;
                    dgvInventory.DataSource = vt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }      
        }

        private void btnEmployeeSettings_Click(object sender, EventArgs e)
        {
            employee_settings_Form employee_Settings_Form = new employee_settings_Form();
			this.Hide();
			employee_Settings_Form.ShowDialog();
			this.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
        }
    }
}
