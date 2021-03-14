using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_aluno.Telas
{
    public partial class TelaPeixe : Form
    {
        public TelaPeixe()
        {
            InitializeComponent();
        }

        private void TelaPeixe_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }
    }
}
