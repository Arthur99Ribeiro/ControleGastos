using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleGastos.UsuarioLogado;


namespace ControleGastos
{
    public partial class uFrmLogin : Form
    {
        public uFrmLogin()
        {
            InitializeComponent();

        }

        private void uFrmLogin_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => cbStrgDB.Focus()));


            string iniPath = @"C:\Dev\Projetos\Controle_Gasto\ConfigDB.ini";

            string pasta = Path.GetDirectoryName(iniPath);
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            if (!File.Exists(iniPath))
                File.Create(iniPath).Close(); // importante: fechar após criar

            IniFile ini = new IniFile(iniPath);

            if (SessaoUsuario.Conexao != null && SessaoUsuario.Conexao.State == ConnectionState.Open)
            {
                CarregarConexoes();
                cbStrgDB.Text = StatusConexao.NomeConexaoAtual;
                lbConectaDB.ForeColor = Color.DarkRed;
                lbConfigDB.Enabled = false;
                cbStrgDB.Enabled = false;
                gbCadastroUsuario.Enabled = true;
                gbLogin.Enabled = true;
                txUsuario.Focus();

            }
            else
            {
                cbStrgDB.Items.Clear();
                cbStrgDB.Items.AddRange(ini.GetSections());
                CarregarConexoes();

                gbCadastroUsuario.Enabled = false;
                gbLogin.Enabled = false;
            }
        }

        private void CarregarConexoes()
        {
            string iniPath = @"C:\Dev\Projetos\Controle_Gasto\ConfigDB.ini";
            if (!File.Exists(iniPath)) return;

            IniFile ini = new IniFile(iniPath);
            List<string> secoes = ini.ReadSections(); // Método que retorna as seções (nomes das conexões)

            cbStrgDB.Items.Clear();
            cbStrgDB.Items.AddRange(secoes.ToArray());
            cbStrgDB.SelectedIndex = -1;
            cbStrgDB.Text = string.Empty;
        }

        private void lbConfigDB_Click(object sender, EventArgs e)
        {

            // Cria e mostra o novo formulário
            uFrmDB form = new uFrmDB();
            form.ConexoesAtualizadas += (s, args) => CarregarConexoes();

            if (cbStrgDB.SelectedItem != null)
            {
                // Passa o nome da conexão selecionada
                form.NomeConexaoSelecionada = cbStrgDB.SelectedItem.ToString();
            }

            if (form.ShowDialog() == DialogResult.OK)
            {
                CarregarConexoes(); // Atualiza os itens do ComboBox
            }

        }

        private void lbConectaDB_Click(object sender, EventArgs e)
        {
            if (StatusConexao.EstaConectado)
            {
                StatusConexao.Desconectar();
                MessageBox.Show("Desconectado do banco de dados!");
                cbStrgDB.SelectedIndex = -1;
                cbStrgDB.Text = String.Empty;
                lbConectaDB.ForeColor = Color.MidnightBlue;
                lbConfigDB.Enabled = true;
                cbStrgDB.Enabled = true;
                gbLogin.Enabled = false;
                gbCadastroUsuario.Enabled = false;
            }
            else
            {

                if (cbStrgDB.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma conexão.");
                    return;
                }

                if (cbStrgDB.SelectedIndex == -1) return;

                string nomeConexao = cbStrgDB.SelectedItem.ToString();
                string iniPath = @"C:\Dev\Projetos\Controle_Gasto\ConfigDB.ini";
                IniFile ini = new IniFile(iniPath);

                string servidor = ini.Read(nomeConexao, "Servidor");
                string porta = ini.Read(nomeConexao, "Porta");
                string banco = ini.Read(nomeConexao, "Banco");
                string usuario = ini.Read(nomeConexao, "Usuario");
                string senha = ini.Read(nomeConexao, "Senha");
                string ssl = ini.Read(nomeConexao, "SSL");

                // Exemplo: conexão com PostgreSQL

                string connStr = $"Server={servidor};Port={porta};Database={banco};Uid={usuario};Pwd={senha};SslMode={(ssl.ToLower() == "true" ? "Required" : "None")}";

                try
                {
                    //using (var conexao = new MySqlConnection(connStr))
                    {
                        StatusConexao.Conectar(nomeConexao, connStr);
                        MessageBox.Show("Conexão bem-sucedida com o banco de dados!");

                        // Aqui você pode abrir o formulário principal ou continuar o fluxo

                        lbConectaDB.ForeColor = Color.DarkRed;
                        lbConfigDB.Enabled = false;
                        cbStrgDB.Enabled = false;
                        gbCadastroUsuario.Enabled = true;
                        gbLogin.Enabled = true;
                        txUsuario.Focus();
                    }
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

        }

        private void lkLbEsqSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uFrmRecuperaUsuarioSenha settingsForm = new uFrmRecuperaUsuarioSenha();
            settingsForm.ShowDialog(); // Use Show() para bloquear o formulário atual
        }

        private void txSenha_Enter(object sender, EventArgs e)
        {
            txSenha.BackColor = Color.AliceBlue;
        }

        private void txSenha_Leave(object sender, EventArgs e)
        {
            txSenha.BackColor = Color.White;
        }

        private void txUsuario_Enter(object sender, EventArgs e)
        {
            txUsuario.BackColor = Color.AliceBlue;
        }

        private void txUsuario_Leave(object sender, EventArgs e)
        {
            txUsuario.BackColor = Color.White;
        }

        private void cbStrgDB_Enter(object sender, EventArgs e)
        {
            cbStrgDB.BackColor = Color.AliceBlue;
        }

        private void cbStrgDB_Leave(object sender, EventArgs e)
        {
            cbStrgDB.BackColor = Color.White;
        }

        private void lbConectaDB_MouseEnter(object sender, EventArgs e)
        {
            lbConectaDB.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbConectaDB_MouseLeave(object sender, EventArgs e)
        {
            lbConectaDB.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbConfigDB_MouseEnter(object sender, EventArgs e)
        {
            lbConfigDB.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbConfigDB_MouseLeave(object sender, EventArgs e)
        {
            lbConfigDB.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txUsuario.Text.Trim().ToUpper();
            string senha = txSenha.Text.Trim();
            string hash = GeraHash.GerarHashSHA256(senha);

            if (!StatusConexao.EstaConectado)  
                return;

            string conexaoSelecionada = cbStrgDB.SelectedItem.ToString();

            if (txUsuario.Text.Trim() == string.Empty || txSenha.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor informe o usuario e senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txUsuario.Focus();
                return;
            }

            try
            {
                string sql = "SELECT id, nome_usuario, senha FROM USUARIO" +
                             " WHERE nome_usuario = @usuario AND senha = @senha";

                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", hash);
                cmd.Prepare();
//                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string usuarioBanco = reader.GetString("nome_usuario");

                    if (usuarioBanco == usuario)
                    {
                        string senhaBanco = reader.GetString("senha");

                        if (senhaBanco == hash)
                        {
                            MessageBox.Show("Bem Vindo " + usuario + "!", "Login realizado com sucesso!",
                                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                            int idUsuario = reader.GetInt32("id");

                            UsuarioLogado.SessaoUsuario.Nome = usuario;
                            UsuarioLogado.SessaoUsuario.Id = (idUsuario);
                            UsuarioLogado.SessaoUsuario.Conexao = StatusConexao.Conexao;

                            uFrmPrincipal form = new uFrmPrincipal();
                            form.Show();
                            this.Hide();
                        }
                    }
                }
                
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txUsuario.Focus();
                }
                
                reader.Close();
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

        private void lbCadUsuario_MouseEnter(object sender, EventArgs e)
        {
            lbCadUsuario.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadUsuario_MouseLeave(object sender, EventArgs e)
        {
            lbCadUsuario.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbCadUsuario_Click(object sender, EventArgs e)
        {
            if (!StatusConexao.EstaConectado)
            {
                MessageBox.Show("Por favor, selecione e conecte em uma conexão antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStrgDB.Focus();
                return;
            }

            uFrmCadUsuario settingsForm = new uFrmCadUsuario();
            settingsForm.ShowDialog(); // Use Show() para bloquear o formulário atual
            txUsuario.Focus();
        }

        private void uFrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            UsuarioLogado.SessaoUsuario.Conexao = StatusConexao.Conexao;
            if (!StatusConexao.EstaConectado)
            {
                Application.Exit();
            }
        }
    }
}
