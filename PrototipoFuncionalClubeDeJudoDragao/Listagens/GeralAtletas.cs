using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoFuncionalClubeDeJudoDragao.Listagens
{
    public partial class GeralAtletas : Form
    {
        public GeralAtletas()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
