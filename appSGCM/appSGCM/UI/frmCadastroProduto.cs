using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appSGCM.CORE.Model;
using appSGCM.CORE.DAL;

namespace appSGCM.UI
{
    public partial class frmCadastroProduto : Form
    {
        FornecedorDAL fornecedorDAL;
        ProdutoDAL produtoDAL;
        string diretorioImagem;
        string comando2;
        int codigo;
        int codFornec;

        public frmCadastroProduto()
        {
            InitializeComponent();
            fornecedorDAL = new FornecedorDAL();
            produtoDAL = new ProdutoDAL();  
            comando2 = "Cadastrar";
            diretorioImagem = "";
            lbDataAtualizacao.Text = "";
            cbxTipo.SelectedIndex = 1;
            for (int i = 0; i < fornecedorDAL.Selecionar().Count(); i++)
            {
                cbxFornecedor.Items.Add(fornecedorDAL.Selecionar().ElementAt(i).Nome);
            }
        }

        public frmCadastroProduto(Produto produto, string comando)
        {
            InitializeComponent();

            fornecedorDAL = new FornecedorDAL();
            produtoDAL = new ProdutoDAL();

            diretorioImagem = produto.Imagem;

            for (int i = 0; i < fornecedorDAL.Selecionar().Count(); i++)
            {
                cbxFornecedor.Items.Add(fornecedorDAL.Selecionar().ElementAt(i).Nome);
            }

            foreach (object item in cbxFornecedor.Items)
            {
                if (item.ToString() == produto.Fornecedor)
                {
                    cbxFornecedor.SelectedItem = item;
                    break;
                }
            }

            codigo = produto.Codigo;
            txtNomeProduto.Text = produto.Nome;
            txtCodigoProd.Text = produto.Codigo_Barras.ToString();
            txtQtd.Text = produto.Quantidade.ToString();
            cbxTipo.Text = produto.Tipo;
            nudPrecoCompra.Value = Convert.ToDecimal(produto.Preco_Compra.ToString());
            nudPrecoVenda.Value = Convert.ToDecimal(produto.Preco_Venda.ToString());            
            rtxtDescricao.Text = produto.Descricao;

            for (int i = 0; i < produtoDAL.Selecionar().Count(); i++)
            {
                if (produto.Codigo.Equals(produtoDAL.Selecionar().ElementAt(i).Codigo))
                {
                    lbDataAtualizacao.Text = produtoDAL.Selecionar().ElementAt(i).DataAtualizacao;
                }
            }

            if (comando.Equals("Alterar"))
            {
                this.Text = "SGCM - Alterar Produto " + produto.Codigo;
                btnCadastrar.Text = "Alterar";
                comando2 = comando;
            }
            else
            {
                btnAdicionar.Enabled = false;
                btnLimpar.Enabled = false;

                txtNomeProduto.ReadOnly = true;
                txtCodigoProd.ReadOnly = true;
                txtQtd.ReadOnly = true;
                cbxTipo.Enabled = false;
                cbxFornecedor.Enabled = false;
                rtxtDescricao.ReadOnly = true;
                nudPrecoCompra.ReadOnly = true;
                nudPrecoVenda.ReadOnly = true;
                
                if (comando.Equals("Visualizar"))
                {
                    this.Text = "SGCM - Produto " + produto.Codigo;
                    btnCancelar.Text = "OK";
                    btnCadastrar.Visible = false;
                }
                else if (comando.Equals("Deletar"))
                {
                    this.Text = "SGCM - Deletar Produto " + produto.Codigo;
                    btnCadastrar.Text = "Deletar";
                    comando2 = comando;
                }
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ofdFoto.InitialDirectory = Application.StartupPath + @"\";

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                Image imagem = Image.FromFile(ofdFoto.FileName);
                picbxProduto.Image = imagem;
                diretorioImagem = ofdFoto.FileName;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja apagar imagem?", "Limpar Imagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                picbxProduto.Image = picbxProduto.InitialImage;
                diretorioImagem = "";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (comando2.Equals("Deletar"))
            {
                if (MessageBox.Show("Tem certeza que deseja deletar este produto?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produtoDAL.Deletar(codigo);
                    MessageBox.Show("Produto deletado com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                Produto produto = new Produto();
                try
                {
                    produto.Nome = txtNomeProduto.Text;
                    produto.Tipo = cbxTipo.Text;
                    produto.Codigo_Barras = Convert.ToDecimal(txtCodigoProd.Text);
                    produto.Fornecedor = cbxFornecedor.Text;
                    produto.Quantidade = Convert.ToInt32(txtQtd.Text);
                    produto.Preco_Compra = nudPrecoCompra.Text;
                    produto.Preco_Venda = nudPrecoVenda.Text;
                    produto.Descricao = rtxtDescricao.Text;
                    produto.CodFornecedor = codFornec;
                    produto.Imagem = diretorioImagem;

                    if (comando2.Equals("Cadastrar"))
                    {
                        produtoDAL.Inserir(produto);
                        MessageBox.Show("Produto cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        txtNomeProduto.Text = "";
                        cbxTipo.Text = "";
                        txtCodigoProd.Text = "";
                        cbxFornecedor.Text = "";
                        txtQtd.Text = "";
                        nudPrecoCompra.Text = "";
                        nudPrecoVenda.Text = "";
                    }
                    else if (comando2.Equals("Alterar"))
                    {
                        produtoDAL.Alterar(produto, codigo);
                        MessageBox.Show("Produto alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditarListaUnidade_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor cadastroFornecedor = new frmCadastroFornecedor();
            cadastroFornecedor.ShowDialog();
        }

        private void btnAddFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor cadastroFornecedor = new frmCadastroFornecedor();
            if (cadastroFornecedor.ShowDialog() == DialogResult.OK)
            {
                cbxFornecedor.Items.Add(fornecedorDAL.Selecionar().Last().Nome); 
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            picbxProduto.Image = Image.FromFile(diretorioImagem);
        }

        private void cbxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < fornecedorDAL.Selecionar().Count(); i++)
            {
                if (cbxFornecedor.Text.Equals(fornecedorDAL.Selecionar().ElementAt(i).Nome))
                {
                    codFornec = fornecedorDAL.Selecionar().ElementAt(i).Codigo;
                    break;
                }
            }
        }
    }
}
