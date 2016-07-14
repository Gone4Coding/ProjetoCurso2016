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
    public partial class ClassificacaoTipoProva : Form
    {
        public ClassificacaoTipoProva()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            try
            {
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio = dtp_Inicio.Text;
                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataFim = dtp_Fim.Text;

                var radioButtons = gb_Nivel.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.RadioNivel = rb.Name;
                    }
                    else
                    {
                        throw new Exception("Escolha um nível primeiro");
                    }
                }

                ClassificacaoTipoProvaLista classificacaoTipoProvaLista = new ClassificacaoTipoProvaLista();
                classificacaoTipoProvaLista.Show();
                this.Hide();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
