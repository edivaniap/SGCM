using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using appSGCM.CORE.Model;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class ServicoDAL
    {
        private ConexaoDB conexaoDB;

        public ServicoDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public void Inserir(Servico servico)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("insert into Servico values (@Tipo, @Descricao)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Tipo", servico.Tipo);
                sqlCommand.Parameters.AddWithValue("@Descricao", servico.Descricao);
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

        public List<Servico> Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Servico", sqlConnection);

            List<Servico> servicos = new List<Servico>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Servico servico = new Servico();

                    servico.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    servico.Tipo = sqlDataReader[1].ToString();
                    servico.Descricao = sqlDataReader[2].ToString();

                    servicos.Add(servico);
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

            return servicos;
        }

        public void Alterar(Servico novoServico, int atualCodigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Servico set Tipo = '" + novoServico.Tipo + "', Descricao = '" +
                    novoServico.Descricao + "' where CodServico = '" + atualCodigo + "';", sqlConnection);
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

                sqlCommand = new SqlCommand("delete Servico where CodServico = '" + codigo + "';", sqlConnection);
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

        public List<Servico> Filtrar(string tipoFiltro, string filtro)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Servico where " +
                tipoFiltro + " like '%" + filtro + "%';", sqlConnection);

            List<Servico> servicos = new List<Servico>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Servico servico = new Servico();

                    servico.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    servico.Tipo = sqlDataReader[1].ToString();
                    servico.Descricao = sqlDataReader[2].ToString();

                    servicos.Add(servico);
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

            return servicos;
        }
    }
}