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
    public partial class FrmInfoInput : Form
    {
        private InfoManager objInfoManager = new InfoManager();
        private List<Info> InfoList = new List<Info>();


        private FrmMain _parentForm;//(差异)

        public FrmInfoInput(FrmMain parentForm)
        {
            InitializeComponent();

            //启动时清空列表
            this.dgvInfoList.DataSource = null;

            //禁止数据列表控件dgv自动生成列
            this.dgvInfoList.AutoGenerateColumns = false;
            new Common.DataGridViewStyle().DgvStyle1(this.dgvInfoList);

            _parentForm = parentForm;//(差异)
        }

        private void FrmInput_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“toxicDBDataSet3.Info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter3.Fill(this.toxicDBDataSet3.Info);
            // TODO:  这行代码将数据加载到表“toxicDBDataSet2.Info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter2.Fill(this.toxicDBDataSet2.Info);
            // TODO:  这行代码将数据加载到表“toxicDBDataSet1.Info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter1.Fill(this.toxicDBDataSet1.Info);
            //// TODO:  这行代码将数据加载到表“toxicDBDataSet.Properties”中。您可以根据需要移动或删除它。
            //this.propertiesTableAdapter.Fill(this.toxicDBDataSet.Properties);
            //// TODO:  这行代码将数据加载到表“toxicDBDataSet.Info”中。您可以根据需要移动或删除它。
            //this.infoTableAdapter.Fill(this.toxicDBDataSet.Info);

        }

        //鼠标离开时或者按下回车时检测
        private void txtCasId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)//此处调用相同的功能，精简代码
            {
                txtCasId_KeyDown(null, null);
            }
        }
        private void txtCasId_Leave(object sender, EventArgs e)
        {
            
            if (Convert.ToString(this.txtCasId.Text.Trim()).Length > 0)
            {
                if (this.objInfoManager.CasIdIsExisted(Convert.ToString(this.txtCasId.Text.Trim())))
                {
                    MessageBox.Show("该CAS ID编号已经存在！", "提示信息");
                    this.txtCasId.SelectAll();
                    this.txtCasId.Focus();

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 数据验证
            //CAS ID编号
            if (this.txtCasId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入CAS ID编号！", "保存信息");
                this.txtCasId.Focus();
                return;
            }
            //化学名
            if (this.txtChemicalName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入化学名！", "保存信息");
                this.txtChemicalName.Focus();
                return;
            }
            //相对分子质量
            if (!this.objInfoManager.IsNonNegativeFloat( this.txtRelativeMolecularMass.Text.Trim()))
            {
                MessageBox.Show("相对分子质量的值应为非负数字", "保存信息");
                this.txtRelativeMolecularMass.SelectAll();
                this.txtRelativeMolecularMass.Focus();
                return;
            }
            //溶解度
            if (!this.objInfoManager.IsNonNegativeFloat(this.txtSolubility.Text.Trim()))
            {
                MessageBox.Show("溶解度的值应为非负数字", "保存信息");
                this.txtSolubility.SelectAll();
                this.txtSolubility.Focus();
                return;
            }
            //密度
            if (!this.objInfoManager.IsNonNegativeFloat(this.txtDensity.Text.Trim()))
            {
                MessageBox.Show("密度的值应为非负数字", "保存信息");
                this.txtDensity.SelectAll();
                this.txtDensity.Focus();
                return;
            }

            #endregion

            //封装对象

            Info objInfo = new Info()
            {
                CasId = this.txtCasId.Text.Trim(),
                ChemicalName = this.txtChemicalName.Text.Trim(),
                ChineseName = this.txtChineseName.Text.Trim(),
                TraditionName = this.txtTraditionName.Text.Trim(),
                RtecsId = this.txtRtecsId.Text.Trim(),
                Element = this.txtElement.Text.Trim(),
                StateInfo = this.txtStateInfo.Text.Trim(),
                Odor = this.txtOdor.Text.Trim(),
                Color = this.txtColor.Text.Trim(),
                RelativeMolecularMass = Convert.ToDouble( this.txtRelativeMolecularMass.Text.Trim()),
                Solubility = Convert.ToDouble( this.txtSolubility.Text.Trim()),
                Density = Convert.ToDouble( this.txtDensity.Text.Trim())
            };

            //调用后台添加信息对象
            try
            {
                objInfoManager.AddInfo(objInfo);//提交数据对象

                this.InfoList.Add(objInfo);
                this.dgvInfoList.DataSource = null;
                this.dgvInfoList.DataSource = this.InfoList;

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
                this.txtRelativeMolecularMass.Text = "0";
                this.txtSolubility.Text = "0";
                this.txtDensity.Text = "0";
            }
            catch(Exception ex)
            {
                MessageBox.Show("添加出现异常" + ex.Message, "错误提示");
            }
        }

        private void btnInputClose_Click(object sender, EventArgs e)
        {
            _parentForm.setLblCurrentText();//(差异)
            this.Close();
        }

        //添加行号
        private void dgvInfoList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvInfoList, e);
        }
    }
}
