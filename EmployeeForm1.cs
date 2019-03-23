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
                btnEmployeeSettings.Visible = true;
            else
                btnEmployeeSettings.Visible = false;
        }

        private void upcSearchButton_Click(object sender, EventArgs e)
        {
			string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
			string sqlstr = "SELECT * FROM items WHERE barcode = @barcode";

			string value = searchTextBox.Text;

			DataTable dt = new DataTable();


			using (OleDbConnection connection = new OleDbConnection(constr))
			{
				OleDbDataAdapter adapter = new OleDbDataAdapter();

				OleDbCommand selectCMD = new OleDbCommand(sqlstr, connection);
				adapter.SelectCommand = selectCMD;

				// Add parameters and set values.  
				selectCMD.Parameters.Add(
				  "@BarCode", OleDbType.VarChar, 18).Value = value;

				adapter.Fill(dt);
				dgvInventory.ReadOnly = true;
				dgvInventory.DataSource = dt;
			}
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
        }

		private void clearButton_Click(object sender, EventArgs e)
		{
			searchTextBox.Text = "";
		}
	}
}
