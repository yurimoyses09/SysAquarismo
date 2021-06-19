
namespace SistemaDeGerenciamentoDePeixes.Telas
{
  partial class TelaPeixe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPeixe));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtDataMorte = new System.Windows.Forms.TextBox();
            this.txtDescricaoDoente = new System.Windows.Forms.TextBox();
            this.pBImagem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTamanho = new System.Windows.Forms.ComboBox();
            this.cbStatusSaude = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnVoltarTelaInicial = new System.Windows.Forms.Button();
            this.txtAquisicaoData = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNome.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(516, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(116, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtEspecie
            // 
            this.txtEspecie.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEspecie.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(516, 80);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(116, 22);
            this.txtEspecie.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescricao.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(516, 121);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(224, 74);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtDataMorte
            // 
            this.txtDataMorte.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDataMorte.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataMorte.Location = new System.Drawing.Point(516, 309);
            this.txtDataMorte.Name = "txtDataMorte";
            this.txtDataMorte.ReadOnly = true;
            this.txtDataMorte.Size = new System.Drawing.Size(116, 22);
            this.txtDataMorte.TabIndex = 5;
            this.txtDataMorte.TextChanged += new System.EventHandler(this.txtDataMorte_TextChanged);
            // 
            // txtDescricaoDoente
            // 
            this.txtDescricaoDoente.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescricaoDoente.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoDoente.Location = new System.Drawing.Point(516, 398);
            this.txtDescricaoDoente.Multiline = true;
            this.txtDescricaoDoente.Name = "txtDescricaoDoente";
            this.txtDescricaoDoente.ReadOnly = true;
            this.txtDescricaoDoente.Size = new System.Drawing.Size(224, 75);
            this.txtDescricaoDoente.TabIndex = 7;
            // 
            // pBImagem
            // 
            this.pBImagem.BackColor = System.Drawing.Color.Gainsboro;
            this.pBImagem.Location = new System.Drawing.Point(28, 121);
            this.pBImagem.Name = "pBImagem";
            this.pBImagem.Size = new System.Drawing.Size(304, 251);
            this.pBImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBImagem.TabIndex = 11;
            this.pBImagem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(369, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome Peixe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(369, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tamanho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(369, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data Morte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowText;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(369, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descrição da Doença";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowText;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(369, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data Aquisição";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.WindowText;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(369, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sexo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.WindowText;
            this.label9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(369, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "Status Saude";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.WindowText;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(369, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "Peso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.WindowText;
            this.label11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(369, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "Descrição";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.WindowText;
            this.label12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(369, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "Especie";
            // 
            // cbTamanho
            // 
            this.cbTamanho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTamanho.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTamanho.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamanho.FormattingEnabled = true;
            this.cbTamanho.Items.AddRange(new object[] {
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
            this.cbTamanho.Location = new System.Drawing.Point(516, 265);
            this.cbTamanho.Name = "cbTamanho";
            this.cbTamanho.Size = new System.Drawing.Size(140, 22);
            this.cbTamanho.TabIndex = 24;
            // 
            // cbStatusSaude
            // 
            this.cbStatusSaude.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbStatusSaude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusSaude.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusSaude.FormattingEnabled = true;
            this.cbStatusSaude.Items.AddRange(new object[] {
            "Faleceu",
            "Saudavel",
            "Doente"});
            this.cbStatusSaude.Location = new System.Drawing.Point(516, 349);
            this.cbStatusSaude.Name = "cbStatusSaude";
            this.cbStatusSaude.Size = new System.Drawing.Size(140, 22);
            this.cbStatusSaude.TabIndex = 25;
            this.cbStatusSaude.SelectedIndexChanged += new System.EventHandler(this.cbStatusSaude_SelectedIndexChanged);
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
            this.cbSexo.Location = new System.Drawing.Point(516, 538);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(140, 22);
            this.cbSexo.TabIndex = 26;
            // 
            // btnVoltarTelaInicial
            // 
            this.btnVoltarTelaInicial.BackColor = System.Drawing.Color.LightCoral;
            this.btnVoltarTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarTelaInicial.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarTelaInicial.Location = new System.Drawing.Point(28, 30);
            this.btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            this.btnVoltarTelaInicial.Size = new System.Drawing.Size(70, 25);
            this.btnVoltarTelaInicial.TabIndex = 27;
            this.btnVoltarTelaInicial.Text = "Voltar ";
            this.btnVoltarTelaInicial.UseVisualStyleBackColor = false;
            this.btnVoltarTelaInicial.Click += new System.EventHandler(this.btnVoltarTelaInicial_Click);
            // 
            // txtAquisicaoData
            // 
            this.txtAquisicaoData.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAquisicaoData.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAquisicaoData.Location = new System.Drawing.Point(516, 494);
            this.txtAquisicaoData.Name = "txtAquisicaoData";
            this.txtAquisicaoData.ReadOnly = true;
            this.txtAquisicaoData.Size = new System.Drawing.Size(116, 22);
            this.txtAquisicaoData.TabIndex = 28;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(504, 595);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(152, 45);
            this.btnAtualizar.TabIndex = 29;
            this.btnAtualizar.Text = "Atualizar dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPeso.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(516, 212);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(116, 22);
            this.txtPeso.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(707, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 32;
            this.label1.UseMnemonic = false;
            // 
            // TelaPeixe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeGerenciamentoDePeixes.Properties.Resources._996a3461932f352502933385beb68f1c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtAquisicaoData);
            this.Controls.Add(this.btnVoltarTelaInicial);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.cbStatusSaude);
            this.Controls.Add(this.cbTamanho);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBImagem);
            this.Controls.Add(this.txtDescricaoDoente);
            this.Controls.Add(this.txtDataMorte);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPeixe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPeixe";
            this.Load += new System.EventHandler(this.TelaPeixe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    public System.Windows.Forms.TextBox txtNome;
    public System.Windows.Forms.TextBox txtEspecie;
    public System.Windows.Forms.TextBox txtDescricao;
    public System.Windows.Forms.TextBox txtDataMorte;
    public System.Windows.Forms.TextBox txtDescricaoDoente;
    public System.Windows.Forms.ComboBox cbTamanho;
    public System.Windows.Forms.ComboBox cbStatusSaude;
    public System.Windows.Forms.ComboBox cbSexo;
    public System.Windows.Forms.PictureBox pBImagem;
    private System.Windows.Forms.Button btnVoltarTelaInicial;
    public System.Windows.Forms.TextBox txtAquisicaoData;
    private System.Windows.Forms.Button btnAtualizar;
    public System.Windows.Forms.TextBox txtPeso;
    private System.Windows.Forms.Label label1;
  }
}