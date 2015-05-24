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
    public partial class frmConsultarProdVendidos : Form
    {
        ProdutoVendidoDAL produtoVendidoDAL;
        ProdutoVendido produtoVendido;

        public frmConsultarProdVendidos()
        {
            InitializeComponent();
            produtoVendidoDAL = new ProdutoVendidoDAL();

            cbxFiltro.SelectedIndex = 1;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvProdutosVendidos.DataSource = null;
            dgvProdutosVendidos.DataSource = produtoVendidoDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);
            lbRegistros.Text = produtoVendidoDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();
        }

        private void frmConsultarProdVendidos_Load(object sender, EventArgs e)
        {
            dgvProdutosVendidos.DataSource = null;
            dgvProdutosVendidos.DataSource = produtoVendidoDAL.Selecionar();
            lbRegistros.Text = produtoVendidoDAL.Selecionar().Count.ToString();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar este registro de produto vendido?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produtoVendidoDAL.Deletar(produtoVendido.CodProdVendido);
                MessageBox.Show("Registro de produto deletado com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvProdutosVendidos.DataSource = null;
                dgvProdutosVendidos.DataSource = produtoVendidoDAL.Selecionar();
                lbRegistros.Text = produtoVendidoDAL.Selecionar().Count.ToString();
            }
        }

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvProdutosVendidos.DataSource = null;
            dgvProdutosVendidos.DataSource = produtoVendidoDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);
            lbRegistros.Text = produtoVendidoDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();
        }

        private void dgvProdutosVendidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProdutosVendidos.SelectedRows.Count >= 0)
                {
                    produtoVendido = new ProdutoVendido();
                    produtoVendido.CodProdVendido = Convert.ToInt32(dgvProdutosVendidos.Rows[e.RowIndex].Cells["CodProdVendido"].Value.ToString());
                    produtoVendido.CodProduto = Convert.ToInt32(dgvProdutosVendidos.Rows[e.RowIndex].Cells["CodProduto"].Value.ToString());
                    produtoVendido.CodVenda = Convert.ToInt32(dgvProdutosVendidos.Rows[e.RowIndex].Cells["CodVenda"].Value.ToString());
                    produtoVendido.Quantidade = Convert.ToInt32(dgvProdutosVendidos.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString());

                    btnDeletar.Enabled = true;
                }
                else
                {
                    btnDeletar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Row Index", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
