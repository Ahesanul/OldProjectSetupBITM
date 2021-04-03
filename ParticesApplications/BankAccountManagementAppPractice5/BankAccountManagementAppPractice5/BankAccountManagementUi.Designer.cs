namespace BankAccountManagementAppPractice5
{
    partial class BankAccountManagementUi
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reportCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AccountSaveButton = new System.Windows.Forms.Button();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.accountNumTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CustomerSaveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transactionCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.reportCustomerComboBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.ShowButton);
            this.groupBox4.Location = new System.Drawing.Point(356, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 140);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report";
            // 
            // reportCustomerComboBox
            // 
            this.reportCustomerComboBox.FormattingEnabled = true;
            this.reportCustomerComboBox.Location = new System.Drawing.Point(95, 18);
            this.reportCustomerComboBox.Name = "reportCustomerComboBox";
            this.reportCustomerComboBox.Size = new System.Drawing.Size(200, 21);
            this.reportCustomerComboBox.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Customer";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(158, 45);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(137, 23);
            this.ShowButton.TabIndex = 10;
            this.ShowButton.Text = "Show Account Info";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AccountSaveButton);
            this.groupBox2.Controls.Add(this.customerComboBox);
            this.groupBox2.Controls.Add(this.typeComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.accountNumTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 129);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Information";
            // 
            // AccountSaveButton
            // 
            this.AccountSaveButton.Location = new System.Drawing.Point(252, 100);
            this.AccountSaveButton.Name = "AccountSaveButton";
            this.AccountSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AccountSaveButton.TabIndex = 7;
            this.AccountSaveButton.Text = "Save";
            this.AccountSaveButton.UseVisualStyleBackColor = true;
            this.AccountSaveButton.Click += new System.EventHandler(this.AccountSaveButton_Click);
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(112, 73);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(215, 21);
            this.customerComboBox.TabIndex = 9;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Saving",
            "Debit",
            "Credit",
            "Checking"});
            this.typeComboBox.Location = new System.Drawing.Point(112, 46);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(216, 21);
            this.typeComboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Account Number";
            // 
            // accountNumTextBox
            // 
            this.accountNumTextBox.Location = new System.Drawing.Point(113, 20);
            this.accountNumTextBox.Name = "accountNumTextBox";
            this.accountNumTextBox.Size = new System.Drawing.Size(215, 20);
            this.accountNumTextBox.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CustomerSaveButton);
            this.groupBox3.Controls.Add(this.nameTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.addressTextBox);
            this.groupBox3.Controls.Add(this.phoneTextBox);
            this.groupBox3.Controls.Add(this.idTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 205);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Information";
            // 
            // CustomerSaveButton
            // 
            this.CustomerSaveButton.Location = new System.Drawing.Point(253, 174);
            this.CustomerSaveButton.Name = "CustomerSaveButton";
            this.CustomerSaveButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerSaveButton.TabIndex = 7;
            this.CustomerSaveButton.Text = "Save";
            this.CustomerSaveButton.UseVisualStyleBackColor = true;
            this.CustomerSaveButton.Click += new System.EventHandler(this.CustomerSaveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(113, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(215, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "National Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Present Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Phone/Mob";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(113, 103);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(215, 63);
            this.addressTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(113, 77);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(215, 20);
            this.phoneTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(113, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(215, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transactionCustomerComboBox);
            this.groupBox1.Controls.Add(this.accountComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DepositButton);
            this.groupBox1.Controls.Add(this.WithdrawButton);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(356, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 140);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction In Account";
            // 
            // transactionCustomerComboBox
            // 
            this.transactionCustomerComboBox.FormattingEnabled = true;
            this.transactionCustomerComboBox.Location = new System.Drawing.Point(95, 18);
            this.transactionCustomerComboBox.Name = "transactionCustomerComboBox";
            this.transactionCustomerComboBox.Size = new System.Drawing.Size(200, 21);
            this.transactionCustomerComboBox.TabIndex = 13;
            this.transactionCustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.transactionCustomerComboBox_SelectedIndexChanged);
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(95, 47);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(201, 21);
            this.accountComboBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Account";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Customer";
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(105, 101);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(75, 23);
            this.DepositButton.TabIndex = 7;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(209, 101);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(75, 23);
            this.WithdrawButton.TabIndex = 7;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(95, 75);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(168, 20);
            this.amountTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // BankAccountManagementUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 363);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankAccountManagementUi";
            this.Text = "Bank Account Management";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox reportCustomerComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AccountSaveButton;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox accountNumTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CustomerSaveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox transactionCustomerComboBox;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label1;
    }
}

