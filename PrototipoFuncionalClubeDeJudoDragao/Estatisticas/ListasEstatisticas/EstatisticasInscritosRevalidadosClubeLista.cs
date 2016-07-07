using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoFuncionalClubeDeJudoDragao.Estatisticas
{
    public partial class EstatisticasInscritosRevalidadosClubeLista : Form
    {
        public EstatisticasInscritosRevalidadosClubeLista()
        {
            InitializeComponent();
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            EstatisticasInscritosRevalidadosClube estatisticasInscritosRevalidadosClube = new EstatisticasInscritosRevalidadosClube();
            estatisticasInscritosRevalidadosClube.Show();
            this.Hide();
        }
    }
}
