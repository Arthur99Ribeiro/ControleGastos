namespace ControleGastos
{
    public partial class uFrmPrincipal : Form
    {
        public uFrmPrincipal()
        {
            InitializeComponent();
        }

        /*        private void AbrirFormulario<F>() where F : Form, new()
                {
                    for (int i = 0; i < this.MdiChildren.Length; i++)
                    {
                        if (this.MdiChildren[i] is F)
                        {
                            this.MdiChildren[i].BringToFront();
                            this.MdiChildren[i].Focus();
                            return;
                        }
                    }

                    F form = new F();
                    form.MdiParent = this;
                    form.Show();
                }
        */

        private void AbrirFormulario<T>() where T : Form, new()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is T)
                {
                    form.WindowState = FormWindowState.Normal; // Restaura o formulário se estiver minimizado
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            T abrirForm = new T();
            abrirForm.MdiParent = this;
            abrirForm.Show();
        }

        private void uFrmPrincipal_Load(object sender, EventArgs e)
        {
            if (UsuarioLogado.SessaoUsuario.Id <= 0)
            {
                mpSistemaCadUsuario.Enabled = false;
                menuPrincipalCadastrosGastos.Enabled = false;
                menuPrincipalCadastrosReceitas.Enabled = false;
                mpCadastrosPessoas.Enabled = false;
            }

            if (UsuarioLogado.SessaoUsuario.Id > 0)
            {
                lbUsuarioLogado.Text = $"Usuario: {UsuarioLogado.SessaoUsuario.Nome}";
            }
            else
                lbUsuarioLogado.Text = "Usuario: Sem Login";
        }

        private void mpSistemaLogInOut_Click(object sender, EventArgs e)
        {
            if (UsuarioLogado.SessaoUsuario.Id > 0)
            {
                DialogResult resultado = MessageBox.Show("Deseja realizar logout?", "LogOut",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.Hide(); // Esconde o formulário principal
                    //LogOut
                    UsuarioLogado.SessaoUsuario.Limpar();
                    lbUsuarioLogado.Text = "Usuario: Sem Login";
                    uFrmLogin form = new uFrmLogin();
                    form.ShowDialog();
                    return;
                }
                else
                {
                    return;
                }

            }
            if (UsuarioLogado.SessaoUsuario.Id == 0)
            {
                this.Hide(); // Esconde o formulário principal
                //LogIn
                uFrmLogin form = new uFrmLogin();
                form.ShowDialog();
                if (UsuarioLogado.SessaoUsuario.Id > 0)
                {
                    lbUsuarioLogado.Text = $"Usuario: {UsuarioLogado.SessaoUsuario.Nome}";
                }
            }
        }

        private void mpSistemaCadUsuario_Click(object sender, EventArgs e)
        {
            uFrmListaCadUsuario form = new uFrmListaCadUsuario();
            form.ShowDialog();
        }

        private void uFrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Fecha a aplicação sem confirmação
        }

        private void mpCadastrosPessoas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<uFrmCadPessoa>();
        }

        private void mpCadReceitasReceita_Click(object sender, EventArgs e)
        {
            AbrirFormulario<uFrmCadReceitasReceita>();
        }

        private void mpCadReceitasTpReceita_Click(object sender, EventArgs e)
        {
            AbrirFormulario<uFrmCadReceitasTpReceita>();
        }

        private void mpCadDespesasDespesa_Click(object sender, EventArgs e)
        {
            AbrirFormulario<uFrmCadDespesasDespesa>();
        }

        private void mpCadDespesasTpDespesa_Click(object sender, EventArgs e)
        {
            AbrirFormulario<uFrmCadDespesasTpDespesa>();
        }

        private void mpCadDespesasCategoriaDespesa_Click(object sender, EventArgs e)
        {
            AbrirFormulario<uFrmCadDespesaCategoriaDespesa>();
        }
    }
}
