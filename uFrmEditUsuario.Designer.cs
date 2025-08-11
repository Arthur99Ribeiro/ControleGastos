namespace ControleGastos
{
    partial class uFrmEditUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbEditUsuario = new GroupBox();
            lbEditRevalaSenha = new Label();
            lbEditSalvar = new Label();
            lbEditCancelar = new Label();
            txQtdErroLogin = new TextBox();
            txEditEmail = new TextBox();
            txEditSenha = new TextBox();
            txEditUsuario = new TextBox();
            lbEditQtdErroLogin = new Label();
            lbEditEmail = new Label();
            lbEditSenha = new Label();
            lbEditUsuario = new Label();
            gbEditUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // gbEditUsuario
            // 
            gbEditUsuario.Controls.Add(lbEditRevalaSenha);
            gbEditUsuario.Controls.Add(lbEditSalvar);
            gbEditUsuario.Controls.Add(lbEditCancelar);
            gbEditUsuario.Controls.Add(txQtdErroLogin);
            gbEditUsuario.Controls.Add(txEditEmail);
            gbEditUsuario.Controls.Add(txEditSenha);
            gbEditUsuario.Controls.Add(txEditUsuario);
            gbEditUsuario.Controls.Add(lbEditQtdErroLogin);
            gbEditUsuario.Controls.Add(lbEditEmail);
            gbEditUsuario.Controls.Add(lbEditSenha);
            gbEditUsuario.Controls.Add(lbEditUsuario);
            gbEditUsuario.Location = new Point(12, 12);
            gbEditUsuario.Name = "gbEditUsuario";
            gbEditUsuario.Size = new Size(354, 207);
            gbEditUsuario.TabIndex = 0;
            gbEditUsuario.TabStop = false;
            gbEditUsuario.Text = "Dados Usuario";
            // 
            // lbEditRevalaSenha
            // 
            lbEditRevalaSenha.AutoSize = true;
            lbEditRevalaSenha.Cursor = Cursors.Hand;
            lbEditRevalaSenha.Font = new Font("Segoe MDL2 Assets", 12F);
            lbEditRevalaSenha.ForeColor = Color.DarkBlue;
            lbEditRevalaSenha.Location = new Point(319, 86);
            lbEditRevalaSenha.Name = "lbEditRevalaSenha";
            lbEditRevalaSenha.Size = new Size(23, 16);
            lbEditRevalaSenha.TabIndex = 10;
            lbEditRevalaSenha.Text = "";
            lbEditRevalaSenha.TextAlign = ContentAlignment.MiddleCenter;
            lbEditRevalaSenha.Click += lbEditRevalaSenha_Click;
            lbEditRevalaSenha.Enter += lbEditRevalaSenha_Enter;
            lbEditRevalaSenha.Leave += lbEditRevalaSenha_Leave;
            // 
            // lbEditSalvar
            // 
            lbEditSalvar.AutoSize = true;
            lbEditSalvar.Cursor = Cursors.Hand;
            lbEditSalvar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEditSalvar.ForeColor = Color.DarkBlue;
            lbEditSalvar.Location = new Point(302, 161);
            lbEditSalvar.Name = "lbEditSalvar";
            lbEditSalvar.Size = new Size(46, 32);
            lbEditSalvar.TabIndex = 9;
            lbEditSalvar.Text = "";
            lbEditSalvar.Click += lbEditSalvar_Click;
            lbEditSalvar.Enter += lbEditSalvar_Enter;
            lbEditSalvar.Leave += lbEditSalvar_Leave;
            // 
            // lbEditCancelar
            // 
            lbEditCancelar.AutoSize = true;
            lbEditCancelar.Cursor = Cursors.Hand;
            lbEditCancelar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEditCancelar.ForeColor = Color.DarkRed;
            lbEditCancelar.Location = new Point(250, 161);
            lbEditCancelar.Name = "lbEditCancelar";
            lbEditCancelar.Size = new Size(46, 32);
            lbEditCancelar.TabIndex = 8;
            lbEditCancelar.Text = "";
            lbEditCancelar.Click += lbEditCancelar_Click;
            lbEditCancelar.Enter += lbEditCancelar_Enter;
            lbEditCancelar.Leave += lbEditCancelar_Leave;
            // 
            // txQtdErroLogin
            // 
            txQtdErroLogin.Cursor = Cursors.IBeam;
            txQtdErroLogin.Location = new Point(6, 170);
            txQtdErroLogin.Name = "txQtdErroLogin";
            txQtdErroLogin.Size = new Size(238, 23);
            txQtdErroLogin.TabIndex = 7;
            txQtdErroLogin.Enter += txQtdErroLogin_Enter;
            txQtdErroLogin.Leave += txQtdErroLogin_Leave;
            // 
            // txEditEmail
            // 
            txEditEmail.Cursor = Cursors.IBeam;
            txEditEmail.Location = new Point(6, 126);
            txEditEmail.Name = "txEditEmail";
            txEditEmail.Size = new Size(342, 23);
            txEditEmail.TabIndex = 6;
            txEditEmail.Enter += txEditEmail_Enter;
            txEditEmail.Leave += txEditEmail_Leave;
            // 
            // txEditSenha
            // 
            txEditSenha.Cursor = Cursors.IBeam;
            txEditSenha.ImeMode = ImeMode.NoControl;
            txEditSenha.Location = new Point(6, 82);
            txEditSenha.Name = "txEditSenha";
            txEditSenha.PlaceholderText = "Para não alterar a senha deixe em branco";
            txEditSenha.Size = new Size(306, 23);
            txEditSenha.TabIndex = 5;
            txEditSenha.UseSystemPasswordChar = true;
            txEditSenha.Enter += txEditSenha_Enter;
            txEditSenha.Leave += txEditSenha_Leave;
            // 
            // txEditUsuario
            // 
            txEditUsuario.Cursor = Cursors.IBeam;
            txEditUsuario.Location = new Point(6, 38);
            txEditUsuario.Name = "txEditUsuario";
            txEditUsuario.Size = new Size(342, 23);
            txEditUsuario.TabIndex = 4;
            txEditUsuario.Enter += txEditUsuario_Enter;
            txEditUsuario.Leave += txEditUsuario_Leave;
            // 
            // lbEditQtdErroLogin
            // 
            lbEditQtdErroLogin.AutoSize = true;
            lbEditQtdErroLogin.Location = new Point(6, 152);
            lbEditQtdErroLogin.Name = "lbEditQtdErroLogin";
            lbEditQtdErroLogin.Size = new Size(82, 15);
            lbEditQtdErroLogin.TabIndex = 3;
            lbEditQtdErroLogin.Text = "Erros de Login";
            // 
            // lbEditEmail
            // 
            lbEditEmail.AutoSize = true;
            lbEditEmail.Location = new Point(6, 108);
            lbEditEmail.Name = "lbEditEmail";
            lbEditEmail.Size = new Size(36, 15);
            lbEditEmail.TabIndex = 2;
            lbEditEmail.Text = "Email";
            // 
            // lbEditSenha
            // 
            lbEditSenha.AutoSize = true;
            lbEditSenha.Location = new Point(6, 64);
            lbEditSenha.Name = "lbEditSenha";
            lbEditSenha.Size = new Size(39, 15);
            lbEditSenha.TabIndex = 1;
            lbEditSenha.Text = "Senha";
            // 
            // lbEditUsuario
            // 
            lbEditUsuario.AutoSize = true;
            lbEditUsuario.Location = new Point(6, 20);
            lbEditUsuario.Name = "lbEditUsuario";
            lbEditUsuario.Size = new Size(47, 15);
            lbEditUsuario.TabIndex = 0;
            lbEditUsuario.Text = "Usuario";
            // 
            // uFrmEditUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 227);
            Controls.Add(gbEditUsuario);
            Name = "uFrmEditUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editor de Usuario";
            gbEditUsuario.ResumeLayout(false);
            gbEditUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbEditUsuario;
        private Label lbEditUsuario;
        private Label lbEditQtdErroLogin;
        private Label lbEditEmail;
        private Label lbEditSenha;
        private TextBox txQtdErroLogin;
        private TextBox txEditEmail;
        private TextBox txEditSenha;
        private TextBox txEditUsuario;
        private Label lbEditSalvar;
        private Label lbEditCancelar;
        private Label lbEditRevalaSenha;
    }
}