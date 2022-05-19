using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);

            string query = "Select * from login Where username = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                if (dtbl.Rows[0]["admin"].ToString() == "1")
                {

                    frmAdminOptions objFrmAdmin = new frmAdminOptions(Int32.Parse(dtbl.Rows[0]["Id"].ToString()));
                    this.Hide();
                    objFrmAdmin.Show();

                }
                else
                {
                    
                    frmCustomer objFrmMain = new frmCustomer(Int32.Parse(dtbl.Rows[0]["id"].ToString()));
                    this.Hide();
                    objFrmMain.Show();
                }
            }

            else
            {
                MessageBox.Show("Check your username and password");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
