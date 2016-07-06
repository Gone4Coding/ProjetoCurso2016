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
    public partial class ListagemAtletas : Form
    {
        ModelDiagramaBDContainer context = new ModelDiagramaBDContainer();

        public ListagemAtletas()
        {
            InitializeComponent();

            List<Atleta> allAtletas = context.AtletaSet.ToList();

            foreach(Atleta item in allAtletas)
            {
                ListViewItem linha = new ListViewItem(item.Id.ToString());
                linha.SubItems.Add(item.Name);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

    }
}
