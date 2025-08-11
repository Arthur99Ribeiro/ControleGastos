namespace ControleGastos
{
    partial class ucCadPessoasEndereco
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
            gpUcCadPessoasEndereco = new GroupBox();
            cbUcCadPessoasEnderecoEstado = new ComboBox();
            lbUcCadPessoasEnderecoEstado = new Label();
            txUcCadPessoasEnderecoCidade = new TextBox();
            lbUcCadPessoasEnderecoCidade = new Label();
            txUcCadPessoasEnderecoComplemento = new TextBox();
            lbUcCadPessoasEnderecoComplemento = new Label();
            lbUcCadPessoasEnderecoNumero = new Label();
            txUcCadPessoasEnderecoNumero = new TextBox();
            txUcCadPessoasEnderecoBairro = new TextBox();
            lbcCadPessoasEnderecoBairro = new Label();
            txUcCadPessoasEnderecoRua = new TextBox();
            lbUcCadPessoasEnderecoRua = new Label();
            mtxUcCadPessoasEnderecoCEP = new MaskedTextBox();
            lbUcCadPessoasEnderecoCEP = new Label();
            gpUcCadPessoasEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // gpUcCadPessoasEndereco
            // 
            gpUcCadPessoasEndereco.AutoSize = true;
            gpUcCadPessoasEndereco.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gpUcCadPessoasEndereco.Controls.Add(cbUcCadPessoasEnderecoEstado);
            gpUcCadPessoasEndereco.Controls.Add(lbUcCadPessoasEnderecoEstado);
            gpUcCadPessoasEndereco.Controls.Add(txUcCadPessoasEnderecoCidade);
            gpUcCadPessoasEndereco.Controls.Add(lbUcCadPessoasEnderecoCidade);
            gpUcCadPessoasEndereco.Controls.Add(txUcCadPessoasEnderecoComplemento);
            gpUcCadPessoasEndereco.Controls.Add(lbUcCadPessoasEnderecoComplemento);
            gpUcCadPessoasEndereco.Controls.Add(lbUcCadPessoasEnderecoNumero);
            gpUcCadPessoasEndereco.Controls.Add(txUcCadPessoasEnderecoNumero);
            gpUcCadPessoasEndereco.Controls.Add(txUcCadPessoasEnderecoBairro);
            gpUcCadPessoasEndereco.Controls.Add(lbcCadPessoasEnderecoBairro);
            gpUcCadPessoasEndereco.Controls.Add(txUcCadPessoasEnderecoRua);
            gpUcCadPessoasEndereco.Controls.Add(lbUcCadPessoasEnderecoRua);
            gpUcCadPessoasEndereco.Controls.Add(mtxUcCadPessoasEnderecoCEP);
            gpUcCadPessoasEndereco.Controls.Add(lbUcCadPessoasEnderecoCEP);
            gpUcCadPessoasEndereco.Location = new Point(3, 3);
            gpUcCadPessoasEndereco.Name = "gpUcCadPessoasEndereco";
            gpUcCadPessoasEndereco.Size = new Size(293, 258);
            gpUcCadPessoasEndereco.TabIndex = 0;
            gpUcCadPessoasEndereco.TabStop = false;
            gpUcCadPessoasEndereco.Text = "Dados do Endereço";
            // 
            // cbUcCadPessoasEnderecoEstado
            // 
            cbUcCadPessoasEnderecoEstado.FormattingEnabled = true;
            cbUcCadPessoasEnderecoEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbUcCadPessoasEnderecoEstado.Location = new Point(112, 213);
            cbUcCadPessoasEnderecoEstado.Name = "cbUcCadPessoasEnderecoEstado";
            cbUcCadPessoasEnderecoEstado.Size = new Size(175, 23);
            cbUcCadPessoasEnderecoEstado.TabIndex = 14;
            cbUcCadPessoasEnderecoEstado.Enter += cbUcCadPessoasEnderecoEstado_Enter;
            cbUcCadPessoasEnderecoEstado.Leave += cbUcCadPessoasEnderecoEstado_Leave;
            // 
            // lbUcCadPessoasEnderecoEstado
            // 
            lbUcCadPessoasEnderecoEstado.AutoSize = true;
            lbUcCadPessoasEnderecoEstado.Location = new Point(112, 195);
            lbUcCadPessoasEnderecoEstado.Name = "lbUcCadPessoasEnderecoEstado";
            lbUcCadPessoasEnderecoEstado.Size = new Size(42, 15);
            lbUcCadPessoasEnderecoEstado.TabIndex = 13;
            lbUcCadPessoasEnderecoEstado.Text = "Estado";
            // 
            // txUcCadPessoasEnderecoCidade
            // 
            txUcCadPessoasEnderecoCidade.Cursor = Cursors.IBeam;
            txUcCadPessoasEnderecoCidade.Location = new Point(6, 169);
            txUcCadPessoasEnderecoCidade.Name = "txUcCadPessoasEnderecoCidade";
            txUcCadPessoasEnderecoCidade.PlaceholderText = "Digite o nome da cidade";
            txUcCadPessoasEnderecoCidade.Size = new Size(281, 23);
            txUcCadPessoasEnderecoCidade.TabIndex = 10;
            txUcCadPessoasEnderecoCidade.Enter += txUcCadPessoasEnderecoCidade_Enter;
            txUcCadPessoasEnderecoCidade.Leave += txUcCadPessoasEnderecoCidade_Leave;
            // 
            // lbUcCadPessoasEnderecoCidade
            // 
            lbUcCadPessoasEnderecoCidade.AutoSize = true;
            lbUcCadPessoasEnderecoCidade.Location = new Point(6, 151);
            lbUcCadPessoasEnderecoCidade.Name = "lbUcCadPessoasEnderecoCidade";
            lbUcCadPessoasEnderecoCidade.Size = new Size(44, 15);
            lbUcCadPessoasEnderecoCidade.TabIndex = 9;
            lbUcCadPessoasEnderecoCidade.Text = "Cidade";
            // 
            // txUcCadPessoasEnderecoComplemento
            // 
            txUcCadPessoasEnderecoComplemento.Cursor = Cursors.IBeam;
            txUcCadPessoasEnderecoComplemento.Location = new Point(112, 125);
            txUcCadPessoasEnderecoComplemento.Name = "txUcCadPessoasEnderecoComplemento";
            txUcCadPessoasEnderecoComplemento.PlaceholderText = "Digite o compl. (Casa 1 \\ Ap 10)";
            txUcCadPessoasEnderecoComplemento.Size = new Size(175, 23);
            txUcCadPessoasEnderecoComplemento.TabIndex = 8;
            txUcCadPessoasEnderecoComplemento.Enter += txUcCadPessoasEnderecoComplemento_Enter;
            txUcCadPessoasEnderecoComplemento.Leave += txUcCadPessoasEnderecoComplemento_Leave;
            // 
            // lbUcCadPessoasEnderecoComplemento
            // 
            lbUcCadPessoasEnderecoComplemento.AutoSize = true;
            lbUcCadPessoasEnderecoComplemento.Location = new Point(112, 107);
            lbUcCadPessoasEnderecoComplemento.Name = "lbUcCadPessoasEnderecoComplemento";
            lbUcCadPessoasEnderecoComplemento.Size = new Size(84, 15);
            lbUcCadPessoasEnderecoComplemento.TabIndex = 7;
            lbUcCadPessoasEnderecoComplemento.Text = "Complemento";
            // 
            // lbUcCadPessoasEnderecoNumero
            // 
            lbUcCadPessoasEnderecoNumero.AutoSize = true;
            lbUcCadPessoasEnderecoNumero.Location = new Point(6, 107);
            lbUcCadPessoasEnderecoNumero.Name = "lbUcCadPessoasEnderecoNumero";
            lbUcCadPessoasEnderecoNumero.Size = new Size(51, 15);
            lbUcCadPessoasEnderecoNumero.TabIndex = 5;
            lbUcCadPessoasEnderecoNumero.Text = "Número";
            // 
            // txUcCadPessoasEnderecoNumero
            // 
            txUcCadPessoasEnderecoNumero.Cursor = Cursors.IBeam;
            txUcCadPessoasEnderecoNumero.Location = new Point(6, 125);
            txUcCadPessoasEnderecoNumero.Name = "txUcCadPessoasEnderecoNumero";
            txUcCadPessoasEnderecoNumero.PlaceholderText = "Digite o numero";
            txUcCadPessoasEnderecoNumero.Size = new Size(100, 23);
            txUcCadPessoasEnderecoNumero.TabIndex = 6;
            txUcCadPessoasEnderecoNumero.Enter += txUcCadPessoasEnderecoNumero_Enter;
            txUcCadPessoasEnderecoNumero.KeyPress += txUcCadPessoasEnderecoNumero_KeyPress;
            txUcCadPessoasEnderecoNumero.Leave += txUcCadPessoasEnderecoNumero_Leave;
            // 
            // txUcCadPessoasEnderecoBairro
            // 
            txUcCadPessoasEnderecoBairro.Cursor = Cursors.IBeam;
            txUcCadPessoasEnderecoBairro.Location = new Point(6, 81);
            txUcCadPessoasEnderecoBairro.Name = "txUcCadPessoasEnderecoBairro";
            txUcCadPessoasEnderecoBairro.PlaceholderText = "Digite o nome do bairro";
            txUcCadPessoasEnderecoBairro.Size = new Size(281, 23);
            txUcCadPessoasEnderecoBairro.TabIndex = 4;
            txUcCadPessoasEnderecoBairro.Enter += txUcCadPessoasEnderecoBairro_Enter;
            txUcCadPessoasEnderecoBairro.Leave += txUcCadPessoasEnderecoBairro_Leave;
            // 
            // lbcCadPessoasEnderecoBairro
            // 
            lbcCadPessoasEnderecoBairro.AutoSize = true;
            lbcCadPessoasEnderecoBairro.Location = new Point(6, 63);
            lbcCadPessoasEnderecoBairro.Name = "lbcCadPessoasEnderecoBairro";
            lbcCadPessoasEnderecoBairro.Size = new Size(38, 15);
            lbcCadPessoasEnderecoBairro.TabIndex = 3;
            lbcCadPessoasEnderecoBairro.Text = "Bairro";
            // 
            // txUcCadPessoasEnderecoRua
            // 
            txUcCadPessoasEnderecoRua.Cursor = Cursors.IBeam;
            txUcCadPessoasEnderecoRua.Location = new Point(6, 37);
            txUcCadPessoasEnderecoRua.Name = "txUcCadPessoasEnderecoRua";
            txUcCadPessoasEnderecoRua.PlaceholderText = "Digite o nome da rua";
            txUcCadPessoasEnderecoRua.Size = new Size(281, 23);
            txUcCadPessoasEnderecoRua.TabIndex = 2;
            txUcCadPessoasEnderecoRua.Enter += txUcCadPessoasEnderecoRua_Enter;
            txUcCadPessoasEnderecoRua.Leave += txUcCadPessoasEnderecoRua_Leave;
            // 
            // lbUcCadPessoasEnderecoRua
            // 
            lbUcCadPessoasEnderecoRua.AutoSize = true;
            lbUcCadPessoasEnderecoRua.Location = new Point(6, 19);
            lbUcCadPessoasEnderecoRua.Name = "lbUcCadPessoasEnderecoRua";
            lbUcCadPessoasEnderecoRua.Size = new Size(27, 15);
            lbUcCadPessoasEnderecoRua.TabIndex = 1;
            lbUcCadPessoasEnderecoRua.Text = "Rua";
            // 
            // mtxUcCadPessoasEnderecoCEP
            // 
            mtxUcCadPessoasEnderecoCEP.Cursor = Cursors.IBeam;
            mtxUcCadPessoasEnderecoCEP.Location = new Point(6, 213);
            mtxUcCadPessoasEnderecoCEP.Mask = "00\\.000\\-000";
            mtxUcCadPessoasEnderecoCEP.Name = "mtxUcCadPessoasEnderecoCEP";
            mtxUcCadPessoasEnderecoCEP.Size = new Size(100, 23);
            mtxUcCadPessoasEnderecoCEP.TabIndex = 12;
            mtxUcCadPessoasEnderecoCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxUcCadPessoasEnderecoCEP.Enter += mtxUcCadPessoasEnderecoCEP_Enter;
            mtxUcCadPessoasEnderecoCEP.Leave += mtxUcCadPessoasEnderecoCEP_Leave;
            // 
            // lbUcCadPessoasEnderecoCEP
            // 
            lbUcCadPessoasEnderecoCEP.AutoSize = true;
            lbUcCadPessoasEnderecoCEP.Location = new Point(6, 195);
            lbUcCadPessoasEnderecoCEP.Name = "lbUcCadPessoasEnderecoCEP";
            lbUcCadPessoasEnderecoCEP.Size = new Size(28, 15);
            lbUcCadPessoasEnderecoCEP.TabIndex = 11;
            lbUcCadPessoasEnderecoCEP.Text = "CEP";
            // 
            // ucCadPessoasEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(gpUcCadPessoasEndereco);
            Name = "ucCadPessoasEndereco";
            Size = new Size(305, 264);
            Load += ucCadPessoasEndereco_Load;
            gpUcCadPessoasEndereco.ResumeLayout(false);
            gpUcCadPessoasEndereco.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpUcCadPessoasEndereco;
        private Label lbUcCadPessoasEnderecoCEP;
        private MaskedTextBox mtxUcCadPessoasEnderecoCEP;
        private TextBox txUcCadPessoasEnderecoRua;
        private Label lbUcCadPessoasEnderecoRua;
        private TextBox txUcCadPessoasEnderecoBairro;
        private Label lbcCadPessoasEnderecoBairro;
        private TextBox txUcCadPessoasEnderecoNumero;
        private Label lbUcCadPessoasEnderecoNumero;
        private TextBox txUcCadPessoasEnderecoComplemento;
        private Label lbUcCadPessoasEnderecoComplemento;
        private TextBox txUcCadPessoasEnderecoCidade;
        private Label lbUcCadPessoasEnderecoCidade;
        private Label lbUcCadPessoasEnderecoEstado;
        private ComboBox cbUcCadPessoasEnderecoEstado;
    }
}
