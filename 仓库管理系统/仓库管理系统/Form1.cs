using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //this.Controls.Remove(Adlogin2);
            string connStr = @"server=.;database=Depot;Integrated Security=True";// windwos 身份验证方式
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlStr = string.Format("select count(*) from [adminer] where 工号='{0}'and 密码='{1}'", txtName.Text, txtPassword.Text);
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    conn.Open();
                    int n = Convert.ToInt32(cmd.ExecuteScalar());
                    if (n > 0)
                    {
                        main main1 = new main();
                        main1.Owner = this;
                        this.Visible = false;
                        main1.ShowDialog();
                    }
                    else MessageBox.Show("登陆失败");
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            admform1 admform1 = new admform1();
            admform1.Owner = this;
            //this.Visible = false;
            admform1.ShowDialog();
        }
    }
}
