using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//This is the first form, where the user chooces the mode employee or customer
namespace MultiFaceRec
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        
        //go to employee log in from
        private void btnImEmployee_Click(object sender, EventArgs e)
        {
			this.Hide();
			EmployeeLogInForm employeeLogIn = new EmployeeLogInForm("WelcomeForm");
            employeeLogIn.ShowDialog();
			this.Show();
		}

        //Continue as customer
        private void btnContinue_Click(object sender, EventArgs e)
        {
                /*
                System.IO.File.WriteAllText(@"profiles\\2.txt", "ara");

                if (File.Exists("profiles\\1.txt"))
                    MessageBox.Show("Yes");
                if (!File.Exists("profiles\\1.txt"))
                    MessageBox.Show("nah nah");
                    */
                CustomerTypeForm id = new CustomerTypeForm();
			this.Hide();
            id.ShowDialog();
            this.Show();
        }
    }
}
