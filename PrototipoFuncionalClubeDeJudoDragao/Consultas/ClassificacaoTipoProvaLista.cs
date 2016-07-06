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
    public partial class ClassificacaoTipoProvaLista : Form
    {
        public ClassificacaoTipoProvaLista()
        {
            InitializeComponent();
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            ClassificacaoTipoProva classificacaoTipoProvaL = new ClassificacaoTipoProva();
            classificacaoTipoProvaL.Show();
            this.Hide();
        }
    }
}
