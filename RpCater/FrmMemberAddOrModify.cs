using RpCater.BLL;
using RpCater.model;
using RpCater.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmMemberAddOrModify : Form
    {
        private static FrmMemberAddOrModify instance;
        private MemberInfo oldMember;
        private HandleStatus status;

        private FrmMemberAddOrModify()
        {
            InitializeComponent();
        }

        private FrmMemberAddOrModify(HandleStatus status, MemberInfo member)
        {
            InitializeComponent();
            this.status = status;
            this.oldMember = member;
        }

        public static FrmMemberAddOrModify Single(HandleStatus status, MemberInfo member)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmMemberAddOrModify(status, member);
            }
            return instance;
        }

        private void Bind()
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MemberInfoBLL memberbll = new MemberInfoBLL();
            if (NewCheckEmpty())
            {
                MemberInfo member = new MemberInfo();
                member.MemAddress = txtAddress.Text;
                member.MemBirthday = txtBirstday.Value;//生日
                member.MemDiscount = float.Parse(txtDiscount.Text);//折扣
                member.MemEndTime = txtEndTime.Value;//结束时间
                member.MemGender = CheckGender();//性别
                member.MemIntegral = Convert.ToInt32(txtIntegral.Text);//积分
                member.MemMobilePhone = txtPhone.Text;//电话
                member.MemMoney = float.Parse(txtMoney.Text);//金额
                member.MemName = txtName.Text;//会员的名字
                member.MemNum = txtNum.Text;//编号
                member.MemType = Convert.ToInt32(cmbType.SelectedValue);//会员的类型

                string msg = null;

                if (status == HandleStatus.Insert)
                {
                    member.SubTime = System.DateTime.Now;
                    member.DelFlag = 0;
                    msg = memberbll.AddOrUpdateMemberInfo(member, status) ? "办理成功" : "办理失败";
                }

                if (status == HandleStatus.Update)
                {
                    member.MemberId = oldMember.MemberId;
                    member.SubTime = oldMember.SubTime;
                    member.DelFlag = oldMember.DelFlag;

                    msg = memberbll.AddOrUpdateMemberInfo(member, status) ? "修改成功" : "修改失败";
                }
                md.MsgDivShow(msg, 1, Bind);
            }
        }

        //判断每个文本框数据--下拉框--时间控件不能为空
        private bool CheckEmpty()
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                md.MsgDivShow("地址不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtBirstday.Value.ToString()))
            {
                md.MsgDivShow("生日不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                md.MsgDivShow("折扣不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtEndTime.Value.ToString()))
            {
                md.MsgDivShow("结束时间不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtIntegral.Text))
            {
                md.MsgDivShow("积分不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtMoney.Text))
            {
                md.MsgDivShow("金额不能为空", 1);
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
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                md.MsgDivShow("电话号码不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtSubTime.Value.ToString()))
            {
                md.MsgDivShow("注册时间不能为空", 1);
                return false;
            }
            if (txtEndTime.Value <= txtSubTime.Value)
            {
                md.MsgDivShow("有效期应该大于当前的注册时间");
                return false;
            }
            if (cmbType.SelectedIndex == 0)
            {
                md.MsgDivShow("请选择会员类型", 1);
                return false;
            }
            return true;
        }

        private bool NewCheckEmpty()
        {
            Content[] checkContentResultArr = new Content[]
            {
                new Content{IsInvalid=string.IsNullOrEmpty( txtAddress.Text),ErrorMessage= "地址不能为空"},
                new Content{IsInvalid=string.IsNullOrEmpty(txtBirstday.Value.ToString()),ErrorMessage="生日不能为空"},
                new Content{IsInvalid=string.IsNullOrEmpty(txtDiscount.Text),ErrorMessage="折扣不能为空"},
                new Content{IsInvalid=string.IsNullOrEmpty(txtEndTime.Value.ToString()),ErrorMessage="结束时间不能为空"},
                new Content{IsInvalid=string.IsNullOrEmpty(txtIntegral.Text),ErrorMessage="积分不能为空"},
                new Content{IsInvalid=string.IsNullOrEmpty(txtMoney.Text),ErrorMessage="金额不能为空"},
                new Content{IsInvalid=string.IsNullOrEmpty(txtName.Text),ErrorMessage="名字不能为空"},
                new Content{IsInvalid=string.IsNullOrEmpty(txtNum.Text),ErrorMessage="编号不能为空"},
                new Content{IsInvalid=string.IsNullOrEmpty(txtPhone.Text),ErrorMessage="电话号码不能为空"},
                new Content{IsInvalid=string.IsNullOrEmpty(txtSubTime.Value.ToString()),ErrorMessage="注册时间不能为空"},
                new Content{IsInvalid=txtEndTime.Value <= txtSubTime.Value,ErrorMessage="有效期应该大于当前的注册时间"},
                new Content{IsInvalid=cmbType.SelectedIndex == 0,ErrorMessage="请选择会员类型"}
            };
            for (int i = 0; i < checkContentResultArr.Length; i++)
            {
                if (checkContentResultArr[i].IsInvalid)
                {
                    md.MsgDivShow(checkContentResultArr[i].ErrorMessage, 1);
                    return false;
                }
            }
            return true;

            #region 逗

            //注意：不能添加相同的key,所以txtAddress.Text不能当key
            //貌似用数组存就ok了，用字典浪费啊。。
            //Dictionary<int, Content> checkContents = new Dictionary<int, Content>()
            //{
            //    {0,new Content{ContentText= txtAddress.Text,ErrorMessage= "地址不能为空"}},
            //    {1,new Content{ContentText=txtBirstday.Value.ToString(),ErrorMessage="生日不能为空"}},
            //    {2,new Content{ContentText=txtDiscount.Text,ErrorMessage="折扣不能为空"}},
            //    {3,new Content{ContentText=txtEndTime.Value.ToString(),ErrorMessage="结束时间不能为空"}},
            //    {4,new Content{ContentText=txtIntegral.Text,ErrorMessage="积分不能为空"}},
            //    {5,new Content{ContentText=txtMoney.Text,ErrorMessage="金额不能为空"}},
            //    {6,new Content{ContentText=txtName.Text,ErrorMessage="名字不能为空"}},
            //    {7,new Content{ContentText=txtNum.Text,ErrorMessage="编号不能为空"}},
            //    {8,new Content{ContentText=txtPhone.Text,ErrorMessage="电话号码不能为空"}},
            //    {9,new Content{ContentText=txtSubTime.Value.ToString(),ErrorMessage="注册时间不能为空"}}
            //};
            //foreach (KeyValuePair<int, Content> checkContent in checkContents)
            //{
            //    if (string.IsNullOrEmpty(checkContent.Value.ContentText))
            //    {
            //        md.MsgDivShow(checkContent.Value.ErrorMessage, 1);
            //        return false;
            //    }
            //}

            //if (txtEndTime.Value <= txtSubTime.Value)
            //{
            //    md.MsgDivShow("有效期应该大于当前的注册时间");
            //    return false;
            //}
            //if (cmbType.SelectedIndex == 0)
            //{
            //    md.MsgDivShow("请选择会员类型", 1);
            //    return false;
            //}

            //return true;

            #endregion 逗
        }

        private string CheckGender()
        {
            return rdoMan.Checked ? "男" : "女";
        }

        private void FrmMemberAddOrModify_Load(object sender, EventArgs e)
        {
            LoadCmbType();
            if (status == HandleStatus.Insert)
            {
                Random rd = new Random();
                string strRd = rd.Next(100000, 999999).ToString();
                string date = DateTime.Now.ToString("yyyyMMddHHmmss");
                txtNum.Text = date + strRd;
            }
            if (status == HandleStatus.Update)
            {
                txtAddress.Text = oldMember.MemAddress;
                txtBirstday.Value = oldMember.MemBirthday;
                txtDiscount.Text = oldMember.MemDiscount.ToString();
                txtEndTime.Value = oldMember.MemEndTime;
                txtIntegral.Text = oldMember.MemIntegral.ToString();
                txtMoney.Text = oldMember.MemMoney.ToString();
                txtName.Text = oldMember.MemName;
                txtNum.Text = oldMember.MemNum;
                txtPhone.Text = oldMember.MemMobilePhone;
                txtSubTime.Value = oldMember.SubTime;
                rdoMan.Checked = oldMember.MemGender == "男" ? true : false;
                rdoWoman.Checked = oldMember.MemGender == "女" ? true : false;
                //type--坑
                cmbType.SelectedValue = oldMember.MemType;
            }
        }

        private void LoadCmbType()
        {
            MemberTypeBLL mtbll = new MemberTypeBLL();
            List<MemberType> list = mtbll.getAll() as List<MemberType>;
            list.Insert(0, new MemberType { MemTypeName = "请选择", MemType = -1 });
            cmbType.DataSource = list;
            cmbType.DisplayMember = "MemTypeName";
            cmbType.ValueMember = "MemType";
        }
    }
}