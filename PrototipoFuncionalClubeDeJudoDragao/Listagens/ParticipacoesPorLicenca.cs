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
    public partial class ParticipacoesPorLicenca : Form
    {
        public ParticipacoesPorLicenca()
        {
            InitializeComponent();
        }

        private void ParticipacoesPorLicenca_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gb_tipo_Enter(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
