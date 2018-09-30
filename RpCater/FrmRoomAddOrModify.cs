using RpCater.BLL;
using RpCater.model;
using RpCater.Model;
using System;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmRoomAddOrModify : Form
    {
        private static FrmRoomAddOrModify instance;
        private RoomInfo oldRoom;
        private HandleStatus status;

        private FrmRoomAddOrModify()
        {
            InitializeComponent();
        }

        private FrmRoomAddOrModify(HandleStatus status, RoomInfo oldRoom)
            : this()
        {
            this.status = status;
            this.oldRoom = oldRoom;
        }

        public static FrmRoomAddOrModify Single(HandleStatus status, RoomInfo oldRoom)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRoomAddOrModify(status, oldRoom);
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
            RoomInfoBLL rBll = new RoomInfoBLL();
            RoomInfo r = new RoomInfo();
            int i = 0;

            r.IsDefault = txtIsDefault.Text;//默认的编号
            r.RoomMaxNum = Convert.ToInt32(txtRPerNum.Text);//容纳人数
            r.RoomMinMoney = Convert.ToDouble(txtRMinMoney.Text);//最低消费
            r.RoomName = txtRName.Text;//名字
            r.RoomType = Convert.ToInt32(txtRType.Text);
            if (status == HandleStatus.Insert)
            {
                r.DelFlag = 0;
                r.SubBy = 1;
                r.SubTime = System.DateTime.Now;//当前时间

                i = rBll.add(r);
            }
            if (status == HandleStatus.Update)
            {
                r.RoomId = oldRoom.RoomId;
                r.DelFlag = oldRoom.DelFlag;
                r.SubBy = oldRoom.SubBy;
                r.SubTime = oldRoom.SubTime;

                i = rBll.update(r);
            }
            string msg = i > 0 ? "操作成功" : "操作失败";
            md.MsgDivShow(msg, 1, Bind);
        }

        private void FrmRoomAddOrModify_Load(object sender, EventArgs e)
        {
            if (status == HandleStatus.Update)
            {
                txtIsDefault.Text = oldRoom.IsDefault;//房间的默认编号
                txtRMinMoney.Text = oldRoom.RoomMinMoney.ToString();//最低消费
                txtRName.Text = oldRoom.RoomName;//房间的名字
                txtRPerNum.Text = oldRoom.RoomMaxNum.ToString();//房间的最多容纳人数
                txtRType.Text = oldRoom.RoomType.ToString();//房间的类型
                labId.Text = oldRoom.RoomId.ToString();//房间的id
            }
        }

        private bool IsNotEmpty()
        {
            if (string.IsNullOrEmpty(txtIsDefault.Text))
            {
                md.MsgDivShow("编号不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtRMinMoney.Text))
            {
                md.MsgDivShow("最低消费不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtRName.Text))
            {
                md.MsgDivShow("名字不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtRPerNum.Text))
            {
                md.MsgDivShow("容纳人数不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtRType.Text))
            {
                md.MsgDivShow("类型不能为空,是数字", 1);
                return false;
            }
            return true;
        }
    }
}