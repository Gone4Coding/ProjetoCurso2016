﻿using System;
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
    public partial class InscritosRevalidadosEscalaoLista : Form
    {
        public InscritosRevalidadosEscalaoLista()
        {
            InitializeComponent();
        }

        private void bt_retroceder_Click(object sender, EventArgs e)
        {
            InscritosRevalidadosEscalao inscritosRevalidadosEscalao = new InscritosRevalidadosEscalao();
            inscritosRevalidadosEscalao.Show();
            this.Hide();
        }
    }
}
