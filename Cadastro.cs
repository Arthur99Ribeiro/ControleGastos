using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos
{
    public class Cadastro
    {
        public class Pessoa
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string CPF { get; set; }
            public DateTime DtaNascimento { get; set; }
            public string Telefone { get; set; }

            public Pessoa (int id, string nome, string cpf, DateTime dtaNascimento, string telefone)
            {
                Id = id;
                Nome = nome;
                CPF = cpf;
                DtaNascimento = dtaNascimento;
                Telefone = telefone;
            }
        }

        public class Endereco
        {
            public int Id { get; set; }
            public int IdPessoa { get; set; }
            public string Rua { get; set; }
            public string Bairro { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string CEP { get; set; }

            public Endereco() { }
            public Endereco( string rua, string bairro, string numero, string complemento, string cidade, string uf, string cep)
            {
 //               Id = id;
 //               IdPessoa = idPessoa;
                Rua = rua;
                Bairro = bairro;
                Numero = numero;
                Complemento = complemento;
                Cidade = cidade;
                UF = uf;
                CEP = cep;
            }
        }

     
    }
}
