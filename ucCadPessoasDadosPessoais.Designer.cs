namespace ControleGastos
{
    partial class ucCadPessoasDadosPessoais
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gbUcCadPessoasDadosPessoais = new GroupBox();
            mtxUcCadPessoasDadosPessoaisCPF = new MaskedTextBox();
            mtxUcCadPessoasDadosPessoaisTelefone = new MaskedTextBox();
            lbUcCadPessoasDadosPessoaisTelefone = new Label();
            dtpUcCadPessoasDadosPessoaisDataNascimento = new DateTimePicker();
            lbUcCadPessoasDadosPessoaisDataNascimento = new Label();
            lbUcCadPessoasDadosPessoaisCPF = new Label();
            txUcCadPessoasDadosPessoaisNome = new TextBox();
            lbUcCadPessoasDadosPessoaisNome = new Label();
            gbUcCadPessoasDadosPessoais.SuspendLayout();
            SuspendLayout();
            // 
            // gbUcCadPessoasDadosPessoais
            // 
            gbUcCadPessoasDadosPessoais.Controls.Add(mtxUcCadPessoasDadosPessoaisCPF);
            gbUcCadPessoasDadosPessoais.Controls.Add(mtxUcCadPessoasDadosPessoaisTelefone);
            gbUcCadPessoasDadosPessoais.Controls.Add(lbUcCadPessoasDadosPessoaisTelefone);
            gbUcCadPessoasDadosPessoais.Controls.Add(dtpUcCadPessoasDadosPessoaisDataNascimento);
            gbUcCadPessoasDadosPessoais.Controls.Add(lbUcCadPessoasDadosPessoaisDataNascimento);
            gbUcCadPessoasDadosPessoais.Controls.Add(lbUcCadPessoasDadosPessoaisCPF);
            gbUcCadPessoasDadosPessoais.Controls.Add(txUcCadPessoasDadosPessoaisNome);
            gbUcCadPessoasDadosPessoais.Controls.Add(lbUcCadPessoasDadosPessoaisNome);
            gbUcCadPessoasDadosPessoais.Location = new Point(3, 3);
            gbUcCadPessoasDadosPessoais.Name = "gbUcCadPessoasDadosPessoais";
            gbUcCadPessoasDadosPessoais.Size = new Size(293, 207);
            gbUcCadPessoasDadosPessoais.TabIndex = 6;
            gbUcCadPessoasDadosPessoais.TabStop = false;
            gbUcCadPessoasDadosPessoais.Text = "Dados Pessoais";
            // 
            // mtxUcCadPessoasDadosPessoaisCPF
            // 
            mtxUcCadPessoasDadosPessoaisCPF.Cursor = Cursors.IBeam;
            mtxUcCadPessoasDadosPessoaisCPF.Location = new Point(7, 81);
            mtxUcCadPessoasDadosPessoaisCPF.Mask = "000\\.000\\.000\\-00";
            mtxUcCadPessoasDadosPessoaisCPF.Name = "mtxUcCadPessoasDadosPessoaisCPF";
            mtxUcCadPessoasDadosPessoaisCPF.Size = new Size(114, 23);
            mtxUcCadPessoasDadosPessoaisCPF.TabIndex = 2;
            mtxUcCadPessoasDadosPessoaisCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxUcCadPessoasDadosPessoaisCPF.Enter += mtxUcCadPessoasDadosPessoaisCPF_Enter;
            mtxUcCadPessoasDadosPessoaisCPF.Leave += mtxUcCadPessoasDadosPessoaisCPF_Leave;
            // 
            // mtxUcCadPessoasDadosPessoaisTelefone
            // 
            mtxUcCadPessoasDadosPessoaisTelefone.Cursor = Cursors.IBeam;
            mtxUcCadPessoasDadosPessoaisTelefone.Location = new Point(8, 170);
            mtxUcCadPessoasDadosPessoaisTelefone.Mask = "(00) 00000-0000";
            mtxUcCadPessoasDadosPessoaisTelefone.Name = "mtxUcCadPessoasDadosPessoaisTelefone";
            mtxUcCadPessoasDadosPessoaisTelefone.Size = new Size(113, 23);
            mtxUcCadPessoasDadosPessoaisTelefone.TabIndex = 8;
            mtxUcCadPessoasDadosPessoaisTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxUcCadPessoasDadosPessoaisTelefone.Enter += mtxUcCadPessoasDadosPessoaisTelefone_Enter;
            mtxUcCadPessoasDadosPessoaisTelefone.Leave += mtxUcCadPessoasDadosPessoaisTelefone_Leave;
            // 
            // lbUcCadPessoasDadosPessoaisTelefone
            // 
            lbUcCadPessoasDadosPessoaisTelefone.AutoSize = true;
            lbUcCadPessoasDadosPessoaisTelefone.Location = new Point(7, 152);
            lbUcCadPessoasDadosPessoaisTelefone.Name = "lbUcCadPessoasDadosPessoaisTelefone";
            lbUcCadPessoasDadosPessoaisTelefone.Size = new Size(51, 15);
            lbUcCadPessoasDadosPessoaisTelefone.TabIndex = 7;
            lbUcCadPessoasDadosPessoaisTelefone.Text = "Telefone";
            // 
            // dtpUcCadPessoasDadosPessoaisDataNascimento
            // 
            dtpUcCadPessoasDadosPessoaisDataNascimento.Format = DateTimePickerFormat.Short;
            dtpUcCadPessoasDadosPessoaisDataNascimento.Location = new Point(8, 126);
            dtpUcCadPessoasDadosPessoaisDataNascimento.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtpUcCadPessoasDadosPessoaisDataNascimento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpUcCadPessoasDadosPessoaisDataNascimento.Name = "dtpUcCadPessoasDadosPessoaisDataNascimento";
            dtpUcCadPessoasDadosPessoaisDataNascimento.Size = new Size(113, 23);
            dtpUcCadPessoasDadosPessoaisDataNascimento.TabIndex = 6;
            dtpUcCadPessoasDadosPessoaisDataNascimento.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lbUcCadPessoasDadosPessoaisDataNascimento
            // 
            lbUcCadPessoasDadosPessoaisDataNascimento.AutoSize = true;
            lbUcCadPessoasDadosPessoaisDataNascimento.Location = new Point(8, 108);
            lbUcCadPessoasDadosPessoaisDataNascimento.Name = "lbUcCadPessoasDadosPessoaisDataNascimento";
            lbUcCadPessoasDadosPessoaisDataNascimento.Size = new Size(114, 15);
            lbUcCadPessoasDadosPessoaisDataNascimento.TabIndex = 5;
            lbUcCadPessoasDadosPessoaisDataNascimento.Text = "Data de Nascimento";
            // 
            // lbUcCadPessoasDadosPessoaisCPF
            // 
            lbUcCadPessoasDadosPessoaisCPF.AutoSize = true;
            lbUcCadPessoasDadosPessoaisCPF.Location = new Point(6, 63);
            lbUcCadPessoasDadosPessoaisCPF.Name = "lbUcCadPessoasDadosPessoaisCPF";
            lbUcCadPessoasDadosPessoaisCPF.Size = new Size(28, 15);
            lbUcCadPessoasDadosPessoaisCPF.TabIndex = 1;
            lbUcCadPessoasDadosPessoaisCPF.Text = "CPF";
            // 
            // txUcCadPessoasDadosPessoaisNome
            // 
            txUcCadPessoasDadosPessoaisNome.Cursor = Cursors.IBeam;
            txUcCadPessoasDadosPessoaisNome.Location = new Point(8, 37);
            txUcCadPessoasDadosPessoaisNome.Name = "txUcCadPessoasDadosPessoaisNome";
            txUcCadPessoasDadosPessoaisNome.PlaceholderText = "Digite seu nome completo";
            txUcCadPessoasDadosPessoaisNome.Size = new Size(274, 23);
            txUcCadPessoasDadosPessoaisNome.TabIndex = 4;
            txUcCadPessoasDadosPessoaisNome.Enter += txUcCadPessoasDadosPessoaisNome_Enter;
            txUcCadPessoasDadosPessoaisNome.Leave += txUcCadPessoasDadosPessoaisNome_Leave;
            // 
            // lbUcCadPessoasDadosPessoaisNome
            // 
            lbUcCadPessoasDadosPessoaisNome.AutoSize = true;
            lbUcCadPessoasDadosPessoaisNome.Location = new Point(6, 19);
            lbUcCadPessoasDadosPessoaisNome.Name = "lbUcCadPessoasDadosPessoaisNome";
            lbUcCadPessoasDadosPessoaisNome.Size = new Size(40, 15);
            lbUcCadPessoasDadosPessoaisNome.TabIndex = 3;
            lbUcCadPessoasDadosPessoaisNome.Text = "Nome";
            // 
            // ucCadPessoasDadosPessoais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbUcCadPessoasDadosPessoais);
            Name = "ucCadPessoasDadosPessoais";
            Size = new Size(305, 220);
            Load += ucCadPessoasDadosPessoais_Load;
            gbUcCadPessoasDadosPessoais.ResumeLayout(false);
            gbUcCadPessoasDadosPessoais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbUcCadPessoasDadosPessoais;
        private TextBox txUcCadPessoasDadosPessoaisNome;
        private Label lbUcCadPessoasDadosPessoaisNome;
        private Label lbUcCadPessoasDadosPessoaisCPF;
        private DateTimePicker dtpUcCadPessoasDadosPessoaisDataNascimento;
        private Label lbUcCadPessoasDadosPessoaisDataNascimento;
        private Label lbUcCadPessoasDadosPessoaisTelefone;
        private MaskedTextBox mtxUcCadPessoasDadosPessoaisTelefone;
        private MaskedTextBox mtxUcCadPessoasDadosPessoaisCPF;
    }
}
