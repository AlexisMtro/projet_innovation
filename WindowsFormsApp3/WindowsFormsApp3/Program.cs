using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            string FileStream = "StreamVoidReader.txt";
            string PathFileStreamer = System.IO.Path.Combine(Application.StartupPath, FileStream);
            System.IO.File.Delete(PathFileStreamer);
        }
    }
}
