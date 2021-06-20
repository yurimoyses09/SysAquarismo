using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamentoDePeixes.Telas
{
    public partial class PerfilUsuario : Form
    {
        public PerfilUsuario(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial(label1.Text);
            this.Visible = false;

            telaInicial.Visible = true;

        }
    }
}
