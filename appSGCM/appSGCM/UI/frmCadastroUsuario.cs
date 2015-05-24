using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appSGCM.CORE.Model;
using appSGCM.CORE.DAL;

namespace appSGCM.UI
{
    public partial class frmCadastroUsuario : Form
    {
        FuncionarioDAL funcionarioDAL;
        string comando2;
        int codigo;
        string senhaAtual;
        ServicoDAL servicoDAL;
        ClienteDAL clienteDAL;

        bool primeiroUsuario;

        public frmCadastroUsuario()
        {
            InitializeComponent();
            funcionarioDAL = new FuncionarioDAL();
            servicoDAL = new ServicoDAL();
            clienteDAL = new ClienteDAL();
            comando2 = "Cadastrar";
            primeiroUsuario = false;
            for (int i = 0; i < funcionarioDAL.Selecionar().Count(); i++)
            {
                cbxCodFuncionario.Items.Add(funcionarioDAL.Selecionar().ElementAt(i).Codigo);
            }         
        }
        
        public frmCadastroUsuario(string x)
        {
            InitializeComponent();
            funcionarioDAL = new FuncionarioDAL();
            servicoDAL = new ServicoDAL();
            clienteDAL = new ClienteDAL();
            comando2 = "Cadastrar";
            primeiroUsuario = true;
            cbxTipo.SelectedIndex = 0;

            if (cbxCodFuncionario.Items.Count > 0)
            {
                for (int i = 0; i < funcionarioDAL.Selecionar().Count(); i++)
                {
                    cbxCodFuncionario.Items.Add(funcionarioDAL.Selecionar().ElementAt(i).Codigo);
                }

                cbxCodFuncionario.SelectedIndex = 0;
            }            
            cbxTipo.Enabled = false;            
        }

        public frmCadastroUsuario(Usuario usuario, string comando)
        {
            InitializeComponent();

            funcionarioDAL = new FuncionarioDAL();

            this.Text = "SGCM - Alterar Usuário " + usuario.Codigo;

            comando2 = comando;
            codigo = usuario.Codigo;
            senhaAtual = usuario.Senha;

            txtSenhaAtual.Enabled = true;

            txtUsuario.Text = usuario.Login;
            cbxTipo.Text = usuario.Tipo;
            //txtSenhaAtual.Text = usuario.Senha;

            for (int i = 0; i < funcionarioDAL.Selecionar().Count(); i++)
            {
                cbxCodFuncionario.Items.Add(funcionarioDAL.Selecionar().ElementAt(i).Codigo);
            }

            foreach (object item in cbxCodFuncionario.Items)
            {
                if (item.ToString() == usuario.CodFuncionario.ToString())
                {
                    cbxCodFuncionario.SelectedItem = item;
                    break;
                }
            }

            if (comando2.Equals("Alterar"))
            {
                btnCadastrar.Text = "Alterar";
                cbxCodFuncionario.Enabled = false;
            }
            if (comando2.Equals("Alterar-se"))
            {
                cbxTipo.Enabled = false;
                cbxCodFuncionario.Enabled = false;
            }
        }

        bool existeLogin;
        bool funcEUsuario;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            Usuario usuario = new Usuario();
            existeLogin = false;
            funcEUsuario = false;

            for (int i = 0; i < usuarioDAL.Selecionar().Count(); i++)
            {
                if(txtUsuario.Text.Equals(usuarioDAL.Selecionar().ElementAt(i).Login))
                {
                    existeLogin = true;
                }

                if (cbxCodFuncionario.SelectedItem.ToString().Equals(usuarioDAL.Selecionar().ElementAt(i).CodFuncionario.ToString()))
                {
                    funcEUsuario = true;
                }
            }

            try
            {
                if (cbxTipo.Text == "<inserir>" || cbxTipo.Text == "")
                {
                    MessageBox.Show("Selecione um tipo de usuário", "Cadastro/Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                }
                else if (txtSenhaNova.Text != txtSenhaConfirmacao.Text)
                {
                    MessageBox.Show("Nova senha e confirmação não correspondem", "Cadastro/Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSenhaNova.Text == "" || txtSenhaConfirmacao.Text == "")
                {
                    MessageBox.Show("O(s) campo(s) de nova senha e/ou confirmação estão vazio(s)", "Cadastro/Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (existeLogin == true && comando2.Equals("Cadastrar"))
                {
                    MessageBox.Show("Nome de usuário já existente. Tente outro nome!",
                        "Cadastro/Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (funcEUsuario == true && comando2.Equals("Cadastrar"))
                {
                    MessageBox.Show("Este Funcionário já está cadastrado como Usuário", "Cadastro/Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtUsuario.Text.Length < 5 || txtSenhaNova.Text.Length < 6)
                {
                    MessageBox.Show("Tamanho mínimo de caracteres para:"+ Environment.NewLine +
                        "Usuário: 5 caracteres" + Environment.NewLine + "Senha: 6 caracteres", "Cadastro/Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    usuario.Login = txtUsuario.Text;
                    usuario.Senha = txtSenhaNova.Text;
                    usuario.Tipo = cbxTipo.Text;
                    usuario.CodFuncionario = Convert.ToInt32(cbxCodFuncionario.Text);

                    if (comando2.Equals("Cadastrar"))
                    {
                        usuarioDAL.Inserir(usuario);
                        MessageBox.Show("Usuário cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (primeiroUsuario == true)
                        {
                            Servico servico = new Servico();
                            servico.Tipo = "Venda";
                            servico.Descricao = "Venda de produtos pelo caixa";
                            servicoDAL.Inserir(servico);

                            Cliente cliente = new Cliente();
                            cliente.Complemento = "-";
                            cliente.CEP = "-";
                            cliente.Celular = "-";
                            cliente.Telefone = "-";
                            cliente.Email = "-";
                            cliente.Site = "-";
                            cliente.Facebook = "-";
                            cliente.Nome = "Consumidor Final";
                            cliente.Endereco = "-";
                            cliente.Numero = 0;
                            cliente.Bairro = "-";
                            cliente.Cidade = "-";
                            cliente.UF = "-";

                            cliente.Nascimento = DateTime.Now;
                            cliente.RG = "-";
                            cliente.CPF = "-";
                            cliente.Sexo = "-";
                            clienteDAL.Inserir(cliente);
                        }
    
                        DialogResult = DialogResult.OK;
                        Close();                      
                    }
                    else if (comando2.Equals("Alterar") || comando2.Equals("Alterar-se"))
                    {
                        if (txtSenhaAtual.Text.Equals(senhaAtual))
                        {
                            usuarioDAL.Alterar(usuario, codigo);
                            MessageBox.Show("Usuário alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Senha atual incorreta", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Algum(ns) Campos estão vazios", ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na inserção de dados", ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario cadastroFuncionario = new frmCadastroFuncionario();
            if (cadastroFuncionario.ShowDialog() == DialogResult.OK)
            {
                cbxCodFuncionario.Items.Add(funcionarioDAL.Selecionar().Last().Codigo);
            }
        }
    }
}
