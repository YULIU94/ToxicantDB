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
            this.lblLocation1.Visible = false;

            this.txtAdminName.Visible = false;
            this.rdoMale.Visible = false;
            this.rdoFemale.Visible = false;
            this.txtAdminRole.Visible = false;
            this.txtPhone.Visible = false;
            this.txtLocation.Visible = false;

            this.btnEdit.Enabled = false;
            this.btnDel.Enabled = false;
            this.btnEditPwd.Enabled = false;

            this.btnEditClose.Visible = false;
            this.btnSave.Visible = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.rdoAdminId.Checked && this.txt_AdminId.Text.Trim().Length > 0)
            {
                this.objCurrentAdmin = objSysAdminManager.GetInfoByAdminId(this.txt_AdminId.Text.Trim());
            }
            else if (this.rdoIDCard.Checked && this.txt_IDCard.Text.Trim().Length > 0)
            {
                this.objCurrentAdmin = objSysAdminManager.GetInfoByIDCard(this.txt_IDCard.Text.Trim());
            }
            else if (this.txt_AdminId.Text.Trim().Length == 0 && this.txt_IDCard.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入相关信息！", "输入提示");
                return;
            }
            

            //显示查询结果
            if(this.objCurrentAdmin!=null)
            {
                this.lbl_AdminName.Text = objCurrentAdmin.AdminName;
                this.lbl_UserId.Text = objCurrentAdmin.AdminId.ToString();
                this.lbl_Gender.Text=objCurrentAdmin.Gender;
                this.lbl_AdminRole.Text = objCurrentAdmin.AdminRole;
                this.lbl_Phone.Text = objCurrentAdmin.PhoneNumber;
                this.lbl_IDCard.Text = objCurrentAdmin.IdCard;
                this.lbl_Location.Text = objCurrentAdmin.Location;

                this.btnEdit.Enabled = true;
                this.btnDel.Enabled = true;
                this.btnEditPwd.Enabled = true;
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
            this.lblLocation1.Visible = true;

            this.txtAdminName.Visible = true;
            this.rdoMale.Visible = true;
            this.rdoFemale.Visible = true;
            this.txtAdminRole.Visible = true;
            this.txtPhone.Visible = true;
            this.txtLocation.Visible = true;

            this.btnEditClose.Visible = true;
            this.btnSave.Visible = true;
            //在输入框中填入已有信息
            this.txtAdminName.Text = objCurrentAdmin.AdminName;
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
            this.txtLocation.Text = objCurrentAdmin.Location;

            //禁用tabpage2

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //封装对象
            SysAdmin objAdmin = new SysAdmin()
            {
                AdminId = this.objCurrentAdmin.AdminId,
                AdminName = this.txtAdminName.Text.Trim(),
                Gender = this.rdoFemale.Checked ? "女" : "男",
                AdminRole = this.txtAdminRole.Text.Trim(),
                PhoneNumber = this.txtPhone.Text.Trim(),
                Location = this.txtLocation.Text.Trim()
            };
            //数据提交
            try
            {
                objSysAdminManager.EditAdmin(objAdmin);
                MessageBox.Show("提交成功", "提交信息");
                
                //同步显示用户信息(调用用户查询功能)
                if (this.txt_AdminId.Text.Trim().Length != 0)
                {
                    this.rdoAdminId.Checked = true;
                }
                else if (this.txt_IDCard.Text.Trim().Length != 0)
                {
                    this.rdoIDCard.Checked = true;
                }
                this.btnQuery_Click(null, null);
                this.btnEdit.Enabled = false;
                if (this.lbl_Gender.Text.Trim() == "男")
                {
                    this.rdoMale.Checked = true;
                }
                else
                {
                    this.rdoFemale.Checked = true;
                }
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
            this.lblLocation1.Visible = false;

            this.txtAdminName.Visible = false;
            this.rdoMale.Visible = false;
            this.rdoFemale.Visible = false;
            this.txtAdminRole.Visible = false;
            this.txtPhone.Visible = false;
            this.txtLocation.Visible = false;

            this.btnEditClose.Visible = false;
            this.btnSave.Visible = false;

            //恢复禁用的按钮
            this.btnQuery.Enabled = true;
            this.btnEdit.Enabled = true;

            if (this.txt_AdminId.Text.Trim().Length != 0)
            {
                this.rdoAdminId.Checked = true;
            }
            else if(this.txt_IDCard.Text.Trim().Length != 0)
            {
                this.rdoIDCard.Checked = true;
            }

            
        }

        private void rdoAdminId_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_IDCard.Clear();
        }

        private void rdoIDCard_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_AdminId.Clear();
        }

        //删除用户
        private void btnDel_Click(object sender, EventArgs e)
        {
            string adminId = this.objCurrentAdmin.AdminId.ToString();
            objSysAdminManager.DeleteAdmin(adminId);
        }
        //新增用户
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //数据验证
            if(this.txtAdminName2.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入用户名" , "添加提示");
                return;
            }
            else if(this.txtAdminId2.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入用户ID", "添加提示");
                return;
            }
            else if(this.txtIDCard2.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入身份证号码", "添加提示");
                return;
            }
            else if (this.txtAdminPwd2.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户密码", "添加提示");
                return;
            }

            if(this.objSysAdminManager.GetAdminByAdminId(this.txtAdminId2.Text.Trim()))
            {
                MessageBox.Show("用户ID已存在", "添加提示");
                return;
            }
            else if (this.objSysAdminManager.GetAdminByIdCard(this.txtIDCard2.Text.Trim()))
            {
                MessageBox.Show("身份证号码已存在", "添加提示");
                return;
            }
            
            if(!this.objSysAdminManager.IsIdCard(this.txtIDCard2.Text.Trim()))
            {
                MessageBox.Show("身份证号码格式不正确", "添加提示");
                return;
            }

            //封装对象
            SysAdmin objAdmin = new SysAdmin()
            {
                AdminId = Convert.ToInt32( this.txtAdminId2.Text),
                AdminName = this.txtAdminName2.Text.Trim(),
                LoginPwd = this.txtAdminPwd2.Text.Trim(),
                StatusId = 1,
                IdCard = this.txtIDCard2.Text.Trim(),
                Gender = this.rdoMale2.Checked ? "男" : "女",
                AdminRole = this.txtAdminRole2.Text.Trim(),
                PhoneNumber = this.txtPhone2.Text.Trim(),
                Location = this.txtLocation2.Text.Trim()
            };
            //调用后台添加对象信息
            try
            {
                objSysAdminManager.AddAdmin(objAdmin);
                MessageBox.Show("添加用户成功", "添加提示");
                foreach (Control item in this.tpAdd.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加用户出现错误："+ex.Message, "添加提示");
            }

        }

        private void btnEditPwd_Click(object sender, EventArgs e)
        {
            FrmEditPwd frmEditPwd = new FrmEditPwd(this.objCurrentAdmin);
            frmEditPwd.Show();
        }
    }
}
