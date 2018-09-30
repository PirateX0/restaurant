using RpCater.BLL;
using RpCater.model;
using RpCater.Model;
using System;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmCategoryAddOrModify : Form
    {
        private static FrmCategoryAddOrModify instance;
        private CategoryInfo oldCategory;
        private HandleStatus status;

        private FrmCategoryAddOrModify()
        {
            InitializeComponent();
        }

        private FrmCategoryAddOrModify(HandleStatus status, CategoryInfo category)
            : this()
        {
            this.status = status;
            this.oldCategory = category;
        }

        public static FrmCategoryAddOrModify Single(HandleStatus status, CategoryInfo category)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCategoryAddOrModify(status, category);
            }
            return instance;
        }

        private void Bind()
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                return;
            }
            CategoryInfo newCategory = new CategoryInfo();
            newCategory.CName = txtCName.Text;
            newCategory.CNum = txtCNum.Text;
            newCategory.CRemark = txtCRemark.Text;

            CategoryInfoBLL categorybll = new CategoryInfoBLL();
            int i = 0;
            //插入时，给未在窗体显示的值添加默认值
            if (status == HandleStatus.Insert)
            {
                newCategory.DelFlag = 0;
                newCategory.SubBy = 1;
                newCategory.SubTime = DateTime.Now;

                i = categorybll.add(newCategory);
            }
            //更新时，将未在窗体显示的值赋予原来的值
            if (status == HandleStatus.Update)
            {
                newCategory.CId = oldCategory.CId;
                newCategory.DelFlag = oldCategory.DelFlag;
                newCategory.SubBy = oldCategory.SubBy;
                newCategory.SubTime = oldCategory.SubTime;

                i = categorybll.update(newCategory);
            }
            string msg = i > 0 ? "操作成功" : "操作失败";
            md.MsgDivShow(msg, 1, Bind);
        }

        private void FrmCategoryAddOrModify_Load(object sender, EventArgs e)
        {
            if (status == HandleStatus.Update)
            {
                txtCName.Text = oldCategory.CName;
                txtCNum.Text = oldCategory.CNum;
                txtCRemark.Text = oldCategory.CRemark;
            }
        }

        private bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txtCName.Text))
            {
                md.MsgDivShow("商品类别不能为空", 1);
                return true;
            }
            if (string.IsNullOrEmpty(txtCNum.Text))
            {
                md.MsgDivShow("商品编号不能为空", 1);
                return true;
            }
            if (string.IsNullOrEmpty(txtCRemark.Text))
            {
                md.MsgDivShow("商品备注不能为空", 1);
                return true;
            }
            return false;
        }
    }
}