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
    public partial class partform2 : Form
    {
        public partform2()
        {
            InitializeComponent();
        }

        private void partform2_Load(object sender, EventArgs e)
        {

        }
        string connStr = @"server=.;database=Depot;Integrated Security=True";// windwos 身份验证方式
        DataSet ds = new DataSet();

        void BindDgv(string sqlStr)
        {
            //dataGridView1.Rows.Clear();
            //清空datatable中的数据
            if (ds.Tables.Count > 0)
            {
                ds.Tables[0].Rows.Clear();
            }


            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, conn);

                //Fill方法内部打开和关闭数据库 
                sda.Fill(ds);
            }
            //不自动产生列
            dataGridView1.AutoGenerateColumns = false;
            //绑定 
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from parts where 1=1";
            if (partsid.Text.Length > 0)
            {
                sql += " and 零件号='" + partsid.Text + "'";
            }
            if (houseid.Text.Length > 0)
            {
                sql += " and 库房编号='" + houseid.Text + "'";
            }
            if (partsname.Text.Length > 0)
            {
                sql += " and 零件名 like '%" + partsname.Text + "%'";
            }

            BindDgv(sql);
        }

        private void allsearch_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from parts ";
            BindDgv(sql1);
        }
    }
}
