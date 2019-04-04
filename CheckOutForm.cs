﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
	public partial class CheckOutForm : Form
	{
		private Timer tm;
		string printout = "";
		string textout = "";

		string custID = "";
		string custName = "";
		string custEmail = "";

		public CheckOutForm(string ID, string[,] cart, string[] totals)
		{
			InitializeComponent();

			emailLabel.Visible = false;
			printLabel.Visible = false;

			custID = ID;

			if (custID == null){
				custName = "Guest";
			}
			else
			{
				getDBInfo();
			}

			loadInfo(cart, totals);

            this.WindowState = FormWindowState.Maximized;
		}

		private void CheckOutForm_Load(object sender, EventArgs e) //Closes form after 30 seconds
		{
			tm = new Timer();
			tm.Interval = 30 * 1000; // 30 seconds
			tm.Tick += new EventHandler(tm_Tick);
			tm.Start();
		}

		private void tm_Tick(object sender, EventArgs e)
		{
			tm.Stop();
			this.Close();
		}

		private void getDBInfo()
		{
			string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
			string sqlstr = "SELECT * FROM customers WHERE id = @id";

			DataSet ds = new DataSet();

			using (OleDbConnection connection = new OleDbConnection(connectionStr))
			{
				OleDbDataAdapter adapter = new OleDbDataAdapter();

				OleDbCommand selectCMD = new OleDbCommand(sqlstr, connection);
				adapter.SelectCommand = selectCMD;

				// Add parameters and set values.  
				selectCMD.Parameters.Add(
				  "@id", OleDbType.VarChar, 40).Value = custID;

				adapter.Fill(ds);

				custName = ds.Tables[0].Rows[0][1].ToString();
				custEmail = ds.Tables[0].Rows[0][2].ToString();
			}

		}

		private void loadInfo(string[,] cart, string[] totals)
		{
			string today = DateTime.Now.ToString("M/d/yyyy hh:mm:ss");
			//nameLabel.Text = username;
			//timeLabel.Text = today.ToString();
			string barcode = "";
			string quantity = "";
			

			string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";

			textout += today;

			printout += "eyePOS Test Kiosk\n";
			printout += "Customer: " + custName + "\n";
			printout += "Date: " + today + "\n\n";

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

				//Add print out e.g
				// x3 Candy Bar (102130) @ $2.00 - 0.25 = $6.00



				printout += "x" + cart[j , 0]; //qty
				printout += " " + cart[j , 2]; //itemname
				printout += " (" + cart[j , 1]; //upc
				printout += ") @ " + cart[j , 3]; //price
				//printout += " - " + cart[j, 5]; //discount
				printout += " = " + cart[j, 4] + "\n\n"; //Total price

				//textout += ":" + cart[j, 1] + "-"+ cart[j, 0] + "-" + cart[j, 3] + "|";
			
			}

			textout += Environment.NewLine;

			//storeSale(textout);

			printout += "--------------------------------------------------\n\n";
			printout += "Subtotal: " + totals[0] + "\n";
			printout += "Taxes: " + totals[1] + "\n";
			printout += "Total: " + totals[2] + "\n\n";


			printout += "Thank you for shopping with us!";

			recieptTextBox.Text = printout;
		}

		private void storeSale(string text) //Output entry to text
		{
			try
			{
				if (custID != null)
				{
					string fileName = @"userHistory\\" + custID;

					// Check if file already exists. If yes, delete it.     
					if (File.Exists(fileName))
					{
						using (StreamWriter sw = File.AppendText(fileName))
						{
							File.AppendText(textout);
						}
					}
					else
					{
						using (StreamWriter sw = File.CreateText(fileName))
						{
							sw.WriteLine(textout);
						}
					}
				}
				
			}
			catch {} //throw out error 
				
		}

		private void printButton_Click(object sender, EventArgs e)
		{
			try
			{
				printDocument1.Print();

			}
			catch
			{
				printLabel.Visible = true;
			}
		}

		private void emailButton_Click(object sender, EventArgs e)
		{
			const string storeemail = "store@email.com"; //Store's email
			const string fromPassword = "fromPassword"; //Store password
			const string subject = "Your purchase receipt!";
			string body = recieptTextBox.Text;


			try
			{
				if (custID != null)
				{
					MailAddress fromAddress = new MailAddress(storeemail, "eyePOS Terminal");
					MailAddress toAddress = new MailAddress(custEmail, custName);

					SmtpClient smtp = new SmtpClient
					{
						Host = "smtp.live.com", //May change
						Port = 587,
						EnableSsl = true,
						DeliveryMethod = SmtpDeliveryMethod.Network,
						UseDefaultCredentials = false,
						Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
					};
					using (MailMessage message = new MailMessage(fromAddress, toAddress)
					{
						Subject = subject,
						Body = body
					})
					{
						smtp.Send(message);
					}

				}
				else
				{
					emailLabel.Text = "Guests cannot send email!";
					emailLabel.Visible = true;
				}
			}
			catch
			{
				emailLabel.Text = "Error sending email!";
				emailLabel.Visible = true;
			}
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
