using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnImEmployee_Click(object sender, EventArgs e)
        {

            // this.Hide();
            // welcome.ShowDialog();
            //this.Show();
            EmployeeLogIn employeeLogIn = new EmployeeLogIn();
            employeeLogIn.Show();
            this.Hide();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
           // this.Hide();
          //  empLogin.ShowDialog();
           // this.Show();
          
        }
    }
}
