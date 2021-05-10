
namespace Sistema_de_aluno
  {
  partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomePeixe = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtDescricaoPeixe = new System.Windows.Forms.TextBox();
            this.txtPesoPeixe = new System.Windows.Forms.TextBox();
            this.txtDataAquisicaoPeixe = new System.Windows.Forms.TextBox();
            this.btnCadastrarPeixe = new System.Windows.Forms.Button();
            this.lblGramas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPeixesDoUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStatusPeixe = new System.Windows.Forms.ComboBox();
            this.pbImagemPeixe = new System.Windows.Forms.PictureBox();
            this.btnUploadFoto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDataMorte = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbTamanhoPeixe = new System.Windows.Forms.ComboBox();
            this.lblDescicaoDoenca = new System.Windows.Forms.Label();
            this.txtDescricaoDoenca = new System.Windows.Forms.TextBox();
            this.lblUserLogado = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnVerPeixe = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDataMorte = new System.Windows.Forms.TextBox();
            this.dataMorte = new System.Windows.Forms.ToolTip(this.components);
            this.dataAquisicao = new System.Windows.Forms.ToolTip(this.components);
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemPeixe)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Peixe *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especie *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(22, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição do Peixe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(22, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status Saude *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Aquisição *";
            // 
            // txtNomePeixe
            // 
            this.txtNomePeixe.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNomePeixe.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePeixe.Location = new System.Drawing.Point(185, 113);
            this.txtNomePeixe.Name = "txtNomePeixe";
            this.txtNomePeixe.Size = new System.Drawing.Size(187, 22);
            this.txtNomePeixe.TabIndex = 6;
            // 
            // txtEspecie
            // 
            this.txtEspecie.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEspecie.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(185, 155);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(187, 22);
            this.txtEspecie.TabIndex = 7;
            // 
            // txtDescricaoPeixe
            // 
            this.txtDescricaoPeixe.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescricaoPeixe.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoPeixe.Location = new System.Drawing.Point(185, 199);
            this.txtDescricaoPeixe.Multiline = true;
            this.txtDescricaoPeixe.Name = "txtDescricaoPeixe";
            this.txtDescricaoPeixe.Size = new System.Drawing.Size(239, 74);
            this.txtDescricaoPeixe.TabIndex = 8;
            // 
            // txtPesoPeixe
            // 
            this.txtPesoPeixe.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPesoPeixe.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoPeixe.Location = new System.Drawing.Point(186, 332);
            this.txtPesoPeixe.Name = "txtPesoPeixe";
            this.txtPesoPeixe.Size = new System.Drawing.Size(32, 22);
            this.txtPesoPeixe.TabIndex = 9;
            this.txtPesoPeixe.TextChanged += new System.EventHandler(this.txtPesoPeixe_TextChanged);
            // 
            // txtDataAquisicaoPeixe
            // 
            this.txtDataAquisicaoPeixe.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDataAquisicaoPeixe.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAquisicaoPeixe.Location = new System.Drawing.Point(186, 552);
            this.txtDataAquisicaoPeixe.Name = "txtDataAquisicaoPeixe";
            this.txtDataAquisicaoPeixe.Size = new System.Drawing.Size(73, 22);
            this.txtDataAquisicaoPeixe.TabIndex = 11;
            this.txtDataAquisicaoPeixe.TextChanged += new System.EventHandler(this.txtDataAquisicaoPeixe_TextChanged);
            this.txtDataAquisicaoPeixe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataAquisicaoPeixe_KeyPress);
            // 
            // btnCadastrarPeixe
            // 
            this.btnCadastrarPeixe.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarPeixe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarPeixe.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPeixe.Location = new System.Drawing.Point(126, 585);
            this.btnCadastrarPeixe.Name = "btnCadastrarPeixe";
            this.btnCadastrarPeixe.Size = new System.Drawing.Size(173, 41);
            this.btnCadastrarPeixe.TabIndex = 13;
            this.btnCadastrarPeixe.Text = "Cadastrar Peixe";
            this.btnCadastrarPeixe.UseVisualStyleBackColor = false;
            this.btnCadastrarPeixe.Click += new System.EventHandler(this.btnCadastrarPeixe_Click);
            // 
            // lblGramas
            // 
            this.lblGramas.AutoSize = true;
            this.lblGramas.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGramas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGramas.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramas.Location = new System.Drawing.Point(232, 334);
            this.lblGramas.Name = "lblGramas";
            this.lblGramas.Size = new System.Drawing.Size(16, 18);
            this.lblGramas.TabIndex = 14;
            this.lblGramas.Text = "g";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 14);
            this.label8.TabIndex = 15;
            // 
            // cbPeixesDoUsuario
            // 
            this.cbPeixesDoUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.cbPeixesDoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeixesDoUsuario.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeixesDoUsuario.FormattingEnabled = true;
            this.cbPeixesDoUsuario.Location = new System.Drawing.Point(757, 151);
            this.cbPeixesDoUsuario.Name = "cbPeixesDoUsuario";
            this.cbPeixesDoUsuario.Size = new System.Drawing.Size(153, 22);
            this.cbPeixesDoUsuario.TabIndex = 16;
            this.cbPeixesDoUsuario.SelectedIndexChanged += new System.EventHandler(this.cbPeixesDoUsuario_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(787, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Seus Peixes";
            // 
            // cbStatusPeixe
            // 
            this.cbStatusPeixe.BackColor = System.Drawing.Color.Gainsboro;
            this.cbStatusPeixe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusPeixe.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusPeixe.FormattingEnabled = true;
            this.cbStatusPeixe.Items.AddRange(new object[] {
            "Saudável",
            "Doente",
            "Faleceu"});
            this.cbStatusPeixe.Location = new System.Drawing.Point(186, 409);
            this.cbStatusPeixe.Name = "cbStatusPeixe";
            this.cbStatusPeixe.Size = new System.Drawing.Size(92, 22);
            this.cbStatusPeixe.TabIndex = 18;
            this.cbStatusPeixe.SelectedIndexChanged += new System.EventHandler(this.cbStatusPeixe_SelectedIndexChanged);
            // 
            // pbImagemPeixe
            // 
            this.pbImagemPeixe.BackColor = System.Drawing.Color.Gainsboro;
            this.pbImagemPeixe.Location = new System.Drawing.Point(504, 135);
            this.pbImagemPeixe.Name = "pbImagemPeixe";
            this.pbImagemPeixe.Size = new System.Drawing.Size(232, 182);
            this.pbImagemPeixe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemPeixe.TabIndex = 19;
            this.pbImagemPeixe.TabStop = false;
            // 
            // btnUploadFoto
            // 
            this.btnUploadFoto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUploadFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadFoto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFoto.Location = new System.Drawing.Point(573, 330);
            this.btnUploadFoto.Name = "btnUploadFoto";
            this.btnUploadFoto.Size = new System.Drawing.Size(88, 23);
            this.btnUploadFoto.TabIndex = 20;
            this.btnUploadFoto.Text = "Upload Foto";
            this.btnUploadFoto.UseVisualStyleBackColor = false;
            this.btnUploadFoto.Click += new System.EventHandler(this.btnUploadFoto_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Chiller", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 40);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cadastre Seu Peixe Aqui";
            // 
            // lblDataMorte
            // 
            this.lblDataMorte.AutoSize = true;
            this.lblDataMorte.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDataMorte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDataMorte.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataMorte.Location = new System.Drawing.Point(284, 411);
            this.lblDataMorte.Name = "lblDataMorte";
            this.lblDataMorte.Size = new System.Drawing.Size(112, 18);
            this.lblDataMorte.TabIndex = 22;
            this.lblDataMorte.Text = "Data da Morte";
            this.lblDataMorte.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(19, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tamanho";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(241, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cm";
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(931, 24);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTamanhoPeixe
            // 
            this.cbTamanhoPeixe.BackColor = System.Drawing.Color.Gainsboro;
            this.cbTamanhoPeixe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTamanhoPeixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamanhoPeixe.FormattingEnabled = true;
            this.cbTamanhoPeixe.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cbTamanhoPeixe.Location = new System.Drawing.Point(186, 375);
            this.cbTamanhoPeixe.Name = "cbTamanhoPeixe";
            this.cbTamanhoPeixe.Size = new System.Drawing.Size(49, 23);
            this.cbTamanhoPeixe.TabIndex = 28;
            this.cbTamanhoPeixe.SelectedIndexChanged += new System.EventHandler(this.cbTamanhoPeixe_SelectedIndexChanged);
            // 
            // lblDescicaoDoenca
            // 
            this.lblDescicaoDoenca.AutoSize = true;
            this.lblDescicaoDoenca.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDescicaoDoenca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDescicaoDoenca.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescicaoDoenca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescicaoDoenca.Location = new System.Drawing.Point(19, 453);
            this.lblDescicaoDoenca.Name = "lblDescicaoDoenca";
            this.lblDescicaoDoenca.Size = new System.Drawing.Size(160, 18);
            this.lblDescicaoDoenca.TabIndex = 29;
            this.lblDescicaoDoenca.Text = "Descrição da Doença";
            this.lblDescicaoDoenca.Visible = false;
            // 
            // txtDescricaoDoenca
            // 
            this.txtDescricaoDoenca.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescricaoDoenca.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoDoenca.Location = new System.Drawing.Point(186, 453);
            this.txtDescricaoDoenca.Multiline = true;
            this.txtDescricaoDoenca.Name = "txtDescricaoDoenca";
            this.txtDescricaoDoenca.Size = new System.Drawing.Size(239, 74);
            this.txtDescricaoDoenca.TabIndex = 30;
            this.txtDescricaoDoenca.Visible = false;
            // 
            // lblUserLogado
            // 
            this.lblUserLogado.AutoSize = true;
            this.lblUserLogado.Location = new System.Drawing.Point(939, 613);
            this.lblUserLogado.Name = "lblUserLogado";
            this.lblUserLogado.Size = new System.Drawing.Size(41, 13);
            this.lblUserLogado.TabIndex = 31;
            this.lblUserLogado.Text = "label13";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSexo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSexo.Location = new System.Drawing.Point(19, 299);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(56, 18);
            this.lblSexo.TabIndex = 32;
            this.lblSexo.Text = "Sexo *";
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.Color.Gainsboro;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Femea",
            "Macho"});
            this.cbSexo.Location = new System.Drawing.Point(186, 299);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(92, 22);
            this.cbSexo.TabIndex = 33;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // btnVerPeixe
            // 
            this.btnVerPeixe.BackColor = System.Drawing.Color.Chartreuse;
            this.btnVerPeixe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPeixe.Enabled = false;
            this.btnVerPeixe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPeixe.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPeixe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerPeixe.Location = new System.Drawing.Point(838, 179);
            this.btnVerPeixe.Name = "btnVerPeixe";
            this.btnVerPeixe.Size = new System.Drawing.Size(75, 28);
            this.btnVerPeixe.TabIndex = 34;
            this.btnVerPeixe.Text = "Veja";
            this.btnVerPeixe.UseVisualStyleBackColor = false;
            this.btnVerPeixe.Click += new System.EventHandler(this.btnVerPeixe_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1018, 21);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(111, 18);
            this.toolStripDropDownButton1.Text = "Configurações";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem1.Text = "Links Uteis";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem2.Text = "Perfil";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem3.Text = "Idioma";
            // 
            // txtDataMorte
            // 
            this.txtDataMorte.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDataMorte.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataMorte.Location = new System.Drawing.Point(412, 409);
            this.txtDataMorte.Name = "txtDataMorte";
            this.txtDataMorte.Size = new System.Drawing.Size(73, 22);
            this.txtDataMorte.TabIndex = 37;
            this.txtDataMorte.Visible = false;
            this.txtDataMorte.TextChanged += new System.EventHandler(this.txtDataMorte_TextChanged);
            this.txtDataMorte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataMorte_KeyPress);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Crimson;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletar.Location = new System.Drawing.Point(757, 179);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 28);
            this.btnDeletar.TabIndex = 38;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Sistema_de_aluno.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 646);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtDataMorte);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnVerPeixe);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblUserLogado);
            this.Controls.Add(this.txtDescricaoDoenca);
            this.Controls.Add(this.lblDescicaoDoenca);
            this.Controls.Add(this.cbTamanhoPeixe);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDataMorte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUploadFoto);
            this.Controls.Add(this.pbImagemPeixe);
            this.Controls.Add(this.cbStatusPeixe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPeixesDoUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblGramas);
            this.Controls.Add(this.btnCadastrarPeixe);
            this.Controls.Add(this.txtDataAquisicaoPeixe);
            this.Controls.Add(this.txtPesoPeixe);
            this.Controls.Add(this.txtDescricaoPeixe);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtNomePeixe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemPeixe)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtNomePeixe;
    private System.Windows.Forms.TextBox txtEspecie;
    private System.Windows.Forms.TextBox txtDescricaoPeixe;
    private System.Windows.Forms.TextBox txtPesoPeixe;
    private System.Windows.Forms.TextBox txtDataAquisicaoPeixe;
    private System.Windows.Forms.Button btnCadastrarPeixe;
    private System.Windows.Forms.Label lblGramas;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ComboBox cbPeixesDoUsuario;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox cbStatusPeixe;
    private System.Windows.Forms.PictureBox pbImagemPeixe;
    private System.Windows.Forms.Button btnUploadFoto;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label lblDataMorte;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.ComboBox cbTamanhoPeixe;
    private System.Windows.Forms.Label lblDescicaoDoenca;
    private System.Windows.Forms.TextBox txtDescricaoDoenca;
    private System.Windows.Forms.Label lblUserLogado;
    private System.Windows.Forms.Label lblSexo;
    private System.Windows.Forms.ComboBox cbSexo;
    private System.Windows.Forms.Button btnVerPeixe;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.TextBox txtDataMorte;
    private System.Windows.Forms.ToolTip dataMorte;
    private System.Windows.Forms.ToolTip dataAquisicao;
    private System.Windows.Forms.Button btnDeletar;
  }
  }