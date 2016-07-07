using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoFuncionalClubeDeJudoDragao.Listagens.Listas
{
    public partial class RelacoesAniversarioLista : Form
    {
        public RelacoesAniversarioLista()
        {
            InitializeComponent();
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            RelacoesAniversario relacoesAniversario = new RelacoesAniversario();
            relacoesAniversario.Show();
            this.Hide();
        }
    }
}
