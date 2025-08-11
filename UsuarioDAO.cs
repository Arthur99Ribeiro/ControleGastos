using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos
{
    public class UsuarioDAO
    {      
        public Usuario BuscarUsuarioPorId(int id)
        {
            Usuario usuario = null;
            MySqlDataReader reader = null;

            if (!StatusConexao.VerificarConexaoAtiva())
                throw new InvalidOperationException("Sem conexão com banco de dados.");

            try
            {
                string sql = "SELECT ID, NOME_USUARIO, SENHA, EMAIL, QTD_ERRO_SENHA " +
                                "FROM USUARIO " +
                                "WHERE ID = @id";

                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@id", id);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario(
                        reader.GetInt32(0),                             // Lê o id_usuario
                        reader.GetString(1),                            // Lê o nome_usuario
                        reader.GetString(2),                            // Lê a senha
                        reader.GetString(3),                            // Lê o email
                        reader.IsDBNull(4) ? 0 : reader.GetInt32(4)     // Lê a quantidade de erros de login (caso nullo, define como 0)
                    );
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.",
                                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar reconectar ao banco de dados:\n" + ex.Message,
                                "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader.Close();
            }

            return usuario;
        }
    }
}
