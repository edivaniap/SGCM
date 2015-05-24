using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class ProdutoVendidoDAL
    {
        private ConexaoDB conexaoDB;

        public ProdutoVendidoDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public void Inserir(ProdutoVendido produtoVendido)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            try
            {
                sqlConnection.Open();
               
                SqlCommand sqlCommand = new SqlCommand("insert into ProdutosVendidos values (@CodVenda, @CodProduto, @Quantidade)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CodVenda", produtoVendido.CodVenda);
                sqlCommand.Parameters.AddWithValue("@CodProduto", produtoVendido.CodProduto);
                sqlCommand.Parameters.AddWithValue("@Quantidade", produtoVendido.Quantidade);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserir Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<ProdutoVendido> Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            List<ProdutoVendido> produtosVendidos = new List<ProdutoVendido>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from ProdutosVendidos;", sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ProdutoVendido produtoVendido = new ProdutoVendido();

                    produtoVendido.CodProdVendido = Convert.ToInt32(sqlDataReader[0]);
                    produtoVendido.CodVenda = Convert.ToInt32(sqlDataReader[1]);
                    produtoVendido.CodProduto = Convert.ToInt32(sqlDataReader[2]);
                    produtoVendido.Quantidade = Convert.ToInt32(sqlDataReader[3]);

                    produtosVendidos.Add(produtoVendido);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Selecionar de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }

            return produtosVendidos;
        }

        public List<ProdutoVendido> Filtrar(string tipoFiltro, string filtro)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from ProdutosVendidos where " +
                tipoFiltro + " like '%" + filtro + "%';", sqlConnection);

             List<ProdutoVendido> produtosVendidos = new List<ProdutoVendido>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ProdutoVendido produtoVendido = new ProdutoVendido();

                    produtoVendido.CodProdVendido = Convert.ToInt32(sqlDataReader[0]);
                    produtoVendido.CodVenda = Convert.ToInt32(sqlDataReader[1]);
                    produtoVendido.CodProduto = Convert.ToInt32(sqlDataReader[2]);
                    produtoVendido.Quantidade = Convert.ToInt32(sqlDataReader[3]);

                    produtosVendidos.Add(produtoVendido);
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

            return produtosVendidos;
        }

        public void Deletar(int codigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("delete ProdutosVendidos where CodProdVendidos = '" + codigo + "';", sqlConnection);
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
    }
}
