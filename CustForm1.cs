using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace MultiFaceRec
{
	public partial class CustForm1 : Form
	{
		

		public CustForm1()
		{
			InitializeComponent();

			this.KeyPreview = true; //Needed to enable Keypress function

		}

		private void CustForm1_Load(object sender, EventArgs e)
		{
			cartGrid.Columns["deleteCol"].DefaultCellStyle.NullValue = "🗑️"; //Set up the grid
																			  //Format: Null, int qty, string UPC, string item name, $price
			barcodeInputTextbox.Select();

			cartGrid.Rows.Add(null, 1, "01052843", "Chocolate Bar", "$2.00"); //RM testing only
			updateTotals();
			payGB.Visible = false;
		}


		private void addToCart(string barcode) //TODO: add DB connection to items
		{
			bool createNew = true; //To see if a new entry is needed

			foreach (DataGridViewRow r in cartGrid.Rows) //If a duplicate item is scanned it increases the amount of items
			{
				if (r.Cells[2].Value.ToString() == barcode)
				{
					r.Cells[1].Value = Convert.ToInt32(r.Cells[1].Value) + 1;

					createNew = false; //Don't create new entry
				}
			}

			if (createNew == true)//DB connection CHANGE VALUES PLS 
			{
				string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
				string sqlstr = "SELECT upc_code, item_name, item_price FROM items";
				DataTable vt = new DataTable();

				try
				{
					OleDbDataAdapter dad = new OleDbDataAdapter(sqlstr, constr);
					dad.Fill(vt);
					dad.Dispose();
					dad = null;
					//cartGrid.DataSource = vt;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error " + ex);
				}



				//cartGrid.Rows.Add(null, 1, barcode, "ItemName", "$1.11");
			}
		}

		private void cartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((e.ColumnIndex == cartGrid.Columns["deleteCol"].Index) && !(e.RowIndex < 0 || e.RowIndex == this.cartGrid.NewRowIndex)) //Ensures value isnt header or new row.
			{

				string message = "Are you sure you want to remove this item from the cart?";
				string caption = "Remove Item";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;

				var result = MessageBox.Show(message, caption, buttons);

				if (result == System.Windows.Forms.DialogResult.Yes)
				{
					cartGrid.Rows.RemoveAt(e.RowIndex);
				}


			}
		}

		private void updateTotals()
		{
			decimal sum = 0m;
			decimal tax = 0m;
			decimal total = 0m;

			string temp;

			foreach (DataGridViewRow r in cartGrid.Rows)
			{
				temp = (r.Cells[4].Value).ToString().Replace("$", String.Empty);
				sum += decimal.Round(Convert.ToDecimal(temp) * Convert.ToInt32(r.Cells[1].Value), 2, MidpointRounding.AwayFromZero);
			}

			tax = decimal.Round((sum * (decimal)0.15), 2, MidpointRounding.AwayFromZero);
			total = decimal.Round((sum + tax), 2, MidpointRounding.AwayFromZero);

			subLabel.Text = "$" + sum.ToString();
			taxLabel.Text = "$" + tax.ToString();
			totalLabel.Text = "$" + total.ToString();

		}

		private void barcodeInputTextbox_KeyDown(object sender, KeyEventArgs e) //gets barcode entries
		{
			if (e.KeyCode == Keys.Enter) //Reads for specific button to send to cart, i.e tab, enter
			{
				addToCart(barcodeInputTextbox.Text);
				barcodeInputTextbox.Clear();
			}
		}

		private void CustForm1_KeyDown_1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
			{
				barcodeInputTextbox.Select();
			}
		}

		private void cartGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			updateTotals();

		}

		private void checkOutButton_Click(object sender, EventArgs e)
		{
			updateTotals();
			payGB.Visible = true;

		}
	}
}