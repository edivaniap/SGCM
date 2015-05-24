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
    public partial class frmCadastroFornecedor : Form
    {
        string comando2;
        int codigo;
        FornecedorDAL fornecedorDAL;

        public frmCadastroFornecedor()
        {
            InitializeComponent();
            fornecedorDAL = new FornecedorDAL();
            lbDataAtualizacao.Text = "";
            comando2 = "Cadastrar";            
        }

        public frmCadastroFornecedor(Fornecedor fornecedor, string comando)
        {
            InitializeComponent();
            fornecedorDAL = new FornecedorDAL();
            try
            {
                txtNomeEmpresa.Text = fornecedor.Nome;
                txtEndereco.Text = fornecedor.Endereco;
                txtNum.Text = fornecedor.Numero.ToString();
                mskCNPJ.Text = fornecedor.CNPJ;
                txtComplemento.Text = fornecedor.Complemento;
                txtBairro.Text = fornecedor.Bairro;
                txtCidade.Text = fornecedor.Cidade;
                cbxUF.Text = fornecedor.UF;
                mskCEP.Text = fornecedor.CEP;
                mskCelular.Text = fornecedor.Celular;
                mskTelefone.Text = fornecedor.Telefone;
                txtEmail.Text = fornecedor.Email;
                txtSite.Text = fornecedor.Site;
                txtFaceBook.Text = fornecedor.Facebook;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Preenchimento de Componentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
            for (int i = 0; i < fornecedorDAL.Selecionar().Count(); i++)
            {
                if (fornecedor.Codigo.Equals(fornecedorDAL.Selecionar().ElementAt(i).Codigo))
                {
                    lbDataAtualizacao.Text = fornecedorDAL.Selecionar().ElementAt(i).DataAtualizacao;
                }
            }

            codigo = fornecedor.Codigo;

            if (comando.Equals("Alterar"))
            {
                this.Text = "SGCM - Alterar Fornecedor " + fornecedor.Codigo;                
                btnCadastrar.Text = "Alterar";
                comando2 = comando;               
            }
            else 
            {
                txtNomeEmpresa.ReadOnly = true;
                mskCNPJ.ReadOnly = true;
                txtEndereco.ReadOnly = true;
                txtNum.ReadOnly = true;
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
                    this.Text = "SGCM - Fornecedor " + fornecedor.Codigo;
                    btnCancelar.Text = "OK";
                    btnCadastrar.Visible = false;
                }
                else if (comando.Equals("Deletar"))
                {
                    this.Text = "SGCM - Deletar Fornecedor " + fornecedor.Codigo;
                    btnCadastrar.Text = "Deletar";                    
                    comando2 = comando;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (comando2.Equals("Deletar"))
            {
                if (MessageBox.Show("Tem certeza que deseja deletar este fornecedor?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fornecedorDAL.Deletar(codigo);
                    MessageBox.Show("Fornecedor deletado com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Complemento = txtComplemento.Text;
                fornecedor.CEP = mskCEP.Text;
                fornecedor.Celular = mskCelular.Text;
                fornecedor.Telefone = mskTelefone.Text;
                fornecedor.Email = txtEmail.Text;
                fornecedor.Site = txtSite.Text;
                fornecedor.Facebook = txtFaceBook.Text;

                try
                {
                    fornecedor.Nome = txtNomeEmpresa.Text;
                    fornecedor.CNPJ = mskCNPJ.Text;
                    fornecedor.Endereco = txtEndereco.Text;
                    fornecedor.Numero = Convert.ToInt32(txtNum.Text);
                    fornecedor.Bairro = txtBairro.Text;
                    fornecedor.Cidade = txtCidade.Text;
                    fornecedor.UF = cbxUF.Text;

                    if (comando2.Equals("Cadastrar"))
                    {
                        fornecedorDAL.Inserir(fornecedor);
                        MessageBox.Show("Fornecedor cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;

                        txtNomeEmpresa.Text = "";
                        txtEndereco.Text = "";
                        txtComplemento.Text = "";
                        txtBairro.Text = "";
                        txtCidade.Text = "";
                        mskCNPJ.Text = "";
                        cbxUF.Text = "AC";
                        mskCEP.Text = "";
                        mskCelular.Text = "";
                        mskTelefone.Text = "";
                        txtEmail.Text = "";
                        txtSite.Text = "";
                        txtFaceBook.Text = "";
                        mskCNPJ.Text = "";
                    }
                    else if (comando2.Equals("Alterar"))
                    {
                        fornecedorDAL.Alterar(fornecedor, codigo);
                        MessageBox.Show("Fornecedor alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
