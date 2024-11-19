namespace DatabaseOperator
{
    partial class Form1
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
            this.grpbxLogin = new System.Windows.Forms.GroupBox();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.lblUsr_Pwd = new System.Windows.Forms.Label();
            this.lblUsr_Name = new System.Windows.Forms.Label();
            this.lblSrv_Name = new System.Windows.Forms.Label();
            this.Srv_Name = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Usr_Pwd = new System.Windows.Forms.TextBox();
            this.Usr_Name = new System.Windows.Forms.TextBox();
            this.grpbxDB = new System.Windows.Forms.GroupBox();
            this.cbDB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpbxLogin.SuspendLayout();
            this.grpbxDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLogin
            // 
            this.grpbxLogin.Controls.Add(this.lblConnStatus);
            this.grpbxLogin.Controls.Add(this.lblUsr_Pwd);
            this.grpbxLogin.Controls.Add(this.lblUsr_Name);
            this.grpbxLogin.Controls.Add(this.lblSrv_Name);
            this.grpbxLogin.Controls.Add(this.Srv_Name);
            this.grpbxLogin.Controls.Add(this.btnConnect);
            this.grpbxLogin.Controls.Add(this.Usr_Pwd);
            this.grpbxLogin.Controls.Add(this.Usr_Name);
            this.grpbxLogin.Location = new System.Drawing.Point(12, 12);
            this.grpbxLogin.Name = "grpbxLogin";
            this.grpbxLogin.Size = new System.Drawing.Size(386, 191);
            this.grpbxLogin.TabIndex = 7;
            this.grpbxLogin.TabStop = false;
            this.grpbxLogin.Text = "LOGIN INFORMATION";
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.Location = new System.Drawing.Point(116, 162);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(74, 13);
            this.lblConnStatus.TabIndex = 14;
            this.lblConnStatus.Text = "--- STATUS ---";
            // 
            // lblUsr_Pwd
            // 
            this.lblUsr_Pwd.AutoSize = true;
            this.lblUsr_Pwd.Location = new System.Drawing.Point(22, 105);
            this.lblUsr_Pwd.Name = "lblUsr_Pwd";
            this.lblUsr_Pwd.Size = new System.Drawing.Size(73, 13);
            this.lblUsr_Pwd.TabIndex = 13;
            this.lblUsr_Pwd.Text = "PASSWORD:";
            // 
            // lblUsr_Name
            // 
            this.lblUsr_Name.AutoSize = true;
            this.lblUsr_Name.Location = new System.Drawing.Point(22, 79);
            this.lblUsr_Name.Name = "lblUsr_Name";
            this.lblUsr_Name.Size = new System.Drawing.Size(74, 13);
            this.lblUsr_Name.TabIndex = 12;
            this.lblUsr_Name.Text = "USER NAME:";
            // 
            // lblSrv_Name
            // 
            this.lblSrv_Name.AutoSize = true;
            this.lblSrv_Name.Location = new System.Drawing.Point(22, 53);
            this.lblSrv_Name.Name = "lblSrv_Name";
            this.lblSrv_Name.Size = new System.Drawing.Size(88, 13);
            this.lblSrv_Name.TabIndex = 11;
            this.lblSrv_Name.Text = "SERVER NAME:";
            // 
            // Srv_Name
            // 
            this.Srv_Name.Location = new System.Drawing.Point(116, 50);
            this.Srv_Name.Name = "Srv_Name";
            this.Srv_Name.Size = new System.Drawing.Size(164, 20);
            this.Srv_Name.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(287, 76);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 46);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "CONNECT!";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Usr_Pwd
            // 
            this.Usr_Pwd.Location = new System.Drawing.Point(116, 102);
            this.Usr_Pwd.Name = "Usr_Pwd";
            this.Usr_Pwd.Size = new System.Drawing.Size(164, 20);
            this.Usr_Pwd.TabIndex = 8;
            this.Usr_Pwd.UseSystemPasswordChar = true;
            // 
            // Usr_Name
            // 
            this.Usr_Name.Location = new System.Drawing.Point(116, 76);
            this.Usr_Name.Name = "Usr_Name";
            this.Usr_Name.Size = new System.Drawing.Size(164, 20);
            this.Usr_Name.TabIndex = 7;
            // 
            // grpbxDB
            // 
            this.grpbxDB.Controls.Add(this.cbDB);
            this.grpbxDB.Controls.Add(this.label1);
            this.grpbxDB.Location = new System.Drawing.Point(12, 210);
            this.grpbxDB.Name = "grpbxDB";
            this.grpbxDB.Size = new System.Drawing.Size(386, 100);
            this.grpbxDB.TabIndex = 8;
            this.grpbxDB.TabStop = false;
            this.grpbxDB.Text = "DATABASES";
            // 
            // cbDB
            // 
            this.cbDB.FormattingEnabled = true;
            this.cbDB.Location = new System.Drawing.Point(116, 45);
            this.cbDB.Name = "cbDB";
            this.cbDB.Size = new System.Drawing.Size(164, 21);
            this.cbDB.TabIndex = 2;
            this.cbDB.SelectedIndexChanged += new System.EventHandler(this.cbDB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB NAME:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TABLES";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(420, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 101);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STORED PROCEDURES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbxDB);
            this.Controls.Add(this.grpbxLogin);
            this.Name = "Form1";
            this.Text = "SQL Server Database Operator";
            this.grpbxLogin.ResumeLayout(false);
            this.grpbxLogin.PerformLayout();
            this.grpbxDB.ResumeLayout(false);
            this.grpbxDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLogin;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.Label lblUsr_Pwd;
        private System.Windows.Forms.Label lblUsr_Name;
        private System.Windows.Forms.Label lblSrv_Name;
        private System.Windows.Forms.TextBox Srv_Name;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox Usr_Pwd;
        private System.Windows.Forms.TextBox Usr_Name;
        private System.Windows.Forms.GroupBox grpbxDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

