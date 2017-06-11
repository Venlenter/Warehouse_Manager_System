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
    public partial class homeform1 : Form
    {
        public homeform1()
        {
            InitializeComponent();
        }
        string connStr = @"server=.;database=Depot;Integrated Security=True";// windwos 身份验证方式
        DataSet ds = new DataSet();

        private void homeform1_Load(object sender, EventArgs e)
        {

        }

        private void homeinsert_Click(object sender, EventArgs e)
        {
            if (homeid.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sqlStr = string.Format("select count(*) from [house] where 库房编号='{0}'", homeid.Text);
                    using (SqlCommand cmd2 = new SqlCommand(sqlStr, conn))
                    {
                        conn.Open();
                        int n = Convert.ToInt32(cmd2.ExecuteScalar());
                        if (n == 0)
                        {
                            string sql = "insert into house values ( '" + homeid.Text + "','" + address.Text + "','" + area.Text + "')";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("添加成功");
                            conn.Close();
                            homeid.Text = "";
                            address.Text = "";
                            area.Text = "";
                        }
                        else MessageBox.Show("库房编号已存在，请重新输入");
                    }
                }
            }
            else MessageBox.Show("请输入库房编号");
        }

    }
}
