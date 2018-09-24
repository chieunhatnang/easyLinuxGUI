namespace LevEasyLinuxGUI
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKeyBrowse = new System.Windows.Forms.Button();
            this.rdKey = new System.Windows.Forms.RadioButton();
            this.rdPass = new System.Windows.Forms.RadioButton();
            this.txtVPSKeyPath = new System.Windows.Forms.TextBox();
            this.txtVPSPassword = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtVPSUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkWine = new System.Windows.Forms.CheckBox();
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.chkFF = new System.Windows.Forms.CheckBox();
            this.txtVNCPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKeyBrowse);
            this.groupBox1.Controls.Add(this.rdKey);
            this.groupBox1.Controls.Add(this.rdPass);
            this.groupBox1.Controls.Add(this.txtVPSKeyPath);
            this.groupBox1.Controls.Add(this.txtVPSPassword);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.txtVPSUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin VPS";
            // 
            // btnKeyBrowse
            // 
            this.btnKeyBrowse.Enabled = false;
            this.btnKeyBrowse.Location = new System.Drawing.Point(346, 94);
            this.btnKeyBrowse.Name = "btnKeyBrowse";
            this.btnKeyBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnKeyBrowse.TabIndex = 6;
            this.btnKeyBrowse.Text = "Browse";
            this.btnKeyBrowse.UseVisualStyleBackColor = true;
            this.btnKeyBrowse.Click += new System.EventHandler(this.btnKeyBrowse_Click);
            // 
            // rdKey
            // 
            this.rdKey.AutoSize = true;
            this.rdKey.Location = new System.Drawing.Point(13, 97);
            this.rdKey.Name = "rdKey";
            this.rdKey.Size = new System.Drawing.Size(80, 17);
            this.rdKey.TabIndex = 4;
            this.rdKey.Text = "Use key file";
            this.rdKey.UseVisualStyleBackColor = true;
            // 
            // rdPass
            // 
            this.rdPass.AutoSize = true;
            this.rdPass.Checked = true;
            this.rdPass.Location = new System.Drawing.Point(13, 70);
            this.rdPass.Name = "rdPass";
            this.rdPass.Size = new System.Drawing.Size(92, 17);
            this.rdPass.TabIndex = 2;
            this.rdPass.TabStop = true;
            this.rdPass.Text = "Use password";
            this.rdPass.UseVisualStyleBackColor = true;
            this.rdPass.CheckedChanged += new System.EventHandler(this.rdPass_CheckedChanged);
            // 
            // txtVPSKeyPath
            // 
            this.txtVPSKeyPath.Enabled = false;
            this.txtVPSKeyPath.Location = new System.Drawing.Point(125, 95);
            this.txtVPSKeyPath.Name = "txtVPSKeyPath";
            this.txtVPSKeyPath.Size = new System.Drawing.Size(209, 20);
            this.txtVPSKeyPath.TabIndex = 5;
            // 
            // txtVPSPassword
            // 
            this.txtVPSPassword.Location = new System.Drawing.Point(125, 69);
            this.txtVPSPassword.Name = "txtVPSPassword";
            this.txtVPSPassword.Size = new System.Drawing.Size(296, 20);
            this.txtVPSPassword.TabIndex = 3;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(125, 17);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(296, 20);
            this.txtIP.TabIndex = 0;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(10, 20);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(41, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "VPS IP";
            // 
            // txtVPSUsername
            // 
            this.txtVPSUsername.Location = new System.Drawing.Point(125, 43);
            this.txtVPSUsername.Name = "txtVPSUsername";
            this.txtVPSUsername.Size = new System.Drawing.Size(296, 20);
            this.txtVPSUsername.TabIndex = 1;
            this.txtVPSUsername.Text = "root";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(2, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(11, 119);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(117, 13);
            this.linkLabel3.TabIndex = 1;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://lowendviet.com";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(129, 80);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(173, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://fb.com/groups/cheapcloud";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(171, 42);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(242, 13);
            this.linkLabel4.TabIndex = 1;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "https://github.com/chieunhatnang/easyLinuxGUI";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(200, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(152, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://free.levnode.com/tools";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 120);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.chkWine);
            this.groupBox3.Controls.Add(this.chkChrome);
            this.groupBox3.Controls.Add(this.chkFF);
            this.groupBox3.Controls.Add(this.txtVNCPassword);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(2, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 117);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(177, 88);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkWine
            // 
            this.chkWine.AutoSize = true;
            this.chkWine.Location = new System.Drawing.Point(13, 70);
            this.chkWine.Name = "chkWine";
            this.chkWine.Size = new System.Drawing.Size(230, 17);
            this.chkWine.TabIndex = 3;
            this.chkWine.Text = "Install Wine để chạy file .exe của Windows";
            this.chkWine.UseVisualStyleBackColor = true;
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Location = new System.Drawing.Point(125, 47);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(92, 17);
            this.chkChrome.TabIndex = 2;
            this.chkChrome.Text = "Install Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // chkFF
            // 
            this.chkFF.AutoSize = true;
            this.chkFF.Location = new System.Drawing.Point(13, 47);
            this.chkFF.Name = "chkFF";
            this.chkFF.Size = new System.Drawing.Size(87, 17);
            this.chkFF.TabIndex = 1;
            this.chkFF.Text = "Install Firefox";
            this.chkFF.UseVisualStyleBackColor = true;
            // 
            // txtVNCPassword
            // 
            this.txtVNCPassword.Location = new System.Drawing.Point(125, 19);
            this.txtVNCPassword.Name = "txtVNCPassword";
            this.txtVNCPassword.Size = new System.Drawing.Size(296, 20);
            this.txtVNCPassword.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đặt mật khẩu VNC";
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 385);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainFrm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdKey;
        private System.Windows.Forms.RadioButton rdPass;
        private System.Windows.Forms.TextBox txtVPSUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeyBrowse;
        private System.Windows.Forms.TextBox txtVPSKeyPath;
        private System.Windows.Forms.TextBox txtVPSPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkWine;
        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.CheckBox chkFF;
        private System.Windows.Forms.TextBox txtVNCPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
    }
}

