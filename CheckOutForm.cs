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
	public partial class CheckOutForm : Form
	{
		private Timer tm;
		string printout = "";
		string textout = "";

		public CheckOutForm(string username, string[,] cart, string[] totals)
		{
			InitializeComponent();
			loadInfo(username, cart, totals);
            this.WindowState = FormWindowState.Maximized;
		}

		private void CheckOutForm_Load(object sender, EventArgs e)
		{
			tm = new Timer();
			tm.Interval = 60 * 1000; // 10 seconds
			tm.Tick += new EventHandler(tm_Tick);
			tm.Start();
		}

		private void tm_Tick(object sender, EventArgs e)
		{
			tm.Stop(); // so that we only fire the timer message once
			this.Close();
		}

		private void loadInfo(string username, string[,] cart, string[] totals)
		{
			DateTime today = DateTime.Today;
			//nameLabel.Text = username;
			//timeLabel.Text = today.ToString();
			string barcode = "";
			string quantity = "";

			string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";


			printout += "eyePOS Test Kiosk\n";
			printout += "Customer: " + username + "\n";
			printout += "Date: " + today.ToString() + "\n\n";

			printout += "--------------------------------------------------\n\n";

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
				printout += " (" + cart[j , 1]; //upc
				printout += ") @ " + cart[j , 3]; //price
				//printout += " - " + cart[j, 5]; //discount
				printout += " = " + cart[j, 4] + "\n\n"; //Total price

				textout += Environment.NewLine + cart[j, 0] + "-"+ cart[j, 1] + "-" + "-" + cart[j, 1]; 
			}

			textout += "|";

			printout += "--------------------------------------------------\n\n";
			printout += "Subtotal: " + totals[0] + "\n";
			printout += "Taxes: " + totals[1] + "\n";
			printout += "Total: " + totals[2] + "\n\n";


			printout += "Thank you for shopping with us!";

			recieptTextBox.Text = printout;
		}

		private void printButton_Click(object sender, EventArgs e)
		{
			printDocument1.Print();
		}

		private void emailButton_Click(object sender, EventArgs e)
		{

		}

		private void quitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString(recieptTextBox.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, 20, 20);
		}
	}
}
