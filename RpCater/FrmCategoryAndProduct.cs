using RpCater.BLL;
using RpCater.model;
using RpCater.Model;
using System;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmCategoryAndProduct : Form
    {
        private static FrmCategoryAndProduct instance;

        private FrmCategoryAndProduct()
        {
            InitializeComponent();
        }

        public static FrmCategoryAndProduct Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmCategoryAndProduct();
                }
                return instance;
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            ShowFrmCategoryAddOrModify(HandleStatus.Insert, null);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ShowFrmProductAddOrModify(HandleStatus.Insert, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //判断是否选择了删除的对象
            if (dgvProduct.SelectedRows.Count <= 0)
            {
                md1.MsgDivShow("请选择要注销的产品", 1);
                return;
            }
            //提示用户是否真的删除
            if (MessageBox.Show("亲，真的要注销这个产品吗？", "注销提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //删除
                ProductInfoBLL pbll = new ProductInfoBLL();
                ProductInfo p = (ProductInfo)dgvProduct.SelectedRows[0].DataBoundItem;
                ;
                string msg = pbll.SoftDeleteProductInfoByProId((int)p.ProId) > 0 ? "操作成功" : "操作失败";
                md1.MsgDivShow(msg, 1);
                //刷新
                LoadProduct();
                return;
            }
            //提示取消删除
            md1.MsgDivShow("您已经取消了注销", 1);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string msg = null;
            if (dgvCategory.SelectedRows.Count <= 0)
            {
                md.MsgDivShow("请选择要注销的商品类别", 1);
                return;
            }
            if (MessageBox.Show("亲，真的要注销这个商品类别吗？", "注销提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //判断该类别下是否有产品，提示删除吗？
                ProductInfoBLL pbll = new ProductInfoBLL();
                CategoryInfoBLL cbll = new CategoryInfoBLL();
                CategoryInfo c = (CategoryInfo)dgvCategory.SelectedRows[0].DataBoundItem;
                if (pbll.GetProductInfoCountByCid((int)c.CId) > 0)
                {
                    if (MessageBox.Show("该类别下有若干产品，产品会随之一起注销，真的要注销吗？", "注销提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        msg = cbll.SoftDeleteCategoryInfoByCId((int)c.CId) > 0 ? "操作成功" : "操作失败";
                        md.MsgDivShow(msg, 1);
                        //刷新
                        LoadCategory();
                        LoadProduct();
                        return;
                    }
                    md.MsgDivShow("您已经取消了注销", 1);
                    return;
                }
                //无产品，删除
                msg = cbll.SoftDeleteCategoryInfoByCId((int)c.CId) > 0 ? "操作成功" : "操作失败";
                md.MsgDivShow(msg, 1);
                //刷新
                LoadCategory();
                return;
            }
            //提示取消删除
            md.MsgDivShow("您已经取消了注销", 1);
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count <= 0)
            {
                md.MsgDivShow("请选择要修改的商品类别", 1);
                return;
            }
            CategoryInfo category = (CategoryInfo)(dgvCategory.SelectedRows[0].DataBoundItem);
            ShowFrmCategoryAddOrModify(HandleStatus.Update, category);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count <= 0)
            {
                md1.MsgDivShow("请选择要修改的产品", 1);
                return;
            }
            ProductInfo product = (ProductInfo)(dgvProduct.SelectedRows[0].DataBoundItem);
            ShowFrmProductAddOrModify(HandleStatus.Update, product);
        }

        private void fcam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            LoadCategory();
            LoadProduct();
        }

        private void FrmCategoryAndProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategory();
        }

        private void LoadCategory()
        {
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.DataSource = new CategoryInfoBLL().GetAllCategoryInfoByDelFlag(0);
            dgvCategory.ClearSelection();
        }

        private void LoadProduct()
        {
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = new ProductInfoBLL().GetAllProductInfoByDelFlag(0);
            dgvProduct.ClearSelection();
        }

        private void ShowFrmCategoryAddOrModify(HandleStatus status, CategoryInfo category)
        {
            this.Hide();
            FrmCategoryAddOrModify fcam = FrmCategoryAddOrModify.Single(status, category);
            fcam.FormClosed += fcam_FormClosed;
            fcam.Show();
        }

        private void ShowFrmProductAddOrModify(HandleStatus status, ProductInfo product)
        {
            this.Hide();
            FrmProductAddOrModify fcam = FrmProductAddOrModify.Single(status, product);
            fcam.FormClosed += fcam_FormClosed;
            fcam.Show();
        }
    }
}