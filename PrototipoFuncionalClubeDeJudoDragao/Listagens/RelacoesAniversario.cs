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
    public partial class RelacoesAniversario : Form
    {
        public RelacoesAniversario()
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

                if (tb_mes.Text == "")
                {
                    throw new Exception("Escolha um mês");
                }

                PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.MesAniversario = tb_mes.Text;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
