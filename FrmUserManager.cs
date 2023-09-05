using Appraisal_System.Models;
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
    public delegate void DelBindDgv();//先声明委托的关键字
    public partial class FrmUserManager : Form
    {
        DelBindDgv delBindDgv;//声明委托变量
        public FrmUserManager()
        {
            InitializeComponent();
        }

        private void FrmUserManager_Load(object sender, EventArgs e)
        {
            BindCbx();
            BindDgv();
            delBindDgv = BindDgv;
        }

        private void BindDgv()
        {
            string username = txtUserName.Text.Trim();
            int baseTypeId = (int)cbxBases.SelectedIndex;
            bool isStop = chkIsStop.Checked;
            dgvUserAppraisal.AutoGenerateColumns = false;
            List<UserAppraisalBases> userAppraisalBases = new List<UserAppraisalBases>();
            if (baseTypeId == 0)
            {
                dgvUserAppraisal.DataSource = UserAppraisalBases.GetListJoinAppraisal().FindAll
                (m => m.UserName.Contains(username) && m.IsDel == isStop);
            }
            else
            {
                dgvUserAppraisal.DataSource = UserAppraisalBases.GetListJoinAppraisal().FindAll
                (m => m.UserName.Contains(username) && m.BaseTypeId == baseTypeId && m.IsDel == isStop);
            }
        }

        private void BindCbx()
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            //appraisalBases.Add(new AppraisalBases
            //{
            //    Id = 0,
            //    BaseType="查询所有",
            //    AppraisalBase=0,
            //    IsDel=false
            //});
            //IEnumerable<AppraisalBases> appraisalBases1=AppraisalBases.ListAll();
            //appraisalBases.AddRange(appraisalBases1);
            appraisalBases = AppraisalBases.ListAll();
            appraisalBases.Insert(0, new AppraisalBases
            {
                Id = 0,
                BaseType = "查询所有",
                AppraisalBase = 0,
                IsDel = false
            });
            cbxBases.DataSource = appraisalBases;
            cbxBases.DisplayMember = "BaseType";
            cbxBases.ValueMember = "Id";
            //foreach (var appraisalbase in appraisalBases)
            //{
            //    cbxBases.Items.Add(appraisalbase.BaseType);
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgv();
        }

        private void dgvUserAppraisal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmAdd.Visible = true;
                tsmEdit.Visible = false;
                tsmStart.Visible = false;
                tsmStop.Visible = false;
            }
        }

        private void dgvUserAppraisal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    dgvUserAppraisal.Rows[e.RowIndex].Selected = true;
                    tsmAdd.Visible = true;
                    tsmEdit.Visible = true;
                    bool IsDel= (bool)dgvUserAppraisal.SelectedRows[0].Cells["IsDel"].Value;
                    if (IsDel)
                    {
                        tsmStart.Visible = true;
                    }
                    else
                    {
                        tsmStop.Visible = true;
                    }                   
                }
            }
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            FrmSetUser frmSetUser = new FrmSetUser(delBindDgv);
            frmSetUser.ShowDialog();
            //BindDgv();//表格刷新
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int id = (int)dgvUserAppraisal.SelectedRows[0].Cells["Id"].Value;
            FrmSetUser frmSetUser=new FrmSetUser(delBindDgv,id);
            frmSetUser.Text = "编辑用户信息";
            frmSetUser.ShowDialog();
        }
    }
}
