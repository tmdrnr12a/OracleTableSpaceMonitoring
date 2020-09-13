using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace OracleTableSpaceMonitoring.Controls
{
    class PSKButton : Panel
    {
        #region " Variables "

        [Browsable(true)]
        public Image ImageDefault { get; set; } = SystemIcons.Error.ToBitmap();

        [Browsable(true)]
        public Image ImageFocusIn { get; set; } = SystemIcons.Error.ToBitmap();
    
        [Browsable(true)]
        public Image ImageClick { get; set; } = SystemIcons.Error.ToBitmap();

        #endregion " Variables End"

        #region " Create & Load & Shown "

        public PSKButton()
        {
            this.MouseLeave += (object sender, EventArgs e) => { this.BackgroundImage = this.ImageDefault; };
            this.MouseHover += (object sender, EventArgs e) => { this.BackgroundImage = this.ImageFocusIn; };
            this.MouseDown += (object sender, MouseEventArgs e) => { this.BackgroundImage = this.ImageClick; };

            this.BackgroundImage = null;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        #endregion " Create & Load & Shown End "

        #region " Methods "

        #endregion " Methods End "

        #region " Events "

        #endregion " Events End "
    }
}