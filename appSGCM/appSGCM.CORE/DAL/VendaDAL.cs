using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class VendaDAL
    {
        private ConexaoDB conexaoDB;

        public VendaDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public void Inserir(Venda venda)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            try
            {
                sqlConnection.Open();
               
                SqlCommand sqlCommand = new SqlCommand("insert into Venda values (@CodCliente, @CodFuncionario, @CodEmpresa, @CodServico, @ValorVenda, @DataHora)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CodCliente", venda.CodCliente);
                sqlCommand.Parameters.AddWithValue("@CodFuncionario", venda.CodFuncionario);
                sqlCommand.Parameters.AddWithValue("@CodEmpresa", venda.CodEmpresa);
                sqlCommand.Parameters.AddWithValue("@CodServico", venda.CodServico);
                sqlCommand.Parameters.AddWithValue("@ValorVenda", venda.ValorVenda);
                sqlCommand.Parameters.AddWithValue("@DataHora", venda.DataHora);
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

        public List<Venda> Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            List<Venda> vendas = new List<Venda>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Venda;", sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Venda venda = new Venda();

                    venda.CodVenda = Convert.ToInt32(sqlDataReader[0]);
                    venda.CodCliente = Convert.ToInt32(sqlDataReader[1]);
                    venda.CodEmpresa = Convert.ToInt32(sqlDataReader[2]);
                    venda.CodFuncionario= Convert.ToInt32(sqlDataReader[3]);
                    venda.CodServico = Convert.ToInt32(sqlDataReader[4]);
                    venda.ValorVenda = sqlDataReader[5].ToString();
                    venda.DataHora = sqlDataReader[6].ToString();

                    vendas.Add(venda);
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

            return vendas;
        }

        public List<Venda> Filtrar(string tipoFiltro, string filtro)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Venda where " +
                tipoFiltro + " like '%" + filtro + "%';", sqlConnection);

            List<Venda> vendas = new List<Venda>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Venda venda = new Venda();

                    venda.CodVenda = Convert.ToInt32(sqlDataReader[0]);
                    venda.CodCliente = Convert.ToInt32(sqlDataReader[1]);
                    venda.CodFuncionario = Convert.ToInt32(sqlDataReader[2]);
                    venda.CodEmpresa = Convert.ToInt32(sqlDataReader[3]);
                    venda.CodServico = Convert.ToInt32(sqlDataReader[4]);
                    venda.ValorVenda = sqlDataReader[5].ToString();
                    venda.DataHora = sqlDataReader[6].ToString();

                    vendas.Add(venda);
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

            return vendas;
        }

        public void Deletar(int codigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("delete Venda where CodVenda = '" + codigo + "';", sqlConnection);
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
