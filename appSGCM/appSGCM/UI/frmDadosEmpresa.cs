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
    public partial class frmDadosEmpresa : Form
    {
        EmpresaDAL empresaDAL;

        public frmDadosEmpresa()
        {
            InitializeComponent();
            empresaDAL = new EmpresaDAL();
            
            if (empresaDAL.IsFilled() == true)
                btnInserir.Text = "Alterar";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();

            empresa.Complemento = txtComplemento.Text;
            empresa.CEP = mskCEP.Text;
            empresa.Celular = mskCelular.Text;
            empresa.Telefone = mskTelefone.Text;
            empresa.Email = txtEmail.Text;
            empresa.Site = txtSite.Text;
            empresa.Facebook = txtFaceBook.Text;

            try
            {
                empresa.Nome = txtNomeEmpresa.Text;
                empresa.CNPJ = mskCNPJ.Text;
                empresa.CPF = mskCPF.Text;
                empresa.RG = mskRG.Text;
                empresa.Proprietario = txtProprietario.Text;
                empresa.Filiais = Convert.ToInt32(nudFiliais.Value);
                empresa.Endereco = txtEndereco.Text;
                empresa.Numero = Convert.ToInt32(txtNum.Text);
                empresa.Bairro = txtBairro.Text;
                empresa.Cidade = txtCidade.Text;
                empresa.UF = cbxUF.Text;
                
                EmpresaDAL empresaDAL = new EmpresaDAL();

                if (empresaDAL.IsFilled() == false)
                {
                    empresaDAL.Inserir(empresa);
                    MessageBox.Show("Dados da Empresa cadastrados com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    Close();
                }
                else if (empresaDAL.IsFilled() == true)
                {   
                    empresaDAL.Alterar(empresa, empresaDAL.Selecionar().Codigo);
                    MessageBox.Show("Dados da Empresa alterados com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDadosEmpresa_Load(object sender, EventArgs e)
        {
            txtNomeEmpresa.Text = empresaDAL.Selecionar().Nome;
            mskCNPJ.Text = empresaDAL.Selecionar().CNPJ;
            mskCPF.Text = empresaDAL.Selecionar().CPF;
            mskRG.Text = empresaDAL.Selecionar().RG;
            txtProprietario.Text = empresaDAL.Selecionar().Proprietario;
            nudFiliais.Value = empresaDAL.Selecionar().Filiais;
            txtEndereco.Text = empresaDAL.Selecionar().Endereco;
            txtNum.Text = empresaDAL.Selecionar().Numero.ToString();
            txtBairro.Text = empresaDAL.Selecionar().Bairro;
            txtCidade.Text = empresaDAL.Selecionar().Cidade;
            cbxUF.Text = empresaDAL.Selecionar().UF;
            txtComplemento.Text = empresaDAL.Selecionar().Complemento;
            mskCEP.Text = empresaDAL.Selecionar().CEP;
            mskCelular.Text = empresaDAL.Selecionar().Celular;
            mskTelefone.Text = empresaDAL.Selecionar().Telefone;
            txtEmail.Text = empresaDAL.Selecionar().Email;
            txtSite.Text = empresaDAL.Selecionar().Site;
            txtFaceBook.Text = empresaDAL.Selecionar().Facebook;
            lbDataAtualizacao.Text = empresaDAL.Selecionar().DataAtualizacao; 
        }
    }
}
