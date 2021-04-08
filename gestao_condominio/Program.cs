using gestao_condominio.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestao_condominio
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
            frmLogin frmL = new frmLogin();
            
            if (frmL.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new menu());
            }
        }
    }
}
