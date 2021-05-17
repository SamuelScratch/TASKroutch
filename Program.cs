using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TASKetch
{

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static Form1 newForm;


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            newForm = new Form1();
            Application.Run(newForm);
        }
    }
}
