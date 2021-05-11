
namespace SistemaDeGerenciamentoDePeixes.Telas
{
    partial class TelaInfoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInfoUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenhaRedefinida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcurarDados = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaRedefinida2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome de Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsuario.Location = new System.Drawing.Point(169, 78);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtNomeLogin
            // 
            this.txtNomeLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNomeLogin.Location = new System.Drawing.Point(169, 119);
            this.txtNomeLogin.Name = "txtNomeLogin";
            this.txtNomeLogin.Size = new System.Drawing.Size(121, 20);
            this.txtNomeLogin.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nova senha";
            this.label5.Visible = false;
            // 
            // txtSenhaRedefinida
            // 
            this.txtSenhaRedefinida.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSenhaRedefinida.Location = new System.Drawing.Point(169, 218);
            this.txtSenhaRedefinida.Name = "txtSenhaRedefinida";
            this.txtSenhaRedefinida.PasswordChar = '*';
            this.txtSenhaRedefinida.Size = new System.Drawing.Size(121, 20);
            this.txtSenhaRedefinida.TabIndex = 13;
            this.txtSenhaRedefinida.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Informações Necessarias para Redefinir Senha";
            // 
            // btnProcurarDados
            // 
            this.btnProcurarDados.BackColor = System.Drawing.Color.Orange;
            this.btnProcurarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarDados.Location = new System.Drawing.Point(109, 166);
            this.btnProcurarDados.Name = "btnProcurarDados";
            this.btnProcurarDados.Size = new System.Drawing.Size(121, 23);
            this.btnProcurarDados.TabIndex = 15;
            this.btnProcurarDados.Text = "Redefinir Senha";
            this.btnProcurarDados.UseVisualStyleBackColor = false;
            this.btnProcurarDados.Click += new System.EventHandler(this.btnProcurarDados_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Repita Senha";
            this.label3.Visible = false;
            // 
            // txtSenhaRedefinida2
            // 
            this.txtSenhaRedefinida2.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSenhaRedefinida2.Location = new System.Drawing.Point(169, 255);
            this.txtSenhaRedefinida2.Name = "txtSenhaRedefinida2";
            this.txtSenhaRedefinida2.PasswordChar = '*';
            this.txtSenhaRedefinida2.Size = new System.Drawing.Size(121, 20);
            this.txtSenhaRedefinida2.TabIndex = 17;
            this.txtSenhaRedefinida2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(101, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Salvar nova Senha";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TelaInfoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeGerenciamentoDePeixes.Properties.Resources._3615b8c01dfa0f17d68b752ffe888304;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 339);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenhaRedefinida2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProcurarDados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenhaRedefinida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeLogin);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInfoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInfoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNomeLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaRedefinida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurarDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaRedefinida2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}