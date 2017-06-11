namespace 仓库管理系统
{
    partial class homeform1
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
            this.address = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.homeinsert = new System.Windows.Forms.Button();
            this.homeid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "库房编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "库房地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "占地面积";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(83, 100);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(211, 21);
            this.address.TabIndex = 4;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(83, 165);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(211, 21);
            this.area.TabIndex = 5;
            // 
            // homeinsert
            // 
            this.homeinsert.Location = new System.Drawing.Point(219, 208);
            this.homeinsert.Name = "homeinsert";
            this.homeinsert.Size = new System.Drawing.Size(75, 23);
            this.homeinsert.TabIndex = 6;
            this.homeinsert.Text = "录入";
            this.homeinsert.UseVisualStyleBackColor = true;
            this.homeinsert.Click += new System.EventHandler(this.homeinsert_Click);
            // 
            // homeid
            // 
            this.homeid.Location = new System.Drawing.Point(83, 34);
            this.homeid.Name = "homeid";
            this.homeid.Size = new System.Drawing.Size(211, 21);
            this.homeid.TabIndex = 7;
            // 
            // homeform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 258);
            this.Controls.Add(this.homeid);
            this.Controls.Add(this.homeinsert);
            this.Controls.Add(this.area);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "homeform1";
            this.Text = "新建库房";
            this.Load += new System.EventHandler(this.homeform1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Button homeinsert;
        private System.Windows.Forms.TextBox homeid;
    }
}