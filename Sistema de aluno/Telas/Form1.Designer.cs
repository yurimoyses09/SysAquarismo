﻿
namespace Sistema_de_aluno
    {
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoginTelaInicial = new System.Windows.Forms.Button();
            this.btbCadastrarTelaInicial = new System.Windows.Forms.Button();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblSenhaRepetida = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaRepetida = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginTelaInicial
            // 
            this.btnLoginTelaInicial.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLoginTelaInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoginTelaInicial.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginTelaInicial.Location = new System.Drawing.Point(81, 410);
            this.btnLoginTelaInicial.Name = "btnLoginTelaInicial";
            this.btnLoginTelaInicial.Size = new System.Drawing.Size(134, 35);
            this.btnLoginTelaInicial.TabIndex = 0;
            this.btnLoginTelaInicial.Text = "Login";
            this.btnLoginTelaInicial.UseVisualStyleBackColor = false;
            this.btnLoginTelaInicial.Click += new System.EventHandler(this.btnLoginTelaInicial_Click);
            // 
            // btbCadastrarTelaInicial
            // 
            this.btbCadastrarTelaInicial.BackColor = System.Drawing.SystemColors.Desktop;
            this.btbCadastrarTelaInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbCadastrarTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbCadastrarTelaInicial.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCadastrarTelaInicial.Location = new System.Drawing.Point(238, 410);
            this.btbCadastrarTelaInicial.Name = "btbCadastrarTelaInicial";
            this.btbCadastrarTelaInicial.Size = new System.Drawing.Size(134, 35);
            this.btbCadastrarTelaInicial.TabIndex = 1;
            this.btbCadastrarTelaInicial.Text = "Cadastrar";
            this.btbCadastrarTelaInicial.UseVisualStyleBackColor = false;
            this.btbCadastrarTelaInicial.Click += new System.EventHandler(this.btbCadastrarTelaInicial_Click);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(30, 286);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(91, 15);
            this.lblNomeUsuario.TabIndex = 2;
            this.lblNomeUsuario.Text = "Nome Usuario";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(30, 323);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 15);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // lblSenhaRepetida
            // 
            this.lblSenhaRepetida.AutoSize = true;
            this.lblSenhaRepetida.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaRepetida.Location = new System.Drawing.Point(30, 363);
            this.lblSenhaRepetida.Name = "lblSenhaRepetida";
            this.lblSenhaRepetida.Size = new System.Drawing.Size(105, 15);
            this.lblSenhaRepetida.TabIndex = 5;
            this.lblSenhaRepetida.Text = "Repita a senha";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(143, 285);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(254, 21);
            this.txtNomeUsuario.TabIndex = 6;
            this.txtNomeUsuario.TextChanged += new System.EventHandler(this.txtNomeUsuario_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(143, 322);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(254, 21);
            this.txtSenha.TabIndex = 7;
            // 
            // txtSenhaRepetida
            // 
            this.txtSenhaRepetida.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSenhaRepetida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaRepetida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaRepetida.Location = new System.Drawing.Point(143, 362);
            this.txtSenhaRepetida.Name = "txtSenhaRepetida";
            this.txtSenhaRepetida.PasswordChar = '*';
            this.txtSenhaRepetida.Size = new System.Drawing.Size(254, 21);
            this.txtSenhaRepetida.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitulo.Font = new System.Drawing.Font("Chiller", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(136, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 48);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "SyS Aquarismo";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Não Possui Cadastro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_aluno.Properties.Resources.c4058dbab9bfb27555c69a39369e7075;
            this.pictureBox1.Location = new System.Drawing.Point(71, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(436, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtSenhaRepetida);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblSenhaRepetida);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.btbCadastrarTelaInicial);
            this.Controls.Add(this.btnLoginTelaInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Peixes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

    #endregion

    private System.Windows.Forms.Button btnLoginTelaInicial;
    private System.Windows.Forms.Button btbCadastrarTelaInicial;
    private System.Windows.Forms.Label lblNomeUsuario;
    private System.Windows.Forms.Label lblSenha;
    private System.Windows.Forms.Label lblSenhaRepetida;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.TextBox txtSenhaRepetida;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox txtNomeUsuario;
  }
    }

