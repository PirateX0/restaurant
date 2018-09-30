namespace RpCater
{
    partial class FrmAddConsumption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddConsumption));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labOrderId = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.md = new MsgDiv();
            this.btnDeleteRorderPro = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.labSumMoney = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labDeskName = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvROrderProduct = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROrderProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvROrderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.labOrderId);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(410, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 603);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // labOrderId
            // 
            this.labOrderId.AutoSize = true;
            this.labOrderId.Location = new System.Drawing.Point(16, 22);
            this.labOrderId.Name = "labOrderId";
            this.labOrderId.Size = new System.Drawing.Size(0, 12);
            this.labOrderId.TabIndex = 1;
            this.labOrderId.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dgvROrderProduct);
            this.groupBox8.Controls.Add(this.md);
            this.groupBox8.Controls.Add(this.btnDeleteRorderPro);
            this.groupBox8.Location = new System.Drawing.Point(15, 117);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(504, 472);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            // 
            // md
            // 
            this.md.AutoSize = true;
            this.md.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.md.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.md.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.md.ForeColor = System.Drawing.Color.Red;
            this.md.Location = new System.Drawing.Point(119, 14);
            this.md.MaximumSize = new System.Drawing.Size(980, 525);
            this.md.Name = "md";
            this.md.Padding = new System.Windows.Forms.Padding(7);
            this.md.Size = new System.Drawing.Size(86, 31);
            this.md.TabIndex = 1;
            this.md.Text = "msgDiv1";
            this.md.Visible = false;
            // 
            // btnDeleteRorderPro
            // 
            this.btnDeleteRorderPro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeleteRorderPro.Location = new System.Drawing.Point(18, 22);
            this.btnDeleteRorderPro.Name = "btnDeleteRorderPro";
            this.btnDeleteRorderPro.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRorderPro.TabIndex = 0;
            this.btnDeleteRorderPro.Text = "退菜";
            this.btnDeleteRorderPro.UseVisualStyleBackColor = false;
            this.btnDeleteRorderPro.Click += new System.EventHandler(this.btnDeleteRorderPro_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.labCount);
            this.groupBox7.Controls.Add(this.labSumMoney);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(15, 63);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(505, 52);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "元";
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(253, 22);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(11, 12);
            this.labCount.TabIndex = 3;
            this.labCount.Text = "0";
            // 
            // labSumMoney
            // 
            this.labSumMoney.AutoSize = true;
            this.labSumMoney.Location = new System.Drawing.Point(72, 23);
            this.labSumMoney.Name = "labSumMoney";
            this.labSumMoney.Size = new System.Drawing.Size(11, 12);
            this.labSumMoney.TabIndex = 2;
            this.labSumMoney.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "点单数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "合计金额";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.labDeskName);
            this.groupBox6.Location = new System.Drawing.Point(15, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(504, 52);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "餐桌编号";
            // 
            // labDeskName
            // 
            this.labDeskName.AutoSize = true;
            this.labDeskName.Location = new System.Drawing.Point(71, 24);
            this.labDeskName.Name = "labDeskName";
            this.labDeskName.Size = new System.Drawing.Size(77, 12);
            this.labDeskName.TabIndex = 0;
            this.labDeskName.Text = "顾客消费清单";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProPrice";
            this.Column4.HeaderText = "单价";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 55;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProSpell";
            this.Column5.HeaderText = "拼音";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProUnit";
            this.Column3.HeaderText = "单位";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 55;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "消费项目(清单)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 3);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 20;
            this.dgvProduct.RowTemplate.Height = 23;
            this.dgvProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(339, 402);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ProId";
            this.Column6.HeaderText = "商品id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProNum";
            this.Column1.HeaderText = "项目编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProName";
            this.Column2.HeaderText = "项目名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tvCategory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "消费项目(列表)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tvCategory
            // 
            this.tvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCategory.Location = new System.Drawing.Point(3, 3);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.Size = new System.Drawing.Size(355, 364);
            this.tvCategory.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl1);
            this.groupBox5.Location = new System.Drawing.Point(9, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 472);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "项目搜索";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtCount);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(9, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 105);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "（拼音/编号）";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(86, 64);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(122, 21);
            this.txtCount.TabIndex = 3;
            this.txtCount.Text = "1";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 21);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "消费数量";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 604);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // dgvROrderProduct
            // 
            this.dgvROrderProduct.AllowUserToAddRows = false;
            this.dgvROrderProduct.AllowUserToDeleteRows = false;
            this.dgvROrderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvROrderProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ROrderProId,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgvROrderProduct.Location = new System.Drawing.Point(18, 60);
            this.dgvROrderProduct.Name = "dgvROrderProduct";
            this.dgvROrderProduct.ReadOnly = true;
            this.dgvROrderProduct.RowHeadersVisible = false;
            this.dgvROrderProduct.RowTemplate.Height = 23;
            this.dgvROrderProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvROrderProduct.Size = new System.Drawing.Size(470, 392);
            this.dgvROrderProduct.TabIndex = 0;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "SubTime";
            this.Column13.HeaderText = "点菜时间";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "CName";
            this.Column12.HeaderText = "项目类别";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "ProSumPrice";
            this.Column11.HeaderText = "金额";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 55;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ProUnit";
            this.Column10.HeaderText = "单位";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 55;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "UnitCount";
            this.Column9.HeaderText = "数量";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 55;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ProPrice";
            this.Column8.HeaderText = "单价";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 55;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ProName";
            this.Column7.HeaderText = "项目名称";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // ROrderProId
            // 
            this.ROrderProId.DataPropertyName = "ROrderProId";
            this.ROrderProId.HeaderText = "中间表id";
            this.ROrderProId.Name = "ROrderProId";
            this.ROrderProId.ReadOnly = true;
            this.ROrderProId.Visible = false;
            this.ROrderProId.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "项";
            // 
            // FrmAddConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(941, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddConsumption";
            this.Text = "增加消费";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddConsumption_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddConsumption_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvROrderProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labOrderId;
        private System.Windows.Forms.GroupBox groupBox8;
        private MsgDiv md;
        private System.Windows.Forms.Button btnDeleteRorderPro;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Label labSumMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labDeskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvROrderProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROrderProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Label label1;

    }
}