using SistemaDeGerenciamentoDePeixes.Commands;
using SistemaDeGerenciamentoDePeixes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamentoDePeixes.Telas
{
    public partial class TelaInfoUsuario : Form
    {
        public TelaInfoUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Visible = false;
        } // Botão que vai para tela de redefinir senha

        private void btnProcurarDados_Click(object sender, EventArgs e)
        {
            TB_USUARIO tB_USUARIO = new TB_USUARIO
            {
                nm_usuario = txtUsuario.Text,
                nm_nome_usuario = txtNomeLogin.Text
            };

            try
            {
                using (db_peixesEntities DB = new db_peixesEntities())
                {
                    if (txtUsuario.Text.Equals(String.Empty) || txtNomeLogin.Text.Equals(String.Empty))
                    {
                        MessageBox.Show($"Campos Obrigatórios Vazios", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    var result = DB.TB_USUARIO.Any(x => x.nm_usuario == txtUsuario.Text && x.nm_nome_usuario == txtNomeLogin.Text);
                    if (result == true)
                    {
                        MessageBox.Show($"Usuário {txtNomeLogin.Text} encontrado !!", "Redefinir senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        txtSenhaRedefinida.Visible = true;
                        txtSenhaRedefinida2.Visible = true;
                        label5.Visible = true;
                        label3.Visible = true;

                        button1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show($"Usuário {txtNomeLogin.Text} não encontrado!!", "Redefinir senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// Procura info informadas para poder redefinir senha

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            var txt = txtUsuario.Text.Substring(0, txtUsuario.Text.Length);
            if (txt.Length == 0)
            {
                txtSenhaRedefinida.Visible = false;
                txtSenhaRedefinida2.Visible = false;

                button1.Visible = false;

                label5.Visible = false;
                label3.Visible = false;

                txtNomeLogin.Text = String.Empty;
            }
        }// Mostra ou nao mostra as opcoes de mudar senha 

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-DH4FP6N; Database=db_peixes;Integrated Security=SSPI;";

            if (txtSenhaRedefinida.Text == txtSenhaRedefinida2.Text)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                string UpdateSenha = @"UPDATE TB_USUARIO SET ds_senha = @SenhaNova WHERE nm_nome_usuario = @Nomelogin";

                SqlCommand cmd = new SqlCommand(UpdateSenha, conn);

                cmd.Parameters.AddWithValue("@SenhaNova", txtSenhaRedefinida.Text);
                cmd.Parameters.AddWithValue("@Nomelogin", txtNomeLogin.Text);

                cmd.CommandType = CommandType.Text;

                conn.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show($"Senha Atualizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtSenhaRedefinida.Visible = false;
                        txtSenhaRedefinida2.Visible = false;

                        button1.Visible = false;

                        label5.Visible = false;
                        label3.Visible = false;

                        txtNomeLogin.Text = String.Empty;
                        txtUsuario.Text = String.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            else
            {
                MessageBox.Show($"As senhas nao sao iguais", "Senhas Diferentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaRedefinida.Text = String.Empty;
                txtSenhaRedefinida2.Text = String.Empty;
            }
        } // Faz Update da senha do usuario
    }
}
