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

            switch (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.TokenFichas)
            {
                case "atletas":
                    if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa != "")
                    {
                        if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNome"))
                        {
                            //get por ordem de nome
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNumero"))
                        {
                            //get por ordem de numero
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porLicFederativa"))
                        {
                            //get por ordem de licenca federativa
                        }
                    }
                    else
                    {
                        getAll();
                    }
                    break;

                case "pontos":
                    if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa != "")
                    {
                        if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNome"))
                        {
                            //get por ordem de nome
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNumero"))
                        {
                            //get por ordem de numero
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porLicFederativa"))
                        {
                            //get por ordem de licenca federativa
                        }
                    }
                    else
                    {
                        getAll();
                    }
                    break;

                case "graduacoes":
                    if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa != "")
                    {
                        if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNome"))
                        {
                            //get por ordem de nome
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNumero"))
                        {
                            //get por ordem de numero
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porLicFederativa"))
                        {
                            //get por ordem de licenca federativa
                        }
                    }
                    else
                    {
                        getAll();
                    }
                    break;

                case "participacoes":
                    if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa != "")
                    {
                        if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNome"))
                        {
                            //get por ordem de nome
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNumero"))
                        {
                            //get por ordem de numero
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porLicFederativa"))
                        {
                            //get por ordem de licenca federativa
                        }
                    }
                    else
                    {
                        getAll();
                    }
                    break;

                case "classificacoes":
                    if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa != "")
                    {
                        if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNome"))
                        {
                            //get por ordem de nome
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNumero"))
                        {
                            //get por ordem de numero
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porLicFederativa"))
                        {
                            //get por ordem de licenca federativa
                        }
                    }
                    else
                    {
                        getAll();
                    }
                    break;

                case "recebimentos":
                    if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa != "")
                    {
                        if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNome"))
                        {
                            //get por ordem de nome
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porNumero"))
                        {
                            //get por ordem de numero
                        }
                        else if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa.Equals("rb_porLicFederativa"))
                        {
                            //get por ordem de licenca federativa
                        }
                    }
                    else
                    {
                        getAll();
                    }
                    break;

                case "recebimentosEnviados":
                    if (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa != "")
                    {
                        string resultado = ordemListagem();


                    }
                    else
                    {
                        getAll();
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

        private void getAll()
        {
            List<Atleta> allAtletas = context.AtletaSet.ToList();

            foreach (Atleta item in allAtletas)
            {
                ListViewItem linha = new ListViewItem(item.Id.ToString());
                linha.SubItems.Add(item.Name);
            }
        }

        private string ordemListagem()
        {
            switch (PrototipoFuncionalClubeDeJudoDragao.Properties.Settings.Default.OpcaoPesquisa)
            {
                case "rb_porNome":
                    
                    break;

                case "rb_porNumero":
                    break;

                case "rb_porLicFederativa":
                    break;
            }
            return null;
        }
    }
}
