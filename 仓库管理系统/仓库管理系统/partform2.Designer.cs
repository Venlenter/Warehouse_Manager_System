namespace 仓库管理系统
{
    partial class partform2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.houseid = new System.Windows.Forms.TextBox();
            this.partsid = new System.Windows.Forms.TextBox();
            this.partsname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "条件查询：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "库房编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "零件号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "零件名";
            // 
            // houseid
            // 
            this.houseid.Location = new System.Drawing.Point(87, 47);
            this.houseid.Name = "houseid";
            this.houseid.Size = new System.Drawing.Size(100, 21);
            this.houseid.TabIndex = 4;
            // 
            // partsid
            // 
            this.partsid.Location = new System.Drawing.Point(309, 47);
            this.partsid.Name = "partsid";
            this.partsid.Size = new System.Drawing.Size(127, 21);
            this.partsid.TabIndex = 5;
            // 
            // partsname
            // 
            this.partsname.Location = new System.Drawing.Point(544, 47);
            this.partsname.Name = "partsname";
            this.partsname.Size = new System.Drawing.Size(119, 21);
            this.partsname.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "条件查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 212);
            this.dataGridView1.TabIndex = 8;
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
            // allsearch
            // 
            this.allsearch.Location = new System.Drawing.Point(484, 310);
            this.allsearch.Name = "allsearch";
            this.allsearch.Size = new System.Drawing.Size(75, 23);
            this.allsearch.TabIndex = 9;
            this.allsearch.Text = "全部查询";
            this.allsearch.UseVisualStyleBackColor = true;
            this.allsearch.Click += new System.EventHandler(this.allsearch_Click);
            // 
            // partform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 360);
            this.Controls.Add(this.allsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partsname);
            this.Controls.Add(this.partsid);
            this.Controls.Add(this.houseid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "partform2";
            this.Text = "零件信息查询";
            this.Load += new System.EventHandler(this.partform2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox houseid;
        private System.Windows.Forms.TextBox partsid;
        private System.Windows.Forms.TextBox partsname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partid;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn partprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn homenum;
        private System.Windows.Forms.Button allsearch;
    }
}