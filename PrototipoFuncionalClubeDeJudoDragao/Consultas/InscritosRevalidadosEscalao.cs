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
    public partial class InscritosRevalidadosEscalao : Form
    {
        public InscritosRevalidadosEscalao()
        {
            InitializeComponent();
        }

        private void cancelEscaloes_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void okEscaloes_Click(object sender, EventArgs e)
        {
            try
            {
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio = dtp_Inicio.Text;
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio = dtp_Fim.Text;

                if (tb_escalaoInicio.Text == "" || tb_escalaoFim.Text == "")
                {
                    throw new Exception("Escolha uma gama de escalões");
                }

                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.EscalaoInicio = Convert.ToInt32(tb_escalaoInicio.Text);
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.EscalaoFim = Convert.ToInt32(tb_escalaoFim.Text);

                var radioButtons = gb_Tipo.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.RadioTipo = rb.Name;
                    }
                    else
                    {
                        throw new Exception("Escolha um tipo primeiro");
                    }
                }

                InscritosRevalidadosEscalaoLista inscritosRevalidadosEscalaoLista = new InscritosRevalidadosEscalaoLista();
                inscritosRevalidadosEscalaoLista.Show();
                this.Hide();

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
