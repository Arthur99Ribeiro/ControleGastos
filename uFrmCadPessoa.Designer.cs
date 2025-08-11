namespace ControleGastos
{
    partial class uFrmCadPessoa
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
            TreeNode treeNode3 = new TreeNode("Dados Pessoais");
            TreeNode treeNode4 = new TreeNode("Endereço");
            tsCadPessoas = new ToolStrip();
            toolStripSeparator2 = new ToolStripSeparator();
            tslCadPessoasExcluir = new ToolStripLabel();
            toolStripSeparator4 = new ToolStripSeparator();
            tslCadPessoasIncluir = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            tslCadPessoasSalvar = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            tslCadPessoasPesquisar = new ToolStripLabel();
            toolStripSeparator6 = new ToolStripSeparator();
            tslCadPessoasLimpar = new ToolStripLabel();
            toolStripSeparator5 = new ToolStripSeparator();
            tslIdPessoa = new ToolStripLabel();
            tstIdPessoa = new ToolStripTextBox();
            spcCadPessoas = new SplitContainer();
            tvCadPessoas = new TreeView();
            tsCadPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcCadPessoas).BeginInit();
            spcCadPessoas.Panel1.SuspendLayout();
            spcCadPessoas.SuspendLayout();
            SuspendLayout();
            // 
            // tsCadPessoas
            // 
            tsCadPessoas.AutoSize = false;
            tsCadPessoas.GripStyle = ToolStripGripStyle.Hidden;
            tsCadPessoas.Items.AddRange(new ToolStripItem[] { toolStripSeparator2, tslCadPessoasExcluir, toolStripSeparator4, tslCadPessoasIncluir, toolStripSeparator1, tslCadPessoasSalvar, toolStripSeparator3, tslCadPessoasPesquisar, toolStripSeparator6, tslCadPessoasLimpar, toolStripSeparator5, tslIdPessoa, tstIdPessoa });
            tsCadPessoas.Location = new Point(0, 0);
            tsCadPessoas.Name = "tsCadPessoas";
            tsCadPessoas.RightToLeft = RightToLeft.No;
            tsCadPessoas.Size = new Size(937, 30);
            tsCadPessoas.TabIndex = 0;
            tsCadPessoas.Text = "tsCadPessoas";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 30);
            // 
            // tslCadPessoasExcluir
            // 
            tslCadPessoasExcluir.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadPessoasExcluir.ForeColor = Color.DarkRed;
            tslCadPessoasExcluir.Name = "tslCadPessoasExcluir";
            tslCadPessoasExcluir.Size = new Size(29, 27);
            tslCadPessoasExcluir.Text = "";
            tslCadPessoasExcluir.Click += tslCadPessoasExcluir_Click;
            tslCadPessoasExcluir.MouseEnter += tslCadPessoasExcluir_MouseEnter;
            tslCadPessoasExcluir.MouseLeave += tslCadPessoasExcluir_MouseLeave;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 30);
            // 
            // tslCadPessoasIncluir
            // 
            tslCadPessoasIncluir.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadPessoasIncluir.ForeColor = Color.DarkGreen;
            tslCadPessoasIncluir.Name = "tslCadPessoasIncluir";
            tslCadPessoasIncluir.Size = new Size(29, 27);
            tslCadPessoasIncluir.Text = "";
            tslCadPessoasIncluir.Click += tslCadPessoasIncluir_Click;
            tslCadPessoasIncluir.MouseEnter += tslCadPessoasIncluir_MouseEnter;
            tslCadPessoasIncluir.MouseLeave += tslCadPessoasIncluir_MouseLeave;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // tslCadPessoasSalvar
            // 
            tslCadPessoasSalvar.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadPessoasSalvar.ForeColor = Color.DarkBlue;
            tslCadPessoasSalvar.Name = "tslCadPessoasSalvar";
            tslCadPessoasSalvar.Size = new Size(29, 27);
            tslCadPessoasSalvar.Text = "";
            tslCadPessoasSalvar.Click += tslCadPessoasSalvar_Click;
            tslCadPessoasSalvar.MouseEnter += tslCadPessoasSalvar_MouseEnter;
            tslCadPessoasSalvar.MouseLeave += tslCadPessoasSalvar_MouseLeave;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 30);
            // 
            // tslCadPessoasPesquisar
            // 
            tslCadPessoasPesquisar.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadPessoasPesquisar.Name = "tslCadPessoasPesquisar";
            tslCadPessoasPesquisar.Size = new Size(29, 27);
            tslCadPessoasPesquisar.Text = "";
            tslCadPessoasPesquisar.Click += tslCadPessoasPesquisar_Click;
            tslCadPessoasPesquisar.MouseEnter += tslCadPessoasPesquisar_MouseEnter;
            tslCadPessoasPesquisar.MouseLeave += tslCadPessoasPesquisar_MouseLeave;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 30);
            // 
            // tslCadPessoasLimpar
            // 
            tslCadPessoasLimpar.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadPessoasLimpar.Name = "tslCadPessoasLimpar";
            tslCadPessoasLimpar.Size = new Size(29, 27);
            tslCadPessoasLimpar.Text = "";
            tslCadPessoasLimpar.Click += tslCadPessoasLimpar_Click;
            tslCadPessoasLimpar.MouseEnter += tslCadPessoasLimpar_MouseEnter;
            tslCadPessoasLimpar.MouseLeave += tslCadPessoasLimpar_MouseLeave;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 30);
            // 
            // tslIdPessoa
            // 
            tslIdPessoa.Name = "tslIdPessoa";
            tslIdPessoa.Size = new Size(68, 27);
            tslIdPessoa.Text = "   Id Pessoa:";
            // 
            // tstIdPessoa
            // 
            tstIdPessoa.Enabled = false;
            tstIdPessoa.Name = "tstIdPessoa";
            tstIdPessoa.Size = new Size(100, 30);
            // 
            // spcCadPessoas
            // 
            spcCadPessoas.Dock = DockStyle.Fill;
            spcCadPessoas.FixedPanel = FixedPanel.Panel1;
            spcCadPessoas.IsSplitterFixed = true;
            spcCadPessoas.Location = new Point(0, 30);
            spcCadPessoas.Name = "spcCadPessoas";
            // 
            // spcCadPessoas.Panel1
            // 
            spcCadPessoas.Panel1.Controls.Add(tvCadPessoas);
            // 
            // spcCadPessoas.Panel2
            // 
            spcCadPessoas.Panel2.BackColor = Color.White;
            spcCadPessoas.Size = new Size(937, 530);
            spcCadPessoas.SplitterDistance = 177;
            spcCadPessoas.TabIndex = 1;
            // 
            // tvCadPessoas
            // 
            tvCadPessoas.Dock = DockStyle.Fill;
            tvCadPessoas.Location = new Point(0, 0);
            tvCadPessoas.Name = "tvCadPessoas";
            treeNode3.Name = "tvCadPessoasDadosPessoais";
            treeNode3.Text = "Dados Pessoais";
            treeNode4.Name = "tvCadPessoasEndereco";
            treeNode4.Text = "Endereço";
            tvCadPessoas.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode4 });
            tvCadPessoas.Size = new Size(177, 530);
            tvCadPessoas.TabIndex = 0;
            tvCadPessoas.AfterSelect += tvCadPessoas_AfterSelect;
            // 
            // uFrmCadPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(937, 560);
            Controls.Add(spcCadPessoas);
            Controls.Add(tsCadPessoas);
            Name = "uFrmCadPessoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pessoa";
            Load += uFrmCadPessoa_Load;
            tsCadPessoas.ResumeLayout(false);
            tsCadPessoas.PerformLayout();
            spcCadPessoas.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcCadPessoas).EndInit();
            spcCadPessoas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip tsCadPessoas;
        private SplitContainer spcCadPessoas;
        private TreeView tvCadPessoas;
        private ToolStripLabel tslCadPessoasExcluir;
        private ToolStripLabel tslCadPessoasPesquisar;
        private ToolStripLabel tslCadPessoasSalvar;
        private ToolStripLabel tslCadPessoasLimpar;
        private ToolStripLabel tslCadPessoasIncluir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel tslIdPessoa;
        private ToolStripTextBox tstIdPessoa;
    }
}