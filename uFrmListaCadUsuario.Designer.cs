namespace ControleGastos
{
    partial class uFrmListaCadUsuario
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
            gbCadUsuario = new GroupBox();
            lbCadLimpar = new Label();
            lbCadRefresh = new Label();
            lbCadEditar = new Label();
            lbCadPesquisar = new Label();
            lbCadExcluir = new Label();
            txCadUsuario = new TextBox();
            lvCadUsuario = new ListView();
            lbCadNovoUsuario = new Label();
            gbCadUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // gbCadUsuario
            // 
            gbCadUsuario.Controls.Add(lbCadLimpar);
            gbCadUsuario.Controls.Add(lbCadRefresh);
            gbCadUsuario.Controls.Add(lbCadEditar);
            gbCadUsuario.Controls.Add(lbCadPesquisar);
            gbCadUsuario.Controls.Add(lbCadExcluir);
            gbCadUsuario.Controls.Add(txCadUsuario);
            gbCadUsuario.Controls.Add(lvCadUsuario);
            gbCadUsuario.Controls.Add(lbCadNovoUsuario);
            gbCadUsuario.Location = new Point(12, 12);
            gbCadUsuario.Name = "gbCadUsuario";
            gbCadUsuario.Size = new Size(521, 373);
            gbCadUsuario.TabIndex = 1;
            gbCadUsuario.TabStop = false;
            gbCadUsuario.Text = "Controle de Usuario";
            // 
            // lbCadLimpar
            // 
            lbCadLimpar.AutoSize = true;
            lbCadLimpar.Cursor = Cursors.Hand;
            lbCadLimpar.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCadLimpar.Location = new Point(482, 22);
            lbCadLimpar.Name = "lbCadLimpar";
            lbCadLimpar.Size = new Size(32, 22);
            lbCadLimpar.TabIndex = 4;
            lbCadLimpar.Text = "";
            lbCadLimpar.MouseEnter += lbCadLimpar_MouseEnter;
            lbCadLimpar.MouseLeave += lbCadLimpar_MouseLeave;
            // 
            // lbCadRefresh
            // 
            lbCadRefresh.AutoSize = true;
            lbCadRefresh.Cursor = Cursors.Hand;
            lbCadRefresh.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCadRefresh.Location = new Point(468, 326);
            lbCadRefresh.Name = "lbCadRefresh";
            lbCadRefresh.Size = new Size(46, 32);
            lbCadRefresh.TabIndex = 9;
            lbCadRefresh.Text = "";
            lbCadRefresh.Click += lbCadRefresh_Click;
            lbCadRefresh.MouseEnter += lbCadRefresh_MouseEnter;
            lbCadRefresh.MouseLeave += lbCadRefresh_MouseLeave;
            // 
            // lbCadEditar
            // 
            lbCadEditar.AutoSize = true;
            lbCadEditar.Cursor = Cursors.Hand;
            lbCadEditar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCadEditar.ForeColor = Color.DarkBlue;
            lbCadEditar.Location = new Point(58, 326);
            lbCadEditar.Name = "lbCadEditar";
            lbCadEditar.Size = new Size(46, 32);
            lbCadEditar.TabIndex = 7;
            lbCadEditar.Text = "";
            lbCadEditar.Click += lbCadEditar_Click;
            lbCadEditar.MouseEnter += lbCadEditar_MouseEnter;
            lbCadEditar.MouseLeave += lbCadEditar_MouseLeave;
            // 
            // lbCadPesquisar
            // 
            lbCadPesquisar.AutoSize = true;
            lbCadPesquisar.Cursor = Cursors.Hand;
            lbCadPesquisar.Font = new Font("Segoe MDL2 Assets", 16F);
            lbCadPesquisar.Location = new Point(444, 22);
            lbCadPesquisar.Name = "lbCadPesquisar";
            lbCadPesquisar.Size = new Size(32, 22);
            lbCadPesquisar.TabIndex = 3;
            lbCadPesquisar.Text = "";
            lbCadPesquisar.Click += lbCadPesquisar_Click;
            lbCadPesquisar.MouseEnter += lbCadPesquisar_MouseEnter;
            lbCadPesquisar.MouseLeave += lbCadPesquisar_MouseLeave;
            // 
            // lbCadExcluir
            // 
            lbCadExcluir.AutoSize = true;
            lbCadExcluir.Cursor = Cursors.Hand;
            lbCadExcluir.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCadExcluir.ForeColor = Color.DarkRed;
            lbCadExcluir.Location = new Point(6, 326);
            lbCadExcluir.Name = "lbCadExcluir";
            lbCadExcluir.Size = new Size(46, 32);
            lbCadExcluir.TabIndex = 6;
            lbCadExcluir.Text = "";
            lbCadExcluir.TextAlign = ContentAlignment.TopCenter;
            lbCadExcluir.Click += lbCadExcluir_Click;
            lbCadExcluir.MouseEnter += lbCadExcluir_MouseEnter;
            lbCadExcluir.MouseLeave += lbCadExcluir_MouseLeave;
            // 
            // txCadUsuario
            // 
            txCadUsuario.Cursor = Cursors.IBeam;
            txCadUsuario.Location = new Point(6, 22);
            txCadUsuario.Name = "txCadUsuario";
            txCadUsuario.PlaceholderText = "Pesquise pelo seu Usuario";
            txCadUsuario.Size = new Size(432, 23);
            txCadUsuario.TabIndex = 2;
            txCadUsuario.Enter += txCadUsuario_Enter;
            txCadUsuario.Leave += txCadUsuario_Leave;
            // 
            // lvCadUsuario
            // 
            lvCadUsuario.Location = new Point(6, 51);
            lvCadUsuario.Name = "lvCadUsuario";
            lvCadUsuario.Size = new Size(508, 257);
            lvCadUsuario.TabIndex = 5;
            lvCadUsuario.UseCompatibleStateImageBehavior = false;
            // 
            // lbCadNovoUsuario
            // 
            lbCadNovoUsuario.AutoSize = true;
            lbCadNovoUsuario.Cursor = Cursors.Hand;
            lbCadNovoUsuario.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCadNovoUsuario.ForeColor = Color.DarkBlue;
            lbCadNovoUsuario.Location = new Point(110, 326);
            lbCadNovoUsuario.Name = "lbCadNovoUsuario";
            lbCadNovoUsuario.Size = new Size(46, 32);
            lbCadNovoUsuario.TabIndex = 8;
            lbCadNovoUsuario.Text = "";
            lbCadNovoUsuario.Click += lbCadNovoUsuario_Click;
            lbCadNovoUsuario.MouseEnter += lbCadNovoUsuario_MouseEnter;
            lbCadNovoUsuario.MouseLeave += lbCadNovoUsuario_MouseLeave;
            // 
            // uFrmListaCadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 400);
            Controls.Add(gbCadUsuario);
            Name = "uFrmListaCadUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Usuario";
            gbCadUsuario.ResumeLayout(false);
            gbCadUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbCadUsuario;
        private ListView lvCadUsuario;
        private Label lbCadNovoUsuario;
        private Label lbCadRefresh;
        private Label lbCadExcluir;
        private Label lbCadEditar;
        private TextBox txCadUsuario;
        private Label lbCadPesquisar;
        private Label lbCadLimpar;
    }
}