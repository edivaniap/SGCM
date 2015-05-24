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
    public partial class frmCadastroServico : Form
    {
        ServicoDAL servicoDAL;
        int codigo;
        string comando2;

        public frmCadastroServico()
        {
            InitializeComponent();
            servicoDAL = new ServicoDAL();
            comando2 = "Cadastrar";
        }

        public frmCadastroServico(Servico servico, string comando)
        {
            InitializeComponent();
            servicoDAL = new ServicoDAL();
            this.Text = "SGCM - Alterar Serviço " + servico.Codigo;
            btnCadastrar.Text = "Alterar";
            rtxtDescricao.Text = servico.Descricao;
            txtTipo.Text = servico.Tipo;            
            comando2 = comando;
            codigo = servico.Codigo;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Servico servico = new Servico();

                servico.Tipo = txtTipo.Text;
                servico.Descricao = rtxtDescricao.Text;

                if (comando2.Equals("Cadastrar"))
                {
                    servicoDAL.Inserir(servico);
                    MessageBox.Show("Serviço cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    txtTipo.Text = "";
                    rtxtDescricao.Text = "";
                }
                else if (comando2.Equals("Alterar"))
                {
                    servicoDAL.Alterar(servico, codigo);
                    MessageBox.Show("Serviço alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
