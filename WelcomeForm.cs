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
            EmployeeLogInForm employeeLogIn = new EmployeeLogInForm();

			this.Hide();
			employeeLogIn.ShowDialog();
			this.Show();

		}

        private void btnContinue_Click(object sender, EventArgs e)
        {
			CustomerTypeForm id = new CustomerTypeForm();

			this.Hide();
            id.ShowDialog();
            this.Show();
          
        }
    }
}
