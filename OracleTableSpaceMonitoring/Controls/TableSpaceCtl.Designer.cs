namespace OracleTableSpaceMonitoring.Controls
{
    partial class TableSpaceCtl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiPnl_Main = new System.Windows.Forms.Panel();
            this.uiProg_Capacity = new OracleTableSpaceMonitoring.Controls.PSKProgressBar();
            this.uiPic_Image = new System.Windows.Forms.PictureBox();
            this.uiLab_Name = new System.Windows.Forms.Label();
            this.uiLab_Usage = new System.Windows.Forms.Label();
            this.uiPnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPnl_Main
            // 
            this.uiPnl_Main.Controls.Add(this.uiProg_Capacity);
            this.uiPnl_Main.Controls.Add(this.uiPic_Image);
            this.uiPnl_Main.Controls.Add(this.uiLab_Name);
            this.uiPnl_Main.Controls.Add(this.uiLab_Usage);
            this.uiPnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Main.Location = new System.Drawing.Point(0, 0);
            this.uiPnl_Main.Name = "uiPnl_Main";
            this.uiPnl_Main.Size = new System.Drawing.Size(290, 88);
            this.uiPnl_Main.TabIndex = 0;
            // 
            // uiProg_Capacity
            // 
            this.uiProg_Capacity.CustomText = "";
            this.uiProg_Capacity.Location = new System.Drawing.Point(74, 33);
            this.uiProg_Capacity.Name = "uiProg_Capacity";
            this.uiProg_Capacity.ProgressColor = System.Drawing.Color.LightGreen;
            this.uiProg_Capacity.Size = new System.Drawing.Size(201, 23);
            this.uiProg_Capacity.TabIndex = 17;
            this.uiProg_Capacity.TextColor = System.Drawing.Color.Black;
            this.uiProg_Capacity.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.uiProg_Capacity.VisualMode = OracleTableSpaceMonitoring.Controls.ProgressBarDisplayMode.CurrProgress;
            // 
            // uiPic_Image
            // 
            this.uiPic_Image.Location = new System.Drawing.Point(13, 16);
            this.uiPic_Image.Name = "uiPic_Image";
            this.uiPic_Image.Size = new System.Drawing.Size(55, 56);
            this.uiPic_Image.TabIndex = 14;
            this.uiPic_Image.TabStop = false;
            // 
            // uiLab_Name
            // 
            this.uiLab_Name.AutoSize = true;
            this.uiLab_Name.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Name.Location = new System.Drawing.Point(72, 16);
            this.uiLab_Name.Name = "uiLab_Name";
            this.uiLab_Name.Size = new System.Drawing.Size(47, 13);
            this.uiLab_Name.TabIndex = 13;
            this.uiLab_Name.Text = "Name";
            // 
            // uiLab_Usage
            // 
            this.uiLab_Usage.AutoSize = true;
            this.uiLab_Usage.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Usage.Location = new System.Drawing.Point(72, 59);
            this.uiLab_Usage.Name = "uiLab_Usage";
            this.uiLab_Usage.Size = new System.Drawing.Size(48, 13);
            this.uiLab_Usage.TabIndex = 12;
            this.uiLab_Usage.Text = "Usage";
            // 
            // TableSpaceCtl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiPnl_Main);
            this.Name = "TableSpaceCtl";
            this.Size = new System.Drawing.Size(290, 88);
            this.uiPnl_Main.ResumeLayout(false);
            this.uiPnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uiPnl_Main;
        private System.Windows.Forms.PictureBox uiPic_Image;
        private System.Windows.Forms.Label uiLab_Name;
        private System.Windows.Forms.Label uiLab_Usage;
        private PSKProgressBar uiProg_Capacity;
    }
}
