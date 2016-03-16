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

        private void Form1_Load(object sender, EventArgs e)
        {
                 
        }

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

        private void btnInput_Click(object sender, EventArgs e)
        {

        }

        private void btnPwdModification_Click(object sender, EventArgs e)
        {

        }
    }
}
