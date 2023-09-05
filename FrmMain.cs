using Appraisal_System.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appraisal_System
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //FormFactory.CreateForm("FrmUserManager");

            ////设置为父容器，子容器为frmUserManager窗体
            //frmUserManager = new FrmUserManager();
            //frmUserManager.MdiParent = this;
            //frmUserManager.Parent = splitContainer1.Panel2;
            //frmUserManager.Show();
            Form form = FormFactory<int>.CreateForm("FrmUserManager");
            form.MdiParent = this;
            form.Parent = splitContainer1.Panel2;
            form.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //鼠标失去焦点的时候，导航栏的选中效果的实现
        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach(TreeNode node in trvMenu.Nodes)
            {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;
            }
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor=Color.White;
            Form form = FormFactory<int>.CreateForm(e.Node.Tag?.ToString());//传入不同的泛型时执行不同的类，静态构造函数会再执行一次
            form.MdiParent=this;
            form.Parent = splitContainer1.Panel2;
            form.Show();
        }
    }
}
