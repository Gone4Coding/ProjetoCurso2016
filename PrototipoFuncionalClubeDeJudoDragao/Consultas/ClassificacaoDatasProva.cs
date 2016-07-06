using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoFuncionalClubeDeJudoDragao;

namespace PrototipoFuncionalClubeDeJudoDragao.Consultas
{
    public partial class ClassificacaoDatasProva : Form
    {
        public ClassificacaoDatasProva()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio = dtp_Inicio.Text;

            ClassificacaoDatasProvaLista listaProvas = new ClassificacaoDatasProvaLista();
            listaProvas.Show();
            this.Hide();
        }

        private void bt_cancelarG_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
