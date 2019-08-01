using System;
using System.Windows.Forms;

namespace BMP2PNG
{
    /// <summary>
    /// Super simple BMP to PNG converter that I needed for a project I was working on.
    /// </summary>
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
            Application.Run(new BmpPngForm());
        }
    }
}
