using System;
using System.Windows.Forms;

namespace Hotel_System
{
    static class Program
    {
        /// Основная точка входа в приложение
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
