﻿namespace MultiFaceRec{
	partial class CustScanForm
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
            this.components = new System.ComponentModel.Container();
            this.callhelpButton = new System.Windows.Forms.Button();
            this.lblPlsScan = new System.Windows.Forms.Label();
            this.cartGrid = new System.Windows.Forms.DataGridView();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.qtyCol = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.codeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeInputTextbox = new System.Windows.Forms.TextBox();
            this.dataGridViewNumericUpDownColumn1 = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrEnter = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnGift = new System.Windows.Forms.Button();
            this.payGB = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.payGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // callhelpButton
            // 
            this.callhelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callhelpButton.Location = new System.Drawing.Point(3, 133);
            this.callhelpButton.Name = "callhelpButton";
            this.callhelpButton.Size = new System.Drawing.Size(92, 72);
            this.callhelpButton.TabIndex = 3;
            this.callhelpButton.Text = "Call for Assistance";
            this.callhelpButton.UseVisualStyleBackColor = true;
            // 
            // lblPlsScan
            // 
            this.lblPlsScan.AutoSize = true;
            this.lblPlsScan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlsScan.Location = new System.Drawing.Point(33, 74);
            this.lblPlsScan.Name = "lblPlsScan";
            this.lblPlsScan.Size = new System.Drawing.Size(226, 18);
            this.lblPlsScan.TabIndex = 8;
            this.lblPlsScan.Text = "Please Scan Your Item Now";
            // 
            // cartGrid
            // 
            this.cartGrid.AllowUserToAddRows = false;
            this.cartGrid.AllowUserToDeleteRows = false;
            this.cartGrid.AllowUserToResizeColumns = false;
            this.cartGrid.AllowUserToResizeRows = false;
            this.cartGrid.BackgroundColor = System.Drawing.Color.White;
            this.cartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteCol,
            this.qtyCol,
            this.codeCol,
            this.itemCol,
            this.priceCol});
            this.cartGrid.Location = new System.Drawing.Point(421, 12);
            this.cartGrid.Name = "cartGrid";
            this.cartGrid.RowHeadersVisible = false;
            this.cartGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cartGrid.Size = new System.Drawing.Size(781, 686);
            this.cartGrid.TabIndex = 10;
            this.cartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartGrid_CellContentClick);
            this.cartGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartGrid_CellValueChanged);
            // 
            // deleteCol
            // 
            this.deleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteCol.HeaderText = "🗑️";
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteCol.Width = 30;
            // 
            // qtyCol
            // 
            this.qtyCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qtyCol.HeaderText = "Qty";
            this.qtyCol.Name = "qtyCol";
            this.qtyCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.qtyCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.qtyCol.Width = 48;
            // 
            // codeCol
            // 
            this.codeCol.HeaderText = "UPC";
            this.codeCol.Name = "codeCol";
            this.codeCol.ReadOnly = true;
            // 
            // itemCol
            // 
            this.itemCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemCol.HeaderText = "Item Name";
            this.itemCol.Name = "itemCol";
            this.itemCol.ReadOnly = true;
            this.itemCol.Width = 400;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            this.priceCol.Width = 200;
            // 
            // barcodeInputTextbox
            // 
            this.barcodeInputTextbox.Location = new System.Drawing.Point(84, 107);
            this.barcodeInputTextbox.Name = "barcodeInputTextbox";
            this.barcodeInputTextbox.Size = new System.Drawing.Size(223, 20);
            this.barcodeInputTextbox.TabIndex = 12;
            this.barcodeInputTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeInputTextbox_KeyDown);
            // 
            // dataGridViewNumericUpDownColumn1
            // 
            this.dataGridViewNumericUpDownColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewNumericUpDownColumn1.HeaderText = "Qty";
            this.dataGridViewNumericUpDownColumn1.Name = "dataGridViewNumericUpDownColumn1";
            this.dataGridViewNumericUpDownColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNumericUpDownColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "UPC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // lblOrEnter
            // 
            this.lblOrEnter.AutoSize = true;
            this.lblOrEnter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrEnter.Location = new System.Drawing.Point(265, 74);
            this.lblOrEnter.Name = "lblOrEnter";
            this.lblOrEnter.Size = new System.Drawing.Size(105, 20);
            this.lblOrEnter.TabIndex = 13;
            this.lblOrEnter.Text = "(or enter a UPC)";
            // 
            // checkOutButton
            // 
            this.checkOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutButton.Location = new System.Drawing.Point(207, 133);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(190, 72);
            this.checkOutButton.TabIndex = 14;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.04908F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.51534F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.subLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.taxLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 211);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.35211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.64789F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 72);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total:";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Location = new System.Drawing.Point(4, 19);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(50, 13);
            this.subLabel.TabIndex = 24;
            this.subLabel.Text = "subLabel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Subtotal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Taxes (15%):";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(264, 19);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(53, 13);
            this.totalLabel.TabIndex = 22;
            this.totalLabel.Text = "totalLabel";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(137, 19);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(47, 13);
            this.taxLabel.TabIndex = 23;
            this.taxLabel.Text = "taxLabel";
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(7, 13);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(75, 50);
            this.btnCash.TabIndex = 24;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            // 
            // btnCredit
            // 
            this.btnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.Location = new System.Drawing.Point(223, 13);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(75, 50);
            this.btnCredit.TabIndex = 25;
            this.btnCredit.Text = "Credit Card";
            this.btnCredit.UseVisualStyleBackColor = true;
            // 
            // btnDebit
            // 
            this.btnDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebit.Location = new System.Drawing.Point(304, 13);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(75, 50);
            this.btnDebit.TabIndex = 26;
            this.btnDebit.Text = "Debit Card";
            this.btnDebit.UseVisualStyleBackColor = true;
            // 
            // btnGift
            // 
            this.btnGift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGift.Location = new System.Drawing.Point(130, 13);
            this.btnGift.Name = "btnGift";
            this.btnGift.Size = new System.Drawing.Size(75, 50);
            this.btnGift.TabIndex = 27;
            this.btnGift.Text = "Gift Card";
            this.btnGift.UseVisualStyleBackColor = true;
            // 
            // payGB
            // 
            this.payGB.Controls.Add(this.btnCash);
            this.payGB.Controls.Add(this.btnGift);
            this.payGB.Controls.Add(this.btnCredit);
            this.payGB.Controls.Add(this.btnDebit);
            this.payGB.Location = new System.Drawing.Point(9, 2);
            this.payGB.Name = "payGB";
            this.payGB.Size = new System.Drawing.Size(385, 69);
            this.payGB.TabIndex = 28;
            this.payGB.TabStop = false;
            this.payGB.Text = "Payment";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(101, 133);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(77, 72);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Profiles captured";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nobody";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(187, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of faces detected: ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Detect and recognize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(207, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 170);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results: ";
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(11, 18);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(163, 134);
            this.imageBox1.TabIndex = 5;
            this.imageBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(9, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 188);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(156, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add face";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(20, 483);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(368, 215);
            this.imageBoxFrameGrabber.TabIndex = 18;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // CustScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.payGB);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.lblOrEnter);
            this.Controls.Add(this.barcodeInputTextbox);
            this.Controls.Add(this.cartGrid);
            this.Controls.Add(this.lblPlsScan);
            this.Controls.Add(this.callhelpButton);
            this.Name = "CustScanForm";
            this.Text = "CustForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustForm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustForm1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.payGB.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button callhelpButton;
		private System.Windows.Forms.Label lblPlsScan;
		private System.Windows.Forms.DataGridView cartGrid;
		private System.Windows.Forms.TextBox barcodeInputTextbox;
		private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn dataGridViewNumericUpDownColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewButtonColumn deleteCol;
		private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn qtyCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn codeCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
		private System.Windows.Forms.Label lblOrEnter;
		private System.Windows.Forms.Button checkOutButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label subLabel;
		private System.Windows.Forms.Label taxLabel;
		private System.Windows.Forms.Label totalLabel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnCash;
		private System.Windows.Forms.Button btnCredit;
		private System.Windows.Forms.Button btnDebit;
		private System.Windows.Forms.Button btnGift;
		private System.Windows.Forms.GroupBox payGB;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
    }
}