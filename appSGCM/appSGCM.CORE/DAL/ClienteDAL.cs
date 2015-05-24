using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class ClienteDAL
    {
        private ConexaoDB conexaoDB;

        public ClienteDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public void Inserir(Cliente cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            try
            {
                sqlConnection.Open();

                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                SqlCommand sqlCommand = new SqlCommand("insert into Pessoa values (@Nome, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @UF, @CEP, @Celular, @Telefone, @Email, @Site, @Facebook, @DataAtualizacao)", sqlConnection, sqlTransaction);
                sqlCommand.Parameters.AddWithValue("@Nome", cliente.Nome);
                sqlCommand.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                sqlCommand.Parameters.AddWithValue("@Numero", cliente.Numero);
                sqlCommand.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                sqlCommand.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                sqlCommand.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                sqlCommand.Parameters.AddWithValue("@UF", cliente.UF);
                sqlCommand.Parameters.AddWithValue("@CEP", cliente.CEP);
                sqlCommand.Parameters.AddWithValue("@Celular", cliente.Celular);
                sqlCommand.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                sqlCommand.Parameters.AddWithValue("@Email", cliente.Email);
                sqlCommand.Parameters.AddWithValue("@Site", cliente.Site);
                sqlCommand.Parameters.AddWithValue("@Facebook", cliente.Facebook);
                sqlCommand.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("select MAX(CodPessoa) from Pessoa", sqlConnection, sqlTransaction);
                int codigoInserido = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand =
                    new SqlCommand("insert into Cliente values (@CodCliente, @Sexo, @Nascimento, @RG, @CPF)", sqlConnection, sqlTransaction);

                sqlCommand.Parameters.AddWithValue("@CodCliente", codigoInserido);
                sqlCommand.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                sqlCommand.Parameters.AddWithValue("@Nascimento", cliente.Nascimento);
                sqlCommand.Parameters.AddWithValue("@RG", cliente.RG);
                sqlCommand.Parameters.AddWithValue("@CPF", cliente.CPF);

                sqlCommand.ExecuteNonQuery();
                
                sqlTransaction.Commit();
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

        public List<Cliente> Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Pessoa inner join Cliente on CodPessoa = CodCliente;", sqlConnection);

            List<Cliente> clientes = new List<Cliente>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    cliente.Nome = sqlDataReader[1].ToString();
                    cliente.Endereco = sqlDataReader[2].ToString();
                    cliente.Numero = Convert.ToInt32(sqlDataReader[3]);
                    cliente.Complemento = sqlDataReader[4].ToString();
                    cliente.Bairro = sqlDataReader[5].ToString();
                    cliente.Cidade = sqlDataReader[6].ToString();
                    cliente.UF = sqlDataReader[7].ToString();
                    cliente.CEP = sqlDataReader[8].ToString();
                    cliente.Celular = sqlDataReader[9].ToString();
                    cliente.Telefone = sqlDataReader[10].ToString();
                    cliente.Email = sqlDataReader[11].ToString();
                    cliente.Site = sqlDataReader[12].ToString();
                    cliente.Facebook = sqlDataReader[13].ToString();
                    cliente.DataAtualizacao = sqlDataReader[14].ToString();
                    cliente.Sexo = sqlDataReader[16].ToString();
                    cliente.Nascimento = Convert.ToDateTime(sqlDataReader[17]);
                    cliente.RG = sqlDataReader[18].ToString();
                    cliente.CPF = sqlDataReader[19].ToString();

                    clientes.Add(cliente);
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
            return clientes;
        }
        public void Alterar(Cliente novoCliente, int atualCodigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Pessoa set Nome = '" + novoCliente.Nome + "', Endereco = '" +
                    novoCliente.Endereco + "', Numero = '" + novoCliente.Numero + "', Complemento = '" + novoCliente.Complemento + 
                    "', Bairro = '" + novoCliente.Bairro + "', Cidade = '" + novoCliente.Cidade + "', UF = '" + novoCliente.UF + 
                    "', CEP = '" + novoCliente.CEP + "', Celular = '" + novoCliente.Celular + "', Telefone = '" + novoCliente.Telefone + 
                    "', Email = '" + novoCliente.Email + "', Site = '" + novoCliente.Site + "', Facebook = '" + novoCliente.Facebook +
                    "', DataAtualizacao = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() +
                    "' where CodPessoa = '" + atualCodigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("update Cliente set Sexo = '" + novoCliente.Sexo + "', Nascimento = '" +
                    novoCliente.Nascimento + "', RG = '" + novoCliente.RG + "', CPF = '" + novoCliente.CPF + 
                    "' where CodCliente = '" + atualCodigo + "';", sqlConnection);
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

                sqlCommand = new SqlCommand("delete Cliente where CodCliente = '" + codigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("delete Pessoa where CodPessoa = '" + codigo + "';", sqlConnection);
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

        public List<Cliente> Filtrar(string tipoFiltro, string filtro)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            
            SqlCommand sqlCommand = new SqlCommand("select * from Pessoa inner join Cliente on CodPessoa = CodCliente where " +
                tipoFiltro + " like '%" + filtro + "%';", sqlConnection);

             List<Cliente> clientes = new List<Cliente>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    cliente.Nome = sqlDataReader[1].ToString();
                    cliente.Endereco = sqlDataReader[2].ToString();
                    cliente.Numero = Convert.ToInt32(sqlDataReader[3]);
                    cliente.Complemento = sqlDataReader[4].ToString();
                    cliente.Bairro = sqlDataReader[5].ToString();
                    cliente.Cidade = sqlDataReader[6].ToString();
                    cliente.UF = sqlDataReader[7].ToString();
                    cliente.CEP = sqlDataReader[8].ToString();
                    cliente.Celular = sqlDataReader[9].ToString();
                    cliente.Telefone = sqlDataReader[10].ToString();
                    cliente.Email = sqlDataReader[11].ToString();
                    cliente.Site = sqlDataReader[12].ToString();
                    cliente.Facebook = sqlDataReader[13].ToString();
                    cliente.DataAtualizacao = sqlDataReader[14].ToString();
                    cliente.Sexo = sqlDataReader[16].ToString();
                    cliente.Nascimento = Convert.ToDateTime(sqlDataReader[17]);
                    cliente.RG = sqlDataReader[18].ToString();
                    cliente.CPF = sqlDataReader[19].ToString();

                    clientes.Add(cliente);
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
            return clientes;
        }
    }
}
