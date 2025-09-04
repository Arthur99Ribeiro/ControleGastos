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

        public class TpDespesa
        {
            public int IdTpDespesa { get; set; }
            public string Nome { get; set; }
            public string TpDespesaFixa { get; set; }
            public TpDespesa() { }

            public TpDespesa(int idTpDespesa, string nome, string tpDespesaFixa)
            {
                IdTpDespesa = idTpDespesa;
                Nome = nome;
                TpDespesaFixa = tpDespesaFixa;
            }
        }

        public class TpReceita
        {
            public int IdTpReceita { get; set; }
            public string Nome { get; set; }
            public string TpReceitaFixa { get; set; }
            public TpReceita() { }

            public TpReceita(int idTpReceita, string nome, string tpReceitaFixa)
            {
                IdTpReceita = idTpReceita;
                Nome = nome;
                TpReceitaFixa = tpReceitaFixa;
            }
        }

        public class CategoriaDespesa
        {
            public int IdCategoriaDespesa { get; set; }
            public string Nome { get; set; }
            
            public CategoriaDespesa() { }
            public CategoriaDespesa(int idCategoriaDespesa, string nome)
            {
                IdCategoriaDespesa = idCategoriaDespesa;
                Nome = nome;
            }
        }
    }
}
