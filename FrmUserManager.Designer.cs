namespace Appraisal_System
{
    partial class FrmUserManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkIsStop = new System.Windows.Forms.CheckBox();
            this.cbxBases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUserAppraisal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppraisalBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsUserManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStop = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).BeginInit();
            this.cmsUserManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.chkIsStop);
            this.groupBox1.Controls.Add(this.cbxBases);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1015, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSearch.Location = new System.Drawing.Point(749, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkIsStop
            // 
            this.chkIsStop.AutoSize = true;
            this.chkIsStop.Location = new System.Drawing.Point(575, 41);
            this.chkIsStop.Name = "chkIsStop";
            this.chkIsStop.Size = new System.Drawing.Size(88, 22);
            this.chkIsStop.TabIndex = 4;
            this.chkIsStop.Text = "已停职";
            this.chkIsStop.UseVisualStyleBackColor = true;
            // 
            // cbxBases
            // 
            this.cbxBases.FormattingEnabled = true;
            this.cbxBases.Location = new System.Drawing.Point(359, 38);
            this.cbxBases.Name = "cbxBases";
            this.cbxBases.Size = new System.Drawing.Size(140, 26);
            this.cbxBases.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "身份";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(98, 38);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(124, 28);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // dgvUserAppraisal
            // 
            this.dgvUserAppraisal.AllowUserToAddRows = false;
            this.dgvUserAppraisal.AllowUserToDeleteRows = false;
            this.dgvUserAppraisal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserAppraisal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAppraisal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.Sex,
            this.BaseType,
            this.AppraisalBase,
            this.IsDel});
            this.dgvUserAppraisal.ContextMenuStrip = this.cmsUserManager;
            this.dgvUserAppraisal.Location = new System.Drawing.Point(18, 146);
            this.dgvUserAppraisal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserAppraisal.MultiSelect = false;
            this.dgvUserAppraisal.Name = "dgvUserAppraisal";
            this.dgvUserAppraisal.ReadOnly = true;
            this.dgvUserAppraisal.RowHeadersWidth = 62;
            this.dgvUserAppraisal.RowTemplate.Height = 30;
            this.dgvUserAppraisal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAppraisal.Size = new System.Drawing.Size(1015, 512);
            this.dgvUserAppraisal.TabIndex = 1;
            this.dgvUserAppraisal.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserAppraisal_CellMouseDown);
            this.dgvUserAppraisal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvUserAppraisal_MouseDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 150;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.MinimumWidth = 8;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 150;
            // 
            // BaseType
            // 
            this.BaseType.DataPropertyName = "BaseType";
            this.BaseType.HeaderText = "基数类型";
            this.BaseType.MinimumWidth = 8;
            this.BaseType.Name = "BaseType";
            this.BaseType.ReadOnly = true;
            this.BaseType.Width = 150;
            // 
            // AppraisalBase
            // 
            this.AppraisalBase.DataPropertyName = "AppraisalBase";
            this.AppraisalBase.HeaderText = "基数";
            this.AppraisalBase.MinimumWidth = 8;
            this.AppraisalBase.Name = "AppraisalBase";
            this.AppraisalBase.ReadOnly = true;
            this.AppraisalBase.Width = 150;
            // 
            // IsDel
            // 
            this.IsDel.DataPropertyName = "IsDel";
            this.IsDel.HeaderText = "是否停职";
            this.IsDel.MinimumWidth = 8;
            this.IsDel.Name = "IsDel";
            this.IsDel.ReadOnly = true;
            this.IsDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsDel.Width = 150;
            // 
            // cmsUserManager
            // 
            this.cmsUserManager.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsUserManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.tsmEdit,
            this.tsmStart,
            this.tsmStop});
            this.cmsUserManager.Name = "cmsUserManager";
            this.cmsUserManager.Size = new System.Drawing.Size(241, 157);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(240, 30);
            this.tsmAdd.Text = "新建";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(240, 30);
            this.tsmEdit.Text = "编辑";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmStart
            // 
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.Size = new System.Drawing.Size(240, 30);
            this.tsmStart.Text = "启用";
            // 
            // tsmStop
            // 
            this.tsmStop.Name = "tsmStop";
            this.tsmStop.Size = new System.Drawing.Size(240, 30);
            this.tsmStop.Text = "停用";
            // 
            // FrmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 675);
            this.Controls.Add(this.dgvUserAppraisal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserManager";
            this.Text = "FrmUserManager";
            this.Load += new System.EventHandler(this.FrmUserManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).EndInit();
            this.cmsUserManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUserAppraisal;
        private System.Windows.Forms.CheckBox chkIsStop;
        private System.Windows.Forms.ComboBox cbxBases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip cmsUserManager;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmStart;
        private System.Windows.Forms.ToolStripMenuItem tsmStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppraisalBase;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDel;
    }
}