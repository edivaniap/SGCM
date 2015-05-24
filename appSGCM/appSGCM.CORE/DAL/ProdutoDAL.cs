using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class ProdutoDAL
    {
        private ConexaoDB conexaoDB;

        public ProdutoDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public void Inserir(Produto produto)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("insert into Produto values (@Nome, @Tipo, @CodigoProduto, @Descricao, @Quantidade, @Fornecedor,  @CodFornecedor, @PrecoCompra, @PrecoVenda, @DataAtualizacao, @Imagem)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Nome", produto.Nome);
                sqlCommand.Parameters.AddWithValue("@Tipo", produto.Tipo);
                sqlCommand.Parameters.AddWithValue("@CodigoProduto", produto.Codigo_Barras);
                sqlCommand.Parameters.AddWithValue("@Descricao", produto.Descricao);
                sqlCommand.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                sqlCommand.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);
                sqlCommand.Parameters.AddWithValue("@CodFornecedor", produto.CodFornecedor);
                sqlCommand.Parameters.AddWithValue("@PrecoCompra", produto.Preco_Compra);
                sqlCommand.Parameters.AddWithValue("@PrecoVenda", produto.Preco_Venda);
                sqlCommand.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                sqlCommand.Parameters.AddWithValue("@Imagem", produto.Imagem);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserção Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<Produto> Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Produto", sqlConnection);

            List<Produto> produtos = new List<Produto>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Produto produto = new Produto();

                    produto.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    produto.Nome = sqlDataReader[1].ToString();
                    produto.Tipo = sqlDataReader[2].ToString();
                    produto.Codigo_Barras = Convert.ToDecimal(sqlDataReader[3]);
                    produto.Descricao = sqlDataReader[4].ToString();
                    produto.Quantidade = Convert.ToInt32(sqlDataReader[5]);
                    produto.Fornecedor = sqlDataReader[6].ToString();
                    produto.CodFornecedor = Convert.ToInt32(sqlDataReader[7]);
                    produto.Preco_Compra = (sqlDataReader[8]).ToString();
                    produto.Preco_Venda = (sqlDataReader[9]).ToString();
                    produto.DataAtualizacao = sqlDataReader[10].ToString();
                    produto.Imagem = sqlDataReader[11].ToString();

                    produtos.Add(produto);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Seleção de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }

            return produtos;
        }

        public void Alterar(Produto novoProduro, int atualCodigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Produto set Nome = '" + novoProduro.Nome + "', Tipo = '" + novoProduro.Tipo +
                    "', CodigoProduto = '" + novoProduro.Codigo_Barras + "', Descricao = '" + novoProduro.Descricao +
                    "', Quantidade = '" + novoProduro.Quantidade + "', Fornecedor = '" + novoProduro.Fornecedor +
                    "', CodFornecedor = '" + novoProduro.CodFornecedor + "', PrecoCompra = '" + novoProduro.Preco_Compra +
                    "', PrecoVenda = '" + novoProduro.Preco_Venda + "', DataAtualizacao = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() +
                    "', Imagem = '" + novoProduro.Imagem + "' where CodProduto = '" + atualCodigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alterar Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        public void AlterarQtd(int qtd, int atualCodigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Produto set Quantidade = '" + qtd + 
                    "' where CodProduto = '" + atualCodigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alterar Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void Deletar(int codigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("delete Produto where CodProduto = '" + codigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deletar Dasos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<Produto> Filtrar(string tipoFiltro, string filtro)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Produto where " + tipoFiltro +
                " like '%" + filtro + "%';", sqlConnection);

            List<Produto> produtos = new List<Produto>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Produto produto = new Produto();

                    produto.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    produto.Nome = sqlDataReader[1].ToString();
                    produto.Tipo = sqlDataReader[2].ToString();
                    produto.Codigo_Barras = Convert.ToDecimal(sqlDataReader[3]);
                    produto.Descricao = sqlDataReader[4].ToString();
                    produto.Quantidade = Convert.ToInt32(sqlDataReader[5]);
                    produto.Fornecedor = sqlDataReader[6].ToString();
                    produto.CodFornecedor = Convert.ToInt32(sqlDataReader[7]);
                    produto.Preco_Compra = (sqlDataReader[8]).ToString();
                    produto.Preco_Venda = (sqlDataReader[9]).ToString();
                    produto.DataAtualizacao = sqlDataReader[10].ToString();
                    produto.Imagem = sqlDataReader[11].ToString();

                    produtos.Add(produto);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filtro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
            return produtos;
        }
    }
}
