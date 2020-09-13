namespace OracleTableSpaceMonitoring
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiTlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.uiPnl_Title = new System.Windows.Forms.Panel();
            this.uiLab_Title = new System.Windows.Forms.Label();
            this.uiSC_Main = new System.Windows.Forms.SplitContainer();
            this.uiPnl_TableSpace = new System.Windows.Forms.Panel();
            this.uiChkList_TableSpace = new System.Windows.Forms.CheckedListBox();
            this.uiFlp_Main = new System.Windows.Forms.FlowLayoutPanel();
            this.uiBtn_Config = new OracleTableSpaceMonitoring.Controls.PSKButton();
            this.uiTlp_Main.SuspendLayout();
            this.uiPnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiSC_Main)).BeginInit();
            this.uiSC_Main.Panel1.SuspendLayout();
            this.uiSC_Main.Panel2.SuspendLayout();
            this.uiSC_Main.SuspendLayout();
            this.uiPnl_TableSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTlp_Main
            // 
            this.uiTlp_Main.ColumnCount = 1;
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Main.Controls.Add(this.uiPnl_Title, 0, 0);
            this.uiTlp_Main.Controls.Add(this.uiSC_Main, 0, 1);
            this.uiTlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlp_Main.Name = "uiTlp_Main";
            this.uiTlp_Main.RowCount = 2;
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Main.Size = new System.Drawing.Size(884, 561);
            this.uiTlp_Main.TabIndex = 0;
            // 
            // uiPnl_Title
            // 
            this.uiPnl_Title.Controls.Add(this.uiBtn_Config);
            this.uiPnl_Title.Controls.Add(this.uiLab_Title);
            this.uiPnl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Title.Location = new System.Drawing.Point(3, 3);
            this.uiPnl_Title.Name = "uiPnl_Title";
            this.uiPnl_Title.Size = new System.Drawing.Size(878, 54);
            this.uiPnl_Title.TabIndex = 8;
            // 
            // uiLab_Title
            // 
            this.uiLab_Title.BackColor = System.Drawing.Color.Black;
            this.uiLab_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLab_Title.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.uiLab_Title.ForeColor = System.Drawing.Color.White;
            this.uiLab_Title.Location = new System.Drawing.Point(0, 0);
            this.uiLab_Title.Name = "uiLab_Title";
            this.uiLab_Title.Size = new System.Drawing.Size(878, 54);
            this.uiLab_Title.TabIndex = 2;
            this.uiLab_Title.Text = "Oracle TableSpace Monitoring";
            this.uiLab_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSC_Main
            // 
            this.uiSC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSC_Main.Location = new System.Drawing.Point(3, 63);
            this.uiSC_Main.Name = "uiSC_Main";
            // 
            // uiSC_Main.Panel1
            // 
            this.uiSC_Main.Panel1.Controls.Add(this.uiPnl_TableSpace);
            // 
            // uiSC_Main.Panel2
            // 
            this.uiSC_Main.Panel2.Controls.Add(this.uiFlp_Main);
            this.uiSC_Main.Size = new System.Drawing.Size(878, 495);
            this.uiSC_Main.SplitterDistance = 289;
            this.uiSC_Main.TabIndex = 9;
            // 
            // uiPnl_TableSpace
            // 
            this.uiPnl_TableSpace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uiPnl_TableSpace.Controls.Add(this.uiChkList_TableSpace);
            this.uiPnl_TableSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_TableSpace.Location = new System.Drawing.Point(0, 0);
            this.uiPnl_TableSpace.Name = "uiPnl_TableSpace";
            this.uiPnl_TableSpace.Size = new System.Drawing.Size(289, 495);
            this.uiPnl_TableSpace.TabIndex = 0;
            // 
            // uiChkList_TableSpace
            // 
            this.uiChkList_TableSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiChkList_TableSpace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uiChkList_TableSpace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiChkList_TableSpace.FormattingEnabled = true;
            this.uiChkList_TableSpace.Location = new System.Drawing.Point(11, 11);
            this.uiChkList_TableSpace.Name = "uiChkList_TableSpace";
            this.uiChkList_TableSpace.Size = new System.Drawing.Size(266, 464);
            this.uiChkList_TableSpace.TabIndex = 2;
            // 
            // uiFlp_Main
            // 
            this.uiFlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiFlp_Main.Name = "uiFlp_Main";
            this.uiFlp_Main.Size = new System.Drawing.Size(585, 495);
            this.uiFlp_Main.TabIndex = 0;
            // 
            // uiBtn_Config
            // 
            this.uiBtn_Config.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Config.BackgroundImage = global::OracleTableSpaceMonitoring.Properties.Resources.ConfigDefault;
            this.uiBtn_Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiBtn_Config.ImageClick = ((System.Drawing.Image)(resources.GetObject("uiBtn_Config.ImageClick")));
            this.uiBtn_Config.ImageDefault = ((System.Drawing.Image)(resources.GetObject("uiBtn_Config.ImageDefault")));
            this.uiBtn_Config.ImageFocusIn = ((System.Drawing.Image)(resources.GetObject("uiBtn_Config.ImageFocusIn")));
            this.uiBtn_Config.Location = new System.Drawing.Point(824, 0);
            this.uiBtn_Config.Name = "uiBtn_Config";
            this.uiBtn_Config.Size = new System.Drawing.Size(54, 54);
            this.uiBtn_Config.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.uiTlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Oracle TableSpace Monitoring";
            this.uiTlp_Main.ResumeLayout(false);
            this.uiPnl_Title.ResumeLayout(false);
            this.uiSC_Main.Panel1.ResumeLayout(false);
            this.uiSC_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSC_Main)).EndInit();
            this.uiSC_Main.ResumeLayout(false);
            this.uiPnl_TableSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlp_Main;
        private System.Windows.Forms.Panel uiPnl_Title;
        private System.Windows.Forms.Label uiLab_Title;
        private Controls.PSKButton uiBtn_Config;
        private System.Windows.Forms.SplitContainer uiSC_Main;
        private System.Windows.Forms.FlowLayoutPanel uiFlp_Main;
        private System.Windows.Forms.Panel uiPnl_TableSpace;
        private System.Windows.Forms.CheckedListBox uiChkList_TableSpace;
    }
}

