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
    public partial class frmConsultaProdutos : Form
    {
        ProdutoDAL produtoDAL;
        Produto produto;

        public frmConsultaProdutos()
        {
            InitializeComponent();
            produtoDAL = new ProdutoDAL();
            cbxFiltro.SelectedIndex = 1;
        }

        public frmConsultaProdutos(string comando)
        {
            InitializeComponent();
            produtoDAL = new ProdutoDAL();
            cbxFiltro.SelectedIndex = 1;
            btnAdicionar.Visible = true;
            btnAdicionar.Enabled = false;
            btnInserir.Visible = false;
            btnAlterar.Visible = false;
            btnDeletar.Visible = false;
        }

        private void frmConsultaProdutos_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtoDAL.Selecionar();
            lbRegistros.Text = produtoDAL.Selecionar().Count.ToString();
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            frmCadastroProduto cadastroProdutos = new frmCadastroProduto();
            if (cadastroProdutos.ShowDialog() == DialogResult.OK)
            {
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = produtoDAL.Selecionar();
                lbRegistros.Text = produtoDAL.Selecionar().Count.ToString();
            }   
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmCadastroProduto visualizarProdutos = new frmCadastroProduto(produto, "Visualizar");
            visualizarProdutos.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadastroProduto alterarProdutos = new frmCadastroProduto(produto, "Alterar");
            if (alterarProdutos.ShowDialog() == DialogResult.OK)
            {
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = produtoDAL.Selecionar();
            }   
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmCadastroProduto deletarProdutos = new frmCadastroProduto(produto, "Deletar");
            if (deletarProdutos.ShowDialog() == DialogResult.OK)
            {
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = produtoDAL.Selecionar();
                lbRegistros.Text = produtoDAL.Selecionar().Count.ToString();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProdutos.SelectedRows.Count >= 0)
                {
                    produto = new Produto();
                    produto.Codigo = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    produto.Nome = dgvProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                    produto.Codigo_Barras = Convert.ToDecimal(dgvProdutos.Rows[e.RowIndex].Cells["Codigo_Barras"].Value.ToString());
                    produto.Descricao = dgvProdutos.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                    produto.Tipo = dgvProdutos.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                    produto.Preco_Compra = (dgvProdutos.Rows[e.RowIndex].Cells["Preco_Compra"].Value.ToString());
                    produto.Preco_Venda = (dgvProdutos.Rows[e.RowIndex].Cells["Preco_Venda"].Value.ToString());
                    produto.Quantidade = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString());
                    produto.Fornecedor = dgvProdutos.Rows[e.RowIndex].Cells["Fornecedor"].Value.ToString();
                    produto.Imagem = dgvProdutos.Rows[e.RowIndex].Cells["Imagem"].Value.ToString();

                    btnAdicionar.Enabled = true;
                    btnVisualizar.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnDeletar.Enabled = true;
                }
                else
                {
                    btnAdicionar.Enabled = false;
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

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtoDAL.Filtrar(cbxFiltro.Text, txtCampoFiltro.Text);
            lbRegistros.Text = produtoDAL.Filtrar(cbxFiltro.Text, txtCampoFiltro.Text).Count.ToString();
        }

        private void txtCampoFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtoDAL.Filtrar(cbxFiltro.Text, txtCampoFiltro.Text);
            lbRegistros.Text = produtoDAL.Filtrar(cbxFiltro.Text, txtCampoFiltro.Text).Count.ToString();
        }

        public decimal CodigoBarrasProdutoSelecionado()
        {
            return produto.Codigo_Barras;
        }

        public int CodigoProdutoSelecionado()
        {
            return produto.Codigo;
        }

        public int QTDProdutoSelecionado()
        {
            return produto.Quantidade;
        }

        public string DescricaoProdutoSelecionado()
        {
            return produto.Descricao;
        }

        public string PrecoUNDProdutoSelecionado()
        {
            return produto.Preco_Venda;
        }
    }
}
