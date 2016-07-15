using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoFuncionalClubeDeJudoDragao.Actualizações
{
    public partial class ListagemAtletas : Form
    {
        ModelDiagramaBDContainer context = new ModelDiagramaBDContainer();
        string resultadoPesquisa = null;

        public ListagemAtletas()
        {
            InitializeComponent();

            switch (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa)
            {
                case "rb_porNome":
                    resultadoPesquisa = "order by nome";
                    break;
                case "rb_porNumero":
                    resultadoPesquisa = "order by numero";
                    break;
                case "rb_porLicFederativa":
                    resultadoPesquisa = "order by licFederativa";
                    break;
            }

            switch (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.TokenFichas)
            {
                case "atletas":
                    if (resultadoPesquisa != null)
                    {
                        //query normal + resultado7
                        //preencherListView();
                    }
                    else
                    {
                        //query normal
                        //preencherListView();
                    }
                    break;

                case "pontos":
                    if (resultadoPesquisa != null)
                    {
                        //query normal + resultado7
                        //preencherListView();
                    }
                    else
                    {
                        //query normal
                        //preencherListView();
                    }
                    break;

                case "graduacoes":
                    if (resultadoPesquisa != null)
                    {

                    }
                    else
                    {
                        //query normal
                        //preencherListView();
                    }
                    break;

                case "participacoes":
                    if (resultadoPesquisa != null)
                    {
                        //query normal + resultado7
                        //preencherListView();
                    }
                    else
                    {
                        //query normal
                        //preencherListView();
                    }
                    break;

                case "classificacoes":
                    if (resultadoPesquisa != null)
                    {
                        //query normal + resultado7
                        //preencherListView();
                    }
                    else
                    {
                        //query normal
                        //preencherListView();
                    }
                    break;

                case "recebimentos":
                    if (resultadoPesquisa != null)
                    {
                        //query normal + resultado7
                        //preencherListView();
                    }
                    else
                    {
                        //query normal
                        //preencherListView();
                    }
                    break;

                case "recebimentosEnviados":
                    if (resultadoPesquisa != null)
                    {
                        //query normal + resultado7
                        //preencherListView();
                    }
                    else
                    {
                        //query normal
                        //preencherListView();
                    }
                    break;
            }
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void preencherListView(List<Atleta> listaResultados)
        {
            foreach (Atleta item in listaResultados)
            {
                ListViewItem linha = new ListViewItem(item.Id.ToString());
                linha.SubItems.Add(item.Name);
            }
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string padrao = @"^[0-9A-Za-z ]+$";
                Regex regex = new Regex(padrao);
                string textoPesquisa = tb_pesquisar.Text;
                if (!regex.IsMatch(textoPesquisa))
                {
                    throw new Exception("Não insira caracteres especiais (incluido o 'ç' ou 'Ç')");
                }



            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
