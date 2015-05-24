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
    public partial class frmCadastroCliente : Form
    {
        string comando2;
        int codigo;
        ClienteDAL clienteDAL;
        
        public frmCadastroCliente()
        {
            InitializeComponent();
            clienteDAL = new ClienteDAL();
            comando2 = "Cadastrar";
            lbDataAtualizacao.Text = "";
        }

        public frmCadastroCliente(Cliente cliente, string comando)
        {
            InitializeComponent();

            clienteDAL = new ClienteDAL();

            try
            {
                txtNome.Text = cliente.Nome;

                if (cliente.Sexo == "Feminino")
                    rbtFeminino.Checked = true;
              

                dateNasc.Text = cliente.Nascimento.ToString();
                mskCPF.Text = cliente.CPF;
                mskRG.Text = cliente.RG;
                txtEndereco.Text = cliente.Endereco;
                txtNumResidencia.Text = cliente.Numero.ToString();
                txtComplemento.Text = cliente.Complemento;
                txtBairro.Text = cliente.Bairro;
                txtCidade.Text = cliente.Cidade;
                cbxUF.Text = cliente.UF;
                mskCEP.Text = cliente.CEP;
                mskCelular.Text = cliente.Celular;
                mskTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
                txtSite.Text = cliente.Site;
                txtFaceBook.Text = cliente.Facebook;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Preenchimento de Componentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < clienteDAL.Selecionar().Count(); i++)
            {
                if (cliente.Codigo.Equals(clienteDAL.Selecionar().ElementAt(i).Codigo))
                {
                    lbDataAtualizacao.Text = clienteDAL.Selecionar().ElementAt(i).DataAtualizacao;
                }
            }

            codigo = cliente.Codigo;

            if (comando.Equals("Alterar"))
            {
                this.Text = "SGCM - Alterar Cliente " + cliente.Codigo;
                btnCadastrar.Text = "Alterar";
                comando2 = comando;
            }
            else
            {
                txtNome.ReadOnly = true;
                rbtMasculino.Enabled = false;
                rbtFeminino.Enabled = false;
                dateNasc.Enabled = false;
                mskCPF.ReadOnly = true;
                mskRG.ReadOnly = true;
                txtEndereco.ReadOnly = true;
                txtNumResidencia.ReadOnly = true;
                txtComplemento.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtCidade.ReadOnly = true;
                cbxUF.Enabled = false;
                mskCEP.ReadOnly = true;
                mskCelular.ReadOnly = true;
                mskTelefone.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtSite.ReadOnly = true;
                txtFaceBook.ReadOnly = true;

                if (comando.Equals("Visualizar"))
                {
                    this.Text = "SGCM - Cliente " + cliente.Codigo;
                    btnCancelar.Text = "OK";
                    btnCadastrar.Visible = false;
                }
                else if (comando.Equals("Deletar"))
                {
                    this.Text = "SGCM - Deletar Cliente " + cliente.Codigo;
                    btnCadastrar.Text = "Deletar";
                    comando2 = comando;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (comando2.Equals("Deletar"))
            {
                if (clienteDAL.Selecionar().ElementAt(0).Codigo == codigo)
                {
                    MessageBox.Show("Este Cliente é padrão e não pode ser deletado", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("Tem certeza que deseja deletar este funcionário?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        clienteDAL.Deletar(codigo);
                        MessageBox.Show("Cliente deletado com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Complemento = txtComplemento.Text;
                cliente.CEP = mskCEP.Text;
                cliente.Celular = mskCelular.Text;
                cliente.Telefone = mskTelefone.Text;
                cliente.Email = txtEmail.Text;
                cliente.Site = txtSite.Text;
                cliente.Facebook = txtFaceBook.Text;
                try
                {
                    cliente.Nome = txtNome.Text;
                    cliente.Endereco = txtEndereco.Text;
                    cliente.Numero = Convert.ToInt32(txtNumResidencia.Text);
                    cliente.Bairro = txtBairro.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.UF = cbxUF.Text;

                    cliente.Nascimento = Convert.ToDateTime(dateNasc.Text);
                    cliente.RG = mskRG.Text;
                    cliente.CPF = mskCPF.Text;

                    if (rbtFeminino.Checked)
                    {
                        cliente.Sexo = "Feminino";
                    }
                    else if (rbtMasculino.Checked)
                    {
                        cliente.Sexo = "Masculino";
                    }

                    if (comando2.Equals("Cadastrar"))
                    {
                        clienteDAL.Inserir(cliente);
                        MessageBox.Show("Cliente cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        
                        txtNome.Text = "";
                        txtEndereco.Text = "";
                        txtNumResidencia.Text = "";
                        txtComplemento.Text = "";
                        txtBairro.Text = "";
                        txtCidade.Text = "";
                        mskRG.Text = "";
                        mskCPF.Text = "";
                        cbxUF.Text = "AC";
                        mskCEP.Text = "";
                        mskCelular.Text = "";
                        mskTelefone.Text = "";
                        txtEmail.Text = "";
                        txtSite.Text = "";
                        txtFaceBook.Text = "";
                    }
                    else if (comando2.Equals("Alterar"))
                    {
                        clienteDAL.Alterar(cliente, codigo);
                        MessageBox.Show("Cliente alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message, "Campo(s) vazio(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
