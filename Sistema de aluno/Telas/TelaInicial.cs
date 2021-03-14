﻿using Sistema_de_aluno.Telas;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_de_aluno
{
    public partial class TelaInicial : Form
    {
        public TelaInicial(string nameUser)
        {
            InitializeComponent();
            lblUserLogado.Text = nameUser;
        }

        public void carregaPeixes()
        {
            string connectionString = @"Server=DESKTOP-DH4FP6N; Database=db_peixes;Integrated Security=SSPI;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string commandSelect = @"SELECT id_usuario FROM TB_USUARIO WHERE nm_nome_usuario = @userLogado";
                    SqlCommand cmd = new SqlCommand(commandSelect, conn);
                    cmd.Parameters.AddWithValue("@userLogado", lblUserLogado.Text);
                    var read = cmd.ExecuteReader();

                    if (read.Read())
                    {
                        var id_usuario = read["id_usuario"].ToString();

                        string commandSelect_ = @"SELECT nm_peixe FROM TB_PEIXES WHERE id_usuario = @id_usuario";

                        SqlCommand cmd_ = new SqlCommand(commandSelect_, conn);
                        cmd_.Parameters.AddWithValue("@id_usuario", id_usuario);
                        cmd_.CommandType = CommandType.Text;

                        read.Close();

                        SqlDataReader dataReader = cmd_.ExecuteReader();
                        DataTable dataTable = new DataTable();

                        while (dataReader.Read())
                        {
                            cbPeixesDoUsuario.Items.Add(dataReader[0].ToString());

                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

            }
        }

        public void ApagaCampos()
        {
            txtNomePeixe.Text = String.Empty;
            txtEspecie.Text = String.Empty;
            txtDescricaoPeixe.Text = String.Empty;
            txtPesoPeixe.Text = String.Empty;
            cbTamanhoPeixe.SelectedIndex = -1;
            cbStatusPeixe.SelectedIndex = -1;
            txtDataMorte.Text = String.Empty;
            txtDescricaoDoenca.Text = String.Empty;
            txtDataAquisicaoPeixe.Text = String.Empty;
            pbImagemPeixe.Image = null;
            cbSexo.SelectedIndex = -1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUploadFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbImagemPeixe.Image = new Bitmap(openFile.FileName);
            }
            MessageBox.Show("Foto Adicionada");
        } // Valida imagem

        private void btnCadastrarPeixe_Click(object sender, EventArgs e)
        {
            Commands commands = new Commands();

            string connectionString = @"Server=DESKTOP-DH4FP6N; Database=db_peixes;Integrated Security=SSPI;";

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                // Converte PictureBox em Byte
                Image img = pbImagemPeixe.Image;
                byte[] arr;
                ImageConverter conver = new ImageConverter();
                arr = (byte[])conver.ConvertTo(img, typeof(byte[]));


                if (txtEspecie.Text != String.Empty && txtDataAquisicaoPeixe.Text != String.Empty && txtNomePeixe.Text != String.Empty && cbStatusPeixe.Text != String.Empty && cbSexo.Text != String.Empty)
                {
                    try
                    {
                        sqlConn.Open();
                        string strQuerySelectPeixe = @"SELECT nm_peixe FROM TB_PEIXES WHERE nm_peixe = @name";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = sqlConn;
                        cmd.CommandText = strQuerySelectPeixe;
                        cmd.Parameters.AddWithValue("@name", txtNomePeixe.Text);
                        SqlDataReader registro = cmd.ExecuteReader();

                        if (!registro.HasRows)
                        {
                            string strQuerySelect = @"SELECT id_usuario FROM TB_USUARIO WHERE nm_nome_usuario = @nameUser";

                            SqlCommand CommandSelect = new SqlCommand(strQuerySelect, sqlConn);
                            CommandSelect.Parameters.AddWithValue("@nameUser", lblUserLogado.Text);
                            registro.Close();
                            var read = CommandSelect.ExecuteReader();

                            read.Read();
                            var id_usuario = read["id_usuario"].ToString();

                            read.Close();
                            string strQueryInsert = @"INSERT INTO TB_PEIXES VALUES(@id_user,'" + txtNomePeixe.Text + "', " +
                                                                                        "'" + txtEspecie.Text + "', " +
                                                                                        "'" + txtDescricaoPeixe.Text + "', " +
                                                                                        "'" + txtPesoPeixe.Text + "', " +
                                                                                        "'" + cbTamanhoPeixe.Text + "', " +
                                                                                        "'" + commands.ValidaDataMorte(txtDataMorte.Text) + "', " +
                                                                                        " @imagem, " +
                                                                                        "'" + cbStatusPeixe.Text + "', " +
                                                                                        "'" + txtDescricaoDoenca.Text + "', " +
                                                                                        "'" + commands.ValidaDataAquisicao(txtDataAquisicaoPeixe.Text) + "', " +
                                                                                        "'" + cbSexo.Text + "')";

                            SqlCommand commandInsert = new SqlCommand(strQueryInsert, sqlConn);

                            commandInsert.Parameters.AddWithValue("@id_user", id_usuario);
                            commandInsert.Parameters.AddWithValue("@imagem", SqlDbType.Image);

                            commandInsert.Parameters["@imagem"].Value = arr;

                            commandInsert.CommandType = CommandType.Text;

                            commandInsert.ExecuteNonQuery();

                            MessageBox.Show($"Peixe cadastrado com sucesso!! {txtNomePeixe.Text}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbPeixesDoUsuario.Items.Clear();

                            carregaPeixes();
                            ApagaCampos();
                        } else
                        {
                            MessageBox.Show($"Peixe já cadastrado!! {txtNomePeixe.Text}", "Peixe já existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    } finally
                    {
                        if (sqlConn.State == ConnectionState.Open)
                        {
                            sqlConn.Close();
                        }
                    }
                } else
                {
                    MessageBox.Show($"Alguns campos obrigatórios estão vazios", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cbStatusPeixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStatusPeixe.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cbStatusPeixe.Text != "Faleceu")
            {
                lblDataMorte.Visible = false;
                txtDataMorte.Visible = false;

            } if (cbStatusPeixe.Text == "Doente")
            {
                lblDataMorte.Visible = false;
                txtDataMorte.Visible = false;

                lblDescicaoDoenca.Visible = true;
                txtDescricaoDoenca.Visible = true;

                txtDataMorte.Text = null;

            } if (cbStatusPeixe.Text == "Faleceu") 
            {
                lblDataMorte.Visible = true;
                txtDataMorte.Visible = true;

                lblDescicaoDoenca.Visible = false;
                txtDescricaoDoenca.Visible = false;
            }

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            carregaPeixes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = false;

            MessageBox.Show($"ATÉ BREVE");

            this.Visible = false;

        }

        private void pbImagemPeixe_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void cbPeixesDoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPeixesDoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbTamanhoPeixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTamanhoPeixe.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cbTamanhoPeixe.Text == String.Empty)
            {
                cbTamanhoPeixe.Text = null;
            }
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtPesoPeixe_TextChanged(object sender, EventArgs e)
        {
            if (txtPesoPeixe.Text == String.Empty)
            {
                txtPesoPeixe.Text = null;
            }
        }

        private void btnVerPeixe_Click(object sender, EventArgs e)
        {
            TelaPeixe tela = new TelaPeixe();

            string connectionString = @"Server=DESKTOP-DH4FP6N; Database=db_peixes;Integrated Security=SSPI;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString)) 
            {
                try
                {
                    sqlConnection.Open();

                    string select = @"SELECT nm_peixe, ds_especie, ds_descricao, vl_peso, vl_tamanho, ds_data_morte, img, ds_status_saude, ds_doenca, ds_data_aquisicao, ds_sexo FROM TB_PEIXES WHERE nm_peixe = @txtNomePeixe";

                    SqlCommand fullSelect = new SqlCommand(select, sqlConnection);
                    fullSelect.Parameters.AddWithValue("@txtNomePeixe", cbPeixesDoUsuario.Text);

                    SqlDataReader read = fullSelect.ExecuteReader();

                    if (read.HasRows)
                    {
                        read.Read();

                        tela.txtNome.Text = read["nm_peixe"].ToString();
                        tela.txtEspecie.Text = read["ds_especie"].ToString();
                        tela.txtDescricao.Text = read["ds_descricao"].ToString();
                        tela.txtPeso.Text = read["vl_peso"].ToString();
                        tela.cbTamanho.Text = read["vl_tamanho"].ToString();
                        tela.txtDataMorte.Text = read["ds_data_morte"].ToString().Substring(0, 10);
                        var foto = read["img"];
                        MemoryStream memoria = new MemoryStream((byte[])foto);

                        if (memoria.Length > 0)
                        {
                            tela.pBImagem.Image = Image.FromStream(memoria);
                        } else
                        {
                            tela.pBImagem.Image = null;

                        }
                        tela.cbStatusSaude.Text = read["ds_status_saude"].ToString();
                        tela.txtDescricaoDoente.Text = read["ds_doenca"].ToString();
                        tela.txtAquisicaoData.Text = read["ds_data_aquisicao"].ToString().Substring(0, 10);
                        tela.cbSexo.Text = read["ds_sexo"].ToString();


                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally 
                {
                    if (sqlConnection.State == ConnectionState.Open) 
                    {
                        sqlConnection.Close();
                    }
                }
            }
            tela.Visible = true;
        }

        private void txtDataAquisicaoPeixe_TextChanged(object sender, EventArgs e)
        {
            dataMorte.AutoPopDelay = 2000;
            dataMorte.SetToolTip(this.txtDataAquisicaoPeixe, "Formato valido dia/mes/ano, SEM AS BARRAS");
        }

        private void txtDataMorte_TextChanged(object sender, EventArgs e)
        {
            dataAquisicao.AutoPopDelay = 2000;
            dataAquisicao.SetToolTip(this.txtDataMorte, "Formato valido dia/mes/ano, SEM AS BARRAS");
        }

        private void txtDataAquisicaoPeixe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // Se valores ano forem numericos
            {
                e.Handled = true;
                //MessageBox.Show("Só permitido valores numericos", "Valor Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                e.Handled = false;
            }
        }

        private void txtDataMorte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // Se valores ano forem numericos
            {
                e.Handled = true;
                //MessageBox.Show("Só permitido valores numericos", "Valor Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                e.Handled = false;
            }
        }
    }
}
