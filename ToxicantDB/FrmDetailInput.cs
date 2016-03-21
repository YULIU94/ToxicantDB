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
    public partial class FrmDetailInput : Form
    {
        private InfoManager objInfoManager = new InfoManager();
        
        //创建对象的容器(List泛型集合):用来保存查询结果
        private List<Info> listInfo = null;

        private FrmMain _parentForm;//(差异)
        public FrmDetailInput(FrmMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;//(差异)

            //初始化图书分类下拉框
            this.cboToxicDegree.DataSource = objInfoManager.GetAllToxicDegree();
            this.cboToxicDegree.DisplayMember = "ToxicDegree";
            //this.cboToxicDegree.ValueMember = "ToxicId";
            this.cboToxicDegree.SelectedIndex = -1;

            //禁用数据列表自动生成列
            this.dgvQueryResult.AutoGenerateColumns = false;
            new Common.DataGridViewStyle().DgvStyle1(this.dgvQueryResult);
            this.dgvQueryResult.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            _parentForm.setLblCurrentText();//(差异)
        }


        #region 组合查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //首先断开选择改变事件（防止有些情况的异常）
            this.dgvQueryResult.SelectionChanged -= new EventHandler(this.dgvQueryResult_SelectionChanged);


            //判断用户是否输入条件
            if (this.txtCasId.Text.Trim().Length == 0 && this.txtChemicalName.Text.Trim().Length == 0 && this.txtChineseName.Text.Trim().Length == 0 && this.txtTraditionName.Text.Trim().Length == 0 && this.txtRtecsId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请至少选择一个查询条件！", "查询提示");
            }
            else
            {
                //根据条件组合查询
                listInfo = objInfoManager.GetInfos(this.txtCasId.Text.ToString().Trim(), this.txtChemicalName.Text.Trim(), this.txtChineseName.Text.Trim(), this.txtTraditionName.Text.Trim(), this.txtRtecsId.Text.Trim());
                //在列表中显示查询结果
                this.dgvQueryResult.DataSource = null;
                this.dgvQueryResult.DataSource = listInfo;
            }
            //开启选择改变事件
            this.dgvQueryResult.SelectionChanged += new EventHandler(this.dgvQueryResult_SelectionChanged);
            dgvQueryResult_SelectionChanged(null, null);//立刻进行一次同步
        }

        #endregion


        #region 同步显示要修改的信息
        private void dgvQueryResult_SelectionChanged(object sender, EventArgs e)
        {
            //刷新dgv的显示
            this.dgvQueryResult.Refresh();

            if (this.dgvQueryResult.RowCount == 0)
            {
                MessageBox.Show("找不到对象！", "查询提示");
                return;
            }

            //string casId = this.dgvQueryResult.CurrentRow.Cells["CasId"].Value.ToString();
            //Info objInfo = (from i in listInfo where i.CasId.Equals(casId) select i).First<Info>();//在泛型集合列表中查找符合的行及其属性（无需去数据库查找）

        }

        #endregion






        //添加行号
        private void dgvInfoList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvQueryResult, e);
        }

        private void FrmDetailInput_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“toxicDBDataSet4.Info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter1.Fill(this.toxicDBDataSet4.Info);
            // TODO:  这行代码将数据加载到表“toxicDBDataSet3.Info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter.Fill(this.toxicDBDataSet3.Info);

        }

        private void btnOtherInfoSave_Click(object sender, EventArgs e)
        {
            if(this.txtLd50.Text.Trim().Length==0||this.cboToxicDegree.SelectedIndex==-1)
            {
                MessageBox.Show("请输入信息！", "保存提示");
            }
            else
            {
                Info objInfo = new Info()
                {
                    Ld50 = this.txtLd50.Text.Trim(),
                    ToxicDegree = this.cboToxicDegree.SelectedValue.ToString()

                    //调用后台添加信息对象
                    try
                    {
                        objInfoManager.AddInfo(objInfo);//提交数据对象

                        this..Add(objInfo);
                        this.dgvInfoList.DataSource = null;
                        this.dgvInfoList.DataSource = this.InfoList;

                        foreach (Control item in this.gbInputInfo.Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                        }
                        foreach (Control item in this.gbInputProperty.Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                        }
                
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("添加出现异常" + ex.Message, "错误提示");
                    }
                        };
                    }
        }



    }
}
