﻿using System;
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
    public partial class Recebimentos : Form
    {
        public Recebimentos()
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

                var radioButtons = gb_tipo.Controls.OfType<RadioButton>();

                foreach (RadioButton rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.RadioTipo = rb.Name;
                    }
                    else
                    {
                        throw new Exception("Escolha um Tipo");
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
