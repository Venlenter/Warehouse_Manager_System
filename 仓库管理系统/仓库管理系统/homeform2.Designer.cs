namespace 仓库管理系统
{
    partial class homeform2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.houseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.housesid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.idsearch = new System.Windows.Forms.Button();
            this.allsearch = new System.Windows.Forms.Button();
            this.othersearch = new System.Windows.Forms.Button();
            this.homebox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homeid,
            this.adress,
            this.area});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(338, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // homeid
            // 
            this.homeid.DataPropertyName = "库房编号";
            this.homeid.HeaderText = "库房编号";
            this.homeid.Name = "homeid";
            // 
            // adress
            // 
            this.adress.DataPropertyName = "地址";
            this.adress.HeaderText = "地址";
            this.adress.Name = "adress";
            // 
            // area
            // 
            this.area.DataPropertyName = "面积";
            this.area.HeaderText = "面积";
            this.area.Name = "area";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseid,
            this.adminid});
            this.dataGridView2.Location = new System.Drawing.Point(391, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(239, 167);
            this.dataGridView2.TabIndex = 1;
            // 
            // houseid
            // 
            this.houseid.DataPropertyName = "库房编号";
            this.houseid.HeaderText = "库房编号";
            this.houseid.Name = "houseid";
            // 
            // adminid
            // 
            this.adminid.DataPropertyName = "工号";
            this.adminid.HeaderText = "管理员工号";
            this.adminid.Name = "adminid";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.housesid,
            this.partid});
            this.dataGridView3.Location = new System.Drawing.Point(390, 198);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // housesid
            // 
            this.housesid.DataPropertyName = "库房编号";
            this.housesid.HeaderText = "库房编号";
            this.housesid.Name = "housesid";
            // 
            // partid
            // 
            this.partid.DataPropertyName = "零件号";
            this.partid.HeaderText = "零件号";
            this.partid.Name = "partid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "库房编号";
            // 
            // idsearch
            // 
            this.idsearch.Location = new System.Drawing.Point(28, 313);
            this.idsearch.Name = "idsearch";
            this.idsearch.Size = new System.Drawing.Size(75, 23);
            this.idsearch.TabIndex = 7;
            this.idsearch.Text = "编号查询";
            this.idsearch.UseVisualStyleBackColor = true;
            this.idsearch.Click += new System.EventHandler(this.idsearch_Click);
            // 
            // allsearch
            // 
            this.allsearch.Location = new System.Drawing.Point(131, 313);
            this.allsearch.Name = "allsearch";
            this.allsearch.Size = new System.Drawing.Size(75, 23);
            this.allsearch.TabIndex = 8;
            this.allsearch.Text = "全部查询";
            this.allsearch.UseVisualStyleBackColor = true;
            this.allsearch.Click += new System.EventHandler(this.allsearch_Click);
            // 
            // othersearch
            // 
            this.othersearch.Location = new System.Drawing.Point(232, 313);
            this.othersearch.Name = "othersearch";
            this.othersearch.Size = new System.Drawing.Size(119, 23);
            this.othersearch.TabIndex = 9;
            this.othersearch.Text = "查询管理员及库存";
            this.othersearch.UseVisualStyleBackColor = true;
            this.othersearch.Click += new System.EventHandler(this.othersearch_Click);
            // 
            // homebox
            // 
            this.homebox.Location = new System.Drawing.Point(85, 257);
            this.homebox.Name = "homebox";
            this.homebox.Size = new System.Drawing.Size(143, 21);
            this.homebox.TabIndex = 10;
            // 
            // homeform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 360);
            this.Controls.Add(this.homebox);
            this.Controls.Add(this.othersearch);
            this.Controls.Add(this.allsearch);
            this.Controls.Add(this.idsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "homeform2";
            this.Text = "库房信息查询";
            this.Load += new System.EventHandler(this.homeform2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminid;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn housesid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button idsearch;
        private System.Windows.Forms.Button allsearch;
        private System.Windows.Forms.Button othersearch;
        private System.Windows.Forms.TextBox homebox;
    }
}