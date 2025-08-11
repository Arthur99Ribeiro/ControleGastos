using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos
{
    internal class UsuarioLogado
    {
        public static class SessaoUsuario
        {
            public static string Nome { get; set; } = string.Empty;
            public static int Id { get; set; } = 0;
            public static MySqlConnection Conexao { get; set; }

            // Se quiser mais infos, adicione aqui
            public static void Limpar()
            {
                Nome = string.Empty;
                Id = 0;
            }
        }
    }
}
