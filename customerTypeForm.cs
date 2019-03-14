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
    public partial class CustomerTypeForm : Form
    {
        public CustomerTypeForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
			try
			{
				FrmPrincipal frmPrincipal = new FrmPrincipal('n');

				this.Hide();
				frmPrincipal.ShowDialog();
				this.Close();
			}
			catch
			{
				MessageBox.Show("Errors with Facial Algorithm or Camera, continuing to scanning.");

				CustForm1 custscan = new CustForm1();

				this.Hide();
				custscan.ShowDialog();
				this.Close();

			}
        }

        private void btnExist_Click(object sender, EventArgs e)
        {

			try
			{
				FrmPrincipal frmPrincipal = new FrmPrincipal('e');

				this.Hide();
				frmPrincipal.ShowDialog();
				this.Close();
			}
			catch
			{
				MessageBox.Show("Errors with Facial Algorithm or Camera, continuing to scanning.");

				CustForm1 custscan = new CustForm1();

				this.Hide();
				custscan.ShowDialog();
				this.Close();
			}

		}
    }
}
