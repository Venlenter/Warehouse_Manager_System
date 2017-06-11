namespace 仓库管理系统
{
    partial class daytable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.partsid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "入库单";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "出库单";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partid,
            this.addnum,
            this.time});
            this.dataGridView1.Location = new System.Drawing.Point(26, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(339, 152);
            this.dataGridView1.TabIndex = 2;
            // 
            // partid
            // 
            this.partid.DataPropertyName = "零件号";
            this.partid.HeaderText = "零件号";
            this.partid.Name = "partid";
            // 
            // addnum
            // 
            this.addnum.DataPropertyName = "入库量";
            this.addnum.HeaderText = "入库量";
            this.addnum.Name = "addnum";
            // 
            // time
            // 
            this.time.DataPropertyName = "时间";
            this.time.HeaderText = "时间";
            this.time.Name = "time";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partsid,
            this.outnum,
            this.outtime});
            this.dataGridView2.Location = new System.Drawing.Point(438, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(341, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // partsid
            // 
            this.partsid.DataPropertyName = "零件号";
            this.partsid.HeaderText = "零件号";
            this.partsid.Name = "partsid";
            // 
            // outnum
            // 
            this.outnum.DataPropertyName = "出库量";
            this.outnum.HeaderText = "出库量";
            this.outnum.Name = "outnum";
            // 
            // outtime
            // 
            this.outtime.DataPropertyName = "时间";
            this.outtime.HeaderText = "时间";
            this.outtime.Name = "outtime";
            // 
            // daytable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 253);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "daytable";
            this.Text = "daytable";
            this.Load += new System.EventHandler(this.daytable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partid;
        private System.Windows.Forms.DataGridViewTextBoxColumn addnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsid;
        private System.Windows.Forms.DataGridViewTextBoxColumn outnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn outtime;
    }
}