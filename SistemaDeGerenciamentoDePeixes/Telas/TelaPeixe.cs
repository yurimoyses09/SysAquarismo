using SistemaDeGerenciamentoDePeixes.Commands;
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
    public partial class TelaPeixe : Form
    {
        public TelaPeixe(string nameUser)
        {
            InitializeComponent();
            label1.Text = nameUser;
        }

        private void TelaPeixe_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cbStatusSaude_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatusSaude.SelectedIndex == 0)
            {
                txtDescricaoDoente.ReadOnly = true;
                txtDataMorte.ReadOnly = false;
                txtDescricaoDoente.Text = String.Empty;
            }
            else if (cbStatusSaude.SelectedIndex == 1)
            {
                txtDescricaoDoente.ReadOnly = true;
                txtDescricaoDoente.Text = String.Empty;
            }
            else
            {
                txtDescricaoDoente.ReadOnly = false;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-DH4FP6N; Database=db_peixes;Integrated Security=SSPI;";

            Command commands = new Command();

            var idUsuario = commands.ObtemIdUsuario(label1.Text);
            var idPeixe = commands.ObtemIdPeixe(txtNome.Text, idUsuario);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    string UpdatePeixe = $"UPDATE TB_PEIXES " +
                                            $"SET ds_descricao = " +
                                            $"@descricao, " +
                                            $"vl_peso = @peso, " +
                                            $"vl_tamanho = @tamanho, " +
                                            $"ds_data_morte = @datamorte," +
                                            $" ds_status_saude = @statussaude, " +
                                            $"ds_doenca = @doenca, " +
                                            $"ds_sexo = @sexo " +
                                            $"WHERE " +
                                            $"id_peixe = '{idPeixe}' AND " +
                                            $"id_usuario = '{idUsuario}'";

                    SqlCommand cmd = new SqlCommand(UpdatePeixe, conn);

                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@peso", txtPeso.Text);
                    cmd.Parameters.AddWithValue("@tamanho", cbTamanho.Text);
                    cmd.Parameters.AddWithValue("@datamorte", txtDataMorte.Text);
                    cmd.Parameters.AddWithValue("@statussaude", cbStatusSaude.Text);
                    cmd.Parameters.AddWithValue("@doenca", txtDescricaoDoente.Text);
                    cmd.Parameters.AddWithValue("@sexo", cbSexo.Text);

                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show($"Informações atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void txtDataMorte_TextChanged(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 2000;
            toolTip1.SetToolTip(this.txtDataMorte, "Formato valido dia/mes/ano, COM BARRAS");
        }

        private void txtDataMorte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // Se valores ano forem numericos
            {
                e.Handled = true;
                //MessageBox.Show("Só permitido valores numericos", "Valor Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtAquisicaoData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // Se valores ano forem numericos
            {
                e.Handled = true;
                //MessageBox.Show("Só permitido valores numericos", "Valor Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // Se valores ano forem numericos
            {
                e.Handled = true;
                //MessageBox.Show("Só permitido valores numericos", "Valor Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {
            toolTip2.AutoPopDelay = 2000;
            toolTip2.SetToolTip(this.txtAquisicaoData, "Formato valido dia/mes/ano, COM BARRAS");
        }
    }
}
