using System.Windows.Forms;

namespace LoginApp
{
    partial class frmUserAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.veteran = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.TextBox();
            this.delete_user = new System.Windows.Forms.Button();
            this.find_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.usersDataSet = new LoginApp.UsersDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new LoginApp.UsersDataSetTableAdapters.loginTableAdapter();
            this.tableAdapterManager = new LoginApp.UsersDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.users_grid = new System.Windows.Forms.DataGridView();
            this.show_all = new System.Windows.Forms.Button();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veteran_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // add_user_btn
            // 
            this.add_user_btn.Location = new System.Drawing.Point(223, 204);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(75, 23);
            this.add_user_btn.TabIndex = 7;
            this.add_user_btn.Text = "add user";
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_clicked);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(212, 98);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 22);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(212, 151);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(474, 50);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 22);
            this.age.TabIndex = 4;
            // 
            // veteran
            // 
            this.veteran.Location = new System.Drawing.Point(778, 53);
            this.veteran.Name = "veteran";
            this.veteran.Size = new System.Drawing.Size(100, 22);
            this.veteran.TabIndex = 5;
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(778, 98);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(100, 22);
            this.admin.TabIndex = 6;
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(778, 204);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(75, 23);
            this.delete_user.TabIndex = 9;
            this.delete_user.Text = "delete user";
            this.delete_user.UseVisualStyleBackColor = true;
            this.delete_user.Click += new System.EventHandler(this.delete_user_Click);
            // 
            // find_user
            // 
            this.find_user.Location = new System.Drawing.Point(626, 204);
            this.find_user.Name = "find_user";
            this.find_user.Size = new System.Drawing.Size(75, 23);
            this.find_user.TabIndex = 8;
            this.find_user.Text = "find user";
            this.find_user.UseVisualStyleBackColor = true;
            this.find_user.Click += new System.EventHandler(this.find_user_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "veteran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "admin";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(212, 47);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "id";
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.usersDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.loginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoginApp.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "update users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.update_user_btn_clicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "teacher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "email";
            // 
            // teacher
            // 
            this.teacher.Location = new System.Drawing.Point(778, 148);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(100, 22);
            this.teacher.TabIndex = 19;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(474, 145);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 22);
            this.email.TabIndex = 20;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(474, 95);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 22);
            this.phone.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Back);
            // 
            // users_grid
            // 
            this.users_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.username_col,
            this.age_col,
            this.veteran_col,
            this.admin_col,
            this.teacher_col,
            this.email_col,
            this.phone_col});
            this.users_grid.Location = new System.Drawing.Point(12, 274);
            this.users_grid.Name = "users_grid";
            this.users_grid.RowHeadersWidth = 51;
            this.users_grid.RowTemplate.Height = 24;
            this.users_grid.Size = new System.Drawing.Size(920, 150);
            this.users_grid.TabIndex = 24;
            // 
            // show_all
            // 
            this.show_all.Location = new System.Drawing.Point(12, 236);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(75, 23);
            this.show_all.TabIndex = 25;
            this.show_all.Text = "show all";
            this.show_all.UseVisualStyleBackColor = true;
            this.show_all.Click += new System.EventHandler(this.show_all_users);
            // 
            // id_col
            // 
            this.id_col.HeaderText = "id";
            this.id_col.MinimumWidth = 6;
            this.id_col.Name = "id_col";
            this.id_col.Width = 125;
            // 
            // username_col
            // 
            this.username_col.HeaderText = "username";
            this.username_col.MinimumWidth = 6;
            this.username_col.Name = "username_col";
            this.username_col.Width = 125;
            // 
            // age_col
            // 
            this.age_col.HeaderText = "age";
            this.age_col.MinimumWidth = 6;
            this.age_col.Name = "age_col";
            this.age_col.Width = 125;
            // 
            // veteran_col
            // 
            this.veteran_col.HeaderText = "veteran";
            this.veteran_col.MinimumWidth = 6;
            this.veteran_col.Name = "veteran_col";
            this.veteran_col.Width = 125;
            // 
            // admin_col
            // 
            this.admin_col.HeaderText = "admin";
            this.admin_col.MinimumWidth = 6;
            this.admin_col.Name = "admin_col";
            this.admin_col.Width = 125;
            // 
            // teacher_col
            // 
            this.teacher_col.HeaderText = "teacher";
            this.teacher_col.MinimumWidth = 6;
            this.teacher_col.Name = "teacher_col";
            this.teacher_col.Width = 125;
            // 
            // email_col
            // 
            this.email_col.HeaderText = "email";
            this.email_col.MinimumWidth = 6;
            this.email_col.Name = "email_col";
            this.email_col.Width = 125;
            // 
            // phone_col
            // 
            this.phone_col.HeaderText = "phone";
            this.phone_col.MinimumWidth = 6;
            this.phone_col.Name = "phone_col";
            this.phone_col.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(701, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Enter 0 for a no and 1 for a yes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(726, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "for the labels below here";
            // 
            // frmUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.users_grid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.find_user);
            this.Controls.Add(this.delete_user);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.veteran);
            this.Controls.Add(this.age);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.add_user_btn);
            this.Name = "frmUserAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmUserAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private TextBox age;
        private TextBox veteran;
        private TextBox admin;
        private Button delete_user;
        private Button find_user;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox id;
        private Label label6;
        private UsersDataSet usersDataSet;
        private BindingSource loginBindingSource;
        private UsersDataSetTableAdapters.loginTableAdapter loginTableAdapter;
        private UsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox teacher;
        private TextBox email;
        private TextBox phone;
        private Label label10;
        private Button button2;
        private DataGridView users_grid;
        private Button show_all;
        private DataGridViewTextBoxColumn id_col;
        private DataGridViewTextBoxColumn username_col;
        private DataGridViewTextBoxColumn age_col;
        private DataGridViewTextBoxColumn veteran_col;
        private DataGridViewTextBoxColumn admin_col;
        private DataGridViewTextBoxColumn teacher_col;
        private DataGridViewTextBoxColumn email_col;
        private DataGridViewTextBoxColumn phone_col;
        private Label label11;
        private Label label12;
    }
}