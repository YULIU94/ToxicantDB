using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToxicantDB
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //显示用户登录名
            this.tssl_AdminName.Text = "  用户名："+Program.objCurrentAdmin.AdminName;

            //后面可以添加权限管理
        }

        private void OpenForm(Form objFrm)
        {
            //首先判断容器中是否有其他窗体，如果有，则先关闭
            foreach (Control item in this.splitContainer1.Panel2.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }

            //其次嵌入新的子窗体
            objFrm.TopLevel = false;//将子窗体设置为非顶级控件
            objFrm.FormBorderStyle = FormBorderStyle.None;//去掉子窗体的边框
            objFrm.Parent = this.splitContainer1.Panel2;//指定子窗体显示的容器（父窗口）
            objFrm.Dock = DockStyle.Fill;//随着容器大小自动调整窗体大小
            objFrm.Show();

        }


        private void Form1_Load(object sender, EventArgs e){} 
               

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnQueryProperty_Click(object sender, EventArgs e)
        {

        }

        private void btnQueryToxic_Click(object sender, EventArgs e)
        {

        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {

        }

        

        private void btnPwdModification_Click(object sender, EventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e){}
        private void btnInput_Click_1(object sender, EventArgs e)
        {
            FrmInfoInput objFrm = new FrmInfoInput(this);//(差异)
            OpenForm(objFrm);
            this.lblCurrent.Text = "信息输入";
        }

        public void setLblCurrentText(){
            this.lblCurrent.Text = "欢迎使用";
        }

        private void btnDetailInput_Click(object sender, EventArgs e)
        {
            FrmDetailInput objFrm = new FrmDetailInput(this);//(差异)
            OpenForm(objFrm);
            this.lblCurrent.Text = "信息输入";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出系统", "退出询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;//取消窗体关闭操作
            }
        }

        private void btnAidInput_Click(object sender, EventArgs e)
        {
            FrmInfoManage objFrm = new FrmInfoManage(this);//(差异)
            OpenForm(objFrm);
            this.lblCurrent.Text = "信息输入";
        }

    }
}
