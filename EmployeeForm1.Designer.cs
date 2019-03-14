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
			this.btnNameSearchButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.upcSearchButton = new System.Windows.Forms.Button();
			this.searchGB = new System.Windows.Forms.GroupBox();
			this.btnAddInvButton = new System.Windows.Forms.Button();
			this.btnRefund = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnUserView = new System.Windows.Forms.Button();
			this.btnEmployeeSettings = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
			this.searchGB.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvInventory
			// 
			this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInventory.Location = new System.Drawing.Point(12, 12);
			this.dgvInventory.Name = "dgvInventory";
			this.dgvInventory.Size = new System.Drawing.Size(714, 537);
			this.dgvInventory.TabIndex = 0;
			// 
			// btnNameSearchButton
			// 
			this.btnNameSearchButton.Location = new System.Drawing.Point(235, 19);
			this.btnNameSearchButton.Name = "btnNameSearchButton";
			this.btnNameSearchButton.Size = new System.Drawing.Size(115, 86);
			this.btnNameSearchButton.TabIndex = 1;
			this.btnNameSearchButton.Text = "Search by Product Name";
			this.btnNameSearchButton.UseVisualStyleBackColor = true;
			this.btnNameSearchButton.Click += new System.EventHandler(this.btnNameSearchButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 111);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(344, 20);
			this.textBox1.TabIndex = 3;
			// 
			// upcSearchButton
			// 
			this.upcSearchButton.Location = new System.Drawing.Point(6, 19);
			this.upcSearchButton.Name = "upcSearchButton";
			this.upcSearchButton.Size = new System.Drawing.Size(115, 86);
			this.upcSearchButton.TabIndex = 4;
			this.upcSearchButton.Text = "Search by UPC";
			this.upcSearchButton.UseVisualStyleBackColor = true;
			this.upcSearchButton.Click += new System.EventHandler(this.upcSearchButton_Click);
			// 
			// searchGB
			// 
			this.searchGB.Controls.Add(this.upcSearchButton);
			this.searchGB.Controls.Add(this.textBox1);
			this.searchGB.Controls.Add(this.btnNameSearchButton);
			this.searchGB.Location = new System.Drawing.Point(732, 12);
			this.searchGB.Name = "searchGB";
			this.searchGB.Size = new System.Drawing.Size(356, 138);
			this.searchGB.TabIndex = 6;
			this.searchGB.TabStop = false;
			this.searchGB.Text = "Search for Product";
			// 
			// btnAddInvButton
			// 
			this.btnAddInvButton.Location = new System.Drawing.Point(732, 149);
			this.btnAddInvButton.Name = "btnAddInvButton";
			this.btnAddInvButton.Size = new System.Drawing.Size(82, 64);
			this.btnAddInvButton.TabIndex = 7;
			this.btnAddInvButton.Text = "Add to Stock";
			this.btnAddInvButton.UseVisualStyleBackColor = true;
			this.btnAddInvButton.Click += new System.EventHandler(this.btnAddInvButton_Click);
			// 
			// btnRefund
			// 
			this.btnRefund.Location = new System.Drawing.Point(1000, 149);
			this.btnRefund.Name = "btnRefund";
			this.btnRefund.Size = new System.Drawing.Size(82, 64);
			this.btnRefund.TabIndex = 9;
			this.btnRefund.Text = "Refund";
			this.btnRefund.UseVisualStyleBackColor = true;
			this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(732, 476);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(82, 64);
			this.btnRefresh.TabIndex = 10;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnUserView
			// 
			this.btnUserView.Location = new System.Drawing.Point(1000, 476);
			this.btnUserView.Name = "btnUserView";
			this.btnUserView.Size = new System.Drawing.Size(82, 64);
			this.btnUserView.TabIndex = 11;
			this.btnUserView.Text = "User View";
			this.btnUserView.UseVisualStyleBackColor = true;
			this.btnUserView.Click += new System.EventHandler(this.btnUserView_Click);
			// 
			// btnEmployeeSettings
			// 
			this.btnEmployeeSettings.Location = new System.Drawing.Point(912, 476);
			this.btnEmployeeSettings.Name = "btnEmployeeSettings";
			this.btnEmployeeSettings.Size = new System.Drawing.Size(82, 64);
			this.btnEmployeeSettings.TabIndex = 12;
			this.btnEmployeeSettings.Text = "Employee settings";
			this.btnEmployeeSettings.UseVisualStyleBackColor = true;
			this.btnEmployeeSettings.Click += new System.EventHandler(this.btnEmployeeSettings_Click);
			// 
			// EmployeeForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1087, 552);
			this.Controls.Add(this.btnEmployeeSettings);
			this.Controls.Add(this.btnUserView);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnRefund);
			this.Controls.Add(this.btnAddInvButton);
			this.Controls.Add(this.searchGB);
			this.Controls.Add(this.dgvInventory);
			this.Name = "EmployeeForm1";
			this.Text = "EmpForm1";
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
			this.searchGB.ResumeLayout(false);
			this.searchGB.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnNameSearchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button upcSearchButton;
        private System.Windows.Forms.GroupBox searchGB;
        private System.Windows.Forms.Button btnAddInvButton;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUserView;
        private System.Windows.Forms.Button btnEmployeeSettings;
    }
}