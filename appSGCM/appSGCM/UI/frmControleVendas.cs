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
using System.Globalization;
using System.Media;
 
namespace appSGCM.UI
{
    public partial class frmControleVendas : Form
    {
        EmpresaDAL empresaDAL;
        FuncionarioDAL funcionarioDAL;
        VendaDAL vendaDAL;
        ProdutoVendidoDAL prodVDAL;
        ProdutoDAL produtoDAL;
        ServicoDAL servicoDAL;
        Servico servico;
        CultureInfo br;
        int codFuncionario;
        int codCliente;
        string nomeCliente;
        string nomeFuncionario;
        string cpfFuncionario;
        string dataHora;
        string dataHoraInicio;
        int numCupom;
        string comando;
        int qtdProd;
        int codProd;
        bool cliquei_finalizar;

        SoundPlayer beep = new SoundPlayer();

        List<ProdutoVendido> prodsVends;

        public frmControleVendas(int codFunc)
        {
            InitializeComponent();
            empresaDAL = new EmpresaDAL();
            funcionarioDAL = new FuncionarioDAL();
            vendaDAL = new VendaDAL();
            prodVDAL = new ProdutoVendidoDAL();
            produtoDAL = new ProdutoDAL();
            servicoDAL = new ServicoDAL();
            servico = new Servico();
            prodsVends = new List<ProdutoVendido>();
            br = new CultureInfo("pt-BR");
            codFuncionario = codFunc;
            dataHoraInicio = "";
            comando = "Venda";
            cliquei_finalizar = false;

            InicializeNota();

            for (int i = 0; i < servicoDAL.Selecionar().Count(); i++)
            {
                if (servicoDAL.Selecionar().ElementAt(i).Tipo.Equals("Venda"))
                {
                    servico.Codigo = servicoDAL.Selecionar().ElementAt(i).Codigo;
                    servico.Tipo = servicoDAL.Selecionar().ElementAt(i).Tipo;
                    servico.Descricao = servicoDAL.Selecionar().ElementAt(i).Descricao;
                }
            }

            txtTipoServico.Text = servico.Tipo;
        }

        public frmControleVendas(int codFunc, Agendamento agendamento)
        {
            InitializeComponent();
            empresaDAL = new EmpresaDAL();
            funcionarioDAL = new FuncionarioDAL();
            vendaDAL = new VendaDAL();
            servicoDAL = new ServicoDAL();
            servico = new Servico();
            prodsVends = new List<ProdutoVendido>();
            br = new CultureInfo("pt-BR");
            comando = "Agend";
            codFuncionario = codFunc;
            nomeCliente = agendamento.Cliente;
            codCliente = agendamento.CodCliente;
            dataHora = "";
            dataHoraInicio = agendamento.Data.ToShortDateString() + " " + agendamento.Horario + ":00";
           
            servico.Codigo = agendamento.CodServico;
            servico.Tipo = agendamento.TipoServico;
            servico.Descricao = agendamento.Descricao;

            rtxtDescricaoProduto.Text = agendamento.Descricao;
            txtTipoServico.Text = agendamento.TipoServico;
            gbxAddProd.Enabled = false;
            lbValorCompra.Text = "Valor Servico";
            txtTotalPagar.ReadOnly = false;
            btnNovoCliente.Enabled = false;
            btnProcurarCliente.Enabled = false;
            txtCliente.Text = nomeCliente;
            btnNovaVenda.Visible = false;
            InicializeNota();
        }

        int cont = 0;
        double valorTotal;
        double somaTotal;
        double totalPagar;
        double pagarComDesconto;
        double pagamento;
        double troco;

        private void InicializeNota()
        {
            try
            {
              //  if (dataHoraInicio == "")
               //     dataHoraInicio = DateTime.Now.ToString();

                numCupom = 0;
                if (vendaDAL.Selecionar().Count > 0)
                    numCupom = vendaDAL.Selecionar().Last().CodVenda + 1;
                else
                    numCupom = 1;

                rtxtNotaFiscal.Text = Environment.NewLine + empresaDAL.Selecionar().Nome.ToUpper() + Environment.NewLine;
                rtxtNotaFiscal.Text += empresaDAL.Selecionar().Endereco.ToUpper() + ", " + empresaDAL.Selecionar().Numero;
                rtxtNotaFiscal.Text += " - " + empresaDAL.Selecionar().Bairro.ToUpper() + Environment.NewLine;
                rtxtNotaFiscal.Text += empresaDAL.Selecionar().Cidade.ToUpper() + "/" + empresaDAL.Selecionar().UF + Environment.NewLine;
                rtxtNotaFiscal.Text += "CNPJ: " + empresaDAL.Selecionar().CNPJ + "    " + Environment.NewLine;
                rtxtNotaFiscal.Text += "----------------------------------------------------" + Environment.NewLine;
                rtxtNotaFiscal.Text += DateTime.Now.ToString() + "  " + ("CUPOM: " + numCupom.ToString().PadLeft(6, '0')).PadLeft(31, ' ') + Environment.NewLine;
                rtxtNotaFiscal.Text += "----------------------------------------------------" + Environment.NewLine;
                rtxtNotaFiscal.Text += "                   NOTA FISCAL                      " + Environment.NewLine;

                if (comando.Equals("Agend"))
                {
                    rtxtNotaFiscal.Text += " CÓDIGO   TIPO/ DESCRIÇÃO                   TOTAL R$" + Environment.NewLine;
                    rtxtNotaFiscal.Text += "----------------------------------------------------" + Environment.NewLine;                    
                }
                else if (comando.Equals("Venda"))
                {
                    rtxtNotaFiscal.Text += "ITEM     CÓDIGO         QTD       UND R$    TOTAL R$" + Environment.NewLine;
                    rtxtNotaFiscal.Text += "----------------------------------------------------" + Environment.NewLine;
                }            

                rtxtNotaFiscal.Select(1, rtxtNotaFiscal.Lines[1].Length + rtxtNotaFiscal.Lines[2].Length + rtxtNotaFiscal.Lines[3].Length + 2);
                rtxtNotaFiscal.SelectionAlignment = HorizontalAlignment.Center;
                rtxtNotaFiscal.SelectionFont = new Font("Courier New", 10.0f, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Catch Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherNota()
        {
            if(comando.Equals("Venda"))
            {
            cont++;
            txtValorTotal.Text = valorTotal.ToString("c", br);          
            rtxtNotaFiscal.Text += cont.ToString().PadLeft(3,'0') + "   " + txtCodProduto.Text.PadLeft(13,'0') + "    "
                + nudQtd.Value.ToString().PadLeft(4, ' ') + "     " + txtPrecoUnd.Text.Replace("R$", "").PadLeft(7, ' ') + " " 
                + txtValorTotal.Text.Replace("R$","").PadLeft(11, ' ');
            rtxtNotaFiscal.Text += Environment.NewLine;
            }
            else if (comando.Equals("Agend"))
            {
                rtxtNotaFiscal.Text += " " + servico.Codigo.ToString().PadLeft(6, '0') + "   " + (servico.Tipo + "/ " + servico.Descricao).Substring(0,30) +
                    "  " + somaTotal.ToString("c",br).Replace("R$","").PadLeft(10, ' '); 
            }
        }
       
        private void FinalizarNota()
        {
            try
            {
                rtxtNotaFiscal.Text += "====================================================" + Environment.NewLine;
                rtxtNotaFiscal.Text += "  DESCONTO(%)       " + nudDesconto.Value + Environment.NewLine;
                rtxtNotaFiscal.Text += "  TOTAL             " + txtPagarComDesconto.Text + Environment.NewLine;
                rtxtNotaFiscal.Text += "  Dinheiro          " + txtPagamento.Text + Environment.NewLine;
                rtxtNotaFiscal.Text += "  TROCO             " + txtTroco.Text + Environment.NewLine;
                rtxtNotaFiscal.Text += "====================================================" + Environment.NewLine;
                rtxtNotaFiscal.Text += "Cliente...: " + codCliente.ToString() + " - " + nomeCliente.ToUpper() +Environment.NewLine;                
               
                for (int i = 0; i < funcionarioDAL.Selecionar().Count(); i++)
                {
                    if (funcionarioDAL.Selecionar().ElementAt(i).Codigo == codFuncionario)
                    {
                        nomeFuncionario = funcionarioDAL.Selecionar().ElementAt(i).Nome;
                        cpfFuncionario = funcionarioDAL.Selecionar().ElementAt(i).CPF;
                    }
                }
                nomeFuncionario += " ";
                int posicaoEspaco = 0;
                posicaoEspaco = nomeFuncionario.IndexOf(" ");
                dataHora = DateTime.Now.ToString();
                rtxtNotaFiscal.Text += "Operador..: " + codFuncionario.ToString() + " - " + nomeFuncionario.Substring(0, posicaoEspaco).ToUpper() 
                    + Environment.NewLine;
                rtxtNotaFiscal.Text += "CPF.......: " + cpfFuncionario + Environment.NewLine + Environment.NewLine;

                if (comando.Equals("Agend"))
                {
                    rtxtNotaFiscal.Text += ("DATA MARCADA:     " + dataHoraInicio).PadLeft(52, ' ') + Environment.NewLine;
                    rtxtNotaFiscal.Text += ("DATA ATENDIMENTO: " + dataHora).PadLeft(52, ' ') + Environment.NewLine + Environment.NewLine;
                }
                else if (comando.Equals("Venda"))
                {
                    rtxtNotaFiscal.Text += dataHora.PadLeft(52, ' ') + Environment.NewLine + Environment.NewLine;
                }

                rtxtNotaFiscal.Text += "         **** AGRADECEMOS A PREFERÊNCIA ****        " + Environment.NewLine;
                rtxtNotaFiscal.Text += "             ****** VOLTE SEMPRE ******             " + Environment.NewLine;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Catch Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadora = new frmCalculadora();
            calculadora.Show();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmConsultaProdutos consultarProduto = new frmConsultaProdutos("");
            if ( consultarProduto.ShowDialog() == DialogResult.OK)
            {
                double precoUnd;
                txtCodProduto.Text = consultarProduto.CodigoBarrasProdutoSelecionado().ToString();
                rtxtDescricaoProduto.Text = consultarProduto.DescricaoProdutoSelecionado();
                precoUnd = Convert.ToDouble(consultarProduto.PrecoUNDProdutoSelecionado());
                txtPrecoUnd.Text = precoUnd.ToString("c", br);
                txtValorTotal.Text = txtPrecoUnd.Text;
                nudQtd.Enabled = true;
                btnAdicionar.Enabled = true;
                qtdProd = consultarProduto.QTDProdutoSelecionado();
                codProd = consultarProduto.CodigoProdutoSelecionado();
                nudQtd.Maximum = consultarProduto.QTDProdutoSelecionado();
            }
        }

        private void nudQtd_ValueChanged(object sender, EventArgs e)
        {
            txtPrecoUnd.Text = txtPrecoUnd.Text.Replace("R$ ", "");
            valorTotal = Convert.ToDouble(nudQtd.Value) * (Convert.ToDouble(txtPrecoUnd.Text));
            txtValorTotal.Text = valorTotal.ToString("c", br);
            
            double precoUnd;
            precoUnd = Convert.ToDouble(txtPrecoUnd.Text);
            txtPrecoUnd.Text = precoUnd.ToString("c", br);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
                txtPrecoUnd.Text = txtPrecoUnd.Text.Replace("R$ ", "");
                valorTotal = Convert.ToDouble(nudQtd.Value) * (Convert.ToDouble(txtPrecoUnd.Text));
                txtValorTotal.Text = valorTotal.ToString("c", br);

                txtValorTotal.Text = valorTotal.ToString();
                valorTotal = Convert.ToDouble(txtValorTotal.Text);

                txtTotalPagar.Text = somaTotal.ToString();
                somaTotal = Convert.ToDouble(txtTotalPagar.Text);
                somaTotal += valorTotal;
                txtTotalPagar.Text = somaTotal.ToString();

                totalPagar = Convert.ToDouble(txtTotalPagar.Text);
                txtPagarComDesconto.Text = (totalPagar - (totalPagar * (Convert.ToDouble(nudDesconto.Value) / 100))).ToString("c", br);
                txtTotalPagar.Text = somaTotal.ToString("c", br);

                PreencherNota();
 
                ProdutoVendido prodVend = new ProdutoVendido();
                prodVend.CodVenda = numCupom;
                prodVend.CodProduto = codProd;
                prodVend.Quantidade = Convert.ToInt32(nudQtd.Value);

                for (int j = 0; j < produtoDAL.Selecionar().Count; j++)
                {
                    int novaQtd;
                    if (produtoDAL.Selecionar().ElementAt(j).Codigo == prodVend.CodProduto)
                    {
                        novaQtd = produtoDAL.Selecionar().ElementAt(j).Quantidade - prodVend.Quantidade;
                        produtoDAL.AlterarQtd(novaQtd, prodVend.CodProduto);
                    }
                }
                 
                prodsVends.Add(prodVend);

                beep = new SoundPlayer(Properties.Resources.beep_caixa);
                beep.Play();

                btnAdicionar.Enabled = false;
                txtCodProduto.Text = "";
                rtxtDescricaoProduto.Text = "";
                if (nudQtd.Maximum == 0)
                {
                    nudQtd.Value = 0;
                }
                else
                {
                    nudQtd.Value = 1;
                }
                txtPrecoUnd.Text = "";
                txtValorTotal.Text = "";
                nudQtd.Enabled = false;
        }

        private void nudDesconto_ValueChanged(object sender, EventArgs e)
        {
            pagarComDesconto = somaTotal - somaTotal * (Convert.ToDouble(nudDesconto.Value) / 100);

            txtPagarComDesconto.Text = pagarComDesconto.ToString("c",br);
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            txtTotalPagar.Text = txtTotalPagar.Text.Replace("R$ ","");
            totalPagar = Convert.ToDouble(txtTotalPagar.Text);
            txtPagarComDesconto.Text = pagarComDesconto.ToString(br);
            pagarComDesconto = totalPagar - totalPagar * (Convert.ToDouble(nudDesconto.Value) / 100);
            pagamento = Convert.ToDouble(txtPagamento.Text);

            try
            {
                if (Convert.ToDouble(txtTotalPagar.Text) == 0 || txtTotalPagar.Text.Equals("") && comando == "Agend")
                {
                    MessageBox.Show("Insira um valor do Serviço!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Convert.ToDouble(txtPagamento.Text) == 0 || txtPagamento.Text.Equals(""))
                {
                    MessageBox.Show("Insira o valor pago!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Convert.ToDouble(txtPagamento.Text) < Convert.ToDouble(txtPagarComDesconto.Text))
                {
                    MessageBox.Show("Insira um valor maior que o total a pagar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtCliente.Text.Equals(""))
                {
                    MessageBox.Show("Insira um Cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtTotalPagar.Text = totalPagar.ToString(br);
                    txtPagarComDesconto.Text = pagarComDesconto.ToString("c", br);
                    troco = pagamento - pagarComDesconto;
                    txtTroco.Text = troco.ToString("c", br);
                    txtPagamento.Text = pagamento.ToString("c", br);

                    txtPagamento.ReadOnly = false;                   
                    btnConfirmarCompra.Enabled = false;
                    btnNovaVenda.Enabled = true;

                    if (comando == "Agend")
                    {
                        PreencherNota();
                    }
                    FinalizarNota();

                    beep = new SoundPlayer(Properties.Resources.beep_caixafinal);
                    beep.Play();

                    if (MessageBox.Show("Deseja salvar nota fiscal?", "Cupom", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        saveFileDialog1.FileName = "cupom_" + numCupom.ToString().PadLeft(6, '0');
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if (!System.IO.File.Exists(saveFileDialog1.FileName))
                                System.IO.File.Create(saveFileDialog1.FileName).Close();

                            System.IO.TextWriter arquivo =
                            System.IO.File.AppendText(saveFileDialog1.FileName);

                            arquivo.WriteLine(rtxtNotaFiscal.Text);

                            arquivo.Close();
                        }
                    }

                    Venda venda = new Venda();

                    //inserir VENDA
                    venda.CodCliente = codCliente;
                    venda.CodFuncionario = codFuncionario;
                    venda.ValorVenda = txtPagarComDesconto.Text;
                    venda.DataHora = dataHora;
                    venda.CodEmpresa = empresaDAL.Selecionar().Codigo;
                    venda.CodServico = servico.Codigo;
                    vendaDAL.Inserir(venda);

                    //inserir Prods Vendidos
                    if (comando.Equals("Venda"))
                    {
                        for (int i = 0; i < prodsVends.Count; i++)
                        {
                            //inserindo codvenda nos produtos vendidos, pois não podia ser adc antes
                            prodsVends.ElementAt(i).CodVenda = vendaDAL.Selecionar().Last().CodVenda;
                            //inserindo produto vendido no banco
                            prodVDAL.Inserir(prodsVends.ElementAt(i));
                        }
                    }

                    DialogResult = DialogResult.OK;
                 
                    btnNovaVenda.Enabled = true;
                    btnAddServico.Enabled = false;
                    btnAdicionar.Enabled = false;
                    btnProcurar.Enabled = false;
                    btnCancelar.Enabled = false;
                    cliquei_finalizar = true;
                }               
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Algum(ns) campo(s) está(ão) vazio(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastroProduto = new frmCadastroProduto();
            cadastroProduto.ShowDialog();
        }

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "cupom_" + numCupom.ToString().PadLeft(6, '0');
            //Abrir a janela de salvar e resulta na ação que foi selecionada
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Verificando se o arquivo existe, caso contrário será criado
                if (!System.IO.File.Exists(saveFileDialog1.FileName))
                    System.IO.File.Create(saveFileDialog1.FileName).Close();

                //Recuperando texto passado/salvo
                System.IO.TextWriter arquivo =
                System.IO.File.AppendText(saveFileDialog1.FileName);

                //Escrevendo no arquivo
                arquivo.WriteLine(rtxtNotaFiscal.Text);

                arquivo.Close();
            }
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            btnNovaVenda.Enabled = false;
            btnAddServico.Enabled = true;
            btnAdicionar.Enabled = false;
            btnProcurar.Enabled = true;
            btnCancelar.Enabled = true;
            btnConfirmarCompra.Enabled = true;
            cliquei_finalizar = false;
            txtCliente.Text = "";
            valorTotal = 0;
            somaTotal = 0;
            totalPagar = 0;
            pagarComDesconto = 0;
            txtTotalPagar.Text = "0";
            txtPagarComDesconto.Text = "0";
            txtPagamento.Text = "0";
            txtTroco.Text = "0";
            rtxtNotaFiscal.Text = "";
            nudDesconto.Value = 0;
            cont = 0;
            prodsVends = new List<ProdutoVendido>();
            InicializeNota();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodProduto.Text = "";
            rtxtDescricaoProduto.Text = "";
            nudQtd.Value = 1;
            txtPrecoUnd.Text = "";
            txtValorTotal.Text = "";
            nudQtd.Enabled = false;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadastroCliente = new frmCadastroCliente();
            cadastroCliente.ShowDialog();
        }

        private void btnProcurarCliente_Click(object sender, EventArgs e)
        {
            frmConsultaClientes consultarClientes = new frmConsultaClientes("");
            if (consultarClientes.ShowDialog() == DialogResult.OK)
            {
                txtCliente.Text = consultarClientes.NomeClienteSelecionado();
                nomeCliente = consultarClientes.NomeClienteSelecionado();
                codCliente = consultarClientes.CodigoClienteSelecionado();
            }
        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {
            if (comando == "Agend")
            {
                totalPagar = Convert.ToDouble(txtTotalPagar.Text);
                txtPagarComDesconto.Text = totalPagar.ToString("c", br);
                somaTotal = totalPagar;
            }
        }

        private void frmControleVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //repondo a qtd de produtos se compra não finalizada
            if (cliquei_finalizar == false)
            {
                if (comando.Equals("Venda"))
                {
                    for (int i = 0; i < prodsVends.Count; i++)
                    {
                        for (int j = 0; j < produtoDAL.Selecionar().Count; j++)
                        {
                            int novaQtd;
                            if (produtoDAL.Selecionar().ElementAt(j).Codigo == prodsVends.ElementAt(i).CodProduto)
                            {
                                novaQtd = produtoDAL.Selecionar().ElementAt(j).Quantidade + prodsVends.ElementAt(i).Quantidade;
                                produtoDAL.AlterarQtd(novaQtd, prodsVends.ElementAt(i).CodProduto);
                            }
                        }
                    }
                }
            }
        }
    }
}
