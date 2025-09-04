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
    public partial class uFrmCadReceitasTpReceita : Form
    {
        private int idTpReceitaAtual = 0;
        public uFrmCadReceitasTpReceita()
        {
            InitializeComponent();
        }

        private void uFrmCadReceitasTpReceita_Load(object sender, EventArgs e)
        {
            tstTpReceitaIdTpReceita.Text = idTpReceitaAtual.ToString();
        }

        private void tslTpReceitaExcluir_MouseEnter(object sender, EventArgs e)
        {
            tslTpReceitaExcluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslTpReceitaExcluir_MouseLeave(object sender, EventArgs e)
        {
            tslTpReceitaExcluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslTpReceitaIncluir_MouseEnter(object sender, EventArgs e)
        {
            tslTpReceitaIncluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslTpReceitaIncluir_MouseLeave(object sender, EventArgs e)
        {
            tslTpReceitaIncluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslTpReceitaSalvar_MouseEnter(object sender, EventArgs e)
        {
            tslTpReceitaSalvar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslTpReceitaSalvar_MouseLeave(object sender, EventArgs e)
        {
            tslTpReceitaSalvar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslTpReceitaPesquisar_MouseEnter(object sender, EventArgs e)
        {
            tslTpReceitaPesquisar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslTpReceitaPesquisar_MouseLeave(object sender, EventArgs e)
        {
            tslTpReceitaPesquisar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslTpReceitaLimpar_MouseEnter(object sender, EventArgs e)
        {
            tslTpReceitaLimpar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslTpReceitaLimpar_MouseLeave(object sender, EventArgs e)
        {
            tslTpReceitaLimpar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void txCadTpReceitaNome_Enter(object sender, EventArgs e)
        {
            txCadTpReceitaNome.BackColor = Color.AliceBlue;
        }

        private void txCadTpReceitaNome_Leave(object sender, EventArgs e)
        {
            txCadTpReceitaNome.BackColor = Color.White;
        }

        private void limparCampos()
        {
            txCadTpReceitaNome.Text = string.Empty;
            ckbCadTpReceitaFixa.Checked = false;
        }

        private Cadastro.TpReceita obterCampos()
        {
            return new Cadastro.TpReceita
            {
                IdTpReceita = idTpReceitaAtual,
                Nome = txCadTpReceitaNome.Text.Trim().ToUpper(),
                TpReceitaFixa = Helper.CheckBoxHelper.SorN(ckbCadTpReceitaFixa)
            };
        }

        private void preencherCampos(Cadastro.TpReceita tpReceita)
        {
            txCadTpReceitaNome.Text = tpReceita.Nome;
            Helper.CheckBoxHelper.TorF(ckbCadTpReceitaFixa, tpReceita.TpReceitaFixa);
        }

        private void tslTpReceitaLimpar_Click(object sender, EventArgs e)
        {
            if (idTpReceitaAtual == 0)
            {
                MessageBox.Show("Nenhum tipo de despesa selecionado para limpar.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja limpar os campos?", "Limpar Campos",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    limparCampos();
                    idTpReceitaAtual = 0;
                    tstTpReceitaIdTpReceita.Text = idTpReceitaAtual.ToString();

                    MessageBox.Show("Campos limpos com sucesso.", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tslTpReceitaPesquisar_Click(object sender, EventArgs e)
        {
            if (idTpReceitaAtual > 0)
            {
                MessageBox.Show("Já existe um tipo de despesa selecionado. \n" +
                                "Limpe antes de pesquisar", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadTpReceitaNome.Text))
                {
                    CadastroDAO dao = new CadastroDAO();
                    var tpReceita = dao.CadTpReceitaPesquisarPorNome(txCadTpReceitaNome.Text);
                    if (tpReceita != null)
                    {
                        preencherCampos(tpReceita);
                        idTpReceitaAtual = tpReceita.IdTpReceita;
                        tstTpReceitaIdTpReceita.Text = idTpReceitaAtual.ToString();

                        MessageBox.Show("Tipo de receita carregado com sucesso.", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tipo de receita não encontrado.", "Aviso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("O campo Nome é obrigatório para pesquisa.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadTpReceitaNome.Focus();
                    return;
                }
            }
        }

        private void tslTpReceitaSalvar_Click(object sender, EventArgs e)
        {
            if (idTpReceitaAtual == 0)
            {
                MessageBox.Show("Cadastro não existente! /n Faça a inclusão!!", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadTpReceitaNome.Text))
                {
                    DialogResult resultado = MessageBox.Show("Deseja salvar as alterações?", "Salvar Alterações",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        var tpReceita = obterCampos();

                        CadastroDAO dao = new CadastroDAO();
                        dao.CadTpReceitaSalvarCadastro(tpReceita);
                        MessageBox.Show("Tipo de receita salvo com sucesso.", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dao.CadTpReceitaPesquisarPorId(idTpReceitaAtual);
                        preencherCampos(tpReceita);
                        tstTpReceitaIdTpReceita.Text = idTpReceitaAtual.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadTpReceitaNome.Focus();
                    return;
                }
            }
        }

        private void tslTpReceitaIncluir_Click(object sender, EventArgs e)
        {
            if (idTpReceitaAtual > 0)
            {
                MessageBox.Show("Já existe um tipo de receita selecionado. \n" +
                                "Caso deseje realizar alguma alteração, use o botão de salvar. \n" +
                                "Caso deseje realizar uma nova inclusão, use o botão de limpar antes de incluir um novo cadastro.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadTpReceitaNome.Text))
                {
                    if(VerificaCadastro.VerificaCadTpReceita(txCadTpReceitaNome.Text.Trim().ToUpper()))
                    {
                        MessageBox.Show("Tipo de receita já cadastrado, por favor informe outro nome.", "Aviso",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txCadTpReceitaNome.Focus();
                        return;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Deseja incluir este tipo de receita?", "Incluir Tipo de receita",
                                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            var tpReceita = obterCampos();

                            CadastroDAO dao = new CadastroDAO();
                            dao.CadTpReceitaInserirCadastro(tpReceita);
                            idTpReceitaAtual = tpReceita.IdTpReceita;

                            DialogResult result = MessageBox.Show("Tipo de receita incluído com sucesso. \n" +
                                                                  "Deseja carregar o cadastro?", "Sucesso",
                                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                CadastroDAO atu = new CadastroDAO();
                                dao.CadTpReceitaPesquisarPorId(idTpReceitaAtual);
                                preencherCampos(tpReceita);
                                tstTpReceitaIdTpReceita.Text = idTpReceitaAtual.ToString();

                                MessageBox.Show("Tipo de receita carregado com sucesso.", "Sucesso",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                limparCampos();
                                tpReceita.IdTpReceita = 0;
                                idTpReceitaAtual = 0;
                            }
                        }
                    }                       
                }
                else
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadTpReceitaNome.Focus();
                    return;
                }
            }
        }

        private void tslTpReceitaExcluir_Click(object sender, EventArgs e)
        {
            if (idTpReceitaAtual == 0)
            {
                MessageBox.Show("Nenhum tipo de receita selecionado para excluir.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja excluir este tipo de receita?", "Excluir Tipo de Despesa",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                CadastroDAO dao = new CadastroDAO();
                dao.CadTpReceitaExcluirCadastro(idTpReceitaAtual);

                limparCampos();
                idTpReceitaAtual = 0;
                tstTpReceitaIdTpReceita.Text = idTpReceitaAtual.ToString();
                MessageBox.Show("Tipo de receita excluído com sucesso.", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
