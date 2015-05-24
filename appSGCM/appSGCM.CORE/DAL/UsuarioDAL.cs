using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appSGCM.CORE.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSGCM.CORE.DAL
{
    public class UsuarioDAL
    {
        private ConexaoDB conexaoDB;

        public UsuarioDAL()
        {
            conexaoDB = new ConexaoDB();
        }

        public bool Autenticacao(string user, string pass)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("select * from Usuario where Login = '" + user +
                    "' and Senha = '" + pass + "'", sqlConnection);

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

        public void Inserir(Usuario usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("insert into Usuario values (@CodFuncionario, @Login, @Senha, @Tipo)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CodFuncionario", usuario.CodFuncionario);
                sqlCommand.Parameters.AddWithValue("@Login", usuario.Login);
                sqlCommand.Parameters.AddWithValue("@Senha", usuario.Senha);
                sqlCommand.Parameters.AddWithValue("@Tipo", usuario.Tipo);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Erro Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<Usuario> Selecionar()
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Usuario;", sqlConnection);

            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Usuario usuario = new Usuario();

                    usuario.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    usuario.CodFuncionario = Convert.ToInt32(sqlDataReader[1]);
                    usuario.Login = sqlDataReader[2].ToString();
                    usuario.Senha = sqlDataReader[3].ToString();
                    usuario.Tipo = sqlDataReader[4].ToString();
                    
                    usuarios.Add(usuario);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Conexão SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Selecionar Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
            return usuarios;
        }

        public void Alterar(Usuario novoUsuario, int atualCodigo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);
            SqlCommand sqlCommand;

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("update Usuario set Login = '" + novoUsuario.Login + "', Senha = '" +
                    novoUsuario.Senha + "', Tipo = '" + novoUsuario.Tipo + "', CodFuncionario = '" + novoUsuario.CodFuncionario +
                    "' where CodUsuario = '" + atualCodigo + "';", sqlConnection);
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

                sqlCommand = new SqlCommand("delete Usuario where CodUsuario = '" + codigo + "';", sqlConnection);
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

        public List<Usuario> Filtrar(string tipoFiltro, string filtro)
        {
            SqlConnection sqlConnection = new SqlConnection(conexaoDB.ConnectionString);

            SqlCommand sqlCommand = new SqlCommand("select * from Usuario where " +
                tipoFiltro + " like '%" + filtro + "%';", sqlConnection);


            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Usuario usuario = new Usuario();

                    usuario.Codigo = Convert.ToInt32(sqlDataReader[0]);
                    usuario.CodFuncionario = Convert.ToInt32(sqlDataReader[1]);
                    usuario.Login = sqlDataReader[2].ToString();
                    usuario.Senha = sqlDataReader[3].ToString();
                    usuario.Tipo = sqlDataReader[4].ToString();

                    usuarios.Add(usuario);
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

            return usuarios;
        }
    }
}
