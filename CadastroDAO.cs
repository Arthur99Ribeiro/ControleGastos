using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ControleGastos
{
    public class CadastroDAO
    {
        public void InserirCadastro(Cadastro.Pessoa pessoa, Cadastro.Endereco endereco)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlTransaction transacao = StatusConexao.Conexao.BeginTransaction())
            {
                try
                {
                    string sqlPessoa = @"INSERT INTO PESSOA (NOME, CPF, DTA_NASCIMENTO, TELEFONE) 
                                         VALUES (@nome, @cpf, @dta_nascimento, @telefone);
                                         SELECT LAST_INSERT_ID();";

                    MySqlCommand cmdPessoa = new MySqlCommand(sqlPessoa, StatusConexao.Conexao, transacao);
                    cmdPessoa.Parameters.AddWithValue("@nome", pessoa.Nome);
                    cmdPessoa.Parameters.AddWithValue("@cpf", pessoa.CPF);
                    cmdPessoa.Parameters.AddWithValue("@dta_nascimento", pessoa.DtaNascimento);
                    cmdPessoa.Parameters.AddWithValue("@telefone", pessoa.Telefone);

                    int idPessoa = Convert.ToInt32(cmdPessoa.ExecuteScalar());

                    string sqlEndereco = @"INSERT INTO ENDERECO (ID_PESSOA, RUA, NUMERO, COMPLEMENTO, CIDADE, UF, CEP)
                                           VALUES (@id_pessoa, @rua, @numero, @complemento, @cidade, @uf, @cep);";

                    MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, StatusConexao.Conexao, transacao);
                    cmdEndereco.Parameters.AddWithValue("@id_pessoa", idPessoa);
                    cmdEndereco.Parameters.AddWithValue("@rua", endereco.Rua);
                    cmdEndereco.Parameters.AddWithValue("@numero", endereco.Numero);
                    cmdEndereco.Parameters.AddWithValue("@complemento", endereco.Complemento);
                    cmdEndereco.Parameters.AddWithValue("@cidade", endereco.Cidade);
                    cmdEndereco.Parameters.AddWithValue("@uf", endereco.UF);
                    cmdEndereco.Parameters.AddWithValue("@cep", endereco.CEP);

                    cmdEndereco.ExecuteNonQuery();

                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao inserir cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SalvarCadastro(Cadastro.Pessoa pessoa, Cadastro.Endereco endereco)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlTransaction transacao = StatusConexao.Conexao.BeginTransaction())
            {
                try
                {
                    string sqlPessoa = @"UPDATE PESSOA SET NOME = @nome, CPF = @cpf, 
                                         DTA_NASCIMENTO = @dta_nascimento, TELEFONE = @telefone 
                                         WHERE ID = @id;";

                    var cmdPessoa = new MySqlCommand(sqlPessoa, StatusConexao.Conexao, transacao);
                    cmdPessoa.Parameters.AddWithValue("@id", pessoa.Id);
                    cmdPessoa.Parameters.AddWithValue("@nome", pessoa.Nome);
                    cmdPessoa.Parameters.AddWithValue("@cpf", pessoa.CPF);
                    cmdPessoa.Parameters.AddWithValue("@dta_nascimento", pessoa.DtaNascimento);
                    cmdPessoa.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                    cmdPessoa.ExecuteNonQuery();

                    string sqlEndereco = @"UPDATE ENDERECO SET RUA = @rua, NUMERO = @numero, COMPLEMENTO = @complemento, 
                                           CIDADE = @cidade, UF = @uf, CEP = @cep 
                                           WHERE ID_PESSOA = @id_pessoa;";

                    var cmdEndereco = new MySqlCommand(sqlEndereco, StatusConexao.Conexao, transacao);
                    cmdEndereco.Parameters.AddWithValue("@id_pessoa", pessoa.Id);
                    cmdEndereco.Parameters.AddWithValue("@rua", endereco.Rua);
                    cmdEndereco.Parameters.AddWithValue("@numero", endereco.Numero);
                    cmdEndereco.Parameters.AddWithValue("@complemento", endereco.Complemento);
                    cmdEndereco.Parameters.AddWithValue("@cidade", endereco.Cidade);
                    cmdEndereco.Parameters.AddWithValue("@uf", endereco.UF);
                    cmdEndereco.Parameters.AddWithValue("@cep", endereco.CEP);
                    cmdEndereco.ExecuteNonQuery();

                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao atualizar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ExcluirCadastro(int idPessoa)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlTransaction transacao = StatusConexao.Conexao.BeginTransaction())
            {
                try
                {
                    var cmdEndereco = new MySqlCommand("DELETE FROM ENDERECO WHERE ID_PESSOA = @id;", StatusConexao.Conexao, transacao);
                    cmdEndereco.Parameters.AddWithValue("@id", idPessoa);
                    cmdEndereco.ExecuteNonQuery();

                    var cmdPessoa = new MySqlCommand("DELETE FROM PESSOA WHERE ID = @id;", StatusConexao.Conexao, transacao);
                    cmdPessoa.Parameters.AddWithValue("@id", idPessoa);
                    cmdPessoa.ExecuteNonQuery();

                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao excluir cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public (Cadastro.Pessoa, Cadastro.Endereco) BuscarPorCPF(string cpf)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return(null, null);
            }

            try
            {
                var sql = @"SELECT p.ID, p.NOME, p.CPF, p.DTA_NASCIMENTO, p.TELEFONE,
                                   e.ID, e.RUA, e.NUMERO, e.COMPLEMENTO, e.CIDADE, e.UF, e.CEP
                            FROM PESSOA p
                            LEFT JOIN ENDERECO e ON p.ID = e.ID_PESSOA
                            WHERE p.CPF = @cpf;";

                using (var cmd = new MySqlCommand(sql, StatusConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var pessoa = new Cadastro.Pessoa(
                                id: reader.GetInt32("id"),
                                nome: reader.GetString("nome"),
                                cpf: reader.GetString("cpf"),
                                dtaNascimento: reader.GetDateTime("dta_nascimento"),
                                telefone: reader.GetString("telefone")
                            );

                            var endereco = new Cadastro.Endereco
                            {
                                Id = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                                IdPessoa = pessoa.Id,
                                Rua = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                Bairro = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                Numero = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                Complemento = reader.IsDBNull(8) ? "" : reader.GetString(8),
                                Cidade = reader.IsDBNull(9) ? "" : reader.GetString(9),
                                UF = reader.IsDBNull(10) ? "" : reader.GetString(10),
                                CEP = reader.IsDBNull(11) ? "" : reader.GetString(11)
                            };

                            return (pessoa, endereco);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (null, null);
        }

        public (Cadastro.Pessoa, Cadastro.Endereco) BuscarPorNome(string nome)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }

            try
            {
                var sql = @"SELECT p.ID, p.NOME, p.CPF, p.DTA_NASCIMENTO, p.TELEFONE,
                                   e.ID, e.RUA, e.NUMERO, e.COMPLEMENTO, e.CIDADE, e.UF, e.CEP
                            FROM PESSOA p
                            LEFT JOIN ENDERECO e ON p.ID = e.ID_PESSOA
                            WHERE p.NOME LIKE @nome;";

                using (var cmd = new MySqlCommand(sql, StatusConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var pessoa = new Cadastro.Pessoa(
                                id: reader.GetInt32("id"),
                                nome: reader.GetString("nome"),
                                cpf: reader.GetString("cpf"),
                                dtaNascimento: reader.GetDateTime("dta_nascimento"),
                                telefone: reader.GetString("telefone")
                            );

                            var endereco = new Cadastro.Endereco
                            {
                                Id = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                                IdPessoa = pessoa.Id,
                                Rua = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                Bairro = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                Numero = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                Complemento = reader.IsDBNull(8) ? "" : reader.GetString(8),
                                Cidade = reader.IsDBNull(9) ? "" : reader.GetString(9),
                                UF = reader.IsDBNull(10) ? "" : reader.GetString(10),
                                CEP = reader.IsDBNull(11) ? "" : reader.GetString(11)
                            };

                            return (pessoa, endereco);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (null, null);
        }

        public (Cadastro.Pessoa, Cadastro.Endereco) BuscarTodos()
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }

            try
            {
                var sql = @"SELECT p.ID, p.NOME, p.CPF, p.DTA_NASCIMENTO, p.TELEFONE,
                                   e.ID, e.RUA, e.NUMERO, e.COMPLEMENTO, e.CIDADE, e.UF, e.CEP
                            FROM PESSOA p
                            LEFT JOIN ENDERECO e ON p.ID = e.ID_PESSOA";

                using (var cmd = new MySqlCommand(sql, StatusConexao.Conexao))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var pessoa = new Cadastro.Pessoa(
                                id: reader.GetInt32("id"),
                                nome: reader.GetString("nome"),
                                cpf: reader.GetString("cpf"),
                                dtaNascimento: reader.GetDateTime("dta_nascimento"),
                                telefone: reader.GetString("telefone")
                            );

                            var endereco = new Cadastro.Endereco
                            {
                                Id = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                                IdPessoa = pessoa.Id,
                                Rua = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                Bairro = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                Numero = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                Complemento = reader.IsDBNull(8) ? "" : reader.GetString(8),
                                Cidade = reader.IsDBNull(9) ? "" : reader.GetString(9),
                                UF = reader.IsDBNull(10) ? "" : reader.GetString(10),
                                CEP = reader.IsDBNull(11) ? "" : reader.GetString(11)
                            };

                            return (pessoa, endereco);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (null, null);
        }
    }
}