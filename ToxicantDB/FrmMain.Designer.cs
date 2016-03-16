namespace ToxicantDB
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_Current = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnQueryToxic = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPwdModification = new System.Windows.Forms.Button();
            this.btnInfoMaintenance = new System.Windows.Forms.Button();
            this.btnQueryAid = new System.Windows.Forms.Button();
            this.btnQueryProperty = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tssl_AdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 21);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 21);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackgroundImage = global::ToxicantDB.Properties.Resources.Image1;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Current);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.btnQueryToxic);
            this.splitContainer1.Panel1.Controls.Add(this.btnUserManagement);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuit);
            this.splitContainer1.Panel1.Controls.Add(this.btnPwdModification);
            this.splitContainer1.Panel1.Controls.Add(this.btnInfoMaintenance);
            this.splitContainer1.Panel1.Controls.Add(this.btnQueryAid);
            this.splitContainer1.Panel1.Controls.Add(this.btnQueryProperty);
            this.splitContainer1.Panel1.Controls.Add(this.btnInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 656);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // lbl_Current
            // 
            this.lbl_Current.AutoSize = true;
            this.lbl_Current.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Current.Location = new System.Drawing.Point(51, 71);
            this.lbl_Current.Name = "lbl_Current";
            this.lbl_Current.Size = new System.Drawing.Size(138, 28);
            this.lbl_Current.TabIndex = 3;
            this.lbl_Current.Text = "毒物管理系统";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Version});
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(238, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Version
            // 
            this.tssl_Version.Name = "tssl_Version";
            this.tssl_Version.Size = new System.Drawing.Size(164, 17);
            this.tssl_Version.Text = "毒物数据库系统 版本号V0.10";
            // 
            // btnQueryToxic
            // 
            this.btnQueryToxic.Location = new System.Drawing.Point(140, 217);
            this.btnQueryToxic.Name = "btnQueryToxic";
            this.btnQueryToxic.Size = new System.Drawing.Size(82, 41);
            this.btnQueryToxic.TabIndex = 1;
            this.btnQueryToxic.Text = "毒性查询";
            this.btnQueryToxic.UseVisualStyleBackColor = true;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(140, 358);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(82, 41);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "用户管理";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(140, 433);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(82, 41);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "退出系统";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnPwdModification
            // 
            this.btnPwdModification.Location = new System.Drawing.Point(21, 433);
            this.btnPwdModification.Name = "btnPwdModification";
            this.btnPwdModification.Size = new System.Drawing.Size(82, 41);
            this.btnPwdModification.TabIndex = 1;
            this.btnPwdModification.Text = "密码修改";
            this.btnPwdModification.UseVisualStyleBackColor = true;
            // 
            // btnInfoMaintenance
            // 
            this.btnInfoMaintenance.Location = new System.Drawing.Point(21, 358);
            this.btnInfoMaintenance.Name = "btnInfoMaintenance";
            this.btnInfoMaintenance.Size = new System.Drawing.Size(82, 41);
            this.btnInfoMaintenance.TabIndex = 1;
            this.btnInfoMaintenance.Text = "信息维护";
            this.btnInfoMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnQueryAid
            // 
            this.btnQueryAid.Location = new System.Drawing.Point(21, 288);
            this.btnQueryAid.Name = "btnQueryAid";
            this.btnQueryAid.Size = new System.Drawing.Size(82, 41);
            this.btnQueryAid.TabIndex = 1;
            this.btnQueryAid.Text = "急救查询";
            this.btnQueryAid.UseVisualStyleBackColor = true;
            // 
            // btnQueryProperty
            // 
            this.btnQueryProperty.Location = new System.Drawing.Point(21, 217);
            this.btnQueryProperty.Name = "btnQueryProperty";
            this.btnQueryProperty.Size = new System.Drawing.Size(82, 41);
            this.btnQueryProperty.TabIndex = 1;
            this.btnQueryProperty.Text = "理化查询";
            this.btnQueryProperty.UseVisualStyleBackColor = true;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(21, 153);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(82, 41);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "录入信息";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_AdminName});
            this.statusStrip2.Location = new System.Drawing.Point(0, 634);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tssl_AdminName
            // 
            this.tssl_AdminName.Name = "tssl_AdminName";
            this.tssl_AdminName.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "毒物数据库系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnQueryProperty;
        private System.Windows.Forms.Button btnQueryToxic;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPwdModification;
        private System.Windows.Forms.Button btnInfoMaintenance;
        private System.Windows.Forms.Button btnQueryAid;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Version;
        private System.Windows.Forms.ToolStripStatusLabel tssl_AdminName;
        private System.Windows.Forms.Label lbl_Current;
    }
}

