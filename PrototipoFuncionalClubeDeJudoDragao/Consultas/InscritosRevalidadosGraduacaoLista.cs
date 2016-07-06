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
    public partial class InscritosRevalidadosGraduacaoLista : Form
    {
        public InscritosRevalidadosGraduacaoLista()
        {
            InitializeComponent();
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            InscritosRevalidadosGraduacao inscritosRevalidadosGraduacao = new InscritosRevalidadosGraduacao();
            inscritosRevalidadosGraduacao.Show();
            this.Hide();
        }
    }
}
