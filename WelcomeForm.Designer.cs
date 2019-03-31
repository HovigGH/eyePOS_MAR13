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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnContinue
			// 
			this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnContinue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContinue.Location = new System.Drawing.Point(12, 151);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new System.Drawing.Size(1346, 451);
			this.btnContinue.TabIndex = 1;
			this.btnContinue.Text = "Click Here to Continue";
			this.btnContinue.UseVisualStyleBackColor = false;
			this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
			// 
			// btnImEmployee
			// 
			this.btnImEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnImEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImEmployee.Location = new System.Drawing.Point(1166, 653);
			this.btnImEmployee.Name = "btnImEmployee";
			this.btnImEmployee.Size = new System.Drawing.Size(192, 84);
			this.btnImEmployee.TabIndex = 2;
			this.btnImEmployee.Text = "I\'m an employee";
			this.btnImEmployee.UseVisualStyleBackColor = false;
			this.btnImEmployee.Click += new System.EventHandler(this.btnImEmployee_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(353, 73);
			this.label1.TabIndex = 3;
			this.label1.Text = "Welcome...";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WelcomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnImEmployee);
			this.Controls.Add(this.btnContinue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "WelcomeForm";
			this.Text = "eyePOS-Welcome";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnImEmployee;
		private System.Windows.Forms.Label label1;
	}
}