using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appSGCM.CORE.DAL;
using appSGCM.CORE.Model;
using System.Data.SqlClient;

namespace appSGCM.UI
{
    public partial class frmConsultaFuncionarios : Form
    {
        FuncionarioDAL funcionarioDAL;
        Funcionario funcionario;

        public frmConsultaFuncionarios()
        {
            InitializeComponent();
            funcionarioDAL = new FuncionarioDAL();
            cbxFiltro.SelectedIndex = 1;
        }

        private void frmConsultaFuncionários_Load(object sender, EventArgs e)
        { 
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = funcionarioDAL.Selecionar();

            lbRegistros.Text = funcionarioDAL.Selecionar().Count.ToString();

                //ORGANIZAR COLUNAS
            dgvFuncionarios.Columns["Codigo"].DisplayIndex = 0;
            dgvFuncionarios.Columns["Nome"].DisplayIndex = 1;
            dgvFuncionarios.Columns["Nascimento"].DisplayIndex = 2;
            dgvFuncionarios.Columns["Sexo"].DisplayIndex = 3;
            dgvFuncionarios.Columns["CPF"].DisplayIndex = 4;
            dgvFuncionarios.Columns["Carteira_Trabalho"].DisplayIndex = 5;
            dgvFuncionarios.Columns["Cargo"].DisplayIndex = 6;
            dgvFuncionarios.Columns["Turno"].DisplayIndex = 7;
            dgvFuncionarios.Columns["Tipo_Contrato"].DisplayIndex = 8;
            dgvFuncionarios.Columns["Salario"].DisplayIndex = 9;
            dgvFuncionarios.Columns["Celular"].DisplayIndex = 10;
            dgvFuncionarios.Columns["Email"].DisplayIndex = 11;
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFuncionarios.SelectedRows.Count >= 0)
                {
                    funcionario = new Funcionario();
                    funcionario.Codigo = Convert.ToInt32(dgvFuncionarios.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    funcionario.Nome = dgvFuncionarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                    funcionario.Endereco = dgvFuncionarios.Rows[e.RowIndex].Cells["Endereco"].Value.ToString();
                    funcionario.Numero = Convert.ToInt32(dgvFuncionarios.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
                    funcionario.Complemento = dgvFuncionarios.Rows[e.RowIndex].Cells["Complemento"].Value.ToString();
                    funcionario.Bairro = dgvFuncionarios.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
                    funcionario.Cidade = dgvFuncionarios.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
                    funcionario.UF = dgvFuncionarios.Rows[e.RowIndex].Cells["UF"].Value.ToString();
                    funcionario.CEP = dgvFuncionarios.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
                    funcionario.Celular = dgvFuncionarios.Rows[e.RowIndex].Cells["Celular"].Value.ToString();
                    funcionario.Telefone = dgvFuncionarios.Rows[e.RowIndex].Cells["Telefone"].Value.ToString(); ;
                    funcionario.Email = dgvFuncionarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    funcionario.Site = dgvFuncionarios.Rows[e.RowIndex].Cells["Site"].Value.ToString();
                    funcionario.Facebook = dgvFuncionarios.Rows[e.RowIndex].Cells["Facebook"].Value.ToString();
                    funcionario.Sexo = dgvFuncionarios.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                    funcionario.Nascimento = Convert.ToDateTime(dgvFuncionarios.Rows[e.RowIndex].Cells["Nascimento"].Value.ToString());
                    funcionario.RG = dgvFuncionarios.Rows[e.RowIndex].Cells["RG"].Value.ToString();
                    funcionario.CPF = dgvFuncionarios.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                    funcionario.Estado_Civil = dgvFuncionarios.Rows[e.RowIndex].Cells["Estado_Civil"].Value.ToString();
                    funcionario.Carteira_Trabalho = dgvFuncionarios.Rows[e.RowIndex].Cells["Carteira_Trabalho"].Value.ToString();
                    funcionario.Expedicao_CT = Convert.ToDateTime(dgvFuncionarios.Rows[e.RowIndex].Cells["Expedicao_CT"].Value.ToString());
                    funcionario.Nacionalidade = dgvFuncionarios.Rows[e.RowIndex].Cells["Nacionalidade"].Value.ToString();
                    funcionario.Cargo = dgvFuncionarios.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
                    funcionario.Turno = dgvFuncionarios.Rows[e.RowIndex].Cells["Turno"].Value.ToString();
                    funcionario.Salario = dgvFuncionarios.Rows[e.RowIndex].Cells["Salario"].Value.ToString();
                    funcionario.Dependentes = Convert.ToInt32(dgvFuncionarios.Rows[e.RowIndex].Cells["Dependentes"].Value.ToString());
                    funcionario.Horas_Diarias = dgvFuncionarios.Rows[e.RowIndex].Cells["Horas_Diarias"].Value.ToString();
                    funcionario.Tipo_Contrato = dgvFuncionarios.Rows[e.RowIndex].Cells["Tipo_Contrato"].Value.ToString();
                    funcionario.Imagem = dgvFuncionarios.Rows[e.RowIndex].Cells["Imagem"].Value.ToString();

                    btnVisualizar.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnDeletar.Enabled = true;
                }
                else
                {
                    btnVisualizar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnDeletar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Row Index", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario cadastroFuncionario = new frmCadastroFuncionario();
            if (cadastroFuncionario.ShowDialog() == DialogResult.OK)
            {
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = funcionarioDAL.Selecionar();
                lbRegistros.Text = funcionarioDAL.Selecionar().Count.ToString();
            }     
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario visualizarFuncionario = new frmCadastroFuncionario(funcionario, "Visualizar");
            visualizarFuncionario.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario alterarFuncionario = new frmCadastroFuncionario(funcionario, "Alterar");
            if (alterarFuncionario.ShowDialog() == DialogResult.OK)
            {
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = funcionarioDAL.Selecionar();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario deletarFuncionario = new frmCadastroFuncionario(funcionario, "Deletar");
            if (deletarFuncionario.ShowDialog() == DialogResult.OK)
            {
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = funcionarioDAL.Selecionar();
                lbRegistros.Text = funcionarioDAL.Selecionar().Count.ToString();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = funcionarioDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);

            lbRegistros.Text = funcionarioDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();

            dgvFuncionarios.Columns["Codigo"].DisplayIndex = 0;
            dgvFuncionarios.Columns["Nome"].DisplayIndex = 1;
            dgvFuncionarios.Columns["Nascimento"].DisplayIndex = 2;
            dgvFuncionarios.Columns["Sexo"].DisplayIndex = 3;
            dgvFuncionarios.Columns["CPF"].DisplayIndex = 4;
            dgvFuncionarios.Columns["Carteira_Trabalho"].DisplayIndex = 5;
            dgvFuncionarios.Columns["Cargo"].DisplayIndex = 6;
            dgvFuncionarios.Columns["Turno"].DisplayIndex = 7;
            dgvFuncionarios.Columns["Tipo_Contrato"].DisplayIndex = 8;
            dgvFuncionarios.Columns["Salario"].DisplayIndex = 9;
            dgvFuncionarios.Columns["Celular"].DisplayIndex = 10;
            dgvFuncionarios.Columns["Email"].DisplayIndex = 11;
        }

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = funcionarioDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);

            lbRegistros.Text = funcionarioDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();

            dgvFuncionarios.Columns["Codigo"].DisplayIndex = 0;
            dgvFuncionarios.Columns["Nome"].DisplayIndex = 1;
            dgvFuncionarios.Columns["Nascimento"].DisplayIndex = 2;
            dgvFuncionarios.Columns["Sexo"].DisplayIndex = 3;
            dgvFuncionarios.Columns["CPF"].DisplayIndex = 4;
            dgvFuncionarios.Columns["Carteira_Trabalho"].DisplayIndex = 5;
            dgvFuncionarios.Columns["Cargo"].DisplayIndex = 6;
            dgvFuncionarios.Columns["Turno"].DisplayIndex = 7;
            dgvFuncionarios.Columns["Tipo_Contrato"].DisplayIndex = 8;
            dgvFuncionarios.Columns["Salario"].DisplayIndex = 9;
            dgvFuncionarios.Columns["Celular"].DisplayIndex = 10;
            dgvFuncionarios.Columns["Email"].DisplayIndex = 11;
        }
    }
}
