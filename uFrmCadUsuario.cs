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
    public partial class uFrmCadUsuario : Form
    {
        public uFrmCadUsuario()
        {
            InitializeComponent();
        }

        private void txCadUsuario_Enter(object sender, EventArgs e)
        {
            txCadUsuario.BackColor = Color.AliceBlue;
        }

        private void txCadUsuario_Leave(object sender, EventArgs e)
        {
            txCadUsuario.BackColor = Color.White;
        }

        private void txCadSenha_Enter(object sender, EventArgs e)
        {
            txCadSenha.BackColor = Color.AliceBlue;
        }

        private void txCadSenha_Leave(object sender, EventArgs e)
        {
            txCadSenha.BackColor = Color.White;
        }
        private void txCadEmail_Enter(object sender, EventArgs e)
        {
            txCadEmail.BackColor = Color.AliceBlue;
        }

        private void txCadEmail_Leave(object sender, EventArgs e)
        {
            txCadEmail.BackColor = Color.White;
        }

        private void lbCadUsuarioCancelar_MouseEnter(object sender, EventArgs e)
        {
            lbCadUsuarioCancelar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadUsuarioCancelar_MouseLeave(object sender, EventArgs e)
        {
            lbCadUsuarioCancelar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbCadUsuarioSalvar_MouseEnter(object sender, EventArgs e)
        {
            lbCadUsuarioSalvar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadUsuarioSalvar_MouseLeave(object sender, EventArgs e)
        {
            lbCadUsuarioSalvar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbCadRevelaSenha_Enter(object sender, EventArgs e)
        {
            lbCadRevelaSenha.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadRevelaSenha_Leave(object sender, EventArgs e)
        {
            lbCadRevelaSenha.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbCadRevelaSenha_Click(object sender, EventArgs e)
        {
            if (txCadSenha.UseSystemPasswordChar)
            {
                txCadSenha.UseSystemPasswordChar = false;
                lbCadRevelaSenha.ForeColor = Color.DarkRed;
            }
            else
            {
                txCadSenha.UseSystemPasswordChar = true;
                lbCadRevelaSenha.ForeColor = Color.DarkBlue;
            }
        }

        private void lbCadUsuarioCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbCadUsuarioSalvar_Click(object sender, EventArgs e)
        {

            string usuario = txCadUsuario.Text.Trim().ToUpper();
            string senha = txCadSenha.Text.Trim();
            string email = txCadEmail.Text.Trim().ToLower();

            string hash = GeraHash.GerarHashSHA256(senha);

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor informe todos os campos do cadastro de usuario.", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCadUsuario.Focus();
                return;
            }

            if (!StatusConexao.VerificarConexaoAtiva())
            {
                MessageBox.Show("Sem conexão!! Conecte novamente no banco de dados.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (VerificaCadastro.VerificaEmail(email))
            {
                MessageBox.Show("Email já cadastrado, por favor informe outro email.", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCadEmail.Focus();
                return;
            }

            if (VerificaCadastro.VerificaUsuario(usuario))
            {
                MessageBox.Show("Usuario já cadastrado, por favor informe outro usuario.", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCadUsuario.Focus();
                return;
            }

            try
            {
                string sql = "INSERT INTO USUARIO (nome_usuario, senha, email) " +
                                "VALUES (@usuario, @senha, @email)";

                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", hash);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();

                DialogResult resultado = MessageBox.Show("Usuario cadastrado com sucesso! \n" + "Deseja Cadastrar um novo Usuario?", "Sucesso",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    txCadUsuario.Clear();
                    txCadSenha.Clear();
                    txCadEmail.Clear();
                    txCadUsuario.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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

      

        
    }
}
