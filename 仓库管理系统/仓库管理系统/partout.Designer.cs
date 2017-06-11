namespace 仓库管理系统
{
    partial class partout
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbpart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outnum = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "零件号";
            // 
            // cmbpart
            // 
            this.cmbpart.FormattingEnabled = true;
            this.cmbpart.Location = new System.Drawing.Point(102, 27);
            this.cmbpart.Name = "cmbpart";
            this.cmbpart.Size = new System.Drawing.Size(146, 20);
            this.cmbpart.TabIndex = 5;
            this.cmbpart.SelectedIndexChanged += new System.EventHandler(this.cmbpart_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "出库量";
            // 
            // outnum
            // 
            this.outnum.Location = new System.Drawing.Point(102, 72);
            this.outnum.Name = "outnum";
            this.outnum.Size = new System.Drawing.Size(146, 21);
            this.outnum.TabIndex = 7;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(173, 161);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "时间";
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(102, 116);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(146, 21);
            this.timebox.TabIndex = 10;
            // 
            // partout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 214);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.outnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbpart);
            this.Controls.Add(this.label2);
            this.Name = "partout";
            this.Text = "partout";
            this.Load += new System.EventHandler(this.partout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbpart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outnum;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox timebox;
    }
}