using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appSGCM.UI;
using appSGCM.CORE.Model;
using appSGCM.CORE.DAL;
using System.Diagnostics;

namespace appSGCM.UI
{
    public partial class frmPrincipal : Form
    {
        Usuario usuarioLogado = new Usuario();
        
        public frmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            statusUsuario.Text = "Usuário: " + usuario.Login;
            statusTipo.Text = "Tipo: " + usuario.Tipo;
            // Controle de usuário terminar.
            if (usuario.Tipo.Equals("Básico"))
            {
                btnConsultarUsuarios.Enabled = false;
                btnConsultarFuncionarios.Enabled = false;
                btnConsultarFornecedores.Enabled = false;
                usuárioTSMenuItens.Enabled = false;
                serviçosToolStripMenuItem.Enabled = false;
                vendasToolStripMenuItem.Enabled = false;
                usuáriosToolStripMenuItem.Enabled = false;
                btnConsultarFornecedores.Enabled = false;
                empresaToolStripMenuItem.Enabled = false;
                funcionarioTSMenuItens.Enabled = false;
                fornecedorTSMenuItens.Enabled = false;
                vendasToolStripMenuItem.Enabled = false;
            }
            else if (usuario.Tipo.Equals("SubAdministrador"))
            {
                btnConsultarUsuarios.Enabled = false;
                usuárioTSMenuItens.Enabled = false;
                usuáriosToolStripMenuItem.Enabled = false;
                empresaToolStripMenuItem.Enabled = false;
                funcionarioTSMenuItens.Enabled = false;
            }
            else if (usuario.Tipo.Equals("Administrador"))
            {
                btnConsultarUsuarios.Enabled = true;
                btnConsultarFuncionarios.Enabled = true;
                btnConsultarFornecedores.Enabled = true;
                usuárioTSMenuItens.Enabled = true;
                serviçosToolStripMenuItem.Enabled = true;
                vendasToolStripMenuItem.Enabled = true;
                usuáriosToolStripMenuItem.Enabled = true;
                btnConsultarFornecedores.Enabled = true;
                empresaToolStripMenuItem.Enabled = true;
                funcionarioTSMenuItens.Enabled = true;
                fornecedorTSMenuItens.Enabled = true;
                vendasToolStripMenuItem.Enabled = true;
            }
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            statusHora.Text = DateTime.Now.ToString("HH:mm:ss");
            statusData.Text = DateTime.Now.ToLongDateString();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadastroCliente = new frmCadastroCliente();
            cadastroCliente.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario cadastroFuncionario = new frmCadastroFuncionario();
            cadastroFuncionario.Show();
        }


        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor cadastroFornecedor = new frmCadastroFornecedor();
            cadastroFornecedor.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastroProduto = new frmCadastroProduto();
            cadastroProduto.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastroUsuario = new frmCadastroUsuario();
            cadastroUsuario.Show();
        }


        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            frmAgendaAtendimento agendaAtendimentos = new frmAgendaAtendimento(usuarioLogado.CodFuncionario);
            agendaAtendimentos.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            EmpresaDAL empresaDAL = new EmpresaDAL();

            if (empresaDAL.IsFilled() == false)
            {
                MessageBox.Show("Cadastre uma empresa antes de abrir o Caixa!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmDadosEmpresa cadastroEmpresa = new frmDadosEmpresa();
                cadastroEmpresa.ShowDialog();
            }
            else
            {
                frmControleVendas caixa = new frmControleVendas(usuarioLogado.CodFuncionario);
                caixa.Show();
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDadosEmpresa dadosEmpresa = new frmDadosEmpresa();
            dadosEmpresa.Show();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadora = new frmCalculadora();
            calculadora.Show();
        }

        private void btnConsultarUsuarios_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarios consultaUsuarios = new frmConsultaUsuarios();
            consultaUsuarios.Show();
        }

        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionarios consultaFuncionarios = new frmConsultaFuncionarios();
            consultaFuncionarios.Show();
        }

        private void btnConsultarFornecedores_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedores consultarFornecedores = new frmConsultaFornecedores();
            consultarFornecedores.Show();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            frmConsultaClientes consultaClientes = new frmConsultaClientes();
            consultaClientes.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Maximized;            
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmConsultaProdutos consultaProdutos = new frmConsultaProdutos();
            consultaProdutos.Show();
        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            EmpresaDAL empresaDAL = new EmpresaDAL();

            Process myProcess = new Process();

            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = empresaDAL.Selecionar().Site;
                myProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void servicoTSMenuItens_Click(object sender, EventArgs e)
        {
            frmCadastroServico cadastroServico = new frmCadastroServico();
            cadastroServico.Show();
        }

        private void usuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadastroUsuario alterarUsuario = new frmCadastroUsuario(usuarioLogado, "Alterar-se");
            if (alterarUsuario.ShowDialog() == DialogResult.OK)
            {
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                Usuario usuarioAlterado = new Usuario();

                for (int i = 0; i < usuarioDAL.Selecionar().Count(); i++)
                {
                    if (usuarioDAL.Selecionar().ElementAt(i).Codigo == usuarioLogado.Codigo)
                    {
                        usuarioAlterado = usuarioDAL.Selecionar().ElementAt(i);
                        usuarioLogado = usuarioAlterado;
                    }
                }

                statusUsuario.Text = "Usuário: " + usuarioLogado.Login;
                statusTipo.Text = "Tipo: " + usuarioLogado.Tipo;
            }            
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarios consultaUsuarios = new frmConsultaUsuarios();
            consultaUsuarios.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaServicos consultaServicos = new frmConsultaServicos();
            consultaServicos.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProdutos consultaProdutos = new frmConsultaProdutos();
            consultaProdutos.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmInformativo info = new frmInformativo();
            info.ShowDialog();*/
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVendas consultarVendas = new frmConsultaVendas();
            consultarVendas.Show();
        }

        private void informativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformativo info = new frmInformativo();
            info.ShowDialog();
        }      
    }
}
