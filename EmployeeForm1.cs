using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//This the main form for both Admin and regular employees where they can review inventory and stock
//update info regarding the items
//When the user is an Admin he/she will see the employee settings button that enables them to view/add/edit/delete employees accounts

namespace MultiFaceRec
{
	public partial class EmployeeForm1 : Form
    {
        //DB parameters
        string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        DataTable vt = new DataTable();

        //constructor
        public EmployeeForm1(string accessLevel)
        {
            InitializeComponent();
            lblPrdID.Text = "";
            displayDataGridView();
            //if the user logged in is an admin enable employee setings feature otherwise disable it
            if (accessLevel == "admin")
            {
                btnEmployeeSettings.Visible = true;
            }
            else
            {
                btnEmployeeSettings.Visible = false;
            }
            this.WindowState = FormWindowState.Maximized;
        }

        //Data grid view of the inventory click on any cell event handller
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //local variables
            string photoPath = "n/a";
            int index = e.RowIndex;// get the Row Index

            //if there is index
            //set all the info to the textboxes 
            if (index > 0)
            {
                DataGridViewRow selectedRow = dgvInventory.Rows[index];
                lblPrdID.Text = selectedRow.Cells[0].Value.ToString();
                txtBarCode.Text = selectedRow.Cells[1].Value.ToString();
                txtprdName.Text = selectedRow.Cells[2].Value.ToString();
                txtPrdDescrp.Text = selectedRow.Cells[3].Value.ToString();
                photoPath = selectedRow.Cells[4].Value.ToString();
                txtphotoPath.Text = photoPath;
                txtPrice.Text = selectedRow.Cells[5].Value.ToString();
                txtTaxRate.Text = selectedRow.Cells[6].Value.ToString();
                txtQty.Text = selectedRow.Cells[7].Value.ToString();
                txtDiscount.Text = selectedRow.Cells[8].Value.ToString();
            }
            try
            {
                //if there is no photo provided, known from table. Display the noPhoto default photo
                if (photoPath != "n/a")
                {
                    picBoxProduct.Image = Image.FromFile(photoPath);
                }
                else
                    picBoxProduct.Image = Image.FromFile("productsPhotos\\noPhoto.png");

            }
            catch
            {
                MessageBox.Show("Please reset path from product edit.", "Error Loading product photo. ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void btnSetProPhoto_Click(object sender, EventArgs e)
        {
            //This button is used to browse the PC to set pictures to the sellected product
            //open the file explorer in a dialog
            //user can only select one of these formats BMP, GIF, JPEG, EXIF, PNG
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;      //path to the photo
                sFileName = sFileName.Replace(@"\", @"\\"); //double backslash(s) found to meet the C# notation
                txtphotoPath.Text = sFileName;              
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true  
            }
        }
        
        //Event Handller to add product to the inventory system
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //validate input and ask user
            if (checkTextBoxes() && dialogBox("Are you sure that you want to Add item " + lblPrdID.Text, "Add Item"))
            {
                    //Connect to DB
                    try
                    {
                        using (var con = new OleDbConnection())
                        {
                            con.ConnectionString = connectionStr;
                            con.Open();

                            using (var com = new OleDbCommand())
                            {
                                com.Connection = con;
                                com.CommandText = "INSERT INTO items ([barcode],[prod_name],[prod_desc],[picture],[price],[tax_rate],[qty],[discount]) " +
                                "VALUES (@barcode,@prod_name,@prod_desc,@picture,@price,@tax_rate,@qty,@discount)";
                                //set values of the insert
                                com.Parameters.AddWithValue("@barcode", txtBarCode.Text);
                                com.Parameters.AddWithValue("@prod_name", txtprdName.Text);
                                com.Parameters.AddWithValue("@prod_desc", txtPrdDescrp.Text);
                                com.Parameters.AddWithValue("@picture", txtphotoPath.Text);
                                com.Parameters.AddWithValue("@price", txtPrice.Text);
                                com.Parameters.AddWithValue("@tax_rate", txtTaxRate.Text);
                                com.Parameters.AddWithValue("@qty", txtQty.Text);
                                com.Parameters.AddWithValue("@discount", txtDiscount.Text);
                                com.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Added, New Item", "Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        displayDataGridView();
                        ClearTextBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not saved: " + ex.Message, "Someting Went wrong...", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
            }
        }

        //Event Handller to edit product from the inventory system
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            //validate input and ask user
            if (checkTextBoxes() && dialogBox("Are you sure that you want to edit item " + lblPrdID.Text + "?", "Edit Item"))
            {
                //Connect to DB
                try
                {
                    using (var con = new OleDbConnection())
                    {
                        con.ConnectionString = connectionStr;
                        con.Open();
                        using (var com = new OleDbCommand())
                        {
                            com.Connection = con;
                            com.CommandText = "UPDATE items SET [barcode] = @barcode, [prod_name] = @prod_name ," +
                                " [prod_desc] = @prod_desc, [picture] = @picture, [price] = @price, [tax_rate] = @tax_rate," +
                                " [qty] = @qty, [discount] = @discount WHERE [ID] = @ID;";
                            //set values to update
                            com.Parameters.AddWithValue("@barcode", txtBarCode.Text);
                            com.Parameters.AddWithValue("@prod_name", txtprdName.Text);
                            com.Parameters.AddWithValue("@prod_desc", txtPrdDescrp.Text);
                            com.Parameters.AddWithValue("@picture", txtphotoPath.Text);
                            com.Parameters.AddWithValue("@price", txtPrice.Text);
                            com.Parameters.AddWithValue("@tax_rate", txtTaxRate.Text);
                            com.Parameters.AddWithValue("@qty", txtQty.Text);
                            com.Parameters.AddWithValue("@discount", txtDiscount.Text);
                            com.Parameters.AddWithValue("@ID", lblPrdID.Text);
                            com.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Edited, Item " + lblPrdID.Text);
                    displayDataGridView();
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not saved: " + ex.Message);
                }
            }
            else if (lblPrdID.Text == "")
                MessageBox.Show("No selection, Select an item to edit");
        }

        //Delete the selected product from to the inventory system
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            //validate input and ask user
            if (lblPrdID.Text != "" && dialogBox("Are you sure that you want to delete item " + lblPrdID.Text, "Delete Item"))
            {
                //Connect to DB
                try
                {
                    using (var con = new OleDbConnection())
                    {
                        con.ConnectionString = connectionStr;
                        con.Open();
                        using (var com = new OleDbCommand())
                        {
                            //delete the sellected ID record
                            com.Connection = con;
                            com.CommandText = "DELETE FROM items WHERE [ID] = @ID;";
                            com.Parameters.AddWithValue("@ID", lblPrdID.Text);
                            com.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Deleted successfully, item " + lblPrdID.Text);
                    displayDataGridView();
                    ClearTextBoxes();
                    picBoxProduct.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not saved: " + ex.Message);
                }
            }
            else if (lblPrdID.Text == "")
                MessageBox.Show("No selection, Select an item to delete");
        }

        //Admins can use this button to go to Employee settings form
        private void btnEmployeeSettings_Click(object sender, EventArgs e)
        {
            employee_settings_Form employee_Settings_Form = new employee_settings_Form();
			this.Hide();
			employee_Settings_Form.ShowDialog();
			this.Show();
        }

        //Go back to home page
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
        }

        //clear item info textboxes
        private void btnClearBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            picBoxProduct.Image = null;
        }

        //go to employee settings form
        private void button2_Click(object sender, EventArgs e)
		{
            employee_settings_Form settings_Form = new employee_settings_Form();
			this.Hide();
			settings_Form.ShowDialog();
			this.Show();
		}

        //search by upc
        private void upcSearchButton_Click(object sender, EventArgs e)
		{
            //SQL parameters
			string sqlstr = "SELECT * FROM items WHERE barcode LIKE @barcode";
			string value = searchTextBox.Text;

			DataTable dt = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionStr))
			{
				OleDbDataAdapter adapter = new OleDbDataAdapter();

				OleDbCommand selectCMD = new OleDbCommand(sqlstr, connection);
				adapter.SelectCommand = selectCMD;

				// Add parameters and set values.  
				selectCMD.Parameters.AddWithValue("@barcode", "%"+value+"%");

				//selectCMD.Parameters.Add( "@BarCode", OleDbType.VarChar, 25).Value = "%"+ value+ "%";

				adapter.Fill(dt);
				dgvInventory.DataSource = dt;
			}
		}

        //clear search critiria
		private void clearButton_Click(object sender, EventArgs e)
		{
			searchTextBox.Text = "";
			displayDataGridView();
		}

        //search by name of the item
		private void nameSearchButton_Click(object sender, EventArgs e)
		{
            //select everything similar to the entered string
			string sqlstr = "SELECT * FROM items WHERE prod_name LIKE @name";
			string value = searchTextBox.Text;

			DataTable dt = new DataTable();
            
			using (OleDbConnection connection = new OleDbConnection(connectionStr))
			{
				OleDbDataAdapter adapter = new OleDbDataAdapter();

				OleDbCommand selectCMD = new OleDbCommand(sqlstr, connection);
				adapter.SelectCommand = selectCMD;

				// Add parameters and set values.  

				selectCMD.Parameters.AddWithValue("@name", "%" + value + "%");

				//selectCMD.Parameters.Add("@name", OleDbType.VarChar, 50).Value = "%" + value + "%";
				adapter.Fill(dt);
				dgvInventory.DataSource = dt;
			}
		}

        // A method to sellect everything from the table to the DGV
        public void displayDataGridView()
        {
            string sqlstr = "SELECT * FROM items";
            DataTable vt = new DataTable();

            try
            {
                OleDbDataAdapter dad = new OleDbDataAdapter(sqlstr, connectionStr);
                dad.Fill(vt);
                dad.Dispose();
                dad = null;
                dgvInventory.DataSource = vt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // A method for custom message boxes
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

        //clear every box on the form
        public void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
            lblPrdID.Text = "";
        }

        //Check if the entered value is only numbers
        public bool check_numeric(string text)
        {
            bool valid = true;
            foreach (char c in text)
            {
                if (c < '0' || c > '9')
                    valid = false;
                if (c == '.')
                    valid = true;
            }
            return valid;
        }

        //A method to check the inputs
        public bool checkTextBoxes()
        {
            //no name
            if (txtprdName.Text == "")
            {
                MessageBox.Show("Enter Product Name.");
                return false;
            }

            //non numeric values
            else if (!check_numeric(txtDiscount.Text) || !check_numeric(txtPrice.Text) || !check_numeric(txtQty.Text) || !check_numeric(txtTaxRate.Text))
            {
                MessageBox.Show("Discount Value, Price, Quantity, and Tax Rate must be numeric values.");
                return false;
            }

            //not complete info entered
            else if (txtBarCode.Text == "" || txtDiscount.Text == "" || txtphotoPath.Text == "" || txtPrdDescrp.Text == "" || txtPrice.Text == "" || txtQty.Text == "" || txtTaxRate.Text == "")
            {
                DialogResult res = MessageBox.Show("Some information is missing, would you like to complete it? " + Environment.NewLine +
                "If NO, the item will be saved with currently entered information.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    return false;
                }
                //set default values
                if (res == DialogResult.No)
                {
                    if (txtBarCode.Text == "")
                        txtBarCode.Text = "000000";
                    if (txtDiscount.Text == "")
                        txtDiscount.Text = "00.00";
                    if (txtphotoPath.Text == "")
                        txtphotoPath.Text = "n/a";
                    if (txtPrdDescrp.Text == "")
                        txtPrdDescrp.Text = "n/a";
                    if (txtPrice.Text == "")
                        txtPrice.Text = "00.00";
                    if (txtQty.Text == "")
                        txtQty.Text = "0";
                    if (txtTaxRate.Text == "")
                        txtTaxRate.Text = "0";
                    return true;
                }
            }
            return true;
        }

        private void btnCustomerSettings_Click(object sender, EventArgs e)
        {
            Customers_SettingsForm customers_SettingsForm = new Customers_SettingsForm();
            this.Hide();
            customers_SettingsForm.ShowDialog();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
