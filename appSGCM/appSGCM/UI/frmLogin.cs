using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using appSGCM.CORE.DAL;

namespace appSGCM.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            InitializeComponent();
            Thread.Sleep(5000);
            t.Abort();
        }

        public void SplashScreen()
        {
            Application.Run(new TelaDeSplash());
        }

        private void btnFechar_MouseHover(object sender, EventArgs e)
        {
            lbDescricaoBotao.Text = "Fechar aplicativo";
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            lbDescricaoBotao.Text = "";
        }

        private void btnEntrar_MouseHover(object sender, EventArgs e)
        {
            lbDescricaoBotao.Text = "Entrar no sistema";
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            lbDescricaoBotao.Text = "";
        }

        public Usuario usuarioLogado = new Usuario();

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();

            if (usuarioDAL.Selecionar().Count == 0)
            {
                MessageBox.Show("Sistema sem usuários!" + Environment.NewLine + "Cadastre o usuário administrador.", "Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmCadastroUsuario cadastroUsuario = new frmCadastroUsuario("");
                cadastroUsuario.ShowDialog();
            }
            else
            {
                if (usuarioDAL.Autenticacao(txtLogin.Text, txtSenha.Text) == true)
                {
                    for (int i = 0; i < usuarioDAL.Selecionar().Count(); i++)
                    {
                        if (txtLogin.Text.Equals(usuarioDAL.Selecionar().ElementAt(i).Login))
                        {
                            usuarioLogado = usuarioDAL.Selecionar().ElementAt(i);
                        }
                    }

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    lbMsgErro.Visible = true;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbMsgErro_MouseHover(object sender, EventArgs e)
        {
            lbDescricaoBotao.Text = "Procure a administração caso não consiga entrar";
        }

        private void lbMsgErro_MouseLeave(object sender, EventArgs e)
        {
            lbDescricaoBotao.Text = "";
        }
    }
}
