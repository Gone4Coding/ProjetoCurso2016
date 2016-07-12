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

        private void bt_ok_Click(object sender, EventArgs e)
        {
            try
            {
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.CodigoAtletaInicio = Convert.ToInt32(tb_codigoAtletaInicio.Text);
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.CodigoAtletaFim = Convert.ToInt32(tb_codigoAtletaFim.Text);

                var radioButtons = gb_tipoSituacao.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.RadioTipoSituacao = rb.Name;
                    }
                    else
                    {
                        throw new Exception("Escolha um tipo de Situação");
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
