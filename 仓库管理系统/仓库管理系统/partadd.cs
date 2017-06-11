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
    public partial class partadd : Form
    {
        public partadd()
        {
            InitializeComponent();
        }
        string connStr = @"server=.;database=Depot;Integrated Security=True";// windwos 身份验证方式
        DataSet ds = new DataSet();

        private void partadd_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select 零件号 from parts", conn);
                sda.Fill(ds, "parts");
            }
            this.cmbpart.DataSource = ds.Tables["parts"];
            this.cmbpart.DisplayMember = "零件号";
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql1 = "update parts set 库存数量=库存数量+" +addnum.Text + " where 零件号='" + cmbpart.Text + "'";
                string sql = "insert into partaddtable values ( '" + cmbpart.Text + "','" + addnum.Text + "','" + timebox.Text + "')";
                if (addnum.Text != "")
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("入库成功");
                    conn.Close();
                    addnum.Text = "";

                }
                else MessageBox.Show("请输入入库量");

            }
        }
    }
}
