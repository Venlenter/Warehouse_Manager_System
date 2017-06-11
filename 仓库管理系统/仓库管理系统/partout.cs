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
    public partial class partout : Form
    {
        public partout()
        {
            InitializeComponent();
        }
        string connStr = @"server=.;database=Depot;Integrated Security=True";// windwos 身份验证方式
        DataSet ds = new DataSet();

        private void partout_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select 零件号 from parts" , conn);
                sda.Fill(ds, "parts");
            }
            this.cmbpart.DataSource = ds.Tables["parts"];
            this.cmbpart.DisplayMember = "零件号";
        }



        private void confirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql1 = "update parts set 库存数量=库存数量-" + outnum.Text + " where 零件号='" + cmbpart.Text + "'";
                string sql = "insert into partoutable values ( '" + cmbpart.Text + "','" + outnum.Text + "','" + timebox.Text + "')";
                if (outnum.Text != "")
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("出库成功");
                    conn.Close();
                    outnum.Text = "";

                }
                else MessageBox.Show("请输入出库量");
            }
        }

        private void partname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbpart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
