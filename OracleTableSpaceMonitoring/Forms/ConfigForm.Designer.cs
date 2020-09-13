namespace OracleTableSpaceMonitoring.Forms
{
    partial class ConfigForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiBtn_Save = new System.Windows.Forms.Button();
            this.uiBtn_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiTxt_DatabaseName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.uiTxt_DatabasePwd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uiTxt_DatabaseUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.uiTxt_DatabasePort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.uiTxt_DatabaseIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.uiBtn_Save);
            this.panel1.Controls.Add(this.uiBtn_Close);
            this.panel1.Location = new System.Drawing.Point(9, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 46);
            this.panel1.TabIndex = 73;
            // 
            // uiBtn_Save
            // 
            this.uiBtn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Save.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_Save.ForeColor = System.Drawing.Color.Blue;
            this.uiBtn_Save.Location = new System.Drawing.Point(5, 5);
            this.uiBtn_Save.Name = "uiBtn_Save";
            this.uiBtn_Save.Size = new System.Drawing.Size(128, 35);
            this.uiBtn_Save.TabIndex = 5;
            this.uiBtn_Save.Text = "Save";
            this.uiBtn_Save.UseVisualStyleBackColor = true;
            // 
            // uiBtn_Close
            // 
            this.uiBtn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiBtn_Close.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_Close.ForeColor = System.Drawing.Color.Red;
            this.uiBtn_Close.Location = new System.Drawing.Point(139, 5);
            this.uiBtn_Close.Name = "uiBtn_Close";
            this.uiBtn_Close.Size = new System.Drawing.Size(127, 35);
            this.uiBtn_Close.TabIndex = 6;
            this.uiBtn_Close.Text = "Close";
            this.uiBtn_Close.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(10, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 180);
            this.panel2.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.uiTxt_DatabaseName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.uiTxt_DatabasePwd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.uiTxt_DatabaseUser);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.uiTxt_DatabasePort);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.uiTxt_DatabaseIP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 167);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Database ";
            // 
            // uiTxt_DatabaseName
            // 
            this.uiTxt_DatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxt_DatabaseName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DatabaseName.Location = new System.Drawing.Point(130, 133);
            this.uiTxt_DatabaseName.Name = "uiTxt_DatabaseName";
            this.uiTxt_DatabaseName.Size = new System.Drawing.Size(117, 23);
            this.uiTxt_DatabaseName.TabIndex = 4;
            this.uiTxt_DatabaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 24);
            this.label13.TabIndex = 76;
            this.label13.Text = "Service Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DatabasePwd
            // 
            this.uiTxt_DatabasePwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxt_DatabasePwd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DatabasePwd.Location = new System.Drawing.Point(130, 105);
            this.uiTxt_DatabasePwd.Name = "uiTxt_DatabasePwd";
            this.uiTxt_DatabasePwd.Size = new System.Drawing.Size(117, 23);
            this.uiTxt_DatabasePwd.TabIndex = 3;
            this.uiTxt_DatabasePwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 24);
            this.label12.TabIndex = 74;
            this.label12.Text = "Password";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DatabaseUser
            // 
            this.uiTxt_DatabaseUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxt_DatabaseUser.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DatabaseUser.Location = new System.Drawing.Point(130, 77);
            this.uiTxt_DatabaseUser.Name = "uiTxt_DatabaseUser";
            this.uiTxt_DatabaseUser.Size = new System.Drawing.Size(117, 23);
            this.uiTxt_DatabaseUser.TabIndex = 2;
            this.uiTxt_DatabaseUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 24);
            this.label11.TabIndex = 72;
            this.label11.Text = "User";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DatabasePort
            // 
            this.uiTxt_DatabasePort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxt_DatabasePort.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DatabasePort.Location = new System.Drawing.Point(130, 49);
            this.uiTxt_DatabasePort.Name = "uiTxt_DatabasePort";
            this.uiTxt_DatabasePort.Size = new System.Drawing.Size(117, 23);
            this.uiTxt_DatabasePort.TabIndex = 1;
            this.uiTxt_DatabasePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 70;
            this.label10.Text = "Port";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DatabaseIP
            // 
            this.uiTxt_DatabaseIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxt_DatabaseIP.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DatabaseIP.Location = new System.Drawing.Point(130, 21);
            this.uiTxt_DatabaseIP.Name = "uiTxt_DatabaseIP";
            this.uiTxt_DatabaseIP.Size = new System.Drawing.Size(117, 23);
            this.uiTxt_DatabaseIP.TabIndex = 0;
            this.uiTxt_DatabaseIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 59;
            this.label9.Text = "IP";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CancelButton = this.uiBtn_Close;
            this.ClientSize = new System.Drawing.Size(287, 244);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.Text = "설정";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uiBtn_Save;
        private System.Windows.Forms.Button uiBtn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox uiTxt_DatabaseName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox uiTxt_DatabasePwd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uiTxt_DatabaseUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox uiTxt_DatabasePort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uiTxt_DatabaseIP;
        private System.Windows.Forms.Label label9;
    }
}