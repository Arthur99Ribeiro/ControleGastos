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
    public partial class uFrmCadDespesasDespesa : Form
    {
        private int? IdDespesaAtual = 0;
        public uFrmCadDespesasDespesa()
        {
            InitializeComponent();
        }

        private void uFrmCadDespesasDespesa_Load(object sender, EventArgs e)
        {
            tstIdDepesa.Text = IdDespesaAtual.ToString();
        }

        private void tslCadDespesaExcluir_MouseEnter(object sender, EventArgs e)
        {
            tslCadDespesaExcluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadDespesaExcluir_MouseLeave(object sender, EventArgs e)
        {
            tslCadDespesaExcluir.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular);
        }

        private void tslCadDespesaIncluir_MouseEnter(object sender, EventArgs e)
        {
            tslCadDespesaIncluir.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadDespesaIncluir_MouseLeave(object sender, EventArgs e)
        {
            tslCadDespesaIncluir.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular);
        }

        private void tslCadDespesaSalvar_MouseEnter(object sender, EventArgs e)
        {
            tslCadDespesaSalvar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadDespesaSalvar_MouseLeave(object sender, EventArgs e)
        {
            tslCadDespesaSalvar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular);
        }

        private void tslCadDespesaPesquisar_MouseEnter(object sender, EventArgs e)
        {
            tslCadDespesaPesquisar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadDespesaPesquisar_MouseLeave(object sender, EventArgs e)
        {
            tslCadDespesaPesquisar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular);
        }

        private void tslCadDespesaLimpar_MouseEnter(object sender, EventArgs e)
        {
            tslCadDespesaLimpar.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold);
        }

        private void tslCadDespesaLimpar_MouseLeave(object sender, EventArgs e)
        {
            tslCadDespesaLimpar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular);
        }
    }
}
