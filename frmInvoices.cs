using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class frmInvoices : Form
    {
        int user = -1;
        int admin = 0;
        public frmInvoices(int user,int is_admin)
        {
            this.user = user;
            this.admin = is_admin;
            InitializeComponent();
            Console.WriteLine(admin);
            if(admin == 0)
            {
                user_id_label.Visible = false;
                user_id_search.Visible = false;
            }
        }

        private void Show_All_Invoices(object sender, EventArgs e)
        {

            invoices_found.Rows.Clear();
            invoices_found.Refresh();

            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);

            string user_id_query = "any(select user_id from invoices)";

            if (admin == 0)
            {
                user_id_query = user.ToString();
            }

            string query = $"Select * from invoices where user_id = {user_id_query}";
            Console.WriteLine(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            try
            {
                sda.Fill(dtbl);

                foreach (DataRow dataRow in dtbl.Rows)
                {

    
                   invoices_found.Rows.Add(new object[] { dataRow[0].ToString(), dataRow[1].ToString(), dataRow[2].ToString(), dataRow[3].ToString(),dataRow[4].ToString() });


                }


            }
            catch (Exception)
            {

                MessageBox.Show("Invoices not found");
            }

        }
        private void Search_Invoices_Click(object sender, EventArgs e)
        {
            invoices_found.Rows.Clear();
            invoices_found.Refresh();

            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);

            string user_id_query = "any(select user_id from invoices)";
            string product_id_query = "";
            string invoice_id_query  = "any(select invoice_id from invoices)";
            string payment_type_query = "any(select payment_type from invoices)";
            string amount_query = "any(select amount from invoices)";
           
            if (user_id_search.Text != "")
            {
                user_id_query = $"'{user_id_search.Text}'";
            }
            if (product_id_search.Text != "")
            {
                product_id_query = $"'{product_id_search.Text}'";
            }
            if (invoice_id_search.Text != "")
            {
                invoice_id_query = $"'{invoice_id_search.Text}'";
            }
            if (payment_type_search.Text != "")
            {
                payment_type_query = $"'{payment_type_search.Text}'";
            }

            if (amount_search.Text != "")
            {
                amount_query = $"'{amount_search.Text}'";
            }
            if (admin == 0)
            {
                user_id_query = user.ToString();
            }



            string query = $"Select * from invoices Where user_id = {user_id_query} and invoice_id = {invoice_id_query} and " +
                $"product_ids like '%{product_id_query}%' and payment_type = {payment_type_query} and amount = {amount_query}";
            Console.WriteLine(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            try
            {
                sda.Fill(dtbl);

                foreach (DataRow dataRow in dtbl.Rows)
                {

    
                    invoices_found.Rows.Add(new object[] { dataRow[0].ToString(), dataRow[1].ToString(), dataRow[2].ToString(), dataRow[3].ToString(),dataRow[4].ToString() });


                }


            }
            catch (Exception)
            {

                MessageBox.Show("Invoices not found");
            }



        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void back_to_options(object sender, EventArgs e)
        {
            if (admin == 1)
            {
                frmAdminOptions objFrm = new frmAdminOptions(user);
                this.Hide();
                objFrm.Show();
            }
            else
            {
                frmCustomer objFrm = new frmCustomer(user);
                this.Hide();
                objFrm.Show();
            }
        }
    }
}
