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
    public partial class TotaisGraduacaoPorClube : Form
    {
        public TotaisGraduacaoPorClube()
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
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio = dtp_Fim.Text;

                if (tb_codigoClube.Text == "")
                {
                    throw new Exception("Insira um código de clube");
                }

                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.CodigoClube = Convert.ToInt32(tb_codigoClube.Text);

                TotaisGraduacaoPorClubeLista totaisGraduacaoPorClubeLista = new TotaisGraduacaoPorClubeLista();
                totaisGraduacaoPorClubeLista.Show();
                this.Hide();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }

        }
    }
}
