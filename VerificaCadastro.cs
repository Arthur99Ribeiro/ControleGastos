using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos
{
    internal class VerificaCadastro
    {

        public static bool VerificaEmail(string email)
        {
            if(!StatusConexao.VerificarConexaoAtiva())
                throw new InvalidOperationException("Sem conexão com banco de dados.");

            string sql = "SELECT COUNT(*) FROM USUARIO WHERE email = @email";
            MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
            cmd.Parameters.AddWithValue("@email", email);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
        

        public static bool VerificaUsuario(string usuario)
        {
            if (!StatusConexao.VerificarConexaoAtiva())
                throw new InvalidOperationException("Sem conexão com banco de dados.");

            string sql = "SELECT COUNT(*) FROM USUARIO WHERE nome_usuario = @usuario";
            MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
            cmd.Parameters.AddWithValue("@usuario", usuario);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
            
        }
    }
}
