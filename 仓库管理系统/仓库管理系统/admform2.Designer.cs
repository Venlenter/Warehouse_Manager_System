namespace 仓库管理系统
{
    partial class admform2
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
            this.depotDataSet = new 仓库管理系统.DepotDataSet();
            this.adminerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminerTableAdapter = new 仓库管理系统.DepotDataSetTableAdapters.adminerTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namebox = new System.Windows.Forms.TextBox();
            this.jobbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.littleserch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.depotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // depotDataSet
            // 
            this.depotDataSet.DataSetName = "DepotDataSet";
            this.depotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminerBindingSource
            // 
            this.adminerBindingSource.DataMember = "adminer";
            this.adminerBindingSource.DataSource = this.depotDataSet;
            // 
            // adminerTableAdapter
            // 
            this.adminerTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(727, 324);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "全部查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(840, 218);
            this.dataGridView1.TabIndex = 22;
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
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(572, 43);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(170, 21);
            this.namebox.TabIndex = 21;
            // 
            // jobbox
            // 
            this.jobbox.Location = new System.Drawing.Point(309, 43);
            this.jobbox.Name = "jobbox";
            this.jobbox.Size = new System.Drawing.Size(150, 21);
            this.jobbox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "工号";
            // 
            // homebox
            // 
            this.homebox.Location = new System.Drawing.Point(83, 44);
            this.homebox.Name = "homebox";
            this.homebox.Size = new System.Drawing.Size(122, 21);
            this.homebox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "库房编号";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "条件查询：";
            // 
            // littleserch
            // 
            this.littleserch.Location = new System.Drawing.Point(603, 324);
            this.littleserch.Name = "littleserch";
            this.littleserch.Size = new System.Drawing.Size(75, 23);
            this.littleserch.TabIndex = 27;
            this.littleserch.Text = "条件查询";
            this.littleserch.UseVisualStyleBackColor = true;
            this.littleserch.Click += new System.EventHandler(this.littleserch_Click);
            // 
            // admform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 401);
            this.Controls.Add(this.littleserch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.jobbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homebox);
            this.Controls.Add(this.label1);
            this.Name = "admform2";
            this.Text = "管理员信息查询";
            this.Load += new System.EventHandler(this.admform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DepotDataSet depotDataSet;
        private System.Windows.Forms.BindingSource adminerBindingSource;
        private DepotDataSetTableAdapters.adminerTableAdapter adminerTableAdapter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox jobbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox homebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button littleserch;
    }
}