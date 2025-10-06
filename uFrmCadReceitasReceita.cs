using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleGastos.Cadastro;

namespace ControleGastos
{
    public partial class uFrmCadReceitasReceita : Form
    {
        private int idCadReceitaAtual = 0;
        public uFrmCadReceitasReceita()
        {
            InitializeComponent();
        }
        private void uFrmCadReceitasReceita_Load(object sender, EventArgs e)
        {
            tstIdReceita.Text = idCadReceitaAtual.ToString();
            carregarCategorias(cbCadReceitaTpReceita);
            cbCadReceitaTpReceita.SelectedIndex = 0;
        }

        private void tslCadReceitaExcluir_MouseEnter(object sender, EventArgs e)
        {
            tslCadReceitaExcluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadReceitaExcluir_MouseLeave(object sender, EventArgs e)
        {
            tslCadReceitaExcluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslCadReceitaIncluir_MouseEnter(object sender, EventArgs e)
        {
            tslCadReceitaIncluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadReceitaIncluir_MouseLeave(object sender, EventArgs e)
        {
            tslCadReceitaIncluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslCadReceitaSalvar_MouseEnter(object sender, EventArgs e)
        {
            tslCadReceitaSalvar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadReceitaSalvar_MouseLeave(object sender, EventArgs e)
        {
            tslCadReceitaSalvar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslCadReceitaPesquisar_MouseEnter(object sender, EventArgs e)
        {
            tslCadReceitaPesquisar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadReceitaPesquisar_MouseLeave(object sender, EventArgs e)
        {
            tslCadReceitaPesquisar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslCadReceitaLimpar_MouseEnter(object sender, EventArgs e)
        {
            tslCadReceitaLimpar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadReceitaLimpar_MouseLeave(object sender, EventArgs e)
        {
            tslCadReceitaLimpar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void txCadReceitaNome_Enter(object sender, EventArgs e)
        {
            txCadReceitaNome.BackColor = Color.AliceBlue;
        }

        private void txCadReceitaNome_Leave(object sender, EventArgs e)
        {
            txCadReceitaNome.BackColor = Color.White;
        }

        private void cbCadReceitaTpReceita_Enter(object sender, EventArgs e)
        {
            cbCadReceitaTpReceita.BackColor = Color.AliceBlue;
        }

        private void cbCadReceitaTpReceita_Leave(object sender, EventArgs e)
        {
            cbCadReceitaTpReceita.BackColor = Color.White;
        }

        public void carregarCategorias(ComboBox combo)
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
                    string sql = @"SELECT ID, NOME FROM TP_RECEITA
                                   ORDER BY NOME;";
                    MySqlCommand cmd = new MySqlCommand(sql, StatusConexao.Conexao, transacao);
                    cmd.ExecuteNonQuery();
                    transacao.Commit();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataRow dr = dt.NewRow();
                        dr["ID"] = DBNull.Value;
                        dr["NOME"] = "";
                        dt.Rows.InsertAt(dr, 0);

                        combo.DataSource = dt;
                        combo.DisplayMember = "NOME"; // o que aparece para o usuário
                        combo.ValueMember = "ID";     // valor real que fica guardado
                    }
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao salvar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void limparCampos()
        {
            idCadReceitaAtual = 0;
            tstIdReceita.Text = idCadReceitaAtual.ToString();
            txCadReceitaNome.Clear();
            cbCadReceitaTpReceita.SelectedIndex = 0;
            ckbCadReceitaRecorrente.Checked = false;
        }

        private Cadastro.CadastroReceita obterCampos()
        {
            return new Cadastro.CadastroReceita
            {
                IdCadReceita = idCadReceitaAtual,
                Nome = txCadReceitaNome.Text.Trim().ToUpper(),
                IdTpReceita = Convert.ToInt32(cbCadReceitaTpReceita.ValueMember),
                ReceitaRecorrente = Helper.CheckBoxHelper.SorN(ckbCadReceitaRecorrente)
            };
        }

        private void preencherCampos(Cadastro.CadastroReceita cadastroReceita)
        {
            txCadReceitaNome.Text = cadastroReceita.Nome;
            cbCadReceitaTpReceita.ValueMember = cadastroReceita.IdTpReceita;
            Helper.CheckBoxHelper.TorF(ckbCadReceitaRecorrente, cadastroReceita.ReceitaRecorrente);
        }

        private void tslCadReceitaLimpar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja limpar os campos?", "Limpar Campos",
                                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                limparCampos();

                MessageBox.Show("Campos limpos com sucesso.", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }  
    }
}
 