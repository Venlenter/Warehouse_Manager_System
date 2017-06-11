namespace 仓库管理系统
{
    partial class partadd
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
            this.timebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.addnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbpart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(80, 106);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(146, 21);
            this.timebox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "时间";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(151, 151);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 15;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // addnum
            // 
            this.addnum.Location = new System.Drawing.Point(80, 62);
            this.addnum.Name = "addnum";
            this.addnum.Size = new System.Drawing.Size(146, 21);
            this.addnum.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "入库量";
            // 
            // cmbpart
            // 
            this.cmbpart.FormattingEnabled = true;
            this.cmbpart.Location = new System.Drawing.Point(80, 17);
            this.cmbpart.Name = "cmbpart";
            this.cmbpart.Size = new System.Drawing.Size(146, 20);
            this.cmbpart.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "零件号";
            // 
            // partadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 216);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.addnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbpart);
            this.Controls.Add(this.label2);
            this.Name = "partadd";
            this.Text = "partadd";
            this.Load += new System.EventHandler(this.partadd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox addnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbpart;
        private System.Windows.Forms.Label label2;
    }
}