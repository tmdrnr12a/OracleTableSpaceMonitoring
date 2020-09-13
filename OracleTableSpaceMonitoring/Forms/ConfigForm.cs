using System;
using System.Windows.Forms;
using OracleTableSpaceMonitoring.Manager;

namespace OracleTableSpaceMonitoring.Forms
{
    public partial class ConfigForm : Form
    {
        #region Variable

        #endregion Variable End

        #region Create & Load & Shown

        public ConfigForm()
        {
            InitializeComponent();

            this.Shown += ConfigForm_Shown;

            uiBtn_Save.Click += UiBtn_Save_Click;
            uiBtn_Close.Click += UiBtn_Close_Click;
        }

        /// <summary>
        /// Shown 화면이 처음 표시될 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigForm_Shown(object sender, EventArgs e)
        {
            LoadValue();
        }

        #endregion Create & Load & Shown End

        #region Method

        /// <summary>
        /// 파일의 값들을 읽어서 화면에 보여주는 메서드
        /// </summary>
        private void LoadValue()
        {
            uiTxt_DatabaseIP.Text = FileManager.GetValueString("DATABASE", "IP", "");
            uiTxt_DatabasePort.Text = FileManager.GetValueString("DATABASE", "PORT", "");
            uiTxt_DatabaseUser.Text = FileManager.GetValueString("DATABASE", "USER", "");
            uiTxt_DatabasePwd.Text = FileManager.GetValueString("DATABASE", "PWD", "");
            uiTxt_DatabaseName.Text = FileManager.GetValueString("DATABASE", "SERVICE_NAME", "");
        }

        /// <summary>
        /// 화면의 정보를 파일에 업데이트하는 메서드
        /// </summary>
        private void UpdateValue()
        {
            FileManager.SetValue("DATABASE", "IP", uiTxt_DatabaseIP.Text);
            FileManager.SetValue("DATABASE", "PORT", uiTxt_DatabasePort.Text);
            FileManager.SetValue("DATABASE", "USER", uiTxt_DatabaseUser.Text);
            FileManager.SetValue("DATABASE", "PWD", uiTxt_DatabasePwd.Text);
            FileManager.SetValue("DATABASE", "SERVICE_NAME", uiTxt_DatabaseName.Text);
        }

        #endregion Method End

        #region Event

        /// <summary>
        /// Save 버튼 클릭시, 실행되는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("저장하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                UpdateValue();
                LoadValue();

                //Program.SetConfigValues();

                MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        /// <summary>
        /// Close 버튼 클릭시, 실행되는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("설정화면을 종료하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        #endregion Event End
    }
}
