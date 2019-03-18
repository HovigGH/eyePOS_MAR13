namespace MultiFaceRec{
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
            this.callhelpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.payGB = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.payGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // callhelpButton
            // 
            this.callhelpButton.Location = new System.Drawing.Point(12, 567);
            this.callhelpButton.Name = "callhelpButton";
            this.callhelpButton.Size = new System.Drawing.Size(121, 72);
            this.callhelpButton.TabIndex = 3;
            this.callhelpButton.Text = "Call for Assistance";
            this.callhelpButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please Scan Your Item Now";
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
            this.cartGrid.Location = new System.Drawing.Point(403, 12);
            this.cartGrid.Name = "cartGrid";
            this.cartGrid.RowHeadersVisible = false;
            this.cartGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cartGrid.Size = new System.Drawing.Size(653, 549);
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
            this.barcodeInputTextbox.Location = new System.Drawing.Point(80, 316);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "(or enter a UPC)";
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(262, 567);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(121, 72);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.subLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.taxLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(403, 567);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 72);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total:";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Location = new System.Drawing.Point(4, 21);
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
            this.label11.Location = new System.Drawing.Point(221, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Taxes (15%):";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(438, 21);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(53, 13);
            this.totalLabel.TabIndex = 22;
            this.totalLabel.Text = "totalLabel";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(221, 21);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(47, 13);
            this.taxLabel.TabIndex = 23;
            this.taxLabel.Text = "taxLabel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Credit Card";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Debit Card";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(87, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Gift Card";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // payGB
            // 
            this.payGB.Controls.Add(this.button1);
            this.payGB.Controls.Add(this.button4);
            this.payGB.Controls.Add(this.button2);
            this.payGB.Controls.Add(this.button3);
            this.payGB.Location = new System.Drawing.Point(12, 12);
            this.payGB.Name = "payGB";
            this.payGB.Size = new System.Drawing.Size(385, 60);
            this.payGB.TabIndex = 28;
            this.payGB.TabStop = false;
            this.payGB.Text = "Payment";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(139, 567);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(121, 72);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // CustScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 651);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.payGB);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcodeInputTextbox);
            this.Controls.Add(this.cartGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.callhelpButton);
            this.Name = "CustScanForm";
            this.Text = "CustForm1";
            this.Load += new System.EventHandler(this.CustForm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustForm1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.payGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button callhelpButton;
		private System.Windows.Forms.Label label1;
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button checkOutButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label subLabel;
		private System.Windows.Forms.Label taxLabel;
		private System.Windows.Forms.Label totalLabel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox payGB;
        private System.Windows.Forms.Button btnHome;
    }
}