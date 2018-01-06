using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExcel
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji. - 
        /// </summary>
        /// Zmiana danych w celu testu na git'cie
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
