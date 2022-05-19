using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class frmAdminOptions : Form
    {
        int id = -1;
        public frmAdminOptions(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Open_User_Admin(object sender, EventArgs e)
        {
            frmUserAdmin objFrmUserAdmin = new frmUserAdmin(id);
            this.Hide();
            objFrmUserAdmin.Show();
        }

        private void Open_Product_Admin(object sender, EventArgs e)
        {
            frmProductAdmin objFrmProductAdmin = new frmProductAdmin(id);
            this.Hide();
            objFrmProductAdmin.Show();
        }

        private void show_invoices(object sender, EventArgs e)
        {
            frmInvoices objFrmInvoices = new frmInvoices(id, 1);
            this.Hide();
            objFrmInvoices.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            frmLogin objFrm = new frmLogin();
            this.Hide();
            objFrm.Show();
        }
    }
}
