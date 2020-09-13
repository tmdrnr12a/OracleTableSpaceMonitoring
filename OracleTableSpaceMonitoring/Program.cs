
using System;
using System.Windows.Forms;
using OracleTableSpaceMonitoring.Manager;

namespace OracleTableSpaceMonitoring
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Config File
            FileManager.FileName = @"Config.ini";

            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
