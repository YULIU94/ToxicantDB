using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using Models;
using Common;

namespace ToxicantDB
{
    public partial class FrmAdminLogin : Form
    {
        //创建相关的业务逻辑对象
        private SysAdminManager objAdminManager = new SysAdminManager();

        public FrmAdminLogin()
        {
            InitializeComponent();

            //显示登录用户名

        }

        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //数据验证
            if(this.txtAdminId.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入登录账号!", "登录提示");
                this.txtAdminId.Focus();
                return;
            }
            if(!DataValidate.IsInteger(this.txtAdminId.Text.Trim()))
            {
                MessageBox.Show("登录帐号必须为整数！","登录提示");
                this.txtAdminId.Focus();
            }
            if (this.txtAdminPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录密码!", "登录提示");
                this.txtAdminId.Focus();
            }
            if (this.txtAdminPwd.Text.Trim().Length < 6 || this.txtAdminPwd.Text.Trim().Length > 18)
            {
                MessageBox.Show("登录密码长度应在6到18之间!", "登录提示");
                this.txtAdminId.Focus();
            }

            //封装对象(将用户输入的账号和密码封装到用户对象中)
            SysAdmin objAdmin = new SysAdmin()
            {
                AdminId = Convert.ToInt32(this.txtAdminId.Text.Trim()),//用户名数据格式暂时为Int，后面可以根据需要修改（改进）
                LoginPwd = this.txtAdminPwd.Text.Trim()
            };
            try
            {
                //调用业务逻辑完成登录账号和密码的比对
                objAdmin = objAdminManager.AdminLogin(objAdmin);
                //判断登录是否成功
                if(objAdmin!=null)
                {
                    if (objAdmin.StatusId == 1)//帐号状态正常
                    {
                        Program.objCurrentAdmin = objAdmin;//保存当前登录用户
                        this.DialogResult = DialogResult.OK;//设置窗体返回值
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("当前登录账号被禁用！/r无法登陆，请联系管理员！", "登录提示");
                    }
                }
                else
                {
                    MessageBox.Show("当前登录账号或密码不正确！", "登录提示");
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("登录出现异常！", "登录提示");
                throw ex;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
