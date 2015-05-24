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

namespace appSGCM.UI
{
    public partial class frmConsultaFornecedores : Form
    {
        FornecedorDAL fornecedorDAL;
        Fornecedor fornecedor;

        public frmConsultaFornecedores()
        {
            InitializeComponent();
            fornecedorDAL = new FornecedorDAL();
            cbxFiltro.SelectedIndex = 1;
        }

        private void frmConsultaFornecedores_Load(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = fornecedorDAL.Selecionar();
            lbRegistros.Text = fornecedorDAL.Selecionar().Count.ToString();
            dgvFornecedores.Columns["Codigo"].DisplayIndex = 0;
            dgvFornecedores.Columns["Nome"].DisplayIndex = 1;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor cadastrarFornecedor = new frmCadastroFornecedor();
            if (cadastrarFornecedor.ShowDialog() == DialogResult.OK)
            {
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = fornecedorDAL.Selecionar();
                lbRegistros.Text = fornecedorDAL.Selecionar().Count.ToString();
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor visualizarFornecedor = new frmCadastroFornecedor(fornecedor, "Visualizar");
            visualizarFornecedor.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor alterarFornecedor = new frmCadastroFornecedor(fornecedor, "Alterar");
            if (alterarFornecedor.ShowDialog() == DialogResult.OK)
            {
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = fornecedorDAL.Selecionar();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor deletarFornecedor = new frmCadastroFornecedor(fornecedor, "Deletar");
            if (deletarFornecedor.ShowDialog() == DialogResult.OK)
            {
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = fornecedorDAL.Selecionar();
                lbRegistros.Text = fornecedorDAL.Selecionar().Count.ToString();
            }
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFornecedores.SelectedRows.Count >= 0)
                {
                    fornecedor = new Fornecedor();
                    fornecedor.Codigo = Convert.ToInt32(dgvFornecedores.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    fornecedor.Nome = dgvFornecedores.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                    fornecedor.Endereco = dgvFornecedores.Rows[e.RowIndex].Cells["Endereco"].Value.ToString();
                    fornecedor.Numero = Convert.ToInt32(dgvFornecedores.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
                    fornecedor.Complemento = dgvFornecedores.Rows[e.RowIndex].Cells["Complemento"].Value.ToString();
                    fornecedor.Bairro = dgvFornecedores.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
                    fornecedor.Cidade = dgvFornecedores.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
                    fornecedor.UF = dgvFornecedores.Rows[e.RowIndex].Cells["UF"].Value.ToString();
                    fornecedor.CEP = dgvFornecedores.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
                    fornecedor.Celular = dgvFornecedores.Rows[e.RowIndex].Cells["Celular"].Value.ToString();
                    fornecedor.Telefone = dgvFornecedores.Rows[e.RowIndex].Cells["Telefone"].Value.ToString(); ;
                    fornecedor.Email = dgvFornecedores.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    fornecedor.Site = dgvFornecedores.Rows[e.RowIndex].Cells["Site"].Value.ToString();
                    fornecedor.Facebook = dgvFornecedores.Rows[e.RowIndex].Cells["Facebook"].Value.ToString();
                    fornecedor.CNPJ = dgvFornecedores.Rows[e.RowIndex].Cells["CNPJ"].Value.ToString();

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCampoFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = fornecedorDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);

            lbRegistros.Text = fornecedorDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();

            dgvFornecedores.Columns["Codigo"].DisplayIndex = 0;
            dgvFornecedores.Columns["Nome"].DisplayIndex = 1;
        }
        
        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = fornecedorDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);
          
            lbRegistros.Text = fornecedorDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();

            dgvFornecedores.Columns["Codigo"].DisplayIndex = 0;
            dgvFornecedores.Columns["Nome"].DisplayIndex = 1;
        }
    }
}