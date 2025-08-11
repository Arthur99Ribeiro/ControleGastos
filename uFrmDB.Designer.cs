namespace ControleGastos
{
    partial class uFrmDB
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
            lbServidor = new Label();
            lbPorta = new Label();
            lbDB = new Label();
            lbUsuario = new Label();
            lbSenha = new Label();
            txServidor = new TextBox();
            txPorta = new TextBox();
            txBanco = new TextBox();
            txUsuario = new TextBox();
            txSenha = new TextBox();
            gbDadosDB = new GroupBox();
            lbExcluir = new Label();
            lbSalvar = new Label();
            txNomeConexao = new TextBox();
            lbNomeConexao = new Label();
            chkSSL = new CheckBox();
            gbDadosDB.SuspendLayout();
            SuspendLayout();
            // 
            // lbServidor
            // 
            lbServidor.AutoSize = true;
            lbServidor.Location = new Point(16, 71);
            lbServidor.Name = "lbServidor";
            lbServidor.Size = new Size(50, 15);
            lbServidor.TabIndex = 0;
            lbServidor.Text = "Servidor";
            // 
            // lbPorta
            // 
            lbPorta.AutoSize = true;
            lbPorta.Location = new Point(16, 115);
            lbPorta.Name = "lbPorta";
            lbPorta.Size = new Size(35, 15);
            lbPorta.TabIndex = 1;
            lbPorta.Text = "Porta";
            // 
            // lbDB
            // 
            lbDB.AutoSize = true;
            lbDB.Location = new Point(16, 159);
            lbDB.Name = "lbDB";
            lbDB.Size = new Size(40, 15);
            lbDB.TabIndex = 2;
            lbDB.Text = "Banco";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(193, 71);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 3;
            lbUsuario.Text = "Usuario";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(193, 115);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 4;
            lbSenha.Text = "Senha";
            // 
            // txServidor
            // 
            txServidor.Cursor = Cursors.IBeam;
            txServidor.Location = new Point(16, 89);
            txServidor.Name = "txServidor";
            txServidor.Size = new Size(151, 23);
            txServidor.TabIndex = 5;
            txServidor.Enter += txServidor_Enter;
            txServidor.Leave += txServidor_Leave;
            // 
            // txPorta
            // 
            txPorta.Cursor = Cursors.IBeam;
            txPorta.Location = new Point(17, 133);
            txPorta.Name = "txPorta";
            txPorta.Size = new Size(151, 23);
            txPorta.TabIndex = 6;
            txPorta.Enter += txPorta_Enter;
            txPorta.Leave += txPorta_Leave;
            // 
            // txBanco
            // 
            txBanco.Cursor = Cursors.IBeam;
            txBanco.Location = new Point(17, 177);
            txBanco.Name = "txBanco";
            txBanco.Size = new Size(151, 23);
            txBanco.TabIndex = 7;
            txBanco.Enter += txBanco_Enter;
            txBanco.Leave += txBanco_Leave;
            // 
            // txUsuario
            // 
            txUsuario.Cursor = Cursors.IBeam;
            txUsuario.Location = new Point(193, 89);
            txUsuario.Name = "txUsuario";
            txUsuario.Size = new Size(151, 23);
            txUsuario.TabIndex = 8;
            txUsuario.Enter += txUsuario_Enter;
            txUsuario.Leave += txUsuario_Leave;
            // 
            // txSenha
            // 
            txSenha.Location = new Point(193, 133);
            txSenha.Name = "txSenha";
            txSenha.Size = new Size(151, 23);
            txSenha.TabIndex = 9;
            txSenha.UseSystemPasswordChar = true;
            txSenha.Enter += txSenha_Enter;
            txSenha.Leave += txSenha_Leave;
            // 
            // gbDadosDB
            // 
            gbDadosDB.Controls.Add(lbExcluir);
            gbDadosDB.Controls.Add(lbSalvar);
            gbDadosDB.Controls.Add(txNomeConexao);
            gbDadosDB.Controls.Add(lbNomeConexao);
            gbDadosDB.Controls.Add(lbUsuario);
            gbDadosDB.Controls.Add(txUsuario);
            gbDadosDB.Controls.Add(lbSenha);
            gbDadosDB.Controls.Add(chkSSL);
            gbDadosDB.Controls.Add(txSenha);
            gbDadosDB.Controls.Add(lbServidor);
            gbDadosDB.Controls.Add(lbPorta);
            gbDadosDB.Controls.Add(lbDB);
            gbDadosDB.Controls.Add(txBanco);
            gbDadosDB.Controls.Add(txServidor);
            gbDadosDB.Controls.Add(txPorta);
            gbDadosDB.Location = new Point(12, 12);
            gbDadosDB.Name = "gbDadosDB";
            gbDadosDB.Size = new Size(379, 214);
            gbDadosDB.TabIndex = 10;
            gbDadosDB.TabStop = false;
            gbDadosDB.Text = "Dados de Conexão do Banco";
            // 
            // lbExcluir
            // 
            lbExcluir.AutoSize = true;
            lbExcluir.Cursor = Cursors.Hand;
            lbExcluir.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbExcluir.ForeColor = Color.DarkRed;
            lbExcluir.Location = new Point(307, 168);
            lbExcluir.Name = "lbExcluir";
            lbExcluir.Size = new Size(46, 32);
            lbExcluir.TabIndex = 13;
            lbExcluir.Text = "";
            lbExcluir.Click += lbExcluir_Click;
            lbExcluir.MouseEnter += lbExcluir_MouseEnter;
            lbExcluir.MouseLeave += lbExcluir_MouseLeave;
            // 
            // lbSalvar
            // 
            lbSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSalvar.AutoSize = true;
            lbSalvar.BackColor = Color.Transparent;
            lbSalvar.Cursor = Cursors.Hand;
            lbSalvar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSalvar.ForeColor = Color.MidnightBlue;
            lbSalvar.Location = new Point(265, 168);
            lbSalvar.Name = "lbSalvar";
            lbSalvar.Size = new Size(46, 32);
            lbSalvar.TabIndex = 12;
            lbSalvar.Text = "";
            lbSalvar.TextAlign = ContentAlignment.MiddleCenter;
            lbSalvar.Click += lbSalvar_Click;
            lbSalvar.MouseEnter += lbSalvar_MouseEnter;
            lbSalvar.MouseLeave += lbSalvar_MouseLeave;
            // 
            // txNomeConexao
            // 
            txNomeConexao.Cursor = Cursors.IBeam;
            txNomeConexao.Location = new Point(17, 45);
            txNomeConexao.Name = "txNomeConexao";
            txNomeConexao.Size = new Size(327, 23);
            txNomeConexao.TabIndex = 11;
            txNomeConexao.Enter += txNomeConexao_Enter;
            txNomeConexao.Leave += txNomeConexao_Leave;
            // 
            // lbNomeConexao
            // 
            lbNomeConexao.AutoSize = true;
            lbNomeConexao.Location = new Point(17, 27);
            lbNomeConexao.Name = "lbNomeConexao";
            lbNomeConexao.Size = new Size(106, 15);
            lbNomeConexao.TabIndex = 10;
            lbNomeConexao.Text = "Nome da Conexão";
            // 
            // chkSSL
            // 
            chkSSL.AutoSize = true;
            chkSSL.Location = new Point(193, 177);
            chkSSL.Name = "chkSSL";
            chkSSL.Size = new Size(66, 19);
            chkSSL.TabIndex = 8;
            chkSSL.Text = "Usa SSL";
            chkSSL.UseVisualStyleBackColor = true;
            // 
            // uFrmDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 231);
            Controls.Add(gbDadosDB);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uFrmDB";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Database";
            Load += uFrmDB_Load;
            gbDadosDB.ResumeLayout(false);
            gbDadosDB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbServidor;
        private Label lbPorta;
        private Label lbDB;
        private Label lbUsuario;
        private Label lbSenha;
        private TextBox txServidor;
        private TextBox txPorta;
        private TextBox txBanco;
        private TextBox txUsuario;
        private TextBox txSenha;
        private GroupBox gbDadosDB;
        private CheckBox chkSSL;
        private Label lbNomeConexao;
        private TextBox txNomeConexao;
        private Label lbSalvar;
        private Label lbExcluir;
    }
}