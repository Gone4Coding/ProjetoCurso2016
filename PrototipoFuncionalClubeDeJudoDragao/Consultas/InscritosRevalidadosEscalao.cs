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
            //SAIR
        }

        private void okEscaloes_Click(object sender, EventArgs e)
        {
            int escalaoInicio = Convert.ToInt32(this.tb_Inicio.Text);
            int escalaoFim = Convert.ToInt32(this.tb_Fim.Text);

            System.Console.WriteLine("");
        }
    }
}
