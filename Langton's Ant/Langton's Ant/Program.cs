using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Langton_s_Ant
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int boxSize = 3;
            int x = Screen.PrimaryScreen.WorkingArea.Size.Width - 260, y = Screen.PrimaryScreen.WorkingArea.Size.Height - 23;
            //int x = 1150, y = 900;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(x / boxSize, (y) / boxSize, boxSize, 12));
            
            
        }
    }
}
