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
    public partial class admform1 : Form
    {
        public admform1()
        {
            InitializeComponent();
        }

        string connStr = @"server=.;database=Depot;Integrated Security=True";// windwos 身份验证方式
        DataSet ds = new DataSet();

        private void admform1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlDataAdapter sda = new SqlDataAdapter("select 库房编号 from house", conn);
                sda.Fill(ds, "house");
            }
            this.cboClass.DataSource = ds.Tables["house"];
            this.cboClass.DisplayMember = "库房编号";
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                if (jobbox.Text != "")
                {
                    string sqlStr = string.Format("select count(*) from [adminer] where 工号='{0}'", jobbox.Text);
                    using (SqlCommand cmd2 = new SqlCommand(sqlStr, conn))
                    {
                        conn.Open();
                        int n = Convert.ToInt32(cmd2.ExecuteScalar());
                        if (n == 0)
                        {
                            string sql = "insert into adminer values ( '" + jobbox.Text + "','" + cboClass.Text + "','" + namebox.Text + "','" + sexbox.Text + "','" + agebox.Text + "','" + phonebox.Text + "','" + moneybox.Text + "','" + passbox.Text + "')";
                            string sql1 = "insert into homead values ( '" + cboClass.Text + "','" + jobbox.Text + "')";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            SqlCommand cmd1 = new SqlCommand(sql1, conn);
                            if ((cmd.ExecuteNonQuery()) > 0 && (cmd1.ExecuteNonQuery() > 0)) MessageBox.Show("注册成功");
                            conn.Close();
                            jobbox.Text = "";
                            namebox.Text = "";
                            sexbox.Text = "";
                            agebox.Text = "";
                            phonebox.Text = "";
                            moneybox.Text = "";
                            passbox.Text = "";
                        }
                        else MessageBox.Show("工号已存在，请重新输入");
                    }
                }
                else MessageBox.Show("请输入工号");
            }
        }
    }
}
