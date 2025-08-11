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
    public partial class uFrmCadDespesasTpDespesa : Form
    {
        private int? idTpDespesaAtual = 0;
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
    }
}
