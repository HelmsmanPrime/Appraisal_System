namespace Appraisal_System
{
    partial class FrmUserAppraisal
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
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUserAppraisal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppraisalBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsUserAppraisal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).BeginInit();
            this.cmsUserAppraisal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "年份选择";
            // 
            // cbxYear
            // 
            this.cbxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(891, 43);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 26);
            this.cbxYear.TabIndex = 1;
            this.cbxYear.Text = "2018";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "年份";
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
            this.AppraisalBase});
            this.dgvUserAppraisal.ContextMenuStrip = this.cmsUserAppraisal;
            this.dgvUserAppraisal.Location = new System.Drawing.Point(12, 162);
            this.dgvUserAppraisal.MultiSelect = false;
            this.dgvUserAppraisal.Name = "dgvUserAppraisal";
            this.dgvUserAppraisal.ReadOnly = true;
            this.dgvUserAppraisal.RowHeadersWidth = 62;
            this.dgvUserAppraisal.RowTemplate.Height = 30;
            this.dgvUserAppraisal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAppraisal.Size = new System.Drawing.Size(1129, 459);
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
            this.BaseType.HeaderText = "身份";
            this.BaseType.MinimumWidth = 8;
            this.BaseType.Name = "BaseType";
            this.BaseType.ReadOnly = true;
            this.BaseType.Width = 150;
            // 
            // AppraisalBase
            // 
            this.AppraisalBase.DataPropertyName = "AppraisalBase";
            this.AppraisalBase.HeaderText = "年终奖基数";
            this.AppraisalBase.MinimumWidth = 8;
            this.AppraisalBase.Name = "AppraisalBase";
            this.AppraisalBase.ReadOnly = true;
            this.AppraisalBase.Width = 150;
            // 
            // cmsUserAppraisal
            // 
            this.cmsUserAppraisal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsUserAppraisal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit});
            this.cmsUserAppraisal.Name = "cmsUserAppraisal";
            this.cmsUserAppraisal.Size = new System.Drawing.Size(241, 67);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(240, 30);
            this.tsmEdit.Text = "编辑考核项";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // FrmUserAppraisal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 647);
            this.Controls.Add(this.dgvUserAppraisal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserAppraisal";
            this.Text = "FrmUserAppraisal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserAppraisal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).EndInit();
            this.cmsUserAppraisal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUserAppraisal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppraisalBase;
        private System.Windows.Forms.ContextMenuStrip cmsUserAppraisal;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
    }
}