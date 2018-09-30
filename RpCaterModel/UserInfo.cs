namespace RpCater.Model
{
    public class UserInfo
    {
        private string loginUserName;
        private string pwd;
        private int userId;
        private string userName;

        public string LoginUserName
        {
            get { return loginUserName; }
            set { loginUserName = value; }
        }

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}