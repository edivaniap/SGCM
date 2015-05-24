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
    public partial class frmConsultaVendas : Form
    {
        VendaDAL vendaDAL;
        Venda venda;

        public frmConsultaVendas()
        {
            InitializeComponent();
            vendaDAL = new VendaDAL();
            cbxFiltro.SelectedIndex = 4;
        }

        private void frmConsultaVendas_Load(object sender, EventArgs e)
        {
            dgvVendas.DataSource = null;
            dgvVendas.DataSource = vendaDAL.Selecionar();
            lbRegistros.Text = vendaDAL.Selecionar().Count.ToString();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar esta Venda?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vendaDAL.Deletar(venda.CodVenda);
                MessageBox.Show("Venda deletada com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvVendas.DataSource = null;
                dgvVendas.DataSource = vendaDAL.Selecionar();
                lbRegistros.Text = vendaDAL.Selecionar().Count.ToString();
            }
        }

        private void dgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvVendas.SelectedRows.Count >= 0)
                {
                    venda = new Venda();
                    venda.CodVenda = Convert.ToInt32(dgvVendas.Rows[e.RowIndex].Cells["CodVenda"].Value.ToString());
                    venda.CodServico = Convert.ToInt32(dgvVendas.Rows[e.RowIndex].Cells["CodServico"].Value.ToString());
                    venda.CodCliente = Convert.ToInt32(dgvVendas.Rows[e.RowIndex].Cells["CodCliente"].Value.ToString());
                    venda.CodEmpresa = Convert.ToInt32(dgvVendas.Rows[e.RowIndex].Cells["CodEmpresa"].Value.ToString());
                    venda.CodFuncionario = Convert.ToInt32(dgvVendas.Rows[e.RowIndex].Cells["CodFuncionario"].Value.ToString());
                    venda.DataHora = dgvVendas.Rows[e.RowIndex].Cells["DataHora"].Value.ToString();
                    venda.ValorVenda = dgvVendas.Rows[e.RowIndex].Cells["ValorVenda"].Value.ToString();

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

        private void btnProdVendidos_Click(object sender, EventArgs e)
        {
            frmConsultarProdVendidos consultarProdVend = new frmConsultarProdVendidos();
            consultarProdVend.Show();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvVendas.DataSource = null;
            dgvVendas.DataSource = vendaDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);
            lbRegistros.Text = vendaDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();
        }

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvVendas.DataSource = null;
            dgvVendas.DataSource = vendaDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);
            lbRegistros.Text = vendaDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();
        }
    }
}
