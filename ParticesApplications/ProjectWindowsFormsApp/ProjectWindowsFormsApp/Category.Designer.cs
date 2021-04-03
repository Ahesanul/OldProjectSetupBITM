namespace ProjectWindowsFormsApp
{
    partial class Category
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
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.catagoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dletButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(356, 101);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(240, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(191, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // catagoryDataGridView
            // 
            this.catagoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catagoryDataGridView.Location = new System.Drawing.Point(72, 153);
            this.catagoryDataGridView.Name = "catagoryDataGridView";
            this.catagoryDataGridView.Size = new System.Drawing.Size(382, 172);
            this.catagoryDataGridView.TabIndex = 3;
            this.catagoryDataGridView.DoubleClick += new System.EventHandler(this.catagoryDataGridView_DoubleClick);
            // 
            // dletButton
            // 
            this.dletButton.Location = new System.Drawing.Point(193, 100);
            this.dletButton.Name = "dletButton";
            this.dletButton.Size = new System.Drawing.Size(75, 23);
            this.dletButton.TabIndex = 4;
            this.dletButton.Text = "delet";
            this.dletButton.UseVisualStyleBackColor = true;
            this.dletButton.Click += new System.EventHandler(this.dletButton_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 387);
            this.Controls.Add(this.dletButton);
            this.Controls.Add(this.catagoryDataGridView);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "Category";
            this.Text = "Category Setup";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catagoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView catagoryDataGridView;
        private System.Windows.Forms.Button dletButton;
    }
}

