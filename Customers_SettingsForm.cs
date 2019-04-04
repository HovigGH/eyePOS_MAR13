using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class Customers_SettingsForm : Form
    {
        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        DataTable vt = new DataTable();

        public Customers_SettingsForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
            displayDataGridViewCust();
        }

        private void dgvCustms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProfile.Text = "";
            int index = e.RowIndex;// get the Row Index
            //DataGridViewRow selectedRow = dgvCustms.Rows[index];
            string id__ = dgvCustms.Rows[index].Cells[0].Value.ToString();
            //string id__= dgvCustms.Rows[DataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()
            string path = "profiles\\" + id__ + ".txt";
            string line = "";
            if (File.Exists(path))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    txtProfile.Text += line + Environment.NewLine;
                }
                file.Close();
            }
            else
            {
                MessageBox.Show("Error", "Profile not found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtProfile.Text = "";
            }
        }

        public void displayDataGridViewCust()
        {
            DataTable vt = new DataTable();
            string sqlstr = "SELECT * FROM customers";
            try
            {
                vt.Clear();
                OleDbDataAdapter dad = new OleDbDataAdapter(sqlstr, constr);
                dad.Fill(vt);
                dad.Dispose();
                dad = null;
                dgvCustms.DataSource = vt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
