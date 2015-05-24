using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class EmpresaDAL
    {
        private ConexaoDB conexaoDB;

        public EmpresaDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public void Inserir(Empresa empresa)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            try
            {
                sqlConnection.Open();

                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                SqlCommand sqlCommand = new SqlCommand("insert into Pessoa values (@Nome, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @UF, @CEP, @Celular, @Telefone, @Email, @Site, @Facebook,  @DataAtualizacao)", sqlConnection, sqlTransaction);
                sqlCommand.Parameters.AddWithValue("@Nome", empresa.Nome);
                sqlCommand.Parameters.AddWithValue("@Endereco", empresa.Endereco);
                sqlCommand.Parameters.AddWithValue("@Numero", empresa.Numero);
                sqlCommand.Parameters.AddWithValue("@Complemento", empresa.Complemento);
                sqlCommand.Parameters.AddWithValue("@Bairro", empresa.Bairro);
                sqlCommand.Parameters.AddWithValue("@Cidade", empresa.Cidade);
                sqlCommand.Parameters.AddWithValue("@UF", empresa.UF);
                sqlCommand.Parameters.AddWithValue("@CEP", empresa.CEP);
                sqlCommand.Parameters.AddWithValue("@Celular", empresa.Celular);
                sqlCommand.Parameters.AddWithValue("@Telefone", empresa.Telefone);
                sqlCommand.Parameters.AddWithValue("@Email", empresa.Email);
                sqlCommand.Parameters.AddWithValue("@Site", empresa.Site);
                sqlCommand.Parameters.AddWithValue("@Facebook", empresa.Facebook);
                sqlCommand.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("select MAX(CodPessoa) from Pessoa", sqlConnection, sqlTransaction);

                int codigoInserido = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand = new SqlCommand("insert into Empresa values (@CodEmpresa, @CNPJ, @Filiais, @Proprietario, @CPF, @RG)", sqlConnection, sqlTransaction);

                sqlCommand.Parameters.AddWithValue("@CodEmpresa", codigoInserido);
                sqlCommand.Parameters.AddWithValue("@CNPJ", empresa.CNPJ);
                sqlCommand.Parameters.AddWithValue("@Filiais", empresa.Filiais);
                sqlCommand.Parameters.AddWithValue("@Proprietario", empresa.Proprietario);
                sqlCommand.Parameters.AddWithValue("@CPF", empresa.CPF);
                sqlCommand.Parameters.AddWithValue("@RG", empresa.RG);
                
                sqlCommand.ExecuteNonQuery();

                sqlTransaction.Commit();
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

        public Empresa Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            Empresa empresa = new Empresa();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Pessoa inner join Empresa on " +
                "CodPessoa = CodEmpresa;", sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    empresa.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    empresa.Nome = sqlDataReader[1].ToString();
                    empresa.Endereco = sqlDataReader[2].ToString();
                    empresa.Numero = Convert.ToInt32(sqlDataReader[3]);
                    empresa.Complemento = sqlDataReader[4].ToString();
                    empresa.Bairro = sqlDataReader[5].ToString();
                    empresa.Cidade = sqlDataReader[6].ToString();
                    empresa.UF = sqlDataReader[7].ToString();
                    empresa.CEP = sqlDataReader[8].ToString();
                    empresa.Celular = sqlDataReader[9].ToString();
                    empresa.Telefone = sqlDataReader[10].ToString();
                    empresa.Email = sqlDataReader[11].ToString();
                    empresa.Site = sqlDataReader[12].ToString();
                    empresa.Facebook = sqlDataReader[13].ToString();
                    empresa.DataAtualizacao = sqlDataReader[14].ToString();
                    empresa.CNPJ = sqlDataReader[16].ToString();
                    empresa.Filiais = Convert.ToInt32(sqlDataReader[17]);
                    empresa.Proprietario = sqlDataReader[18].ToString();
                    empresa.CPF = sqlDataReader[19].ToString();
                    empresa.RG = sqlDataReader[20].ToString();
                    
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

            return empresa;
        }

        public void Alterar(Empresa novaEmpresa, int atualCodigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Pessoa set Nome = '" + novaEmpresa.Nome + "', Endereco = '" +
                    novaEmpresa.Endereco + "', Numero = '" + novaEmpresa.Numero + "', Complemento = '" + novaEmpresa.Complemento + 
                    "', Bairro = '" + novaEmpresa.Bairro + "', Cidade = '" + novaEmpresa.Cidade + "', UF = '" + novaEmpresa.UF + 
                    "', CEP = '" + novaEmpresa.CEP + "', Celular = '" + novaEmpresa.Celular + "', Telefone = '" + novaEmpresa.Telefone + 
                    "', Email = '" + novaEmpresa.Email + "', Site = '" + novaEmpresa.Site + "', Facebook = '" + novaEmpresa.Facebook +
                    "', DataAtualizacao = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() +
                    "' where CodPessoa = '" + atualCodigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("update empresa set CNPJ = '" + novaEmpresa.CNPJ + "', Proprietario = '" +
                    novaEmpresa.Proprietario + "', CPF = '" + novaEmpresa.CPF + "', RG = '" + novaEmpresa.RG + 
                    "' where CodEmpresa = '" + atualCodigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alteraração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool IsFilled()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("select * from Empresa;", sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
