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
        string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
        DataTable vt = new DataTable();

        public EmployeeForm1(string accessLevel)
        {
            InitializeComponent();
            lblPrdID.Text = "";
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
        private void btnSetProPhoto_Click(object sender, EventArgs e)
        {
            //get the photo
            OpenFileDialog choofdlog = new OpenFileDialog();
            //BMP, GIF, JPEG, EXIF, PNG
            choofdlog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                sFileName = sFileName.Replace(@"\", @"\\");
                txtphotoPath.Text = sFileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true  
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes() && dialogBox("Are you sure that you want to Add item " + lblPrdID.Text, "Add Item"))
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
                                com.CommandText = "INSERT INTO items ([barcode],[prod_name],[prod_desc],[picture],[price],[tax_rate],[qty],[discount]) " +
                                "VALUES (@barcode,@prod_name,@prod_desc,@picture,@price,@tax_rate,@qty,@discount)";
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
                        MessageBox.Show("Added, New Item");
                        displayDataGridView();
                        ClearTextBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not saved: " + ex.Message);
                    }
            }

        }
 
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			string photoPath = "n/a";

			int index = e.RowIndex;// get the Row Index

			if (index > 0 )
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
                if(photoPath != "n/a")
                {
                    picBoxProduct.Image = Image.FromFile(photoPath);
                }
                else
                    picBoxProduct.Image = Image.FromFile("productsPhotos\\noPhoto.png");

            }
            catch
            {
                MessageBox.Show("Error Loading product photo. Please reset path from product edit.");
            }
                
        }

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


        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes() && dialogBox("Are you sure that you want to edit item " + lblPrdID.Text + "?", "Edit Item"))
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
                            com.CommandText = "UPDATE items SET [barcode] = @barcode, [prod_name] = @prod_name ," +
                                " [prod_desc] = @prod_desc, [picture] = @picture, [price] = @price, [tax_rate] = @tax_rate," +
                                " [qty] = @qty, [discount] = @discount WHERE [ID] = @ID;";
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

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (lblPrdID.Text != "" && dialogBox("Are you sure that you want to delete item " + lblPrdID.Text, "Delete Item"))
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

        public bool checkTextBoxes()
        {
            if (txtprdName.Text == "")
            {
                MessageBox.Show("Enter Product Name.");
                return false;
            }
            else if (!check_numeric(txtDiscount.Text) || !check_numeric(txtPrice.Text) ||!check_numeric(txtQty.Text) || !check_numeric(txtTaxRate.Text))
            {
                MessageBox.Show("Discount Value, Price, Quantity, and Tax Rate must be numeric values.");
                return false;
            }
            else if (txtBarCode.Text == "" || txtDiscount.Text == "" || txtphotoPath.Text == "" || txtPrdDescrp.Text == ""|| txtPrice.Text == "" || txtQty.Text == "" || txtTaxRate.Text == "")
            {
                DialogResult res = MessageBox.Show("Some information is missing, would you like to complete it? " + Environment.NewLine +
                "If NO, the item will be saved with currently entered information.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                 if (res == DialogResult.Yes)
                 {
                    return false;
                 }
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

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            picBoxProduct.Image = null;
        }

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void upcSearchButton_Click(object sender, EventArgs e)
		{
			string sqlstr = "SELECT * FROM items WHERE barcode LIKE @barcode";

			string value = searchTextBox.Text;

			DataTable dt = new DataTable();


			using (OleDbConnection connection = new OleDbConnection(connectionStr))
			{
				OleDbDataAdapter adapter = new OleDbDataAdapter();

				OleDbCommand selectCMD = new OleDbCommand(sqlstr, connection);
				adapter.SelectCommand = selectCMD;

				// Add parameters and set values.  
				selectCMD.Parameters.Add(
				  "@BarCode", OleDbType.VarChar, 25).Value = "%"+ value+ "%";

				adapter.Fill(dt);
				dgvInventory.DataSource = dt;
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			searchTextBox.Text = "";
			displayDataGridView();
		}

		private void nameSearchButton_Click(object sender, EventArgs e)
		{
			string sqlstr = "SELECT * FROM items WHERE name LIKE @name";

			string value = searchTextBox.Text;

			DataTable dt = new DataTable();


			using (OleDbConnection connection = new OleDbConnection(connectionStr))
			{
				OleDbDataAdapter adapter = new OleDbDataAdapter();

				OleDbCommand selectCMD = new OleDbCommand(sqlstr, connection);
				adapter.SelectCommand = selectCMD;

				// Add parameters and set values.  
				selectCMD.Parameters.Add("@name", OleDbType.VarChar, 25).Value = "%" + value + "%";

				adapter.Fill(dt);
				dgvInventory.DataSource = dt;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
