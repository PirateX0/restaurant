using RpCater.Model;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class UserInfoDAL
    {
        /// <summary>
        /// 根据loginName返回UserInfo对象
        /// </summary>
        /// <param name="loginName">loginName</param>
        /// <returns>如果有loginName对应的UserInfo对象，返回UserInfo对象；否则，返回null</returns>
        public UserInfo GetUserInfoByLoginName(string loginName)
        {
            string sql = "select * from UserInfo where loginUserName=@loginName";
            DataTable table = SQLHelper.ExecuteQuery(sql, new SqlParameter("loginName", loginName));
            UserInfo info = null;
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    info = GetInfoFromRow(row);
                }
            }
            return info;
        }

        private UserInfo GetInfoFromRow(DataRow row)
        {
            UserInfo info = new UserInfo();
            info.UserId = int.Parse(row["UserId"].ToString());
            info.UserName = row.IsNull("UserName") ? null : row["UserName"].ToString();
            info.Pwd = row.IsNull("Pwd") ? null : row["Pwd"].ToString();
            info.LoginUserName = row.IsNull("LoginUserName") ? null : row["LoginUserName"].ToString();

            return info;
        }
    }
}