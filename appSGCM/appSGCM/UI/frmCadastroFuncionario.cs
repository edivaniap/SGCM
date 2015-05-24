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
    public partial class frmCadastroFuncionario : Form
    {
        string diretorioImagem;
        string comando2;
        int codigo;
        FuncionarioDAL funcionarioDAL;
        
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            comando2 = "Cadastrar";
            lbDataAtualizacao.Text = "";
            diretorioImagem = "";
            funcionarioDAL = new FuncionarioDAL();
        }

        public frmCadastroFuncionario(Funcionario funcionario, string comando)
        {
            InitializeComponent();
            funcionarioDAL = new FuncionarioDAL();

            diretorioImagem = funcionario.Imagem;

            try
            {
                txtNome.Text = funcionario.Nome;

                if (funcionario.Sexo == "Feminino")
                    rbtFeminino.Checked = true;

                dateNasc.Text = funcionario.Nascimento.ToString();
                mskCPF.Text = funcionario.CPF;
                mskRG.Text = funcionario.RG;
                cbxEstadoCivil.Text = funcionario.Estado_Civil;
                txtNacionalidade.Text = funcionario.Nacionalidade;
                txtCateiraTrab.Text = funcionario.Carteira_Trabalho;
                dateExpedicaoCT.Text = funcionario.Expedicao_CT.ToString();
                txtEndereco.Text = funcionario.Endereco;
                txtNumResidencia.Text = funcionario.Numero.ToString();
                txtComplemento.Text = funcionario.Complemento;
                txtBairro.Text = funcionario.Bairro;
                txtCidade.Text = funcionario.Cidade;
                cbxUF.Text = funcionario.UF;
                mskCEP.Text = funcionario.CEP;
                mskCelular.Text = funcionario.Celular;
                mskTelefone.Text = funcionario.Telefone;
                txtEmail.Text = funcionario.Email;
                txtSite.Text = funcionario.Site;
                txtFaceBook.Text = funcionario.Facebook;
                cbxCargo.Text = funcionario.Cargo;
                cbxTipoContrato.Text = funcionario.Tipo_Contrato;
                nudSalario.Text = funcionario.Salario;
                nudDependentes.Value = funcionario.Dependentes;
                mskHorasDiarias.Text = funcionario.Horas_Diarias;

                if (funcionario.Turno == "Matutino")
                {
                    ckbMatutino.Checked = true;
                    ckbVespertino.Checked = false;
                    ckbNoturno.Checked = false;
                }
                else if (funcionario.Turno == "Vespertino")
                {
                    ckbMatutino.Checked = false;
                    ckbVespertino.Checked = true;
                    ckbNoturno.Checked = false;
                }
                else if (funcionario.Turno == "Noturno")
                {
                    ckbMatutino.Checked = false;
                    ckbVespertino.Checked = false;
                    ckbNoturno.Checked = true;
                }
                else if (funcionario.Turno == "Matutino/Vespertino")
                {
                    ckbMatutino.Checked = true;
                    ckbVespertino.Checked = true;
                    ckbNoturno.Checked = false;
                }
                else if (funcionario.Turno == "Matutino/Noturno")
                {
                    ckbMatutino.Checked = true;
                    ckbVespertino.Checked = false;
                    ckbNoturno.Checked = true;
                }
                else if (funcionario.Turno == "Vespertino/Noturno")
                {
                    ckbMatutino.Checked = false;
                    ckbVespertino.Checked = true;
                    ckbNoturno.Checked = true;
                }
                else if (funcionario.Turno == "Matutino/Vespertino/Noturno")
                {
                    ckbMatutino.Checked = true;
                    ckbVespertino.Checked = true;
                    ckbNoturno.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Preenchimento de Componentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < funcionarioDAL.Selecionar().Count(); i++)
            {
                if (funcionario.Codigo.Equals(funcionarioDAL.Selecionar().ElementAt(i).Codigo))
                {
                    lbDataAtualizacao.Text = funcionarioDAL.Selecionar().ElementAt(i).DataAtualizacao;
                }
            }

            codigo = funcionario.Codigo;

            if (comando.Equals("Alterar"))
            {
                this.Text = "SGCM - Alterar Funcionário " + funcionario.Codigo;
                btnCadastrar.Text = "Alterar";
                comando2 = comando;
            }
            else
            {
                btnAdicionar.Enabled = false;
                btnLimpar.Enabled = false;
                txtNome.ReadOnly = true;
                rbtMasculino.Enabled = false;
                rbtFeminino.Enabled = false;
                dateNasc.Enabled = false;
                mskCPF.ReadOnly = true;
                mskRG.ReadOnly = true;
                txtNacionalidade.ReadOnly = true;
                cbxEstadoCivil.Enabled = false;
                txtCateiraTrab.ReadOnly = true;
                dateExpedicaoCT.Enabled = false;
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
                cbxCargo.Enabled = false;
                cbxTipoContrato.Enabled = false;
                nudSalario.ReadOnly = true;
                nudDependentes.ReadOnly = true;
                ckbMatutino.Enabled = false;
                ckbVespertino.Enabled = false;
                ckbNoturno.Enabled = false;
                mskHorasDiarias.ReadOnly = true;

                if (comando.Equals("Visualizar"))
                {
                    this.Text = "SGCM - Funcionário " + funcionario.Codigo;
                    btnCancelar.Text = "OK";
                    btnCadastrar.Visible = false;
                }
                else if (comando.Equals("Deletar"))
                {
                    this.Text = "SGCM - Deletar Funcionário " + funcionario.Codigo;
                    btnCadastrar.Text = "Deletar";                    
                    comando2 = comando;
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ofdFoto.InitialDirectory = Application.StartupPath + @"\";

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image imagem = Image.FromFile(ofdFoto.FileName);
                    picbxFuncionario.Image = imagem;
                    diretorioImagem = ofdFoto.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na operação", ex.Message);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja apagar imagem?", "Limpar Imagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                picbxFuncionario.Image = picbxFuncionario.InitialImage;
                diretorioImagem = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (comando2.Equals("Deletar"))
            {
                if (funcionarioDAL.Selecionar().ElementAt(0).Codigo == codigo)
                {
                    MessageBox.Show("Este Funcionário Administrador Pai e não pode ser deletado", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("Tem certeza que deseja deletar este funcionário?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcionarioDAL.Deletar(codigo);
                        MessageBox.Show("Funcionário deletado com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                Funcionario funcionario = new Funcionario();
                string turno = "";
                funcionario.Complemento = txtComplemento.Text;
                funcionario.CEP = mskCEP.Text;
                funcionario.Celular = mskCelular.Text;
                funcionario.Telefone = mskTelefone.Text;
                funcionario.Email = txtEmail.Text;
                funcionario.Site = txtSite.Text;
                funcionario.Facebook = txtFaceBook.Text;
                funcionario.Imagem = diretorioImagem;
                try
                {
                    funcionario.Nome = txtNome.Text;
                    funcionario.Endereco = txtEndereco.Text;
                    funcionario.Numero = Convert.ToInt32(txtNumResidencia.Text);
                    funcionario.Bairro = txtBairro.Text;
                    funcionario.Cidade = txtCidade.Text;
                    funcionario.UF = cbxUF.Text;
                    funcionario.Estado_Civil = cbxEstadoCivil.Text;
                    funcionario.Carteira_Trabalho = txtCateiraTrab.Text;
                    funcionario.Expedicao_CT = Convert.ToDateTime(dateExpedicaoCT.Text);
                    funcionario.Nacionalidade = txtNacionalidade.Text;
                    funcionario.Cargo = cbxCargo.Text;

                    if (ckbMatutino.Checked && !ckbVespertino.Checked && !ckbNoturno.Checked)
                    {
                        turno = "Matutino";
                        funcionario.Turno = turno;
                    }
                    if (!ckbMatutino.Checked && ckbVespertino.Checked && !ckbNoturno.Checked)
                    {
                        turno = "Vespertino";
                        funcionario.Turno = turno;
                    }
                    if (!ckbMatutino.Checked && !ckbVespertino.Checked && ckbNoturno.Checked)
                    {
                        turno = "Noturno";
                        funcionario.Turno = turno;
                    }
                    if (ckbMatutino.Checked && ckbVespertino.Checked && !ckbNoturno.Checked)
                    {
                        turno = "Matutino/Vespertino";
                        funcionario.Turno = turno;
                    }
                    if (ckbMatutino.Checked && !ckbVespertino.Checked && ckbNoturno.Checked)
                    {
                        turno = "Matutino/Noturno";
                        funcionario.Turno = turno;
                    }
                    if (!ckbMatutino.Checked && ckbVespertino.Checked && ckbNoturno.Checked)
                    {
                        turno = "Vespertino/Noturno";
                        funcionario.Turno = turno;
                    }
                    if (ckbMatutino.Checked && ckbVespertino.Checked && ckbNoturno.Checked)
                    {
                        turno = "Matutino/Vespertino/Noturno";
                        funcionario.Turno = turno;
                    }

                    funcionario.Salario = nudSalario.Text;
                    funcionario.Dependentes = Convert.ToInt32(nudDependentes.Value);
                    funcionario.Horas_Diarias = mskHorasDiarias.Text;
                    funcionario.Tipo_Contrato = cbxTipoContrato.Text;

                    if (!ckbMatutino.Checked && !ckbVespertino.Checked && !ckbNoturno.Checked)
                    {
                        erroTurno.SetError(gbxTurno, "Marque pelo menos uma das opções abaixo!");
                    }
                    else
                    {
                        erroTurno.SetError(gbxTurno, "");
                    }

                    if (rbtFeminino.Checked)
                    {
                        funcionario.Sexo = "Feminino";
                    }
                    else if (rbtMasculino.Checked)
                    {
                        funcionario.Sexo = "Masculino";
                    }

                    funcionario.Nascimento = Convert.ToDateTime(dateNasc.Text);
                    funcionario.RG = mskRG.Text;
                    funcionario.CPF = mskCPF.Text;
                    funcionario.Imagem = diretorioImagem;

                    if (comando2.Equals("Cadastrar"))
                    {
                        funcionarioDAL.Inserir(funcionario);
                        MessageBox.Show("Funcionário cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cbxEstadoCivil.Text = "<selecionar>";
                        txtCateiraTrab.Text = "";
                        txtNacionalidade.Text = "";
                        cbxCargo.Text = "<selecionar>";
                        cbxTipoContrato.Text = "<selecionar>";
                        nudSalario.Value = 0;
                        mskHorasDiarias.Text = "";
                        nudDependentes.Value = 0;
                    }
                    else if (comando2.Equals("Alterar"))
                    {
                        funcionarioDAL.Alterar(funcionario, codigo);
                        MessageBox.Show("Funcionário alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            picbxFuncionario.Image = Image.FromFile(diretorioImagem);
        }
    }
}

