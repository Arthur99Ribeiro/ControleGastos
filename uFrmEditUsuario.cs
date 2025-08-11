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

namespace ControleGastos
{
    public partial class uFrmEditUsuario : Form
    {
        private Usuario usuario;
        public uFrmEditUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            txEditUsuario.Focus();

            txEditUsuario.Text = usuario.Nome;
            txEditSenha.Text = String.Empty;
            txEditEmail.Text = usuario.Email;
            txQtdErroLogin.Text = Convert.ToString(usuario.ErrosLogin);
        }

        private void txEditUsuario_Enter(object sender, EventArgs e)
        {
            txEditUsuario.BackColor = Color.AliceBlue;
        }

        private void txEditUsuario_Leave(object sender, EventArgs e)
        {
            txEditUsuario.BackColor = Color.White;
        }

        private void lbEditSalvar_Enter(object sender, EventArgs e)
        {
            lbEditSalvar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbEditSalvar_Leave(object sender, EventArgs e)
        {
            lbEditSalvar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbEditCancelar_Enter(object sender, EventArgs e)
        {
            lbEditCancelar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbEditCancelar_Leave(object sender, EventArgs e)
        {
            lbEditCancelar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void txEditSenha_Enter(object sender, EventArgs e)
        {
            txEditSenha.BackColor = Color.AliceBlue;
        }

        private void txEditSenha_Leave(object sender, EventArgs e)
        {
            txEditSenha.BackColor = Color.White;
        }

        private void txEditEmail_Enter(object sender, EventArgs e)
        {
            txEditEmail.BackColor = Color.AliceBlue;
        }

        private void txEditEmail_Leave(object sender, EventArgs e)
        {
            txEditEmail.BackColor = Color.White;
        }

        private void txQtdErroLogin_Enter(object sender, EventArgs e)
        {
            txQtdErroLogin.BackColor = Color.AliceBlue;
        }

        private void txQtdErroLogin_Leave(object sender, EventArgs e)
        {
            txQtdErroLogin.BackColor = Color.White;
        }

        private void lbEditRevalaSenha_Enter(object sender, EventArgs e)
        {
            lbEditRevalaSenha.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbEditRevalaSenha_Leave(object sender, EventArgs e)
        {
            lbEditRevalaSenha.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbEditRevalaSenha_Click(object sender, EventArgs e)
        {
            if (txEditSenha.UseSystemPasswordChar)
            {
                txEditSenha.UseSystemPasswordChar = false;
                lbEditRevalaSenha.ForeColor = Color.DarkRed;
            }
            else
            {
                txEditSenha.UseSystemPasswordChar = true;
                lbEditRevalaSenha.ForeColor = Color.DarkBlue;
            }
        }

        private void lbEditCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbEditSalvar_Click(object sender, EventArgs e)
        {
            int idUsuario = this.usuario.Id;
            string usuario = txEditUsuario.Text.Trim().ToUpper();
            string senha = txEditSenha.Text.Trim();
            string email = txEditEmail.Text.Trim().ToLower();
            string erroLogin = txQtdErroLogin.Text.Trim();
            string hash = GeraHash.GerarHashSHA256(senha);

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor informe todos os campos do cadastro de usuario. \n " +
                                "Caso não for alterar a senha, campo pode ficar vazio", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txEditUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(erroLogin))
            {
                erroLogin = "0"; // Se não informar, assume 0 erros.
            }

            if (!StatusConexao.VerificarConexaoAtiva())
            {
                MessageBox.Show("Sem conexão!! Conecte novamente no banco de dados.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txEditSenha.Text.Trim() == string.Empty)
            {       //update sem alterar a senha.
                try
                {
                    string sql = "UPDATE USUARIO " +
                                 "SET NOME_USUARIO = @usuario, " +
                                 "EMAIL = @email, " +
                                 "QTD_ERRO_SENHA = @erroLogin " +
                                 "WHERE ID = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@erroLogin", erroLogin);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                catch (Exception ex)
                {
                    // Pode registrar ou mostrar o erro
                    MessageBox.Show("Erro ao tentar reconectar ao banco de dados:\n" + ex.Message,
                                    "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {       //update alterando a senha.
                try
                {
                    string sql = "UPDATE USUARIO " +
                                 "SET NOME_USUARIO = @usuario, " +
                                 "SENHA = @senha, " +
                                 "EMAIL = @email, " +
                                 "QTD_ERRO_SENHA = @erroLogin " +
                                 "WHERE ID = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", hash);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@erroLogin", erroLogin);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                catch (Exception ex)
                {
                    // Pode registrar ou mostrar o erro
                    MessageBox.Show("Erro ao tentar reconectar ao banco de dados:\n" + ex.Message,
                                    "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            DialogResult resultado = MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            resultado = DialogResult.OK;
            this.Close();   
        }


    }
}
