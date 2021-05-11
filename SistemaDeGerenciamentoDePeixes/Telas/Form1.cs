using SistemaDeGerenciamentoDePeixes.Commands;
using System;
using System.Windows.Forms;

namespace SistemaDeGerenciamentoDePeixes.Telas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void btbCadastrarTelaInicial_Click(object sender, EventArgs e)
        {
            TelaCadastro tela = new TelaCadastro();

            tela.Show();
            this.Visible = false;
        }

        public void btnLoginTelaInicial_Click(object sender, EventArgs e)
        {
            Command commands = new Command();
            commands.RealizaLogin(txtNomeUsuario.Text, txtSenha.Text, txtSenhaRepetida.Text);

            apagaCampos();
        }// Realiza login no sistema

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        public void apagaCampos() 
        {
            txtNomeUsuario.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtSenhaRepetida.Text = String.Empty;
        }// Apaga campos

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            TelaInfoUsuario tl = new TelaInfoUsuario();

            tl.Show();

        }
    }
}
