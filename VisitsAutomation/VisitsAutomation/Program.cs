using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitsAutomation.Forms;
using VisitsAutomation.Models;
using VisitsAutomation.Utils;

namespace VisitsAutomation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Init files with the start data about students, groups and etr.
            InitializationUtil.InitFiles();            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
