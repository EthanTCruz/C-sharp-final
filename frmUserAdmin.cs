using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class frmUserAdmin : Form
    {
        int user = -1;
        public frmUserAdmin(int user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_user_btn_clicked(object sender, EventArgs e)
        {
            
            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString); string query = "Select id from login";

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

            
            query = $"insert into login (id,username,password,age,veteran,admin,teacher,phone,email)  values ({new_id},'{username.Text}','{password.Text}',{age.Text}," +
                $"{veteran.Text},{admin.Text},{teacher.Text},'{phone.Text}','{email.Text}');";

            command = new SqlCommand(query, sqlcon);
    
            command.ExecuteNonQuery();   
            MessageBox.Show("user added");
        }



        private void find_user_Click(object sender, EventArgs e)
        {

            users_grid.Rows.Clear();
            users_grid.Refresh();

            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);

            string username_query = "any(select username from login)";
            string age_query = "any(select age from login)";
            string admin_query = "any(select admin from login)";
            string teacher_query = "any(select teacher from login)";
            string phone_query = "any(select phone from login)";
            string email_query = "any(select email from login)";
            string id_query = "any(select Id from login)";
            string veteran_query = "any(select veteran from login)";

            if (veteran.Text != "")
            {
                veteran_query = $"'{veteran.Text}'";
            }
            if (id.Text != "")
            {
                id_query = $"'{id.Text}'";
            }
            if (username.Text != "")
            {
                username_query = $"'{username.Text}'";
            }

            if (age.Text != "")
            {
                age_query = $"'{age.Text}'";
            }
            if (admin.Text != "")
            {
                admin_query = $"'{admin.Text}'";
            }
            if (teacher.Text != "")
            {
                teacher_query = $"'{teacher.Text}'";
            }
            if (phone.Text != "")
            {
                phone_query = $"'{phone.Text}'";
            }
            if (email.Text != "")
            {
                email_query = $"'{email.Text}'";
            }

            string query = $"Select * from login Where id = {id_query} and username = {username_query} and age = {age_query} and " +
                $" teacher = {teacher_query} and admin = {admin_query} and veteran = {veteran_query} and phone = {phone_query} and email = {email_query}";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            try
            {
                sda.Fill(dtbl);

                foreach (DataRow dataRow in dtbl.Rows)
                {


                    users_grid.Rows.Add(new object[] { dataRow[0].ToString(), dataRow[1].ToString(), 
                        dataRow[3].ToString(), dataRow[4].ToString(),
                        dataRow[5].ToString(), dataRow[6].ToString(),  dataRow[8].ToString(), dataRow[7].ToString() });


                }


            }
            catch (Exception)
            {

                MessageBox.Show("Users not found");
            }


        }


        private void delete_user_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);
            string username_query = "";
            string veteran_query = "";
            string admin_query = "";
            string age_query = "";
            string id_query = "";
            string teacher_query = "";
            string email_query = "";
            string phone_query = "";




            if (teacher.Text != "")
            {
               teacher_query = $"teacher = '{teacher.Text}'";
            }
            if (email.Text != "")
            {
                email_query = $"email = '{email.Text}'";
            }
            if (phone.Text != "")
            {
                phone_query = $"phone = '{phone.Text}'";
            }
            if (username.Text != "")
            {
                username_query = $"username = '{username.Text}'";
            }



            if (age.Text != "")
            {
                age_query = $"and age = '{age.Text}'";
            }

            if (veteran.Text != "")
            {
                veteran_query = $"and veteran = '{veteran.Text}'";
            }

            if (admin.Text != "")
            {
                admin_query = $"and admin ='{admin.Text}'";
            }
            if (id.Text != "")
            {
                id_query = $"and id = '{id.Text}'";
            }


            string query = $"delete from login Where {username_query} {age_query} {veteran_query} {admin_query} {teacher_query} " +
                $"{phone_query} {email_query} {id_query} ";


            SqlCommand command = new SqlCommand(query, sqlcon);

            sqlcon.Open();
          

            command.ExecuteNonQuery();




        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void frmUserAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.usersDataSet.login);

        }

        private void show_all_users(object sender, EventArgs e)
        {
            users_grid.Rows.Clear();
            users_grid.Refresh();

            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);


            string query = $"Select * from login ";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            try
            {
                sda.Fill(dtbl);

                foreach (DataRow dataRow in dtbl.Rows)
                {


                    users_grid.Rows.Add(new object[] { dataRow[0].ToString(), dataRow[1].ToString(),
                         dataRow[3].ToString(), dataRow[4].ToString(),
                        dataRow[5].ToString(), dataRow[6].ToString(),  dataRow[8].ToString(),dataRow[7].ToString() });


                }


            }
            catch (Exception)
            {

                MessageBox.Show("Invoices not found");
            }

        }

        public void update_user_btn_clicked(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Connection.ConnectionString);
            string username_query = "";
            string password_query = "";
            string age_query = "";
            string id_query = "";
            string veteran_query = "";
            string admin_query = "";
            string teacher_query = "";
            string phone_query = "";
            string email_query = "";



            if (phone.Text != "")
            {
                phone_query = $", phone = '{phone.Text}'";
            }
            if (teacher.Text != "")
            {
                teacher_query = $", teacher = '{teacher.Text}'";
            }
            if (email.Text != "")
            {
                email_query = $", email = '{email.Text}'";
            }

            if (username.Text != "")
            {
                username_query = $", username = '{username.Text}'";
            }



            if (password.Text != "")
            {
                password_query = $", password = '{password.Text}'";
            }

            if (veteran.Text != "")
            {
                veteran_query = $", veteran = '{veteran.Text}'";
            }

            if (admin.Text != "")
            {
                admin_query = $", admin = '{admin.Text}'";
            }

            if (age.Text != "")
            {
                age_query = $", age = '{age.Text}'";
            }

            if (id.Text != "")
            {
                id_query = $"'{id.Text}'";
            }


            string query = $"update login set id = {id_query} {username_query} {password_query} {age_query} {veteran_query} {admin_query} " +
                $"{teacher_query} {phone_query} {email_query} where id = {id_query}";

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
