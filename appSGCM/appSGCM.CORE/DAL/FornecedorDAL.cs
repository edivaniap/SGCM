using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class FornecedorDAL
    {
        private ConexaoDB conexaoDB;

        public FornecedorDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public void Inserir(Fornecedor fornecedor)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            try
            {
                sqlConnection.Open();

                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                SqlCommand sqlCommand = new SqlCommand("insert into Pessoa values (@Nome, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @UF, @CEP, @Celular, @Telefone, @Email, @Site, @Facebook, @DataAtualizacao)", sqlConnection, sqlTransaction);
                sqlCommand.Parameters.AddWithValue("@Nome", fornecedor.Nome);
                sqlCommand.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
                sqlCommand.Parameters.AddWithValue("@Numero", fornecedor.Numero);
                sqlCommand.Parameters.AddWithValue("@Complemento", fornecedor.Complemento);
                sqlCommand.Parameters.AddWithValue("@Bairro", fornecedor.Bairro);
                sqlCommand.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);
                sqlCommand.Parameters.AddWithValue("@UF", fornecedor.UF);
                sqlCommand.Parameters.AddWithValue("@CEP", fornecedor.CEP);
                sqlCommand.Parameters.AddWithValue("@Celular", fornecedor.Celular);
                sqlCommand.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
                sqlCommand.Parameters.AddWithValue("@Email", fornecedor.Email);
                sqlCommand.Parameters.AddWithValue("@Site", fornecedor.Site);
                sqlCommand.Parameters.AddWithValue("@Facebook", fornecedor.Facebook);
                sqlCommand.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("select MAX(CodPessoa) from Pessoa", sqlConnection, sqlTransaction);

                int codigoInserido = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand =
                    new SqlCommand("insert into Fornecedor values (@CodFornecedor, @CNPJ)", sqlConnection, sqlTransaction);
                
                sqlCommand.Parameters.AddWithValue("@CodFornecedor", codigoInserido);
                sqlCommand.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);

                sqlCommand.ExecuteNonQuery();
                
                sqlTransaction.Commit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserção Dasos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<Fornecedor> Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Pessoa inner join Fornecedor on " +
                "CodPessoa = CodFornecedor;", sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();

                    fornecedor.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    fornecedor.Nome = sqlDataReader[1].ToString();
                    fornecedor.Endereco = sqlDataReader[2].ToString();
                    fornecedor.Numero = Convert.ToInt32(sqlDataReader[3]);
                    fornecedor.Complemento = sqlDataReader[4].ToString();
                    fornecedor.Bairro = sqlDataReader[5].ToString();
                    fornecedor.Cidade = sqlDataReader[6].ToString();
                    fornecedor.UF = sqlDataReader[7].ToString();
                    fornecedor.CEP = sqlDataReader[8].ToString();
                    fornecedor.Celular = sqlDataReader[9].ToString();
                    fornecedor.Telefone = sqlDataReader[10].ToString();
                    fornecedor.Email = sqlDataReader[11].ToString();
                    fornecedor.Site = sqlDataReader[12].ToString();
                    fornecedor.Facebook = sqlDataReader[13].ToString();
                    fornecedor.DataAtualizacao = sqlDataReader[14].ToString();
                    fornecedor.CNPJ = sqlDataReader[16].ToString();
                    
                    fornecedores.Add(fornecedor);
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
            return fornecedores;
        }

        public void Alterar(Fornecedor novoFornecedor, int atualCodigo)
        {

            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Pessoa set Nome = '" + novoFornecedor.Nome + "', Endereco = '" +
                    novoFornecedor.Endereco + "', Numero = '" + novoFornecedor.Numero + "', Complemento = '" + novoFornecedor.Complemento + 
                    "', Bairro = '" + novoFornecedor.Bairro + "', Cidade = '" + novoFornecedor.Cidade + "', UF = '" + novoFornecedor.UF + 
                    "', CEP = '" + novoFornecedor.CEP + "', Celular = '" + novoFornecedor.Celular + "', Telefone = '" + novoFornecedor.Telefone +
                    "', Email = '" + novoFornecedor.Email + "', Site = '" + novoFornecedor.Site + "', Facebook = '" + novoFornecedor.Facebook +
                    "', DataAtualizacao = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() +
                    "' where CodPessoa = '" + atualCodigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("update Fornecedor set CNPJ = '" + novoFornecedor.CNPJ + 
                    "' where CodFornecedor = '" + atualCodigo + "';", sqlConnection);
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

                sqlCommand = new SqlCommand("delete Fornecedor where CodFornecedor = '" + codigo + "';", sqlConnection);
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

        public List<Fornecedor> Filtrar(string tipoFiltro, string filtro)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Pessoa inner join Fornecedor on CodPessoa = CodFornecedor  where " + tipoFiltro +
                " like '%" + filtro + "%';", sqlConnection);

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();

                    fornecedor.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    fornecedor.Nome = sqlDataReader[1].ToString();
                    fornecedor.Endereco = sqlDataReader[2].ToString();
                    fornecedor.Numero = Convert.ToInt32(sqlDataReader[3]);
                    fornecedor.Complemento = sqlDataReader[4].ToString();
                    fornecedor.Bairro = sqlDataReader[5].ToString();
                    fornecedor.Cidade = sqlDataReader[6].ToString();
                    fornecedor.UF = sqlDataReader[7].ToString();
                    fornecedor.CEP = sqlDataReader[8].ToString();
                    fornecedor.Celular = sqlDataReader[9].ToString();
                    fornecedor.Telefone = sqlDataReader[10].ToString();
                    fornecedor.Email = sqlDataReader[11].ToString();
                    fornecedor.Site = sqlDataReader[12].ToString();
                    fornecedor.Facebook = sqlDataReader[13].ToString();
                    fornecedor.DataAtualizacao = sqlDataReader[14].ToString();
                    fornecedor.CNPJ = sqlDataReader[16].ToString();

                    fornecedores.Add(fornecedor);
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
            return fornecedores;
        }
    }
}
