using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void 管理员信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admform1 admform1 = new admform1();
            admform1.Owner = this;
            //this.Visible = false;
            admform1.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void adlogin21_Load(object sender, EventArgs e)
        {

        }

        private void 库房信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admform2 admform2 = new admform2();
            admform2.Owner = this;
            //this.Visible = false;
            admform2.ShowDialog();
        }

        private void 管理员信息更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admform3 admform3 = new admform3();
            admform3.Owner = this;
            //this.Visible = false;
            admform3.ShowDialog();
        }

        private void 删除管理员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admform3 admform3 = new admform3();
            admform3.Owner = this;
            //this.Visible = false;
            admform3.ShowDialog();
        }

        private void 零件信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partform1 partform1 = new partform1();
            partform1.Owner = this;
            //this.Visible = false;
            partform1.ShowDialog();
        }

        private void 库房信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeform1 homeform1 = new homeform1();
            homeform1.Owner = this;
            //this.Visible = false;
            homeform1.ShowDialog();
        }

        private void 管理员信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partform2 partform2 = new partform2();
            partform2.Owner = this;
            //this.Visible = false;
            partform2.ShowDialog();
        }

        private void 零件信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeform2 homeform2 = new homeform2();
            homeform2.Owner = this;
            //this.Visible = false;
            homeform2.ShowDialog();
        }

        private void 零件信息更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partform3 partform3 = new partform3();
            partform3.Owner = this;
            //this.Visible = false;
            partform3.ShowDialog();
        }

        private void 库房信息更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeform3 homeform3 = new homeform3();
            homeform3.Owner = this;
            //this.Visible = false;
            homeform3.ShowDialog();
        }

        private void 零件出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partout partout = new partout();
            partout.Owner = this;
            //this.Visible = false;
            partout.ShowDialog();
        }

        private void 新零件添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partform1 partform1 = new partform1();
            partform1.Owner = this;
            //this.Visible = false;
            partform1.ShowDialog();
        }

        private void 已有零件添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partadd partadd = new partadd();
            partadd.Owner = this;
            //this.Visible = false;
            partadd.ShowDialog();
        }

        private void 入库单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daytable daytable = new daytable();
            daytable.Owner = this;
            //this.Visible = false;
            daytable.ShowDialog();
        }

        private void 删除零件信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partform3 partform3 = new partform3();
            partform3.Owner = this;
            //this.Visible = false;
            partform3.ShowDialog();
        }

        private void 删除库房信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeform3 homeform3 = new homeform3();
            homeform3.Owner = this;
            //this.Visible = false;
            homeform3.ShowDialog();
        }

    }
}
