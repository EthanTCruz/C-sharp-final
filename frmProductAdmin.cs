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
    public partial class frmProductAdmin : Form
    {
        int user = -1;
        public frmProductAdmin(int user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void add_product_btn_clicked(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);
            string query = "Select id from Products";

            SqlCommand command = new SqlCommand(query, sqlcon);

            sqlcon.Open();

            int new_id = 0;
            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    new_id = (int)reader["id"] + 1;
                }
            }


            query = $"insert into Products (id,name,category,price)  values ({new_id},'{name.Text}','{category.Text}',{cost.Text})";

            command = new SqlCommand(query, sqlcon);
            
            command.ExecuteNonQuery();
            MessageBox.Show("product added");
        }


        private void find_product_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString); string name_query = "any(select name from Products)";
            string category_query = "any(select category from Products)";
            string cost_query = "any(select price from Products)";

            string id_query = "any(select id from Products)";

            if (name.Text != "")
            {
                name_query = $"'{name.Text}'";
            }

            if (category.Text != "")
            {
                category_query = $"'{category.Text}'";
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
                
                MessageBox.Show("Product not found");
            }
            string users_found = $"Product Found: {dtbl.Rows.Count},";
           
            foreach (DataRow dataRow in dtbl.Rows)
            {
                users_found = users_found.Remove(users_found.Length - 1, 1) + "\n";
                foreach (var item in dataRow.ItemArray)
                {
                    users_found += item.ToString() + ",";

                }
            }
            MessageBox.Show(users_found.Remove(users_found.Length - 1, 1));


        }


        private void Delete_Product_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString); string name_query = "";
            string price_query = "";
            string category_query = "";
            string id_query = "";



            if (name.Text != "")
            {
                name_query = $"and name = '{name.Text}'";
            }



            if (cost.Text != "")
            {
                price_query = $"and price = '{cost.Text}'";
            }

            if (category.Text != "")
            {
                category_query = $"and category = '{category.Text}'";
            }


            if (id.Text != "")
            {
                id_query = $"'{id.Text}'";
            }


            string query = $"delete from Products Where   id = {id_query} {name_query} {price_query} {category_query}";

            SqlCommand command = new SqlCommand(query, sqlcon);

            sqlcon.Open();
     
            command.ExecuteNonQuery();




        }



        public void update_product_btn_clicked(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString); string name_query = "";
            string price_query = "";
            string category_query = "";
            string id_query = "";



            if (name.Text != "")
            {
                name_query = $", name = '{name.Text}'";
            }



            if (cost.Text != "")
            {
                price_query = $", price = '{cost.Text}'";
            }

            if (category.Text != "")
            {
                category_query = $", category = '{category.Text}'";
            }


            if (id.Text != "")
            {
                id_query = $"'{id.Text}'";
            }


            string query = $"update Products set id = {id_query} {category_query} {price_query} {name_query} where id = {id_query}";

            SqlCommand command = new SqlCommand(query, sqlcon);

            sqlcon.Open();


            command.ExecuteNonQuery();
        }

        private void Back(object sender, EventArgs e)
        {
            frmAdminOptions objFrm = new frmAdminOptions(user);
            this.Hide();
            objFrm.Show();
        }
    }

    }

