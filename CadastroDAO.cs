using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static ControleGastos.Cadastro;

namespace ControleGastos
{
    public class CadastroDAO
    {
        public void CadPessoaInserirCadastro(Cadastro.Pessoa pessoa, Cadastro.Endereco endereco)
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

        public void CadPessoaSalvarCadastro(Cadastro.Pessoa pessoa, Cadastro.Endereco endereco)
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

        public void CadPessoaExcluirCadastro(int idPessoa)
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

        public (Cadastro.Pessoa, Cadastro.Endereco) CadPessoaBuscarPorCPF(string cpf)
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

        public (Cadastro.Pessoa, Cadastro.Endereco) CadPessoaBuscarPorNome(string nome)
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

        public (Cadastro.Pessoa, Cadastro.Endereco) CadPessoaBuscarTodos()
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

        public void CadTpDespesaExcluirCadastro(int IdTpDespesa)
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
                    string sql = "DELETE FROM TP_DESPESA WHERE ID = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@id", IdTpDespesa);
                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao excluir tipo de despesa: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CadTpDespesaInserirCadastro(Cadastro.TpDespesa tpDespesa)
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
                    string sql = @"INSERT INTO TP_DESPESA (NOME, IND_FIXA) 
                                   VALUES (@nome, @fixa);
                                   SELECT LAST_INSERT_ID()";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@nome", tpDespesa.Nome);
                    cmd.Parameters.AddWithValue("@fixa", tpDespesa.TpDespesaFixa);

                    int idTpDespesa = Convert.ToInt32(cmd.ExecuteScalar());
                    tpDespesa.IdTpDespesa = idTpDespesa;

                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao inserir tipo de despesa: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Cadastro.TpDespesa CadTpDespesaPesquisarPorNome(string nome)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string sql = @"SELECT ID, NOME, IND_FIXA FROM TP_DESPESA WHERE NOME LIKE @nome;";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tpDespesa = new Cadastro.TpDespesa
                        {
                            IdTpDespesa = reader.GetInt32("ID"),
                            Nome = reader.GetString("NOME"),
                            TpDespesaFixa = reader.GetString("IND_FIXA")
                        };
                        
                        return tpDespesa;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo de despesa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public Cadastro.TpDespesa CadTpDespesaPesquisarPorId(int idTpDespesa)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string sql = @"SELECT ID, NOME, IND_FIXA FROM TP_DESPESA WHERE ID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@id", idTpDespesa);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tpDespesa = new Cadastro.TpDespesa
                        {
                            IdTpDespesa = reader.GetInt32("ID"),
                            Nome = reader.GetString("NOME"),
                            TpDespesaFixa = reader.GetString("IND_FIXA")
                        };
                        return tpDespesa;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo de despesa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void CadTpDespesaSalvarCadastro(Cadastro.TpDespesa tpDespesa)
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
                    string sql = @"UPDATE TP_DESPESA SET NOME = @nome, IND_FIXA = @fixa 
                                   WHERE ID = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@id", tpDespesa.IdTpDespesa);
                    cmd.Parameters.AddWithValue("@nome", tpDespesa.Nome);
                    cmd.Parameters.AddWithValue("@fixa", tpDespesa.TpDespesaFixa);
                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao salvar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void CadTpReceitaExcluirCadastro(int IdTpReceita)
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
                    string sql = "DELETE FROM TP_RECEITA WHERE ID = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@id", IdTpReceita);
                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao excluir tipo de receita: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CadTpReceitaInserirCadastro(Cadastro.TpReceita tpReceita)
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
                    string sql = @"INSERT INTO TP_RECEITA (NOME, IND_FIXA) 
                                   VALUES (@nome, @fixa);
                                   SELECT LAST_INSERT_ID()";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@nome", tpReceita.Nome);
                    cmd.Parameters.AddWithValue("@fixa", tpReceita.TpReceitaFixa);

                    int idTpReceita = Convert.ToInt32(cmd.ExecuteScalar());
                    tpReceita.IdTpReceita = idTpReceita;

                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao inserir tipo de receita: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Cadastro.TpReceita CadTpReceitaPesquisarPorNome(string nome)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string sql = @"SELECT ID, NOME, IND_FIXA FROM TP_RECEITA WHERE NOME LIKE @nome;";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tpReceita = new Cadastro.TpReceita
                        {
                            IdTpReceita = reader.GetInt32("ID"),
                            Nome = reader.GetString("NOME"),
                            TpReceitaFixa = reader.GetString("IND_FIXA")
                        };

                        return tpReceita;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo de receita: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public Cadastro.TpReceita CadTpReceitaPesquisarPorId(int idTpReceita)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string sql = @"SELECT ID, NOME, IND_FIXA FROM TP_RECEITA WHERE ID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@id", idTpReceita);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tpReceita = new Cadastro.TpReceita
                        {
                            IdTpReceita = reader.GetInt32("ID"),
                            Nome = reader.GetString("NOME"),
                            TpReceitaFixa = reader.GetString("IND_FIXA")
                        };
                        return tpReceita;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo de receita: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void CadTpReceitaSalvarCadastro(Cadastro.TpReceita tpReceita)
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
                    string sql = @"UPDATE TP_RECEITA SET NOME = @nome, IND_FIXA = @fixa 
                                   WHERE ID = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@id", tpReceita.IdTpReceita);
                    cmd.Parameters.AddWithValue("@nome", tpReceita.Nome);
                    cmd.Parameters.AddWithValue("@fixa", tpReceita.TpReceitaFixa);
                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao salvar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void CadCategoriaDespesaExcluirCadastro(int IdCategoriaDespesa)
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
                    string sql = "DELETE FROM CATEGORIA_DESPESA WHERE ID = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@id", IdCategoriaDespesa);
                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao excluir tipo de receita: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CadCategoriaDespesaInserirCadastro(Cadastro.CategoriaDespesa categoriaDespesa)
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
                    string sql = @"INSERT INTO CATEGORIA_DESPESA (NOME) 
                                   VALUES (@nome);
                                   SELECT LAST_INSERT_ID()";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@nome", categoriaDespesa.Nome);

                    int idCategoriaDespesa = Convert.ToInt32(cmd.ExecuteScalar());
                    categoriaDespesa.IdCategoriaDespesa = idCategoriaDespesa;

                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao inserir tipo de receita: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Cadastro.CategoriaDespesa CadCategoriaDespesaPesquisarPorNome(string nome)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string sql = @"SELECT ID, NOME FROM CATEGORIA_DESPESA WHERE NOME LIKE @nome;";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriaDespesa = new Cadastro.CategoriaDespesa
                        {
                            IdCategoriaDespesa = reader.GetInt32("ID"),
                            Nome = reader.GetString("NOME"),
                        };

                        return categoriaDespesa;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo de receita: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public Cadastro.CategoriaDespesa CadCategoriaDespesaPesquisarPorId(int idCategoriaDespesa)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string sql = @"SELECT ID, NOME FROM CATEGORIA_DESPESA WHERE ID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@id", idCategoriaDespesa);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriaDespesa = new Cadastro.CategoriaDespesa
                        {
                            IdCategoriaDespesa = reader.GetInt32("ID"),
                            Nome = reader.GetString("NOME")
                        };
                        return categoriaDespesa;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo de receita: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void CadCategoriaDespesaSalvarCadastro(Cadastro.CategoriaDespesa categoriaDespesa)
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
                    string sql = @"UPDATE CATEGORIA_DESPESA SET NOME = @nome
                                   WHERE ID = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@id", categoriaDespesa.IdCategoriaDespesa);
                    cmd.Parameters.AddWithValue("@nome", categoriaDespesa.Nome);
                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao salvar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void CadReceitaExcluirCadastro(int IdCadReceita)
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
                    string sql = "DELETE FROM RECEITA WHERE ID = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@id", IdCadReceita);
                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao excluir receita: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CadReceitaInserirCadastro(Cadastro.CadastroReceita cadastroReceita)
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
                    string sql = @"INSERT INTO RECEITA (NOME, ID_TP_RECEITA, IND_RECORRENTE) 
                                   VALUES (@nome, @id_tp_receita, @ind_recorrente);
                                   SELECT LAST_INSERT_ID()";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@nome", cadastroReceita.Nome);
                    cmd.Parameters.AddWithValue("@id_tp_receita", cadastroReceita.IdTpReceita);
                    cmd.Parameters.AddWithValue("@ind_recorrente", cadastroReceita.ReceitaRecorrente);

                    int idCadReceita = Convert.ToInt32(cmd.ExecuteScalar());
                    cadastroReceita.IdCadReceita = idCadReceita;

                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao inserir receita: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Cadastro.CadastroReceita CadReceitaPesquisarPorNome(string nome)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string sql = @"SELECT ID, NOME, ID_TP_RECEITA, IND_RECORRENTE FROM RECEITA WHERE NOME LIKE @nome;";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cadReceita = new Cadastro.CadastroReceita
                        {
                            IdCadReceita = reader.GetInt32("ID"),
                            Nome = reader.GetString("NOME"),
                            IdTpReceita = reader.GetInt32("ID_TP_RECEITA"),
                            ReceitaRecorrente = reader.GetString("IND_RECORRENTE")
                        };

                        return cadReceita;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar receita: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public Cadastro.CadastroReceita CadReceitaPesquisarPorId(int idCadReceita)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Não há conexão ativa com o banco de dados.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string sql = @"SELECT ID, NOME, ID_TP_RECEITA, IND_RECORRENTE FROM RECEITA WHERE ID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@id", idCadReceita);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cadReceita = new Cadastro.CadastroReceita
                        {
                            IdCadReceita = reader.GetInt32("ID"),
                            Nome = reader.GetString("NOME"),
                            IdTpReceita = reader.GetInt32("ID_TP_RECEITA"),
                            ReceitaRecorrente = reader.GetString("IND_RECORRENTE")
                        };
                        return cadReceita;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar receita: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void CadReceitaSalvarCadastro(Cadastro.CadastroReceita cadastroReceita)
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
                    string sql = @"UPDATE RECEITA SET NOME = @nome, ID_TP_RECEITA = @id_tp_receita, IND_RECORRENTE = @ind_recorrente
                                   WHERE ID = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.Parameters.AddWithValue("@id", cadastroReceita.IdCadReceita);
                    cmd.Parameters.AddWithValue("@nome", cadastroReceita.Nome);
                    cmd.Parameters.AddWithValue("@id_tp_receita", cadastroReceita.IdTpReceita);
                    cmd.Parameters.AddWithValue("@ind_recorrente", cadastroReceita.ReceitaRecorrente);
                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao salvar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}