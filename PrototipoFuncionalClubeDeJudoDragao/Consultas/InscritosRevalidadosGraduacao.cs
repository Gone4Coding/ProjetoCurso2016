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
    public partial class InscritosRevalidadosGraduacao : Form
    {
        public InscritosRevalidadosGraduacao()
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

                var radioButtonsTipo = gb_Tipo.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtonsTipo)
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

                var radioButtonsGraduacao = gb_Graduacoes.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtonsTipo)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.RadioSelecionado = rb.Name;
                    }
                    else
                    {
                        throw new Exception("Escolha uma graduação primeiro");
                    }
                }

                InscritosRevalidadosGraduacaoLista inscritosRevalidadosGraduacaoLista = new InscritosRevalidadosGraduacaoLista();
                inscritosRevalidadosGraduacaoLista.Show();
                this.Hide();

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }



        }
    }
}
