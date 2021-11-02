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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(Screen.PrimaryScreen.WorkingArea.Size.Width / boxSize, (Screen.PrimaryScreen.WorkingArea.Size.Height - 23) / boxSize, boxSize, 40));
            
            
        }
    }
}
