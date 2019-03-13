namespace MultiFaceRec
{
    partial class employee_settings_Form
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpPass = new System.Windows.Forms.TextBox();
            this.txtEmpPosition = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpPass = new System.Windows.Forms.Label();
            this.lblEmpPosition = new System.Windows.Forms.Label();
            this.lblEmpAccessLevel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmpAdd = new System.Windows.Forms.Button();
            this.lblEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.rdbtnRegEmp = new System.Windows.Forms.RadioButton();
            this.rdbtnAdmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(4, 4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(666, 441);
            this.dgvEmployees.TabIndex = 0;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(6, 37);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(236, 20);
            this.txtEmpName.TabIndex = 1;
            // 
            // txtEmpPass
            // 
            this.txtEmpPass.Location = new System.Drawing.Point(6, 87);
            this.txtEmpPass.Name = "txtEmpPass";
            this.txtEmpPass.Size = new System.Drawing.Size(236, 20);
            this.txtEmpPass.TabIndex = 2;
            // 
            // txtEmpPosition
            // 
            this.txtEmpPosition.Location = new System.Drawing.Point(6, 126);
            this.txtEmpPosition.Name = "txtEmpPosition";
            this.txtEmpPosition.Size = new System.Drawing.Size(236, 20);
            this.txtEmpPosition.TabIndex = 3;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(6, 16);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(52, 13);
            this.lblEmpName.TabIndex = 5;
            this.lblEmpName.Text = "Full name";
            // 
            // lblEmpPass
            // 
            this.lblEmpPass.AutoSize = true;
            this.lblEmpPass.Location = new System.Drawing.Point(3, 67);
            this.lblEmpPass.Name = "lblEmpPass";
            this.lblEmpPass.Size = new System.Drawing.Size(53, 13);
            this.lblEmpPass.TabIndex = 6;
            this.lblEmpPass.Text = "Password";
            // 
            // lblEmpPosition
            // 
            this.lblEmpPosition.AutoSize = true;
            this.lblEmpPosition.Location = new System.Drawing.Point(4, 110);
            this.lblEmpPosition.Name = "lblEmpPosition";
            this.lblEmpPosition.Size = new System.Drawing.Size(44, 13);
            this.lblEmpPosition.TabIndex = 7;
            this.lblEmpPosition.Text = "Position";
            // 
            // lblEmpAccessLevel
            // 
            this.lblEmpAccessLevel.AutoSize = true;
            this.lblEmpAccessLevel.Location = new System.Drawing.Point(3, 152);
            this.lblEmpAccessLevel.Name = "lblEmpAccessLevel";
            this.lblEmpAccessLevel.Size = new System.Drawing.Size(71, 13);
            this.lblEmpAccessLevel.TabIndex = 8;
            this.lblEmpAccessLevel.Text = "Access Level";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnAdmin);
            this.groupBox1.Controls.Add(this.rdbtnRegEmp);
            this.groupBox1.Controls.Add(this.lblEmpAccessLevel);
            this.groupBox1.Controls.Add(this.lblEmpName);
            this.groupBox1.Controls.Add(this.lblEmpPosition);
            this.groupBox1.Controls.Add(this.lblEmpPass);
            this.groupBox1.Controls.Add(this.txtEmpPosition);
            this.groupBox1.Controls.Add(this.txtEmpPass);
            this.groupBox1.Controls.Add(this.txtEmpName);
            this.groupBox1.Location = new System.Drawing.Point(676, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 214);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee info Add/Edit";
            // 
            // lblEmpAdd
            // 
            this.lblEmpAdd.Location = new System.Drawing.Point(682, 242);
            this.lblEmpAdd.Name = "lblEmpAdd";
            this.lblEmpAdd.Size = new System.Drawing.Size(75, 37);
            this.lblEmpAdd.TabIndex = 10;
            this.lblEmpAdd.Text = "Add";
            this.lblEmpAdd.UseVisualStyleBackColor = true;
            this.lblEmpAdd.Click += new System.EventHandler(this.lblEmpAdd_Click);
            // 
            // lblEmpEdit
            // 
            this.lblEmpEdit.Location = new System.Drawing.Point(763, 242);
            this.lblEmpEdit.Name = "lblEmpEdit";
            this.lblEmpEdit.Size = new System.Drawing.Size(75, 37);
            this.lblEmpEdit.TabIndex = 11;
            this.lblEmpEdit.Text = "Edit";
            this.lblEmpEdit.UseVisualStyleBackColor = true;
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.Location = new System.Drawing.Point(843, 242);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(75, 37);
            this.btnEmpDelete.TabIndex = 12;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.UseVisualStyleBackColor = true;
            // 
            // rdbtnRegEmp
            // 
            this.rdbtnRegEmp.AutoSize = true;
            this.rdbtnRegEmp.Location = new System.Drawing.Point(9, 178);
            this.rdbtnRegEmp.Name = "rdbtnRegEmp";
            this.rdbtnRegEmp.Size = new System.Drawing.Size(62, 17);
            this.rdbtnRegEmp.TabIndex = 9;
            this.rdbtnRegEmp.TabStop = true;
            this.rdbtnRegEmp.Text = "Regular";
            this.rdbtnRegEmp.UseVisualStyleBackColor = true;
            this.rdbtnRegEmp.CheckedChanged += new System.EventHandler(this.rdbtnRegEmp_CheckedChanged);
            // 
            // rdbtnAdmin
            // 
            this.rdbtnAdmin.AutoSize = true;
            this.rdbtnAdmin.Location = new System.Drawing.Point(136, 178);
            this.rdbtnAdmin.Name = "rdbtnAdmin";
            this.rdbtnAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdbtnAdmin.TabIndex = 10;
            this.rdbtnAdmin.TabStop = true;
            this.rdbtnAdmin.Text = "Admin";
            this.rdbtnAdmin.UseVisualStyleBackColor = true;
            this.rdbtnAdmin.CheckedChanged += new System.EventHandler(this.rdbtnRegEmp_CheckedChanged);
            // 
            // employee_settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.btnEmpDelete);
            this.Controls.Add(this.lblEmpEdit);
            this.Controls.Add(this.lblEmpAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "employee_settings_Form";
            this.Text = "employee_settings_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpPass;
        private System.Windows.Forms.TextBox txtEmpPosition;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpPass;
        private System.Windows.Forms.Label lblEmpPosition;
        private System.Windows.Forms.Label lblEmpAccessLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lblEmpAdd;
        private System.Windows.Forms.Button lblEmpEdit;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.RadioButton rdbtnAdmin;
        private System.Windows.Forms.RadioButton rdbtnRegEmp;
    }
}