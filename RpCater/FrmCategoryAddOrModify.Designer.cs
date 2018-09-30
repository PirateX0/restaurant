namespace RpCater
{
    partial class FrmCategoryAddOrModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoryAddOrModify));
            this.md = new MsgDiv();
            this.labId = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCRemark = new System.Windows.Forms.TextBox();
            this.txtCNum = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // md
            // 
            this.md.AutoSize = true;
            this.md.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.md.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.md.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.md.ForeColor = System.Drawing.Color.Red;
            this.md.Location = new System.Drawing.Point(30, 233);
            this.md.MaximumSize = new System.Drawing.Size(980, 525);
            this.md.Name = "md";
            this.md.Padding = new System.Windows.Forms.Padding(7);
            this.md.Size = new System.Drawing.Size(86, 31);
            this.md.TabIndex = 36;
            this.md.Text = "msgDiv1";
            this.md.Visible = false;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(75, 195);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(0, 12);
            this.labId.TabIndex = 44;
            this.labId.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOk.Location = new System.Drawing.Point(41, 190);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 43;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCRemark
            // 
            this.txtCRemark.Location = new System.Drawing.Point(128, 140);
            this.txtCRemark.Name = "txtCRemark";
            this.txtCRemark.Size = new System.Drawing.Size(100, 21);
            this.txtCRemark.TabIndex = 41;
            // 
            // txtCNum
            // 
            this.txtCNum.Location = new System.Drawing.Point(128, 91);
            this.txtCNum.Name = "txtCNum";
            this.txtCNum.Size = new System.Drawing.Size(100, 21);
            this.txtCNum.TabIndex = 42;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(128, 39);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 21);
            this.txtCName.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "商品备注";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "商品编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "商品类别";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.Location = new System.Drawing.Point(153, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmCategoryAddOrModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.md);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCRemark);
            this.Controls.Add(this.txtCNum);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoryAddOrModify";
            this.Text = "商品类别信息设置";
            this.Load += new System.EventHandler(this.FrmCategoryAddOrModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MsgDiv md;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtCRemark;
        private System.Windows.Forms.TextBox txtCNum;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}