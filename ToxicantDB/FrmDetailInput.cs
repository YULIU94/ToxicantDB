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
        //定义用户成员变量
        private Info objCurrentInfo = null;

        //创建对象的容器(List泛型集合):用来保存查询结果
        private List<Info> listInfo = null;

        private FrmMain _parentForm;//(差异)
        public FrmDetailInput(FrmMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;//(差异)

            //初始化毒性等级下拉框
            this.cboToxicDegree.DataSource = objInfoManager.GetAllToxicDegree();
            this.cboToxicDegree.DisplayMember = "ToxicDegree";
            this.cboToxicDegree.ValueMember = "ToxicDegree";
            this.cboToxicDegree.SelectedIndex = -1;
            //初始化文本分类下拉框
            this.cboRichTextCategory.DataSource = objInfoManager.GetAllAidCategory();
            this.cboRichTextCategory.DisplayMember = "AidCategory";
            this.cboRichTextCategory.ValueMember = "AidCategory";
            this.cboRichTextCategory.SelectedIndex = 0;

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
                return;
            }
            
            else
            {
                //根据条件组合查询
                listInfo = objInfoManager.GetInfos(this.txtCasId.Text.ToString().Trim(), this.txtChemicalName.Text.Trim(), this.txtChineseName.Text.Trim(), this.txtTraditionName.Text.Trim(), this.txtRtecsId.Text.Trim());
                //在列表中显示查询结果
                this.dgvQueryResult.DataSource = null;
                this.dgvQueryResult.DataSource = listInfo;
            }
            if (this.dgvQueryResult.RowCount == 0)
            {
                MessageBox.Show("找不到对象！", "查询提示");
                return;
            }
            else
            {
                 //绑定当前对象
                if(this.txtCasId.Text.Trim().Length > 0 )
                {
                    objCurrentInfo = objInfoManager.GetInfoByCasId(this.txtCasId.Text.Trim());
                }
                else if(this.txtRtecsId.Text.Trim().Length > 0)
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
            this.dgvQueryResult.SelectionChanged += new EventHandler(this.dgvQueryResult_SelectionChanged);
            dgvQueryResult_SelectionChanged(null, null);//立刻进行一次同步
        }

        #endregion


        #region 同步显示要修改的信息
        private void dgvQueryResult_SelectionChanged(object sender, EventArgs e)
        {
            //刷新dgv的显示
            this.dgvQueryResult.Refresh();

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
            if (this.dgvQueryResult.RowCount == 0)
            {
                MessageBox.Show("找不到对象！", "查询提示");
                return;
            }
            if(this.txtLd50.Text.Trim().Length==0||this.cboToxicDegree.SelectedIndex==-1)
            {
                MessageBox.Show("请输入信息！", "保存提示");
            }
            else
            {
                
                    //调用后台添加信息对象
                    try
                    {
                        Info objInfo = new Info()
                        {
                            Ld50 = this.txtLd50.Text.Trim(),
                            ToxicDegree = this.cboToxicDegree.SelectedValue.ToString(),
                            CasId = this.objCurrentInfo.CasId
                        };

                        objInfoManager.EditOtherInfo(objInfo);//提交数据对象

                        //同步更新显示
                        Info editedInfo = (from i in this.listInfo where i.CasId.Equals(this.objCurrentInfo.CasId) select i).First<Info>();//找到对应修改的那一行
                        editedInfo.Ld50 = this.txtLd50.Text;
                        editedInfo.ToxicDegree =Convert.ToString( this.cboToxicDegree.SelectedValue);
                        //刷新dgv的显示
                        this.dgvQueryResult.Refresh();

                        foreach (Control item in this.gbOtherInfo.Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                        }
                        this.cboToxicDegree.SelectedIndex = 0;

                        MessageBox.Show("保存成功！", "保存提示");

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("添加出现异常: " + ex.Message, "错误提示");
                    }
                        
             }   
                        
        }


        //富文本信息保存
        private void btnRichTextSave_Click(object sender, EventArgs e)
        {
           if (this.dgvQueryResult.RowCount == 0)
            {
                MessageBox.Show("找不到对象！", "查询提示");
                return;
            }
           if(this.rtxtBox.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入文本信息！", "保存提示");

            }
            else
            {
                try
                {
                    if (this.cboRichTextCategory.SelectedValue.ToString() == "毒性信息")
                    {
                        Info objInfo = new Info()
                        {
                            CasId = this.objCurrentInfo.CasId,
                            ToxicDetail = this.rtxtBox.Text,
                            HealthHarzard = this.objCurrentInfo.HealthHarzard,
                            EnvironmentHarzard = this.objCurrentInfo.EnvironmentHarzard,
                            AidSkin = this.objCurrentInfo.AidSkin,
                            AidEye = this.objCurrentInfo.AidEye,
                            AidInhalation = this.objCurrentInfo.AidInhalation,
                            AidIngestion = this.objCurrentInfo.AidIngestion
                        };
                        //调用后台添加信息对象
                        try
                        {
                            objInfoManager.EditInfo(objInfo);//提交数据对象

                            //同步更新显示
                            Info editedInfo = (from i in this.listInfo where i.CasId.Equals(this.objCurrentInfo.CasId) select i).First<Info>();//找到对应修改的那一行
                            editedInfo.ToxicDetail = this.rtxtBox.Text;
                            //刷新dgv的显示
                            this.dgvQueryResult.Refresh();

                            this.rtxtBox.Clear();
                            MessageBox.Show("保存成功！", "保存提示");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("添加出现异常" + ex.Message, "错误提示");
                        }
                    }
                    if (this.cboRichTextCategory.SelectedValue.ToString() == "健康危害")
                    {
                        Info objInfo = new Info()
                        {
                            CasId = this.objCurrentInfo.CasId,
                            ToxicDetail = this.objCurrentInfo.ToxicDetail,
                            HealthHarzard = this.rtxtBox.Text,//测试
                            EnvironmentHarzard = this.objCurrentInfo.EnvironmentHarzard,
                            AidSkin = this.objCurrentInfo.AidSkin,
                            AidEye = this.objCurrentInfo.AidEye,
                            AidInhalation = this.objCurrentInfo.AidInhalation,
                            AidIngestion = this.objCurrentInfo.AidIngestion
                        };
                        //调用后台添加信息对象
                        try
                        {
                            objInfoManager.EditInfo(objInfo);//提交数据对象

                            //同步更新显示
                            Info editedInfo = (from i in this.listInfo where i.CasId.Equals(this.objCurrentInfo.CasId) select i).First<Info>();//找到对应修改的那一行
                            editedInfo.HealthHarzard = this.rtxtBox.Text;
                            //刷新dgv的显示
                            this.dgvQueryResult.Refresh();

                            this.rtxtBox.Clear();
                            MessageBox.Show("保存成功！", "保存提示");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("添加出现异常" + ex.Message, "错误提示");
                        }
                    }
                    if (this.cboRichTextCategory.SelectedValue.ToString() == "环境危害")
                    {
                        Info objInfo = new Info()
                        {
                            CasId = this.objCurrentInfo.CasId,
                            ToxicDetail = this.objCurrentInfo.ToxicDetail,
                            HealthHarzard = this.objCurrentInfo.HealthHarzard,
                            EnvironmentHarzard = this.rtxtBox.Text,
                            AidSkin = this.objCurrentInfo.AidSkin,
                            AidEye = this.objCurrentInfo.AidEye,
                            AidInhalation = this.objCurrentInfo.AidInhalation,
                            AidIngestion = this.objCurrentInfo.AidIngestion
                        };
                        //调用后台添加信息对象
                        try
                        {
                            objInfoManager.EditInfo(objInfo);//提交数据对象

                            //同步更新显示
                            Info editedInfo = (from i in this.listInfo where i.CasId.Equals(this.objCurrentInfo.CasId) select i).First<Info>();//找到对应修改的那一行
                            editedInfo.EnvironmentHarzard = this.rtxtBox.Text;
                            //刷新dgv的显示
                            this.dgvQueryResult.Refresh();

                            this.rtxtBox.Clear();
                            MessageBox.Show("保存成功！", "保存提示");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("添加出现异常" + ex.Message, "错误提示");
                        }
                    }
                    if (this.cboRichTextCategory.SelectedValue.ToString() == "皮肤接触急救方法")
                    {
                        Info objInfo = new Info()
                        {
                            CasId = this.objCurrentInfo.CasId,
                            ToxicDetail = this.objCurrentInfo.ToxicDetail,
                            HealthHarzard = this.objCurrentInfo.HealthHarzard,
                            EnvironmentHarzard = this.objCurrentInfo.EnvironmentHarzard,
                            AidSkin = this.rtxtBox.Text,
                            AidEye = this.objCurrentInfo.AidEye,
                            AidInhalation = this.objCurrentInfo.AidInhalation,
                            AidIngestion = this.objCurrentInfo.AidIngestion
                        };
                        //调用后台添加信息对象
                        try
                        {
                            objInfoManager.EditInfo(objInfo);//提交数据对象

                            //同步更新显示
                            Info editedInfo = (from i in this.listInfo where i.CasId.Equals(this.objCurrentInfo.CasId) select i).First<Info>();//找到对应修改的那一行
                            editedInfo.AidSkin = this.rtxtBox.Text;
                            //刷新dgv的显示
                            this.dgvQueryResult.Refresh();

                            this.rtxtBox.Clear();
                            MessageBox.Show("保存成功！", "保存提示");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("添加出现异常" + ex.Message, "错误提示");
                        }
                    }
                    if (this.cboRichTextCategory.SelectedValue.ToString() == "眼睛接触急救方法")
                    {
                        Info objInfo = new Info()
                        {
                            CasId = this.objCurrentInfo.CasId,
                            ToxicDetail = this.objCurrentInfo.ToxicDetail,
                            HealthHarzard = this.objCurrentInfo.HealthHarzard,
                            EnvironmentHarzard = this.objCurrentInfo.EnvironmentHarzard,
                            AidSkin = this.objCurrentInfo.AidSkin,
                            AidEye = this.rtxtBox.Text,
                            AidInhalation = this.objCurrentInfo.AidInhalation,
                            AidIngestion = this.objCurrentInfo.AidIngestion
                        };
                        //调用后台添加信息对象
                        try
                        {
                            objInfoManager.EditInfo(objInfo);//提交数据对象

                            //同步更新显示
                            Info editedInfo = (from i in this.listInfo where i.CasId.Equals(this.objCurrentInfo.CasId) select i).First<Info>();//找到对应修改的那一行
                            editedInfo.AidEye = this.rtxtBox.Text;
                            //刷新dgv的显示
                            this.dgvQueryResult.Refresh();

                            this.rtxtBox.Clear();
                            MessageBox.Show("保存成功！", "保存提示");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("添加出现异常" + ex.Message, "错误提示");
                        }
                    }
                    if (this.cboRichTextCategory.SelectedValue.ToString() == "吸入急救方法")
                    {
                        Info objInfo = new Info()
                        {
                            CasId = this.objCurrentInfo.CasId,
                            ToxicDetail = this.objCurrentInfo.ToxicDetail,
                            HealthHarzard = this.objCurrentInfo.HealthHarzard,
                            EnvironmentHarzard = this.objCurrentInfo.EnvironmentHarzard,
                            AidSkin = this.objCurrentInfo.AidSkin,
                            AidEye = this.objCurrentInfo.AidEye,
                            AidInhalation = this.rtxtBox.Text,
                            AidIngestion = this.objCurrentInfo.AidIngestion
                        };
                        //调用后台添加信息对象
                        try
                        {
                            objInfoManager.EditInfo(objInfo);//提交数据对象

                            //同步更新显示
                            Info editedInfo = (from i in this.listInfo where i.CasId.Equals(this.objCurrentInfo.CasId) select i).First<Info>();//找到对应修改的那一行
                            editedInfo.AidInhalation = this.rtxtBox.Text;
                            //刷新dgv的显示
                            this.dgvQueryResult.Refresh();

                            this.rtxtBox.Clear();
                            MessageBox.Show("保存成功！", "保存提示");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("添加出现异常" + ex.Message, "错误提示");
                        }
                    }
                    if (this.cboRichTextCategory.SelectedValue.ToString() == "误服急救方法")
                    {
                        Info objInfo = new Info()
                        {
                            CasId = this.objCurrentInfo.CasId,
                            ToxicDetail = this.objCurrentInfo.ToxicDetail,
                            HealthHarzard = this.objCurrentInfo.HealthHarzard,
                            EnvironmentHarzard = this.objCurrentInfo.EnvironmentHarzard,
                            AidSkin = this.objCurrentInfo.AidSkin,
                            AidEye = this.objCurrentInfo.AidEye,
                            AidInhalation = this.objCurrentInfo.AidInhalation,
                            AidIngestion = this.rtxtBox.Text
                        };
                        //调用后台添加信息对象
                        try
                        {
                            objInfoManager.EditInfo(objInfo);//提交数据对象

                            //同步更新显示
                            Info editedInfo = (from i in this.listInfo where i.CasId.Equals(this.objCurrentInfo.CasId) select i).First<Info>();//找到对应修改的那一行
                            editedInfo.AidIngestion = this.rtxtBox.Text;
                            //刷新dgv的显示
                            this.dgvQueryResult.Refresh();

                            this.rtxtBox.Clear();
                            MessageBox.Show("保存成功！", "保存提示");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("添加出现异常" + ex.Message, "错误提示");
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("添加出现异常: " + ex.Message, "错误提示");
                }
                
               };

        }

    }
}
