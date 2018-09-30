using RpCater.BLL;
using RpCater.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void LoadDeskBySelectedTab(TabPage tabPage)
        {
            if (tabPage == null)
            {
                return;
            }
            DeskInfoBLL dBll = new DeskInfoBLL();
            RoomInfo room = (RoomInfo)tabPage.Tag;
            List<DeskInfo> desks = dBll.GetAllAliveDeskInfoByRoomId((int)room.RoomId);
            ListView lv = (ListView)tabPage.Controls[0];
            //清空listview
            lv.Clear();
            //为listview添加内容
            for (int i = 0; i < desks.Count; i++)
            {
                lv.Items.Add(desks[i].DeskName, (int)desks[i].DeskState);
                lv.Items[i].Tag = desks[i];
            }
        }

        private void btnAddConsumption_Click(object sender, EventArgs e)
        {
            if (tabMain.TabCount <= 0)
            {
                md.MsgDivShow("sorry啊，店内装修，暂不营业", 1);
                return;
            }
            ListView lv = (ListView)tabMain.SelectedTab.Controls[0];
            if (lv.SelectedItems.Count <= 0)
            {
                md.MsgDivShow("亲，请先选择餐桌哦", 1);
                return;
            }
            RoomInfo room = (RoomInfo)tabMain.SelectedTab.Tag;
            DeskInfo desk = (DeskInfo)lv.SelectedItems[0].Tag;
            if (desk.DeskState == 0)
            {
                md.MsgDivShow("亲，请选择开单后的餐桌哦", 1);
                return;
            }
            int orderID = new R_Order_DeskBLL().GetAliveOrderIdByDeskId((int)desk.DeskId);
            FrmAddConsumption fac = FrmAddConsumption.Single(orderID, desk.DeskName);
            //主窗体要刷新！因为如果不刷新，之前选中的状态还会存在，虽然你看不见。
            //测试方法：
            //正常情况：选中餐桌→增加消费→关闭增加消费窗体→选中餐桌→增加消费
            //bug情况：关闭增加消费窗体→增加消费（不用选中餐桌就能增加消费了）
            fac.FormClosed += fb_FormClosed;
            fac.Show();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            if (tabMain.TabCount <= 0)
            {
                md.MsgDivShow("sorry啊，店内装修，暂不营业", 1);
                return;
            }
            ListView lv = (ListView)tabMain.SelectedTab.Controls[0];
            if (lv.SelectedItems.Count <= 0)
            {
                md.MsgDivShow("亲，请先选择餐桌哦", 1);
                return;
            }
            RoomInfo room = (RoomInfo)tabMain.SelectedTab.Tag;
            DeskInfo desk = (DeskInfo)lv.SelectedItems[0].Tag;
            if (desk.DeskState == 1)
            {
                md.MsgDivShow("亲，请选择空闲的餐桌哦", 1);
                return;
            }
            FrmBilling fb = FrmBilling.Single(room, desk);
            fb.Main = this;
            fb.TabMain = tabMain;
            fb.FormClosed += fb_FormClosed;
            fb.Show();
        }

        private void btnCategoryOrProduct_Click(object sender, EventArgs e)
        {
            FrmCategoryAndProduct fcap = FrmCategoryAndProduct.Instance;
            fcap.Show();
        }

        private void btnGuestPay_Click(object sender, EventArgs e)
        {
            //结账条件检查
            if (tabMain.TabCount <= 0)
            {
                md.MsgDivShow("sorry啊，店内装修，暂不营业", 1);
                return;
            }
            ListView lv = (ListView)tabMain.SelectedTab.Controls[0];
            if (lv.SelectedItems.Count <= 0)
            {
                md.MsgDivShow("亲，请先选择要结账的餐桌哦", 1);
                return;
            }
            RoomInfo room = (RoomInfo)tabMain.SelectedTab.Tag;
            DeskInfo desk = (DeskInfo)lv.SelectedItems[0].Tag;
            if (desk.DeskState == 0)
            {
                md.MsgDivShow("亲，请选择正在就餐的餐桌哦", 1);
                return;
            }
            //弹出结账窗体
            int deskId = (int)desk.DeskId;
            string deskNum = desk.DeskName;
            int orderId = new R_Order_DeskBLL().GetAliveOrderIdByDeskId((int)desk.DeskId);
            FrmGuestPay fcp = FrmGuestPay.Single(deskId, deskNum, orderId);
            //刷新主窗体
            fcp.FormClosed += fb_FormClosed;
            fcp.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FrmMember member = FrmMember.Instance;
            member.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            FrmRoomAndDesk frod = FrmRoomAndDesk.Instance;
            frod.LoadDeskEvent = LoadDeskBySelectedTab;
            frod.LoadRoomEvent = ReloadRoom;
            //frod.Page = tabMain.SelectedTab;//tabpage在增加或者注销房间后不是原来的SelectedTab了，要动态获得
            frod.GetTabPage = GetTabPage;

            //非实时显示增加餐桌
            //frod.FormClosed += frod_FormClosed;

            frod.Show();
        }

        private TabPage GetTabPage()
        {
            return tabMain.SelectedTab;
        }

        private void frod_FormClosed(object sender, FormClosedEventArgs e)
        {
            //加载房间
            ReloadRoom();
            //加载显示房间中的餐桌
            LoadDeskBySelectedTab(tabMain.SelectedTab);
        }

        private void ReloadRoom()
        {
            tabMain.TabPages.Clear();
            LoadRoomByDelFlag(0);
        }

        private void fb_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDeskBySelectedTab(tabMain.SelectedTab);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //坑--------房间和餐桌信息修改之后应该刷新主页面的房间和餐桌显示

            //加载房间
            LoadRoomByDelFlag(0);
            //加载显示房间中的餐桌
            LoadDeskBySelectedTab(tabMain.SelectedTab);
        }

        private void LoadRoomByDelFlag(int p)
        {
            RoomInfoBLL rBll = new RoomInfoBLL();
            List<RoomInfo> rooms = rBll.GetAllRoomInfoByDelFlag(p);
            for (int i = rooms.Count - 1; i >= 0; i--)
            {
                //page
                TabPage page = new TabPage();
                page.Text = rooms[i].RoomName;
                page.Tag = rooms[i];
                //listview
                ListView lv = new ListView();
                lv.View = View.LargeIcon;
                lv.LargeImageList = imageList1;
                lv.Dock = DockStyle.Fill;
                lv.BackColor = Color.SeaGreen;
                lv.MultiSelect = false;
                //page添加listview
                page.Controls.Add(lv);
                //tabmain添加page
                tabMain.TabPages.Add(page);
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDeskBySelectedTab(tabMain.SelectedTab);
        }
    }
}