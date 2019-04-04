namespace MultiFaceRec
{
    partial class Customers_SettingsForm
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
            this.lblSelectCust = new System.Windows.Forms.Label();
            this.dgvCustms = new System.Windows.Forms.DataGridView();
            this.txtProfile = new System.Windows.Forms.RichTextBox();
            this.lblEmpAccessLevel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectCust
            // 
            this.lblSelectCust.AutoSize = true;
            this.lblSelectCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCust.Location = new System.Drawing.Point(282, -119);
            this.lblSelectCust.Name = "lblSelectCust";
            this.lblSelectCust.Size = new System.Drawing.Size(259, 20);
            this.lblSelectCust.TabIndex = 17;
            this.lblSelectCust.Text = "Select a customer to preview profile";
            // 
            // dgvCustms
            // 
            this.dgvCustms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustms.Location = new System.Drawing.Point(12, 48);
            this.dgvCustms.Name = "dgvCustms";
            this.dgvCustms.Size = new System.Drawing.Size(739, 677);
            this.dgvCustms.TabIndex = 18;
            this.dgvCustms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustms_CellClick);
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(757, 12);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.ReadOnly = true;
            this.txtProfile.Size = new System.Drawing.Size(610, 713);
            this.txtProfile.TabIndex = 20;
            this.txtProfile.Text = "";
            // 
            // lblEmpAccessLevel
            // 
            this.lblEmpAccessLevel.AutoSize = true;
            this.lblEmpAccessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpAccessLevel.Location = new System.Drawing.Point(7, 4);
            this.lblEmpAccessLevel.Name = "lblEmpAccessLevel";
            this.lblEmpAccessLevel.Size = new System.Drawing.Size(291, 25);
            this.lblEmpAccessLevel.TabIndex = 21;
            this.lblEmpAccessLevel.Text = "Select customer to review profile";
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(647, 4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(104, 38);
            this.homeButton.TabIndex = 33;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Customers_SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.lblEmpAccessLevel);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.lblSelectCust);
            this.Controls.Add(this.dgvCustms);
            this.Name = "Customers_SettingsForm";
            this.Text = "eyePOS-Customers Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCust;
        private System.Windows.Forms.DataGridView dgvCustms;
        private System.Windows.Forms.RichTextBox txtProfile;
        private System.Windows.Forms.Label lblEmpAccessLevel;
        private System.Windows.Forms.Button homeButton;
    }
}