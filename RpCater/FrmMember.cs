using RpCater.BLL;
using RpCater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RpCater
{
    /// <summary>
    /// 三层怎么解决多表联合查询？
    //我想把类别显示成土豪，屌丝，非正常人类
    //但是类别名称MemTypeName在MemberType表，MemberInfo表存的是MemTyperNum
    //尚海沸
    //那种情况下 我觉得可能直接用DataTable更好
    //单独在DAL写个返回DataTable的方法
    //因为它不是返回一个具体的实体对象了
    //而是一种组合的数据集合
    /// </summary>
    public partial class FrmMember : Form
    {
        private static FrmMember instance;
        private MemberInfoBLL membll = new MemberInfoBLL();

        private FrmMember()
        {
            InitializeComponent();
        }

        public static FrmMember Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmMember();
                }
                return instance;
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMember.SelectedRows.Count <= 0)
            {
                msgMember.MsgDivShow("请选择要注销的会员", 1);
                return;
            }
            if (MessageBox.Show("您真的要注销会员吗？", "注销提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DeleteMember();
                return;
            }
            msgMember.MsgDivShow("您已经取消了注销会员");
        }

        private void DeleteMember()
        {
            string msg = "注销失败";
            int count = 0;
            int id;
            int delFlag;

            for (int i = 0; i < dgvMember.SelectedRows.Count; i++)
            {
                id = Convert.ToInt32(dgvMember.SelectedRows[i].Cells[0].Value);
                //根据cmb状态(会员、回收站)设置删除标志（放入回收站、从回收站删除）
                delFlag = cmbRecycle.SelectedIndex == 0 ? (int)DeleteStatus.Recyclable : (int)DeleteStatus.Dead;
                if (membll.SoftDeleteMemberInfo(id, delFlag))
                {
                    count++;
                }
            }

            msg = count == dgvMember.SelectedRows.Count ? "注销成功" : "注销失败";
            msgMember.MsgDivShow(msg, 1);

            LoadDataGridView(cmbRecycle.SelectedIndex);
        }

        private void btnInsertMember_Click(object sender, EventArgs e)
        {
            ShowFrmMemberAddOrModify(HandleStatus.Insert, null);
        }

        private void btnSelectMember_Click(object sender, EventArgs e)
        {
            LoadDataGridView(membll.GetMemberInfoDataTableLikeMemName(txtMemName.Text));
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (CanUpdateMember())
            {
                MemberInfo member = membll.GetMemberInfoById(Convert.ToInt32(dgvMember.SelectedRows[0].Cells[0].Value));
                ShowFrmMemberAddOrModify(HandleStatus.Update, member);
            }
        }

        private bool CanUpdateMember()
        {
            if (dgvMember.SelectedRows.Count <= 0)
            {
                msgMember.MsgDivShow("请选择要修改的会员", 1);
                return false;
            }
            if (dgvMember.SelectedRows.Count >= 2)
            {
                msgMember.MsgDivShow("亲，只能选择一位要修改的会员", 1);
                return false;
            }
            if (cmbRecycle.SelectedIndex == 1)
            {
                msgMember.MsgDivShow("亲，不能修改已注销的会员", 1);
                return false;
            }
            return true;
        }

        private void cmbRecycle_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView(cmbRecycle.SelectedIndex);
        }

        private void fmam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            LoadDataGridView(0);
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            LoadDataGridView(0);

            cmbRecycle.SelectedIndex = 0;
        }

        private void LoadDataGridView(List<MemberInfo> list)
        {
            dgvMember.AutoGenerateColumns = false;
            dgvMember.DataSource = list;
            dgvMember.ClearSelection();
        }

        private void LoadDataGridView(int delFlag)
        {
            dgvMember.AutoGenerateColumns = false;
            //dgvMember.DataSource = membll.GetAllMemberInfoByDelFlag(delFlag);
            dgvMember.DataSource = membll.GetMemberInfoDataTableByDelFlag(delFlag);
            dgvMember.ClearSelection();
        }

        private void LoadDataGridView(DataTable table)
        {
            dgvMember.AutoGenerateColumns = false;
            dgvMember.DataSource = table;
            dgvMember.ClearSelection();
        }

        private void ShowFrmMemberAddOrModify(HandleStatus status, MemberInfo member)
        {
            this.Hide();
            FrmMemberAddOrModify fmam = FrmMemberAddOrModify.Single(status, member);
            fmam.FormClosed += fmam_FormClosed;
            fmam.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel文件|*.xls";
            sfd.Title = "导出Excel";
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            int delFlag = cmbRecycle.SelectedIndex;
            string msg = this.membll.CanExportToExcel(delFlag, sfd.FileName) ? "导出成功" : "导出失败";
            msgMember.MsgDivShow(msg, 1);
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    int delFlag = cmbRecycle.SelectedIndex;
            //    string msg = this.membll.CanExportToExcel(delFlag, sfd.FileName) ? "导出成功" : "导出失败";
            //    msgMember.MsgDivShow(msg, 1);
            //}
           
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件|*.xls;*.xlsx";
            ofd.Title = "导入Excel";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (this.membll.CanImportExcel(ofd.FileName))
            {
                msgMember.MsgDivShow("导入成功", 1);
                LoadDataGridView(0);
                return;
            }
            msgMember.MsgDivShow("导入失败，请联系大龙", 1);
        }
    }
}