using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class AgendamentoDAL
    {
        private ConexaoDB conexaoDB;

        public AgendamentoDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public void Inserir(Agendamento agendamento)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            try 
            { 
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("insert into Agendamento values (@CodServico, @CodCliente, @NomeCliente, @TipoServico, @Descricao, @Data, @Horario, @Status)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CodCliente", agendamento.CodCliente);
                sqlCommand.Parameters.AddWithValue("@NomeCliente", agendamento.Cliente);
                sqlCommand.Parameters.AddWithValue("@CodServico", agendamento.CodServico);
                sqlCommand.Parameters.AddWithValue("@TipoServico", agendamento.TipoServico);
                sqlCommand.Parameters.AddWithValue("@Descricao", agendamento.Descricao);
                sqlCommand.Parameters.AddWithValue("@Data", agendamento.Data);
                sqlCommand.Parameters.AddWithValue("@Horario", agendamento.Horario);
                sqlCommand.Parameters.AddWithValue("@Status", agendamento.Status);
                sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException ex)
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

        public List<Agendamento> Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Agendamento", sqlConnection);

            List<Agendamento> agendamentos = new List<Agendamento>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Agendamento agendamento = new Agendamento();

                    agendamento.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    agendamento.CodServico = Convert.ToInt32(sqlDataReader[1]);
                    agendamento.CodCliente = Convert.ToInt32(sqlDataReader[2]);
                    agendamento.Cliente = sqlDataReader[3].ToString();
                    agendamento.TipoServico = sqlDataReader[4].ToString();
                    agendamento.Descricao = sqlDataReader[5].ToString();
                    agendamento.Data = Convert.ToDateTime(sqlDataReader[6]);
                    agendamento.Horario = sqlDataReader[7].ToString();
                    agendamento.Status = sqlDataReader[8].ToString();

                    agendamentos.Add(agendamento);
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
            
            return agendamentos;
        }

        public void Alterar(Agendamento novoaAgendamento, int atualCodigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Agendamento set CodServico = '" + novoaAgendamento.CodServico +
                    "', CodCliente = '" + novoaAgendamento.CodCliente + "', NomeCliente = '" + novoaAgendamento.Cliente +
                    "', TipoServico = '" + novoaAgendamento.TipoServico + "', Descricao = '" + novoaAgendamento.Descricao +
                    "',  Data ='" + novoaAgendamento.Data + "', Horario = '" + novoaAgendamento.Horario + "', Status = '" +
                    novoaAgendamento.Status + "' where CodAgendamento = '" + atualCodigo + "';", sqlConnection);
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

        public void AlterarStatus(int atualCodigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Agendamento set Status = 'Pendente' where CodAgendamento = '" + atualCodigo + "';", sqlConnection);
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

                sqlCommand = new SqlCommand("delete Agendamento where CodAgendamento = '" + codigo + "';", sqlConnection);
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

        public List<Agendamento> Filtrar(string tipoFiltro, string filtro)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Agendamento where " + tipoFiltro + 
                " like '%" + filtro + "%';", sqlConnection);

            List<Agendamento> agendamentos = new List<Agendamento>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Agendamento agendamento = new Agendamento();

                    agendamento.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    agendamento.CodServico = Convert.ToInt32(sqlDataReader[1]);
                    agendamento.CodCliente = Convert.ToInt32(sqlDataReader[2]);
                    agendamento.Cliente = sqlDataReader[3].ToString();
                    agendamento.TipoServico = sqlDataReader[4].ToString();
                    agendamento.Descricao = sqlDataReader[5].ToString();
                    agendamento.Data = Convert.ToDateTime(sqlDataReader[6]);
                    agendamento.Horario = sqlDataReader[7].ToString();
                    agendamento.Status = sqlDataReader[8].ToString();

                    agendamentos.Add(agendamento);
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
            return agendamentos;
        }
    }
}
