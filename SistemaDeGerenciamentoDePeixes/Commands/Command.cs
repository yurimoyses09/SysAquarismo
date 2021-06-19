using System;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlTypes;
using SistemaDeGerenciamentoDePeixes.Model;
using System.Data.SqlClient;
using SistemaDeGerenciamentoDePeixes.Telas;

namespace SistemaDeGerenciamentoDePeixes.Commands
{

    class Command
    {
        readonly TB_USUARIO tB_USUARIO = new TB_USUARIO();

        public void RealizaLogin(string username, string password, string senhaRepetida)
        {
            tB_USUARIO.nm_nome_usuario = username;
            tB_USUARIO.ds_senha = password;
            try
            {
                using (db_peixesEntities DB = new db_peixesEntities())
                {

                    if (username != String.Empty || password != String.Empty || senhaRepetida != String.Empty)
                    {
                        if (password == senhaRepetida)
                        {
                            // Retorna true or false caso dado exita ou nao
                            var result = DB.TB_USUARIO.Any(x => x.nm_nome_usuario == username && x.ds_senha == password);

                            if (result == true)
                            {
                                TelaInicial tela1 = new TelaInicial(username);
                                tela1.Show();
                            }
                            else
                            {
                                MessageBox.Show($"Usuario {username} não existe, se cadastre", "Usuario não existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("As senhas não são iguais", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Alguns Campos estão vazios", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CadastroUsuario(string nome, string idade, string telefone, string UserName, string senha, string senhaRepetida, string sexo, string pais) // Metodo que realiza a insercao de um usuario no sistema
        {
            try
            {
                using (db_peixesEntities DB = new db_peixesEntities())
                {
                    if (nome != String.Empty && senha != String.Empty && idade != String.Empty && UserName != String.Empty && sexo != String.Empty && pais != String.Empty)
                    {
                        tB_USUARIO.nm_usuario = nome;
                        tB_USUARIO.vl_idade = int.Parse(idade);
                        tB_USUARIO.ds_telefone = telefone;
                        tB_USUARIO.nm_nome_usuario = UserName;
                        tB_USUARIO.ds_senha = senha;
                        tB_USUARIO.ds_sexo = sexo;
                        tB_USUARIO.ds_Pais = pais;

                        if (senha == senhaRepetida)
                        {
                            var result = DB.TB_USUARIO.Any(x => x.nm_nome_usuario == UserName);
                            if (result == true)
                            {
                                MessageBox.Show($"Usuario {UserName} já existe", "Usuario já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                DB.TB_USUARIO.Add(tB_USUARIO);
                                DB.SaveChanges();

                                MessageBox.Show($"Usuario cadastrado com sucesso!! Volte para tela de Login {UserName}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Senhas não Conferem");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Alguns campos estão vazios", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string ValidaDataMorte(string dataMorte)
        {
            if (dataMorte == String.Empty)
            {
                dataMorte = DateTime.MinValue.ToString();
                return dataMorte;
            }
            string dia = dataMorte.Substring(0, 2);
            string mes = dataMorte.Substring(2, 2);
            string ano = dataMorte.Substring(4, 4);

            if (int.Parse(dia) > 31 && int.Parse(dia) < 0 || int.Parse(mes) > 12 && int.Parse(dia) < 1 || int.Parse(ano) > DateTime.Now.Year && int.Parse(dia) < 0)
            {
                MessageBox.Show($"Valor de data errada {dia + "/" + mes + "/" + ano}", "Formato errado");
            }
            else
            {
                dataMorte = $"{dia + "/" + mes + "/" + ano}";
            }

            return dataMorte;
        }// Valida data da morte

        public string ValidaDataAquisicao(string ValordataAquisicao)
        {
            if (ValordataAquisicao == String.Empty)
            {
                MessageBox.Show("Valor de data de aquisição está VAZIO", "Valor Nulo", MessageBoxButtons.OK);
            }
            else
            {
                string dia = ValordataAquisicao.Substring(0, 2);
                string mes = ValordataAquisicao.Substring(2, 2);
                string ano = ValordataAquisicao.Substring(4, 4);

                if (int.Parse(dia) > 31 && int.Parse(dia) < 0 || int.Parse(mes) > 12 && int.Parse(dia) < 1 || int.Parse(ano) > DateTime.Now.Year && int.Parse(dia) < 0)
                {
                    MessageBox.Show($"Valor de data errada {dia + "/" + mes + "/" + ano}", "Formato errado");
                }
                ValordataAquisicao = $"{dia + "/" + mes + "/" + ano}";
            }

            return ValordataAquisicao;
        }// Valida data de Aquisisao

        public string ObtemIdUsuario(string nomeUsuario)
        {
            string connectionString = @"Server=DESKTOP-DH4FP6N; Database=db_peixes;Integrated Security=SSPI;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string strQuerySelectUser = @"SELECT id_usuario FROM TB_USUARIO WHERE nm_nome_usuario = @nameUser";

                SqlCommand CommandSelectIdUser = new SqlCommand(strQuerySelectUser, conn);
                CommandSelectIdUser.Parameters.AddWithValue("@nameUser", nomeUsuario);

                var id_usuario = "";
                try
                {
                    conn.Open();
                    var read = CommandSelectIdUser.ExecuteReader();

                    read.Read();
                    id_usuario = read["id_usuario"].ToString();
                    read.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                return id_usuario;
            }
        }// Retorna o Id do usuario logado no sistema

        public string ObtemIdPeixe(string nomePeixe, string id_usuario)
        {
            string connectionString = @"Server=DESKTOP-DH4FP6N; Database=db_peixes;Integrated Security=SSPI;";

            string strQuerySelect = $"SELECT id_peixe FROM TB_PEIXES WHERE id_usuario = '{id_usuario}' AND nm_peixe = @nome_peixe";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand CommandSelectIdPeixe = new SqlCommand(strQuerySelect, conn);
                CommandSelectIdPeixe.Parameters.AddWithValue("@nome_peixe", nomePeixe);

                var id_peixe = "";
                try
                {
                    conn.Open();

                    var read = CommandSelectIdPeixe.ExecuteReader();

                    read.Read();
                    id_peixe = read["id_peixe"].ToString();
                    read.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                return id_peixe;
            }
        }// Retorna o Id do peixe selecionado

    }
}
