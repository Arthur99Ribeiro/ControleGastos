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
    public partial class ucCadPessoasDadosPessoais : UserControl, IFocusInicial
    {
        public ucCadPessoasDadosPessoais()
        {
            InitializeComponent();
        }
        private void ucCadPessoasDadosPessoais_Load(object sender, EventArgs e)
        {

        }

        public void FocarCampoInicial()
        {
            this.BeginInvoke((Action)(() => mtxUcCadPessoasDadosPessoaisCPF.Focus()));
        }

        private void txUcCadPessoasDadosPessoaisNome_Enter(object sender, EventArgs e)
        {
            txUcCadPessoasDadosPessoaisNome.BackColor = Color.AliceBlue;
        }

        private void txUcCadPessoasDadosPessoaisNome_Leave(object sender, EventArgs e)
        {
            txUcCadPessoasDadosPessoaisNome.BackColor = Color.White;
        }

        private void mtxUcCadPessoasDadosPessoaisTelefone_Enter(object sender, EventArgs e)
        {
            mtxUcCadPessoasDadosPessoaisTelefone.BackColor = Color.AliceBlue;
        }

        private void mtxUcCadPessoasDadosPessoaisTelefone_Leave(object sender, EventArgs e)
        {
            mtxUcCadPessoasDadosPessoaisTelefone.BackColor = Color.White;
        }

        private void mtxUcCadPessoasDadosPessoaisCPF_Enter(object sender, EventArgs e)
        {
            mtxUcCadPessoasDadosPessoaisCPF.BackColor = Color.AliceBlue;
        }

        private void mtxUcCadPessoasDadosPessoaisCPF_Leave(object sender, EventArgs e)
        {
            mtxUcCadPessoasDadosPessoaisCPF.BackColor = Color.White;
        }

        public string ObterDadosPessoaisCPF()
        {
            return mtxUcCadPessoasDadosPessoaisCPF.Text.Trim().ToUpper();
        }
        public string ObterDadosPessoaisNome()
        {
            return txUcCadPessoasDadosPessoaisNome.Text.Trim().ToUpper();
        }
        public DateTime ObterDadosPessoaisDataNascimento()
        {
            return dtpUcCadPessoasDadosPessoaisDataNascimento.Value;
        }
        public string ObterDadosPessoaisTelefone()
        {
            return mtxUcCadPessoasDadosPessoaisTelefone.Text.Trim().ToUpper();
        }

        public bool ValidaDadosPessoaisPreenchidos()
        {
            if ((string.IsNullOrWhiteSpace(mtxUcCadPessoasDadosPessoaisCPF.Text) || !mtxUcCadPessoasDadosPessoaisCPF.MaskFull) ||
                string.IsNullOrWhiteSpace(txUcCadPessoasDadosPessoaisNome.Text) ||
                (string.IsNullOrWhiteSpace(mtxUcCadPessoasDadosPessoaisTelefone.Text) || !mtxUcCadPessoasDadosPessoaisTelefone.MaskFull))
            {
                return true;
            }
            return false;
        }

        public Cadastro.Pessoa ObterDadosPessoais()
        {
            return new Cadastro.Pessoa(
                id: 0, // ou outro valor padrão, se aplicável
                nome: txUcCadPessoasDadosPessoaisNome.Text.ToUpper(),
                cpf: mtxUcCadPessoasDadosPessoaisCPF.Text.ToUpper(),
                dtaNascimento: dtpUcCadPessoasDadosPessoaisDataNascimento.Value,
                telefone: mtxUcCadPessoasDadosPessoaisTelefone.Text.ToUpper()
            );
        }

        public void PreencherDadosPessoias(Cadastro.Pessoa Pessoa)
        {
            mtxUcCadPessoasDadosPessoaisCPF.Text = Pessoa.CPF;
            txUcCadPessoasDadosPessoaisNome.Text = Pessoa.Nome;
            dtpUcCadPessoasDadosPessoaisDataNascimento.Value = Pessoa.DtaNascimento;
            mtxUcCadPessoasDadosPessoaisTelefone.Text = Pessoa.Telefone;
        }

        public void LimparCamposDadosPessoais()
        {
            mtxUcCadPessoasDadosPessoaisCPF.Clear();
            txUcCadPessoasDadosPessoaisNome.Clear();
            dtpUcCadPessoasDadosPessoaisDataNascimento.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            mtxUcCadPessoasDadosPessoaisTelefone.Clear();
        }


    }
}
