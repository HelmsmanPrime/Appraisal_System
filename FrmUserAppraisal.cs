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
    public partial class FrmUserAppraisal : Form
    {
        public FrmUserAppraisal()
        {
            InitializeComponent();
        }
        Action binDgv;
        private void FrmUserAppraisal_Load(object sender, EventArgs e)
        {
            SetCol();
            BindDgvUserAppraisal();
            binDgv = BindDgvUserAppraisal;
        }

        private void BindDgvUserAppraisal()
        {
            //获取需要扩展的表
            DataTable dtUser = UserAppraisalBases.GetDtJoinAppraisal();
            //获取系数表集合
            List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
            //通过系数表来填充dtUser
            foreach (var item in appraisalCoefficients)
            {
                //添加系数名
                dtUser.Columns.Add(new DataColumn
                {
                    ColumnName = "AppraisalType" + item.Id
                });
                //添加系数值
                dtUser.Columns.Add(new DataColumn
                {
                    ColumnName = "AppraisalCoefficient" + item.Id
                });
                //添加计算方式
                dtUser.Columns.Add(new DataColumn
                {
                    ColumnName = "CalculationMethod" + item.Id
                });
            }
            //添加考核年度
            dtUser.Columns.Add(new DataColumn
            {
                ColumnName = "AssessmentYear"
            });
            //添加实发年终奖
            dtUser.Columns.Add(new DataColumn
            {
                ColumnName = "YearBonus"
            });
            //给dtUser填充数据
            List<UserAppraisalCoefficients> userAppraisalCoefficients = UserAppraisalCoefficients.ListAll();
            for (int i = 0; i < dtUser.Rows.Count; i++)
            {
                var uacFilter = userAppraisalCoefficients.FindAll(m => m.UserId == (int)dtUser.Rows[i]["Id"] &&
                m.AssessmentYear == Convert.ToInt32(cbxYear.Text));
                //实发年终奖
                //系数计算的数组，用于存放考核类型的总系数
                double[] yearBonusArray = new double[uacFilter.Count];
                for (int j = 0; j < uacFilter.Count; j++)
                {
                    //获取AppraisalType对应的dtUser的ColumnName
                    //获取考核次数
                    string AppraisalTypeKey = "AppraisalType" + uacFilter[j].CoefficientId;
                    double AppraisalTypeCountValue = uacFilter[j].Count;
                    //获取考核系数
                    string AppraisalCoefficientKey = "AppraisalCoefficient" + uacFilter[j].CoefficientId;
                    double AppraisalCoefficientValue = uacFilter[j].AppraisalCoefficient;
                    //获取计算方法
                    string CalculationMethodtKey = "CalculationMethod" + uacFilter[j].CoefficientId;
                    double CalculationMethodValue = (int)uacFilter[j].CalculationMethod;
                    //给dtUser绑定值
                    dtUser.Rows[i][AppraisalTypeKey] = AppraisalTypeCountValue;
                    dtUser.Rows[i][AppraisalCoefficientKey] = AppraisalCoefficientValue;
                    dtUser.Rows[i][CalculationMethodtKey] = CalculationMethodValue;
                    //计算考核项系数 考核系数x次数x计算方式
                    yearBonusArray[j] = AppraisalTypeCountValue * AppraisalCoefficientValue * CalculationMethodValue;
                }
                dtUser.Rows[i]["AssessmentYear"] = cbxYear.Text;
                //结算实发年终奖
                double yearBonusAll = 0;
                for (int j = 0; j < yearBonusArray.Length; j++)
                {
                    yearBonusAll += yearBonusArray[j];
                }
                //计算实发年终奖
                double yearBonus = (1 + yearBonusAll) * Convert.ToDouble(dtUser.Rows[i]["AppraisalBase"]);
                //有可能钱被扣光，如果为负数，则年终奖为0
                dtUser.Rows[i]["YearBonus"] = yearBonus < 0 ? 0 : yearBonus;
            }
            dgvUserAppraisal.AutoGenerateColumns = false;
            dgvUserAppraisal.DataSource = dtUser;
        }

        private void SetCol()
        {
            List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
            List<DataGridViewTextBoxColumn> columns = new List<DataGridViewTextBoxColumn>();
            foreach (var appraisalCoefficient in appraisalCoefficients)
            {
                columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = appraisalCoefficient.AppraisalType,
                    Name = "AppraisalType" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "AppraisalType" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Width = 88
                });
                columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "系数",
                    Name = "AppraisalCoefficient" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "AppraisalCoefficient" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Visible = false,
                    Width = 88
                });
                columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "计算方式",
                    Name = "CalculationMethod" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "CalculationMethod" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Visible = false,
                    Width = 88
                });
            }          
            columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "考核年度",
                Name = "AssessmentYear",
                DataPropertyName = "AssessmentYear",
                ReadOnly = true,
                Visible = true,
                Width = 166
            });
            columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "实发年终奖",
                Name = "YearBonus",
                DataPropertyName = "YearBonus",
                ReadOnly = true,
                Visible = true,
                Width = 166
            });
            dgvUserAppraisal.Columns.AddRange(columns.ToArray());
        }

        private void dgvUserAppraisal_MouseDown(object sender, MouseEventArgs e)
        {
            tsmEdit.Visible = false;
        }

        private void dgvUserAppraisal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    dgvUserAppraisal.ClearSelection();//清除选中的行
                    dgvUserAppraisal.Rows[e.RowIndex].Selected = true;
                }
            }
            tsmEdit.Visible = true;
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            string year = cbxYear.Text;
            int userId = (int)dgvUserAppraisal.SelectedRows[0].Cells["Id"].Value;
            FrmUserAppraisalEdit frmUserAppraisalEdit = new FrmUserAppraisalEdit(userId,year,binDgv);
            frmUserAppraisalEdit.ShowDialog();
        }
    }
}
