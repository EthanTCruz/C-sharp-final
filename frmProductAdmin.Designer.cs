namespace LoginApp
{
    partial class frmProductAdmin
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
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.find_product_btn = new System.Windows.Forms.Button();
            this.delete_product_btn = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.add_product_btn = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "id";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(351, 32);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "name";
            // 
            // find_product_btn
            // 
            this.find_product_btn.Location = new System.Drawing.Point(376, 396);
            this.find_product_btn.Name = "find_product_btn";
            this.find_product_btn.Size = new System.Drawing.Size(75, 23);
            this.find_product_btn.TabIndex = 6;
            this.find_product_btn.Text = "find product";
            this.find_product_btn.UseVisualStyleBackColor = true;
            this.find_product_btn.Click += new System.EventHandler(this.find_product_Click);
            // 
            // delete_product_btn
            // 
            this.delete_product_btn.Location = new System.Drawing.Point(494, 396);
            this.delete_product_btn.Name = "delete_product_btn";
            this.delete_product_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_product_btn.TabIndex = 7;
            this.delete_product_btn.Text = "delete product";
            this.delete_product_btn.UseVisualStyleBackColor = true;
            this.delete_product_btn.Click += new System.EventHandler(this.Delete_Product_Click);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(351, 226);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(100, 22);
            this.cost.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(351, 79);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 2;
            // 
            // add_product_btn
            // 
            this.add_product_btn.Location = new System.Drawing.Point(231, 396);
            this.add_product_btn.Name = "add_product_btn";
            this.add_product_btn.Size = new System.Drawing.Size(75, 23);
            this.add_product_btn.TabIndex = 5;
            this.add_product_btn.Text = "add product";
            this.add_product_btn.UseVisualStyleBackColor = true;
            this.add_product_btn.Click += new System.EventHandler(this.add_product_btn_clicked);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Grocery",
            "Music Instruments",
            "Books",
            "Clothing"});
            this.category.Location = new System.Drawing.Point(351, 163);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 24);
            this.category.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 26);
            this.button1.TabIndex = 30;
            this.button1.Text = "Update Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.update_product_btn_clicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Back);
            // 
            // frmProductAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.find_product_btn);
            this.Controls.Add(this.delete_product_btn);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.name);
            this.Controls.Add(this.add_product_btn);
            this.Name = "frmProductAdmin";
            this.Text = "Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find_product_btn;
        private System.Windows.Forms.Button delete_product_btn;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button add_product_btn;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}