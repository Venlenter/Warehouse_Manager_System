namespace 仓库管理系统
{
    partial class admform3
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.jobbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(521, 16);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(170, 21);
            this.namebox.TabIndex = 33;
            // 
            // jobbox
            // 
            this.jobbox.Location = new System.Drawing.Point(278, 16);
            this.jobbox.Name = "jobbox";
            this.jobbox.Size = new System.Drawing.Size(150, 21);
            this.jobbox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "工号";
            // 
            // homebox
            // 
            this.homebox.Location = new System.Drawing.Point(69, 17);
            this.homebox.Name = "homebox";
            this.homebox.Size = new System.Drawing.Size(122, 21);
            this.homebox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "库房编号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobnum,
            this.homeid,
            this.name,
            this.sex,
            this.age,
            this.phone,
            this.money,
            this.password});
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(840, 218);
            this.dataGridView1.TabIndex = 34;
            // 
            // jobnum
            // 
            this.jobnum.DataPropertyName = "工号";
            this.jobnum.HeaderText = "工号";
            this.jobnum.Name = "jobnum";
            // 
            // homeid
            // 
            this.homeid.DataPropertyName = "库房编号";
            this.homeid.HeaderText = "库房编号";
            this.homeid.Name = "homeid";
            // 
            // name
            // 
            this.name.DataPropertyName = "姓名";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "性别";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            // 
            // age
            // 
            this.age.DataPropertyName = "年龄";
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "电话";
            this.phone.HeaderText = "电话";
            this.phone.Name = "phone";
            // 
            // money
            // 
            this.money.DataPropertyName = "工资";
            this.money.HeaderText = "工资";
            this.money.Name = "money";
            // 
            // password
            // 
            this.password.DataPropertyName = "密码";
            this.password.HeaderText = "密码";
            this.password.Name = "password";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(739, 293);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 36;
            this.Deletebtn.Text = "删除首行";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(635, 293);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 35;
            this.updatebtn.Text = "更新";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(726, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "条件检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // admform3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 353);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.jobbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homebox);
            this.Controls.Add(this.label1);
            this.Name = "admform3";
            this.Text = "管理员更新与删除";
            this.Load += new System.EventHandler(this.admform3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox jobbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox homebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button btnSearch;
    }
}