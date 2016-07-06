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
    public partial class ClassificacaoDatasProvaLista : Form
    {
        public ClassificacaoDatasProvaLista()
        {
            InitializeComponent();

            String dataInicio = PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.DataInicio;

            //Buscar cenas à bd

            /*foreach (??? item in ???)
            {
                ListViewItem linha = new ListViewItem(items.???.toString());
                linha.SubItems.Add(items.???.toString());
                linha.SubItems.Add(items.???.toString());
                linha.SubItems.Add(items.???.toString());
                linha.SubItems.Add(items.???.toString());

                lv_provas.Items.Add(linha);
            }*/


        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            ClassificacaoDatasProva classificacaoDatasProva = new ClassificacaoDatasProva();
            classificacaoDatasProva.Show();
            this.Hide();
        }
    }
}
