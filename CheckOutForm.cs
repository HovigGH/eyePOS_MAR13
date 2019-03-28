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
	public partial class CheckOutForm : Form
	{
		public CheckOutForm(string username, string[,] cart, string[] totals)
		{
			InitializeComponent();
			loadInfo(username, cart, totals);
		}

		private void CheckOutForm_Load(object sender, EventArgs e)
		{

		}
		private void loadInfo(string username, string[,] cart, string[] totals)
		{
			DateTime today = DateTime.Today;
			//nameLabel.Text = username;
			//timeLabel.Text = today.ToString();
			string printout = "";
			string txtout = "";
			string barcode = "";
			string quantity = "";

			string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";



			printout += "eyePOS Test Kiosk\n";
			printout += "Customer: " + username + "\n";
			printout += "Date: " + today.ToString() + "\n\n";

			printout += "--------------------------------\n\n";

			for (int j = 0; j < cart.GetLength(0); j++)
			{
				barcode = cart[j, 1];
				quantity = cart[j, 0];

				using (var con = new OleDbConnection()) //this subtracts from the inventory
				{
					con.ConnectionString = connectionStr;
					con.Open();
					using (var com = new OleDbCommand())
					{
						com.Connection = con;
						com.CommandText = "UPDATE items SET qty = qty - (1*@quantity) WHERE barcode = @barcode;";
						com.Parameters.AddWithValue("@quantity", quantity);
						com.Parameters.AddWithValue("@barcode", barcode);

						com.ExecuteNonQuery();
					}
				}

				//Add print out eg
				// x3 Candy Bar (102130) @ $2.00 - 0.25 = $6.00



				printout += "x" + cart[j , 0]; //qty
				printout += " " + cart[j , 2]; //itemname
				printout += "(" + cart[j , 1] + ")"; //upc
				printout += " @ " + cart[j , 3]; //price
				//printout += " - " + cart[j, 5]; //discount
				printout += " = " + cart[j, 4] + "\n\n"; //Total price

				txtout = cart[j, 0] + cart[j, 1] ; 
			}

			printout += "--------------------------------\n\n";
			printout += "Subtotal: " + totals[0] + "\n";
			printout += "Taxes: " + totals[1] + "\n";
			printout += "Total: " + totals[2] + "\n\n";


			printout += "Thank you for shopping with us!";

			richTextBox1.Text = printout;
		}
	}
}
