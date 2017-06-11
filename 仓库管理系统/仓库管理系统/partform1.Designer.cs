namespace 仓库管理系统
{
    partial class partform1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.partid = new System.Windows.Forms.TextBox();
            this.partname = new System.Windows.Forms.TextBox();
            this.partsize = new System.Windows.Forms.TextBox();
            this.partprice = new System.Windows.Forms.TextBox();
            this.partnum = new System.Windows.Forms.TextBox();
            this.cmbhome = new System.Windows.Forms.ComboBox();
            this.partinsert = new System.Windows.Forms.Button();
            this.lable = new System.Windows.Forms.Label();
            this.timebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "零件号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "库房编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "零件名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "零件规格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "价格";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "库存数量";
            // 
            // partid
            // 
            this.partid.Location = new System.Drawing.Point(79, 27);
            this.partid.Name = "partid";
            this.partid.Size = new System.Drawing.Size(143, 21);
            this.partid.TabIndex = 6;
            // 
            // partname
            // 
            this.partname.Location = new System.Drawing.Point(531, 26);
            this.partname.Name = "partname";
            this.partname.Size = new System.Drawing.Size(127, 21);
            this.partname.TabIndex = 7;
            // 
            // partsize
            // 
            this.partsize.Location = new System.Drawing.Point(79, 91);
            this.partsize.Name = "partsize";
            this.partsize.Size = new System.Drawing.Size(143, 21);
            this.partsize.TabIndex = 8;
            // 
            // partprice
            // 
            this.partprice.Location = new System.Drawing.Point(304, 92);
            this.partprice.Name = "partprice";
            this.partprice.Size = new System.Drawing.Size(131, 21);
            this.partprice.TabIndex = 9;
            // 
            // partnum
            // 
            this.partnum.Location = new System.Drawing.Point(531, 92);
            this.partnum.Name = "partnum";
            this.partnum.Size = new System.Drawing.Size(127, 21);
            this.partnum.TabIndex = 10;
            // 
            // cmbhome
            // 
            this.cmbhome.FormattingEnabled = true;
            this.cmbhome.Location = new System.Drawing.Point(304, 27);
            this.cmbhome.Name = "cmbhome";
            this.cmbhome.Size = new System.Drawing.Size(131, 20);
            this.cmbhome.TabIndex = 11;
            // 
            // partinsert
            // 
            this.partinsert.Location = new System.Drawing.Point(531, 176);
            this.partinsert.Name = "partinsert";
            this.partinsert.Size = new System.Drawing.Size(75, 23);
            this.partinsert.TabIndex = 12;
            this.partinsert.Text = "录入";
            this.partinsert.UseVisualStyleBackColor = true;
            this.partinsert.Click += new System.EventHandler(this.partinsert_Click);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(32, 155);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(29, 12);
            this.lable.TabIndex = 13;
            this.lable.Text = "时间";
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(79, 152);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(143, 21);
            this.timebox.TabIndex = 14;
            // 
            // partform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 237);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.partinsert);
            this.Controls.Add(this.cmbhome);
            this.Controls.Add(this.partnum);
            this.Controls.Add(this.partprice);
            this.Controls.Add(this.partsize);
            this.Controls.Add(this.partname);
            this.Controls.Add(this.partid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "partform1";
            this.Text = "零件录入";
            this.Load += new System.EventHandler(this.partform1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox partid;
        private System.Windows.Forms.TextBox partname;
        private System.Windows.Forms.TextBox partsize;
        private System.Windows.Forms.TextBox partprice;
        private System.Windows.Forms.TextBox partnum;
        private System.Windows.Forms.ComboBox cmbhome;
        private System.Windows.Forms.Button partinsert;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox timebox;
    }
}