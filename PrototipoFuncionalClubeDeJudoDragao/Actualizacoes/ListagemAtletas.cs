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

            if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa != "")
            {
                if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNome"))
                {
                    //getAtletas por ordem de nome
                }
                else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNumero"))
                {
                    //getAtletas por ordem de numero
                }
                else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porLicFederativa"))
                {
                    //getAtletas por ordem de licenca federativa
                }
            }
            else
            {
                List<Atleta> allAtletas = context.AtletaSet.ToList();

                foreach (Atleta item in allAtletas)
                {
                    ListViewItem linha = new ListViewItem(item.Id.ToString());
                    linha.SubItems.Add(item.Name);
                }
            }
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
