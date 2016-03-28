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

namespace ToxicantDB
{
    public partial class FrmEditPwd : Form
    {
        private SysAdminManager objSysAdminManager = new SysAdminManager();
        private SysAdmin objEditAdmin = null;
        private FrmAdminManage objFrmAdminManage = null;

        public FrmEditPwd(SysAdmin objAdmin, FrmAdminManage objFrm)
        {
            InitializeComponent();

            objEditAdmin = objAdmin;//(差异)
            objFrmAdminManage = objFrm;

            this.txtAdminId.Text = objEditAdmin.AdminId.ToString();
            this.txtAdminName.Text = objEditAdmin.AdminName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string formerPwd = objEditAdmin.LoginPwd;

            //数据验证
            if(this.txtFormerPwd.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入原密码", "保存提示");
                return;
            }
            else if (this.txtNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入新密码", "保存提示");
                return;
            }
            else if (this.txtNewPwdRepeat.Text.Trim().Length == 0)
            {
                MessageBox.Show("请重复新密码", "保存提示");
                return;
            }
            else if (this.txtNewPwd.Text.Trim().Length < 6 || this.txtNewPwd.Text.Trim().Length > 18 || this.txtNewPwdRepeat.Text.Trim().Length < 6 || this.txtNewPwdRepeat.Text.Trim().Length > 18)
            {
                MessageBox.Show("密码长度应在6到18之间", "保存提示");
                return;
            }
            else if(this.txtNewPwd.Text.Trim()!=this.txtNewPwdRepeat.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致", "保存提示");
                return;
            }
            else if (this.txtFormerPwd.Text.Trim() != formerPwd)
            {
                MessageBox.Show("原密码错误", "保存提示");
                return;
            }

            
            //封装对象
            SysAdmin objAdmin = new SysAdmin()
            {
                AdminId = this.objEditAdmin.AdminId,
                LoginPwd = this.txtNewPwd.Text.Trim()
            };
            //提交修改
            try
            {
                objSysAdminManager.EditPwd(objAdmin);
                MessageBox.Show("修改成功", "修改信息");
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改出现错误：" + ex.Message, "修改信息");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //恢复禁用的按钮
            objFrmAdminManage.btnQuery.Enabled = true;
            objFrmAdminManage.btnEdit.Enabled = true;
            objFrmAdminManage.btnDel.Enabled = true;
            objFrmAdminManage.btnEditPwd.Enabled = true;
            this.Close();
        }
    }
}
