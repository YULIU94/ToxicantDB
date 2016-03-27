namespace ToxicantDB
{
    partial class FrmEditPwd
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
            this.lblFormerPwd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormerPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwdRepeat = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.txtAdminId = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormerPwd
            // 
            this.lblFormerPwd.AutoSize = true;
            this.lblFormerPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFormerPwd.Location = new System.Drawing.Point(58, 140);
            this.lblFormerPwd.Name = "lblFormerPwd";
            this.lblFormerPwd.Size = new System.Drawing.Size(58, 20);
            this.lblFormerPwd.TabIndex = 0;
            this.lblFormerPwd.Text = "原密码 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(58, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "新密码 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(58, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "重复新密码 :";
            // 
            // txtFormerPwd
            // 
            this.txtFormerPwd.Location = new System.Drawing.Point(162, 143);
            this.txtFormerPwd.Name = "txtFormerPwd";
            this.txtFormerPwd.Size = new System.Drawing.Size(171, 21);
            this.txtFormerPwd.TabIndex = 0;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(162, 205);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(171, 21);
            this.txtNewPwd.TabIndex = 1;
            // 
            // txtNewPwdRepeat
            // 
            this.txtNewPwdRepeat.Location = new System.Drawing.Point(162, 239);
            this.txtNewPwdRepeat.Name = "txtNewPwdRepeat";
            this.txtNewPwdRepeat.Size = new System.Drawing.Size(171, 21);
            this.txtNewPwdRepeat.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "确认修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdminId.Location = new System.Drawing.Point(58, 35);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(59, 20);
            this.lblAdminId.TabIndex = 0;
            this.lblAdminId.Text = "用户ID :";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdminName.Location = new System.Drawing.Point(58, 71);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(58, 20);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "用户名 :";
            // 
            // txtAdminId
            // 
            this.txtAdminId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdminId.Location = new System.Drawing.Point(162, 38);
            this.txtAdminId.Name = "txtAdminId";
            this.txtAdminId.Size = new System.Drawing.Size(171, 21);
            this.txtAdminId.TabIndex = 1;
            // 
            // txtAdminName
            // 
            this.txtAdminName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdminName.Location = new System.Drawing.Point(162, 74);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(171, 21);
            this.txtAdminName.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(249, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmEditPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPwdRepeat);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.txtAdminId);
            this.Controls.Add(this.txtFormerPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblAdminId);
            this.Controls.Add(this.lblFormerPwd);
            this.Name = "FrmEditPwd";
            this.Text = "密码修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormerPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFormerPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtNewPwdRepeat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.TextBox txtAdminId;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Button btnClose;
    }
}