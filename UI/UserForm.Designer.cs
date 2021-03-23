namespace MySQLCRUD.UI
{
    partial class UserForm
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
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Middlename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(151, 12);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(175, 20);
            this.txtFirstname.TabIndex = 0;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(151, 38);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(175, 20);
            this.txtMiddlename.TabIndex = 1;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(151, 64);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(175, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(151, 90);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(175, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txtGender.Location = new System.Drawing.Point(151, 116);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(175, 21);
            this.txtGender.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middlename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(388, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 58);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(388, 74);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 58);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(490, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 58);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(490, 74);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 58);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Firstname,
            this.Middlename,
            this.Lastname,
            this.Age,
            this.Gender});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 155);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 283);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Firstname
            // 
            this.Firstname.Text = "Firstname";
            this.Firstname.Width = 124;
            // 
            // Middlename
            // 
            this.Middlename.Text = "Middlename";
            this.Middlename.Width = 109;
            // 
            // Lastname
            // 
            this.Lastname.Text = "Lastname";
            this.Lastname.Width = 117;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 80;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 97;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 45;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.txtFirstname);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Firstname;
        private System.Windows.Forms.ColumnHeader Middlename;
        private System.Windows.Forms.ColumnHeader Lastname;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Id;
    }
}