namespace ToxicantDB
{
    partial class FrmDetailInput
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbToxicQuery = new System.Windows.Forms.GroupBox();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.rtxtBox = new System.Windows.Forms.RichTextBox();
            this.gbRichText = new System.Windows.Forms.GroupBox();
            this.btnRichTextSave = new System.Windows.Forms.Button();
            this.cboRichTextCategory = new System.Windows.Forms.ComboBox();
            this.lblRichTextCategory = new System.Windows.Forms.Label();
            this.gbOtherInfo = new System.Windows.Forms.GroupBox();
            this.btnOtherInfoSave = new System.Windows.Forms.Button();
            this.cboToxicDegree = new System.Windows.Forms.ComboBox();
            this.lblToxicDegree = new System.Windows.Forms.Label();
            this.txtLd50 = new System.Windows.Forms.TextBox();
            this.lblLd50 = new System.Windows.Forms.Label();
            this.dgvQueryResult = new System.Windows.Forms.DataGridView();
            this.infoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toxicDBDataSet4 = new ToxicantDB.ToxicDBDataSet4();
            this.gbQueryResult = new System.Windows.Forms.GroupBox();
            this.toxicDBDataSet3 = new ToxicantDB.ToxicDBDataSet3();
            this.toxicDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter = new ToxicantDB.ToxicDBDataSet3TableAdapters.InfoTableAdapter();
            this.infoTableAdapter1 = new ToxicantDB.ToxicDBDataSet4TableAdapters.InfoTableAdapter();
            this.CasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraditionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RtecsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ld50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToxicDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToxicDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HealthHarzard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnvironmentHarzard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AidSkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AidEye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AidInhalation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AidIngestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbToxicQuery.SuspendLayout();
            this.gbRichText.SuspendLayout();
            this.gbOtherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbToxicQuery
            // 
            this.gbToxicQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbToxicQuery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbToxicQuery.Controls.Add(this.btnQuery);
            this.gbToxicQuery.Controls.Add(this.txtChineseName);
            this.gbToxicQuery.Controls.Add(this.lblChineseName);
            this.gbToxicQuery.Controls.Add(this.txtTraditionName);
            this.gbToxicQuery.Controls.Add(this.txtChemicalName);
            this.gbToxicQuery.Controls.Add(this.lblTraditionName);
            this.gbToxicQuery.Controls.Add(this.lblChemicalName);
            this.gbToxicQuery.Controls.Add(this.txtRtecsId);
            this.gbToxicQuery.Controls.Add(this.lblRtecsId);
            this.gbToxicQuery.Controls.Add(this.txtCasId);
            this.gbToxicQuery.Controls.Add(this.lblCasId);
            this.gbToxicQuery.Location = new System.Drawing.Point(27, 19);
            this.gbToxicQuery.Name = "gbToxicQuery";
            this.gbToxicQuery.Size = new System.Drawing.Size(806, 105);
            this.gbToxicQuery.TabIndex = 0;
            this.gbToxicQuery.TabStop = false;
            this.gbToxicQuery.Text = "按照条件查询";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(686, 25);
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
            this.txtChineseName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChineseName_KeyDown);
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
            this.txtTraditionName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTraditionName_KeyDown);
            // 
            // txtChemicalName
            // 
            this.txtChemicalName.Location = new System.Drawing.Point(309, 32);
            this.txtChemicalName.Name = "txtChemicalName";
            this.txtChemicalName.Size = new System.Drawing.Size(122, 21);
            this.txtChemicalName.TabIndex = 1;
            this.txtChemicalName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChemicalName_KeyDown);
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
            this.txtRtecsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRtecsId_KeyDown);
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
            this.txtCasId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCasId_KeyDown);
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(883, 44);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtxtBox
            // 
            this.rtxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtBox.Location = new System.Drawing.Point(7, 61);
            this.rtxtBox.Name = "rtxtBox";
            this.rtxtBox.Size = new System.Drawing.Size(490, 445);
            this.rtxtBox.TabIndex = 0;
            this.rtxtBox.Text = "";
            // 
            // gbRichText
            // 
            this.gbRichText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRichText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbRichText.Controls.Add(this.btnRichTextSave);
            this.gbRichText.Controls.Add(this.rtxtBox);
            this.gbRichText.Controls.Add(this.cboRichTextCategory);
            this.gbRichText.Controls.Add(this.lblRichTextCategory);
            this.gbRichText.Location = new System.Drawing.Point(500, 157);
            this.gbRichText.Name = "gbRichText";
            this.gbRichText.Size = new System.Drawing.Size(502, 512);
            this.gbRichText.TabIndex = 5;
            this.gbRichText.TabStop = false;
            this.gbRichText.Text = "毒物资料输入";
            // 
            // btnRichTextSave
            // 
            this.btnRichTextSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRichTextSave.Location = new System.Drawing.Point(383, 17);
            this.btnRichTextSave.Name = "btnRichTextSave";
            this.btnRichTextSave.Size = new System.Drawing.Size(86, 33);
            this.btnRichTextSave.TabIndex = 1;
            this.btnRichTextSave.Text = "保存";
            this.btnRichTextSave.UseVisualStyleBackColor = true;
            this.btnRichTextSave.Click += new System.EventHandler(this.btnRichTextSave_Click);
            // 
            // cboRichTextCategory
            // 
            this.cboRichTextCategory.FormattingEnabled = true;
            this.cboRichTextCategory.Location = new System.Drawing.Point(124, 24);
            this.cboRichTextCategory.Name = "cboRichTextCategory";
            this.cboRichTextCategory.Size = new System.Drawing.Size(179, 20);
            this.cboRichTextCategory.TabIndex = 0;
            // 
            // lblRichTextCategory
            // 
            this.lblRichTextCategory.AutoSize = true;
            this.lblRichTextCategory.Location = new System.Drawing.Point(29, 27);
            this.lblRichTextCategory.Name = "lblRichTextCategory";
            this.lblRichTextCategory.Size = new System.Drawing.Size(89, 12);
            this.lblRichTextCategory.TabIndex = 0;
            this.lblRichTextCategory.Text = "毒物资料分类 :";
            // 
            // gbOtherInfo
            // 
            this.gbOtherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOtherInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbOtherInfo.Controls.Add(this.btnOtherInfoSave);
            this.gbOtherInfo.Controls.Add(this.cboToxicDegree);
            this.gbOtherInfo.Controls.Add(this.lblToxicDegree);
            this.gbOtherInfo.Controls.Add(this.txtLd50);
            this.gbOtherInfo.Controls.Add(this.lblLd50);
            this.gbOtherInfo.Location = new System.Drawing.Point(27, 505);
            this.gbOtherInfo.Name = "gbOtherInfo";
            this.gbOtherInfo.Size = new System.Drawing.Size(453, 158);
            this.gbOtherInfo.TabIndex = 6;
            this.gbOtherInfo.TabStop = false;
            this.gbOtherInfo.Text = "其他信息";
            // 
            // btnOtherInfoSave
            // 
            this.btnOtherInfoSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtherInfoSave.Location = new System.Drawing.Point(329, 88);
            this.btnOtherInfoSave.Name = "btnOtherInfoSave";
            this.btnOtherInfoSave.Size = new System.Drawing.Size(86, 33);
            this.btnOtherInfoSave.TabIndex = 1;
            this.btnOtherInfoSave.Text = "保存";
            this.btnOtherInfoSave.UseVisualStyleBackColor = true;
            this.btnOtherInfoSave.Click += new System.EventHandler(this.btnOtherInfoSave_Click);
            // 
            // cboToxicDegree
            // 
            this.cboToxicDegree.FormattingEnabled = true;
            this.cboToxicDegree.Location = new System.Drawing.Point(102, 95);
            this.cboToxicDegree.Name = "cboToxicDegree";
            this.cboToxicDegree.Size = new System.Drawing.Size(144, 20);
            this.cboToxicDegree.TabIndex = 0;
            // 
            // lblToxicDegree
            // 
            this.lblToxicDegree.AutoSize = true;
            this.lblToxicDegree.Location = new System.Drawing.Point(31, 98);
            this.lblToxicDegree.Name = "lblToxicDegree";
            this.lblToxicDegree.Size = new System.Drawing.Size(65, 12);
            this.lblToxicDegree.TabIndex = 0;
            this.lblToxicDegree.Text = "毒性分级 :";
            // 
            // txtLd50
            // 
            this.txtLd50.Location = new System.Drawing.Point(102, 55);
            this.txtLd50.Name = "txtLd50";
            this.txtLd50.Size = new System.Drawing.Size(144, 21);
            this.txtLd50.TabIndex = 2;
            // 
            // lblLd50
            // 
            this.lblLd50.AutoSize = true;
            this.lblLd50.Location = new System.Drawing.Point(31, 58);
            this.lblLd50.Name = "lblLd50";
            this.lblLd50.Size = new System.Drawing.Size(59, 12);
            this.lblLd50.TabIndex = 0;
            this.lblLd50.Text = "Ld50    :";
            // 
            // dgvQueryResult
            // 
            this.dgvQueryResult.AllowUserToAddRows = false;
            this.dgvQueryResult.AllowUserToDeleteRows = false;
            this.dgvQueryResult.AutoGenerateColumns = false;
            this.dgvQueryResult.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQueryResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CasId,
            this.ChemicalName,
            this.ChineseName,
            this.TraditionName,
            this.RtecsId,
            this.Ld50,
            this.ToxicDegree,
            this.ToxicDetail,
            this.HealthHarzard,
            this.EnvironmentHarzard,
            this.AidSkin,
            this.AidEye,
            this.AidInhalation,
            this.AidIngestion});
            this.dgvQueryResult.DataSource = this.infoBindingSource1;
            this.dgvQueryResult.Location = new System.Drawing.Point(33, 177);
            this.dgvQueryResult.Name = "dgvQueryResult";
            this.dgvQueryResult.ReadOnly = true;
            this.dgvQueryResult.RowHeadersWidth = 46;
            this.dgvQueryResult.RowTemplate.Height = 23;
            this.dgvQueryResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueryResult.Size = new System.Drawing.Size(441, 307);
            this.dgvQueryResult.TabIndex = 7;
            // 
            // infoBindingSource1
            // 
            this.infoBindingSource1.DataMember = "Info";
            this.infoBindingSource1.DataSource = this.toxicDBDataSet4;
            // 
            // toxicDBDataSet4
            // 
            this.toxicDBDataSet4.DataSetName = "ToxicDBDataSet4";
            this.toxicDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbQueryResult
            // 
            this.gbQueryResult.Location = new System.Drawing.Point(27, 157);
            this.gbQueryResult.Name = "gbQueryResult";
            this.gbQueryResult.Size = new System.Drawing.Size(453, 333);
            this.gbQueryResult.TabIndex = 8;
            this.gbQueryResult.TabStop = false;
            this.gbQueryResult.Text = "查询结果";
            // 
            // toxicDBDataSet3
            // 
            this.toxicDBDataSet3.DataSetName = "ToxicDBDataSet3";
            this.toxicDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toxicDBDataSet3BindingSource
            // 
            this.toxicDBDataSet3BindingSource.DataSource = this.toxicDBDataSet3;
            this.toxicDBDataSet3BindingSource.Position = 0;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "Info";
            this.infoBindingSource.DataSource = this.toxicDBDataSet3BindingSource;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // infoTableAdapter1
            // 
            this.infoTableAdapter1.ClearBeforeFill = true;
            // 
            // CasId
            // 
            this.CasId.DataPropertyName = "CasId";
            this.CasId.HeaderText = "CasId编号";
            this.CasId.Name = "CasId";
            this.CasId.ReadOnly = true;
            // 
            // ChemicalName
            // 
            this.ChemicalName.DataPropertyName = "ChemicalName";
            this.ChemicalName.HeaderText = "化学名";
            this.ChemicalName.Name = "ChemicalName";
            this.ChemicalName.ReadOnly = true;
            // 
            // ChineseName
            // 
            this.ChineseName.DataPropertyName = "ChineseName";
            this.ChineseName.HeaderText = "中文名";
            this.ChineseName.Name = "ChineseName";
            this.ChineseName.ReadOnly = true;
            // 
            // TraditionName
            // 
            this.TraditionName.DataPropertyName = "TraditionName";
            this.TraditionName.HeaderText = "俗名";
            this.TraditionName.Name = "TraditionName";
            this.TraditionName.ReadOnly = true;
            // 
            // RtecsId
            // 
            this.RtecsId.DataPropertyName = "RtecsId";
            this.RtecsId.HeaderText = "RtecsId编号";
            this.RtecsId.Name = "RtecsId";
            this.RtecsId.ReadOnly = true;
            // 
            // Ld50
            // 
            this.Ld50.DataPropertyName = "Ld50";
            this.Ld50.HeaderText = "Ld50";
            this.Ld50.Name = "Ld50";
            this.Ld50.ReadOnly = true;
            // 
            // ToxicDegree
            // 
            this.ToxicDegree.DataPropertyName = "ToxicDegree";
            this.ToxicDegree.HeaderText = "毒性等级";
            this.ToxicDegree.Name = "ToxicDegree";
            this.ToxicDegree.ReadOnly = true;
            // 
            // ToxicDetail
            // 
            this.ToxicDetail.DataPropertyName = "ToxicDetail";
            this.ToxicDetail.HeaderText = "毒性信息";
            this.ToxicDetail.Name = "ToxicDetail";
            this.ToxicDetail.ReadOnly = true;
            // 
            // HealthHarzard
            // 
            this.HealthHarzard.DataPropertyName = "HealthHarzard";
            this.HealthHarzard.HeaderText = "健康危害";
            this.HealthHarzard.Name = "HealthHarzard";
            this.HealthHarzard.ReadOnly = true;
            // 
            // EnvironmentHarzard
            // 
            this.EnvironmentHarzard.DataPropertyName = "EnvironmentHarzard";
            this.EnvironmentHarzard.HeaderText = "环境危害";
            this.EnvironmentHarzard.Name = "EnvironmentHarzard";
            this.EnvironmentHarzard.ReadOnly = true;
            // 
            // AidSkin
            // 
            this.AidSkin.DataPropertyName = "AidSkin";
            this.AidSkin.HeaderText = "皮肤接触急救";
            this.AidSkin.Name = "AidSkin";
            this.AidSkin.ReadOnly = true;
            // 
            // AidEye
            // 
            this.AidEye.DataPropertyName = "AidEye";
            this.AidEye.HeaderText = "眼部接触急救";
            this.AidEye.Name = "AidEye";
            this.AidEye.ReadOnly = true;
            // 
            // AidInhalation
            // 
            this.AidInhalation.DataPropertyName = "AidInhalation";
            this.AidInhalation.HeaderText = "毒物吸入急救";
            this.AidInhalation.Name = "AidInhalation";
            this.AidInhalation.ReadOnly = true;
            // 
            // AidIngestion
            // 
            this.AidIngestion.DataPropertyName = "AidIngestion";
            this.AidIngestion.HeaderText = "毒物摄入急救";
            this.AidIngestion.Name = "AidIngestion";
            this.AidIngestion.ReadOnly = true;
            // 
            // FrmDetailInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.dgvQueryResult);
            this.Controls.Add(this.gbOtherInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbToxicQuery);
            this.Controls.Add(this.gbRichText);
            this.Controls.Add(this.gbQueryResult);
            this.Name = "FrmDetailInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "详细信息输入";
            this.Load += new System.EventHandler(this.FrmDetailInput_Load);
            this.gbToxicQuery.ResumeLayout(false);
            this.gbToxicQuery.PerformLayout();
            this.gbRichText.ResumeLayout(false);
            this.gbRichText.PerformLayout();
            this.gbOtherInfo.ResumeLayout(false);
            this.gbOtherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbToxicQuery;
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
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtxtBox;
        private System.Windows.Forms.GroupBox gbRichText;
        private System.Windows.Forms.ComboBox cboRichTextCategory;
        private System.Windows.Forms.Label lblRichTextCategory;
        private System.Windows.Forms.GroupBox gbOtherInfo;
        private System.Windows.Forms.Button btnOtherInfoSave;
        private System.Windows.Forms.TextBox txtLd50;
        private System.Windows.Forms.Label lblLd50;
        private System.Windows.Forms.ComboBox cboToxicDegree;
        private System.Windows.Forms.Label lblToxicDegree;
        private System.Windows.Forms.DataGridView dgvQueryResult;
        private System.Windows.Forms.GroupBox gbQueryResult;
        private System.Windows.Forms.BindingSource toxicDBDataSet3BindingSource;
        private ToxicDBDataSet3 toxicDBDataSet3;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private ToxicDBDataSet3TableAdapters.InfoTableAdapter infoTableAdapter;
        private ToxicDBDataSet4 toxicDBDataSet4;
        private System.Windows.Forms.BindingSource infoBindingSource1;
        private ToxicDBDataSet4TableAdapters.InfoTableAdapter infoTableAdapter1;
        private System.Windows.Forms.Button btnRichTextSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraditionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RtecsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ld50;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToxicDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToxicDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn HealthHarzard;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnvironmentHarzard;
        private System.Windows.Forms.DataGridViewTextBoxColumn AidSkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AidEye;
        private System.Windows.Forms.DataGridViewTextBoxColumn AidInhalation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AidIngestion;
    }
}