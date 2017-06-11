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
using System.Configuration;

namespace 仓库管理系统
{
    public partial class admform2 : Form
    {
        public admform2()
        {
            InitializeComponent();
        }

        private void admform_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“depotDataSet.adminer”中。您可以根据需要移动或删除它。
            this.adminerTableAdapter.Fill(this.depotDataSet.adminer);

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
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            //实现多条件查询
            string sql = "select * from adminer";
            BindDgv(sql);
        }

        private void littleserch_Click(object sender, EventArgs e)
        {
            //实现多条件查询
            string sql = "select * from adminer where 1=1";
            if (homebox.Text.Length > 0)
            {
                sql += " and 库房编号='" + homebox.Text + "'";
            }
            if (jobbox.Text.Length > 0)
            {
                sql += " and 工号='" + jobbox.Text + "'";
            }
            if (namebox.Text.Length > 0)
            {
                sql += " and 姓名 like '%" + namebox.Text + "%'";
            }

            BindDgv(sql);
        }

    }
}
