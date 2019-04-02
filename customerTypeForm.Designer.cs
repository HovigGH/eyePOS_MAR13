namespace MultiFaceRec
{
    partial class CustomerTypeForm
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
			this.btnNew = new System.Windows.Forms.Button();
			this.btnExist = new System.Windows.Forms.Button();
			this.lblIAm = new System.Windows.Forms.Label();
			this.btnHome = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnNew
			// 
			this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Location = new System.Drawing.Point(215, 35);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(500, 635);
			this.btnNew.TabIndex = 0;
			this.btnNew.Text = "New Customer";
			this.btnNew.UseVisualStyleBackColor = false;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnExist
			// 
			this.btnExist.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExist.Location = new System.Drawing.Point(756, 35);
			this.btnExist.Name = "btnExist";
			this.btnExist.Size = new System.Drawing.Size(500, 635);
			this.btnExist.TabIndex = 1;
			this.btnExist.Text = "Existing Customer";
			this.btnExist.UseVisualStyleBackColor = false;
			this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
			// 
			// lblIAm
			// 
			this.lblIAm.AutoSize = true;
			this.lblIAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIAm.Location = new System.Drawing.Point(12, 35);
			this.lblIAm.Name = "lblIAm";
			this.lblIAm.Size = new System.Drawing.Size(103, 26);
			this.lblIAm.TabIndex = 2;
			this.lblIAm.Text = "I\'m a(n)...";
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.Location = new System.Drawing.Point(12, 287);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(148, 111);
			this.btnHome.TabIndex = 4;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// CustomerTypeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.btnHome);
			this.Controls.Add(this.lblIAm);
			this.Controls.Add(this.btnExist);
			this.Controls.Add(this.btnNew);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CustomerTypeForm";
			this.Text = "eyePOS";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Label lblIAm;
        private System.Windows.Forms.Button btnHome;
    }
}