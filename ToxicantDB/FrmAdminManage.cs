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
    public partial class FrmAdminManage : Form
    {
        //创建业务逻辑对象
        //private InfoManager objInfoManager = new InfoManager();
        private SysAdminManager objSysAdminManager = new SysAdminManager();
        //创建对象的容器(List泛型集合):用来保存查询结果
        List<Info> listReader = null;
        //定义用户成员变量
        //private Info objCurrentInfo = null;
        private SysAdmin objCurrentAdmin = null;
        private FrmMain _parentForm;//(差异)
        public FrmAdminManage(FrmMain parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;//(差异)

            //修改信息部分隐藏
            this.lblAdminName1.Visible = false;
            this.lblAdminRole1.Visible = false;
            this.lblGender1.Visible = false;
            this.lblPhone1.Visible = false;
            this.lblIDCard1.Visible = false;
            this.lblLocation1.Visible = false;

            this.txtUserName.Visible = false;
            this.rdoMale.Visible = false;
            this.rdoFemale.Visible = false;
            this.txtAdminRole.Visible = false;
            this.txtPhone.Visible = false;
            this.txtIDCard.Visible = false;
            this.txtLocation.Visible = false;

            this.btnEditClose.Visible = false;
            this.btnSave.Visible = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.rdoAdminId.Checked && this.txt_UserId.Text.Trim().Length > 0)
            {
                this.objCurrentAdmin = objSysAdminManager.GetInfoByAdminId(this.txt_UserId.Text.Trim());
            }
            else if (this.rdoIDCard.Checked && this.txt_IDCard.Text.Trim().Length > 0)
            {
                this.objCurrentAdmin = objSysAdminManager.GetInfoByIDCard(this.txt_IDCard.Text.Trim());
            }
            else if (this.txt_UserId.Text.Trim().Length == 0 && this.txt_IDCard.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入相关信息！", "输入提示");
                return;
            }
            

            //显示查询结果
            if(this.objCurrentAdmin!=null)
            {
                this.lbl_UserName.Text = objCurrentAdmin.AdminName;
                this.lbl_UserId.Text = objCurrentAdmin.AdminId.ToString();
                this.lbl_Gender.Text=objCurrentAdmin.Gender;
                this.lbl_AdminRole.Text = objCurrentAdmin.AdminRole;
                this.lbl_Phone.Text = objCurrentAdmin.PhoneNumber;
                this.lbl_IDCard.Text = objCurrentAdmin.IdCard;
                this.lbl_Location.Text = objCurrentAdmin.Location;
            }
            else
            {
                MessageBox.Show("无法找到对应信息！", "提示信息");
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //禁用原来的按钮
            this.btnQuery.Enabled = false;
            this.btnEdit.Enabled = false;

            if (this.objCurrentAdmin == null)
                return;
            //显示输入框
            this.lblAdminName1.Visible = true;
            this.lblAdminRole1.Visible = true;
            this.lblGender1.Visible = true;
            this.lblPhone1.Visible = true;
            this.lblIDCard1.Visible = true;
            this.lblLocation1.Visible = true;

            this.txtUserName.Visible = true;
            this.rdoMale.Visible = true;
            this.rdoFemale.Visible = true;
            this.txtAdminRole.Visible = true;
            this.txtPhone.Visible = true;
            this.txtIDCard.Visible = true;
            this.txtLocation.Visible = true;

            this.btnEditClose.Visible = true;
            this.btnSave.Visible = true;
            //在输入框中填入已有信息
            this.txtUserName.Text = objCurrentAdmin.AdminName;
            if(this.lbl_Gender.Text.Trim() =="男")
            {
                this.rdoMale.Checked=true;
            }
            else
            {
                this.rdoFemale.Checked = true;
            }
            this.txtAdminRole.Text = objCurrentAdmin.AdminRole;
            this.txtPhone.Text = objCurrentAdmin.PhoneNumber;
            this.txtIDCard.Text = objCurrentAdmin.IdCard;
            this.txtLocation.Text = objCurrentAdmin.Location;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //封装对象
            SysAdmin objAdmin = new SysAdmin()
            {
                AdminId = this.objCurrentAdmin.AdminId,
                AdminName = this.txtUserName.Text.Trim(),
                Gender = this.rdoFemale.Checked ? "女" : "男",
                AdminRole = this.txtAdminRole.Text.Trim(),
                PhoneNumber = this.txtPhone.Text.Trim(),
                IdCard = this.txtIDCard.Text.Trim(),
                Location = this.txtLocation.Text.Trim()
            };
            //数据提交
            try
            {
                objSysAdminManager.EditAdmin(objAdmin);
                MessageBox.Show("提交成功", "提交信息");
            }
            catch (Exception ex)
            {
                MessageBox.Show("提交出现错误：" + ex.Message, "提交信息");
            }
        }

        private void btnEditClose_Click(object sender, EventArgs e)
        {
            //修改信息部分隐藏
            this.lblAdminName1.Visible = false;
            this.lblAdminRole1.Visible = false;
            this.lblGender1.Visible = false;
            this.lblPhone1.Visible = false;
            this.lblIDCard1.Visible = false;
            this.lblLocation1.Visible = false;

            this.txtUserName.Visible = false;
            this.rdoMale.Visible = false;
            this.rdoFemale.Visible = false;
            this.txtAdminRole.Visible = false;
            this.txtPhone.Visible = false;
            this.txtIDCard.Visible = false;
            this.txtLocation.Visible = false;

            this.btnEditClose.Visible = false;
            this.btnSave.Visible = false;

            //恢复禁用的按钮
            this.btnQuery.Enabled = true;
            this.btnEdit.Enabled = true;
        }
    }
}
