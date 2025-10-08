using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGastos
{
    public partial class uFrmDB : Form
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeConexaoSelecionada { get; set; } = null;

        public uFrmDB()
        {
            InitializeComponent();
        }

        public event EventHandler ConexoesAtualizadas;

        private void uFrmDB_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => txNomeConexao.Focus()));

            if (!string.IsNullOrEmpty(NomeConexaoSelecionada))
            {
                string iniPath = @"C:\Dev\C#\Controle_Gastos\ConfigDB.ini";
                if (!File.Exists(iniPath)) return;

                IniFile ini = new IniFile(iniPath);

                txNomeConexao.Text = NomeConexaoSelecionada;
                txServidor.Text = ini.Read(NomeConexaoSelecionada, "Servidor");
                txPorta.Text = ini.Read(NomeConexaoSelecionada, "Porta");
                txBanco.Text = ini.Read(NomeConexaoSelecionada, "Banco");
                txUsuario.Text = ini.Read(NomeConexaoSelecionada, "Usuario");
                txSenha.Text = ini.Read(NomeConexaoSelecionada, "Senha");
                chkSSL.Checked = ini.Read(NomeConexaoSelecionada, "SSL").ToLower() == "true";

                // Impede edição do nome da conexão (chave primária do INI)
                txNomeConexao.Enabled = false;
            }
        }

        private void txNomeConexao_Enter(object sender, EventArgs e)
        {
            txNomeConexao.BackColor = Color.AliceBlue;
        }

        private void txNomeConexao_Leave(object sender, EventArgs e)
        {
            txNomeConexao.BackColor = Color.White;
        }

        private void txServidor_Enter(object sender, EventArgs e)
        {
            txServidor.BackColor = Color.AliceBlue;
        }

        private void txServidor_Leave(object sender, EventArgs e)
        {
            txServidor.BackColor = Color.White;
        }

        private void txUsuario_Enter(object sender, EventArgs e)
        {
            txUsuario.BackColor = Color.AliceBlue;
        }

        private void txUsuario_Leave(object sender, EventArgs e)
        {
            txUsuario.BackColor = Color.White;
        }

        private void txPorta_Enter(object sender, EventArgs e)
        {
            txPorta.BackColor = Color.AliceBlue;
        }

        private void txPorta_Leave(object sender, EventArgs e)
        {
            txPorta.BackColor = Color.White;
        }

        private void txSenha_Enter(object sender, EventArgs e)
        {
            txSenha.BackColor = Color.AliceBlue;
        }

        private void txSenha_Leave(object sender, EventArgs e)
        {
            txSenha.BackColor = Color.White;
        }

        private void txBanco_Enter(object sender, EventArgs e)
        {
            txBanco.BackColor = Color.AliceBlue;
        }

        private void txBanco_Leave(object sender, EventArgs e)
        {
            txBanco.BackColor = Color.White;
        }

        private void lbSalvar_MouseEnter(object sender, EventArgs e)
        {
            lbSalvar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbSalvar_MouseLeave(object sender, EventArgs e)
        {
            lbSalvar.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            string iniPath = @"C:\Dev\C#\Controle_Gastos\ConfigDB.ini";
            string pasta = Path.GetDirectoryName(iniPath);
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            if (!File.Exists(iniPath))
                File.Create(iniPath).Close(); // importante: fechar após criar

            IniFile ini = new IniFile(iniPath);

            string nomeConexao = txNomeConexao.Text.Trim();

            ini.Write(nomeConexao, "Servidor", txServidor.Text);
            ini.Write(nomeConexao, "Porta", txPorta.Text);
            ini.Write(nomeConexao, "Banco", txBanco.Text);
            ini.Write(nomeConexao, "Usuario", txUsuario.Text);
            ini.Write(nomeConexao, "Senha", txSenha.Text);
            ini.Write(nomeConexao, "SSL", chkSSL.Checked ? "true" : "false");

            MessageBox.Show("Conexão salva com sucesso!");
            this.Close(); // Fecha a tela de configuração
            ConexoesAtualizadas?.Invoke(this, EventArgs.Empty);

        }

        private void lbExcluir_MouseEnter(object sender, EventArgs e)
        {
            lbExcluir.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void lbExcluir_MouseLeave(object sender, EventArgs e)
        {
            lbExcluir.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void lbExcluir_Click(object sender, EventArgs e)
        {
            string iniPath = @"C:\Dev\C#\Controle_Gastos\ConfigDB.ini";
            string nomeConexao = txNomeConexao.Text.Trim();

            if (string.IsNullOrEmpty(nomeConexao))
            {
                MessageBox.Show("Nenhuma conexão selecionada.");
                return;
            }

            DialogResult result = MessageBox.Show($"Deseja realmente excluir a conexão \"{nomeConexao}\"?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                IniFile ini = new IniFile(iniPath);
                ini.DeleteSection(nomeConexao); // Você precisa implementar esse método na classe IniFile
                MessageBox.Show("Conexão excluída com sucesso.");
                this.Close();
                ConexoesAtualizadas?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
