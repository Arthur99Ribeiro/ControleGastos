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
            txCadReceitaNome.Focus();
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
            cbCadReceitaTpReceita.ValueMember = cadastroReceita.IdTpReceita.ToString();
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

        private void tslCadReceitaPesquisar_Click(object sender, EventArgs e)
        {
            if (idCadReceitaAtual > 0)
            {
                MessageBox.Show("Já existe um cadastro carregado. Limpe os campos antes de pesquisar outro cadastro.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txCadReceitaNome.Text))
            {
                CadastroDAO dao = new CadastroDAO();
                var cadastroReceita = dao.CadReceitaPesquisarPorNome(txCadReceitaNome.Text);
                if (cadastroReceita != null)
                {
                    preencherCampos(cadastroReceita);
                    idCadReceitaAtual = cadastroReceita.IdCadReceita;
                    tstIdReceita.Text = idCadReceitaAtual.ToString();
                    MessageBox.Show("Cadastro carregado com sucesso.", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cadastro não encontrado.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("O campo Nome é obrigatório para pesquisa.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCadReceitaNome.Focus();
                return;
            }
        }

        private void tslCadReceitaSalvar_Click(object sender, EventArgs e)
        {
            if (idCadReceitaAtual == 0)
            {
                MessageBox.Show("Cadastro não existente! Faça a inclusão!!", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadReceitaNome.Text) && (cbCadReceitaTpReceita.SelectedIndex > 0))
                {
                    DialogResult result = MessageBox.Show("Deseja salvar o novo cadastro?", "Salvar Cadastro",
                                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var cadastroReceita = obterCampos();

                        CadastroDAO dao = new CadastroDAO();
                        dao.CadReceitaSalvarCadastro(cadastroReceita);
                        MessageBox.Show("Cadastro salvo com sucesso.", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dao.CadReceitaPesquisarPorId(idCadReceitaAtual);
                        preencherCampos(cadastroReceita);
                        tstIdReceita.Text = idCadReceitaAtual.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("O campo Nome e Tipo Receita é obrigatório.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadReceitaNome.Focus();
                    return;
                }

                DialogResult resultado = MessageBox.Show("Deseja salvar as alterações no cadastro?", "Salvar Cadastro",
                                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void tslCadReceitaIncluir_Click(object sender, EventArgs e)
        {
            if (idCadReceitaAtual > 0)
            {
                MessageBox.Show("Já existe uma receita selecionada. \n" +
                                "Caso deseje realizar alguma alteração, use o botão de salvar. \n" +
                                "Caso deseje realizar uma nova inclusão, use o botão de limpar antes de incluir um novo cadastro.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txCadReceitaNome.Focus();
                return;
            }   
            if (string.IsNullOrWhiteSpace(txCadReceitaNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCadReceitaNome.Focus();
                return;
            }
            if(cbCadReceitaTpReceita.SelectedIndex == 0)
            {
                MessageBox.Show("O campo Tipo Receita é obrigatório.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCadReceitaTpReceita.Focus();
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja incluir esse receita?", "Incluir Receita",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                var cadReceita = obterCampos();

                CadastroDAO dao = new CadastroDAO();
                dao.CadReceitaInserirCadastro(cadReceita);
                idCadReceitaAtual = cadReceita.IdCadReceita;

                DialogResult result = MessageBox.Show("Receita incluída com sucesso. \n" +
                                                      "Deseja carregar o cadastro?", "Sucesso",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    CadastroDAO atu = new CadastroDAO();
                    dao.CadReceitaPesquisarPorId(idCadReceitaAtual);
                    preencherCampos(cadReceita);
                    tstIdReceita.Text = idCadReceitaAtual.ToString();

                    MessageBox.Show("Receita carregada com sucesso.", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    limparCampos();
                }
            }
        }

        private void tslCadReceitaExcluir_Click(object sender, EventArgs e)
        {
            if(idCadReceitaAtual == 0)
            {
                MessageBox.Show("Nenhum cadastro carregado para exclusão.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Deseja realmente excluir o cadastro?", "Confirmar Exclusão",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                CadastroDAO dao = new CadastroDAO();
                dao.CadReceitaExcluirCadastro(idCadReceitaAtual);
                limparCampos();
                MessageBox.Show("Receita excluída com sucesso.", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
 