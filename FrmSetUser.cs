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
    public partial class FrmSetUser : Form
    {
        private DelBindDgv _delBindDgv;
        public FrmSetUser(DelBindDgv delBindDgv)
        {
            InitializeComponent();
            _delBindDgv= delBindDgv;
        }
        private Users _user;
        public FrmSetUser(DelBindDgv delBindDgv,int UserId):this(delBindDgv)//先执行上面的FrmSetUser方法
        {
            //InitializeComponent();
            _user = Users.ListAll().Find(m => m.Id == UserId);
            
        }
        private void FrmSetUser_Load(object sender, EventArgs e)
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            appraisalBases = AppraisalBases.ListAll();           
            cbxBases.DataSource = appraisalBases;
            cbxBases.DisplayMember = "BaseType";
            cbxBases.ValueMember = "Id";
            //创建窗体给combobox赋值，执行完FrmSetUser方法再执行FrmSetUser_Load方法。
            txtUserName.Text = _user.UserName;
            cbxBases.SelectedValue = _user.BaseTypeId;
            cbxSex.Text = _user.Sex;
            chkIsStop.Checked = _user.IsDel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string txtusername=txtUserName.Text.Trim();
            int baseTypeId = (int)cbxBases.SelectedValue;
            string sex = cbxSex.Text;
            bool isDel=chkIsStop.Checked;
            if(_user==null)
            {
                Users users = new Users
                {
                    UserName = txtusername,
                    BaseTypeId = baseTypeId,
                    PassWord = "111",
                    Sex = sex,
                    IsDel = isDel
                };
                Users.Insert(users);
                MessageBox.Show("添加成功！");
            }
            else
            {
                _user.UserName = txtusername;
                _user.BaseTypeId = baseTypeId;                
                _user.Sex = sex;
                _user.IsDel = isDel;
                Users.Update(_user);
                MessageBox.Show("用户修改成功！");  
            }
            _delBindDgv();//刷新外面的GridView
            this.Close();
        }
    }
}
