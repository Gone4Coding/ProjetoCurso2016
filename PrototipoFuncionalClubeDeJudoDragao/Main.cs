using PrototipoFuncionalClubeDeJudoDragao.Actualizações;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoFuncionalClubeDeJudoDragao
{
    public partial class Main : Form
    {
        ModelDiagramaBDContainer context = new ModelDiagramaBDContainer();
        public Main()
        {
            InitializeComponent();
        }

        private void ts_actualizações_fichaAtletas_listarTodos_Click(object sender, EventArgs e)
        {
            ListagemAtletas listagemAtletas = new ListagemAtletas();
            listagemAtletas.Show();
            this.Hide();
        }

        private void ts_actualizações_fichaAtletas_procurarAtleta_Click(object sender, EventArgs e)
        {
            ProcurarAtleta procurarAtleta = new ProcurarAtleta();
            procurarAtleta.Show();
            this.Hide();
        }

        private void injecao_Click(object sender, EventArgs e)
        {
            Atleta atleta = new Atleta();

            atleta.Name = "Hugo";

            context.AtletaSet.Add(atleta);

            //Atleta atleta1 = new Atleta();

            //atleta.Name = "Gonçalo";

            //context.AtletaSet.Add(atleta1);

            //Atleta atleta2 = new Atleta();

            //atleta.Name = "Pragas";

            //context.AtletaSet.Add(atleta2);

            //Atleta atleta3 = new Atleta();

            //atleta.Name = "Tiago";

            //context.AtletaSet.Add(atleta3);

            //Atleta atleta4 = new Atleta();

            //atleta.Name = "Rato";

            //context.AtletaSet.Add(atleta4);

            //Atleta atleta5 = new Atleta();

            //atleta.Name = "Vieira";

            //context.AtletaSet.Add(atleta5);

            //Atleta atleta6 = new Atleta();

            //atleta.Name = "Joao";

            //context.AtletaSet.Add(atleta6);

            //Atleta atleta7 = new Atleta();

            //atleta.Name = "Ricardo";

            //context.AtletaSet.Add(atleta7);

            //Atleta atleta8 = new Atleta();

            //atleta.Name = "Ricol";

            //context.AtletaSet.Add(atleta8);

            //Atleta atleta9 = new Atleta();

            //atleta.Name = "Duarte";

            //context.AtletaSet.Add(atleta9);

            context.SaveChanges();
            MessageBox.Show("Atletas criados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
