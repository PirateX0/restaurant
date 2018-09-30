using System;
using System.Windows.Forms;

namespace RpCater
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            //Application.Run(FrmRoomAndDesk.Instance);
        }
    }
}