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
    public partial class frmConsultaServicos : Form
    {
        ServicoDAL servicoDAL;
        Servico servico;

        public frmConsultaServicos()
        {
            InitializeComponent();
            servicoDAL = new ServicoDAL();
            cbxFiltro.SelectedIndex = 1;
        }

        private void frmConsultaServicos_Load(object sender, EventArgs e)
        {
            dgvServicos.DataSource = null;
            dgvServicos.DataSource = servicoDAL.Selecionar();
            lbRegistros.Text = servicoDAL.Selecionar().Count.ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmCadastroServico cadastroServico = new frmCadastroServico();
            if (cadastroServico.ShowDialog() == DialogResult.OK)
            {
                dgvServicos.DataSource = null;
                dgvServicos.DataSource = servicoDAL.Selecionar();
                lbRegistros.Text = servicoDAL.Selecionar().Count.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadastroServico alterarUsuario = new frmCadastroServico(servico, "Alterar");
            if (alterarUsuario.ShowDialog() == DialogResult.OK)
            {
                dgvServicos.DataSource = null;
                dgvServicos.DataSource = servicoDAL.Selecionar();
            } 
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (servicoDAL.Selecionar().ElementAt(0).Codigo == servico.Codigo)
            {
                MessageBox.Show("Este Serviço é padrão e não pode ser deletado", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Serviço: " + servico.Tipo + Environment.NewLine + "Tem certeza que deseja deletar este Serviço?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    servicoDAL.Deletar(servico.Codigo);
                    MessageBox.Show("Serviço deletado com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvServicos.DataSource = null;
                    dgvServicos.DataSource = servicoDAL.Selecionar();
                    lbRegistros.Text = servicoDAL.Selecionar().Count.ToString();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvServicos.SelectedRows.Count >= 0)
                {
                    servico = new Servico();
                    servico.Codigo = Convert.ToInt32(dgvServicos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    servico.Tipo = dgvServicos.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                    servico.Descricao = dgvServicos.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();

                    btnAlterar.Enabled = true;
                    btnDeletar.Enabled = true;
                }
                else
                {
                    btnAlterar.Enabled = false;
                    btnDeletar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Row Index", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvServicos.DataSource = null;
            dgvServicos.DataSource = servicoDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);
            lbRegistros.Text = servicoDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();
        }

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvServicos.DataSource = null;
            dgvServicos.DataSource = servicoDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);
            lbRegistros.Text = servicoDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();
        }
    }
}
