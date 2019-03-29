using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//This form directs each type of customer to the appropriate form
namespace MultiFaceRec
{
    public partial class CustomerTypeForm : Form
    {
        public CustomerTypeForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        //Go to the form to get the new customer info
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfoForm userinfo = new UserInfoForm();
			userinfo.ShowDialog();
        }

        //Go to form to start checkout 
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustScanForm custscan = new CustScanForm("CustomerTypeForm", "existing");
            custscan.ShowDialog();
            //custscan.ShowDialog();
            //this.Close();
        }

        //back to home form
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
