namespace MultiFaceRec
{
    partial class customerTypeForm
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
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnExistnCustomer = new System.Windows.Forms.Button();
            this.lblIAm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(83, 12);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(182, 258);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.Text = "New customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnExistnCustomer
            // 
            this.btnExistnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistnCustomer.Location = new System.Drawing.Point(271, 12);
            this.btnExistnCustomer.Name = "btnExistnCustomer";
            this.btnExistnCustomer.Size = new System.Drawing.Size(169, 258);
            this.btnExistnCustomer.TabIndex = 1;
            this.btnExistnCustomer.Text = "Existing customer";
            this.btnExistnCustomer.UseVisualStyleBackColor = true;
            this.btnExistnCustomer.Click += new System.EventHandler(this.btnExistnCustomer_Click);
            // 
            // lblIAm
            // 
            this.lblIAm.AutoSize = true;
            this.lblIAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIAm.Location = new System.Drawing.Point(12, 35);
            this.lblIAm.Name = "lblIAm";
            this.lblIAm.Size = new System.Drawing.Size(49, 24);
            this.lblIAm.TabIndex = 2;
            this.lblIAm.Text = "I\'m a";
            // 
            // customerTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 282);
            this.Controls.Add(this.lblIAm);
            this.Controls.Add(this.btnExistnCustomer);
            this.Controls.Add(this.btnNewCustomer);
            this.Name = "customerTypeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnExistnCustomer;
        private System.Windows.Forms.Label lblIAm;
    }
}