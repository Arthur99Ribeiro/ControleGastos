namespace ControleGastos
{
    partial class uFrmCadUsuario
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
            lbCadUsuario = new Label();
            lbCadSenha = new Label();
            lbCadEmail = new Label();
            txCadUsuario = new TextBox();
            txCadSenha = new TextBox();
            txCadEmail = new TextBox();
            lbCadUsuarioCancelar = new Label();
            lbCadUsuarioSalvar = new Label();
            lbCadRevelaSenha = new Label();
            SuspendLayout();
            // 
            // lbCadUsuario
            // 
            lbCadUsuario.AutoSize = true;
            lbCadUsuario.Location = new Point(12, 9);
            lbCadUsuario.Name = "lbCadUsuario";
            lbCadUsuario.Size = new Size(47, 15);
            lbCadUsuario.TabIndex = 0;
            lbCadUsuario.Text = "Usuario";
            // 
            // lbCadSenha
            // 
            lbCadSenha.AutoSize = true;
            lbCadSenha.Location = new Point(12, 53);
            lbCadSenha.Name = "lbCadSenha";
            lbCadSenha.Size = new Size(39, 15);
            lbCadSenha.TabIndex = 1;
            lbCadSenha.Text = "Senha";
            // 
            // lbCadEmail
            // 
            lbCadEmail.AutoSize = true;
            lbCadEmail.Location = new Point(12, 97);
            lbCadEmail.Name = "lbCadEmail";
            lbCadEmail.Size = new Size(36, 15);
            lbCadEmail.TabIndex = 2;
            lbCadEmail.Text = "Email";
            // 
            // txCadUsuario
            // 
            txCadUsuario.Cursor = Cursors.IBeam;
            txCadUsuario.Location = new Point(12, 27);
            txCadUsuario.Name = "txCadUsuario";
            txCadUsuario.Size = new Size(307, 23);
            txCadUsuario.TabIndex = 3;
            txCadUsuario.Enter += txCadUsuario_Enter;
            txCadUsuario.Leave += txCadUsuario_Leave;
            // 
            // txCadSenha
            // 
            txCadSenha.Cursor = Cursors.IBeam;
            txCadSenha.Location = new Point(12, 71);
            txCadSenha.Name = "txCadSenha";
            txCadSenha.Size = new Size(276, 23);
            txCadSenha.TabIndex = 4;
            txCadSenha.UseSystemPasswordChar = true;
            txCadSenha.Enter += txCadSenha_Enter;
            txCadSenha.Leave += txCadSenha_Leave;
            // 
            // txCadEmail
            // 
            txCadEmail.Cursor = Cursors.IBeam;
            txCadEmail.Location = new Point(12, 115);
            txCadEmail.Name = "txCadEmail";
            txCadEmail.Size = new Size(307, 23);
            txCadEmail.TabIndex = 5;
            txCadEmail.Enter += txCadEmail_Enter;
            txCadEmail.Leave += txCadEmail_Leave;
            // 
            // lbCadUsuarioCancelar
            // 
            lbCadUsuarioCancelar.AutoSize = true;
            lbCadUsuarioCancelar.Cursor = Cursors.Hand;
            lbCadUsuarioCancelar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCadUsuarioCancelar.ForeColor = Color.DarkRed;
            lbCadUsuarioCancelar.Location = new Point(12, 148);
            lbCadUsuarioCancelar.Name = "lbCadUsuarioCancelar";
            lbCadUsuarioCancelar.Size = new Size(46, 32);
            lbCadUsuarioCancelar.TabIndex = 6;
            lbCadUsuarioCancelar.Text = "";
            lbCadUsuarioCancelar.Click += lbCadUsuarioCancelar_Click;
            lbCadUsuarioCancelar.MouseEnter += lbCadUsuarioCancelar_MouseEnter;
            lbCadUsuarioCancelar.MouseLeave += lbCadUsuarioCancelar_MouseLeave;
            // 
            // lbCadUsuarioSalvar
            // 
            lbCadUsuarioSalvar.AutoSize = true;
            lbCadUsuarioSalvar.Cursor = Cursors.Hand;
            lbCadUsuarioSalvar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCadUsuarioSalvar.ForeColor = Color.MidnightBlue;
            lbCadUsuarioSalvar.Location = new Point(273, 148);
            lbCadUsuarioSalvar.Name = "lbCadUsuarioSalvar";
            lbCadUsuarioSalvar.Size = new Size(46, 32);
            lbCadUsuarioSalvar.TabIndex = 7;
            lbCadUsuarioSalvar.Text = "";
            lbCadUsuarioSalvar.Click += lbCadUsuarioSalvar_Click;
            lbCadUsuarioSalvar.MouseEnter += lbCadUsuarioSalvar_MouseEnter;
            lbCadUsuarioSalvar.MouseLeave += lbCadUsuarioSalvar_MouseLeave;
            // 
            // lbCadRevelaSenha
            // 
            lbCadRevelaSenha.AutoSize = true;
            lbCadRevelaSenha.Cursor = Cursors.Hand;
            lbCadRevelaSenha.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCadRevelaSenha.ForeColor = Color.DarkBlue;
            lbCadRevelaSenha.Location = new Point(294, 75);
            lbCadRevelaSenha.Name = "lbCadRevelaSenha";
            lbCadRevelaSenha.Size = new Size(23, 16);
            lbCadRevelaSenha.TabIndex = 8;
            lbCadRevelaSenha.Text = "";
            lbCadRevelaSenha.TextAlign = ContentAlignment.MiddleCenter;
            lbCadRevelaSenha.Click += lbCadRevelaSenha_Click;
            lbCadRevelaSenha.Enter += lbCadRevelaSenha_Enter;
            lbCadRevelaSenha.Leave += lbCadRevelaSenha_Leave;
            // 
            // uFrmCadUsuario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(326, 189);
            Controls.Add(lbCadRevelaSenha);
            Controls.Add(lbCadUsuarioSalvar);
            Controls.Add(lbCadUsuarioCancelar);
            Controls.Add(txCadEmail);
            Controls.Add(txCadSenha);
            Controls.Add(txCadUsuario);
            Controls.Add(lbCadEmail);
            Controls.Add(lbCadSenha);
            Controls.Add(lbCadUsuario);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "uFrmCadUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCadUsuario;
        private Label lbCadSenha;
        private Label lbCadEmail;
        private TextBox txCadUsuario;
        private TextBox txCadSenha;
        private TextBox txCadEmail;
        private Label lbCadUsuarioCancelar;
        private Label lbCadUsuarioSalvar;
        private Label lbCadRevelaSenha;
    }
}