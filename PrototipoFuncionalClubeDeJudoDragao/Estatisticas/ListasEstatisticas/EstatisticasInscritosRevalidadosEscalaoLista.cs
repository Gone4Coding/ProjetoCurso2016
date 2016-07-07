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
    public partial class EstatisticasInscritosRevalidadosEscalaoLista : Form
    {
        public EstatisticasInscritosRevalidadosEscalaoLista()
        {
            InitializeComponent();
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            EstatisticasInscritosRevalidadosEscalao estatisticasInscritosRevalidadosEscalao = new EstatisticasInscritosRevalidadosEscalao();
            estatisticasInscritosRevalidadosEscalao.Show();
            this.Hide();
        }
    }
}
