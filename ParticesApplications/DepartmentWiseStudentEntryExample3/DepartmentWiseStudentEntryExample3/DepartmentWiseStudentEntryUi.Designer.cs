namespace DepartmentWiseStudentEntryExample3
{
    partial class DepartmentWiseStudentEntryUi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dipartment2ComboBox = new System.Windows.Forms.ComboBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deprartmentComboBox = new System.Windows.Forms.ComboBox();
            this.StudentSaveButton = new System.Windows.Forms.Button();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DepartmentSaveButton = new System.Windows.Forms.Button();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dipartment2ComboBox);
            this.groupBox2.Controls.Add(this.ShowButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(17, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 63);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student List";
            // 
            // dipartment2ComboBox
            // 
            this.dipartment2ComboBox.FormattingEnabled = true;
            this.dipartment2ComboBox.Location = new System.Drawing.Point(112, 21);
            this.dipartment2ComboBox.Name = "dipartment2ComboBox";
            this.dipartment2ComboBox.Size = new System.Drawing.Size(262, 21);
            this.dipartment2ComboBox.TabIndex = 11;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(407, 21);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(105, 23);
            this.ShowButton.TabIndex = 10;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deprartmentComboBox);
            this.groupBox3.Controls.Add(this.StudentSaveButton);
            this.groupBox3.Controls.Add(this.studentNameTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.emailTextBox);
            this.groupBox3.Controls.Add(this.regNoTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 137);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            // 
            // deprartmentComboBox
            // 
            this.deprartmentComboBox.DisplayMember = "DepartmentName";
            this.deprartmentComboBox.FormattingEnabled = true;
            this.deprartmentComboBox.Location = new System.Drawing.Point(113, 103);
            this.deprartmentComboBox.Name = "deprartmentComboBox";
            this.deprartmentComboBox.Size = new System.Drawing.Size(262, 21);
            this.deprartmentComboBox.TabIndex = 9;
            this.deprartmentComboBox.ValueMember = "DepartmentName";
            this.deprartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.deprartmentComboBox_SelectedIndexChanged);
            this.deprartmentComboBox.Click += new System.EventHandler(this.deprartmentComboBox_Click);
            // 
            // StudentSaveButton
            // 
            this.StudentSaveButton.Location = new System.Drawing.Point(442, 103);
            this.StudentSaveButton.Name = "StudentSaveButton";
            this.StudentSaveButton.Size = new System.Drawing.Size(75, 23);
            this.StudentSaveButton.TabIndex = 7;
            this.StudentSaveButton.Text = "Save";
            this.StudentSaveButton.UseVisualStyleBackColor = true;
            this.StudentSaveButton.Click += new System.EventHandler(this.StudentSaveButton_Click);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(113, 49);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(401, 20);
            this.studentNameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Reg No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Department";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(113, 77);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(401, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(113, 21);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(168, 20);
            this.regNoTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DepartmentSaveButton);
            this.groupBox1.Controls.Add(this.departmentNameTextBox);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 101);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Info";
            // 
            // DepartmentSaveButton
            // 
            this.DepartmentSaveButton.Location = new System.Drawing.Point(442, 71);
            this.DepartmentSaveButton.Name = "DepartmentSaveButton";
            this.DepartmentSaveButton.Size = new System.Drawing.Size(75, 23);
            this.DepartmentSaveButton.TabIndex = 7;
            this.DepartmentSaveButton.Text = "Save";
            this.DepartmentSaveButton.UseVisualStyleBackColor = true;
            this.DepartmentSaveButton.Click += new System.EventHandler(this.DepartmentSaveButton_Click);
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(116, 45);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(401, 20);
            this.departmentNameTextBox.TabIndex = 6;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(116, 23);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(168, 20);
            this.codeTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // DepartmentWiseStudentEntryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepartmentWiseStudentEntryUi";
            this.Text = "Department Wise Student Entry";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox dipartment2ComboBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox deprartmentComboBox;
        private System.Windows.Forms.Button StudentSaveButton;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DepartmentSaveButton;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

