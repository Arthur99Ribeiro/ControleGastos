using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleGastos.Helper;

namespace ControleGastos
{
    public partial class uFrmCadDespesasTpDespesa : Form
    {
        private int idTpDespesaAtual = 0;
        public uFrmCadDespesasTpDespesa()
        {
            InitializeComponent();
        }

        private void uFrmCadDespesasTpDespesa_Load(object sender, EventArgs e)
        {
            tstTpDespesaIdTpDespesa.Text = idTpDespesaAtual.ToString();
        }

        private void tslTpDespesaExcluir_MouseEnter(object sender, EventArgs e)
        {
            tslTpDespesaExcluir.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslTpDespesaExcluir_MouseLeave(object sender, EventArgs e)
        {
            tslTpDespesaExcluir.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void tslTpDespesaIncluir_MouseEnter(object sender, EventArgs e)
        {
            tslTpDespesaIncluir.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslTpDespesaIncluir_MouseLeave(object sender, EventArgs e)
        {
            tslTpDespesaIncluir.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void tslTpDespesaSalvar_MouseEnter(object sender, EventArgs e)
        {
            tslTpDespesaSalvar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslTpDespesaSalvar_MouseLeave(object sender, EventArgs e)
        {
            tslTpDespesaSalvar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void tslTpDespesaPesquisar_MouseEnter(object sender, EventArgs e)
        {
            tslTpDespesaPesquisar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslTpDespesaPesquisar_MouseLeave(object sender, EventArgs e)
        {
            tslTpDespesaPesquisar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void tslTpDespesaLimpar_MouseEnter(object sender, EventArgs e)
        {
            tslTpDespesaLimpar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Bold);
        }

        private void tslTpDespesaLimpar_MouseLeave(object sender, EventArgs e)
        {
            tslTpDespesaLimpar.Font = new Font("Segoe MDL2 Assets", 15, FontStyle.Regular);
        }

        private void txCadTpDespesaNome_Enter(object sender, EventArgs e)
        {
            txCadTpDespesaNome.BackColor = Color.AliceBlue;
        }

        private void txCadTpDespesaNome_Leave(object sender, EventArgs e)
        {
            txCadTpDespesaNome.BackColor = Color.White;
        }

        private void limparCampos()
        {
            txCadTpDespesaNome.Text = string.Empty;
            ckbCadTpDespesaFixa.Checked = false;
            idTpDespesaAtual = 0;
            tstTpDespesaIdTpDespesa.Text = idTpDespesaAtual.ToString();
        }

        private Cadastro.TpDespesa obterCampos()
        {
            return new Cadastro.TpDespesa
            {
                IdTpDespesa = idTpDespesaAtual,
                Nome = txCadTpDespesaNome.Text.Trim().ToUpper(),
                TpDespesaFixa = Helper.CheckBoxHelper.SorN(ckbCadTpDespesaFixa)
            };
        }

        private void preencherCampos(Cadastro.TpDespesa tpDespesa)
        {
            txCadTpDespesaNome.Text = tpDespesa.Nome;
            Helper.CheckBoxHelper.TorF(ckbCadTpDespesaFixa, tpDespesa.TpDespesaFixa);
        }

        private void tslTpDespesaLimpar_Click(object sender, EventArgs e)
        {
            if (idTpDespesaAtual == 0)
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

                    MessageBox.Show("Campos limpos com sucesso.", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tslTpDespesaPesquisar_Click(object sender, EventArgs e)
        {
            if (idTpDespesaAtual > 0)
            {
                MessageBox.Show("Já existe um tipo de despesa selecionado. \n" +
                                "Limpe antes de pesquisar", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadTpDespesaNome.Text))
                {
                    CadastroDAO dao = new CadastroDAO();
                    var tpDespesa = dao.CadTpDespesaPesquisarPorNome(txCadTpDespesaNome.Text);
                    if (tpDespesa != null)
                    {
                        preencherCampos(tpDespesa);
                        idTpDespesaAtual = tpDespesa.IdTpDespesa;
                        tstTpDespesaIdTpDespesa.Text = idTpDespesaAtual.ToString();

                        MessageBox.Show("Tipo de despesa carregado com sucesso.", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tipo de despesa não encontrado.", "Aviso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("O campo Nome é obrigatório para pesquisa.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadTpDespesaNome.Focus();
                    return;
                }
            }
        }

        private void tslTpDespesaSalvar_Click(object sender, EventArgs e)
        {
            if (idTpDespesaAtual == 0)
            {
                MessageBox.Show("Cadastro não existente! \n Faça a inclusão!!", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadTpDespesaNome.Text))
                {
                    DialogResult resultado = MessageBox.Show("Deseja salvar as alterações?", "Salvar Alterações",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        var tpDespesa = obterCampos();

                        CadastroDAO dao = new CadastroDAO();
                        dao.CadTpDespesaSalvarCadastro(tpDespesa);
                        MessageBox.Show("Tipo de despesa salvo com sucesso.", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dao.CadTpDespesaPesquisarPorId(idTpDespesaAtual);
                        preencherCampos(tpDespesa);
                        tstTpDespesaIdTpDespesa.Text = idTpDespesaAtual.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadTpDespesaNome.Focus();
                    return;
                }
            }
        }

        private void tslTpDespesaIncluir_Click(object sender, EventArgs e)
        {
            if (idTpDespesaAtual > 0)
            {
                MessageBox.Show("Já existe um tipo de despesa selecionado. \n" +
                                "Caso deseje realizar alguma alteração, use o botão de salvar. \n" +
                                "Caso deseje realizar uma nova inclusão, limpe os campos antes de incluir um novo cadastro.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txCadTpDespesaNome.Text))
                {

                    if (VerificaCadastro.VerificaCadTpDespesa(txCadTpDespesaNome.Text.Trim().ToUpper()))
                    {
                        MessageBox.Show("Tipo de despesa já cadastrado, por favor informe outro nome.", "Aviso",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txCadTpDespesaNome.Focus();
                        return;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Deseja incluir este tipo de despesa?", "Incluir Tipo de Despesa",
                                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            var tpDespesa = obterCampos();

                            CadastroDAO dao = new CadastroDAO();
                            dao.CadTpDespesaInserirCadastro(tpDespesa);
                            idTpDespesaAtual = tpDespesa.IdTpDespesa;

                            DialogResult result = MessageBox.Show("Tipo de despesa incluído com sucesso. \n" +
                                                                  "Deseja carregar o cadastro?", "Sucesso",
                                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                CadastroDAO atu = new CadastroDAO();
                                dao.CadTpDespesaPesquisarPorId(idTpDespesaAtual);
                                preencherCampos(tpDespesa);
                                tstTpDespesaIdTpDespesa.Text = idTpDespesaAtual.ToString();

                                MessageBox.Show("Tipo de despesa carregado com sucesso.", "Sucesso",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                limparCampos();
                                tpDespesa.IdTpDespesa = 0;
                                idTpDespesaAtual = 0;
                            }
                        }
                    } 
                }
                else 
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCadTpDespesaNome.Focus();
                    return;
                }
            }
        }

        private void tslTpDespesaExcluir_Click(object sender, EventArgs e)
        {
            if (idTpDespesaAtual == 0)
            {
                MessageBox.Show("Nenhum tipo de despesa selecionado para excluir.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja excluir este tipo de despesa?", "Excluir Tipo de Despesa",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                CadastroDAO dao = new CadastroDAO();
                dao.CadTpDespesaExcluirCadastro(idTpDespesaAtual);

                limparCampos();
                idTpDespesaAtual = 0;
                tstTpDespesaIdTpDespesa.Text = idTpDespesaAtual.ToString();
                MessageBox.Show("Tipo de despesa excluído com sucesso.", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
