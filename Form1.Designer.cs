namespace InformationSystem
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftJoin = new System.Windows.Forms.Button();
            this.innerJoin = new System.Windows.Forms.Button();
            this.infoAboutClient = new System.Windows.Forms.Button();
            this.updateClient = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.city = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Логін = new System.Windows.Forms.Label();
            this.deleteClient = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgwResults = new System.Windows.Forms.DataGridView();
            this.rightJoin = new System.Windows.Forms.Button();
            this.threeCon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResults)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.threeCon);
            this.splitContainer1.Panel1.Controls.Add(this.rightJoin);
            this.splitContainer1.Panel1.Controls.Add(this.leftJoin);
            this.splitContainer1.Panel1.Controls.Add(this.innerJoin);
            this.splitContainer1.Panel1.Controls.Add(this.infoAboutClient);
            this.splitContainer1.Panel1.Controls.Add(this.updateClient);
            this.splitContainer1.Panel1.Controls.Add(this.addClient);
            this.splitContainer1.Panel1.Controls.Add(this.city);
            this.splitContainer1.Panel1.Controls.Add(this.email);
            this.splitContainer1.Panel1.Controls.Add(this.phoneNumber);
            this.splitContainer1.Panel1.Controls.Add(this.lastName);
            this.splitContainer1.Panel1.Controls.Add(this.firstName);
            this.splitContainer1.Panel1.Controls.Add(this.password);
            this.splitContainer1.Panel1.Controls.Add(this.login);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Логін);
            this.splitContainer1.Panel1.Controls.Add(this.deleteClient);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwResults);
            this.splitContainer1.Size = new System.Drawing.Size(681, 415);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 0;
            // 
            // leftJoin
            // 
            this.leftJoin.Location = new System.Drawing.Point(138, 339);
            this.leftJoin.Name = "leftJoin";
            this.leftJoin.Size = new System.Drawing.Size(75, 23);
            this.leftJoin.TabIndex = 20;
            this.leftJoin.Text = "leftJoin";
            this.leftJoin.UseVisualStyleBackColor = true;
            this.leftJoin.Click += new System.EventHandler(this.leftJoin_Click);
            // 
            // innerJoin
            // 
            this.innerJoin.Location = new System.Drawing.Point(12, 340);
            this.innerJoin.Name = "innerJoin";
            this.innerJoin.Size = new System.Drawing.Size(79, 23);
            this.innerJoin.TabIndex = 19;
            this.innerJoin.Text = "innerJoin";
            this.innerJoin.UseVisualStyleBackColor = true;
            this.innerJoin.Click += new System.EventHandler(this.innerJoin_Click);
            // 
            // infoAboutClient
            // 
            this.infoAboutClient.Location = new System.Drawing.Point(16, 30);
            this.infoAboutClient.Name = "infoAboutClient";
            this.infoAboutClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infoAboutClient.Size = new System.Drawing.Size(75, 23);
            this.infoAboutClient.TabIndex = 18;
            this.infoAboutClient.Text = "Info";
            this.infoAboutClient.UseVisualStyleBackColor = true;
            this.infoAboutClient.Click += new System.EventHandler(this.infoAboutClient_Click);
            // 
            // updateClient
            // 
            this.updateClient.Location = new System.Drawing.Point(13, 302);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(75, 23);
            this.updateClient.TabIndex = 17;
            this.updateClient.Text = "Update ";
            this.updateClient.UseVisualStyleBackColor = true;
            this.updateClient.Click += new System.EventHandler(this.updateClient_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(138, 302);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(75, 23);
            this.addClient.TabIndex = 16;
            this.addClient.Text = "Add client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(113, 251);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 15;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(113, 224);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 14;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(113, 189);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(100, 20);
            this.phoneNumber.TabIndex = 13;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(113, 157);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 12;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(113, 131);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 11;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(113, 98);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 10;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(113, 72);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Логін
            // 
            this.Логін.AutoSize = true;
            this.Логін.Location = new System.Drawing.Point(13, 72);
            this.Логін.Name = "Логін";
            this.Логін.Size = new System.Drawing.Size(33, 13);
            this.Логін.TabIndex = 2;
            this.Логін.Text = "Login";
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(149, 31);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(75, 23);
            this.deleteClient.TabIndex = 1;
            this.deleteClient.Text = "Delete";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgwResults
            // 
            this.dgwResults.AllowUserToAddRows = false;
            this.dgwResults.AllowUserToDeleteRows = false;
            this.dgwResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwResults.Location = new System.Drawing.Point(0, 0);
            this.dgwResults.Name = "dgwResults";
            this.dgwResults.ReadOnly = true;
            this.dgwResults.Size = new System.Drawing.Size(450, 415);
            this.dgwResults.TabIndex = 0;
            this.dgwResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rightJoin
            // 
            this.rightJoin.Location = new System.Drawing.Point(138, 369);
            this.rightJoin.Name = "rightJoin";
            this.rightJoin.Size = new System.Drawing.Size(75, 23);
            this.rightJoin.TabIndex = 21;
            this.rightJoin.Text = "rightJoin";
            this.rightJoin.UseVisualStyleBackColor = true;
            this.rightJoin.Click += new System.EventHandler(this.rightJoin_Click);
            // 
            // threeCon
            // 
            this.threeCon.Location = new System.Drawing.Point(12, 369);
            this.threeCon.Name = "threeCon";
            this.threeCon.Size = new System.Drawing.Size(75, 23);
            this.threeCon.TabIndex = 22;
            this.threeCon.Text = "threeCon";
            this.threeCon.UseVisualStyleBackColor = true;
            this.threeCon.Click += new System.EventHandler(this.threeCon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 415);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgwResults;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Label Логін;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button infoAboutClient;
        private System.Windows.Forms.Button updateClient;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button innerJoin;
        private System.Windows.Forms.Button leftJoin;
        private System.Windows.Forms.Button rightJoin;
        private System.Windows.Forms.Button threeCon;
    }
}

