namespace ToxicantDB
{
    partial class FrmAdminManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminManage));
            this.tcUserManage = new System.Windows.Forms.TabControl();
            this.tpQuery = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lbl_IDCard = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_AdminRole = new System.Windows.Forms.Label();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAdminRole = new System.Windows.Forms.Label();
            this.rdoIDCard = new System.Windows.Forms.RadioButton();
            this.txt_IDCard = new System.Windows.Forms.TextBox();
            this.rdoAdminId = new System.Windows.Forms.RadioButton();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.lblAdminRole1 = new System.Windows.Forms.Label();
            this.lblGender1 = new System.Windows.Forms.Label();
            this.lblLocation1 = new System.Windows.Forms.Label();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.lblAdminName1 = new System.Windows.Forms.Label();
            this.lblIDCard1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtAdminRole = new System.Windows.Forms.TextBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditClose = new System.Windows.Forms.Button();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.tcUserManage.SuspendLayout();
            this.tpQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUserManage
            // 
            this.tcUserManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcUserManage.Controls.Add(this.tpQuery);
            this.tcUserManage.Controls.Add(this.tpAdd);
            this.tcUserManage.Location = new System.Drawing.Point(0, 1);
            this.tcUserManage.Name = "tcUserManage";
            this.tcUserManage.SelectedIndex = 0;
            this.tcUserManage.Size = new System.Drawing.Size(1017, 312);
            this.tcUserManage.TabIndex = 0;
            // 
            // tpQuery
            // 
            this.tpQuery.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpQuery.Controls.Add(this.btnEdit);
            this.tpQuery.Controls.Add(this.btnQuery);
            this.tpQuery.Controls.Add(this.lbl_IDCard);
            this.tpQuery.Controls.Add(this.lbl_Phone);
            this.tpQuery.Controls.Add(this.lbl_Location);
            this.tpQuery.Controls.Add(this.lbl_AdminRole);
            this.tpQuery.Controls.Add(this.lbl_UserId);
            this.tpQuery.Controls.Add(this.lbl_Gender);
            this.tpQuery.Controls.Add(this.lbl_UserName);
            this.tpQuery.Controls.Add(this.lblIDCard);
            this.tpQuery.Controls.Add(this.lblUserName);
            this.tpQuery.Controls.Add(this.lblPhone);
            this.tpQuery.Controls.Add(this.lblUserId);
            this.tpQuery.Controls.Add(this.lblLocation);
            this.tpQuery.Controls.Add(this.lblGender);
            this.tpQuery.Controls.Add(this.lblAdminRole);
            this.tpQuery.Controls.Add(this.rdoIDCard);
            this.tpQuery.Controls.Add(this.txt_IDCard);
            this.tpQuery.Controls.Add(this.rdoAdminId);
            this.tpQuery.Controls.Add(this.txt_UserId);
            this.tpQuery.Location = new System.Drawing.Point(4, 22);
            this.tpQuery.Name = "tpQuery";
            this.tpQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery.Size = new System.Drawing.Size(1009, 286);
            this.tpQuery.TabIndex = 0;
            this.tpQuery.Text = "用户查询";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(256, 203);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 37);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "修改信息 ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(116, 203);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(96, 37);
            this.btnQuery.TabIndex = 47;
            this.btnQuery.Text = "提交查询  ";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lbl_IDCard
            // 
            this.lbl_IDCard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_IDCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_IDCard.Location = new System.Drawing.Point(774, 130);
            this.lbl_IDCard.Name = "lbl_IDCard";
            this.lbl_IDCard.Size = new System.Drawing.Size(142, 24);
            this.lbl_IDCard.TabIndex = 46;
            this.lbl_IDCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Phone.Location = new System.Drawing.Point(543, 130);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(142, 24);
            this.lbl_Phone.TabIndex = 46;
            this.lbl_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Location
            // 
            this.lbl_Location.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Location.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Location.Location = new System.Drawing.Point(543, 174);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(373, 24);
            this.lbl_Location.TabIndex = 44;
            this.lbl_Location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AdminRole
            // 
            this.lbl_AdminRole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AdminRole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_AdminRole.Location = new System.Drawing.Point(774, 90);
            this.lbl_AdminRole.Name = "lbl_AdminRole";
            this.lbl_AdminRole.Size = new System.Drawing.Size(142, 24);
            this.lbl_AdminRole.TabIndex = 42;
            this.lbl_AdminRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_UserId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UserId.Location = new System.Drawing.Point(774, 49);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(142, 24);
            this.lbl_UserId.TabIndex = 41;
            this.lbl_UserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Gender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Gender.Location = new System.Drawing.Point(543, 90);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(142, 24);
            this.lbl_Gender.TabIndex = 40;
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_UserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UserName.Location = new System.Drawing.Point(543, 49);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(142, 24);
            this.lbl_UserName.TabIndex = 45;
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(712, 136);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(65, 12);
            this.lblIDCard.TabIndex = 33;
            this.lblIDCard.Text = "身份证号：";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(472, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 12);
            this.lblUserName.TabIndex = 35;
            this.lblUserName.Text = "用户姓名：";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(472, 136);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 33;
            this.lblPhone.Text = "联系电话：";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(724, 56);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(53, 12);
            this.lblUserId.TabIndex = 32;
            this.lblUserId.Text = "用户ID：";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(472, 180);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(65, 12);
            this.lblLocation.TabIndex = 31;
            this.lblLocation.Text = "所在单位：";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(496, 96);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 12);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "性别：";
            // 
            // lblAdminRole
            // 
            this.lblAdminRole.AutoSize = true;
            this.lblAdminRole.Location = new System.Drawing.Point(712, 96);
            this.lblAdminRole.Name = "lblAdminRole";
            this.lblAdminRole.Size = new System.Drawing.Size(65, 12);
            this.lblAdminRole.TabIndex = 29;
            this.lblAdminRole.Text = "用户角色：";
            // 
            // rdoIDCard
            // 
            this.rdoIDCard.AutoSize = true;
            this.rdoIDCard.Location = new System.Drawing.Point(76, 137);
            this.rdoIDCard.Name = "rdoIDCard";
            this.rdoIDCard.Size = new System.Drawing.Size(83, 16);
            this.rdoIDCard.TabIndex = 6;
            this.rdoIDCard.Text = "身份证号：";
            this.rdoIDCard.UseVisualStyleBackColor = true;
            // 
            // txt_IDCard
            // 
            this.txt_IDCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IDCard.Location = new System.Drawing.Point(171, 134);
            this.txt_IDCard.Name = "txt_IDCard";
            this.txt_IDCard.Size = new System.Drawing.Size(126, 21);
            this.txt_IDCard.TabIndex = 5;
            // 
            // rdoAdminId
            // 
            this.rdoAdminId.AutoSize = true;
            this.rdoAdminId.Checked = true;
            this.rdoAdminId.Location = new System.Drawing.Point(76, 90);
            this.rdoAdminId.Name = "rdoAdminId";
            this.rdoAdminId.Size = new System.Drawing.Size(71, 16);
            this.rdoAdminId.TabIndex = 7;
            this.rdoAdminId.TabStop = true;
            this.rdoAdminId.Text = "用户ID：";
            this.rdoAdminId.UseVisualStyleBackColor = true;
            // 
            // txt_UserId
            // 
            this.txt_UserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserId.Location = new System.Drawing.Point(171, 85);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(126, 21);
            this.txt_UserId.TabIndex = 4;
            // 
            // tpAdd
            // 
            this.tpAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpAdd.Location = new System.Drawing.Point(4, 22);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(1009, 286);
            this.tpAdd.TabIndex = 1;
            this.tpAdd.Text = "新增用户";
            // 
            // lblAdminRole1
            // 
            this.lblAdminRole1.AutoSize = true;
            this.lblAdminRole1.Location = new System.Drawing.Point(289, 351);
            this.lblAdminRole1.Name = "lblAdminRole1";
            this.lblAdminRole1.Size = new System.Drawing.Size(65, 12);
            this.lblAdminRole1.TabIndex = 29;
            this.lblAdminRole1.Text = "用户角色：";
            // 
            // lblGender1
            // 
            this.lblGender1.AutoSize = true;
            this.lblGender1.Location = new System.Drawing.Point(73, 400);
            this.lblGender1.Name = "lblGender1";
            this.lblGender1.Size = new System.Drawing.Size(41, 12);
            this.lblGender1.TabIndex = 30;
            this.lblGender1.Text = "性别：";
            // 
            // lblLocation1
            // 
            this.lblLocation1.AutoSize = true;
            this.lblLocation1.Location = new System.Drawing.Point(49, 500);
            this.lblLocation1.Name = "lblLocation1";
            this.lblLocation1.Size = new System.Drawing.Size(65, 12);
            this.lblLocation1.TabIndex = 31;
            this.lblLocation1.Text = "所在单位：";
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Location = new System.Drawing.Point(49, 445);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(65, 12);
            this.lblPhone1.TabIndex = 33;
            this.lblPhone1.Text = "联系电话：";
            // 
            // lblAdminName1
            // 
            this.lblAdminName1.AutoSize = true;
            this.lblAdminName1.Location = new System.Drawing.Point(49, 351);
            this.lblAdminName1.Name = "lblAdminName1";
            this.lblAdminName1.Size = new System.Drawing.Size(65, 12);
            this.lblAdminName1.TabIndex = 35;
            this.lblAdminName1.Text = "用户姓名：";
            // 
            // lblIDCard1
            // 
            this.lblIDCard1.AutoSize = true;
            this.lblIDCard1.Location = new System.Drawing.Point(289, 445);
            this.lblIDCard1.Name = "lblIDCard1";
            this.lblIDCard1.Size = new System.Drawing.Size(65, 12);
            this.lblIDCard1.TabIndex = 33;
            this.lblIDCard1.Text = "身份证号：";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(120, 349);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(126, 21);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(120, 443);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(126, 21);
            this.txtPhone.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Location = new System.Drawing.Point(120, 498);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(366, 21);
            this.txtLocation.TabIndex = 4;
            // 
            // txtAdminRole
            // 
            this.txtAdminRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminRole.Location = new System.Drawing.Point(360, 349);
            this.txtAdminRole.Name = "txtAdminRole";
            this.txtAdminRole.Size = new System.Drawing.Size(126, 21);
            this.txtAdminRole.TabIndex = 4;
            // 
            // txtIDCard
            // 
            this.txtIDCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDCard.Location = new System.Drawing.Point(360, 443);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(126, 21);
            this.txtIDCard.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(260, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 37);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "保存信息";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditClose
            // 
            this.btnEditClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditClose.Location = new System.Drawing.Point(392, 576);
            this.btnEditClose.Name = "btnEditClose";
            this.btnEditClose.Size = new System.Drawing.Size(94, 37);
            this.btnEditClose.TabIndex = 48;
            this.btnEditClose.Text = "完成修改";
            this.btnEditClose.UseVisualStyleBackColor = true;
            this.btnEditClose.Click += new System.EventHandler(this.btnEditClose_Click);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(179, 398);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 50;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(128, 398);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 51;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // FrmAdminManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 681);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.btnEditClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcUserManage);
            this.Controls.Add(this.lblLocation1);
            this.Controls.Add(this.lblAdminRole1);
            this.Controls.Add(this.lblGender1);
            this.Controls.Add(this.lblPhone1);
            this.Controls.Add(this.lblAdminName1);
            this.Controls.Add(this.lblIDCard1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdminRole);
            this.Controls.Add(this.txtUserName);
            this.Name = "FrmAdminManage";
            this.Text = "用户管理";
            this.tcUserManage.ResumeLayout(false);
            this.tpQuery.ResumeLayout(false);
            this.tpQuery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcUserManage;
        private System.Windows.Forms.TabPage tpQuery;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_AdminRole;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAdminRole;
        private System.Windows.Forms.RadioButton rdoIDCard;
        private System.Windows.Forms.TextBox txt_IDCard;
        private System.Windows.Forms.RadioButton rdoAdminId;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.Label lbl_IDCard;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.Label lblAdminRole1;
        private System.Windows.Forms.Label lblGender1;
        private System.Windows.Forms.Label lblLocation1;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.Label lblAdminName1;
        private System.Windows.Forms.Label lblIDCard1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtAdminRole;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditClose;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
    }
}