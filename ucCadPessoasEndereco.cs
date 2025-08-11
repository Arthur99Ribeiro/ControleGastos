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

namespace ControleGastos
{
    public partial class ucCadPessoasEndereco : UserControl, IFocusInicial
    {
        public ucCadPessoasEndereco()
        {
            InitializeComponent();
        }
        public void ucCadPessoasEndereco_Load(object sender, EventArgs e)
        {

        }

        public void FocarCampoInicial()
        {
            this.BeginInvoke((Action)(() => txUcCadPessoasEnderecoRua.Focus()));
        }

        private void mtxUcCadPessoasEnderecoCEP_Enter(object sender, EventArgs e)
        {
            mtxUcCadPessoasEnderecoCEP.BackColor = Color.AliceBlue;
        }

        private void mtxUcCadPessoasEnderecoCEP_Leave(object sender, EventArgs e)
        {
            mtxUcCadPessoasEnderecoCEP.BackColor = Color.White;
        }

        private void txUcCadPessoasEnderecoRua_Enter(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoRua.BackColor = Color.AliceBlue;
        }

        private void txUcCadPessoasEnderecoRua_Leave(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoRua.BackColor = Color.White;
        }

        private void txUcCadPessoasEnderecoBairro_Enter(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoBairro.BackColor = Color.AliceBlue;
        }

        private void txUcCadPessoasEnderecoBairro_Leave(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoBairro.BackColor = Color.White;
        }

        private void txUcCadPessoasEnderecoNumero_Enter(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoNumero.BackColor = Color.AliceBlue;
        }

        private void txUcCadPessoasEnderecoNumero_Leave(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoNumero.BackColor = Color.White;
        }

        private void txUcCadPessoasEnderecoComplemento_Enter(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoComplemento.BackColor = Color.AliceBlue;
        }

        private void txUcCadPessoasEnderecoComplemento_Leave(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoComplemento.BackColor = Color.White;
        }

        private void txUcCadPessoasEnderecoCidade_Enter(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoCidade.BackColor = Color.AliceBlue;
        }

        private void txUcCadPessoasEnderecoCidade_Leave(object sender, EventArgs e)
        {
            txUcCadPessoasEnderecoCidade.BackColor = Color.White;
        }

        private void cbUcCadPessoasEnderecoEstado_Enter(object sender, EventArgs e)
        {
            cbUcCadPessoasEnderecoEstado.BackColor = Color.AliceBlue;
        }

        private void cbUcCadPessoasEnderecoEstado_Leave(object sender, EventArgs e)
        {
            cbUcCadPessoasEnderecoEstado.BackColor = Color.White;
        }

        private void txUcCadPessoasEnderecoNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede que o caractere seja inserido
            }
        }

        public string ObterEnderecoRua()
        {
            return txUcCadPessoasEnderecoRua.Text.Trim().ToUpper();
        }
        public string ObterEnderecoBairro()
        {
            return txUcCadPessoasEnderecoBairro.Text.Trim().ToUpper();
        }
        public string ObterEnderecoNumero()
        {
            return txUcCadPessoasEnderecoNumero.Text.Trim().ToUpper();
        }
        public string ObterEnderecoComplemento()
        {
            return txUcCadPessoasEnderecoComplemento.Text.Trim().ToUpper();
        }
        public string ObterEnderecoCidade()
        {
            return txUcCadPessoasEnderecoCidade.Text.Trim().ToUpper();
        }
        public string ObterEnderecoCEP()
        {
            return mtxUcCadPessoasEnderecoCEP.Text.Trim().ToUpper();
        }
        public string ObterEnderecoUF()
        {
            return cbUcCadPessoasEnderecoEstado.SelectedItem?.ToString().Trim().ToUpper() ?? string.Empty;
        }

        public bool ValidaEnderecoPreenchido()
        {
            if (string.IsNullOrWhiteSpace(txUcCadPessoasEnderecoRua.Text) ||
                string.IsNullOrWhiteSpace(txUcCadPessoasEnderecoBairro.Text) ||
                string.IsNullOrWhiteSpace(txUcCadPessoasEnderecoNumero.Text) ||
                string.IsNullOrWhiteSpace(txUcCadPessoasEnderecoCidade.Text) ||
                (string.IsNullOrWhiteSpace(mtxUcCadPessoasEnderecoCEP.Text) || !mtxUcCadPessoasEnderecoCEP.MaskFull) ||
                cbUcCadPessoasEnderecoEstado.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        public Cadastro.Endereco ObterEndereco()
        {
            return new Cadastro.Endereco(
                //                id: 0, // ou outro valor padrão, se aplicável
                rua: txUcCadPessoasEnderecoRua.Text.ToUpper(),
                bairro: txUcCadPessoasEnderecoBairro.Text.ToUpper(),
                numero: txUcCadPessoasEnderecoNumero.Text.ToUpper(),
                complemento: txUcCadPessoasEnderecoComplemento.Text.ToUpper(),
                cidade: txUcCadPessoasEnderecoCidade.Text.ToUpper(),
                cep: mtxUcCadPessoasEnderecoCEP.Text.ToUpper(),
                uf: cbUcCadPessoasEnderecoEstado.SelectedItem?.ToString()
            );
        }

        public void PreencherEndereco(Cadastro.Endereco Endereco)
        {
            txUcCadPessoasEnderecoRua.Text = Endereco.Rua;
            txUcCadPessoasEnderecoBairro.Text = Endereco.Bairro;
            txUcCadPessoasEnderecoNumero.Text = Endereco.Numero;
            txUcCadPessoasEnderecoComplemento.Text = Endereco.Complemento;
            txUcCadPessoasEnderecoCidade.Text = Endereco.Cidade;
            mtxUcCadPessoasEnderecoCEP.Text = Endereco.CEP;
            cbUcCadPessoasEnderecoEstado.SelectedItem = Endereco.UF;
        }

        public void LimparCamposEndereco()
        {
            mtxUcCadPessoasEnderecoCEP.Clear();
            txUcCadPessoasEnderecoRua.Clear();
            txUcCadPessoasEnderecoBairro.Clear();
            txUcCadPessoasEnderecoNumero.Clear();
            txUcCadPessoasEnderecoComplemento.Clear();
            txUcCadPessoasEnderecoCidade.Clear();
            cbUcCadPessoasEnderecoEstado.SelectedIndex = -1;
        }


    }
}
