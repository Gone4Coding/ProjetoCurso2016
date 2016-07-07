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
    public partial class RecebimentosLista : Form
    {
        public RecebimentosLista()
        {
            InitializeComponent();
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            Recebimentos recebimentos = new Recebimentos();
            recebimentos.Show();
            this.Hide();
        }
        
    }
}
