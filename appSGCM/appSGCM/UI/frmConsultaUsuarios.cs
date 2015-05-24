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
    public partial class frmConsultaUsuarios : Form
    {
        UsuarioDAL usuarioDAL;
        Usuario usuario;

        public frmConsultaUsuarios()
        {
            InitializeComponent();
            usuarioDAL = new UsuarioDAL();
            cbxFiltro.SelectedIndex = 2;
        }

        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarioDAL.Selecionar();
            lbRegistros.Text = usuarioDAL.Selecionar().Count.ToString();
        } 

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastroUsuario = new frmCadastroUsuario();
            if (cadastroUsuario.ShowDialog() == DialogResult.OK)
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = usuarioDAL.Selecionar();
                lbRegistros.Text = usuarioDAL.Selecionar().Count.ToString();
            }
        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario alterarUsuario = new frmCadastroUsuario(usuario, "Alterar");
            if (alterarUsuario.ShowDialog() == DialogResult.OK)
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = usuarioDAL.Selecionar();
            }            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (usuario.Codigo == usuarioDAL.Selecionar().ElementAt(0).Codigo)
            {
                MessageBox.Show(usuario.Login + " é Usuario Administrador Pai e não pode ser deletado", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Usuário: " + usuario.Login + Environment.NewLine + "Tem certeza que deseja deletar este usuário?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuarioDAL.Deletar(usuario.Codigo);
                    MessageBox.Show("Usuário deletado com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataSource = usuarioDAL.Selecionar();
                    lbRegistros.Text = usuarioDAL.Selecionar().Count.ToString();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count >= 0)
                {
                    usuario = new Usuario();
                    usuario.Codigo = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    usuario.CodFuncionario = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["CodFuncionario"].Value.ToString());
                    usuario.Login = dgvUsuarios.Rows[e.RowIndex].Cells["Login"].Value.ToString();
                    usuario.Senha = dgvUsuarios.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
                    usuario.Tipo = dgvUsuarios.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();

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
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarioDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);
            lbRegistros.Text = usuarioDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();
        }

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarioDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text);
            lbRegistros.Text = usuarioDAL.Filtrar(cbxFiltro.Text, txtFiltro.Text).Count.ToString();
        }       
    }
}
