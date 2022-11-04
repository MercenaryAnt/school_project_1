using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_project_1
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
            if (LisanslamaIslemleri.lisansKontrol())
                Application.Run(new KullaniciGirisi());
            else
                Application.Run(new Baslangic());
        }
    }
}
