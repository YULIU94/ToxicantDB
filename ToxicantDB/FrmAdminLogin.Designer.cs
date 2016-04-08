namespace ToxicantDB
{
    partial class FrmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminLogin));
            this.lblAdminId = new System.Windows.Forms.Label();
            this.lblAdminPwd = new System.Windows.Forms.Label();
            this.txtAdminId = new System.Windows.Forms.TextBox();
            this.txtAdminPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Location = new System.Drawing.Point(52, 45);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(65, 12);
            this.lblAdminId.TabIndex = 0;
            this.lblAdminId.Text = "登录账号：";
            // 
            // lblAdminPwd
            // 
            this.lblAdminPwd.AutoSize = true;
            this.lblAdminPwd.Location = new System.Drawing.Point(52, 84);
            this.lblAdminPwd.Name = "lblAdminPwd";
            this.lblAdminPwd.Size = new System.Drawing.Size(65, 12);
            this.lblAdminPwd.TabIndex = 0;
            this.lblAdminPwd.Text = "登录密码：";
            // 
            // txtAdminId
            // 
            this.txtAdminId.Location = new System.Drawing.Point(150, 42);
            this.txtAdminId.Name = "txtAdminId";
            this.txtAdminId.Size = new System.Drawing.Size(147, 21);
            this.txtAdminId.TabIndex = 1;
            this.txtAdminId.Text = "1001";
            // 
            // txtAdminPwd
            // 
            this.txtAdminPwd.Location = new System.Drawing.Point(150, 81);
            this.txtAdminPwd.Name = "txtAdminPwd";
            this.txtAdminPwd.PasswordChar = '*';
            this.txtAdminPwd.Size = new System.Drawing.Size(147, 21);
            this.txtAdminPwd.TabIndex = 1;
            this.txtAdminPwd.Text = "123456";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(125, 137);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(246, 137);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 30);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FrmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 193);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtAdminPwd);
            this.Controls.Add(this.txtAdminId);
            this.Controls.Add(this.lblAdminPwd);
            this.Controls.Add(this.lblAdminId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminLogin";
            this.Text = "管理员登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Label lblAdminPwd;
        private System.Windows.Forms.TextBox txtAdminId;
        private System.Windows.Forms.TextBox txtAdminPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnQuit;
    }
}