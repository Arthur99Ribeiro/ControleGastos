using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleGastos.Cadastro;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControleGastos
{
    public partial class uFrmCadPessoa : Form
    {
        private ucCadPessoasDadosPessoais ucDadosPessoais;
        private ucCadPessoasEndereco ucEndereco;
        private int? idPessoaAtual = 0;
        public uFrmCadPessoa()
        {
            InitializeComponent();
        }
        private void Controle(UserControl controle)
        {
            spcCadPessoas.Panel2.Controls.Clear();
            controle.Dock = DockStyle.Fill;
            spcCadPessoas.Panel2.Controls.Add(controle);

            if (controle is IFocusInicial foco)
            {
                foco.FocarCampoInicial();
            }
        }

        private void uFrmCadPessoa_Load(object sender, EventArgs e)
        {
            tvCadPessoas.AfterSelect += tvCadPessoas_AfterSelect;

            // Cria as instâncias uma única vez
            ucDadosPessoais = new ucCadPessoasDadosPessoais();
            ucEndereco = new ucCadPessoasEndereco();

            // Exibe o padrão
            Controle(ucDadosPessoais);
            tstIdPessoa.Text = idPessoaAtual.ToString();
        }

        private void tslCadPessoasExcluir_MouseEnter(object sender, EventArgs e)
        {
            tslCadPessoasExcluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadPessoasExcluir_MouseLeave(object sender, EventArgs e)
        {
            tslCadPessoasExcluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslCadPessoasIncluir_MouseEnter(object sender, EventArgs e)
        {
            tslCadPessoasIncluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadPessoasIncluir_MouseLeave(object sender, EventArgs e)
        {
            tslCadPessoasIncluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslCadPessoasSalvar_MouseEnter(object sender, EventArgs e)
        {
            tslCadPessoasSalvar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadPessoasSalvar_MouseLeave(object sender, EventArgs e)
        {
            tslCadPessoasSalvar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslCadPessoasPesquisar_MouseEnter(object sender, EventArgs e)
        {
            tslCadPessoasPesquisar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadPessoasPesquisar_MouseLeave(object sender, EventArgs e)
        {
            tslCadPessoasPesquisar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tslCadPessoasLimpar_MouseEnter(object sender, EventArgs e)
        {
            tslCadPessoasLimpar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadPessoasLimpar_MouseLeave(object sender, EventArgs e)
        {
            tslCadPessoasLimpar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular);
        }

        private void tvCadPessoas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Dados Pessoais":
                    Controle(ucDadosPessoais);
                    break;

                case "Endereço":
                    Controle(ucEndereco);
                    break;
            }
        }

        private void tslCadPessoasExcluir_Click(object sender, EventArgs e)
        {
            if (idPessoaAtual == 0)
            {
                MessageBox.Show("Nenhum cadastro selecionado para exclusão.");
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir este cadastro?", "Confirmação",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        CadastroDAO dao = new CadastroDAO();
                        dao.CadPessoaExcluirCadastro(idPessoaAtual.Value);

                        MessageBox.Show("Cadastro excluído com sucesso!");
                        ucDadosPessoais.LimparCamposDadosPessoais();
                        ucEndereco.LimparCamposEndereco();
                        idPessoaAtual = 0;
                        tstIdPessoa.Text = idPessoaAtual.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tslCadPessoasIncluir_Click(object sender, EventArgs e)
        {
            if(idPessoaAtual > 0)
            {
                MessageBox.Show("Já existe um cadastro selecionado. \n " +
                                "Caso deseja relaizar uma alteração, use o botão salvar. \n" +
                                "Caso deseje realizar uma nova inclusão, limpe os campos antes de incluir um novo cadastro.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!ucDadosPessoais.ValidaDadosPessoaisPreenchidos() && !ucEndereco.ValidaEnderecoPreenchido())
                {
                    DialogResult resultado = MessageBox.Show("Deseja incluir os dados preenchidos em Dados Pessoais e Endereço?", "Incluir Dados",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        if (idPessoaAtual == 0)
                        {
                            var pessoa = ucDadosPessoais.ObterDadosPessoais();
                            var endereco = ucEndereco.ObterEndereco();

                            CadastroDAO dao = new CadastroDAO();
                            dao.CadPessoaInserirCadastro(pessoa, endereco);

                            DialogResult result = MessageBox.Show("Cadastro incluído com sucesso! \n" +
                                                                    "Deja carregar cadastro?", "Sucesso",
                                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string cpf = ucDadosPessoais.ObterDadosPessoaisCPF();

                                CadastroDAO atu = new CadastroDAO();
                                var (atuPessoa, atuEndereco) = atu.CadPessoaBuscarPorCPF(cpf);
                                ucDadosPessoais.PreencherDadosPessoias(atuPessoa);
                                ucEndereco.PreencherEndereco(atuEndereco);
                                idPessoaAtual = atuPessoa.Id;
                                tstIdPessoa.Text = idPessoaAtual.ToString();

                                MessageBox.Show("Cadastro carregado com sucesso!", "Sucesso",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                ucDadosPessoais.LimparCamposDadosPessoais();
                                ucEndereco.LimparCamposEndereco();
                                idPessoaAtual = 0; // Reseta o ID do cadastro atual
                                tstIdPessoa.Text = idPessoaAtual.ToString();
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha os campos de Dados Pessoais e Endereço antes de incluir.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void tslCadPessoasSalvar_Click(object sender, EventArgs e)
        {
            if (idPessoaAtual == 0)
            {
                MessageBox.Show("Cadastro não existente! /n Faça a inclusão!!", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja salvar os dados altrerados em Dados Pessoais e Endereço?", "Alterar Dados",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    var pessoa = ucDadosPessoais.ObterDadosPessoais();
                    var endereco = ucEndereco.ObterEndereco();

                    CadastroDAO dao = new CadastroDAO();

                    pessoa.Id = idPessoaAtual.Value;
                    endereco.IdPessoa = idPessoaAtual.Value;

                    dao.CadPessoaSalvarCadastro(pessoa, endereco);
                    MessageBox.Show("Dados salvo com sucesso!", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string cpf = ucDadosPessoais.ObterDadosPessoaisCPF();

                    CadastroDAO atu = new CadastroDAO();
                    var (atuPessoa, atuEndereco) = atu.CadPessoaBuscarPorCPF(cpf);
                    ucDadosPessoais.PreencherDadosPessoias(atuPessoa);
                    ucEndereco.PreencherEndereco(atuEndereco);
                    idPessoaAtual = atuPessoa.Id;
                    tstIdPessoa.Text = idPessoaAtual.ToString();

                }
            }   
        }

        private void tslCadPessoasPesquisar_Click(object sender, EventArgs e)
        {
            string cpf = ucDadosPessoais.ObterDadosPessoaisCPF();
            string nome = ucDadosPessoais.ObterDadosPessoaisNome();

            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(cpf)) 
            {
                MessageBox.Show("Por favor, preencha o nome ou CPF para pesquisa.", "Aviso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(cpf))
            {
                CadastroDAO daoCpf = new CadastroDAO();
                var (pessoa, endereco) = daoCpf.CadPessoaBuscarPorCPF(cpf);

                if (pessoa != null)
                {
                    ucDadosPessoais.PreencherDadosPessoias(pessoa);
                    ucEndereco.PreencherEndereco(endereco);
                    idPessoaAtual = pessoa.Id;
                    tstIdPessoa.Text = idPessoaAtual.ToString();

                    MessageBox.Show("Cadastro encontrado com sucesso!", "Sucesso", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pessoa não encontrada! \n Confira se o CPF esta preenchido coretamente.");
                    ucDadosPessoais.LimparCamposDadosPessoais();
                    ucEndereco.LimparCamposEndereco();
                    idPessoaAtual = 0;
                    tstIdPessoa.Text = idPessoaAtual.ToString();
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(nome))
                {
                    CadastroDAO daoNome = new CadastroDAO();
                    var (pessoa, endereco) = daoNome.CadPessoaBuscarPorNome(nome);
                    if (pessoa != null)
                    {
                        ucDadosPessoais.PreencherDadosPessoias(pessoa);
                        ucEndereco.PreencherEndereco(endereco);
                        idPessoaAtual = pessoa.Id;
                        tstIdPessoa.Text = idPessoaAtual.ToString();

                        MessageBox.Show("Cadastro encontrado com sucesso!", "Sucesso", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pessoa não encontrada.\n Confira se o Nome esta preenchido corretamente.");
                        ucDadosPessoais.LimparCamposDadosPessoais();
                        ucEndereco.LimparCamposEndereco();
                        idPessoaAtual = 0;
                        tstIdPessoa.Text = idPessoaAtual.ToString();
                    }
                }
            }
        }

        private void tslCadPessoasLimpar_Click(object sender, EventArgs e)
        {
            DialogResult resiltado = MessageBox.Show("Deseja limpar todos os campos de Dados Pessoais e Endereço?", "Limpar Campos", 
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resiltado == DialogResult.Yes)
            {
                ucDadosPessoais.LimparCamposDadosPessoais();
                ucEndereco.LimparCamposEndereco();
                idPessoaAtual = 0; // Reseta o ID do cadastro atual
                tstIdPessoa.Text = idPessoaAtual.ToString();

                MessageBox.Show("Campos limpos com sucesso!", "Sucesso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
