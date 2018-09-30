using RpCater.BLL;
using RpCater.model;
using RpCater.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmProductAddOrModify : Form
    {
        private static FrmProductAddOrModify instance;
        private ProductInfo oldProduct;
        private HandleStatus status;

        private FrmProductAddOrModify()
        {
            InitializeComponent();
        }

        private FrmProductAddOrModify(HandleStatus status, ProductInfo product)
            : this()
        {
            this.status = status;
            this.oldProduct = product;
        }

        public static FrmProductAddOrModify Single(HandleStatus status, ProductInfo product)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmProductAddOrModify(status, product);
            }
            return instance;
        }

        private void Bind()
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!IsNotEmpty())
            {
                return;
            }
            ProductInfoBLL proBll = new ProductInfoBLL();
            ProductInfo pro = new ProductInfo();
            int i = 0;
            pro.CId = Convert.ToInt32(cmbCategory.SelectedValue);//获取选择的类别
            pro.ProCost = Convert.ToDouble(txtCost.Text);//价格
            pro.ProName = txtName.Text;//名字
            pro.ProNum = txtNum.Text;//编号
            pro.ProPrice = Convert.ToDouble(txtPrice.Text);//实际的价格
            pro.ProSpell = txtSpell.Text;//拼音
            pro.ProStock = Convert.ToInt32(txtStock.Text);
            pro.ProUnit = txtUnit.Text;//单位
            pro.Remark = txtRemark.Text; ;//备注
            if (status == HandleStatus.Insert)
            {
                pro.DelFlag = 0;
                pro.SubBy = 1;
                pro.SubTime = System.DateTime.Now;//当前时间

                i = proBll.add(pro);
            }
            if (status == HandleStatus.Update)
            {
                pro.ProId = oldProduct.ProId;
                pro.DelFlag = oldProduct.DelFlag;
                pro.SubBy = oldProduct.SubBy;
                pro.SubTime = oldProduct.SubTime;

                i = proBll.update(pro);
            }
            string msg = i > 0 ? "操作成功" : "操作失败";
            md.MsgDivShow(msg, 1, Bind);
        }

        private void FrmProductAddOrModify_Load(object sender, EventArgs e)
        {
            LoadCategory();
            if (status == HandleStatus.Update)
            {
                //在输入的时候已经保证为非空，所以输出的时候不用再检验
                txtCost.Text = oldProduct.ProCost.ToString();//进价
                txtName.Text = oldProduct.ProName;//名字
                txtNum.Text = oldProduct.ProNum;//编号
                txtPrice.Text = oldProduct.ProPrice.ToString();//价格
                txtRemark.Text = oldProduct.Remark;//备注
                txtSpell.Text = oldProduct.ProSpell;//拼音
                txtStock.Text = oldProduct.ProStock.ToString();//库存
                txtUnit.Text = oldProduct.ProUnit;//单位

                cmbCategory.SelectedValue = oldProduct.CId;//商品类别---显示
            }
        }

        private bool IsNotEmpty()
        {
            if (string.IsNullOrEmpty(txtCost.Text))
            {
                md.MsgDivShow("进价不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                md.MsgDivShow("名字不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtNum.Text))
            {
                md.MsgDivShow("编号不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                md.MsgDivShow("实际价格不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtRemark.Text))
            {
                md.MsgDivShow("备注不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtSpell.Text))
            {
                md.MsgDivShow("拼音不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                md.MsgDivShow("库存不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtUnit.Text))
            {
                md.MsgDivShow("单位不能为空");
                return false;
            }
            if (cmbCategory.SelectedIndex == 0)
            {
                md.MsgDivShow("请选中类别", 1);
                return false;
            }
            return true;
        }

        private void LoadCategory()
        {
            CategoryInfoBLL categoryBll = new CategoryInfoBLL();
            List<CategoryInfo> list = categoryBll.GetAllCategoryInfoByDelFlag(0);
            list.Insert(0, new CategoryInfo { CName = "请选择", CId = -1 });
            cmbCategory.DataSource = list;
            cmbCategory.DisplayMember = "CName";
            cmbCategory.ValueMember = "CId";
        }
    }
}