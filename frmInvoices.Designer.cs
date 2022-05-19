namespace LoginApp
{
    partial class frmInvoices
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
            this.invoices_found = new System.Windows.Forms.DataGridView();
            this.invoice_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show_all = new System.Windows.Forms.Button();
            this.invoice_id_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user_id_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_id_search = new System.Windows.Forms.TextBox();
            this.product_id_search = new System.Windows.Forms.TextBox();
            this.search_invoices = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amount_search = new System.Windows.Forms.TextBox();
            this.payment_type_search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoices_found)).BeginInit();
            this.SuspendLayout();
            // 
            // invoices_found
            // 
            this.invoices_found.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoices_found.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoice_id,
            this.user_id,
            this.product_ids,
            this.amount,
            this.payment_type});
            this.invoices_found.Location = new System.Drawing.Point(41, 246);
            this.invoices_found.Name = "invoices_found";
            this.invoices_found.RowHeadersWidth = 51;
            this.invoices_found.RowTemplate.Height = 24;
            this.invoices_found.Size = new System.Drawing.Size(706, 174);
            this.invoices_found.TabIndex = 0;
            this.invoices_found.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invoice_id
            // 
            this.invoice_id.HeaderText = "invoice id";
            this.invoice_id.MinimumWidth = 6;
            this.invoice_id.Name = "invoice_id";
            this.invoice_id.Width = 125;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "user id";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.Width = 125;
            // 
            // product_ids
            // 
            this.product_ids.HeaderText = "product id\'s";
            this.product_ids.MinimumWidth = 6;
            this.product_ids.Name = "product_ids";
            this.product_ids.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // payment_type
            // 
            this.payment_type.HeaderText = "payment type";
            this.payment_type.MinimumWidth = 6;
            this.payment_type.Name = "payment_type";
            this.payment_type.Width = 125;
            // 
            // show_all
            // 
            this.show_all.Location = new System.Drawing.Point(137, 176);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(99, 33);
            this.show_all.TabIndex = 1;
            this.show_all.Text = "show all";
            this.show_all.UseVisualStyleBackColor = true;
            this.show_all.Click += new System.EventHandler(this.Show_All_Invoices);
            // 
            // invoice_id_search
            // 
            this.invoice_id_search.Location = new System.Drawing.Point(119, 55);
            this.invoice_id_search.Name = "invoice_id_search";
            this.invoice_id_search.Size = new System.Drawing.Size(100, 22);
            this.invoice_id_search.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "invoice id";
            // 
            // user_id_label
            // 
            this.user_id_label.AutoSize = true;
            this.user_id_label.Location = new System.Drawing.Point(479, 117);
            this.user_id_label.Name = "user_id_label";
            this.user_id_label.Size = new System.Drawing.Size(47, 16);
            this.user_id_label.TabIndex = 4;
            this.user_id_label.Text = "user id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "product id";
            // 
            // user_id_search
            // 
            this.user_id_search.Location = new System.Drawing.Point(585, 111);
            this.user_id_search.Name = "user_id_search";
            this.user_id_search.Size = new System.Drawing.Size(100, 22);
            this.user_id_search.TabIndex = 6;
            // 
            // product_id_search
            // 
            this.product_id_search.Location = new System.Drawing.Point(647, 55);
            this.product_id_search.Name = "product_id_search";
            this.product_id_search.Size = new System.Drawing.Size(100, 22);
            this.product_id_search.TabIndex = 7;
            // 
            // search_invoices
            // 
            this.search_invoices.Location = new System.Drawing.Point(482, 176);
            this.search_invoices.Name = "search_invoices";
            this.search_invoices.Size = new System.Drawing.Size(117, 33);
            this.search_invoices.TabIndex = 8;
            this.search_invoices.Text = "search invoices";
            this.search_invoices.UseVisualStyleBackColor = true;
            this.search_invoices.Click += new System.EventHandler(this.Search_Invoices_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "payment type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // amount_search
            // 
            this.amount_search.Location = new System.Drawing.Point(248, 108);
            this.amount_search.Name = "amount_search";
            this.amount_search.Size = new System.Drawing.Size(100, 22);
            this.amount_search.TabIndex = 11;
            // 
            // payment_type_search
            // 
            this.payment_type_search.Location = new System.Drawing.Point(354, 61);
            this.payment_type_search.Name = "payment_type_search";
            this.payment_type_search.Size = new System.Drawing.Size(100, 22);
            this.payment_type_search.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.back_to_options);
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.payment_type_search);
            this.Controls.Add(this.amount_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_invoices);
            this.Controls.Add(this.product_id_search);
            this.Controls.Add(this.user_id_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_id_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoice_id_search);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.invoices_found);
            this.Name = "frmInvoices";
            this.Text = "Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.invoices_found)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoices_found;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.TextBox invoice_id_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user_id_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_id_search;
        private System.Windows.Forms.TextBox product_id_search;
        private System.Windows.Forms.Button search_invoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amount_search;
        private System.Windows.Forms.TextBox payment_type_search;
        private System.Windows.Forms.Button button1;
    }
}