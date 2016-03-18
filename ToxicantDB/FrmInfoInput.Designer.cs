namespace ToxicantDB
{
    partial class FrmInfoInput
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
            this.lblCasId = new System.Windows.Forms.Label();
            this.txtCasId = new System.Windows.Forms.TextBox();
            this.lblChemicalName = new System.Windows.Forms.Label();
            this.txtChemicalName = new System.Windows.Forms.TextBox();
            this.lblChineseName = new System.Windows.Forms.Label();
            this.txtChineseName = new System.Windows.Forms.TextBox();
            this.lblTraditionalName = new System.Windows.Forms.Label();
            this.txtTraditionName = new System.Windows.Forms.TextBox();
            this.lblRtecsId = new System.Windows.Forms.Label();
            this.txtRtecsId = new System.Windows.Forms.TextBox();
            this.DescCasId = new System.Windows.Forms.Label();
            this.DescChemicalName = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOdor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStateInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtRelativeMolecularMass = new System.Windows.Forms.TextBox();
            this.DescSolubility = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolubility = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.DescDensity = new System.Windows.Forms.Label();
            this.gbInputProperty = new System.Windows.Forms.GroupBox();
            this.gbInputInfo = new System.Windows.Forms.GroupBox();
            this.dgvInfoList = new System.Windows.Forms.DataGridView();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toxicDBDataSet = new ToxicantDB.ToxicDBDataSet();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter = new ToxicantDB.ToxicDBDataSetTableAdapters.InfoTableAdapter();
            this.propertiesTableAdapter = new ToxicantDB.ToxicDBDataSetTableAdapters.PropertiesTableAdapter();
            this.btnInputClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.toxicDBDataSet1 = new ToxicantDB.ToxicDBDataSet1();
            this.infoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter1 = new ToxicantDB.ToxicDBDataSet1TableAdapters.InfoTableAdapter();
            this.toxicDBDataSet2 = new ToxicantDB.ToxicDBDataSet2();
            this.infoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter2 = new ToxicantDB.ToxicDBDataSet2TableAdapters.InfoTableAdapter();
            this.toxicDBDataSet3 = new ToxicantDB.ToxicDBDataSet3();
            this.infoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter3 = new ToxicantDB.ToxicDBDataSet3TableAdapters.InfoTableAdapter();
            this.casIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraditionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RtecsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelativeMolecularMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solubility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Density = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCasId
            // 
            this.lblCasId.AutoSize = true;
            this.lblCasId.Location = new System.Drawing.Point(72, 56);
            this.lblCasId.Name = "lblCasId";
            this.lblCasId.Size = new System.Drawing.Size(53, 12);
            this.lblCasId.TabIndex = 0;
            this.lblCasId.Text = "CAS ID :";
            // 
            // txtCasId
            // 
            this.txtCasId.Location = new System.Drawing.Point(160, 53);
            this.txtCasId.Name = "txtCasId";
            this.txtCasId.Size = new System.Drawing.Size(100, 21);
            this.txtCasId.TabIndex = 0;
            this.txtCasId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCasId_KeyDown);
            this.txtCasId.Leave += new System.EventHandler(this.txtCasId_Leave);
            // 
            // lblChemicalName
            // 
            this.lblChemicalName.AutoSize = true;
            this.lblChemicalName.Location = new System.Drawing.Point(72, 98);
            this.lblChemicalName.Name = "lblChemicalName";
            this.lblChemicalName.Size = new System.Drawing.Size(53, 12);
            this.lblChemicalName.TabIndex = 0;
            this.lblChemicalName.Text = "化学名 :";
            // 
            // txtChemicalName
            // 
            this.txtChemicalName.Location = new System.Drawing.Point(160, 95);
            this.txtChemicalName.Name = "txtChemicalName";
            this.txtChemicalName.Size = new System.Drawing.Size(100, 21);
            this.txtChemicalName.TabIndex = 1;
            // 
            // lblChineseName
            // 
            this.lblChineseName.AutoSize = true;
            this.lblChineseName.Location = new System.Drawing.Point(72, 140);
            this.lblChineseName.Name = "lblChineseName";
            this.lblChineseName.Size = new System.Drawing.Size(53, 12);
            this.lblChineseName.TabIndex = 0;
            this.lblChineseName.Text = "中文名 :";
            // 
            // txtChineseName
            // 
            this.txtChineseName.Location = new System.Drawing.Point(160, 137);
            this.txtChineseName.Name = "txtChineseName";
            this.txtChineseName.Size = new System.Drawing.Size(100, 21);
            this.txtChineseName.TabIndex = 2;
            // 
            // lblTraditionalName
            // 
            this.lblTraditionalName.AutoSize = true;
            this.lblTraditionalName.Location = new System.Drawing.Point(72, 182);
            this.lblTraditionalName.Name = "lblTraditionalName";
            this.lblTraditionalName.Size = new System.Drawing.Size(41, 12);
            this.lblTraditionalName.TabIndex = 0;
            this.lblTraditionalName.Text = "俗名 :";
            // 
            // txtTraditionName
            // 
            this.txtTraditionName.Location = new System.Drawing.Point(160, 179);
            this.txtTraditionName.Name = "txtTraditionName";
            this.txtTraditionName.Size = new System.Drawing.Size(100, 21);
            this.txtTraditionName.TabIndex = 3;
            // 
            // lblRtecsId
            // 
            this.lblRtecsId.AutoSize = true;
            this.lblRtecsId.Location = new System.Drawing.Point(72, 224);
            this.lblRtecsId.Name = "lblRtecsId";
            this.lblRtecsId.Size = new System.Drawing.Size(65, 12);
            this.lblRtecsId.TabIndex = 0;
            this.lblRtecsId.Text = "RTECS ID :";
            // 
            // txtRtecsId
            // 
            this.txtRtecsId.Location = new System.Drawing.Point(160, 221);
            this.txtRtecsId.Name = "txtRtecsId";
            this.txtRtecsId.Size = new System.Drawing.Size(100, 21);
            this.txtRtecsId.TabIndex = 4;
            // 
            // DescCasId
            // 
            this.DescCasId.AutoSize = true;
            this.DescCasId.Location = new System.Drawing.Point(266, 56);
            this.DescCasId.Name = "DescCasId";
            this.DescCasId.Size = new System.Drawing.Size(11, 12);
            this.DescCasId.TabIndex = 5;
            this.DescCasId.Text = "*";
            // 
            // DescChemicalName
            // 
            this.DescChemicalName.AutoSize = true;
            this.DescChemicalName.Location = new System.Drawing.Point(266, 98);
            this.DescChemicalName.Name = "DescChemicalName";
            this.DescChemicalName.Size = new System.Drawing.Size(11, 12);
            this.DescChemicalName.TabIndex = 6;
            this.DescChemicalName.Text = "*";
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Location = new System.Drawing.Point(414, 56);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(65, 12);
            this.lblElement.TabIndex = 0;
            this.lblElement.Text = "所含元素 :";
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(502, 53);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(100, 21);
            this.txtElement.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "气味 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "状态 :";
            // 
            // txtOdor
            // 
            this.txtOdor.Location = new System.Drawing.Point(502, 137);
            this.txtOdor.Name = "txtOdor";
            this.txtOdor.Size = new System.Drawing.Size(100, 21);
            this.txtOdor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "颜色 :";
            // 
            // txtStateInfo
            // 
            this.txtStateInfo.Location = new System.Drawing.Point(502, 95);
            this.txtStateInfo.Name = "txtStateInfo";
            this.txtStateInfo.Size = new System.Drawing.Size(100, 21);
            this.txtStateInfo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "相对分子质量 :";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(502, 179);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 21);
            this.txtColor.TabIndex = 8;
            // 
            // txtRelativeMolecularMass
            // 
            this.txtRelativeMolecularMass.Location = new System.Drawing.Point(502, 221);
            this.txtRelativeMolecularMass.Name = "txtRelativeMolecularMass";
            this.txtRelativeMolecularMass.Size = new System.Drawing.Size(100, 21);
            this.txtRelativeMolecularMass.TabIndex = 9;
            this.txtRelativeMolecularMass.Text = "0";
            // 
            // DescSolubility
            // 
            this.DescSolubility.AutoSize = true;
            this.DescSolubility.Location = new System.Drawing.Point(883, 59);
            this.DescSolubility.Name = "DescSolubility";
            this.DescSolubility.Size = new System.Drawing.Size(71, 12);
            this.DescSolubility.TabIndex = 6;
            this.DescSolubility.Text = "(g/100g 水)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "溶解度 :";
            // 
            // txtSolubility
            // 
            this.txtSolubility.Location = new System.Drawing.Point(777, 56);
            this.txtSolubility.Name = "txtSolubility";
            this.txtSolubility.Size = new System.Drawing.Size(100, 21);
            this.txtSolubility.TabIndex = 10;
            this.txtSolubility.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "密度 :";
            // 
            // txtDensity
            // 
            this.txtDensity.Location = new System.Drawing.Point(777, 98);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(100, 21);
            this.txtDensity.TabIndex = 11;
            this.txtDensity.Text = "0";
            // 
            // DescDensity
            // 
            this.DescDensity.AutoSize = true;
            this.DescDensity.Location = new System.Drawing.Point(883, 101);
            this.DescDensity.Name = "DescDensity";
            this.DescDensity.Size = new System.Drawing.Size(47, 12);
            this.DescDensity.TabIndex = 6;
            this.DescDensity.Text = "(g/cm3)";
            // 
            // gbInputProperty
            // 
            this.gbInputProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInputProperty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbInputProperty.Location = new System.Drawing.Point(372, 12);
            this.gbInputProperty.Name = "gbInputProperty";
            this.gbInputProperty.Size = new System.Drawing.Size(614, 244);
            this.gbInputProperty.TabIndex = 13;
            this.gbInputProperty.TabStop = false;
            this.gbInputProperty.Text = "理化性质输入";
            // 
            // gbInputInfo
            // 
            this.gbInputInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInputInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbInputInfo.Location = new System.Drawing.Point(24, 12);
            this.gbInputInfo.Name = "gbInputInfo";
            this.gbInputInfo.Size = new System.Drawing.Size(306, 292);
            this.gbInputInfo.TabIndex = 8;
            this.gbInputInfo.TabStop = false;
            this.gbInputInfo.Text = "基本信息输入";
            // 
            // dgvInfoList
            // 
            this.dgvInfoList.AllowUserToAddRows = false;
            this.dgvInfoList.AllowUserToDeleteRows = false;
            this.dgvInfoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoList.AutoGenerateColumns = false;
            this.dgvInfoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.casIdDataGridViewTextBoxColumn,
            this.ChemicalName,
            this.ChineseName,
            this.TraditionName,
            this.RtecsId,
            this.Element,
            this.StateInfo,
            this.Odor,
            this.Color,
            this.RelativeMolecularMass,
            this.Solubility,
            this.Density});
            this.dgvInfoList.DataSource = this.infoBindingSource3;
            this.dgvInfoList.Location = new System.Drawing.Point(24, 310);
            this.dgvInfoList.Name = "dgvInfoList";
            this.dgvInfoList.ReadOnly = true;
            this.dgvInfoList.RowTemplate.Height = 23;
            this.dgvInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoList.Size = new System.Drawing.Size(962, 346);
            this.dgvInfoList.TabIndex = 9;
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.toxicDBDataSet;
            // 
            // toxicDBDataSet
            // 
            this.toxicDBDataSet.DataSetName = "ToxicDBDataSet";
            this.toxicDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "Info";
            this.infoBindingSource.DataSource = this.toxicDBDataSet;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // btnInputClose
            // 
            this.btnInputClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputClose.Location = new System.Drawing.Point(890, 267);
            this.btnInputClose.Name = "btnInputClose";
            this.btnInputClose.Size = new System.Drawing.Size(96, 32);
            this.btnInputClose.TabIndex = 14;
            this.btnInputClose.Text = "关闭窗口";
            this.btnInputClose.UseVisualStyleBackColor = true;
            this.btnInputClose.Click += new System.EventHandler(this.btnInputClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(759, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保存信息";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toxicDBDataSet1
            // 
            this.toxicDBDataSet1.DataSetName = "ToxicDBDataSet1";
            this.toxicDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource1
            // 
            this.infoBindingSource1.DataMember = "Info";
            this.infoBindingSource1.DataSource = this.toxicDBDataSet1;
            // 
            // infoTableAdapter1
            // 
            this.infoTableAdapter1.ClearBeforeFill = true;
            // 
            // toxicDBDataSet2
            // 
            this.toxicDBDataSet2.DataSetName = "ToxicDBDataSet2";
            this.toxicDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource2
            // 
            this.infoBindingSource2.DataMember = "Info";
            this.infoBindingSource2.DataSource = this.toxicDBDataSet2;
            // 
            // infoTableAdapter2
            // 
            this.infoTableAdapter2.ClearBeforeFill = true;
            // 
            // toxicDBDataSet3
            // 
            this.toxicDBDataSet3.DataSetName = "ToxicDBDataSet3";
            this.toxicDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource3
            // 
            this.infoBindingSource3.DataMember = "Info";
            this.infoBindingSource3.DataSource = this.toxicDBDataSet3;
            // 
            // infoTableAdapter3
            // 
            this.infoTableAdapter3.ClearBeforeFill = true;
            // 
            // casIdDataGridViewTextBoxColumn
            // 
            this.casIdDataGridViewTextBoxColumn.DataPropertyName = "CasId";
            this.casIdDataGridViewTextBoxColumn.HeaderText = "CasId";
            this.casIdDataGridViewTextBoxColumn.Name = "casIdDataGridViewTextBoxColumn";
            this.casIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ChemicalName
            // 
            this.ChemicalName.DataPropertyName = "ChemicalName";
            this.ChemicalName.HeaderText = "ChemicalName";
            this.ChemicalName.Name = "ChemicalName";
            this.ChemicalName.ReadOnly = true;
            // 
            // ChineseName
            // 
            this.ChineseName.DataPropertyName = "ChineseName";
            this.ChineseName.HeaderText = "ChineseName";
            this.ChineseName.Name = "ChineseName";
            this.ChineseName.ReadOnly = true;
            // 
            // TraditionName
            // 
            this.TraditionName.DataPropertyName = "TraditionName";
            this.TraditionName.HeaderText = "TraditionName";
            this.TraditionName.Name = "TraditionName";
            this.TraditionName.ReadOnly = true;
            // 
            // RtecsId
            // 
            this.RtecsId.DataPropertyName = "RtecsId";
            this.RtecsId.HeaderText = "RtecsId";
            this.RtecsId.Name = "RtecsId";
            this.RtecsId.ReadOnly = true;
            // 
            // Element
            // 
            this.Element.DataPropertyName = "Element";
            this.Element.HeaderText = "Element";
            this.Element.Name = "Element";
            this.Element.ReadOnly = true;
            // 
            // StateInfo
            // 
            this.StateInfo.DataPropertyName = "StateInfo";
            this.StateInfo.HeaderText = "StateInfo";
            this.StateInfo.Name = "StateInfo";
            this.StateInfo.ReadOnly = true;
            // 
            // Odor
            // 
            this.Odor.DataPropertyName = "Odor";
            this.Odor.HeaderText = "Odor";
            this.Odor.Name = "Odor";
            this.Odor.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // RelativeMolecularMass
            // 
            this.RelativeMolecularMass.DataPropertyName = "RelativeMolecularMass";
            this.RelativeMolecularMass.HeaderText = "RelativeMolecularMass";
            this.RelativeMolecularMass.Name = "RelativeMolecularMass";
            this.RelativeMolecularMass.ReadOnly = true;
            // 
            // Solubility
            // 
            this.Solubility.DataPropertyName = "Solubility";
            this.Solubility.HeaderText = "Solubility";
            this.Solubility.Name = "Solubility";
            this.Solubility.ReadOnly = true;
            // 
            // Density
            // 
            this.Density.DataPropertyName = "Density";
            this.Density.HeaderText = "Density";
            this.Density.Name = "Density";
            this.Density.ReadOnly = true;
            // 
            // FrmInfoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInputClose);
            this.Controls.Add(this.dgvInfoList);
            this.Controls.Add(this.DescDensity);
            this.Controls.Add(this.DescSolubility);
            this.Controls.Add(this.DescChemicalName);
            this.Controls.Add(this.DescCasId);
            this.Controls.Add(this.txtRelativeMolecularMass);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtRtecsId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTraditionName);
            this.Controls.Add(this.txtDensity);
            this.Controls.Add(this.txtStateInfo);
            this.Controls.Add(this.lblRtecsId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChemicalName);
            this.Controls.Add(this.txtOdor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTraditionalName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChineseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSolubility);
            this.Controls.Add(this.lblChemicalName);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChineseName);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.txtCasId);
            this.Controls.Add(this.lblCasId);
            this.Controls.Add(this.gbInputProperty);
            this.Controls.Add(this.gbInputInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInfoInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入信息";
            this.Load += new System.EventHandler(this.FrmInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toxicDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCasId;
        private System.Windows.Forms.TextBox txtCasId;
        private System.Windows.Forms.Label lblChemicalName;
        private System.Windows.Forms.TextBox txtChemicalName;
        private System.Windows.Forms.Label lblChineseName;
        private System.Windows.Forms.TextBox txtChineseName;
        private System.Windows.Forms.Label lblTraditionalName;
        private System.Windows.Forms.TextBox txtTraditionName;
        private System.Windows.Forms.Label lblRtecsId;
        private System.Windows.Forms.TextBox txtRtecsId;
        private System.Windows.Forms.Label DescCasId;
        private System.Windows.Forms.Label DescChemicalName;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOdor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStateInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtRelativeMolecularMass;
        private System.Windows.Forms.Label DescSolubility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSolubility;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.Label DescDensity;
        private System.Windows.Forms.GroupBox gbInputProperty;
        private System.Windows.Forms.GroupBox gbInputInfo;
        private System.Windows.Forms.DataGridView dgvInfoList;
        private ToxicDBDataSet toxicDBDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private ToxicDBDataSetTableAdapters.InfoTableAdapter infoTableAdapter;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private ToxicDBDataSetTableAdapters.PropertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.Button btnInputClose;
        private System.Windows.Forms.Button btnSave;
        private ToxicDBDataSet1 toxicDBDataSet1;
        private System.Windows.Forms.BindingSource infoBindingSource1;
        private ToxicDBDataSet1TableAdapters.InfoTableAdapter infoTableAdapter1;
        private ToxicDBDataSet2 toxicDBDataSet2;
        private System.Windows.Forms.BindingSource infoBindingSource2;
        private ToxicDBDataSet2TableAdapters.InfoTableAdapter infoTableAdapter2;
        private ToxicDBDataSet3 toxicDBDataSet3;
        private System.Windows.Forms.BindingSource infoBindingSource3;
        private ToxicDBDataSet3TableAdapters.InfoTableAdapter infoTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn casIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraditionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RtecsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Element;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelativeMolecularMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solubility;
        private System.Windows.Forms.DataGridViewTextBoxColumn Density;
    }
}