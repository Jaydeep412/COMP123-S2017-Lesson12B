using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Name: Jaydeep Lakhwani
 * Student ID: 3009334575
 * Date: August 1, 2017
 * Description: Demo Application to showcase windows forms and UI Controls
 * Version: 0.1 - Project was created
 */
namespace COMP123_S2017_Lesson12B
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DemoForm());
        }
    }
}
