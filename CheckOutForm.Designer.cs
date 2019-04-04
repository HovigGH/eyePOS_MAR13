﻿namespace MultiFaceRec
{
	partial class CheckOutForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.recieptTextBox = new System.Windows.Forms.RichTextBox();
			this.printButton = new System.Windows.Forms.Button();
			this.emailButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.printLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.quitButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// recieptTextBox
			// 
			this.recieptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.recieptTextBox.Location = new System.Drawing.Point(12, 35);
			this.recieptTextBox.Name = "recieptTextBox";
			this.recieptTextBox.Size = new System.Drawing.Size(569, 702);
			this.recieptTextBox.TabIndex = 0;
			this.recieptTextBox.Text = "";
			// 
			// printButton
			// 
			this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printButton.Location = new System.Drawing.Point(290, 25);
			this.printButton.Name = "printButton";
			this.printButton.Size = new System.Drawing.Size(130, 79);
			this.printButton.TabIndex = 2;
			this.printButton.Text = "Print Receipt";
			this.printButton.UseVisualStyleBackColor = true;
			this.printButton.Click += new System.EventHandler(this.printButton_Click);
			// 
			// emailButton
			// 
			this.emailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailButton.Location = new System.Drawing.Point(6, 25);
			this.emailButton.Name = "emailButton";
			this.emailButton.Size = new System.Drawing.Size(130, 79);
			this.emailButton.TabIndex = 3;
			this.emailButton.Text = "Email Receipt";
			this.emailButton.UseVisualStyleBackColor = true;
			this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.printLabel);
			this.groupBox1.Controls.Add(this.emailLabel);
			this.groupBox1.Controls.Add(this.emailButton);
			this.groupBox1.Controls.Add(this.printButton);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(593, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(426, 139);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// printLabel
			// 
			this.printLabel.AutoSize = true;
			this.printLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printLabel.ForeColor = System.Drawing.Color.Red;
			this.printLabel.Location = new System.Drawing.Point(310, 107);
			this.printLabel.Name = "printLabel";
			this.printLabel.Size = new System.Drawing.Size(88, 20);
			this.printLabel.TabIndex = 34;
			this.printLabel.Text = "Error printing!";
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLabel.ForeColor = System.Drawing.Color.Red;
			this.emailLabel.Location = new System.Drawing.Point(6, 107);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(129, 20);
			this.emailLabel.TabIndex = 33;
			this.emailLabel.Text = "Error sending email!";
			// 
			// quitButton
			// 
			this.quitButton.BackColor = System.Drawing.Color.PaleGreen;
			this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitButton.Location = new System.Drawing.Point(593, 613);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(765, 124);
			this.quitButton.TabIndex = 3;
			this.quitButton.Text = "Quit";
			this.quitButton.UseVisualStyleBackColor = false;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Your Reciept:";
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(858, 283);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 57);
			this.label2.TabIndex = 6;
			this.label2.Text = "Thank You";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(752, 329);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(430, 57);
			this.label3.TabIndex = 7;
			this.label3.Text = "For Shopping With Us!";
			// 
			// CheckOutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.quitButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.recieptTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CheckOutForm";
			this.Text = "Confirmation";
			this.Load += new System.EventHandler(this.CheckOutForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox recieptTextBox;
		private System.Windows.Forms.Button printButton;
		private System.Windows.Forms.Button emailButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button quitButton;
		private System.Windows.Forms.Label label1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Label printLabel;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}