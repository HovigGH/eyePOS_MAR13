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

        private void lblEmpAdd_Click(object sender, EventArgs e)
        {
            if(checkIfFilled())
            {/*
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

                OleDbConnection connect = new OleDbConnection();
                connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";   //relational path to sourse
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                command.CommandText = "INSERT INTO employee (Full_Name,position) VALUES ('cc','caa' )";
                command.ExecuteNonQuery();
            }
            else
                MessageBox.Show("Fill all fields");

        }
        public bool checkIfFilled()
        {
            if (txtEmpName.Text == "" || txtEmpPass.Text == "" || txtEmpPosition.Text == "" || accessLevelSelected == "")
                return false;
            return true;
        }

        private void rdbtnRegEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRegEmp.Checked == true && rdbtnAdmin.Checked == false)
                accessLevelSelected = "regular";
            else if (rdbtnAdmin.Checked == true && rdbtnRegEmp.Checked == false)
                accessLevelSelected = "admin";
        }
    }


    }
