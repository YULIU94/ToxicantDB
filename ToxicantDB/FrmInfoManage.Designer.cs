namespace ToxicantDB
{
    partial class FrmInfoManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbInfoQuery = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtChineseName = new System.Windows.Forms.TextBox();
            this.lblChineseName = new System.Windows.Forms.Label();
            this.txtTraditionName = new System.Windows.Forms.TextBox();
            this.txtChemicalName = new System.Windows.Forms.TextBox();
            this.lblTraditionName = new System.Windows.Forms.Label();
            this.lblChemicalName = new System.Windows.Forms.Label();
            this.txtRtecsId = new System.Windows.Forms.TextBox();
            this.lblRtecsId = new System.Windows.Forms.Label();
            this.txtCasId = new System.Windows.Forms.TextBox();
            this.lblCasId = new System.Windows.Forms.Label();
            this.dgvInfoList = new System.Windows.Forms.DataGridView();
            this.gbInfoEdit = new System.Windows.Forms.GroupBox();
            this.txt_RelativeMolecularMass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.txt_RtecsId = new System.Windows.Forms.TextBox();
            this.lbl_RelativeMolecularMass = new System.Windows.Forms.Label();
            this.txt_TraditionName = new System.Windows.Forms.TextBox();
            this.txt_Density = new System.Windows.Forms.TextBox();
            this.txt_StateInfo = new System.Windows.Forms.TextBox();
            this.lbl_TraditionName = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.txt_ChemicalName = new System.Windows.Forms.TextBox();
            this.txt_Odor = new System.Windows.Forms.TextBox();
            this.lbl_Density = new System.Windows.Forms.Label();
            this.lbl_TraditionalName = new System.Windows.Forms.Label();
            this.lbl_StateInfo = new System.Windows.Forms.Label();
            this.txt_ChineseName = new System.Windows.Forms.TextBox();
            this.lbl_Odor = new System.Windows.Forms.Label();
            this.txt_Solubility = new System.Windows.Forms.TextBox();
            this.lbl_ChemicalName = new System.Windows.Forms.Label();
            this.txt_Element = new System.Windows.Forms.TextBox();
            this.lbl_Solubility = new System.Windows.Forms.Label();
            this.lbl_ChineseName = new System.Windows.Forms.Label();
            this.lbl_Element = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.toxicDBDataSet4 = new ToxicantDB.ToxicDBDataSet4();
            this.toxicDBDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toxicDBDataSet5 = new ToxicantDB.ToxicDBDataSet5();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter = new ToxicantDB.ToxicDBDataSet5TableAdapters.InfoTableAdapter();
            this.casIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chineseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traditionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtecsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relativeMolecularMassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solubilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.densityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ld50DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toxicDegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toxicDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthHarzardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.environmentHarzardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidSkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidEyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidInhalationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidIngestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfoQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoList)).BeginInit();
            this.gbInfoEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoQuery
            // 
            this.gbInfoQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfoQuery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbInfoQuery.Controls.Add(this.btnDel);
            this.gbInfoQuery.Controls.Add(this.btnQuery);
            this.gbInfoQuery.Controls.Add(this.txtChineseName);
            this.gbInfoQuery.Controls.Add(this.lblChineseName);
            this.gbInfoQuery.Controls.Add(this.txtTraditionName);
            this.gbInfoQuery.Controls.Add(this.txtChemicalName);
            this.gbInfoQuery.Controls.Add(this.lblTraditionName);
            this.gbInfoQuery.Controls.Add(this.lblChemicalName);
            this.gbInfoQuery.Controls.Add(this.txtRtecsId);
            this.gbInfoQuery.Controls.Add(this.lblRtecsId);
            this.gbInfoQuery.Controls.Add(this.txtCasId);
            this.gbInfoQuery.Controls.Add(this.lblCasId);
            this.gbInfoQuery.Location = new System.Drawing.Point(12, 12);
            this.gbInfoQuery.MinimumSize = new System.Drawing.Size(800, 105);
            this.gbInfoQuery.Name = "gbInfoQuery";
            this.gbInfoQuery.Size = new System.Drawing.Size(800, 105);
            this.gbInfoQuery.TabIndex = 1;
            this.gbInfoQuery.TabStop = false;
            this.gbInfoQuery.Text = "按照条件查询";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(680, 62);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 32);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(680, 25);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(86, 32);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtChineseName
            // 
            this.txtChineseName.Location = new System.Drawing.Point(508, 32);
            this.txtChineseName.Name = "txtChineseName";
            this.txtChineseName.Size = new System.Drawing.Size(122, 21);
            this.txtChineseName.TabIndex = 2;
            // 
            // lblChineseName
            // 
            this.lblChineseName.AutoSize = true;
            this.lblChineseName.Location = new System.Drawing.Point(449, 35);
            this.lblChineseName.Name = "lblChineseName";
            this.lblChineseName.Size = new System.Drawing.Size(53, 12);
            this.lblChineseName.TabIndex = 0;
            this.lblChineseName.Text = "中文名 :";
            // 
            // txtTraditionName
            // 
            this.txtTraditionName.Location = new System.Drawing.Point(309, 69);
            this.txtTraditionName.Name = "txtTraditionName";
            this.txtTraditionName.Size = new System.Drawing.Size(122, 21);
            this.txtTraditionName.TabIndex = 4;
            // 
            // txtChemicalName
            // 
            this.txtChemicalName.Location = new System.Drawing.Point(309, 32);
            this.txtChemicalName.Name = "txtChemicalName";
            this.txtChemicalName.Size = new System.Drawing.Size(122, 21);
            this.txtChemicalName.TabIndex = 1;
            // 
            // lblTraditionName
            // 
            this.lblTraditionName.AutoSize = true;
            this.lblTraditionName.Location = new System.Drawing.Point(250, 72);
            this.lblTraditionName.Name = "lblTraditionName";
            this.lblTraditionName.Size = new System.Drawing.Size(53, 12);
            this.lblTraditionName.TabIndex = 0;
            this.lblTraditionName.Text = "俗名   :";
            // 
            // lblChemicalName
            // 
            this.lblChemicalName.AutoSize = true;
            this.lblChemicalName.Location = new System.Drawing.Point(250, 35);
            this.lblChemicalName.Name = "lblChemicalName";
            this.lblChemicalName.Size = new System.Drawing.Size(53, 12);
            this.lblChemicalName.TabIndex = 0;
            this.lblChemicalName.Text = "化学名 :";
            // 
            // txtRtecsId
            // 
            this.txtRtecsId.Location = new System.Drawing.Point(112, 69);
            this.txtRtecsId.Name = "txtRtecsId";
            this.txtRtecsId.Size = new System.Drawing.Size(122, 21);
            this.txtRtecsId.TabIndex = 3;
            // 
            // lblRtecsId
            // 
            this.lblRtecsId.AutoSize = true;
            this.lblRtecsId.Location = new System.Drawing.Point(29, 72);
            this.lblRtecsId.Name = "lblRtecsId";
            this.lblRtecsId.Size = new System.Drawing.Size(65, 12);
            this.lblRtecsId.TabIndex = 0;
            this.lblRtecsId.Text = "Rtecs ID :";
            // 
            // txtCasId
            // 
            this.txtCasId.Location = new System.Drawing.Point(112, 32);
            this.txtCasId.Name = "txtCasId";
            this.txtCasId.Size = new System.Drawing.Size(122, 21);
            this.txtCasId.TabIndex = 0;
            // 
            // lblCasId
            // 
            this.lblCasId.AutoSize = true;
            this.lblCasId.Location = new System.Drawing.Point(29, 35);
            this.lblCasId.Name = "lblCasId";
            this.lblCasId.Size = new System.Drawing.Size(65, 12);
            this.lblCasId.TabIndex = 0;
            this.lblCasId.Text = "CAS ID   :";
            // 
            // dgvInfoList
            // 
            this.dgvInfoList.AllowUserToAddRows = false;
            this.dgvInfoList.AllowUserToDeleteRows = false;
            this.dgvInfoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoList.AutoGenerateColumns = false;
            this.dgvInfoList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.casIdDataGridViewTextBoxColumn,
            this.chemicalNameDataGridViewTextBoxColumn,
            this.chineseNameDataGridViewTextBoxColumn,
            this.traditionNameDataGridViewTextBoxColumn,
            this.rtecsIdDataGridViewTextBoxColumn,
            this.elementDataGridViewTextBoxColumn,
            this.stateInfoDataGridViewTextBoxColumn,
            this.odorDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.relativeMolecularMassDataGridViewTextBoxColumn,
            this.solubilityDataGridViewTextBoxColumn,
            this.densityDataGridViewTextBoxColumn,
            this.ld50DataGridViewTextBoxColumn,
            this.toxicDegreeDataGridViewTextBoxColumn,
            this.toxicDetailDataGridViewTextBoxColumn,
            this.healthHarzardDataGridViewTextBoxColumn,
            this.environmentHarzardDataGridViewTextBoxColumn,
            this.aidSkinDataGridViewTextBoxColumn,
            this.aidEyeDataGridViewTextBoxColumn,
            this.aidInhalationDataGridViewTextBoxColumn,
            this.aidIngestionDataGridViewTextBoxColumn});
            this.dgvInfoList.DataSource = this.infoBindingSource;
            this.dgvInfoList.Location = new System.Drawing.Point(12, 123);
            this.dgvInfoList.MinimumSize = new System.Drawing.Size(992, 226);
            this.dgvInfoList.Name = "dgvInfoList";
            this.dgvInfoList.ReadOnly = true;
            this.dgvInfoList.RowTemplate.Height = 23;
            this.dgvInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoList.Size = new System.Drawing.Size(992, 286);
            this.dgvInfoList.TabIndex = 2;
            this.dgvInfoList.SelectionChanged += new System.EventHandler(this.dgvInfoList_SelectionChanged);
            // 
            // gbInfoEdit
            // 
            this.gbInfoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfoEdit.Controls.Add(this.txt_RelativeMolecularMass);
            this.gbInfoEdit.Controls.Add(this.btnSave);
            this.gbInfoEdit.Controls.Add(this.txt_Color);
            this.gbInfoEdit.Controls.Add(this.txt_RtecsId);
            this.gbInfoEdit.Controls.Add(this.lbl_RelativeMolecularMass);
            this.gbInfoEdit.Controls.Add(this.txt_TraditionName);
            this.gbInfoEdit.Controls.Add(this.txt_Density);
            this.gbInfoEdit.Controls.Add(this.txt_StateInfo);
            this.gbInfoEdit.Controls.Add(this.lbl_TraditionName);
            this.gbInfoEdit.Controls.Add(this.lbl_Color);
            this.gbInfoEdit.Controls.Add(this.txt_ChemicalName);
            this.gbInfoEdit.Controls.Add(this.txt_Odor);
            this.gbInfoEdit.Controls.Add(this.lbl_Density);
            this.gbInfoEdit.Controls.Add(this.lbl_TraditionalName);
            this.gbInfoEdit.Controls.Add(this.lbl_StateInfo);
            this.gbInfoEdit.Controls.Add(this.txt_ChineseName);
            this.gbInfoEdit.Controls.Add(this.lbl_Odor);
            this.gbInfoEdit.Controls.Add(this.txt_Solubility);
            this.gbInfoEdit.Controls.Add(this.lbl_ChemicalName);
            this.gbInfoEdit.Controls.Add(this.txt_Element);
            this.gbInfoEdit.Controls.Add(this.lbl_Solubility);
            this.gbInfoEdit.Controls.Add(this.lbl_ChineseName);
            this.gbInfoEdit.Controls.Add(this.lbl_Element);
            this.gbInfoEdit.Location = new System.Drawing.Point(12, 415);
            this.gbInfoEdit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.gbInfoEdit.Name = "gbInfoEdit";
            this.gbInfoEdit.Size = new System.Drawing.Size(992, 254);
            this.gbInfoEdit.TabIndex = 3;
            this.gbInfoEdit.TabStop = false;
            this.gbInfoEdit.Text = "基本信息修改";
            // 
            // txt_RelativeMolecularMass
            // 
            this.txt_RelativeMolecularMass.Location = new System.Drawing.Point(338, 201);
            this.txt_RelativeMolecularMass.Name = "txt_RelativeMolecularMass";
            this.txt_RelativeMolecularMass.Size = new System.Drawing.Size(100, 21);
            this.txt_RelativeMolecularMass.TabIndex = 31;
            this.txt_RelativeMolecularMass.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(868, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(338, 159);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 21);
            this.txt_Color.TabIndex = 30;
            // 
            // txt_RtecsId
            // 
            this.txt_RtecsId.Location = new System.Drawing.Point(117, 159);
            this.txt_RtecsId.Name = "txt_RtecsId";
            this.txt_RtecsId.Size = new System.Drawing.Size(100, 21);
            this.txt_RtecsId.TabIndex = 26;
            // 
            // lbl_RelativeMolecularMass
            // 
            this.lbl_RelativeMolecularMass.AutoSize = true;
            this.lbl_RelativeMolecularMass.Location = new System.Drawing.Point(250, 204);
            this.lbl_RelativeMolecularMass.Name = "lbl_RelativeMolecularMass";
            this.lbl_RelativeMolecularMass.Size = new System.Drawing.Size(89, 12);
            this.lbl_RelativeMolecularMass.TabIndex = 20;
            this.lbl_RelativeMolecularMass.Text = "相对分子质量 :";
            // 
            // txt_TraditionName
            // 
            this.txt_TraditionName.Location = new System.Drawing.Point(117, 117);
            this.txt_TraditionName.Name = "txt_TraditionName";
            this.txt_TraditionName.Size = new System.Drawing.Size(100, 21);
            this.txt_TraditionName.TabIndex = 25;
            // 
            // txt_Density
            // 
            this.txt_Density.Location = new System.Drawing.Point(552, 75);
            this.txt_Density.Name = "txt_Density";
            this.txt_Density.Size = new System.Drawing.Size(100, 21);
            this.txt_Density.TabIndex = 33;
            this.txt_Density.Text = "0";
            // 
            // txt_StateInfo
            // 
            this.txt_StateInfo.Location = new System.Drawing.Point(338, 75);
            this.txt_StateInfo.Name = "txt_StateInfo";
            this.txt_StateInfo.Size = new System.Drawing.Size(100, 21);
            this.txt_StateInfo.TabIndex = 28;
            // 
            // lbl_TraditionName
            // 
            this.lbl_TraditionName.AutoSize = true;
            this.lbl_TraditionName.Location = new System.Drawing.Point(29, 162);
            this.lbl_TraditionName.Name = "lbl_TraditionName";
            this.lbl_TraditionName.Size = new System.Drawing.Size(65, 12);
            this.lbl_TraditionName.TabIndex = 18;
            this.lbl_TraditionName.Text = "RTECS ID :";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(250, 162);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(41, 12);
            this.lbl_Color.TabIndex = 19;
            this.lbl_Color.Text = "颜色 :";
            // 
            // txt_ChemicalName
            // 
            this.txt_ChemicalName.Location = new System.Drawing.Point(117, 33);
            this.txt_ChemicalName.Name = "txt_ChemicalName";
            this.txt_ChemicalName.Size = new System.Drawing.Size(100, 21);
            this.txt_ChemicalName.TabIndex = 23;
            // 
            // txt_Odor
            // 
            this.txt_Odor.Location = new System.Drawing.Point(338, 117);
            this.txt_Odor.Name = "txt_Odor";
            this.txt_Odor.Size = new System.Drawing.Size(100, 21);
            this.txt_Odor.TabIndex = 29;
            // 
            // lbl_Density
            // 
            this.lbl_Density.AutoSize = true;
            this.lbl_Density.Location = new System.Drawing.Point(464, 78);
            this.lbl_Density.Name = "lbl_Density";
            this.lbl_Density.Size = new System.Drawing.Size(41, 12);
            this.lbl_Density.TabIndex = 15;
            this.lbl_Density.Text = "密度 :";
            // 
            // lbl_TraditionalName
            // 
            this.lbl_TraditionalName.AutoSize = true;
            this.lbl_TraditionalName.Location = new System.Drawing.Point(29, 120);
            this.lbl_TraditionalName.Name = "lbl_TraditionalName";
            this.lbl_TraditionalName.Size = new System.Drawing.Size(41, 12);
            this.lbl_TraditionalName.TabIndex = 14;
            this.lbl_TraditionalName.Text = "俗名 :";
            // 
            // lbl_StateInfo
            // 
            this.lbl_StateInfo.AutoSize = true;
            this.lbl_StateInfo.Location = new System.Drawing.Point(250, 78);
            this.lbl_StateInfo.Name = "lbl_StateInfo";
            this.lbl_StateInfo.Size = new System.Drawing.Size(41, 12);
            this.lbl_StateInfo.TabIndex = 13;
            this.lbl_StateInfo.Text = "状态 :";
            // 
            // txt_ChineseName
            // 
            this.txt_ChineseName.Location = new System.Drawing.Point(117, 75);
            this.txt_ChineseName.Name = "txt_ChineseName";
            this.txt_ChineseName.Size = new System.Drawing.Size(100, 21);
            this.txt_ChineseName.TabIndex = 24;
            // 
            // lbl_Odor
            // 
            this.lbl_Odor.AutoSize = true;
            this.lbl_Odor.Location = new System.Drawing.Point(250, 120);
            this.lbl_Odor.Name = "lbl_Odor";
            this.lbl_Odor.Size = new System.Drawing.Size(41, 12);
            this.lbl_Odor.TabIndex = 17;
            this.lbl_Odor.Text = "气味 :";
            // 
            // txt_Solubility
            // 
            this.txt_Solubility.Location = new System.Drawing.Point(552, 33);
            this.txt_Solubility.Name = "txt_Solubility";
            this.txt_Solubility.Size = new System.Drawing.Size(100, 21);
            this.txt_Solubility.TabIndex = 32;
            this.txt_Solubility.Text = "0";
            // 
            // lbl_ChemicalName
            // 
            this.lbl_ChemicalName.AutoSize = true;
            this.lbl_ChemicalName.Location = new System.Drawing.Point(29, 36);
            this.lbl_ChemicalName.Name = "lbl_ChemicalName";
            this.lbl_ChemicalName.Size = new System.Drawing.Size(53, 12);
            this.lbl_ChemicalName.TabIndex = 22;
            this.lbl_ChemicalName.Text = "化学名 :";
            // 
            // txt_Element
            // 
            this.txt_Element.Location = new System.Drawing.Point(338, 33);
            this.txt_Element.Name = "txt_Element";
            this.txt_Element.Size = new System.Drawing.Size(100, 21);
            this.txt_Element.TabIndex = 27;
            // 
            // lbl_Solubility
            // 
            this.lbl_Solubility.AutoSize = true;
            this.lbl_Solubility.Location = new System.Drawing.Point(464, 36);
            this.lbl_Solubility.Name = "lbl_Solubility";
            this.lbl_Solubility.Size = new System.Drawing.Size(53, 12);
            this.lbl_Solubility.TabIndex = 21;
            this.lbl_Solubility.Text = "溶解度 :";
            // 
            // lbl_ChineseName
            // 
            this.lbl_ChineseName.AutoSize = true;
            this.lbl_ChineseName.Location = new System.Drawing.Point(29, 78);
            this.lbl_ChineseName.Name = "lbl_ChineseName";
            this.lbl_ChineseName.Size = new System.Drawing.Size(53, 12);
            this.lbl_ChineseName.TabIndex = 16;
            this.lbl_ChineseName.Text = "中文名 :";
            // 
            // lbl_Element
            // 
            this.lbl_Element.AutoSize = true;
            this.lbl_Element.Location = new System.Drawing.Point(250, 36);
            this.lbl_Element.Name = "lbl_Element";
            this.lbl_Element.Size = new System.Drawing.Size(65, 12);
            this.lbl_Element.TabIndex = 12;
            this.lbl_Element.Text = "所含元素 :";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(880, 37);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toxicDBDataSet4
            // 
            this.toxicDBDataSet4.DataSetName = "ToxicDBDataSet4";
            this.toxicDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toxicDBDataSet4BindingSource
            // 
            this.toxicDBDataSet4BindingSource.DataSource = this.toxicDBDataSet4;
            this.toxicDBDataSet4BindingSource.Position = 0;
            // 
            // toxicDBDataSet5
            // 
            this.toxicDBDataSet5.DataSetName = "ToxicDBDataSet5";
            this.toxicDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "Info";
            this.infoBindingSource.DataSource = this.toxicDBDataSet5;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // casIdDataGridViewTextBoxColumn
            // 
            this.casIdDataGridViewTextBoxColumn.DataPropertyName = "CasId";
            this.casIdDataGridViewTextBoxColumn.HeaderText = "CasId编号";
            this.casIdDataGridViewTextBoxColumn.Name = "casIdDataGridViewTextBoxColumn";
            this.casIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chemicalNameDataGridViewTextBoxColumn
            // 
            this.chemicalNameDataGridViewTextBoxColumn.DataPropertyName = "ChemicalName";
            this.chemicalNameDataGridViewTextBoxColumn.HeaderText = "化学名";
            this.chemicalNameDataGridViewTextBoxColumn.Name = "chemicalNameDataGridViewTextBoxColumn";
            this.chemicalNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chineseNameDataGridViewTextBoxColumn
            // 
            this.chineseNameDataGridViewTextBoxColumn.DataPropertyName = "ChineseName";
            this.chineseNameDataGridViewTextBoxColumn.HeaderText = "中文名";
            this.chineseNameDataGridViewTextBoxColumn.Name = "chineseNameDataGridViewTextBoxColumn";
            this.chineseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // traditionNameDataGridViewTextBoxColumn
            // 
            this.traditionNameDataGridViewTextBoxColumn.DataPropertyName = "TraditionName";
            this.traditionNameDataGridViewTextBoxColumn.HeaderText = "俗名";
            this.traditionNameDataGridViewTextBoxColumn.Name = "traditionNameDataGridViewTextBoxColumn";
            this.traditionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rtecsIdDataGridViewTextBoxColumn
            // 
            this.rtecsIdDataGridViewTextBoxColumn.DataPropertyName = "RtecsId";
            this.rtecsIdDataGridViewTextBoxColumn.HeaderText = "RtecsId编号";
            this.rtecsIdDataGridViewTextBoxColumn.Name = "rtecsIdDataGridViewTextBoxColumn";
            this.rtecsIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elementDataGridViewTextBoxColumn
            // 
            this.elementDataGridViewTextBoxColumn.DataPropertyName = "Element";
            this.elementDataGridViewTextBoxColumn.HeaderText = "所含元素";
            this.elementDataGridViewTextBoxColumn.Name = "elementDataGridViewTextBoxColumn";
            this.elementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateInfoDataGridViewTextBoxColumn
            // 
            this.stateInfoDataGridViewTextBoxColumn.DataPropertyName = "StateInfo";
            this.stateInfoDataGridViewTextBoxColumn.HeaderText = "状态";
            this.stateInfoDataGridViewTextBoxColumn.Name = "stateInfoDataGridViewTextBoxColumn";
            this.stateInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odorDataGridViewTextBoxColumn
            // 
            this.odorDataGridViewTextBoxColumn.DataPropertyName = "Odor";
            this.odorDataGridViewTextBoxColumn.HeaderText = "气味";
            this.odorDataGridViewTextBoxColumn.Name = "odorDataGridViewTextBoxColumn";
            this.odorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relativeMolecularMassDataGridViewTextBoxColumn
            // 
            this.relativeMolecularMassDataGridViewTextBoxColumn.DataPropertyName = "RelativeMolecularMass";
            this.relativeMolecularMassDataGridViewTextBoxColumn.HeaderText = "相对分子质量";
            this.relativeMolecularMassDataGridViewTextBoxColumn.Name = "relativeMolecularMassDataGridViewTextBoxColumn";
            this.relativeMolecularMassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solubilityDataGridViewTextBoxColumn
            // 
            this.solubilityDataGridViewTextBoxColumn.DataPropertyName = "Solubility";
            this.solubilityDataGridViewTextBoxColumn.HeaderText = "溶解度";
            this.solubilityDataGridViewTextBoxColumn.Name = "solubilityDataGridViewTextBoxColumn";
            this.solubilityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // densityDataGridViewTextBoxColumn
            // 
            this.densityDataGridViewTextBoxColumn.DataPropertyName = "Density";
            this.densityDataGridViewTextBoxColumn.HeaderText = "密度";
            this.densityDataGridViewTextBoxColumn.Name = "densityDataGridViewTextBoxColumn";
            this.densityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ld50DataGridViewTextBoxColumn
            // 
            this.ld50DataGridViewTextBoxColumn.DataPropertyName = "Ld50";
            this.ld50DataGridViewTextBoxColumn.HeaderText = "Ld50";
            this.ld50DataGridViewTextBoxColumn.Name = "ld50DataGridViewTextBoxColumn";
            this.ld50DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toxicDegreeDataGridViewTextBoxColumn
            // 
            this.toxicDegreeDataGridViewTextBoxColumn.DataPropertyName = "ToxicDegree";
            this.toxicDegreeDataGridViewTextBoxColumn.HeaderText = "毒性等级";
            this.toxicDegreeDataGridViewTextBoxColumn.Name = "toxicDegreeDataGridViewTextBoxColumn";
            this.toxicDegreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toxicDetailDataGridViewTextBoxColumn
            // 
            this.toxicDetailDataGridViewTextBoxColumn.DataPropertyName = "ToxicDetail";
            this.toxicDetailDataGridViewTextBoxColumn.HeaderText = "毒性信息";
            this.toxicDetailDataGridViewTextBoxColumn.Name = "toxicDetailDataGridViewTextBoxColumn";
            this.toxicDetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // healthHarzardDataGridViewTextBoxColumn
            // 
            this.healthHarzardDataGridViewTextBoxColumn.DataPropertyName = "HealthHarzard";
            this.healthHarzardDataGridViewTextBoxColumn.HeaderText = "健康危害";
            this.healthHarzardDataGridViewTextBoxColumn.Name = "healthHarzardDataGridViewTextBoxColumn";
            this.healthHarzardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // environmentHarzardDataGridViewTextBoxColumn
            // 
            this.environmentHarzardDataGridViewTextBoxColumn.DataPropertyName = "EnvironmentHarzard";
            this.environmentHarzardDataGridViewTextBoxColumn.HeaderText = "环境危害";
            this.environmentHarzardDataGridViewTextBoxColumn.Name = "environmentHarzardDataGridViewTextBoxColumn";
            this.environmentHarzardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aidSkinDataGridViewTextBoxColumn
            // 
            this.aidSkinDataGridViewTextBoxColumn.DataPropertyName = "AidSkin";
            this.aidSkinDataGridViewTextBoxColumn.HeaderText = "皮肤接触急救方法";
            this.aidSkinDataGridViewTextBoxColumn.Name = "aidSkinDataGridViewTextBoxColumn";
            this.aidSkinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aidEyeDataGridViewTextBoxColumn
            // 
            this.aidEyeDataGridViewTextBoxColumn.DataPropertyName = "AidEye";
            this.aidEyeDataGridViewTextBoxColumn.HeaderText = "眼部接触急救方法";
            this.aidEyeDataGridViewTextBoxColumn.Name = "aidEyeDataGridViewTextBoxColumn";
            this.aidEyeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aidInhalationDataGridViewTextBoxColumn
            // 
            this.aidInhalationDataGridViewTextBoxColumn.DataPropertyName = "AidInhalation";
            this.aidInhalationDataGridViewTextBoxColumn.HeaderText = "毒物吸入急救方法";
            this.aidInhalationDataGridViewTextBoxColumn.Name = "aidInhalationDataGridViewTextBoxColumn";
            this.aidInhalationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aidIngestionDataGridViewTextBoxColumn
            // 
            this.aidIngestionDataGridViewTextBoxColumn.DataPropertyName = "AidIngestion";
            this.aidIngestionDataGridViewTextBoxColumn.HeaderText = "毒物误食急救方法";
            this.aidIngestionDataGridViewTextBoxColumn.Name = "aidIngestionDataGridViewTextBoxColumn";
            this.aidIngestionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 681);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbInfoEdit);
            this.Controls.Add(this.dgvInfoList);
            this.Controls.Add(this.gbInfoQuery);
            this.Name = "FrmInfoManage";
            this.Text = "基本信息修改";
            this.Load += new System.EventHandler(this.FrmInfoManage_Load);
            this.gbInfoQuery.ResumeLayout(false);
            this.gbInfoQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoList)).EndInit();
            this.gbInfoEdit.ResumeLayout(false);
            this.gbInfoEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtChineseName;
        private System.Windows.Forms.Label lblChineseName;
        private System.Windows.Forms.TextBox txtTraditionName;
        private System.Windows.Forms.TextBox txtChemicalName;
        private System.Windows.Forms.Label lblTraditionName;
        private System.Windows.Forms.Label lblChemicalName;
        private System.Windows.Forms.TextBox txtRtecsId;
        private System.Windows.Forms.Label lblRtecsId;
        private System.Windows.Forms.TextBox txtCasId;
        private System.Windows.Forms.Label lblCasId;
        private System.Windows.Forms.DataGridView dgvInfoList;
        private System.Windows.Forms.GroupBox gbInfoEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txt_RelativeMolecularMass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.TextBox txt_RtecsId;
        private System.Windows.Forms.Label lbl_RelativeMolecularMass;
        private System.Windows.Forms.TextBox txt_TraditionName;
        private System.Windows.Forms.TextBox txt_Density;
        private System.Windows.Forms.TextBox txt_StateInfo;
        private System.Windows.Forms.Label lbl_TraditionName;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.TextBox txt_ChemicalName;
        private System.Windows.Forms.TextBox txt_Odor;
        private System.Windows.Forms.Label lbl_Density;
        private System.Windows.Forms.Label lbl_TraditionalName;
        private System.Windows.Forms.Label lbl_StateInfo;
        private System.Windows.Forms.TextBox txt_ChineseName;
        private System.Windows.Forms.Label lbl_Odor;
        private System.Windows.Forms.TextBox txt_Solubility;
        private System.Windows.Forms.Label lbl_ChemicalName;
        private System.Windows.Forms.TextBox txt_Element;
        private System.Windows.Forms.Label lbl_Solubility;
        private System.Windows.Forms.Label lbl_ChineseName;
        private System.Windows.Forms.Label lbl_Element;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource toxicDBDataSet4BindingSource;
        private ToxicDBDataSet4 toxicDBDataSet4;
        private ToxicDBDataSet5 toxicDBDataSet5;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private ToxicDBDataSet5TableAdapters.InfoTableAdapter infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn casIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chineseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traditionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtecsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relativeMolecularMassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solubilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn densityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ld50DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toxicDegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toxicDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthHarzardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn environmentHarzardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidSkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidEyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidInhalationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidIngestionDataGridViewTextBoxColumn;
    }
}