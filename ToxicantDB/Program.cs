using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Models;

namespace ToxicantDB
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //显示登录窗体
            FrmAdminLogin frmLogin = new FrmAdminLogin();
            DialogResult result = frmLogin.ShowDialog();
            //判断登录是否成功
            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }
        }
        //定义一个全局变量，保存当前用户对象
        public static SysAdmin objCurrentAdmin = null;
    }
}
