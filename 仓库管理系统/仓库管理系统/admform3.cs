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
    public partial class admform3 : Form
    {
        public admform3()
        {
            InitializeComponent();
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

        private void admform3_Load(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from adminer";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(sql, conn))
                {
                    //自动生成  增删改的命令
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);

                    //使用Update更新数据，sql语句中必须包含主键
                    if (sda.Update(ds) > 0) MessageBox.Show("更新成功");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (!r.IsNewRow) { dataGridView1.Rows.Remove(r); }
            }
            string sql = "select * from adminer";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(sql, conn))
                {
                    //自动生成  增删改的命令
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);

                    //使用Update更新数据，sql语句中必须包含主键
                    if (sda.Update(ds) > 0) MessageBox.Show("删除成功");
                }
            }
        }
    }
   
}
