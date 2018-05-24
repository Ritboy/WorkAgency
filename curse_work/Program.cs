using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curse_work
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        //public static Form1 f1 = new Form1();
        //public static  Form2 f2 = new Form2();
        /// public static vakans v = new vakans();
       // public Data data = new Data();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Headform());
        }
    }
}
