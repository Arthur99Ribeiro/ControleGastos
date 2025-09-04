namespace ControleGastos
{
    partial class uFrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPrincipal = new MenuStrip();
            menuPrincipalSistema = new ToolStripMenuItem();
            mpSistemaLogInOut = new ToolStripMenuItem();
            mpSistemaCadUsuario = new ToolStripMenuItem();
            menuPrincipalCadastros = new ToolStripMenuItem();
            mpCadastrosPessoas = new ToolStripMenuItem();
            menuPrincipalCadastrosReceitas = new ToolStripMenuItem();
            mpCadReceitasReceita = new ToolStripMenuItem();
            mpCadReceitasTpReceita = new ToolStripMenuItem();
            menuPrincipalCadastrosGastos = new ToolStripMenuItem();
            mpCadDespesasDespesa = new ToolStripMenuItem();
            mpCadDespesasTpDespesa = new ToolStripMenuItem();
            menuPrincipalLancamentos = new ToolStripMenuItem();
            menuPrincipalGraficos = new ToolStripMenuItem();
            menuPrincipalRelatorios = new ToolStripMenuItem();
            stUsuarioLogado = new StatusStrip();
            lbUsuarioLogado = new ToolStripStatusLabel();
            mpCadDespesasCategoriaDespesa = new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            stUsuarioLogado.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.AllowClickThrough = true;
            menuPrincipal.Items.AddRange(new ToolStripItem[] { menuPrincipalSistema, menuPrincipalCadastros, menuPrincipalLancamentos, menuPrincipalGraficos, menuPrincipalRelatorios });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(1904, 24);
            menuPrincipal.TabIndex = 1;
            menuPrincipal.Text = "Menus";
            // 
            // menuPrincipalSistema
            // 
            menuPrincipalSistema.DropDownItems.AddRange(new ToolStripItem[] { mpSistemaLogInOut, mpSistemaCadUsuario });
            menuPrincipalSistema.Name = "menuPrincipalSistema";
            menuPrincipalSistema.Size = new Size(60, 20);
            menuPrincipalSistema.Text = "Sistema";
            // 
            // mpSistemaLogInOut
            // 
            mpSistemaLogInOut.Name = "mpSistemaLogInOut";
            mpSistemaLogInOut.Size = new Size(180, 22);
            mpSistemaLogInOut.Text = "LogIn/Out";
            mpSistemaLogInOut.Click += mpSistemaLogInOut_Click;
            // 
            // mpSistemaCadUsuario
            // 
            mpSistemaCadUsuario.Name = "mpSistemaCadUsuario";
            mpSistemaCadUsuario.Size = new Size(180, 22);
            mpSistemaCadUsuario.Text = "Cadastro de Usuario";
            mpSistemaCadUsuario.Click += mpSistemaCadUsuario_Click;
            // 
            // menuPrincipalCadastros
            // 
            menuPrincipalCadastros.DropDownItems.AddRange(new ToolStripItem[] { mpCadastrosPessoas, menuPrincipalCadastrosReceitas, menuPrincipalCadastrosGastos });
            menuPrincipalCadastros.Name = "menuPrincipalCadastros";
            menuPrincipalCadastros.Size = new Size(71, 20);
            menuPrincipalCadastros.Text = "Cadastros";
            // 
            // mpCadastrosPessoas
            // 
            mpCadastrosPessoas.Name = "mpCadastrosPessoas";
            mpCadastrosPessoas.Size = new Size(180, 22);
            mpCadastrosPessoas.Text = "Pessoas";
            mpCadastrosPessoas.Click += mpCadastrosPessoas_Click;
            // 
            // menuPrincipalCadastrosReceitas
            // 
            menuPrincipalCadastrosReceitas.DropDownItems.AddRange(new ToolStripItem[] { mpCadReceitasReceita, mpCadReceitasTpReceita });
            menuPrincipalCadastrosReceitas.Name = "menuPrincipalCadastrosReceitas";
            menuPrincipalCadastrosReceitas.Size = new Size(180, 22);
            menuPrincipalCadastrosReceitas.Text = "Receitas";
            // 
            // mpCadReceitasReceita
            // 
            mpCadReceitasReceita.Name = "mpCadReceitasReceita";
            mpCadReceitasReceita.Size = new Size(180, 22);
            mpCadReceitasReceita.Text = "Receita";
            mpCadReceitasReceita.Click += mpCadReceitasReceita_Click;
            // 
            // mpCadReceitasTpReceita
            // 
            mpCadReceitasTpReceita.Name = "mpCadReceitasTpReceita";
            mpCadReceitasTpReceita.Size = new Size(180, 22);
            mpCadReceitasTpReceita.Text = "Tipo de Receita";
            mpCadReceitasTpReceita.Click += mpCadReceitasTpReceita_Click;
            // 
            // menuPrincipalCadastrosGastos
            // 
            menuPrincipalCadastrosGastos.DropDownItems.AddRange(new ToolStripItem[] { mpCadDespesasDespesa, mpCadDespesasTpDespesa, mpCadDespesasCategoriaDespesa });
            menuPrincipalCadastrosGastos.Name = "menuPrincipalCadastrosGastos";
            menuPrincipalCadastrosGastos.Size = new Size(180, 22);
            menuPrincipalCadastrosGastos.Text = "Despesas";
            // 
            // mpCadDespesasDespesa
            // 
            mpCadDespesasDespesa.Name = "mpCadDespesasDespesa";
            mpCadDespesasDespesa.Size = new Size(180, 22);
            mpCadDespesasDespesa.Text = "Despesa";
            mpCadDespesasDespesa.Click += mpCadDespesasDespesa_Click;
            // 
            // mpCadDespesasTpDespesa
            // 
            mpCadDespesasTpDespesa.Name = "mpCadDespesasTpDespesa";
            mpCadDespesasTpDespesa.Size = new Size(180, 22);
            mpCadDespesasTpDespesa.Text = "Tipo de Despesa";
            mpCadDespesasTpDespesa.Click += mpCadDespesasTpDespesa_Click;
            // 
            // menuPrincipalLancamentos
            // 
            menuPrincipalLancamentos.Name = "menuPrincipalLancamentos";
            menuPrincipalLancamentos.Size = new Size(90, 20);
            menuPrincipalLancamentos.Text = "Lançamentos";
            // 
            // menuPrincipalGraficos
            // 
            menuPrincipalGraficos.Name = "menuPrincipalGraficos";
            menuPrincipalGraficos.Size = new Size(62, 20);
            menuPrincipalGraficos.Text = "Graficos";
            // 
            // menuPrincipalRelatorios
            // 
            menuPrincipalRelatorios.Name = "menuPrincipalRelatorios";
            menuPrincipalRelatorios.Size = new Size(71, 20);
            menuPrincipalRelatorios.Text = "Relatorios";
            // 
            // stUsuarioLogado
            // 
            stUsuarioLogado.Items.AddRange(new ToolStripItem[] { lbUsuarioLogado });
            stUsuarioLogado.Location = new Point(0, 1019);
            stUsuarioLogado.Name = "stUsuarioLogado";
            stUsuarioLogado.Size = new Size(1904, 22);
            stUsuarioLogado.TabIndex = 3;
            stUsuarioLogado.Text = "UsuarioLogado";
            // 
            // lbUsuarioLogado
            // 
            lbUsuarioLogado.Name = "lbUsuarioLogado";
            lbUsuarioLogado.Size = new Size(0, 17);
            // 
            // mpCadDespesasCategoriaDespesa
            // 
            mpCadDespesasCategoriaDespesa.Name = "mpCadDespesasCategoriaDespesa";
            mpCadDespesasCategoriaDespesa.Size = new Size(180, 22);
            mpCadDespesasCategoriaDespesa.Text = "Categoria Desepesa";
            mpCadDespesasCategoriaDespesa.Click += mpCadDespesasCategoriaDespesa_Click;
            // 
            // uFrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1904, 1041);
            Controls.Add(stUsuarioLogado);
            Controls.Add(menuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipal;
            Name = "uFrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Gastos";
            WindowState = FormWindowState.Maximized;
            FormClosing += uFrmPrincipal_FormClosing;
            Load += uFrmPrincipal_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            stUsuarioLogado.ResumeLayout(false);
            stUsuarioLogado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menuPrincipalSistema;
        private ToolStripMenuItem menuPrincipalCadastros;
        private ToolStripMenuItem menuPrincipalGraficos;
        private ToolStripMenuItem menuPrincipalRelatorios;
        private ToolStripMenuItem mpCadastrosPessoas;
        private ToolStripMenuItem menuPrincipalCadastrosReceitas;
        private ToolStripMenuItem menuPrincipalCadastrosGastos;
        private ToolStripMenuItem mpSistemaLogInOut;
        private ToolStripMenuItem mpSistemaCadUsuario;
        private StatusStrip stUsuarioLogado;
        private ToolStripStatusLabel lbUsuarioLogado;
        private ToolStripMenuItem mpCadReceitasTpReceita;
        private ToolStripMenuItem mpCadReceitasReceita;
        private ToolStripMenuItem mpCadDespesasDespesa;
        private ToolStripMenuItem mpCadDespesasTpDespesa;
        private ToolStripMenuItem menuPrincipalLancamentos;
        private ToolStripMenuItem mpCadDespesasCategoriaDespesa;
    }
}
