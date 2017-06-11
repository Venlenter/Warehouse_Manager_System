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
    public partial class homeform2 : Form
    {
        public homeform2()
        {
            InitializeComponent();
        }

        string connStr = @"server=.;database=Depot;Integrated Security=True";// windwos 身份验证方式
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();

        private void homeform2_Load(object sender, EventArgs e)
        {
            
        }

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
        void BindDgv2(string sqlStr)
        {
            //dataGridView1.Rows.Clear();
            //清空datatable中的数据
            if (ds2.Tables.Count > 0)
            {
                ds2.Tables[0].Rows.Clear();
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, conn);

                //Fill方法内部打开和关闭数据库 
                sda.Fill(ds2);
            }
            //不自动产生列
            dataGridView2.AutoGenerateColumns = false;
            //绑定 
            dataGridView2.DataSource = ds2.Tables[0];
        }
        void BindDgv3(string sqlStr)
        {
            //dataGridView1.Rows.Clear();
            //清空datatable中的数据
            if (ds3.Tables.Count > 0)
            {
                ds3.Tables[0].Rows.Clear();
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, conn);

                //Fill方法内部打开和关闭数据库 
                sda.Fill(ds3);
            }
            //不自动产生列
            dataGridView3.AutoGenerateColumns = false;
            //绑定 
            dataGridView3.DataSource = ds3.Tables[0];
        }

        private void idsearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from house where 1=1" + " and 库房编号='" + homebox.Text + "'";
            BindDgv(sql);
        }

        private void allsearch_Click(object sender, EventArgs e)
        {
            string sql2 = "select * from house ";
            BindDgv(sql2);
        }

        private void othersearch_Click(object sender, EventArgs e)
        {
            string sql3 = "select * from homead where 1=1" + " and 库房编号='" + homebox.Text + "'";
            string sql4 = "select * from homepart where 1=1" + " and 库房编号='" + homebox.Text + "'";
            BindDgv2(sql3);
            BindDgv3(sql4);
        }
    }
}
