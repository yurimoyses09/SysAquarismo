using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_aluno
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
            txtSenhaRepetidaCadastro.Visible = false;
            txtSenhaRepetidaCadastro.ReadOnly = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btbCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Commands commands = new Commands();
            commands.CadastroUsuario
            (
                txtNomeUsuarioCadastro.Text,
                cbIdade.Text,
                txtSenhaUsuarioCadastro.Text,
                txtUserNameCadastro.Text,
                txtSenhaUsuarioCadastro.Text,
                txtSenhaRepetidaCadastro.Text,
                cbSexo.Text,
                cbPais.Text
            );


        }// Realiza cadrastro de usuario no sistema

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();

            tela.Show();
            this.Visible = false;
        }// Volta para a tela inicial de login

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeUsuarioCadastro_TextChanged(object sender, EventArgs e)
        {
            // Comandos que mostram um aviso ao colocar o mouse em cima do campo
            tTInformacaoNome.AutoPopDelay = 5000;
            tTInformacaoNome.SetToolTip(this.txtNomeUsuarioCadastro, "Não é permitido numeros");

            string oldText = string.Empty;
            if (txtNomeUsuarioCadastro.Text.All(chr => char.IsLetter(chr)))  // Se o campo for apenas string
            {
                oldText = txtNomeUsuarioCadastro.Text;

            } else // Se tiver valores mumericos, Mostra uma mensagem de erro
            {
                txtNomeUsuarioCadastro.Text = oldText;
            }
        }// Action que valida se os dados do nome(txtNomeUsuarioCadastro)

        private void txtTelefoneCadastroUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comandos que mostram um aviso ao colocar o mouse em cima do campo
            tTTelefone.AutoPopDelay = 1000;
            tTTelefone.SetToolTip(this.txtTelefoneCadastroUsuario, "Não é permitido letras");

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // Se valores ano forem numericos
            {
                e.Handled = true;
                //MessageBox.Show("Só permitido valores numericos", "Valor Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else 
            {
                e.Handled = false;
            }
        }// Valida se so exite numeros no campo do telefone

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void tTTelefone_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txtSenhaRepetidaCadastro_TextChanged(object sender, EventArgs e)
        {
            tTRepitaSenha.AutoPopDelay = 5000;
            tTRepitaSenha.SetToolTip(this.txtSenhaRepetidaCadastro, "As Senhas devem ser identicas");
        }// Mostra um popup informando que senhas devem ser identicas

        private void txtSenhaUsuarioCadastro_TextChanged_1(object sender, EventArgs e)
        {
            tTTamanhoSenha.SetToolTip(this.txtSenhaUsuarioCadastro, "Senha deve ter mais que 4 digitos");
            var txt = txtSenhaUsuarioCadastro.Text.Substring(0, txtSenhaUsuarioCadastro.Text.Length);
            if (txt.Length == 0 || txt.Length < 4)
            {
                txtSenhaRepetidaCadastro.Visible = false;
                txtSenhaRepetidaCadastro.Text = String.Empty;
            }
            else if (txt.Length >= 4)
            {
                txtSenhaRepetidaCadastro.Visible = true;
                txtSenhaRepetidaCadastro.ReadOnly = false;
            }
            else 
            {
                txtSenhaRepetidaCadastro.ReadOnly = true;
            }

        }
    }
}