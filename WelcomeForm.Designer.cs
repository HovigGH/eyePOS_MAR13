namespace MultiFaceRec
{
    partial class WelcomeForm
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
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnImEmployee = new System.Windows.Forms.Button();
            this.lblWlc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(12, 99);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(918, 358);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Click Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnImEmployee
            // 
            this.btnImEmployee.Location = new System.Drawing.Point(813, 463);
            this.btnImEmployee.Name = "btnImEmployee";
            this.btnImEmployee.Size = new System.Drawing.Size(117, 46);
            this.btnImEmployee.TabIndex = 2;
            this.btnImEmployee.Text = "I\'m an employee";
            this.btnImEmployee.UseVisualStyleBackColor = true;
            this.btnImEmployee.Click += new System.EventHandler(this.btnImEmployee_Click);
            // 
            // lblWlc
            // 
            this.lblWlc.AutoSize = true;
            this.lblWlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWlc.Location = new System.Drawing.Point(12, 9);
            this.lblWlc.Name = "lblWlc";
            this.lblWlc.Size = new System.Drawing.Size(230, 24);
            this.lblWlc.TabIndex = 4;
            this.lblWlc.Text = "eyePOS Welcomes you";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 521);
            this.Controls.Add(this.lblWlc);
            this.Controls.Add(this.btnImEmployee);
            this.Controls.Add(this.btnContinue);
            this.Name = "WelcomeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnImEmployee;
        private System.Windows.Forms.Label lblWlc;
    }
}