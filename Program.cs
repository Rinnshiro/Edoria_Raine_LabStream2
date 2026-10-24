using System;
using System.Windows.Forms;

namespace Edoria_Raine_LabStream
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmOpenTextFile());
        }
    }
}
