using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace old_win_forms_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new generalTask3());
            //Application.Run(new generalTask4());
            //Application.Run(new generalTask5());
            //Application.Run(new generalTask6());
            //Application.Run(new individualTask1());
            //Application.Run(new individualTask2());
            Application.Run(new individualTask3());
        }
    }
}
