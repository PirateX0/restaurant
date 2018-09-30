namespace RpCater
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCategoryOrProduct = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnGuestPay = new System.Windows.Forms.Button();
            this.btnAddConsumption = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.md = new MsgDiv();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.btnCategoryOrProduct);
            this.splitContainer1.Panel1.Controls.Add(this.btnRoom);
            this.splitContainer1.Panel1.Controls.Add(this.btnMember);
            this.splitContainer1.Panel1.Controls.Add(this.btnGuestPay);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddConsumption);
            this.splitContainer1.Panel1.Controls.Add(this.btnBilling);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(744, 408);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnCategoryOrProduct
            // 
            this.btnCategoryOrProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnCategoryOrProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryOrProduct.Location = new System.Drawing.Point(28, 333);
            this.btnCategoryOrProduct.Name = "btnCategoryOrProduct";
            this.btnCategoryOrProduct.Size = new System.Drawing.Size(75, 46);
            this.btnCategoryOrProduct.TabIndex = 0;
            this.btnCategoryOrProduct.Text = "商品管理";
            this.btnCategoryOrProduct.UseVisualStyleBackColor = false;
            this.btnCategoryOrProduct.Click += new System.EventHandler(this.btnCategoryOrProduct_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.SystemColors.Control;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Location = new System.Drawing.Point(28, 272);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(75, 46);
            this.btnRoom.TabIndex = 0;
            this.btnRoom.Text = "房间设置";
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.Control;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Location = new System.Drawing.Point(28, 211);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(75, 46);
            this.btnMember.TabIndex = 0;
            this.btnMember.Text = "会员管理";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnGuestPay
            // 
            this.btnGuestPay.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuestPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestPay.Location = new System.Drawing.Point(28, 150);
            this.btnGuestPay.Name = "btnGuestPay";
            this.btnGuestPay.Size = new System.Drawing.Size(75, 46);
            this.btnGuestPay.TabIndex = 0;
            this.btnGuestPay.Text = "上帝结账";
            this.btnGuestPay.UseVisualStyleBackColor = false;
            this.btnGuestPay.Click += new System.EventHandler(this.btnGuestPay_Click);
            // 
            // btnAddConsumption
            // 
            this.btnAddConsumption.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddConsumption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConsumption.Location = new System.Drawing.Point(28, 89);
            this.btnAddConsumption.Name = "btnAddConsumption";
            this.btnAddConsumption.Size = new System.Drawing.Size(75, 46);
            this.btnAddConsumption.TabIndex = 0;
            this.btnAddConsumption.Text = "增加消费";
            this.btnAddConsumption.UseVisualStyleBackColor = false;
            this.btnAddConsumption.Click += new System.EventHandler(this.btnAddConsumption_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.SystemColors.Control;
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilling.Location = new System.Drawing.Point(28, 28);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(75, 46);
            this.btnBilling.TabIndex = 0;
            this.btnBilling.Text = "顾客开单";
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.md);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabMain);
            this.splitContainer2.Size = new System.Drawing.Size(597, 408);
            this.splitContainer2.SplitterDistance = 122;
            this.splitContainer2.TabIndex = 0;
            // 
            // md
            // 
            this.md.AutoSize = true;
            this.md.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.md.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.md.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.md.ForeColor = System.Drawing.Color.Red;
            this.md.Location = new System.Drawing.Point(26, 66);
            this.md.MaximumSize = new System.Drawing.Size(980, 525);
            this.md.Name = "md";
            this.md.Padding = new System.Windows.Forms.Padding(7);
            this.md.Size = new System.Drawing.Size(102, 36);
            this.md.TabIndex = 2;
            this.md.Text = "msgDiv1";
            this.md.Visible = false;
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(597, 282);
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "空闲.png");
            this.imageList1.Images.SetKeyName(1, "就餐.png");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("幼圆", 20F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "我将眼泪流成天山上面的湖";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("幼圆", 20F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(244, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "让你疲倦时能够扎营停驻";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 408);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "如鹏餐饮系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCategoryOrProduct;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnGuestPay;
        private System.Windows.Forms.Button btnAddConsumption;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.ImageList imageList1;
        private MsgDiv md;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}