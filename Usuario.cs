using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int ErrosLogin { get; set; }

        public Usuario(int id, string nome, string senha, string email, int errosLogin)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Email = email;
            ErrosLogin = errosLogin;
        }
    }
}
