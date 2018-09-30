using RpCater.BLL;
using RpCater.model;
using RpCater.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmGuestPay : Form
    {
        private static FrmGuestPay instance;
        private int deskId;
        private int orderId;
        private string deskNum;

        private FrmGuestPay()
        {
            InitializeComponent();
        }

        private FrmGuestPay(int deskId, string deskNum, int orderId)
            : this()
        {
            this.deskId = deskId;
            this.deskNum = deskNum;
            this.orderId = orderId;
        }

        public static FrmGuestPay Single(int deskId, string deskNum, int orderId)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmGuestPay(deskId, deskNum, orderId);
            }
            return instance;
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            PayTheBillResult payTheBillResult = new PayTheBillResult();

            switch (IsUsingMemMoney())
            {
                case UseStatus.Use: payTheBillResult.IsUsingMemMoney = true; break;
                case UseStatus.DoNotUse: payTheBillResult.IsUsingMemMoney = false; break;
                case UseStatus.Error: return;
            }

            UpdatePayTheBillResult(payTheBillResult);

            ShowResult(payTheBillResult);
        }

        private void cmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            //会员
            if (cmbMember.SelectedIndex != 0)
            {
                MemberInfo member = cmbMember.SelectedItem as MemberInfo;
                lblDisCount.Text = Convert.ToString(member.MemDiscount);
                labyuMoney.Text = member.MemMoney.ToString();
                lblCheckMoney.Text = Convert.ToString(Convert.ToDouble(labMoney.Text) * 0.1 * member.MemDiscount);

                txtMoney.ReadOnly = false;
                return;
            }
            //非会员：请选择
            lblDisCount.Text = "0";
            labyuMoney.Text = "0";
            lblCheckMoney.Text = labMoney.Text;

            txtMoney.Text = "0";
            txtMoney.ReadOnly = true;
        }

        private void FrmGuestPay_Load(object sender, EventArgs e)
        {
            labDeskName.Text = deskNum;
            labOrderId.Text = orderId.ToString();
            labMoney.Text = Convert.ToString(((OrderInfo)new OrderInfoBLL().get(orderId)).OrderMoney);
            lblCheckMoney.Text = labMoney.Text;
            LoadCmbMemBer();
            LoadDgvROrderProduct();
        }

        private UseStatus IsUsingMemMoney()
        {
            if (cmbMember.SelectedIndex == 0)
            {
                return UseStatus.DoNotUse;
            }
            if (string.IsNullOrEmpty(txtMoney.Text))
            {
                return UseStatus.DoNotUse;
            }
            if (Convert.ToDouble(txtMoney.Text) > Convert.ToDouble(labyuMoney.Text))
            {
                md.MsgDivShow("亲，刷卡金额不能大于卡内余额", 1);
                return UseStatus.Error;
            }
            if (Convert.ToDouble(txtMoney.Text) > Convert.ToDouble(lblCheckMoney.Text))
            {
                md.MsgDivShow("亲，刷卡金额不能大于结账金额", 1);
                return UseStatus.Error;
            }
            return UseStatus.Use;
        }

        private void LoadCmbMemBer()
        {
            List<MemberInfo> members = new MemberInfoBLL().GetAllMemberInfoByDelFlag(0);
            members.Insert(0, new MemberInfo { MemName = "请选择", MemberId = -1 });
            cmbMember.DataSource = members;
            cmbMember.DisplayMember = "MemName";
            cmbMember.ValueMember = "MemberId";
        }

        private void LoadDgvROrderProduct()
        {
            dgvROrderProduct.AutoGenerateColumns = false;
            dgvROrderProduct.DataSource = new R_Order_ProductBLL().GetROrderProductByOrderId(orderId);
            dgvROrderProduct.ClearSelection();
        }

        private void ShowResult(PayTheBillResult payTheBillResult)
        {
            if (payTheBillResult.UpdateDeskInfoResult && payTheBillResult.UpdateOrderInfoResult && payTheBillResult.UpdateROPResult && (payTheBillResult.IsUsingMemMoney ? payTheBillResult.UpdateMemberInfoResult : true))
            {
                md.MsgDivShow("结账成功", 1, Bind);
                return;
            }
            md.MsgDivShow("结账失败，请联系程序员大龙", 1);
        }

        private void UpdatePayTheBillResult(PayTheBillResult payTheBillResult)
        {
            payTheBillResult.UpdateOrderInfoResult = TryUpdateOrderInfo();
            payTheBillResult.UpdateDeskInfoResult = TryUpdateDeskInfo();
            //如果没有点菜，不用更新rop表，直接返回true
            payTheBillResult.UpdateROPResult = dgvROrderProduct.RowCount == 0 ? true : TryUpdateROP();
            payTheBillResult.UpdateMemberInfoResult = TryUpdateMemberInfo(payTheBillResult.IsUsingMemMoney);
        }

        private bool TryUpdateDeskInfo()
        {
            return new DeskInfoBLL().UpdateDeskInfoStateByDeskIdAndState(this.deskId, (int)DeskStatus.Available);
        }

        private bool TryUpdateMemberInfo(bool isUsingMemMoney)
        {
            if (isUsingMemMoney)
            {
                MemberInfo member = (MemberInfo)cmbMember.SelectedItem;
                member.MemMoney = (float)(Convert.ToDouble(labyuMoney.Text) - Convert.ToDouble(txtMoney.Text));
                return new MemberInfoBLL().AddOrUpdateMemberInfo(member, HandleStatus.Update);
            }
            return false;
        }

        private bool TryUpdateOrderInfo()
        {
            OrderInfoBLL orderBll = new OrderInfoBLL();
            OrderInfo order = orderBll.get(this.orderId);
            order.EndTime = DateTime.Now;
            order.OrderMoney = Convert.ToDouble(lblCheckMoney.Text);
            order.OrderState = (int)OrderStatus.Checked;
            if (cmbMember.SelectedIndex != 0)
            {
                MemberInfo member = (MemberInfo)cmbMember.SelectedItem;
                order.OrderMemberId = member.MemberId;
                order.DisCount = member.MemDiscount;
            }
            return orderBll.update(order);
        }

        private bool TryUpdateROP()
        {
            return new R_Order_ProductBLL().UpdateROPDelFlagByOrderId(this.orderId);
        }

        private void Bind()
        {
            this.Close();
        }
    }
}