namespace 仓库管理系统
{
    partial class partform3
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
            this.partid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsname = new System.Windows.Forms.TextBox();
            this.partsid = new System.Windows.Forms.TextBox();
            this.houseid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partid,
            this.homeid,
            this.partname,
            this.partsize,
            this.partprice,
            this.homenum});
            this.dataGridView1.Location = new System.Drawing.Point(11, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 212);
            this.dataGridView1.TabIndex = 17;
            // 
            // partid
            // 
            this.partid.DataPropertyName = "零件号";
            this.partid.HeaderText = "零件号";
            this.partid.Name = "partid";
            // 
            // homeid
            // 
            this.homeid.DataPropertyName = "库房编号";
            this.homeid.HeaderText = "库房编号";
            this.homeid.Name = "homeid";
            // 
            // partname
            // 
            this.partname.DataPropertyName = "零件名";
            this.partname.HeaderText = "零件名";
            this.partname.Name = "partname";
            // 
            // partsize
            // 
            this.partsize.DataPropertyName = "规格";
            this.partsize.HeaderText = "规格";
            this.partsize.Name = "partsize";
            // 
            // partprice
            // 
            this.partprice.DataPropertyName = "价格";
            this.partprice.HeaderText = "价格";
            this.partprice.Name = "partprice";
            // 
            // homenum
            // 
            this.homenum.DataPropertyName = "库存数量";
            this.homenum.HeaderText = "库存数量";
            this.homenum.Name = "homenum";
            // 
            // partsname
            // 
            this.partsname.Location = new System.Drawing.Point(438, 17);
            this.partsname.Name = "partsname";
            this.partsname.Size = new System.Drawing.Size(119, 21);
            this.partsname.TabIndex = 15;
            // 
            // partsid
            // 
            this.partsid.Location = new System.Drawing.Point(239, 17);
            this.partsid.Name = "partsid";
            this.partsid.Size = new System.Drawing.Size(127, 21);
            this.partsid.TabIndex = 14;
            // 
            // houseid
            // 
            this.houseid.Location = new System.Drawing.Point(68, 17);
            this.houseid.Name = "houseid";
            this.houseid.Size = new System.Drawing.Size(100, 21);
            this.houseid.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "零件名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "零件号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "库房编号";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(542, 284);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 38;
            this.Deletebtn.Text = "删除首行";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(438, 284);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 37;
            this.updatebtn.Text = "更新";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(575, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "条件检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // partform3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 328);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.partsname);
            this.Controls.Add(this.partsid);
            this.Controls.Add(this.houseid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "partform3";
            this.Text = "零件更新与删除";
            this.Load += new System.EventHandler(this.partform3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partid;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn partprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn homenum;
        private System.Windows.Forms.TextBox partsname;
        private System.Windows.Forms.TextBox partsid;
        private System.Windows.Forms.TextBox houseid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button btnSearch;
    }
}