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
    public partial class EstatisticasInscritosRevalidadosClube : Form
    {
        public EstatisticasInscritosRevalidadosClube()
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
            try
            {
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio = dtp_Inicio.Text;
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio = dtp_Inicio.Text;

                if (tb_clubesInicio.Text == "" || tb_clubesFim.Text == "")
                {
                    throw new Exception("Escolha uma gama de clubes");
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
