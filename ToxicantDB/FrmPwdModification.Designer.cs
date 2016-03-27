namespace ToxicantDB
{
    partial class FrmPwdModification
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
            this.SuspendLayout();
            // 
            // lblFormerPwd
            // 
            this.lblFormerPwd.AutoSize = true;
            this.lblFormerPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFormerPwd.Location = new System.Drawing.Point(55, 55);
            this.lblFormerPwd.Name = "lblFormerPwd";
            this.lblFormerPwd.Size = new System.Drawing.Size(58, 20);
            this.lblFormerPwd.TabIndex = 0;
            this.lblFormerPwd.Text = "原密码 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "新密码 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(55, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "重复新密码 :";
            // 
            // txtFormerPwd
            // 
            this.txtFormerPwd.Location = new System.Drawing.Point(159, 58);
            this.txtFormerPwd.Name = "txtFormerPwd";
            this.txtFormerPwd.Size = new System.Drawing.Size(171, 21);
            this.txtFormerPwd.TabIndex = 1;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(159, 120);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(171, 21);
            this.txtNewPwd.TabIndex = 1;
            // 
            // txtNewPwdRepeat
            // 
            this.txtNewPwdRepeat.Location = new System.Drawing.Point(159, 154);
            this.txtNewPwdRepeat.Name = "txtNewPwdRepeat";
            this.txtNewPwdRepeat.Size = new System.Drawing.Size(171, 21);
            this.txtNewPwdRepeat.TabIndex = 1;
            // 
            // FrmPwdModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 234);
            this.Controls.Add(this.txtNewPwdRepeat);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtFormerPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFormerPwd);
            this.Name = "FrmPwdModification";
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
    }
}