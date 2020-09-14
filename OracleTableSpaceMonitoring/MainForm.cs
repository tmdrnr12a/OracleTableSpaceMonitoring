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
        private readonly int delaySeconds = 60;

        // Connect to DB
        private BackgroundWorker ConnectWorker = null;

        // Refresh UI
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

        /// <summary>
        /// Initialize form
        /// </summary>
        private void InitForm()
        {
            SetConfigImage();

            InitTableSpaceList();

            FixDistance();

            uiFlp_Main.AutoScroll = true;
        }

        /// <summary>
        /// Set image of configuration butoon
        /// </summary>
        private void SetConfigImage()
        {
            uiBtn_Config.ImageFocusIn = Properties.Resources.ConfigMouseMove;
            uiBtn_Config.ImageClick = Properties.Resources.ConfigMouseClick;
            uiBtn_Config.ImageDefault = Properties.Resources.ConfigDefault;
        }

        /// <summary>
        /// Initialize TableSpace List
        /// </summary>
        private void InitTableSpaceList()
        {
            uiChkList_TableSpace.CheckOnClick = true;
            uiChkList_TableSpace.ThreeDCheckBoxes = true;

            uiChkList_TableSpace.Items.Clear();
        }

        /// <summary>
        /// Fix splitter distance of SplitContainer 
        /// </summary>
        private void FixDistance()
        {
            uiSC_Main.SplitterDistance = 250;
        }

        /// <summary>
        /// Connect to DB 
        /// </summary>
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

        /// <summary>
        /// Set TableSpace list
        /// </summary>
        /// <param name="ds"></param>
        private void SetTableSpaceList(DataSet ds)
        {
            object[] arrObj = ds.Tables[0].Select().Select(x => x["NAME"]).ToArray();
            uiChkList_TableSpace.Items.AddRange(arrObj);         
        }

        /// <summary>
        /// Select all TableSpace 
        /// </summary>
        private void SetAllCheck()
        {
            for (int i = 0; i < uiChkList_TableSpace.Items.Count; i++)
                uiChkList_TableSpace.SetItemChecked(i, true);
        }

        /// <summary>
        /// Create TableSpace control
        /// </summary>
        /// <param name="ds"></param>
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

        /// <summary>
        /// Refresh UI thread
        /// </summary>
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

        /// <summary>
        /// Refresh TableSpace size
        /// </summary>
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

        /// <summary>
        /// Try to connect DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectWorker_DoWork(object sender, DoWorkEventArgs e)
        {
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

                RefreshUI();
            }
        }

        /// <summary>
        /// Show according to check status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Oracle instance exception event
        /// </summary>
        /// <param name="LocationID"></param>
        /// <param name="ex"></param>
        private void Instance_ExceptionEvent(string LocationID, Exception ex)
        {
            string msg = $"[{LocationID}] - {ex.Message}]";
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Events
    }
}
