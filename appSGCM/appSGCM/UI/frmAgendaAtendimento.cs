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
    public partial class frmAgendaAtendimento : Form
    {
        Agendamento agendamento;
        ServicoDAL servicoDAL;
        ClienteDAL clienteDAL;
        AgendamentoDAL agendamentoDAL;
        int codigo;
        int codCliente;
        int codServico;
        int codFunc2;
        public frmAgendaAtendimento(int codFunc)
        {
            InitializeComponent();
            servicoDAL = new ServicoDAL();
            clienteDAL = new ClienteDAL();
            agendamentoDAL = new AgendamentoDAL();
            cbxFiltro.SelectedIndex = 3;
            codFunc2 = codFunc;
            dgvAtendimentos.ForeColor = Color.Black;
            
            for (int i = 0; i < servicoDAL.Selecionar().Count(); i++)
            {
                if(i != 0)
                    cbxServico.Items.Add(servicoDAL.Selecionar().ElementAt(i).Tipo);
            }
        }

        private void frmAgendaAtendimento_Load(object sender, EventArgs e)
        {

            int contPendendes = 0;

            for (int i = 0; i < agendamentoDAL.Selecionar().Count(); i++)
            {
                if (agendamentoDAL.Selecionar().ElementAt(i).Status == "Ativo")
                {
                    if (agendamentoDAL.Selecionar().ElementAt(i).Data < DateTime.Now && Convert.ToDateTime(agendamentoDAL.Selecionar().ElementAt(i).Horario) < DateTime.Now)
                    {
                        agendamentoDAL.AlterarStatus(agendamentoDAL.Selecionar().ElementAt(i).Codigo);
                        contPendendes++;                        
                    }
                }
            }

            if (contPendendes > 0)
            {
                MessageBox.Show(contPendendes + " Novo(s) agendamento(s) pendente(s)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            ContagemStatus();
            dgvAtendimentos.DataSource = null;
            dgvAtendimentos.DataSource = agendamentoDAL.Selecionar();
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            frmCadastroServico cadastroServico = new frmCadastroServico();
            if (cadastroServico.ShowDialog() == DialogResult.OK)
            {
                cbxServico.Items.Add(servicoDAL.Selecionar().Last().Tipo);             
            }
        }

        private void btnProcurarCliente_Click(object sender, EventArgs e)
        {
            frmConsultaClientes consultarClientes = new frmConsultaClientes("Agend");
            if (consultarClientes.ShowDialog() == DialogResult.OK)
            {
                txtCliente.Text = consultarClientes.NomeClienteSelecionado();
                codCliente = consultarClientes.CodigoClienteSelecionado();
            }

                      
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadastroCliente = new frmCadastroCliente();
            cadastroCliente.ShowDialog();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            
            try
            {
                if (txtCliente.Text == "Consumidor Final")
                {
                    MessageBox.Show("Este cliente é padrão e não pode agendar serviços", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (rbtAtivo.Checked)
                    {
                        agendamento.Status = "Ativo";
                    }
                    else if (rbtAntendido.Checked)
                    {
                        agendamento.Status = "Atendido";
                    }
                    else if (rbtPendente.Checked)
                    {
                        agendamento.Status = "Pendente";
                    }
                    else if (rbtCancelado.Checked)
                    {
                        agendamento.Status = "Cancelado";
                    }

                    //   if ((Convert.ToDateTime(mskHorario.Text) < DateTime.Now) && Convert.ToDateTime(dateTimeData.Text) <= DateTime.Now &&  agendamento.Status == "Ativo")
                    if (Convert.ToDateTime(dateTimeData.Text + " " + mskHorario.Text + ":00") <= DateTime.Now && agendamento.Status == "Ativo")
                    {
                        MessageBox.Show("Data e/ou Hora inseridos são inválidos" + Environment.NewLine + "Agende uma Data e Hora maior que a atual", "Data/Hora", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        agendamento.Cliente = txtCliente.Text;
                        agendamento.TipoServico = cbxServico.Text;
                        agendamento.Descricao = rtxtDescricaoServico.Text;
                        agendamento.Data = Convert.ToDateTime(dateTimeData.Text);
                        agendamento.Horario = mskHorario.Text;
                        agendamento.CodCliente = codCliente;
                        agendamento.CodServico = codServico;

                        if (rbtAtivo.Checked)
                        {
                            agendamento.Status = "Ativo";
                        }
                        else if (rbtAntendido.Checked)
                        {
                            agendamento.Status = "Atendido";
                        }
                        else if (rbtPendente.Checked)
                        {
                            agendamento.Status = "Pendente";
                        }
                        else if (rbtCancelado.Checked)
                        {
                            agendamento.Status = "Cancelado";
                        }

                        if (btnAgendar.Text == "Agendar")
                        {
                            agendamentoDAL.Inserir(agendamento);

                            MessageBox.Show("Agendamento realizado com sucesso", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtCliente.Text = "";
                            cbxServico.Text = "";
                            rtxtDescricaoServico.Text = "";
                            dateTimeData.Text = "";
                            mskHorario.Text = "";
                        }
                        else if (btnAgendar.Text == "Salvar")
                        {
                            agendamentoDAL.Alterar(agendamento, codigo);
                            MessageBox.Show("Agendamento alterado com sucesso", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnAgendar.Text = "Agendar";
                            btnAgendar.BackColor = Color.LimeGreen;

                            txtCliente.Text = "";
                            cbxServico.Text = "";
                            rtxtDescricaoServico.Text = "";
                            dateTimeData.Text = "";
                            mskHorario.Text = "";

                            rbtAtivo.Checked = true;
                            rbtAntendido.Enabled = false;
                            rbtPendente.Enabled = false;
                            rbtCancelado.Enabled = false;
                            dateTimeData.Enabled = true;
                            mskHorario.ReadOnly = false;
                            rtxtDescricaoServico.ReadOnly = false;
                            btnAgendar.Enabled = true;
                            txtCliente.Enabled = true;
                            cbxServico.Enabled = true;
                            btnAddCliente.Enabled = true;
                            btnAddServico.Enabled = true;
                            btnProcurarCliente.Enabled = true;
                        }

                        ContagemStatus();
                        dgvAtendimentos.DataSource = null;
                        dgvAtendimentos.DataSource = agendamentoDAL.Selecionar();
                    }
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

        private void cbxServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < servicoDAL.Selecionar().Count(); i++)
            {
                if (cbxServico.Text.Equals(servicoDAL.Selecionar().ElementAt(i).Tipo))
                {
                    codServico = servicoDAL.Selecionar().ElementAt(i).Codigo;
                    rtxtDescricaoServico.Text = servicoDAL.Selecionar().ElementAt(i).Descricao;
                    break;
                }
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (agendamento.Status == "Ativo" || agendamento.Status == "Pendente")
            {
                frmControleVendas caixa = new frmControleVendas(codFunc2, agendamento);
                if (caixa.ShowDialog() == DialogResult.OK)
                {
                    agendamento.Status = "Atendido";
                    agendamentoDAL.Alterar(agendamento, agendamento.Codigo);
                    dgvAtendimentos.DataSource = null;
                    dgvAtendimentos.DataSource = agendamentoDAL.Selecionar();
                    ContagemStatus();
                }
            }
            else
            {
                MessageBox.Show("Este serviço já foi atendido ou está cancelado", "Atendimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAgendar.Text = "Salvar";
            btnAgendar.BackColor = Color.DarkOrange;

            rbtAntendido.Enabled = true;
            rbtPendente.Enabled = true;
            rbtCancelado.Enabled = true;

            if (agendamento.Status == "Ativo")
            {
                rbtAtivo.Checked = true;
            }
            else if (agendamento.Status == "Atendido")
            {
                rbtAntendido.Checked = true;
                gbxStatus.Enabled = false;
            }
            else if (agendamento.Status == "Pendente")
            {
                rbtPendente.Checked = true;
            }
            else if (agendamento.Status == "Cancelado")
            {
                rbtCancelado.Checked = true;
            }

            txtCliente.Text = agendamento.Cliente;
            codCliente = agendamento.CodCliente;

            foreach (object item in cbxServico.Items)
            {
                if (item.ToString() == agendamento.TipoServico)
                {
                    cbxServico.SelectedItem = item;
                    break;
                }
            }

            btnProcurarCliente.Enabled = false;
            btnAddCliente.Enabled = false;
            btnAddServico.Enabled = false;

            txtCliente.Enabled = false;
            cbxServico.Enabled = false;

            if (rbtAntendido.Checked || rbtPendente.Checked || rbtCancelado.Checked)
            {
                dateTimeData.Enabled = false;
                mskHorario.ReadOnly = true;
                rtxtDescricaoServico.ReadOnly = true;
            }

            rtxtDescricaoServico.Text = agendamento.Descricao;
            dateTimeData.Value = agendamento.Data;
            mskHorario.Text = agendamento.Horario;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cliente: " + agendamento.CodCliente + " - " + agendamento.Cliente + Environment.NewLine +
                "Serviço: " + agendamento.CodServico + " - " + agendamento.TipoServico + Environment.NewLine + "Tem certeza que deseja deletar agendamento?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agendamentoDAL.Deletar(agendamento.Codigo);
                MessageBox.Show("Agendamento deletado com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ContagemStatus();
                dgvAtendimentos.DataSource = null;
                dgvAtendimentos.DataSource = agendamentoDAL.Selecionar();
            }
        }

        private void ContagemStatus() 
        {
            int contAtivos = 0;
            int contAtendidos = 0;
            int contPendentes = 0;
            int contCancelados = 0;
            int contTotal = 0;
            for (int i = 0; i < agendamentoDAL.Selecionar().Count(); i++)
            {
                if (agendamentoDAL.Selecionar().ElementAt(i).Status == "Ativo")
                {
                    contAtivos++;
                }
                if (agendamentoDAL.Selecionar().ElementAt(i).Status == "Atendido")
                {
                    contAtendidos++;
                }
                if (agendamentoDAL.Selecionar().ElementAt(i).Status == "Pendente")
                {
                    contPendentes++;
                }
                if (agendamentoDAL.Selecionar().ElementAt(i).Status == "Cancelado")
                {
                    contCancelados++;
                }
            }

            contTotal = agendamentoDAL.Selecionar().Count;
            lbNumTotal.Text = contTotal.ToString();
            lbNumAtivos.Text = contAtivos.ToString();
            lbNumAtendidos.Text = contAtendidos.ToString();
            lbNumPendentes.Text = contPendentes.ToString();
            lbNumCancelados.Text = contCancelados.ToString();
        }

        private void dgvAtendimentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAtendimentos.SelectedRows.Count >= 0)
                {
                    agendamento = new Agendamento();

                    codigo = Convert.ToInt32(dgvAtendimentos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    agendamento.Codigo = Convert.ToInt32(dgvAtendimentos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    agendamento.CodServico = Convert.ToInt32(dgvAtendimentos.Rows[e.RowIndex].Cells["CodServico"].Value.ToString());
                    agendamento.CodCliente = Convert.ToInt32(dgvAtendimentos.Rows[e.RowIndex].Cells["CodCliente"].Value.ToString());
                    agendamento.Cliente = dgvAtendimentos.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                    agendamento.TipoServico = dgvAtendimentos.Rows[e.RowIndex].Cells["TipoServico"].Value.ToString();
                    agendamento.Descricao = dgvAtendimentos.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                    agendamento.Data = Convert.ToDateTime(dgvAtendimentos.Rows[e.RowIndex].Cells["Data"].Value.ToString());
                    agendamento.Horario = dgvAtendimentos.Rows[e.RowIndex].Cells["Horario"].Value.ToString();
                    agendamento.Status = dgvAtendimentos.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                    btnAtender.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnDeletar.Enabled = true;
                }
                else
                {
                    btnAtender.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnDeletar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Row Index", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtAtivo_Click(object sender, EventArgs e)
        {
            dateTimeData.Enabled = true;
            mskHorario.ReadOnly = false;
            rtxtDescricaoServico.ReadOnly = false;
            btnAgendar.Enabled = true;

        }

        private void rbtAntendido_Click(object sender, EventArgs e)
        {
            dateTimeData.Enabled = false;
            mskHorario.ReadOnly = true;
            rtxtDescricaoServico.ReadOnly = true;
            btnAgendar.Enabled = false;
        }

        private void rbtPendente_Click(object sender, EventArgs e)
        {
            dateTimeData.Enabled = false;
            mskHorario.ReadOnly = true;
            rtxtDescricaoServico.ReadOnly = true;
            btnAgendar.Enabled = false;
        }

        private void rbtCancelado_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeData.Enabled = false;
            mskHorario.ReadOnly = true;
            rtxtDescricaoServico.ReadOnly = true;
            btnAgendar.Enabled = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvAtendimentos.DataSource = null;
            dgvAtendimentos.DataSource = agendamentoDAL.Filtrar(cbxFiltro.Text, txtBuscar.Text);
        }

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvAtendimentos.DataSource = null;
            dgvAtendimentos.DataSource = agendamentoDAL.Filtrar(cbxFiltro.Text, txtBuscar.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAgendar.Text = "Agendar";
            btnAgendar.BackColor = Color.LimeGreen;

            txtCliente.Text = "";
            cbxServico.Text = "";
            rtxtDescricaoServico.Text = "";
            dateTimeData.Text = "";
            mskHorario.Text = "";

            gbxStatus.Enabled = true;

            rbtAtivo.Checked = true;
            rbtAntendido.Enabled = false;
            rbtPendente.Enabled = false;
            rbtCancelado.Enabled = false;
            dateTimeData.Enabled = true;
            mskHorario.ReadOnly = false;
            rtxtDescricaoServico.ReadOnly = false;
            btnAgendar.Enabled = true;
            txtCliente.Enabled = true;
            cbxServico.Enabled = true;
            btnAddCliente.Enabled = true;
            btnAddServico.Enabled = true;
            btnProcurarCliente.Enabled = true;
        }
    }
}
