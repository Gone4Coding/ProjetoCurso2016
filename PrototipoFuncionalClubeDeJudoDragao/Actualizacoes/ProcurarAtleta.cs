using PrototipoFuncionalClubeDeJudoDragao.Actualizacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoFuncionalClubeDeJudoDragao.Actualizações
{
    public partial class ProcurarAtleta : Form
    {
        public ProcurarAtleta()
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
                var radioButtons = gb_opcoes.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa = rb.Text;
                    }
                    else
                    {
                        throw new Exception("Escolha um tipo de pesquisa");
                    }
                }

                FichaAtleta fichaAtleta = new FichaAtleta();
                fichaAtleta.Show();
                this.Hide();
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
