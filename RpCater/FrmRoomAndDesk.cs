using RpCater.BLL;
using RpCater.model;
using RpCater.Model;
using System;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmRoomAndDesk : Form
    {
        public Action LoadRoomEvent;//刷新主窗体中的房间
        public Func<TabPage> GetTabPage;//获得主窗体的TabPage
        public Action<TabPage> LoadDeskEvent;//刷新主窗体中的餐桌
        private static FrmRoomAndDesk instance;

        private FrmRoomAndDesk()
        {
            InitializeComponent();
        }

        public static FrmRoomAndDesk Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRoomAndDesk();
                }
                return FrmRoomAndDesk.instance;
            }
        }

        //public TabPage Page { get; set; }//主窗体中的餐桌所在房间

        private void btnADesk_Click(object sender, EventArgs e)
        {
            ShowFrmDeskAddOrModify(HandleStatus.Insert, null);
        }

        private void btnARoom_Click(object sender, EventArgs e)
        {
            ShowFrmRoomAddOrModify(HandleStatus.Insert, null);
        }

        private void btnDDesk_Click(object sender, EventArgs e)
        {
            //判断是否选择了删除的对象
            if (dgvDesk.SelectedRows.Count <= 0)
            {
                md1.MsgDivShow("请选择要注销的餐桌", 1);
                return;
            }
            //提示用户是否真的删除
            if (MessageBox.Show("亲，真的要注销这个餐桌吗？", "注销提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //删除
                DeskInfoBLL dBll = new DeskInfoBLL();
                DeskInfo d = (DeskInfo)dgvDesk.SelectedRows[0].DataBoundItem;
                string msg = dBll.SoftDelete((int)d.DeskId) > 0 ? "操作成功" : "操作失败";
                md1.MsgDivShow(msg, 1);
                //刷新
                LoadDeskByDelFlag(0);

                LoadDeskEvent(GetTabPage());
                return;
            }
            //提示取消删除
            md1.MsgDivShow("您已经取消了注销", 1);
        }

        private void btnDRoom_Click(object sender, EventArgs e)
        {
            //判断是否选择了删除的对象
            if (dgvRoom.SelectedRows.Count <= 0)
            {
                md.MsgDivShow("请选择要注销的房间", 1);
                return;
            }
            //提示用户是否真的删除
            if (MessageBox.Show("亲，真的要注销这个房间吗？", "注销提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                RoomInfoBLL roomBll = new RoomInfoBLL();
                RoomInfo room = (RoomInfo)dgvRoom.SelectedRows[0].DataBoundItem;
                DeskInfoBLL deskBll = new DeskInfoBLL();
                if (deskBll.GetAliveDeskCountByRoomId((int)room.RoomId) > 0)
                {
                    md.MsgDivShow("对不起，该房间内有餐桌，请先注销该房间内的餐桌哦~", 1);
                    return;
                }
                //删除
                string msg = roomBll.SoftDelete((int)room.RoomId) > 0 ? "操作成功" : "操作失败";
                md.MsgDivShow(msg, 1);
                //刷新
                LoadRoomByDelFlag(0);

                LoadRoomEvent();
                LoadDeskEvent(GetTabPage());
                return;
            }
            //提示取消删除
            md.MsgDivShow("您已经取消了注销", 1);
        }

        private void btnUDesk_Click(object sender, EventArgs e)
        {
            if (dgvDesk.SelectedRows.Count <= 0)
            {
                md1.MsgDivShow("请选择要修改的餐桌", 1);
                return;
            }
            DeskInfo desk = (DeskInfo)(dgvDesk.SelectedRows[0].DataBoundItem);
            ShowFrmDeskAddOrModify(HandleStatus.Update, desk);
        }

        private void btnURoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count <= 0)
            {
                md.MsgDivShow("请选择要修改的房间", 1);
                return;
            }
            RoomInfo room = (RoomInfo)(dgvRoom.SelectedRows[0].DataBoundItem);
            ShowFrmRoomAddOrModify(HandleStatus.Update, room);
        }

        private void fraom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            LoadDeskByDelFlag(0);
            LoadRoomByDelFlag(0);

            LoadRoomEvent();
            LoadDeskEvent(GetTabPage());
        }

        private void FrmRoomAndDesk_Load(object sender, EventArgs e)
        {
            LoadRoomByDelFlag(0);
            LoadDeskByDelFlag(0);
        }

        private void LoadDeskByDelFlag(int p)
        {
            dgvDesk.AutoGenerateColumns = false;
            dgvDesk.DataSource = new DeskInfoBLL().GetAllDeskInfoByDelFlag(p);
            dgvDesk.ClearSelection();
        }

        private void LoadRoomByDelFlag(int p)
        {
            dgvRoom.AutoGenerateColumns = false;
            dgvRoom.DataSource = new RoomInfoBLL().GetAllRoomInfoByDelFlag(p);
            dgvRoom.ClearSelection();
        }

        private void ShowFrmDeskAddOrModify(HandleStatus status, DeskInfo desk)
        {
            this.Hide();
            FrmDeskAddOrModify fdaom = FrmDeskAddOrModify.Single(status, desk);
            fdaom.FormClosed += fraom_FormClosed;
            fdaom.Show();
        }

        private void ShowFrmRoomAddOrModify(HandleStatus status, RoomInfo room)
        {
            this.Hide();
            FrmRoomAddOrModify fraom = FrmRoomAddOrModify.Single(status, room);
            fraom.FormClosed += fraom_FormClosed;
            fraom.Show();
        }
    }
}