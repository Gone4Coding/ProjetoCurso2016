using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoFuncionalClubeDeJudoDragao.Consultas
{
    public partial class TotaisPorGraduacao : Form
    {
        public TotaisPorGraduacao()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio = dtp_Inicio.Text;
            PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio = dtp_Fim.Text;

            TotaisPorGraduacaoLista totaisPorGraduacaoLista = new TotaisPorGraduacaoLista();
            totaisPorGraduacaoLista.Show();
            this.Hide();
        }
    }
}
