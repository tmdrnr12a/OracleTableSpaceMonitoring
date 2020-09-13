using OracleTableSpaceMonitoring.Controls;
using OracleTableSpaceMonitoring.Forms;
using OracleTableSpaceMonitoring.Manager;
using OracleTableSpaceMonitoring.Processor;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace OracleTableSpaceMonitoring
{
    public partial class MainForm : Form
    {
        #region Variables

        // Delay time to update UI
        private readonly int delaySeconds = 5;

        private readonly string enableTag = "EnableControls";

        private BackgroundWorker ConnectWorker = null;

        private Thread thRefresh = null;

        #endregion Variables

        #region Create & Load & Shown

        public MainForm()
        {
            InitializeComponent();

            this.Shown += MainForm_Shown;
            this.SizeChanged += (object sender, EventArgs e) => { FixDistance(); };

            uiBtn_Config.Click += (object sender, EventArgs e) => { (new ConfigForm()).ShowDialog(); };

            uiChkList_TableSpace.ItemCheck += UiChkList_TableSpace_ItemCheck;

            OracleManager.Instance.ExceptionEvent += Instance_ExceptionEvent;
        }

        public void MainForm_Shown(object sender, EventArgs e)
        {
            InitForm();

            ConnectDB();
        }

        #endregion Create & Load & Shown

        #region Methods

        private void InitForm()
        {
            SetConfigImage();

            SetControlTag();

            InitTableSpaceList();

            FixDistance();

            uiFlp_Main.AutoScroll = true;
        }

        private void SetConfigImage()
        {
            uiBtn_Config.ImageFocusIn = Properties.Resources.ConfigMouseMove;
            uiBtn_Config.ImageClick = Properties.Resources.ConfigMouseClick;
            uiBtn_Config.ImageDefault = Properties.Resources.ConfigDefault;
        }

        private void SetControlTag()
        {
            uiSC_Main.Tag = this.enableTag;
        }

        private void InitTableSpaceList()
        {
            uiChkList_TableSpace.CheckOnClick = true;
            uiChkList_TableSpace.ThreeDCheckBoxes = true;

            uiChkList_TableSpace.Items.Clear();
        }

        private void FixDistance()
        {
            uiSC_Main.SplitterDistance = 250;
        }

        private void ConnectDB()
        {
            if (this.ConnectWorker == null)
            {
                this.ConnectWorker = new BackgroundWorker();
                this.ConnectWorker.DoWork += ConnectWorker_DoWork;
                this.ConnectWorker.RunWorkerCompleted += ConnectWorker_RunWorkerCompleted;
            }

            this.ConnectWorker.RunWorkerAsync();
        }

        private void EnableControls(bool flag)
        {
            if (uiSC_Main.InvokeRequired == true)
            {
                uiSC_Main.Invoke(new MethodInvoker(delegate ()
                {
                    uiSC_Main.Enabled = flag;
                }));
            }
            else
            {
                uiSC_Main.Enabled = flag;
            }
        }

        private void SetTableSpaceList(DataSet ds)
        {
            object[] arrObj = ds.Tables[0].Select().Select(x => x["NAME"]).ToArray();
            uiChkList_TableSpace.Items.AddRange(arrObj);         
        }

        private void SetAllCheck()
        {
            for (int i = 0; i < uiChkList_TableSpace.Items.Count; i++)
                uiChkList_TableSpace.SetItemChecked(i, true);
        }

        private void CreateTableSpaceControl(DataSet ds)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                TableSpaceCtl ctl = new TableSpaceCtl()
                {
                    TABLESPACE_NAME = ds.Tables[0].Rows[i]["NAME"].ToString(),
                    TOTAL_SIZE = Convert.ToDouble(ds.Tables[0].Rows[i]["TOTAL_SIZE"].ToString()),
                    FREE_SIZE = Convert.ToDouble(ds.Tables[0].Rows[i]["FREE_SIZE"].ToString()),
                    PERCENTAGE = Convert.ToInt32(ds.Tables[0].Rows[i]["PERCENTAGE"].ToString()),
                };

                uiFlp_Main.Controls.Add(ctl);
            }
        }

        private void RefreshUI()
        {
            if (this.thRefresh != null && this.thRefresh.IsAlive == true)
            {
                this.thRefresh.Abort();
                this.thRefresh = null;
            }

            this.thRefresh = new Thread(new ThreadStart(RefreshTableSpace))
            {
                IsBackground = true
            };
            this.thRefresh.Start();
        }

        private void RefreshTableSpace()
        {
            while (true)
            {
                RefreshSize();

                Thread.Sleep(1000 * this.delaySeconds);
            }
        }

        private void RefreshSize()
        {
            DataSet ds = DatabaseProcessor.Instance.GetTableSpaceList();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string tableSpaceName = ds.Tables[0].Rows[i]["NAME"].ToString();
                    double freeSize = Convert.ToDouble(ds.Tables[0].Rows[i]["FREE_SIZE"].ToString());
                    int percentage = Convert.ToInt32(ds.Tables[0].Rows[i]["PERCENTAGE"].ToString());

                    for (int k = 0; k < uiFlp_Main.Controls.Count; k++)
                    {
                        TableSpaceCtl ctl = uiFlp_Main.Controls[k] as TableSpaceCtl;

                        if (ctl.TABLESPACE_NAME != tableSpaceName)
                            continue;

                        ctl.FREE_SIZE = freeSize;
                        ctl.PERCENTAGE = percentage;
                        ctl.SetCapacity();
                    }
                }
            }
        }

        #endregion Methods

        #region Events

        private void ConnectWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            EnableControls(false);

            while (true)
            {
                try
                {
                    if (OracleManager.Instance.GetConnection() == true)
                        break;

                    Thread.Sleep(1000);
                }
                catch { }
            }
        }

        private void ConnectWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataSet ds = DatabaseProcessor.Instance.GetTableSpaceList();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                SetTableSpaceList(ds);
                SetAllCheck();

                CreateTableSpaceControl(ds);

                EnableControls(true);

                RefreshUI();
            }
        }

        private void UiChkList_TableSpace_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (uiFlp_Main.Controls.Count == 0)
                return;

            CheckedListBox chkListBox = sender as CheckedListBox;
            bool checkFlag = chkListBox.GetItemChecked(chkListBox.SelectedIndex);

            for (int i = 0; i < uiFlp_Main.Controls.Count; i++)
            {
                if (i == chkListBox.SelectedIndex)
                {
                    uiFlp_Main.Controls[chkListBox.SelectedIndex].Visible = !checkFlag;
                    break;
                }
            }
        }
        private void Instance_ExceptionEvent(string LocationID, Exception ex)
        {
            string msg = $"[{LocationID}] - {ex.Message}]";
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Events
    }
}
