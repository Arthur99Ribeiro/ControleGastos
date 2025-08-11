namespace ControleGastos
{
    partial class uFrmCadReceitasReceita
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
            TreeNode treeNode1 = new TreeNode("Receita");
            tsCadReceita = new ToolStrip();
            toolStripSeparator3 = new ToolStripSeparator();
            tslCadReceitaExcluir = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            tslCadReceitaIncluir = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            tslCadReceitaSalvar = new ToolStripLabel();
            toolStripSeparator4 = new ToolStripSeparator();
            tslCadReceitaPesquisar = new ToolStripLabel();
            toolStripSeparator5 = new ToolStripSeparator();
            tslCadReceitaLimpar = new ToolStripLabel();
            toolStripSeparator6 = new ToolStripSeparator();
            tslIdReceita = new ToolStripLabel();
            tstIdReceita = new ToolStripTextBox();
            spcCadReceita = new SplitContainer();
            tvCadReceita = new TreeView();
            tsCadReceita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcCadReceita).BeginInit();
            spcCadReceita.Panel1.SuspendLayout();
            spcCadReceita.SuspendLayout();
            SuspendLayout();
            // 
            // tsCadReceita
            // 
            tsCadReceita.AutoSize = false;
            tsCadReceita.GripStyle = ToolStripGripStyle.Hidden;
            tsCadReceita.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, tslCadReceitaExcluir, toolStripSeparator2, tslCadReceitaIncluir, toolStripSeparator1, tslCadReceitaSalvar, toolStripSeparator4, tslCadReceitaPesquisar, toolStripSeparator5, tslCadReceitaLimpar, toolStripSeparator6, tslIdReceita, tstIdReceita });
            tsCadReceita.Location = new Point(0, 0);
            tsCadReceita.Name = "tsCadReceita";
            tsCadReceita.Size = new Size(595, 30);
            tsCadReceita.TabIndex = 0;
            tsCadReceita.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 30);
            // 
            // tslCadReceitaExcluir
            // 
            tslCadReceitaExcluir.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadReceitaExcluir.ForeColor = Color.DarkRed;
            tslCadReceitaExcluir.Name = "tslCadReceitaExcluir";
            tslCadReceitaExcluir.Size = new Size(29, 27);
            tslCadReceitaExcluir.Text = "";
            tslCadReceitaExcluir.MouseEnter += tslCadReceitaExcluir_MouseEnter;
            tslCadReceitaExcluir.MouseLeave += tslCadReceitaExcluir_MouseLeave;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 30);
            // 
            // tslCadReceitaIncluir
            // 
            tslCadReceitaIncluir.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadReceitaIncluir.ForeColor = Color.DarkGreen;
            tslCadReceitaIncluir.Name = "tslCadReceitaIncluir";
            tslCadReceitaIncluir.Size = new Size(29, 27);
            tslCadReceitaIncluir.Text = "";
            tslCadReceitaIncluir.MouseEnter += tslCadReceitaIncluir_MouseEnter;
            tslCadReceitaIncluir.MouseLeave += tslCadReceitaIncluir_MouseLeave;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // tslCadReceitaSalvar
            // 
            tslCadReceitaSalvar.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadReceitaSalvar.ForeColor = Color.DarkBlue;
            tslCadReceitaSalvar.Name = "tslCadReceitaSalvar";
            tslCadReceitaSalvar.Size = new Size(29, 27);
            tslCadReceitaSalvar.Text = "";
            tslCadReceitaSalvar.MouseEnter += tslCadReceitaSalvar_MouseEnter;
            tslCadReceitaSalvar.MouseLeave += tslCadReceitaSalvar_MouseLeave;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 30);
            // 
            // tslCadReceitaPesquisar
            // 
            tslCadReceitaPesquisar.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadReceitaPesquisar.Name = "tslCadReceitaPesquisar";
            tslCadReceitaPesquisar.Size = new Size(29, 27);
            tslCadReceitaPesquisar.Text = "";
            tslCadReceitaPesquisar.MouseEnter += tslCadReceitaPesquisar_MouseEnter;
            tslCadReceitaPesquisar.MouseLeave += tslCadReceitaPesquisar_MouseLeave;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 30);
            // 
            // tslCadReceitaLimpar
            // 
            tslCadReceitaLimpar.Font = new Font("Segoe MDL2 Assets", 15F);
            tslCadReceitaLimpar.Name = "tslCadReceitaLimpar";
            tslCadReceitaLimpar.Size = new Size(29, 27);
            tslCadReceitaLimpar.Text = "";
            tslCadReceitaLimpar.MouseEnter += tslCadReceitaLimpar_MouseEnter;
            tslCadReceitaLimpar.MouseLeave += tslCadReceitaLimpar_MouseLeave;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 30);
            // 
            // tslIdReceita
            // 
            tslIdReceita.Name = "tslIdReceita";
            tslIdReceita.Size = new Size(70, 27);
            tslIdReceita.Text = "   Id Receita:";
            // 
            // tstIdReceita
            // 
            tstIdReceita.Enabled = false;
            tstIdReceita.Name = "tstIdReceita";
            tstIdReceita.Size = new Size(100, 30);
            // 
            // spcCadReceita
            // 
            spcCadReceita.Dock = DockStyle.Fill;
            spcCadReceita.FixedPanel = FixedPanel.Panel1;
            spcCadReceita.IsSplitterFixed = true;
            spcCadReceita.Location = new Point(0, 30);
            spcCadReceita.Name = "spcCadReceita";
            // 
            // spcCadReceita.Panel1
            // 
            spcCadReceita.Panel1.Controls.Add(tvCadReceita);
            // 
            // spcCadReceita.Panel2
            // 
            spcCadReceita.Panel2.BackColor = Color.White;
            spcCadReceita.Size = new Size(595, 260);
            spcCadReceita.SplitterDistance = 177;
            spcCadReceita.TabIndex = 1;
            // 
            // tvCadReceita
            // 
            tvCadReceita.Dock = DockStyle.Fill;
            tvCadReceita.Location = new Point(0, 0);
            tvCadReceita.Name = "tvCadReceita";
            treeNode1.Name = "tvCadReceitaReceita";
            treeNode1.Text = "Receita";
            tvCadReceita.Nodes.AddRange(new TreeNode[] { treeNode1 });
            tvCadReceita.Size = new Size(177, 260);
            tvCadReceita.TabIndex = 0;
            tvCadReceita.AfterSelect += tvCadReceita_AfterSelect;
            // 
            // uFrmCadReceitasReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 290);
            Controls.Add(spcCadReceita);
            Controls.Add(tsCadReceita);
            Name = "uFrmCadReceitasReceita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Receita";
            Load += uFrmCadReceitasReceita_Load;
            tsCadReceita.ResumeLayout(false);
            tsCadReceita.PerformLayout();
            spcCadReceita.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcCadReceita).EndInit();
            spcCadReceita.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip tsCadReceita;
        private SplitContainer spcCadReceita;
        private TreeView tvCadReceita;
        private ToolStripLabel tslCadReceitaExcluir;
        private ToolStripLabel tslCadReceitaIncluir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel tslCadReceitaSalvar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel tslCadReceitaPesquisar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel tslCadReceitaLimpar;
        private ToolStripLabel tslIdReceita;
        private ToolStripTextBox tstIdReceita;
        private ToolStripSeparator toolStripSeparator6;
    }
}