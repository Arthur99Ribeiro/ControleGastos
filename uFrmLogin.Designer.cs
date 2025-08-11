namespace ControleGastos
{
    partial class uFrmLogin
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
            gbDatabse = new GroupBox();
            lbConectaDB = new Label();
            lbConfigDB = new Label();
            cbStrgDB = new ComboBox();
            gbLogin = new GroupBox();
            lkLbEsqSenha = new LinkLabel();
            btEntrar = new Button();
            txSenha = new TextBox();
            txUsuario = new TextBox();
            lbSenha = new Label();
            lbUsuario = new Label();
            gbCadastroUsuario = new GroupBox();
            lbCadUsuario = new Label();
            lbDesejaCadUsuario = new Label();
            gbDatabse.SuspendLayout();
            gbLogin.SuspendLayout();
            gbCadastroUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatabse
            // 
            gbDatabse.BackColor = Color.Transparent;
            gbDatabse.Controls.Add(lbConectaDB);
            gbDatabse.Controls.Add(lbConfigDB);
            gbDatabse.Controls.Add(cbStrgDB);
            gbDatabse.Location = new Point(232, 12);
            gbDatabse.Name = "gbDatabse";
            gbDatabse.Size = new Size(430, 130);
            gbDatabse.TabIndex = 0;
            gbDatabse.TabStop = false;
            gbDatabse.Text = "Database";
            // 
            // lbConectaDB
            // 
            lbConectaDB.AutoSize = true;
            lbConectaDB.Cursor = Cursors.Hand;
            lbConectaDB.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbConectaDB.ForeColor = Color.MidnightBlue;
            lbConectaDB.Location = new Point(326, 62);
            lbConectaDB.Name = "lbConectaDB";
            lbConectaDB.Size = new Size(23, 16);
            lbConectaDB.TabIndex = 2;
            lbConectaDB.Text = "";
            lbConectaDB.TextAlign = ContentAlignment.MiddleCenter;
            lbConectaDB.Click += lbConectaDB_Click;
            lbConectaDB.MouseEnter += lbConectaDB_MouseEnter;
            lbConectaDB.MouseLeave += lbConectaDB_MouseLeave;
            // 
            // lbConfigDB
            // 
            lbConfigDB.AutoSize = true;
            lbConfigDB.Cursor = Cursors.Hand;
            lbConfigDB.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbConfigDB.ForeColor = Color.MidnightBlue;
            lbConfigDB.Location = new Point(349, 62);
            lbConfigDB.Name = "lbConfigDB";
            lbConfigDB.Size = new Size(23, 16);
            lbConfigDB.TabIndex = 4;
            lbConfigDB.Text = "";
            lbConfigDB.TextAlign = ContentAlignment.MiddleCenter;
            lbConfigDB.Click += lbConfigDB_Click;
            lbConfigDB.MouseEnter += lbConfigDB_MouseEnter;
            lbConfigDB.MouseLeave += lbConfigDB_MouseLeave;
            // 
            // cbStrgDB
            // 
            cbStrgDB.FormattingEnabled = true;
            cbStrgDB.Items.AddRange(new object[] { "a" });
            cbStrgDB.Location = new Point(49, 59);
            cbStrgDB.Name = "cbStrgDB";
            cbStrgDB.Size = new Size(273, 23);
            cbStrgDB.TabIndex = 3;
            cbStrgDB.Enter += cbStrgDB_Enter;
            cbStrgDB.Leave += cbStrgDB_Leave;
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(lkLbEsqSenha);
            gbLogin.Controls.Add(btEntrar);
            gbLogin.Controls.Add(txSenha);
            gbLogin.Controls.Add(txUsuario);
            gbLogin.Controls.Add(lbSenha);
            gbLogin.Controls.Add(lbUsuario);
            gbLogin.Location = new Point(232, 145);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(430, 166);
            gbLogin.TabIndex = 1;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
            // 
            // lkLbEsqSenha
            // 
            lkLbEsqSenha.ActiveLinkColor = Color.DarkRed;
            lkLbEsqSenha.AutoSize = true;
            lkLbEsqSenha.Cursor = Cursors.Hand;
            lkLbEsqSenha.LinkColor = Color.MidnightBlue;
            lkLbEsqSenha.Location = new Point(49, 122);
            lkLbEsqSenha.Name = "lkLbEsqSenha";
            lkLbEsqSenha.Size = new Size(161, 15);
            lkLbEsqSenha.TabIndex = 5;
            lkLbEsqSenha.TabStop = true;
            lkLbEsqSenha.Text = "Esqueceu seu usuario/senha?";
            lkLbEsqSenha.LinkClicked += lkLbEsqSenha_LinkClicked;
            // 
            // btEntrar
            // 
            btEntrar.Cursor = Cursors.Hand;
            btEntrar.Location = new Point(269, 118);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(75, 23);
            btEntrar.TabIndex = 4;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = true;
            btEntrar.Click += btEntrar_Click;
            // 
            // txSenha
            // 
            txSenha.CharacterCasing = CharacterCasing.Lower;
            txSenha.Cursor = Cursors.IBeam;
            txSenha.Location = new Point(49, 81);
            txSenha.Name = "txSenha";
            txSenha.Size = new Size(295, 23);
            txSenha.TabIndex = 3;
            txSenha.UseSystemPasswordChar = true;
            txSenha.Enter += txSenha_Enter;
            txSenha.Leave += txSenha_Leave;
            // 
            // txUsuario
            // 
            txUsuario.Cursor = Cursors.IBeam;
            txUsuario.Location = new Point(49, 37);
            txUsuario.Name = "txUsuario";
            txUsuario.Size = new Size(295, 23);
            txUsuario.TabIndex = 2;
            txUsuario.Enter += txUsuario_Enter;
            txUsuario.Leave += txUsuario_Leave;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(49, 63);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 1;
            lbSenha.Text = "Senha";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(49, 19);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuario";
            // 
            // gbCadastroUsuario
            // 
            gbCadastroUsuario.Controls.Add(lbCadUsuario);
            gbCadastroUsuario.Controls.Add(lbDesejaCadUsuario);
            gbCadastroUsuario.Location = new Point(12, 145);
            gbCadastroUsuario.Name = "gbCadastroUsuario";
            gbCadastroUsuario.Size = new Size(214, 166);
            gbCadastroUsuario.TabIndex = 2;
            gbCadastroUsuario.TabStop = false;
            gbCadastroUsuario.Text = "Cadastro de Usuario";
            // 
            // lbCadUsuario
            // 
            lbCadUsuario.AutoSize = true;
            lbCadUsuario.Cursor = Cursors.Hand;
            lbCadUsuario.Font = new Font("Segoe MDL2 Assets", 25F);
            lbCadUsuario.ForeColor = Color.MidnightBlue;
            lbCadUsuario.Location = new Point(74, 104);
            lbCadUsuario.Name = "lbCadUsuario";
            lbCadUsuario.Size = new Size(49, 34);
            lbCadUsuario.TabIndex = 1;
            lbCadUsuario.Text = "";
            lbCadUsuario.TextAlign = ContentAlignment.MiddleCenter;
            lbCadUsuario.Click += lbCadUsuario_Click;
            lbCadUsuario.MouseEnter += lbCadUsuario_MouseEnter;
            lbCadUsuario.MouseLeave += lbCadUsuario_MouseLeave;
            // 
            // lbDesejaCadUsuario
            // 
            lbDesejaCadUsuario.Font = new Font("Segoe UI", 12F);
            lbDesejaCadUsuario.Location = new Point(30, 37);
            lbDesejaCadUsuario.Name = "lbDesejaCadUsuario";
            lbDesejaCadUsuario.Size = new Size(147, 50);
            lbDesejaCadUsuario.TabIndex = 0;
            lbDesejaCadUsuario.Text = "Deseja cadastrar um novo usuario?";
            lbDesejaCadUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uFrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 316);
            Controls.Add(gbCadastroUsuario);
            Controls.Add(gbLogin);
            Controls.Add(gbDatabse);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "uFrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += uFrmLogin_FormClosing;
            Load += uFrmLogin_Load;
            gbDatabse.ResumeLayout(false);
            gbDatabse.PerformLayout();
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            gbCadastroUsuario.ResumeLayout(false);
            gbCadastroUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatabse;
        private GroupBox gbLogin;
        private Label lbUsuario;
        private TextBox txSenha;
        private TextBox txUsuario;
        private Label lbSenha;
        private Button btEntrar;
        private ComboBox cbStrgDB;
        private Label lbConfigDB;
        private LinkLabel lkLbEsqSenha;
        private Label lbConectaDB;
        private GroupBox gbCadastroUsuario;
        private Label lbCadUsuario;
        private Label lbDesejaCadUsuario;
    }
}