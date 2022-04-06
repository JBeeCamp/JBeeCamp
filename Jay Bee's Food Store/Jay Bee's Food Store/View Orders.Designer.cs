namespace Jay_Bee_s_Food_Store
{
    partial class ViewOrders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchByLocation = new System.Windows.Forms.Label();
            this.searchByCustomer = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridOrderView = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(16)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.AddCus);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 92);
            this.panel1.TabIndex = 1;
            // 
            // AddCus
            // 
            this.AddCus.AutoSize = true;
            this.AddCus.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCus.Location = new System.Drawing.Point(11, 34);
            this.AddCus.Name = "AddCus";
            this.AddCus.Size = new System.Drawing.Size(112, 19);
            this.AddCus.TabIndex = 0;
            this.AddCus.Text = "View Orders";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridOrderView);
            this.panel2.Controls.Add(this.searchByLocation);
            this.panel2.Controls.Add(this.searchByCustomer);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(30, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 281);
            this.panel2.TabIndex = 2;
            // 
            // searchByLocation
            // 
            this.searchByLocation.AutoSize = true;
            this.searchByLocation.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLocation.Location = new System.Drawing.Point(434, 34);
            this.searchByLocation.Name = "searchByLocation";
            this.searchByLocation.Size = new System.Drawing.Size(153, 15);
            this.searchByLocation.TabIndex = 7;
            this.searchByLocation.Text = "Search By LocationID:";
            // 
            // searchByCustomer
            // 
            this.searchByCustomer.AutoSize = true;
            this.searchByCustomer.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByCustomer.Location = new System.Drawing.Point(71, 34);
            this.searchByCustomer.Name = "searchByCustomer";
            this.searchByCustomer.Size = new System.Drawing.Size(159, 15);
            this.searchByCustomer.TabIndex = 6;
            this.searchByCustomer.Text = "Search By CustomerID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(590, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(246, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridOrderView
            // 
            this.dataGridOrderView.AllowUserToAddRows = false;
            this.dataGridOrderView.AllowUserToDeleteRows = false;
            this.dataGridOrderView.AllowUserToResizeColumns = false;
            this.dataGridOrderView.AllowUserToResizeRows = false;
            this.dataGridOrderView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrderView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOrderView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderDate,
            this.Quantity,
            this.CustomerID,
            this.LocationID,
            this.ProductID});
            this.dataGridOrderView.Location = new System.Drawing.Point(74, 59);
            this.dataGridOrderView.MultiSelect = false;
            this.dataGridOrderView.Name = "dataGridOrderView";
            this.dataGridOrderView.ReadOnly = true;
            this.dataGridOrderView.RowHeadersVisible = false;
            this.dataGridOrderView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridOrderView.ShowEditingIcon = false;
            this.dataGridOrderView.Size = new System.Drawing.Size(616, 202);
            this.dataGridOrderView.TabIndex = 8;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LocationID
            // 
            this.LocationID.DataPropertyName = "LocationID";
            this.LocationID.HeaderText = "LocationID";
            this.LocationID.Name = "LocationID";
            this.LocationID.ReadOnly = true;
            this.LocationID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Orders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddCus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label searchByCustomer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label searchByLocation;
        private System.Windows.Forms.DataGridView dataGridOrderView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
    }
}