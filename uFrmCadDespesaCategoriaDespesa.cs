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
    public partial class uFrmCadDespesaCategoriaDespesa : Form
    {
        int idCategoriaDespesaAtual = 0;

        public uFrmCadDespesaCategoriaDespesa()
        {
            InitializeComponent();
        }

        private void uFrmCadDespesaCategoriaDespesa_Load(object sender, EventArgs e)
        {
            tstCadCategoriaDespesaIdCategoriaDespesa.Text = idCategoriaDespesaAtual.ToString();
        }

        private void tslCadCategoriaDespesaExcluir_MouseEnter(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaExcluir.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslCadCategoriaDespesaExcluir_MouseLeave(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaExcluir.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void tslCadCategoriaDespesaIncluir_MouseEnter(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaIncluir.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslCadCategoriaDespesaIncluir_MouseLeave(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaIncluir.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void tslCadCategoriaDespesaSalvar_MouseEnter(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaSalvar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslCadCategoriaDespesaSalvar_MouseLeave(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaSalvar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void tslCadCategoriaDespesaPesquisar_MouseEnter(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaPesquisar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslCadCategoriaDespesaPesquisar_MouseLeave(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaPesquisar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void tslCadCategoriaDespesaLimpar_MouseEnter(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaLimpar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslCadCategoriaDespesaLimpar_MouseLeave(object sender, EventArgs e)
        {
            tslCadCategoriaDespesaLimpar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void txCadDespesaCategoriaDespesaNome_Enter(object sender, EventArgs e)
        {
            tstCadCategoriaDespesaIdCategoriaDespesa.BackColor = Color.AliceBlue;
        }

        private void txCadDespesaCategoriaDespesaNome_Leave(object sender, EventArgs e)
        {
            tstCadCategoriaDespesaIdCategoriaDespesa.BackColor = Color.White;
        }

        private void limparCampos()
        {
            txCadDespesaCategoriaDespesaNome.Text = string.Empty;
            idCategoriaDespesaAtual = 0;
            tstCadCategoriaDespesaIdCategoriaDespesa.Text = idCategoriaDespesaAtual.ToString();
        }

        private Cadastro.CategoriaDespesa obterCampos()
        {
            return new Cadastro.CategoriaDespesa
            {
                IdCategoriaDespesa = idCategoriaDespesaAtual,
                Nome = txCadDespesaCategoriaDespesaNome.Text.Trim().ToUpper()
            };
        }

        private void preencherCampos(Cadastro.CategoriaDespesa categoriaDespesa)
        {
            txCadDespesaCategoriaDespesaNome.Text = categoriaDespesa.Nome;
        }

        private void tslCadCategoriaDespesaLimpar_Click(object sender, EventArgs e)
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

        private void tslCadCategoriaDespesaPesquisar_Click(object sender, EventArgs e)
        {
            if (idCategoriaDespesaAtual > 0)
            {
                MessageBox.Show("Já existe uma categoria de despesa selecionada. \n" +
                                "Limpe antes de pesquisar", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadDespesaCategoriaDespesaNome.Text))
                {
                    CadastroDAO dao = new CadastroDAO();
                    var categoriaDespesa = dao.CadCategoriaDespesaPesquisarPorNome(txCadDespesaCategoriaDespesaNome.Text);
                    if (categoriaDespesa != null)
                    {
                        preencherCampos(categoriaDespesa);
                        idCategoriaDespesaAtual = categoriaDespesa.IdCategoriaDespesa;
                        tstCadCategoriaDespesaIdCategoriaDespesa.Text = idCategoriaDespesaAtual.ToString();

                        MessageBox.Show("Categoria de despesa carregada com sucesso.", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Categoria de despesa não encontrada.", "Aviso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("O campo Nome é obrigatório para pesquisa.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadDespesaCategoriaDespesaNome.Focus();
                    return;
                }
            }
        }

        private void tslCadCategoriaDespesaSalvar_Click(object sender, EventArgs e)
        {
            if (idCategoriaDespesaAtual == 0)
            {
                MessageBox.Show("Cadastro não existente! \n Faça a inclusão!!", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadDespesaCategoriaDespesaNome.Text))
                {
                    DialogResult resultado = MessageBox.Show("Deseja salvar as alterações?", "Salvar Alterações",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        var categoriaDespesa = obterCampos();

                        CadastroDAO dao = new CadastroDAO();
                        dao.CadCategoriaDespesaSalvarCadastro(categoriaDespesa);
                        MessageBox.Show("Categoria de despesa salva com sucesso.", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dao.CadCategoriaDespesaPesquisarPorId(idCategoriaDespesaAtual);
                        preencherCampos(categoriaDespesa);
                        tstCadCategoriaDespesaIdCategoriaDespesa.Text = idCategoriaDespesaAtual.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadDespesaCategoriaDespesaNome.Focus();
                    return;
                }
            }
        }

        private void tslCadCategoriaDespesaIncluir_Click(object sender, EventArgs e)
        {
            if (idCategoriaDespesaAtual > 0)
            {
                MessageBox.Show("Já existe uma categoria de despesa selecionada. \n" +
                                "Caso deseje realizar alguma alteração, use o botão de salvar. \n" +
                                "Caso deseje realizar uma nova inclusão, limpe os campos antes de incluir um novo cadastro.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadDespesaCategoriaDespesaNome.Text))
                {

                    if (VerificaCadastro.VerificaCadCategoriaDespesa(txCadDespesaCategoriaDespesaNome.Text.Trim().ToUpper()))
                    {
                        MessageBox.Show("Categoria de despesa já cadastrada, por favor informe outro nome.", "Aviso",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txCadDespesaCategoriaDespesaNome.Focus();
                        return;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Deseja incluir este tipo de despesa?", "Incluir Tipo de Despesa",
                                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            var categoriaDespesa = obterCampos();

                            CadastroDAO dao = new CadastroDAO();
                            dao.CadCategoriaDespesaInserirCadastro(categoriaDespesa);
                            idCategoriaDespesaAtual = categoriaDespesa.IdCategoriaDespesa;

                            DialogResult result = MessageBox.Show("Categoria de despesa incluída com sucesso. \n" +
                                                                  "Deseja carregar o cadastro?", "Sucesso",
                                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                CadastroDAO atu = new CadastroDAO();
                                dao.CadCategoriaDespesaPesquisarPorId(idCategoriaDespesaAtual);
                                preencherCampos(categoriaDespesa);
                                tstCadCategoriaDespesaIdCategoriaDespesa.Text = idCategoriaDespesaAtual.ToString();

                                MessageBox.Show("Categoria de despesa carregada com sucesso.", "Sucesso",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                categoriaDespesa.IdCategoriaDespesa = 0;
                                limparCampos();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadDespesaCategoriaDespesaNome.Focus();
                    return;
                }
            }
        }

        private void tslCadCategoriaDespesaExcluir_Click(object sender, EventArgs e)
        {
            if (idCategoriaDespesaAtual == 0)
            {
                MessageBox.Show("Nenhuma categoria de despesa selecionada para excluir.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja excluir esta categoria de despesa?", "Excluir Categoria de Despesa",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                CadastroDAO dao = new CadastroDAO();
                dao.CadCategoriaDespesaExcluirCadastro(idCategoriaDespesaAtual);

                limparCampos();
                MessageBox.Show("Tipo de despesa excluído com sucesso.", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
