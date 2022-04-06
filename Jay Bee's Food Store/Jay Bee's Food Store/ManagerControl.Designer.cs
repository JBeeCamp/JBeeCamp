namespace Jay_Bee_s_Food_Store
{
    partial class ManagerControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewOrders = new System.Windows.Forms.Button();
            this.dataGridCustomerView = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.validateManagerControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonAddCustomer = new System.Windows.Forms.Button();
            this.project0DataSet = new Jay_Bee_s_Food_Store.Project0DataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Jay_Bee_s_Food_Store.Project0DataSetTableAdapters.CustomerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validateManagerControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(16)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Control";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.viewOrders);
            this.panel2.Controls.Add(this.dataGridCustomerView);
            this.panel2.Controls.Add(this.textBoxSearchCustomer);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ButtonAddCustomer);
            this.panel2.Location = new System.Drawing.Point(39, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 411);
            this.panel2.TabIndex = 0;
            // 
            // viewOrders
            // 
            this.viewOrders.BackColor = System.Drawing.Color.SeaGreen;
            this.viewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewOrders.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrders.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewOrders.Location = new System.Drawing.Point(255, 31);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(97, 52);
            this.viewOrders.TabIndex = 4;
            this.viewOrders.Text = "View Orders";
            this.viewOrders.UseVisualStyleBackColor = false;
            this.viewOrders.Click += new System.EventHandler(this.viewOrders_Click);
            // 
            // dataGridCustomerView
            // 
            this.dataGridCustomerView.AllowUserToAddRows = false;
            this.dataGridCustomerView.AllowUserToDeleteRows = false;
            this.dataGridCustomerView.AllowUserToResizeColumns = false;
            this.dataGridCustomerView.AllowUserToResizeRows = false;
            this.dataGridCustomerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCustomerView.AutoGenerateColumns = false;
            this.dataGridCustomerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomerView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCustomerView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCustomerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Pword,
            this.Delete});
            this.dataGridCustomerView.DataSource = this.validateManagerControlBindingSource;
            this.dataGridCustomerView.Location = new System.Drawing.Point(48, 117);
            this.dataGridCustomerView.MultiSelect = false;
            this.dataGridCustomerView.Name = "dataGridCustomerView";
            this.dataGridCustomerView.ReadOnly = true;
            this.dataGridCustomerView.RowHeadersVisible = false;
            this.dataGridCustomerView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCustomerView.ShowEditingIcon = false;
            this.dataGridCustomerView.Size = new System.Drawing.Size(545, 252);
            this.dataGridCustomerView.TabIndex = 0;
            this.dataGridCustomerView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomerView_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.FillWeight = 131.42F;
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.FillWeight = 123.3658F;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.FillWeight = 126.3826F;
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 87.31193F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Pword
            // 
            this.Pword.DataPropertyName = "Pword";
            this.Pword.HeaderText = "Pword";
            this.Pword.Name = "Pword";
            this.Pword.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(51)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(51)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.FillWeight = 31.51972F;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 34;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // textBoxSearchCustomer
            // 
            this.textBoxSearchCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCustomer.Location = new System.Drawing.Point(87, 89);
            this.textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            this.textBoxSearchCustomer.Size = new System.Drawing.Size(140, 22);
            this.textBoxSearchCustomer.TabIndex = 2;
            this.textBoxSearchCustomer.TextChanged += new System.EventHandler(this.textBoxSearchCustomer_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonAddCustomer
            // 
            this.ButtonAddCustomer.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonAddCustomer.FlatAppearance.BorderSize = 0;
            this.ButtonAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddCustomer.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCustomer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonAddCustomer.Location = new System.Drawing.Point(48, 31);
            this.ButtonAddCustomer.Name = "ButtonAddCustomer";
            this.ButtonAddCustomer.Size = new System.Drawing.Size(100, 52);
            this.ButtonAddCustomer.TabIndex = 1;
            this.ButtonAddCustomer.Text = "Add Customer";
            this.ButtonAddCustomer.UseVisualStyleBackColor = false;
            this.ButtonAddCustomer.Click += new System.EventHandler(this.ButtonAddCustomer_Click);
            // 
            // project0DataSet
            // 
            this.project0DataSet.DataSetName = "Project0DataSet";
            this.project0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.project0DataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "This is where Purchase Button  should be.";
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(708, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagerControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerControl_FormClosed);
            this.Load += new System.EventHandler(this.ManagerControl_Load);
            this.Shown += new System.EventHandler(this.ManagerControl_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validateManagerControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource validateManagerControlBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonAddCustomer;
        private System.Windows.Forms.DataGridView dataGridCustomerView;
        private System.Windows.Forms.TextBox textBoxSearchCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Project0DataSet project0DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Project0DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pword;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button viewOrders;
        private System.Windows.Forms.Label label2;
    }
}