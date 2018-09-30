using RpCater.DAL;
using RpCater.Model;
using System.Security.Cryptography;
using System.Text;

namespace RpCater.BLL
{
    public class UserInfoBLL
    {
        public LoginStatus GetLoginStatus(string loginName, string pwd)
        {
            pwd = GetMd5(pwd);
            UserInfoDAL dal = new UserInfoDAL();
            UserInfo info = dal.GetUserInfoByLoginName(loginName);
            if (info == null)
            {
                return LoginStatus.LoginNameIsNotFound;
            }
            if (info.Pwd != pwd)
            {
                return LoginStatus.PasswordError;
            }
            return LoginStatus.OK;
        }

        private static string GetMd5(string pwd)
        {
            string pwdMd5 = null;
            byte[] pwdBytes = Encoding.UTF8.GetBytes(pwd);
            MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();
            byte[] pwdMd5Bytes = md5Provider.ComputeHash(pwdBytes);
            foreach (byte pwdMd5Byte in pwdMd5Bytes)
            {
                pwdMd5 += pwdMd5Byte.ToString("x2");//x2表示16进制
            }
            return pwdMd5;
        }
    }
}