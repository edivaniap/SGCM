using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using appSGCM.UI;
using appSGCM.CORE.Model;

namespace appSGCM
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

            frmLogin frmLogin = new frmLogin();

            Usuario usuarioLogado = new Usuario();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                usuarioLogado = frmLogin.usuarioLogado;
                Application.Run(new frmPrincipal(usuarioLogado));
            }
        }
    }
}
