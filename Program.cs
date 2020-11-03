using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TightVNCLauncher
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        
        public static BindingList<THost> hosts = new BindingList<THost>();

        [STAThread]
        static void Main()
        {
            hosts.Add(new THost("192.168.15.1", "192.168.15.1", "Yflt;lf0"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
