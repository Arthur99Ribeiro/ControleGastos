using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using MySql.Data.MySqlClient;
 using MySqlX.XDevAPI;
 using System;
 using System.Drawing;

namespace ControleGastos
{
    public static class StatusConexao
    {
        public static MySqlConnection Conexao { get; private set; }
        public static bool EstaConectado => Conexao != null && Conexao.State == System.Data.ConnectionState.Open;
        public static string NomeConexaoAtual { get; private set; } = string.Empty;

        private static string UltimaConexaoUsada = string.Empty;

        // Evento para notificar quando o status da conexão mudar
        public static event EventHandler StatusConexaoAlterada;

        public static void Conectar(string nomeConexao, string stringConexao)
        {
            try
            {
                if (EstaConectado)
                {
                    Desconectar();
                }

                Conexao = new MySqlConnection(stringConexao);
                Conexao.Open();
                NomeConexaoAtual = nomeConexao;
                StatusConexaoAlterada?.Invoke(null, EventArgs.Empty);
                UltimaConexaoUsada = nomeConexao;
            }
            catch
            {
                Conexao = null;
                NomeConexaoAtual = string.Empty;
                StatusConexaoAlterada?.Invoke(null, EventArgs.Empty);
                throw;
            }
        }

        public static void Desconectar()
        {
            if (Conexao != null)
            {
                try
                {
                    Conexao.Close();
                }
                catch { }
                Conexao = null;
                NomeConexaoAtual = string.Empty;
                StatusConexaoAlterada?.Invoke(null, EventArgs.Empty);
            }
        }

        public static bool VerificarConexaoAtiva()
        {
            if (EstaConectado)
                return true;

            if (!string.IsNullOrWhiteSpace(NomeConexaoAtual) && !string.IsNullOrWhiteSpace(UltimaConexaoUsada))
            {
                try
                {
                    Conectar(NomeConexaoAtual, UltimaConexaoUsada);
                    return EstaConectado;
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)    
                {
                    // Pode registrar ou mostrar o erro
                    MessageBox.Show("Erro ao tentar reconectar ao banco de dados:\n" + ex.Message,
                                    "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma conexão foi configurada para reconectar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            return false;
        }
    }
}                                                                                       
