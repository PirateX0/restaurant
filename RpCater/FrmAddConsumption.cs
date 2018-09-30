using RpCater.BLL;
using RpCater.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmAddConsumption : Form
    {
        private static FrmAddConsumption instance;
        private readonly string deskName;
        private readonly int orderId;

        private FrmAddConsumption()
        {
            InitializeComponent();
        }

        private FrmAddConsumption(int orderId, string deskName)
            : this()
        {
            this.orderId = orderId;
            this.deskName = deskName;
        }

        public static FrmAddConsumption Single(int orderID, string deskName)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmAddConsumption(orderID, deskName);
            }
            return instance;
        }

        private void btnDeleteRorderPro_Click(object sender, EventArgs e)
        {
            //删除条件
            if (dgvROrderProduct.SelectedRows.Count <= 0)
            {
                md.MsgDivShow("亲，请选择要退的菜肴", 1);
                return;
            }
            //根据中间表id，设置中间表id对应的delflag为0
            //由于我绑定的是datatable，所以不能强转为rop对象。
            //int ropId = (int)((R_Order_Product)dgvROrderProduct.SelectedRows[0].DataBoundItem).ROrderProId;
            int ropId = (int)(dgvROrderProduct.SelectedRows[0].Cells["ROrderProId"].Value);
            md.MsgDivShow(new R_Order_ProductBLL().SoftDeleteByROrderProductId(ropId) ? "操作成功" : "操作失败", 1);
            //刷新
            LoadDgvROrderProduct();
            LoadProductCountAndSumPrice();
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //对数据库操作
            //对R_Order_Product表进行插入操作
            int count = 0;
            if (string.IsNullOrEmpty(txtCount.Text))
            {
                count = 1;
            }
            else if (!int.TryParse(txtCount.Text, out count) || txtCount.Text == "0")
            {
                md.MsgDivShow("亲，请输入正确的数量", 1);
                return;
            }
            R_Order_Product rop = new R_Order_Product();
            rop.DelFlag = 0;
            rop.OrderId = orderId;
            rop.ProId = ((ProductInfo)dgvProduct.SelectedRows[0].DataBoundItem).ProId;
            rop.SubTime = DateTime.Now;
            rop.UnitCount = count;
            md.MsgDivShow(new R_Order_ProductBLL().OrderFood(rop) ? "操作成功" : "操作失败", 1);
            //在右边的dgv显示点的菜
            LoadDgvROrderProduct();
            //显示金额和数量
            LoadProductCountAndSumPrice();
        }

        private void FrmAddConsumption_FormClosed(object sender, FormClosedEventArgs e)
        {
            //保存合计金额
            //我感觉1.每次关闭都会保存BeginTime，这本身是个逻辑bug；2.记录客人每次开单和结账的时间就可以了，BeginTime有点鸡肋
            //所以没有保存BeginTime

            //记得加判断啊
            if (string.IsNullOrEmpty(labSumMoney.Text))
            {
                return;
            }
            new OrderInfoBLL().UpdateOrderMoney(orderId, Convert.ToDouble(labSumMoney.Text));
        }

        private void FrmAddConsumption_Load(object sender, EventArgs e)
        {
            labDeskName.Text = deskName;
            LoadDgvProduct();
            LoadTvCategory();
            LoadDgvROrderProduct();
            LoadProductCountAndSumPrice();
        }

        private void LoadCnode(TreeNodeCollection tnc, int cId)
        {
            List<ProductInfo> pros = new ProductInfoBLL().GetAliveProductInfosByCid(cId);
            foreach (ProductInfo pro in pros)
            {
                tnc.Add(pro.ProName + "：" + pro.ProPrice + "元");
            }
        }

        private void LoadDgvProduct()
        {
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = new ProductInfoBLL().GetAllProductInfoByDelFlag(0);
            dgvProduct.ClearSelection();
        }

        private void LoadDgvProduct(DataTable table)
        {
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = table;
            dgvProduct.ClearSelection();
        }

        private void LoadDgvROrderProduct()
        {
            dgvROrderProduct.AutoGenerateColumns = false;
            dgvROrderProduct.DataSource = new R_Order_ProductBLL().GetROrderProductByOrderId(orderId);
            dgvROrderProduct.ClearSelection();
        }

        private void LoadProductCountAndSumPrice()
        {
            DataTable table = new R_Order_ProductBLL().GetProductCountAndSumPriceByOrderId(orderId);
            labCount.Text = table.Rows[0]["ProductCount"].ToString();
            labSumMoney.Text = string.IsNullOrEmpty(table.Rows[0]["SumPrice"].ToString()) ? "0" : table.Rows[0]["SumPrice"].ToString();
        }

        private void LoadTvCategory()
        {
            List<CategoryInfo> categories = new CategoryInfoBLL().GetAllCategoryInfoByDelFlag(0);
            foreach (CategoryInfo cat in categories)
            {
                TreeNode cNode = tvCategory.Nodes.Add(cat.CName);
                LoadCnode(cNode.Nodes, (int)cat.CId);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDgvProduct(new ProductInfoBLL().GetProductInfosByLikeProSpellOrProNum(txtSearch.Text));
        }
    }
}