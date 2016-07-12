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
    public partial class ExamesMedicosCaducados : Form
    {
        public ExamesMedicosCaducados()
        {
            InitializeComponent();
        }

        private void rb_cancelar_Click(object sender, EventArgs e)
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
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataExame = dtp_ExameMedico.Text;

                var radioButtons = gb_Tipo.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.RadioSelecionado = rb.Name;
                    }
                    else
                    {
                        throw new Exception("Escolha um tipo primeiro");
                    }
                }

                ExamesMedicosCaducadosLista examesMedicosCaducadosLista = new ExamesMedicosCaducadosLista();
                examesMedicosCaducadosLista.Show();
                this.Hide();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
