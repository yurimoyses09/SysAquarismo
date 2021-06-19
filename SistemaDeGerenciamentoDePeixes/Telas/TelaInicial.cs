using SistemaDeGerenciamentoDePeixes.Commands;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaDeGerenciamentoDePeixes.Telas
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
        }// Carrega os peixes do usuario assim q ele loga no sistema

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
        }// Metodo que apaga os campos depois de preenchidos e peixe ser cadastrado

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

        private void btnRemoverFoto_Click(object sender, EventArgs e)
        {
            pbImagemPeixe.Image = null;
        }// Deleta imagem carregada

        private void btnCadastrarPeixe_Click(object sender, EventArgs e)
        {
            Command commands = new Command();

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
                    sqlConn.Open();
                    string strQuerySelectPeixe = @"SELECT nm_peixe FROM TB_PEIXES WHERE nm_peixe = @name_peixe";

                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = sqlConn,
                        CommandText = strQuerySelectPeixe
                    };

                    cmd.Parameters.AddWithValue("@name_peixe", txtNomePeixe.Text);
                    SqlDataReader registro = cmd.ExecuteReader();
                    try
                    {
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

                            int i = commandInsert.ExecuteNonQuery();
                            if (i == 1)
                            {
                                MessageBox.Show($"Peixe cadastrado com sucesso!! {txtNomePeixe.Text}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbPeixesDoUsuario.Items.Clear();

                                carregaPeixes();
                                ApagaCampos();
                            }
                            else
                            {
                                MessageBox.Show($"Erro ao cadastrar peixe {txtNomePeixe.Text}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Esse peixe já está cadastrado!! {txtNomePeixe.Text}", "Peixe já existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (sqlConn.State == ConnectionState.Open)
                        {
                            sqlConn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Alguns campos obrigatórios estão vazios", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }// Botao que cadastra peixe no sistema

        private void cbStatusPeixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStatusPeixe.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cbStatusPeixe.Text == "Faleceu")
            {
                lblDataMorte.Visible = true;
                txtDataMorte.Visible = true;

                lblDescicaoDoenca.Visible = false;
                txtDescricaoDoenca.Visible = false;
            }
            else if (cbStatusPeixe.Text == "Doente")
            {
                lblDataMorte.Visible = false;
                txtDataMorte.Visible = false;

                lblDescicaoDoenca.Visible = true;
                txtDescricaoDoenca.Visible = true;
            }
            else if (cbStatusPeixe.Text == "Saudável")
            {
                lblDescicaoDoenca.Visible = false;
                txtDescricaoDoenca.Visible = false;

                lblDataMorte.Visible = false;
                txtDataMorte.Visible = false;
            }
        }// Mostra ou nao uma opcao dependendo da escolha do Status do peixe

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            carregaPeixes();
        }// Carrega todos os peixes do usuario que logou

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = false;

            MessageBox.Show($"ATÉ BREVE {lblUserLogado.Text}");

            Visible = false;
            form.Visible = true;

        }// Mesagem quando o usuario vai para tela inicial

        private void cbPeixesDoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPeixesDoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cbPeixesDoUsuario.SelectedIndex == -1)
            {
                btnVerPeixe.Enabled = false;
                btnDeletar.Enabled = false;
            }
            else
            {
                btnDeletar.Enabled = true;
                btnVerPeixe.Enabled = true;
            }
        }

        private void cbTamanhoPeixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTamanhoPeixe.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cbTamanhoPeixe.Text == String.Empty)
            {
                cbTamanhoPeixe.Text = "";
            }
        }// Valida se valor do tamanho do peixe é vazio

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtPesoPeixe_TextChanged(object sender, EventArgs e)
        {
            if (txtPesoPeixe.Text == String.Empty)
            {
                txtPesoPeixe.Text = "";
            }
        }

        private void btnVerPeixe_Click(object sender, EventArgs e)
        {
            TelaPeixe tela = new TelaPeixe(lblUserLogado.Text);

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
                        if (txtDataMorte.Text == "01/01/0001")
                        {
                            tela.txtDescricaoDoente.ReadOnly = true;
                        }
                        var foto = read["img"];
                        MemoryStream memoria = new MemoryStream((byte[])foto);

                        if (memoria.Length > 0)
                        {
                            tela.pBImagem.Image = Image.FromStream(memoria);
                        }
                        else
                        {
                            tela.pBImagem.Image = null;

                        }
                        tela.cbStatusSaude.Text = read["ds_status_saude"].ToString();
                        tela.txtDescricaoDoente.Text = read["ds_doenca"].ToString();
                        tela.txtAquisicaoData.Text = read["ds_data_aquisicao"].ToString().Substring(0, 10);
                        tela.cbSexo.Text = read["ds_sexo"].ToString();
                        read.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro vai visualizar seus peixes");
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
            }
            tela.Visible = true;
        }// Abre uma tela com as informacoes do peixe selecionado

        private void txtDataAquisicaoPeixe_TextChanged(object sender, EventArgs e)
        {
            dataMorte.AutoPopDelay = 2000;
            dataMorte.SetToolTip(this.txtDataAquisicaoPeixe, "Formato valido dia/mes/ano, SEM AS BARRAS");
        }// mostra texto sobre formato da data

        private void txtDataMorte_TextChanged(object sender, EventArgs e)
        {
            dataAquisicao.AutoPopDelay = 2000;
            dataAquisicao.SetToolTip(this.txtDataMorte, "Formato valido dia/mes/ano, SEM AS BARRAS");
        }// mostra texto sobre formato da data

        private void txtDataAquisicaoPeixe_KeyPress(object sender, KeyPressEventArgs e)
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
        }// Nao deixa digitar letras no campo de data de aquisição

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
        }// Nao deixa digitar letras no campo de data de aquisição

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (cbPeixesDoUsuario.SelectedIndex == 0)
            {
                cbPeixesDoUsuario.Enabled = false;
            }
            cbPeixesDoUsuario.Enabled = true;

            string connectionString = @"Server=DESKTOP-DH4FP6N; Database=db_peixes;Integrated Security=SSPI;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string strQuerySelectUser = @"SELECT id_usuario FROM TB_USUARIO WHERE nm_nome_usuario = @nameUser";

                SqlCommand CommandSelectIdUser = new SqlCommand(strQuerySelectUser, conn);
                CommandSelectIdUser.Parameters.AddWithValue("@nameUser", lblUserLogado.Text);

                try
                {
                    var read = CommandSelectIdUser.ExecuteReader();

                    read.Read();
                    var id_usuario = read["id_usuario"].ToString();
                    read.Close();

                    string strQuerySelect = $"SELECT id_peixe FROM TB_PEIXES WHERE id_usuario = '{id_usuario}' AND nm_peixe = @nome_peixe";

                    SqlCommand CommandSelectIdPeixe = new SqlCommand(strQuerySelect, conn);
                    CommandSelectIdPeixe.Parameters.AddWithValue("@nome_peixe", cbPeixesDoUsuario.Text);

                    try
                    {
                        read = CommandSelectIdPeixe.ExecuteReader();

                        read.Read();
                        var id_peixe = read["id_peixe"].ToString();
                        read.Close();

                        string DeletarPeixe = $"DELETE FROM TB_PEIXES WHERE id_usuario = @id_usuario AND id_peixe = @id_peixe";

                        SqlCommand cmd = new SqlCommand(DeletarPeixe, conn);

                        cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                        cmd.Parameters.AddWithValue("@id_peixe", id_peixe);

                        cmd.CommandType = CommandType.Text;

                        try
                        {
                            int i = cmd.ExecuteNonQuery();
                            if (i == 1)
                            {
                                MessageBox.Show($"Peixe {cbPeixesDoUsuario.Text} Deletado", "Deletado com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                cbPeixesDoUsuario.Items.Clear();

                                carregaPeixes();
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

        }// Deleta peixe selecionado no combo

    }
}
