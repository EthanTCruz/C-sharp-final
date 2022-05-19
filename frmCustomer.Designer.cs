namespace LoginApp
{
    partial class frmCustomer
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
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.shopping_cart = new System.Windows.Forms.DataGridView();
            this.cart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase = new System.Windows.Forms.Button();
            this.clear_cart = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shopping_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "find product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.query_products);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(136, 52);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(136, 114);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 3;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(136, 209);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(100, 22);
            this.cost.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "cost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "add to cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_to_cart);
            // 
            // shopping_cart
            // 
            this.shopping_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopping_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cart_id,
            this.cart_name,
            this.cart_category,
            this.cart_cost});
            this.shopping_cart.Location = new System.Drawing.Point(408, 66);
            this.shopping_cart.Name = "shopping_cart";
            this.shopping_cart.RowHeadersWidth = 51;
            this.shopping_cart.RowTemplate.Height = 24;
            this.shopping_cart.Size = new System.Drawing.Size(550, 150);
            this.shopping_cart.TabIndex = 10;
            this.shopping_cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cart_id
            // 
            this.cart_id.HeaderText = "id";
            this.cart_id.MinimumWidth = 6;
            this.cart_id.Name = "cart_id";
            this.cart_id.Width = 125;
            // 
            // cart_name
            // 
            this.cart_name.HeaderText = "name";
            this.cart_name.MinimumWidth = 6;
            this.cart_name.Name = "cart_name";
            this.cart_name.Width = 125;
            // 
            // cart_category
            // 
            this.cart_category.HeaderText = "category";
            this.cart_category.MinimumWidth = 6;
            this.cart_category.Name = "cart_category";
            this.cart_category.Width = 125;
            // 
            // cart_cost
            // 
            this.cart_cost.HeaderText = "cost";
            this.cart_cost.MinimumWidth = 6;
            this.cart_cost.Name = "cart_cost";
            this.cart_cost.Width = 125;
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(455, 275);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(151, 24);
            this.purchase.TabIndex = 11;
            this.purchase.Text = "purchase items";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.purchase_btn_clicked);
            // 
            // clear_cart
            // 
            this.clear_cart.Location = new System.Drawing.Point(750, 275);
            this.clear_cart.Name = "clear_cart";
            this.clear_cart.Size = new System.Drawing.Size(75, 23);
            this.clear_cart.TabIndex = 12;
            this.clear_cart.Text = "clear cart";
            this.clear_cart.UseVisualStyleBackColor = true;
            this.clear_cart.Click += new System.EventHandler(this.clear_cart_btn);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Grocery",
            "Music Instruments",
            "Books",
            "Clothing"});
            this.category.Location = new System.Drawing.Point(136, 160);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 24);
            this.category.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(919, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "invoices";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.show_invoices);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.logout);
            // 
            // frmCustomer
            // 
            this.ClientSize = new System.Drawing.Size(1008, 454);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.category);
            this.Controls.Add(this.clear_cart);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.shopping_cart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button2);
            this.Name = "frmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.shopping_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView shopping_cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_cost;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Button clear_cart;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}