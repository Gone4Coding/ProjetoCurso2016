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
    public partial class RelacoesPorDataLista : Form
    {
        public RelacoesPorDataLista()
        {
            InitializeComponent();
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            RelacoesPorData relacoesPorData = new RelacoesPorData();
            relacoesPorData.Show();
            this.Hide();
        }
    }
}
