using RpCater.BLL;
using RpCater.model;
using System;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmBilling : Form
    {
        private static FrmBilling instance;
        private FrmMain main;
        private int newOrderId;
        private DeskInfo oldDesk;
        private RoomInfo oldRoom;
        private TabControl tabMain;

        private FrmBilling()
        {
            InitializeComponent();
        }

        private FrmBilling(RoomInfo oldRoom, DeskInfo oldDesk)
            : this()
        {
            this.oldRoom = oldRoom;
            this.oldDesk = oldDesk;
        }

        public FrmMain Main
        {
            get { return main; }
            set { main = value; }
        }

        public TabControl TabMain
        {
            get { return tabMain; }
            set { tabMain = value; }
        }

        public static FrmBilling Single(RoomInfo oldRoom, DeskInfo oldDesk)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmBilling(oldRoom, oldDesk);
            }
            return instance;
        }

        private void Bind()
        {
            if (ckbMeal.Checked)
            {
                //此时不能直接关闭，关闭就直接return了，fac就show不出来了，所以Hide()。
                this.Hide();
                //由于弹出了新窗体，没有在更新开单信息后，立即关闭窗体触发主窗体更新的事件
                //可能会导致，用户在主窗体可以对已经修改状态而未显示已经修改状态的餐桌进行选择，并重复开单（一张桌子，两个开单）。
                //流程图：
                //正常情况：在主窗体选择a桌子→顾客开单→开单界面（向数据库插入数据）→开单界面隐藏→添加消费界面→消费界面关闭→开单界面关闭→刷新主窗体
                //bug情况：开单界面隐藏→添加消费界面→在主窗体选择a桌子→顾客开单→开单界面（再次向数据库插入数据）→开单界面隐藏→添加消费界面→
                //修改：开单界面隐藏→刷新主窗体→添加消费界面→
                main.LoadDeskBySelectedTab(tabMain.SelectedTab);

                FrmAddConsumption fac = FrmAddConsumption.Single(newOrderId, oldDesk.DeskName);
                fac.FormClosed += fac_FormClosed;
                fac.Show();
                return;
            }
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                return;
            }
            OrderInfo order = new OrderInfo();
            order.BeginTime = System.DateTime.Now;//订单的开始时间
            order.DelFlag = 0;//删除标识
            order.DisCount = 0;//折扣==针对会员
            order.OrderMoney = 0;//订单消费的金额默认值为0
            order.OrderState = 1;//订单状态1===使用
            order.Remark = txtPersonCount.Text + "个" + txtDescription.Text;//备注
            order.SubBy = 1;//提交人默认1
            order.SubTime = System.DateTime.Now;
            //保存开单的newOrderId，以便传给新增消费窗体
            newOrderId = new OrderInfoBLL().AddOrderAddOrder_DeskUpdateDesk(order, oldDesk);
            md.MsgDivShow(newOrderId > 0 ? "操作成功" : "操作失败，请联系大龙同志", 1, Bind);
        }

        private void fac_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            labDeskName.Text = oldDesk.DeskName;
            labRoomName.Text = oldRoom.RoomName;
            labLittleMoney.Text = Convert.ToString(oldRoom.RoomMinMoney);
        }

        private bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txtPersonCount.Text))
            {
                md.MsgDivShow("亲，请输入顾客人数哦", 1);
                return true;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                md.MsgDivShow("亲，请输入开单备注哦", 1);
                return true;
            }
            return false;
        }
    }
}