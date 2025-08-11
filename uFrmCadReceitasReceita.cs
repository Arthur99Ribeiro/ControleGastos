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
    public partial class uFrmCadReceitasReceita : Form
    {
        private ucCadReceitasReceita ucReceita;
        private int? IdReceitaAtual = 0;
        public uFrmCadReceitasReceita()
        {
            InitializeComponent();
        }
        private void uFrmCadReceitasReceita_Load(object sender, EventArgs e)
        {
            tvCadReceita.AfterSelect += tvCadReceita_AfterSelect;

            ucReceita = new ucCadReceitasReceita();

            Controle(ucReceita);
            tstIdReceita.Text = IdReceitaAtual.ToString();
        }

        private void Controle(UserControl controle)
        {
            spcCadReceita.Panel2.Controls.Clear();
            controle.Dock = DockStyle.Fill;
            spcCadReceita.Panel2.Controls.Add(controle);

            if (controle is IFocusInicial foco)
            {
                foco.FocarCampoInicial();
            }
        }

        private void tvCadReceita_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Dados Pessoais":
                    Controle(ucReceita);
                    break;
            }
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
    }
}
