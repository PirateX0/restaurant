using RpCater.BLL;
using RpCater.Model;
using System;
using System.Windows.Forms;

namespace RpCater
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Bind()
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserInfoBLL bll = new UserInfoBLL();
            if (CheckLoginNameAndPwd())
            {
                LoginStatus status = bll.GetLoginStatus(txtLoginName.Text, txtPwd.Text);
                if (status == LoginStatus.LoginNameIsNotFound)
                {
                    msg.MsgDivShow("亲，不存在该用户", 1);
                    return;
                }
                if (status == LoginStatus.PasswordError)
                {
                    msg.MsgDivShow("亲，密码不正确", 1);
                    return;
                }
                msg.MsgDivShow("登陆成功啦", 1, Bind);
            }
        }

        private bool CheckLoginNameAndPwd()
        {
            if (string.IsNullOrEmpty(txtLoginName.Text))
            {
                msg.MsgDivShow("亲，请填写用户名", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                msg.MsgDivShow("亲，请填写密码", 1);
                return false;
            }
            return true;
        }
    }
}