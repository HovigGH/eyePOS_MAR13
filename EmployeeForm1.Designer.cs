namespace MultiFaceRec
{
    partial class EmployeeForm1
    {/// <summary>
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
			this.dgvInventory = new System.Windows.Forms.DataGridView();
			this.btnEmployeeSettings = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.txtprdName = new System.Windows.Forms.TextBox();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.txtPrdDescrp = new System.Windows.Forms.TextBox();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.lblPrdName = new System.Windows.Forms.Label();
			this.lblBarcode = new System.Windows.Forms.Label();
			this.lblDescrp = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lbltaxRate = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.grpBxPrdInfo = new System.Windows.Forms.GroupBox();
			this.btnClearBoxes = new System.Windows.Forms.Button();
			this.lblIDtag = new System.Windows.Forms.Label();
			this.btnSetProPhoto = new System.Windows.Forms.Button();
			this.lblImgPath = new System.Windows.Forms.Label();
			this.txtphotoPath = new System.Windows.Forms.TextBox();
			this.lblPrdID = new System.Windows.Forms.Label();
			this.btnDeleteItem = new System.Windows.Forms.Button();
			this.txtTaxRate = new System.Windows.Forms.TextBox();
			this.btnEditItem = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.txtBarCode = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.picBoxProduct = new System.Windows.Forms.PictureBox();
			this.homeButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.searchGB = new System.Windows.Forms.GroupBox();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.nameSearchButton = new System.Windows.Forms.Button();
			this.clearSearchButton = new System.Windows.Forms.Button();
			this.upcSearchButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
			this.grpBxPrdInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).BeginInit();
			this.searchGB.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvInventory
			// 
			this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInventory.Location = new System.Drawing.Point(12, 96);
			this.dgvInventory.Name = "dgvInventory";
			this.dgvInventory.Size = new System.Drawing.Size(954, 571);
			this.dgvInventory.TabIndex = 0;
			this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
			// 
			// btnEmployeeSettings
			// 
			this.btnEmployeeSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmployeeSettings.Location = new System.Drawing.Point(1211, 430);
			this.btnEmployeeSettings.Name = "btnEmployeeSettings";
			this.btnEmployeeSettings.Size = new System.Drawing.Size(82, 64);
			this.btnEmployeeSettings.TabIndex = 12;
			this.btnEmployeeSettings.Text = "Employee settings";
			this.btnEmployeeSettings.UseVisualStyleBackColor = true;
			this.btnEmployeeSettings.Click += new System.EventHandler(this.btnEmployeeSettings_Click);
			// 
			// btnHome
			// 
			this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.Location = new System.Drawing.Point(1035, 430);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(82, 64);
			this.btnHome.TabIndex = 13;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// txtprdName
			// 
			this.txtprdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtprdName.Location = new System.Drawing.Point(12, 45);
			this.txtprdName.Name = "txtprdName";
			this.txtprdName.Size = new System.Drawing.Size(245, 21);
			this.txtprdName.TabIndex = 4;
			// 
			// txtQty
			// 
			this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(13, 131);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(244, 21);
			this.txtQty.TabIndex = 6;
			// 
			// txtPrdDescrp
			// 
			this.txtPrdDescrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrdDescrp.Location = new System.Drawing.Point(12, 88);
			this.txtPrdDescrp.Name = "txtPrdDescrp";
			this.txtPrdDescrp.Size = new System.Drawing.Size(245, 21);
			this.txtPrdDescrp.TabIndex = 5;
			// 
			// txtDiscount
			// 
			this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiscount.Location = new System.Drawing.Point(13, 309);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(244, 21);
			this.txtDiscount.TabIndex = 10;
			// 
			// lblPrdName
			// 
			this.lblPrdName.AutoSize = true;
			this.lblPrdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrdName.Location = new System.Drawing.Point(3, 20);
			this.lblPrdName.Name = "lblPrdName";
			this.lblPrdName.Size = new System.Drawing.Size(45, 17);
			this.lblPrdName.TabIndex = 22;
			this.lblPrdName.Text = "Name";
			// 
			// lblBarcode
			// 
			this.lblBarcode.AutoSize = true;
			this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBarcode.Location = new System.Drawing.Point(3, 154);
			this.lblBarcode.Name = "lblBarcode";
			this.lblBarcode.Size = new System.Drawing.Size(60, 17);
			this.lblBarcode.TabIndex = 23;
			this.lblBarcode.Text = "barcode";
			// 
			// lblDescrp
			// 
			this.lblDescrp.AutoSize = true;
			this.lblDescrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescrp.Location = new System.Drawing.Point(3, 68);
			this.lblDescrp.Name = "lblDescrp";
			this.lblDescrp.Size = new System.Drawing.Size(79, 17);
			this.lblDescrp.TabIndex = 24;
			this.lblDescrp.Text = "Description";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.Location = new System.Drawing.Point(3, 198);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(40, 17);
			this.lblPrice.TabIndex = 25;
			this.lblPrice.Text = "Price";
			// 
			// lbltaxRate
			// 
			this.lbltaxRate.AutoSize = true;
			this.lbltaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltaxRate.Location = new System.Drawing.Point(3, 241);
			this.lbltaxRate.Name = "lbltaxRate";
			this.lbltaxRate.Size = new System.Drawing.Size(76, 17);
			this.lbltaxRate.TabIndex = 26;
			this.lbltaxRate.Text = "Tax rate %";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantity.Location = new System.Drawing.Point(3, 111);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(114, 17);
			this.lblQuantity.TabIndex = 27;
			this.lblQuantity.Text = "Quantity Availble";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDiscount.Location = new System.Drawing.Point(3, 289);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(113, 17);
			this.lblDiscount.TabIndex = 28;
			this.lblDiscount.Text = "Discount $ value";
			// 
			// grpBxPrdInfo
			// 
			this.grpBxPrdInfo.Controls.Add(this.btnClearBoxes);
			this.grpBxPrdInfo.Controls.Add(this.lblIDtag);
			this.grpBxPrdInfo.Controls.Add(this.btnSetProPhoto);
			this.grpBxPrdInfo.Controls.Add(this.lblImgPath);
			this.grpBxPrdInfo.Controls.Add(this.txtphotoPath);
			this.grpBxPrdInfo.Controls.Add(this.lblPrdID);
			this.grpBxPrdInfo.Controls.Add(this.btnDeleteItem);
			this.grpBxPrdInfo.Controls.Add(this.txtTaxRate);
			this.grpBxPrdInfo.Controls.Add(this.txtDiscount);
			this.grpBxPrdInfo.Controls.Add(this.btnEditItem);
			this.grpBxPrdInfo.Controls.Add(this.lblBarcode);
			this.grpBxPrdInfo.Controls.Add(this.btnAddProduct);
			this.grpBxPrdInfo.Controls.Add(this.txtBarCode);
			this.grpBxPrdInfo.Controls.Add(this.lblPrdName);
			this.grpBxPrdInfo.Controls.Add(this.txtPrice);
			this.grpBxPrdInfo.Controls.Add(this.lblDiscount);
			this.grpBxPrdInfo.Controls.Add(this.lblQuantity);
			this.grpBxPrdInfo.Controls.Add(this.lbltaxRate);
			this.grpBxPrdInfo.Controls.Add(this.lblPrice);
			this.grpBxPrdInfo.Controls.Add(this.lblDescrp);
			this.grpBxPrdInfo.Controls.Add(this.txtPrdDescrp);
			this.grpBxPrdInfo.Controls.Add(this.txtQty);
			this.grpBxPrdInfo.Controls.Add(this.txtprdName);
			this.grpBxPrdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBxPrdInfo.Location = new System.Drawing.Point(984, 12);
			this.grpBxPrdInfo.Name = "grpBxPrdInfo";
			this.grpBxPrdInfo.Size = new System.Drawing.Size(374, 386);
			this.grpBxPrdInfo.TabIndex = 29;
			this.grpBxPrdInfo.TabStop = false;
			this.grpBxPrdInfo.Text = "Product Information";
			// 
			// btnClearBoxes
			// 
			this.btnClearBoxes.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnClearBoxes.Location = new System.Drawing.Point(283, 265);
			this.btnClearBoxes.Name = "btnClearBoxes";
			this.btnClearBoxes.Size = new System.Drawing.Size(82, 64);
			this.btnClearBoxes.TabIndex = 15;
			this.btnClearBoxes.Text = "Clear Fields";
			this.btnClearBoxes.UseVisualStyleBackColor = false;
			this.btnClearBoxes.Click += new System.EventHandler(this.btnClearBoxes_Click);
			// 
			// lblIDtag
			// 
			this.lblIDtag.AutoSize = true;
			this.lblIDtag.Location = new System.Drawing.Point(78, 19);
			this.lblIDtag.Name = "lblIDtag";
			this.lblIDtag.Size = new System.Drawing.Size(78, 17);
			this.lblIDtag.TabIndex = 36;
			this.lblIDtag.Text = "Product ID:";
			// 
			// btnSetProPhoto
			// 
			this.btnSetProPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnSetProPhoto.Location = new System.Drawing.Point(283, 352);
			this.btnSetProPhoto.Name = "btnSetProPhoto";
			this.btnSetProPhoto.Size = new System.Drawing.Size(82, 28);
			this.btnSetProPhoto.TabIndex = 11;
			this.btnSetProPhoto.Text = "Set";
			this.btnSetProPhoto.UseVisualStyleBackColor = false;
			this.btnSetProPhoto.Click += new System.EventHandler(this.btnSetProPhoto_Click);
			// 
			// lblImgPath
			// 
			this.lblImgPath.AutoSize = true;
			this.lblImgPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblImgPath.Location = new System.Drawing.Point(3, 333);
			this.lblImgPath.Name = "lblImgPath";
			this.lblImgPath.Size = new System.Drawing.Size(77, 17);
			this.lblImgPath.TabIndex = 35;
			this.lblImgPath.Text = "Photo path";
			// 
			// txtphotoPath
			// 
			this.txtphotoPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtphotoPath.Location = new System.Drawing.Point(13, 356);
			this.txtphotoPath.Name = "txtphotoPath";
			this.txtphotoPath.ReadOnly = true;
			this.txtphotoPath.Size = new System.Drawing.Size(244, 21);
			this.txtphotoPath.TabIndex = 34;
			// 
			// lblPrdID
			// 
			this.lblPrdID.AutoSize = true;
			this.lblPrdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrdID.Location = new System.Drawing.Point(162, 19);
			this.lblPrdID.Name = "lblPrdID";
			this.lblPrdID.Size = new System.Drawing.Size(72, 17);
			this.lblPrdID.TabIndex = 32;
			this.lblPrdID.Text = "Product Id";
			// 
			// btnDeleteItem
			// 
			this.btnDeleteItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnDeleteItem.Location = new System.Drawing.Point(283, 154);
			this.btnDeleteItem.Name = "btnDeleteItem";
			this.btnDeleteItem.Size = new System.Drawing.Size(82, 64);
			this.btnDeleteItem.TabIndex = 14;
			this.btnDeleteItem.Text = "Delete";
			this.btnDeleteItem.UseVisualStyleBackColor = false;
			this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
			// 
			// txtTaxRate
			// 
			this.txtTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTaxRate.Location = new System.Drawing.Point(12, 261);
			this.txtTaxRate.Name = "txtTaxRate";
			this.txtTaxRate.Size = new System.Drawing.Size(245, 21);
			this.txtTaxRate.TabIndex = 9;
			// 
			// btnEditItem
			// 
			this.btnEditItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnEditItem.Location = new System.Drawing.Point(283, 84);
			this.btnEditItem.Name = "btnEditItem";
			this.btnEditItem.Size = new System.Drawing.Size(82, 64);
			this.btnEditItem.TabIndex = 13;
			this.btnEditItem.Text = "Edit";
			this.btnEditItem.UseVisualStyleBackColor = false;
			this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAddProduct.Location = new System.Drawing.Point(283, 14);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(82, 64);
			this.btnAddProduct.TabIndex = 12;
			this.btnAddProduct.Text = "Add";
			this.btnAddProduct.UseVisualStyleBackColor = false;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// txtBarCode
			// 
			this.txtBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBarCode.Location = new System.Drawing.Point(13, 175);
			this.txtBarCode.Name = "txtBarCode";
			this.txtBarCode.Size = new System.Drawing.Size(244, 21);
			this.txtBarCode.TabIndex = 7;
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.Location = new System.Drawing.Point(13, 218);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(244, 21);
			this.txtPrice.TabIndex = 8;
			// 
			// picBoxProduct
			// 
			this.picBoxProduct.Location = new System.Drawing.Point(984, 404);
			this.picBoxProduct.Name = "picBoxProduct";
			this.picBoxProduct.Size = new System.Drawing.Size(348, 263);
			this.picBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBoxProduct.TabIndex = 30;
			this.picBoxProduct.TabStop = false;
			// 
			// homeButton
			// 
			this.homeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.homeButton.Location = new System.Drawing.Point(684, 26);
			this.homeButton.Name = "homeButton";
			this.homeButton.Size = new System.Drawing.Size(104, 64);
			this.homeButton.TabIndex = 32;
			this.homeButton.Text = "Home";
			this.homeButton.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(810, 26);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 64);
			this.button2.TabIndex = 31;
			this.button2.Text = "Employee Settings";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// searchGB
			// 
			this.searchGB.Controls.Add(this.searchTextBox);
			this.searchGB.Controls.Add(this.nameSearchButton);
			this.searchGB.Controls.Add(this.clearSearchButton);
			this.searchGB.Controls.Add(this.upcSearchButton);
			this.searchGB.Location = new System.Drawing.Point(12, 26);
			this.searchGB.Name = "searchGB";
			this.searchGB.Size = new System.Drawing.Size(507, 64);
			this.searchGB.TabIndex = 33;
			this.searchGB.TabStop = false;
			this.searchGB.Text = "Product Search";
			// 
			// searchTextBox
			// 
			this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchTextBox.Location = new System.Drawing.Point(183, 22);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(217, 26);
			this.searchTextBox.TabIndex = 0;
			// 
			// nameSearchButton
			// 
			this.nameSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.nameSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameSearchButton.Location = new System.Drawing.Point(90, 14);
			this.nameSearchButton.Name = "nameSearchButton";
			this.nameSearchButton.Size = new System.Drawing.Size(75, 43);
			this.nameSearchButton.TabIndex = 2;
			this.nameSearchButton.Text = "Name Search";
			this.nameSearchButton.UseVisualStyleBackColor = false;
			this.nameSearchButton.Click += new System.EventHandler(this.nameSearchButton_Click);
			// 
			// clearSearchButton
			// 
			this.clearSearchButton.BackColor = System.Drawing.SystemColors.Info;
			this.clearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearSearchButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.clearSearchButton.Location = new System.Drawing.Point(406, 15);
			this.clearSearchButton.Name = "clearSearchButton";
			this.clearSearchButton.Size = new System.Drawing.Size(95, 43);
			this.clearSearchButton.TabIndex = 3;
			this.clearSearchButton.Text = "Clear Search";
			this.clearSearchButton.UseVisualStyleBackColor = false;
			this.clearSearchButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// upcSearchButton
			// 
			this.upcSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.upcSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.upcSearchButton.Location = new System.Drawing.Point(9, 14);
			this.upcSearchButton.Name = "upcSearchButton";
			this.upcSearchButton.Size = new System.Drawing.Size(75, 44);
			this.upcSearchButton.TabIndex = 1;
			this.upcSearchButton.Text = "UPC Search";
			this.upcSearchButton.UseVisualStyleBackColor = false;
			this.upcSearchButton.Click += new System.EventHandler(this.upcSearchButton_Click);
			// 
			// EmployeeForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.searchGB);
			this.Controls.Add(this.homeButton);
			this.Controls.Add(this.picBoxProduct);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.grpBxPrdInfo);
			this.Controls.Add(this.btnHome);
			this.Controls.Add(this.btnEmployeeSettings);
			this.Controls.Add(this.dgvInventory);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "EmployeeForm1";
			this.Text = "eyePOS_Employee";
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
			this.grpBxPrdInfo.ResumeLayout(false);
			this.grpBxPrdInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).EndInit();
			this.searchGB.ResumeLayout(false);
			this.searchGB.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnEmployeeSettings;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtprdName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrdDescrp;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblPrdName;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblDescrp;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbltaxRate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.GroupBox grpBxPrdInfo;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrdID;
        private System.Windows.Forms.PictureBox picBoxProduct;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSetProPhoto;
        private System.Windows.Forms.Label lblImgPath;
        private System.Windows.Forms.TextBox txtphotoPath;
        private System.Windows.Forms.Label lblIDtag;
        private System.Windows.Forms.Button btnClearBoxes;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox searchGB;
		private System.Windows.Forms.Button nameSearchButton;
		private System.Windows.Forms.Button clearSearchButton;
		private System.Windows.Forms.Button upcSearchButton;
		private System.Windows.Forms.TextBox searchTextBox;
	}
}