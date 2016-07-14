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
    public partial class PontosPorLicenca : Form
    {
        public PontosPorLicenca()
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
                if (tb_licencaFederativa.Text == "")
                {
                    throw new Exception("Insira uma licença");
                }

                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.LicencaFederativa = Convert.ToInt32(tb_licencaFederativa.Text);

                var radioButtons = gb_Graduacoes.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.RadioGraduacao = rb.Name;
                    }
                    else
                    {
                        throw new Exception("Escolha uma graduação primeiro");
                    }
                }

                PontosPorLicencaLista pontosPorLicencaLista = new PontosPorLicencaLista();
                pontosPorLicencaLista.Show();
                this.Hide();

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
