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
        
        //Add new eployee
        private void lblEmpAdd_Click(object sender, EventArgs e)
        {
            if (dialogBox("Are you sure that you want to add the entered employee " + lblIdValue.Text, "Add Employee"))
            {
                if (checkIfFilled())
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

        //Edite existing Employee
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
            if (lblIdValue.Text != "")
            {
                if (dialogBox("Are you sure that you want to delete employee " + lblIdValue.Text, "Delete Employee"))
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
                                com.CommandText = "DELETE FROM employee WHERE [ID] = @ID;";
                                com.Parameters.AddWithValue("@ID", lblIdValue.Text);
                                com.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Deleted successfully, employee " + lblIdValue.Text);
                        displayDataGridView();
                        clearSelections();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not saved: " + ex.Message);
                    }
                }
            }
            else if (lblIdValue.Text == "")
                MessageBox.Show("No sellection, Please select an employee!");

        }

        public void clearSelections()
        {
            txtEmpName.Text = "";
            txtEmpPass.Text = "";
            txtEmpPosition.Text = "";
            rdbtnAdmin.Checked = false;
            rdbtnRegEmp.Checked = true;
        }

        public bool checkIfFilled()
        {
            if (txtEmpName.Text == "" || txtEmpPass.Text == "" || txtEmpPosition.Text == "" || accessLevelSelected == "")
                return false;
            return true;
        }

        public string whichRBTIsChecked()
        {
            if (rdbtnAdmin.Checked)
                return "admin";
            else if (rdbtnRegEmp.Checked)
                return "regular";
            return "not selected";
        }

        private void rdbtnRegEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRegEmp.Checked == true && rdbtnAdmin.Checked == false)
                accessLevelSelected = "regular";
            else if (rdbtnAdmin.Checked == true && rdbtnRegEmp.Checked == false)
                accessLevelSelected = "admin";
        }


        

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dgvEmployees.Rows[index];
            lblIdValue.Text = selectedRow.Cells[0].Value.ToString();
            txtEmpName.Text = selectedRow.Cells[1].Value.ToString();
            txtEmpPosition.Text = selectedRow.Cells[2].Value.ToString();
            txtEmpPass.Text = selectedRow.Cells[3].Value.ToString();
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

        private void btnClearBoxs_Click(object sender, EventArgs e)
        {
            clearSelections();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("No Change", title);

            return false;
        }

    }


    }
/*
                OleDbConnection connect = new OleDbConnection();
                connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";   //relational path to sourse
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                command.CommandText = "INSERT INTO employee (Full_Name,position,password,access_level) VALUES (' " + txtEmpName.Text + " ',' " + txtEmpPosition.Text + " ',' " + txtEmpPass.Text + " ' , ' " + accessLevelSelected + " ')";
                command.ExecuteNonQuery();*/

/*OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;");
con.Open();
OleDbCommand com = new OleDbCommand();
com.Connection = con;
com.CommandType = CommandType.Text;
com.CommandText = "INSERT INTO employee (Full_Name,position,password,access_level) VALUES (' " + txtEmpName.Text + " ',' " + txtEmpPosition.Text + " ',' " + txtEmpPass.Text + " ' , ' " + accessLevelSelected + " ')";

com.ExecuteNonQuery();
MessageBox.Show("Saved");
con.Close();
*/
/*
                OleDbConnection connect = new OleDbConnection();
                connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";   //relational path to sourse
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                command.CommandText = "INSERT INTO employee (Full_Name) VALUES (' " + txtEmpName.Text + " ')";
                //"INSERT INTO employee(Full_Name, position, password, access_level) VALUES (, ' " + txtEmpPosition.Text + " ', ' " + txtEmpPass.Text + " ',' " + txtEmpName.Text + " ')";
                command.ExecuteNonQuery();*/
