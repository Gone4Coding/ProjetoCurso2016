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
    public partial class TotaisPontosLista : Form
    {
        public TotaisPontosLista()
        {
            InitializeComponent();
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            TotaisPontos totaisPontos = new TotaisPontos();
            totaisPontos.Show();
            this.Hide();
        }
    }
}
