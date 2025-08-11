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
        private int? idTpReceitaAtual = 0;
        public uFrmCadReceitasTpReceita()
        {
            InitializeComponent();
        }

        private void uFrmCadReceitasTpReceita_Load(object sender, EventArgs e)
        {
            tstTpReceitaIdTpDespesa.Text = idTpReceitaAtual.ToString();
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
    }
}
