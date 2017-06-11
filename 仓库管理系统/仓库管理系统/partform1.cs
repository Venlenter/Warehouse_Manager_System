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
    public partial class partform1 : Form
    {
        public partform1()
        {
            InitializeComponent();
        }
        string connStr = @"server=.;database=Depot;Integrated Security=True";// windwos 身份验证方式
        DataSet ds = new DataSet();

        private void partform1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlDataAdapter sda = new SqlDataAdapter("select 库房编号 from house", conn);
                sda.Fill(ds, "house");
            }
            this.cmbhome.DataSource = ds.Tables["house"];
            this.cmbhome.DisplayMember = "库房编号";

        }

        private void partinsert_Click(object sender, EventArgs e)
        {
            if (partid.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sqlStr = string.Format("select count(*) from [parts] where 零件号='{0}'", partid.Text);
                    using (SqlCommand cmd2 = new SqlCommand(sqlStr, conn))
                    {
                        conn.Open();
                        int n = Convert.ToInt32(cmd2.ExecuteScalar());
                        if (n == 0)
                        {
                            string sql = "insert into parts values ( '" + partid.Text + "','" + cmbhome.Text + "','" + partname.Text + "','" + partsize.Text + "','" + partprice.Text + "','" + partnum.Text + "')";
                            string sql1 = "insert into partsum values ( '" + partid.Text + "','" + cmbhome.Text + "','" + partnum.Text + "')";
                            string sql2 = "insert into partaddtable values ( '" + partid.Text + "','" + partnum.Text + "','" + timebox.Text + "')";
                            string sql3 = "insert into homepart values ( '" + cmbhome.Text + "','" + partid.Text + "')";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            SqlCommand cmd1 = new SqlCommand(sql1, conn);
                            SqlCommand cmd3 = new SqlCommand(sql2, conn);
                            SqlCommand cmd4 = new SqlCommand(sql3, conn);
                            if ((cmd.ExecuteNonQuery()) > 0 && (cmd1.ExecuteNonQuery() > 0) && (cmd3.ExecuteNonQuery() > 0) && (cmd4.ExecuteNonQuery() > 0)) MessageBox.Show("添加成功");
                            conn.Close();
                            partid.Text = "";
                            partname.Text = "";
                            partsize.Text = "";
                            partprice.Text = "";
                            partnum.Text = "";
                            timebox.Text = "";
                        }
                        else MessageBox.Show("零件号已存在，请重新输入");
                    }
                }
            }
            else MessageBox.Show("请输入零件号");

        }
    }
}
