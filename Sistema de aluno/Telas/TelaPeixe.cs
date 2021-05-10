﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_aluno.Telas
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

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string strQuerySelectUser = @"SELECT id_usuario FROM TB_USUARIO WHERE nm_nome_usuario = @nameUser";

                SqlCommand CommandSelectIdUser = new SqlCommand(strQuerySelectUser, conn);
                CommandSelectIdUser.Parameters.AddWithValue("@nameUser", label1.Text);
                try
                {
                    var read = CommandSelectIdUser.ExecuteReader();

                    read.Read();
                    var id_usuario = read["id_usuario"].ToString();
                    read.Close();

                    string strQuerySelect = $"SELECT id_peixe FROM TB_PEIXES WHERE id_usuario = '{id_usuario}' AND nm_peixe = @nome_peixe";

                    SqlCommand CommandSelectIdPeixe = new SqlCommand(strQuerySelect, conn);
                    CommandSelectIdPeixe.Parameters.AddWithValue("@nome_peixe", txtNome.Text);

                    try
                    {
                        read = CommandSelectIdPeixe.ExecuteReader();

                        read.Read();
                        var id_peixe = read["id_peixe"].ToString();
                        read.Close();

                        string UpdatePeixe = $"UPDATE TB_PEIXES SET ds_descricao = @descricao, vl_peso = @peso, vl_tamanho = @tamanho, ds_data_morte = @datamorte, ds_status_saude = @statussaude, ds_doenca = @doenca, ds_sexo = @sexo WHERE id_peixe = '{id_peixe}' AND id_usuario = '{id_usuario}'";

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

        }
    }
}
