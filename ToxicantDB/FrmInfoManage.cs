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
    public partial class FrmInfoManage : Form
    {
        private InfoManager objInfoManager = new InfoManager();
        //创建对象的容器(List泛型集合):用来保存查询结果
        private List<Info> listInfo = null;
        //定义用户成员变量
        private Info objCurrentInfo = null;

        private FrmMain _parentForm;//(差异)

        public FrmInfoManage(FrmMain parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;//(差异)

            this.btnDel.Enabled = false;
            this.btnSave.Enabled = false;

            //启动时清空列表
            this.dgvInfoList.DataSource = null;

            //禁止数据列表控件dgv自动生成列
            this.dgvInfoList.AutoGenerateColumns = false;
            new Common.DataGridViewStyle().DgvStyle1(this.dgvInfoList);
        }

        #region 组合查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //首先断开选择改变事件（防止有些情况的异常）
            this.dgvInfoList.SelectionChanged -= new EventHandler(this.dgvInfoList_SelectionChanged);

            //判断用户是否输入条件
            if (this.txtCasId.Text.Trim().Length == 0 && this.txtChemicalName.Text.Trim().Length == 0 && this.txtChineseName.Text.Trim().Length == 0 && this.txtTraditionName.Text.Trim().Length == 0 && this.txtRtecsId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请至少选择一个查询条件！", "查询提示");
                return;
            }

            else
            {
                //根据条件组合查询
                listInfo = objInfoManager.GetInfos(this.txtCasId.Text.ToString().Trim(), this.txtChemicalName.Text.Trim(), this.txtChineseName.Text.Trim(), this.txtTraditionName.Text.Trim(), this.txtRtecsId.Text.Trim());
                //在列表中显示查询结果
                this.dgvInfoList.DataSource = null;
                this.dgvInfoList.DataSource = listInfo;
            }
            if (this.dgvInfoList.RowCount == 0)
            {
                MessageBox.Show("找不到对象！", "查询提示");
                return;
            }
            else
            {
                //激活按钮
                this.btnDel.Enabled = true;
                this.btnSave.Enabled = true;
                //绑定当前对象
                if (this.txtCasId.Text.Trim().Length > 0)
                {
                    objCurrentInfo = objInfoManager.GetInfoByCasId(this.txtCasId.Text.Trim());
                }
                else if (this.txtRtecsId.Text.Trim().Length > 0)
                {
                    objCurrentInfo = objInfoManager.GetInfoByRtecsId(this.txtRtecsId.Text.Trim());
                }
                else if (this.txtChemicalName.Text.Trim().Length > 0)
                {
                    objCurrentInfo = objInfoManager.GetInfoByChemicalName(this.txtChemicalName.Text.Trim());
                }
                else if (this.txtChineseName.Text.Trim().Length > 0)
                {
                    objCurrentInfo = objInfoManager.GetInfoByChineseName(this.txtChineseName.Text.Trim());
                }
                else if (this.txtTraditionName.Text.Trim().Length > 0)
                {
                    objCurrentInfo = objInfoManager.GetInfoByTraditionName(this.txtTraditionName.Text.Trim());
                }
            }



            //开启选择改变事件
            this.dgvInfoList.SelectionChanged += new EventHandler(this.dgvInfoList_SelectionChanged);
            dgvInfoList_SelectionChanged(null, null);//立刻进行一次同步
        }

        #endregion


        #region 检索框回车时查询

        private void txtCasId_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtCasId.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.btnQuery_Click(null, null);
            }
        }

        private void txtChemicalName_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtChemicalName.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.btnQuery_Click(null, null);
            }
        }

        private void txtChineseName_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtChineseName.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.btnQuery_Click(null, null);
            }
        }

        private void txtRtecsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtRtecsId.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.btnQuery_Click(null, null);
            }
        }

        private void txtTraditionName_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtTraditionName.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.btnQuery_Click(null, null);
            }
        }
        #endregion

        #region 删除信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            //删除前的确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;
            try
            {
                //首先断开选择改变事件（防止有些情况的异常）
                this.dgvInfoList.SelectionChanged -= new EventHandler(this.dgvInfoList_SelectionChanged);

                
                if (objInfoManager.DeleteInfo(this.objCurrentInfo.CasId) == 1)//表示删除成功
                {
                    //从列表中删除行
                    //同步更新显示
                    Info deleteInfo = (from i in this.listInfo where i.CasId.Equals(this.objCurrentInfo.CasId) select i).First<Info>();
                    this.listInfo.Remove(deleteInfo);
                    this.dgvInfoList.DataSource = null;
                    this.dgvInfoList.DataSource = this.listInfo;
                    //刷新dgv的显示
                    this.dgvInfoList.Refresh();
                }

                MessageBox.Show("删除成功", "删除提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "删除提示");
            }

            //开启选择改变事件
            this.dgvInfoList.SelectionChanged += new EventHandler(this.dgvInfoList_SelectionChanged);
            dgvInfoList_SelectionChanged(null, null);//使其立刻进行一次同步
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //同步显示
        private void dgvInfoList_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvInfoList.RowCount == 0)
                return;

            string casId = this.dgvInfoList.CurrentRow.Cells["casIdDataGridViewTextBoxColumn"].Value.ToString();//是Name不是DataPropertyName！
            Info objInfo = (from i in listInfo where i.CasId.Equals(casId) select i).First<Info>();//在泛型集合列表中查找符合的行及其属性（无需去数据库查找）

            //在下方修改框中同步显示对应数据
            this.txt_ChemicalName.Text = objInfo.ChemicalName;
            this.txt_ChineseName.Text = objInfo.ChineseName;
            this.txt_TraditionName.Text = objInfo.TraditionName;
            this.txt_RtecsId.Text = objInfo.RtecsId;
            this.txt_Element.Text = objInfo.Element;
            this.txt_StateInfo.Text = objInfo.StateInfo;
            this.txt_Odor.Text = objInfo.Odor;
            this.txt_Color.Text = objInfo.Color;
            this.txt_RelativeMolecularMass.Text = objInfo.RelativeMolecularMass.ToString();
            this.txt_Solubility.Text = objInfo.Solubility.ToString();
            this.txt_Density.Text = objInfo.Density.ToString();
            
        }
        //添加行号
        private void dgvInfoList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvInfoList, e);
        }


        private void FrmInfoManage_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“toxicDBDataSet5.Info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter.Fill(this.toxicDBDataSet5.Info);

        }

        

    }
}
