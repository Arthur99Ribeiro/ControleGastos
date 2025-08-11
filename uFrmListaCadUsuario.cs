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
    public partial class uFrmListaCadUsuario : Form
    {
        public uFrmListaCadUsuario()
        {
            InitializeComponent();

            lvCadUsuario.View = View.Details;
            lvCadUsuario.AllowColumnReorder = true;
            lvCadUsuario.FullRowSelect = true;
            lvCadUsuario.GridLines = true;

            lvCadUsuario.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvCadUsuario.Columns.Add("Usuário", 400, HorizontalAlignment.Left);

            carregaUsuario();
        }

        private void lbCadNovoUsuario_MouseEnter(object sender, EventArgs e)
        {
            lbCadNovoUsuario.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadNovoUsuario_MouseLeave(object sender, EventArgs e)
        {
            lbCadNovoUsuario.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbCadEditar_MouseEnter(object sender, EventArgs e)
        {
            lbCadEditar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadEditar_MouseLeave(object sender, EventArgs e)
        {
            lbCadEditar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbCadExcluir_MouseEnter(object sender, EventArgs e)
        {
            lbCadExcluir.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadExcluir_MouseLeave(object sender, EventArgs e)
        {
            lbCadExcluir.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbCadRefresh_MouseEnter(object sender, EventArgs e)
        {
            lbCadRefresh.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadRefresh_MouseLeave(object sender, EventArgs e)
        {
            lbCadRefresh.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbCadPesquisar_MouseEnter(object sender, EventArgs e)
        {
            lbCadPesquisar.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadPesquisar_MouseLeave(object sender, EventArgs e)
        {
            lbCadPesquisar.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbCadLimpar_MouseEnter(object sender, EventArgs e)
        {
            lbCadLimpar.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbCadLimpar_MouseLeave(object sender, EventArgs e)
        {
            lbCadLimpar.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void txCadUsuario_Enter(object sender, EventArgs e)
        {
            txCadUsuario.BackColor = Color.AliceBlue;
        }

        private void txCadUsuario_Leave(object sender, EventArgs e)
        {
            txCadUsuario.BackColor = Color.White;
        }

        private void lbCadNovoUsuario_Click(object sender, EventArgs e)
        {
            uFrmCadUsuario form = new uFrmCadUsuario();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                carregaUsuario();
            }
        }

        private void lbCadPesquisar_Click(object sender, EventArgs e)
        {
            if (!StatusConexao.VerificarConexaoAtiva())
                return;

            string usuario = txCadUsuario.Text.Trim().ToUpper();
            MySqlDataReader reader = null;

            try
            {
                string sql = "select id, nome_usuario from USUARIO " +
                                "where nome_usuario like @usuario " +
                                "order by id";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                cmd.Parameters.AddWithValue("@usuario", "%" + usuario + "%");
                reader = cmd.ExecuteReader();

                lvCadUsuario.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                        {
                            reader.GetInt32(0).ToString(), // Lê o id_usuario
                            reader.GetString(1), // Lê o nome_usuario
                        };

                    var linha = new ListViewItem(row);
                    lvCadUsuario.Items.Add(linha);
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
            finally
            {
                reader.Close();
            }

        }

        private void carregaUsuario()
        {
            if (!StatusConexao.VerificarConexaoAtiva())
                return;

            txCadUsuario.Text = string.Empty;
            MySqlDataReader reader = null;

            try
            {

                string sql = "select id, nome_usuario from USUARIO " +
                                   "order by id ASC";
                MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                reader = cmd.ExecuteReader();
                lvCadUsuario.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                        {
                            reader.GetInt32(0).ToString(), // Lê o id_usuario
                            reader.GetString(1), // Lê o nome_usuario
                        };

                    var linha = new ListViewItem(row);
                    lvCadUsuario.Items.Add(linha);
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
            finally
            {
                reader.Close();

            }
        }

        private UsuarioDAO usuarioDAO = new UsuarioDAO();
        private void lbCadEditar_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection usuarioSelecionado = lvCadUsuario.SelectedItems;
            MySqlDataReader reader = null;

            if (usuarioSelecionado.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para editar.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usuarioSelecionado.Count > 1)
            {
                MessageBox.Show("Selecione apenas um usuário para editar.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = lvCadUsuario.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[0].Text);
            string nomeUsuario = item.SubItems[1].Text;

            DialogResult resultado = MessageBox.Show($"Deseja editar o usuario {nomeUsuario}?",
                                                        "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Usuario usuario = usuarioDAO.BuscarUsuarioPorId(id);

                uFrmEditUsuario form = new uFrmEditUsuario(usuario);
                form.ShowDialog();
                               
            }

            carregaUsuario();            
        }

        private void lbCadRefresh_Click(object sender, EventArgs e)
        {
            carregaUsuario();
        }

        private void lbCadExcluir_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection usuarioSelecionado = lvCadUsuario.SelectedItems;

            if (usuarioSelecionado.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para excluir.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < lvCadUsuario.SelectedItems.Count; i++)
            {
                int id = Convert.ToInt32(lvCadUsuario.SelectedItems[i].SubItems[0].Text);
                string usuario = lvCadUsuario.SelectedItems[i].SubItems[1].Text;


               DialogResult resultado =  MessageBox.Show($"Deseja excluir o usuario {usuario}?",
                                                           "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (!StatusConexao.VerificarConexaoAtiva())
                        return;
                    try
                    {
                        string sql = "delete from USUARIO where id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário excluído com sucesso.",
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carregaUsuario();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar reconectar ao banco de dados:\n" + ex.Message,
                                        "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }
    }
}
