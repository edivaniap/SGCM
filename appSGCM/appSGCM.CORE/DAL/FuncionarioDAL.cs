using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class FuncionarioDAL
    {
        private ConexaoDB conexaoDB;

        public FuncionarioDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public void Inserir(Funcionario funcionario)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            try
            {
                sqlConnection.Open();

                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                
                SqlCommand sqlCommand = new SqlCommand("insert into Pessoa values (@Nome, @Endereco, @Numero, " +
                    "@Complemento, @Bairro, @Cidade, @UF, @CEP, @Celular, @Telefone, @Email, @Site, @Facebook, @DataAtualizacao)",
                    sqlConnection, sqlTransaction);
                
                sqlCommand.Parameters.AddWithValue("@Nome", funcionario.Nome);
                sqlCommand.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
                sqlCommand.Parameters.AddWithValue("@Numero", funcionario.Numero);
                sqlCommand.Parameters.AddWithValue("@Complemento", funcionario.Complemento);
                sqlCommand.Parameters.AddWithValue("@Bairro", funcionario.Bairro);
                sqlCommand.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
                sqlCommand.Parameters.AddWithValue("@UF", funcionario.UF);
                sqlCommand.Parameters.AddWithValue("@CEP", funcionario.CEP);
                sqlCommand.Parameters.AddWithValue("@Celular", funcionario.Celular);
                sqlCommand.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                sqlCommand.Parameters.AddWithValue("@Email", funcionario.Email);
                sqlCommand.Parameters.AddWithValue("@Site", funcionario.Site);
                sqlCommand.Parameters.AddWithValue("@Facebook", funcionario.Facebook);
                sqlCommand.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("select MAX(CodPessoa) from Pessoa", sqlConnection, sqlTransaction);
                int codigoInserido = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand = new SqlCommand("insert into Funcionario values (@CodFuncionario, @Sexo, @Nascimento, " +
                    "@RG, @CPF, @EstadoCivil, @CarteiraTrabalho, @ExpedicaoCT, @Nacionalidade, @Cargo, @Turno, " +
                    "@Salario, @Dependentes, @HorasDiarias, @TipoContrato, @Imagem)", sqlConnection, sqlTransaction);
                
                sqlCommand.Parameters.AddWithValue("@CodFuncionario", codigoInserido);
                sqlCommand.Parameters.AddWithValue("@Sexo", funcionario.Sexo);
                sqlCommand.Parameters.AddWithValue("@Nascimento", funcionario.Nascimento);
                sqlCommand.Parameters.AddWithValue("@RG", funcionario.RG);
                sqlCommand.Parameters.AddWithValue("@CPF", funcionario.CPF);
                sqlCommand.Parameters.AddWithValue("@EstadoCivil", funcionario.Estado_Civil);
                sqlCommand.Parameters.AddWithValue("@CarteiraTrabalho", funcionario.Carteira_Trabalho);
                sqlCommand.Parameters.AddWithValue("@ExpedicaoCT", funcionario.Expedicao_CT);
                sqlCommand.Parameters.AddWithValue("@Nacionalidade", funcionario.Nacionalidade);
                sqlCommand.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                sqlCommand.Parameters.AddWithValue("@Turno", funcionario.Turno);
                sqlCommand.Parameters.AddWithValue("@Salario", funcionario.Salario);
                sqlCommand.Parameters.AddWithValue("@Dependentes", funcionario.Dependentes);
                sqlCommand.Parameters.AddWithValue("@HorasDiarias", funcionario.Horas_Diarias);
                sqlCommand.Parameters.AddWithValue("@TipoContrato", funcionario.Tipo_Contrato);
                sqlCommand.Parameters.AddWithValue("@Imagem", funcionario.Imagem);

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

        public List<Funcionario> Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            List<Funcionario> funcionarios = new List<Funcionario>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Pessoa inner join Funcionario on " +
                "CodPessoa = CodFuncionario;", sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    funcionario.Nome = sqlDataReader[1].ToString();
                    funcionario.Endereco = sqlDataReader[2].ToString();
                    funcionario.Numero = Convert.ToInt32(sqlDataReader[3]);
                    funcionario.Complemento = sqlDataReader[4].ToString();
                    funcionario.Bairro = sqlDataReader[5].ToString();
                    funcionario.Cidade = sqlDataReader[6].ToString();
                    funcionario.UF = sqlDataReader[7].ToString();
                    funcionario.CEP = sqlDataReader[8].ToString();
                    funcionario.Celular = sqlDataReader[9].ToString();
                    funcionario.Telefone = sqlDataReader[10].ToString();
                    funcionario.Email = sqlDataReader[11].ToString();
                    funcionario.Site = sqlDataReader[12].ToString();
                    funcionario.Facebook = sqlDataReader[13].ToString();
                    funcionario.DataAtualizacao = sqlDataReader[14].ToString();
                    funcionario.Sexo = sqlDataReader[16].ToString();
                    funcionario.Nascimento = Convert.ToDateTime(sqlDataReader[17]);
                    funcionario.RG = sqlDataReader[18].ToString();
                    funcionario.CPF = sqlDataReader[19].ToString();
                    funcionario.Estado_Civil = sqlDataReader[20].ToString();
                    funcionario.Carteira_Trabalho = sqlDataReader[21].ToString();
                    funcionario.Expedicao_CT = Convert.ToDateTime(sqlDataReader[22]);
                    funcionario.Nacionalidade = sqlDataReader[23].ToString();
                    funcionario.Cargo = sqlDataReader[24].ToString();
                    funcionario.Turno = sqlDataReader[25].ToString();
                    funcionario.Salario = sqlDataReader[26].ToString();
                    funcionario.Dependentes = Convert.ToInt32(sqlDataReader[27]);
                    funcionario.Horas_Diarias = sqlDataReader[28].ToString();
                    funcionario.Tipo_Contrato = sqlDataReader[29].ToString();
                    funcionario.Imagem = sqlDataReader[30].ToString(); 
                                        
                    funcionarios.Add(funcionario);
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
            return funcionarios;
        }

        public void Alterar(Funcionario novoFuncionario, int atualCodigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Pessoa set Nome = '"+ novoFuncionario.Nome + "', Endereco = '" + novoFuncionario.Endereco + 
                    "', Numero = '"+ novoFuncionario.Numero + "', Complemento = '" + novoFuncionario.Complemento + "', Bairro = '" + novoFuncionario.Bairro + 
                    "', Cidade = '" + novoFuncionario.Cidade + "', UF = '" + novoFuncionario.UF + "', CEP = '" + novoFuncionario.CEP + 
                    "', Celular = '" + novoFuncionario.Celular + "', Telefone = '" + novoFuncionario.Telefone + "', Email = '" +
                    novoFuncionario.Email + "', Site = '" + novoFuncionario.Site + "', Facebook = '" + novoFuncionario.Facebook +
                    "', DataAtualizacao = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() +
                    "' where CodPessoa = '" + atualCodigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("update Funcionario set Sexo = '" + novoFuncionario.Sexo + "', Nascimento = '" +
                    novoFuncionario.Nascimento + "', RG = '" + novoFuncionario.RG + "', CPF = '" + novoFuncionario.CPF + "', EstadoCivil = '" +
                    novoFuncionario.Estado_Civil + "', CarteiraTrabalho = '" + novoFuncionario.Carteira_Trabalho + "', ExpedicaoCT = '" +
                    novoFuncionario.Expedicao_CT + "', Nacionalidade = '" + novoFuncionario.Nacionalidade + "', Cargo = '" + 
                    novoFuncionario.Cargo + "', Turno = '" + novoFuncionario.Turno + "', Salario = '" + novoFuncionario.Salario + "', Dependentes = '" +
                    novoFuncionario.Dependentes + "', HorasDiarias = '" + novoFuncionario.Horas_Diarias + "', TipoContrato = '" +
                    novoFuncionario.Tipo_Contrato + "', Imagem = '" + novoFuncionario.Imagem + "' where CodFuncionario = '" + atualCodigo + "';", sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alterar de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                sqlCommand = new SqlCommand("delete Funcionario where CodFuncionario = '" + codigo + "';", sqlConnection);
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
                MessageBox.Show(ex.Message, "Deletar Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<Funcionario> Filtrar(string tipoFiltro, string filtro)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            
            SqlCommand sqlCommand = new SqlCommand("select * from Pessoa inner join Funcionario on CodPessoa = CodFuncionario where " +
                tipoFiltro + " like '%" + filtro + "%';", sqlConnection);

            List<Funcionario> funcionarios = new List<Funcionario>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    funcionario.Nome = sqlDataReader[1].ToString();
                    funcionario.Endereco = sqlDataReader[2].ToString();
                    funcionario.Numero = Convert.ToInt32(sqlDataReader[3]);
                    funcionario.Complemento = sqlDataReader[4].ToString();
                    funcionario.Bairro = sqlDataReader[5].ToString();
                    funcionario.Cidade = sqlDataReader[6].ToString();
                    funcionario.UF = sqlDataReader[7].ToString();
                    funcionario.CEP = sqlDataReader[8].ToString();
                    funcionario.Celular = sqlDataReader[9].ToString();
                    funcionario.Telefone = sqlDataReader[10].ToString();
                    funcionario.Email = sqlDataReader[11].ToString();
                    funcionario.Site = sqlDataReader[12].ToString();
                    funcionario.Facebook = sqlDataReader[13].ToString();
                    funcionario.DataAtualizacao = sqlDataReader[14].ToString();
                    funcionario.Sexo = sqlDataReader[16].ToString();
                    funcionario.Nascimento = Convert.ToDateTime(sqlDataReader[17]);
                    funcionario.RG = sqlDataReader[18].ToString();
                    funcionario.CPF = sqlDataReader[19].ToString();
                    funcionario.Estado_Civil = sqlDataReader[20].ToString();
                    funcionario.Carteira_Trabalho = sqlDataReader[21].ToString();
                    funcionario.Expedicao_CT = Convert.ToDateTime(sqlDataReader[22]);
                    funcionario.Nacionalidade = sqlDataReader[23].ToString();
                    funcionario.Cargo = sqlDataReader[24].ToString();
                    funcionario.Turno = sqlDataReader[25].ToString();
                    funcionario.Salario = sqlDataReader[26].ToString();
                    funcionario.Dependentes = Convert.ToInt32(sqlDataReader[27]);
                    funcionario.Horas_Diarias = sqlDataReader[28].ToString();
                    funcionario.Tipo_Contrato = sqlDataReader[29].ToString();
                    funcionario.Imagem = sqlDataReader[30].ToString();

                    funcionarios.Add(funcionario);
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
            return funcionarios;
        }
    }
}
