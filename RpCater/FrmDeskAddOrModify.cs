using RpCater.BLL;
using RpCater.model;
using RpCater.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmDeskAddOrModify : Form
    {
        private static FrmDeskAddOrModify instance;
        private DeskInfo oldDesk;
        private HandleStatus status;

        private FrmDeskAddOrModify()
        {
            InitializeComponent();
        }

        private FrmDeskAddOrModify(HandleStatus status,
DeskInfo oldDesk)
            : this()
        {
            this.status = status;
            this.oldDesk = oldDesk;
        }

        public static FrmDeskAddOrModify Single(HandleStatus status,

DeskInfo oldDesk)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDeskAddOrModify(status, oldDesk);
            }
            return instance;
        }

        private void Bind()
        {
            this.Close();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!IsNotEmpty())
            {
                return;
            }
            DeskInfoBLL dBll = new DeskInfoBLL();
            DeskInfo dk = new DeskInfo();
            int i = 0;
            dk.DeskName = txtDeskName.Text;
            dk.DeskRegion = txtDeskRegion.Text;//描述信息
            dk.DeskRemark = txtDeskRemark.Text;//备注
            dk.RoomId = Convert.ToInt32(cmbRoom.SelectedValue);//房间的id
            if (status == HandleStatus.Insert)
            {
                dk.DelFlag = 0;
                dk.DeskState = 0;//空闲===1===就餐
                dk.SubBy = 1;
                dk.SubTime = System.DateTime.Now;

                i = dBll.add(dk);
            }
            if (status == HandleStatus.Update)
            {
                dk.DeskId = oldDesk.DeskId;
                dk.DelFlag = oldDesk.DelFlag;
                dk.DeskState = oldDesk.DeskState;//空闲===1===就餐
                dk.SubBy = oldDesk.SubBy;
                dk.SubTime = oldDesk.SubTime;

                i = dBll.update(dk);
            }
            string msg = i > 0 ? "操作成功" : "操作失败";
            md.MsgDivShow(msg, 1, Bind);
        }

        private void FrmDeskAddOrModify_Load(object sender, EventArgs e)
        {
            LoadCmbRoom();
            if (status == HandleStatus.Update)
            {
                txtDeskName.Text = oldDesk.DeskName;
                txtDeskRegion.Text = oldDesk.DeskRegion;
                txtDeskRemark.Text = oldDesk.DeskRemark;
                cmbRoom.SelectedValue = oldDesk.RoomId;
            }
        }

        private bool IsNotEmpty()
        {
            if (string.IsNullOrEmpty(txtDeskName.Text))
            {
                md.MsgDivShow("名字不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtDeskRegion.Text))
            {
                md.MsgDivShow("描述信息不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtDeskRemark.Text))
            {
                md.MsgDivShow("备注不能为空", 1);
                return false;
            }
            if (cmbRoom.SelectedIndex == 0)
            {
                md.MsgDivShow("请选中房间");
                return false;
            }
            return true;
        }

        private void LoadCmbRoom()
        {
            RoomInfoBLL rBll = new RoomInfoBLL();
            List<RoomInfo> rooms = rBll.GetAllRoomInfoByDelFlag(0);
            rooms.Insert(0, new RoomInfo { RoomName = "请选择", RoomId = -1 });
            cmbRoom.DataSource = rooms;
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomId";
        }
    }
}