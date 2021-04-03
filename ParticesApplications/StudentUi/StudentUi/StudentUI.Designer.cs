namespace StudentUi
{
    partial class studentUiForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.districtBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rollNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.districtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.districtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showdataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(this.districtComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rollNoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StudentInfo";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(103, 225);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(64, 141);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(114, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(64, 107);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(114, 20);
            this.ageTextBox.TabIndex = 8;
            // 
            // districtComboBox
            // 
            this.districtComboBox.DataSource = this.districtBindingSource2;
            this.districtComboBox.DisplayMember = "Name";
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(64, 173);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(114, 21);
            this.districtComboBox.TabIndex = 7;
            this.districtComboBox.ValueMember = "Id";
            // 
            // districtBindingSource2
            // 
            this.districtBindingSource2.DataSource = typeof(StudentUi.Models.District);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "District";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(64, 64);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(114, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // rollNoTextBox
            // 
            this.rollNoTextBox.Location = new System.Drawing.Point(64, 32);
            this.rollNoTextBox.Name = "rollNoTextBox";
            this.rollNoTextBox.Size = new System.Drawing.Size(114, 20);
            this.rollNoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RollNo";
            // 
            // districtBindingSource
            // 
            this.districtBindingSource.DataSource = typeof(StudentUi.Models.District);
            // 
            // districtBindingSource1
            // 
            this.districtBindingSource1.DataSource = typeof(StudentUi.Models.District);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showdataGridView);
            this.groupBox2.Location = new System.Drawing.Point(222, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Records";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // showdataGridView
            // 
            this.showdataGridView.AllowUserToAddRows = false;
            this.showdataGridView.AllowUserToDeleteRows = false;
            this.showdataGridView.AutoGenerateColumns = false;
            this.showdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.idDataGridViewTextBoxColumn,
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.districtIdDataGridViewTextBoxColumn,
            this.DistrictName});
            this.showdataGridView.DataSource = this.studentBindingSource7;
            this.showdataGridView.Location = new System.Drawing.Point(14, 19);
            this.showdataGridView.Name = "showdataGridView";
            this.showdataGridView.ReadOnly = true;
            this.showdataGridView.Size = new System.Drawing.Size(423, 235);
            this.showdataGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // districtIdDataGridViewTextBoxColumn
            // 
            this.districtIdDataGridViewTextBoxColumn.DataPropertyName = "DistrictId";
            this.districtIdDataGridViewTextBoxColumn.HeaderText = "DistrictId";
            this.districtIdDataGridViewTextBoxColumn.Name = "districtIdDataGridViewTextBoxColumn";
            this.districtIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.districtIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // DistrictName
            // 
            this.DistrictName.DataPropertyName = "DistrictName";
            this.DistrictName.HeaderText = "DistrictName";
            this.DistrictName.Name = "DistrictName";
            this.DistrictName.ReadOnly = true;
            // 
            // studentBindingSource7
            // 
            this.studentBindingSource7.DataSource = typeof(StudentUi.Models.Student);
            // 
            // studentBindingSource6
            // 
            this.studentBindingSource6.DataSource = typeof(StudentUi.Models.Student);
            // 
            // studentBindingSource5
            // 
            this.studentBindingSource5.DataSource = typeof(StudentUi.Models.Student);
            // 
            // studentBindingSource4
            // 
            this.studentBindingSource4.DataSource = typeof(StudentUi.Models.Student);
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataSource = typeof(StudentUi.Models.Student);
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataSource = typeof(StudentUi.Models.Student);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataSource = typeof(StudentUi.Models.Student);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentUi.Models.Student);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.editButton);
            this.groupBox3.Controls.Add(this.showButton);
            this.groupBox3.Location = new System.Drawing.Point(229, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 94);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(313, 65);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(216, 65);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(111, 65);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(7, 65);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // studentUiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(670, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "studentUiForm";
            this.Text = "StudenUi";
            this.Load += new System.EventHandler(this.studentUiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rollNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView showdataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.BindingSource districtBindingSource;
        private System.Windows.Forms.BindingSource districtBindingSource1;
        private System.Windows.Forms.BindingSource districtBindingSource2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.BindingSource studentBindingSource3;
        private System.Windows.Forms.BindingSource studentBindingSource4;
        private System.Windows.Forms.BindingSource studentBindingSource5;
        private System.Windows.Forms.BindingSource studentBindingSource6;
        private System.Windows.Forms.BindingSource studentBindingSource7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictName;
    }
}

