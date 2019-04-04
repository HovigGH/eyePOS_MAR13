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
    public partial class employee_settings_Form : Form
    {
        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        string accessLevelSelected =  "regular";
        public employee_settings_Form()
        {
            InitializeComponent();
            displayDataGridView();
            rdbtnRegEmp.Checked = true;
            this.WindowState = FormWindowState.Maximized;
        }

        DataTable vt = new DataTable();
        public void displayDataGridView()
        {
            string sqlstr = "SELECT * FROM employee";
            try
            {
                vt.Clear();
                OleDbDataAdapter dad = new OleDbDataAdapter(sqlstr, constr);
                dad.Fill(vt);
                dad.Dispose();
                dad = null;
                dgvEmployees.DataSource = vt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }


        //Add a new eployee
        private void lblEmpAdd_Click(object sender, EventArgs e)
        {
            if (dialogBox("Are you sure that you want to add the entered employee " + lblIdValue.Text, "Add Employee"))
            {
                //check if all info are entered 
                if (checkIfFilled())
                {
                    try
                    {
                        //Add to the DB
                        using (var con = new OleDbConnection())
                        {
                            con.ConnectionString = connectionStr;
                            con.Open();
                            using (var com = new OleDbCommand())
                            {
                                //SQL satetment
                                com.Connection = con;
                                com.CommandText = "INSERT INTO employee ([Full_Name],[position],[password],[access_level]) VALUES (@Full_Name,@position,@password,@access_level)";
                                com.Parameters.AddWithValue("@Full_Name", txtEmpName.Text);
                                com.Parameters.AddWithValue("@position", txtEmpPosition.Text);
                                com.Parameters.AddWithValue("@password", txtEmpPass.Text);
                                com.Parameters.AddWithValue("@access_level", whichRBTIsChecked());
                                com.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Added, New employee");
                        displayDataGridView();
                        clearSelections();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not saved: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Fill all fields");
            }
        }

        //Edit existing Employee
        private void lblEmpEdit_Click(object sender, EventArgs e)
        {
            if (dialogBox("Are you sure that you want to edit sellected employee " + lblIdValue.Text, "Edit Employee"))
            {
                try
                {
                    using (var con = new OleDbConnection())
                    {
                        con.ConnectionString = connectionStr;
                        con.Open();

                        using (var com = new OleDbCommand())
                        {
                            //Update DB
                            //SQL satetment
                            com.Connection = con;
                            com.CommandText = "UPDATE employee SET [Full_Name] = @Full_Name, [position] = @position , [password] = @password, [access_level] = @access_level WHERE [ID] = @ID;";
                            com.Parameters.AddWithValue("@Full_Name", txtEmpName.Text);
                            com.Parameters.AddWithValue("@position", txtEmpPosition.Text);
                            com.Parameters.AddWithValue("@password", txtEmpPass.Text);
                            com.Parameters.AddWithValue("@access_level", whichRBTIsChecked());
                            com.Parameters.AddWithValue("@ID", lblIdValue.Text);
                            com.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Edited, employee " + lblIdValue.Text);
                    displayDataGridView();
                    clearSelections();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not saved: " + ex.Message);
                }
            }
        }

        //Delete exiting employee
        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            //if a employee is selected
            if (lblIdValue.Text != "")
            {
                if (dialogBox("Are you sure that you want to delete employee " + lblIdValue.Text, "Delete Employee"))
                {
                    try
                    {
                        //Delete From DB
                        using (var con = new OleDbConnection())
                        {
                            con.ConnectionString = connectionStr;
                            con.Open();
                            using (var com = new OleDbCommand())
                            {
                                //SQL satetment
                                com.Connection = con;
                                com.CommandText = "DELETE FROM employee WHERE [ID] = @ID;";
                                com.Parameters.AddWithValue("@ID", lblIdValue.Text);
                                com.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Deleted successfully, employee " + lblIdValue.Text);
                        displayDataGridView(); //update data grid view
                        clearSelections();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not saved: " + ex.Message);
                    }
                }
            }
            else if (lblIdValue.Text == "")
                MessageBox.Show("No selection, Please select an employee!");
        }

        //Radio buttin for access level check change
        private void rdbtnRegEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRegEmp.Checked == true && rdbtnAdmin.Checked == false)
                accessLevelSelected = "regular";
            else if (rdbtnAdmin.Checked == true && rdbtnRegEmp.Checked == false)
                accessLevelSelected = "admin";
        }

        //Click event handller of any click in the data grid view
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dgvEmployees.Rows[index];
            lblIdValue.Text = selectedRow.Cells[0].Value.ToString();
            txtEmpName.Text = selectedRow.Cells[1].Value.ToString();
            txtEmpPosition.Text = selectedRow.Cells[2].Value.ToString();
            txtEmpPass.Text = selectedRow.Cells[3].Value.ToString();

            //manage employee admin/regular--access level radio buttons
            if (selectedRow.Cells[4].Value.ToString() == "admin")
            {
                rdbtnAdmin.Checked = true;
                rdbtnRegEmp.Checked = false;
            }
            else if (selectedRow.Cells[4].Value.ToString() == "regular")
            {
                rdbtnAdmin.Checked = false;
                rdbtnRegEmp.Checked = true;
            }
            else 
            {
                rdbtnAdmin.Checked = false;
                rdbtnRegEmp.Checked = false;
            }
        }

        //reset all textboxes
        private void btnClearBoxs_Click(object sender, EventArgs e)
        {
            clearSelections();
        }

        //Go back to home page
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Custom message box
        public bool dialogBox(string message, string title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                MessageBox.Show("No Change", title);

            return false;
        }

        //Reset all selections
        public void clearSelections()
        {
            txtEmpName.Text = "";
            txtEmpPass.Text = "";
            txtEmpPosition.Text = "";
            rdbtnAdmin.Checked = false;
            rdbtnRegEmp.Checked = true;
        }

        //Check inputs
        public bool checkIfFilled()
        {
            if (txtEmpName.Text == "" || txtEmpPass.Text == "" || txtEmpPosition.Text == "" || accessLevelSelected == "")
                return false;
            return true;
        }

        //Get what access level is specified
        public string whichRBTIsChecked()
        {
            if (rdbtnAdmin.Checked)
                return "admin";
            else if (rdbtnRegEmp.Checked)
                return "regular";
            return "not selected";
        }

       
    }
}