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
    public partial class frmCustomer : Form
    {
        int user_id = 0;
        int teacher = 0;

        public frmCustomer(int user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
        }

        Product[] cart = new Product[50];

        
        private void query_products(object sender,EventArgs e)
        {
            
           
            DataTable result = find_products(sender, e);
          
            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Product not found");
            }
            else
            {

                string users_found = $"Product Found: {result.Rows.Count},";
                foreach (DataRow dataRow in result.Rows)
                {
                    users_found = users_found.Remove(users_found.Length - 1, 1) + "\n";
                    foreach (var item in dataRow.ItemArray)
                    {
                        users_found += item.ToString() + ",";

                    }
                }
                MessageBox.Show(users_found.Remove(users_found.Length - 1, 1));
            }
        }

        private DataTable find_products(object sender, EventArgs e)
        {


            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);
            string name_query = "any(select name from Products)";
            string category_query = "any(select category from Products)";
            string cost_query = "any(select price from Products)";

            string id_query = "any(select id from Products)";

            if (category.Text != "")
            {
                category_query = $"'{category.Text}'";
            }

            if (name.Text != "")
            {
                name_query = $"'{name.Text}'";
            }

            if (cost.Text != "")
            {
                cost_query = $"'{cost.Text}'";
            }

            if (id.Text != "")
            {
                id_query = $"'{id.Text}'";
            }


            string query = $"Select * from Products Where name = {name_query} and category = {category_query} and " +
                $"price = {cost_query} and id = {id_query}";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            try
            {
                sda.Fill(dtbl);
            }
            catch (Exception)
            {
              
                
                return dtbl;
            }
            
            return dtbl;

            
            
           

        }

        private void Add_to_cart(object sender, EventArgs e)
        {


            DataTable result = find_products(sender, e);

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Product not found");
            }
            else
            {
                
                foreach (DataRow dataRow in result.Rows)
                {
                    

                    shopping_cart.Rows.Add(new object[] { Int32.Parse(dataRow[0].ToString()), dataRow[1].ToString(), dataRow[2].ToString(), Int32.Parse(dataRow[3].ToString()) });

                }
                

            }
        }

        private double discount_amount()
        {
            double deductable = 1;

            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);



            string query = $"Select * from login Where id = {user_id}";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            try
            {
                sda.Fill(dtbl);

                if(Int32.Parse(dtbl.Rows[0][3].ToString()) >= 65 || Int32.Parse(dtbl.Rows[0][3].ToString()) == 1)
                {
                    deductable = deductable - 0.055;
                }
                if(Int32.Parse(dtbl.Rows[0][6].ToString()) == 1)
                {
                    teacher = 1;
                }


            }
            catch (Exception)
            {

                MessageBox.Show("User not found");
            }

            return deductable + 0.055;
        }

        public void purchase_btn_clicked(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);

            string payment_type = "cash";
            double deductible = discount_amount();
            double cost = 0;

            string product = "";
            foreach (DataGridViewRow dataRow in shopping_cart.Rows)
            {
                if (dataRow.Cells[0].Value == null || dataRow.Cells[1].Value == null || dataRow.Cells[2].Value == null || dataRow.Cells[3].Value == null)
                {
                    break;
                }
                else {
                    if (teacher == 1 && dataRow.Cells[2].Value.ToString() == "books")
                    {
                        cost = Double.Parse(dataRow.Cells[3].Value.ToString()) * (deductible - 0.1) + cost;
                    }
                    cost = Double.Parse(dataRow.Cells[3].Value.ToString()) * deductible + cost;

                    product += dataRow.Cells[0].Value + ",";

                }

            }

              string query = "Select invoice_id from invoices";

            SqlCommand command = new SqlCommand(query, sqlcon);

            sqlcon.Open();

            int new_id = 0;
            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    new_id = (int)reader["invoice_id"] + 1;

                }
            }



            product = product.Trim(',');
 

            query = $"insert into invoices (invoice_id,product_ids,user_id,amount,payment_type) values({new_id},'{product}',{user_id},{cost},'{payment_type}')";

            command = new SqlCommand(query, sqlcon);



            command.ExecuteNonQuery();

            shopping_cart.Rows.Clear();
            shopping_cart.Refresh();
            MessageBox.Show("Items purchased");

        }

        public void clear_cart_btn(object sender,EventArgs e)
        {

            shopping_cart.Rows.Clear();
            shopping_cart.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void show_invoices(object sender, EventArgs e)
        {
            frmInvoices objFrmInvoices = new frmInvoices(user_id,0);
            this.Hide();
            objFrmInvoices.Show();
        }

        private void logout(object sender, EventArgs e)
        {
            frmLogin objFrm = new frmLogin();
            this.Hide();
            objFrm.Show();
        }


    }
}
