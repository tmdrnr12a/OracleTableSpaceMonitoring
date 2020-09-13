using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace OracleTableSpaceMonitoring.Controls
{
    public partial class TableSpaceCtl : UserControl
    {

        #region Variables 

        public enum E_UNIT { UNKNOWN, MB, GB, TB, PB }

        // UNIT
        private long KBYTE = 0;
        private long MEGA = 0;
        private long GIGA = 0;
        private long TERA = 0;
        private long PETA = 0;

        // TABLESPACE Infomation
        private E_UNIT TABLESPACE_UNIT = E_UNIT.UNKNOWN;
        public string TABLESPACE_NAME = string.Empty;
        public double TOTAL_SIZE = 0;           // KByte Value
        public double FREE_SIZE = 0;            // KByte Value        
        public int PERCENTAGE = 0;

        #endregion Variables 

        #region Create & Load & Shown 

        public TableSpaceCtl()
        {
            InitializeComponent();

            this.Load += TableSpaceCtl_Load;
        }

        private void TableSpaceCtl_Load(object sender, EventArgs e)
        {
            SetUnit();
            SetIcon();
            SetInfo();
            SetCapacity();
        }

        #endregion Create & Load & Shown

        #region Methods

        private void SetUnit()
        {
            this.KBYTE = 1024;
            this.MEGA = this.KBYTE * 1024;
            this.GIGA = this.MEGA * 1024;
            this.TERA = this.GIGA * 1024;
            this.PETA = this.TERA * 1024;

            if (this.MEGA <= this.TOTAL_SIZE && this.TOTAL_SIZE < this.GIGA)
                this.TABLESPACE_UNIT = E_UNIT.MB;

            else if (this.GIGA <= this.TOTAL_SIZE && this.TOTAL_SIZE < this.TERA)
                this.TABLESPACE_UNIT = E_UNIT.GB;

            else if (this.TERA <= this.TOTAL_SIZE && this.TOTAL_SIZE < this.PETA)
                this.TABLESPACE_UNIT = E_UNIT.TB;

            else if (this.PETA <= this.TOTAL_SIZE)
                this.TABLESPACE_UNIT = E_UNIT.UNKNOWN;
        }

        private void SetIcon()
        {
            uiPic_Image.BackgroundImage = Properties.Resources.Database;
            uiPic_Image.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void SetInfo()
        {
            uiLab_Name.Text = this.TABLESPACE_NAME;

            uiProg_Capacity.BackColor = Color.FromKnownColor(KnownColor.Control);
            uiProg_Capacity.Style = ProgressBarStyle.Continuous;

            uiProg_Capacity.VisualMode = ProgressBarDisplayMode.Percentage;
            uiProg_Capacity.TextColor = Color.Black;
        }

        public void SetCapacity()
        {
            SetProgressValue(this.PERCENTAGE);
            SetProgressColor(this.PERCENTAGE);

            SetUsageText();
        }

        private void SetProgressValue(int value)
        {
            if (uiProg_Capacity.InvokeRequired == true)
            {
                uiProg_Capacity.Invoke(new MethodInvoker(delegate ()
                {
                    uiProg_Capacity.Value = value;
                }));
            }
            else
            {
                uiProg_Capacity.Value = value;
            }
        }

        private void SetProgressColor(int value)
        {
            if (0 <= value && value < 25)
                uiProg_Capacity.ProgressColor = Color.FromArgb(116, 182, 102);

            else if (25 <= value && value < 50)
                uiProg_Capacity.ProgressColor = Color.FromArgb(118, 190, 219);

            else if (50 <= value && value < 75)
                uiProg_Capacity.ProgressColor = Color.FromArgb(230, 176, 95);

            else
                uiProg_Capacity.ProgressColor = Color.FromArgb(201, 92, 84);
        }

        private void SetUsageText()
        {
            double unitValue = GetUnitValue();
            double freeSize = Math.Round(this.FREE_SIZE / unitValue, 2);
            double totalSize = Math.Round(this.TOTAL_SIZE / unitValue, 2);

            string usageText = $"{freeSize} {this.TABLESPACE_UNIT} free of {totalSize} {this.TABLESPACE_UNIT}";
            uiLab_Usage.Text = usageText;
        }

        /// <summary>
        /// Get disk unit value
        /// </summary>
        /// <returns></returns>
        private double GetUnitValue()
        {
            double unitValue = 0;
            switch (this.TABLESPACE_UNIT)
            {
                case E_UNIT.MB: unitValue = this.MEGA; break;
                case E_UNIT.GB: unitValue = this.GIGA; break;
                case E_UNIT.TB: unitValue = this.TERA; break;
                case E_UNIT.PB: unitValue = this.PETA; break;
                case E_UNIT.UNKNOWN: break;
            }

            return unitValue;
        }

        #endregion Methods

        #region Events

        #endregion Events
    }
}
