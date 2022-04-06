namespace Jay_Bee_s_Food_Store
{
    partial class AddCustomer
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label pwordLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pwordTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.validateAddCustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.validateAddCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.validateAddCustomerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            pwordLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validateAddCustomerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validateAddCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validateAddCustomerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(62, 146);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(37, 38);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(36, 95);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // pwordLabel
            // 
            pwordLabel.AutoSize = true;
            pwordLabel.Location = new System.Drawing.Point(41, 195);
            pwordLabel.Name = "pwordLabel";
            pwordLabel.Size = new System.Drawing.Size(56, 13);
            pwordLabel.TabIndex = 7;
            pwordLabel.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(16)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.AddCus);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 92);
            this.panel1.TabIndex = 0;
            // 
            // AddCus
            // 
            this.AddCus.AutoSize = true;
            this.AddCus.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCus.Location = new System.Drawing.Point(11, 34);
            this.AddCus.Name = "AddCus";
            this.AddCus.Size = new System.Drawing.Size(126, 19);
            this.AddCus.TabIndex = 0;
            this.AddCus.Text = "Add Customer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(pwordLabel);
            this.panel2.Controls.Add(this.pwordTextBox);
            this.panel2.Controls.Add(lastNameLabel);
            this.panel2.Controls.Add(this.lastNameTextBox);
            this.panel2.Controls.Add(firstNameLabel);
            this.panel2.Controls.Add(this.firstNameTextBox);
            this.panel2.Controls.Add(emailLabel);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.ButtonSubmit);
            this.panel2.Location = new System.Drawing.Point(16, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 301);
            this.panel2.TabIndex = 1;
            // 
            // pwordTextBox
            // 
            this.pwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.validateAddCustomerBindingSource2, "Pword", true));
            this.pwordTextBox.Location = new System.Drawing.Point(103, 192);
            this.pwordTextBox.Name = "pwordTextBox";
            this.pwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.pwordTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.validateAddCustomerBindingSource2, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(103, 92);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.validateAddCustomerBindingSource2, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(103, 35);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.validateAddCustomerBindingSource2, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(103, 139);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonSubmit.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmit.Location = new System.Drawing.Point(103, 245);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 36);
            this.ButtonSubmit.TabIndex = 4;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = false;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // validateAddCustomerBindingSource2
            // 
            this.validateAddCustomerBindingSource2.DataSource = typeof(Jay_Bee_s_Food_Store.ValidateAddCustomer);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomer_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validateAddCustomerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validateAddCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validateAddCustomerBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddCus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource validateAddCustomerBindingSource;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.BindingSource validateAddCustomerBindingSource1;
        private System.Windows.Forms.TextBox pwordTextBox;
        private System.Windows.Forms.BindingSource validateAddCustomerBindingSource2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}