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
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataFim = dtp_Fim.Text;
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.LicencaInicio = tb_licencaInicio.Text;
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.LicencaFim = tb_licencaFim.Text;

                var radioButtonsNivel = gb_Nivel.Controls.OfType<RadioButton>();
                var radioButtonsTipo = gb_tipo.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtonsNivel)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.RadioNivel = rb.Name;
                    }
                    else
                    {
                        throw new Exception("Escolha um nível");
                    }
                }

                foreach (RadioButton rb in radioButtonsTipo)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.RadioTipo = rb.Name;
                    }
                    else
                    {
                        throw new Exception("Escolha um tipo");
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
