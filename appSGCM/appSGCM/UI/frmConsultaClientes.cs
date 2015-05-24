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
    public partial class frmConsultaClientes : Form
    {
        ClienteDAL clienteDAL;
        Cliente cliente;
        string comando;
        public frmConsultaClientes()
        {
            InitializeComponent();
            clienteDAL = new ClienteDAL();
            cbxFiltro.SelectedIndex = 1;
            comando = "";
        }

        public frmConsultaClientes(string x)
        {
            InitializeComponent();
            clienteDAL = new ClienteDAL();
            cbxFiltro.SelectedIndex = 1;
            btnAdicionar.Visible = true;
            btnInserir.Visible = false;
            btnVisualizar.Visible = false;
            btnAlterar.Visible = false;
            btnDeletar.Visible = false;            
            comando = x;
        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteDAL.Selecionar();
            lbRegistros.Text = clienteDAL.Selecionar().Count.ToString();            
            dgvClientes.Columns["Codigo"].DisplayIndex = 0;
            dgvClientes.Columns["Nome"].DisplayIndex = 1;
            dgvClientes.Columns["Nascimento"].DisplayIndex = 2;
            dgvClientes.Columns["Sexo"].DisplayIndex = 3;
            dgvClientes.Columns["CPF"].DisplayIndex = 4;
            dgvClientes.Columns["Celular"].DisplayIndex = 5;
            dgvClientes.Columns["Email"].DisplayIndex = 6;           
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count >= 0)
                {
                    cliente = new Cliente();
                    cliente.Codigo = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    cliente.Nome = dgvClientes.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                    cliente.Endereco = dgvClientes.Rows[e.RowIndex].Cells["Endereco"].Value.ToString();
                    cliente.Numero = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
                    cliente.Complemento = dgvClientes.Rows[e.RowIndex].Cells["Complemento"].Value.ToString();
                    cliente.Bairro = dgvClientes.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
                    cliente.Cidade = dgvClientes.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
                    cliente.UF = dgvClientes.Rows[e.RowIndex].Cells["UF"].Value.ToString();
                    cliente.CEP = dgvClientes.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
                    cliente.Celular = dgvClientes.Rows[e.RowIndex].Cells["Celular"].Value.ToString();
                    cliente.Telefone = dgvClientes.Rows[e.RowIndex].Cells["Telefone"].Value.ToString(); ;
                    cliente.Email = dgvClientes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    cliente.Site = dgvClientes.Rows[e.RowIndex].Cells["Site"].Value.ToString();
                    cliente.Facebook = dgvClientes.Rows[e.RowIndex].Cells["Facebook"].Value.ToString();
                    cliente.Sexo = dgvClientes.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                    cliente.Nascimento = Convert.ToDateTime(dgvClientes.Rows[e.RowIndex].Cells["Nascimento"].Value.ToString());
                    cliente.RG = dgvClientes.Rows[e.RowIndex].Cells["RG"].Value.ToString();
                    cliente.CPF = dgvClientes.Rows[e.RowIndex].Cells["CPF"].Value.ToString();

                    btnVisualizar.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnDeletar.Enabled = true;
                    btnAdicionar.Enabled = true;
                }
                else
                {
                    btnVisualizar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnDeletar.Enabled = false;
                    btnAdicionar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Row Index", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadastroCliente = new frmCadastroCliente();
            if (cadastroCliente.ShowDialog() == DialogResult.OK)
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clienteDAL.Selecionar();
                lbRegistros.Text = clienteDAL.Selecionar().Count.ToString();
            }     
        }


        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmCadastroCliente visualizarCliente = new frmCadastroCliente(cliente, "Visualizar");
            visualizarCliente.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadastroCliente alterarCliente = new frmCadastroCliente(cliente, "Alterar");
            if (alterarCliente.ShowDialog() == DialogResult.OK)
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clienteDAL.Selecionar();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmCadastroCliente deletarCliente = new frmCadastroCliente(cliente, "Deletar");
            if (deletarCliente.ShowDialog() == DialogResult.OK)
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clienteDAL.Selecionar();
                lbRegistros.Text = clienteDAL.Selecionar().Count.ToString();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string NomeClienteSelecionado()
        {
            return cliente.Nome;
        }

        public int CodigoClienteSelecionado()
        {
            return cliente.Codigo;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);

            lbRegistros.Text = clienteDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();

            dgvClientes.Columns["Codigo"].DisplayIndex = 0;
            dgvClientes.Columns["Nome"].DisplayIndex = 1;
            dgvClientes.Columns["Nascimento"].DisplayIndex = 2;
            dgvClientes.Columns["Sexo"].DisplayIndex = 3;
            dgvClientes.Columns["CPF"].DisplayIndex = 4;
            dgvClientes.Columns["Celular"].DisplayIndex = 5;
            dgvClientes.Columns["Email"].DisplayIndex = 6;
        }

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);

            lbRegistros.Text = clienteDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();

            dgvClientes.Columns["Codigo"].DisplayIndex = 0;
            dgvClientes.Columns["Nome"].DisplayIndex = 1;
            dgvClientes.Columns["Nascimento"].DisplayIndex = 2;
            dgvClientes.Columns["Sexo"].DisplayIndex = 3;
            dgvClientes.Columns["CPF"].DisplayIndex = 4;
            dgvClientes.Columns["Celular"].DisplayIndex = 5;
            dgvClientes.Columns["Email"].DisplayIndex = 6;
        }
    }
}
