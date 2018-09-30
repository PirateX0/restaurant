namespace RpCater
{
    partial class FrmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember));
            this.btnInsertMember = new System.Windows.Forms.Button();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnSelectMember = new System.Windows.Forms.Button();
            this.cmbRecycle = new System.Windows.Forms.ComboBox();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.msgMember = new MsgDiv();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertMember
            // 
            this.btnInsertMember.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsertMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertMember.Location = new System.Drawing.Point(12, 13);
            this.btnInsertMember.Name = "btnInsertMember";
            this.btnInsertMember.Size = new System.Drawing.Size(75, 23);
            this.btnInsertMember.TabIndex = 0;
            this.btnInsertMember.Text = "会员办理";
            this.btnInsertMember.UseVisualStyleBackColor = false;
            this.btnInsertMember.Click += new System.EventHandler(this.btnInsertMember_Click);
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgvMember.Location = new System.Drawing.Point(12, 85);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.RowHeadersVisible = false;
            this.dgvMember.RowTemplate.Height = 23;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(553, 179);
            this.dgvMember.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MemberId";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MemName";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MemMobilePhone";
            this.Column3.HeaderText = "电话";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MemAddress";
            this.Column4.HeaderText = "地址";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MemTypeName";
            this.Column5.HeaderText = "类别";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MemNum";
            this.Column6.HeaderText = "编号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MemGender";
            this.Column7.HeaderText = "性别";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MemDiscount";
            this.Column8.HeaderText = "折扣";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MemMoney";
            this.Column9.HeaderText = "金额";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SubTime";
            this.Column10.HeaderText = "注册时间";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MemIntegral";
            this.Column11.HeaderText = "积分";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "MemEndTime";
            this.Column12.HeaderText = "有效期";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "MemBirthday";
            this.Column13.HeaderText = "生日";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMember.Location = new System.Drawing.Point(102, 13);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMember.TabIndex = 0;
            this.btnUpdateMember.Text = "信息修改";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.Location = new System.Drawing.Point(192, 13);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMember.TabIndex = 0;
            this.btnDeleteMember.Text = "注销会员";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMember.Location = new System.Drawing.Point(282, 13);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(75, 23);
            this.btnSelectMember.TabIndex = 0;
            this.btnSelectMember.Text = "查询会员";
            this.btnSelectMember.UseVisualStyleBackColor = false;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // cmbRecycle
            // 
            this.cmbRecycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecycle.FormattingEnabled = true;
            this.cmbRecycle.Items.AddRange(new object[] {
            "会员",
            "已注销"});
            this.cmbRecycle.Location = new System.Drawing.Point(280, 47);
            this.cmbRecycle.Name = "cmbRecycle";
            this.cmbRecycle.Size = new System.Drawing.Size(77, 20);
            this.cmbRecycle.TabIndex = 2;
            this.cmbRecycle.SelectedIndexChanged += new System.EventHandler(this.cmbRecycle_SelectedIndexChanged);
            // 
            // txtMemName
            // 
            this.txtMemName.Location = new System.Drawing.Point(465, 13);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(100, 21);
            this.txtMemName.TabIndex = 3;
            // 
            // msgMember
            // 
            this.msgMember.AutoSize = true;
            this.msgMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.msgMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgMember.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msgMember.ForeColor = System.Drawing.Color.Red;
            this.msgMember.Location = new System.Drawing.Point(320, 190);
            this.msgMember.MaximumSize = new System.Drawing.Size(980, 525);
            this.msgMember.Name = "msgMember";
            this.msgMember.Padding = new System.Windows.Forms.Padding(7);
            this.msgMember.Size = new System.Drawing.Size(86, 31);
            this.msgMember.TabIndex = 1;
            this.msgMember.Text = "msgDiv1";
            this.msgMember.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(192, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "表格内容：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(12, 47);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "导出Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.Control;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(102, 47);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "导入Excel";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(373, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "会员姓名：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(581, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgMember);
            this.Controls.Add(this.txtMemName);
            this.Controls.Add(this.cmbRecycle);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.btnSelectMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.btnInsertMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMember";
            this.Text = "会员信息";
            this.Load += new System.EventHandler(this.FrmMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertMember;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnSelectMember;
        private System.Windows.Forms.ComboBox cmbRecycle;
        private System.Windows.Forms.TextBox txtMemName;
        private MsgDiv msgMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label3;
    }
}