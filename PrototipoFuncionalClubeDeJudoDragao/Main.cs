﻿using PrototipoFuncionalClubeDeJudoDragao.Actualizações;
using PrototipoFuncionalClubeDeJudoDragao.Consultas;
using PrototipoFuncionalClubeDeJudoDragao.Listagens;
using PrototipoFuncionalClubeDeJudoDragao.Estatisticas;
using PrototipoFuncionalClubeDeJudoDragao.Utilitarios;
using PrototipoFuncionalClubeDeJudoDragao.Tabelas;
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

        private void ts_actualizacoes_fichaAtletas_listarTodos_Click(object sender, EventArgs e)
        {
            ListagemAtletas listagemAtletas = new ListagemAtletas();
            listagemAtletas.Show();
            this.Hide();
        }

        private void ts_actualizacoes_fichaAtletas_procurarAtleta_Click(object sender, EventArgs e)
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

        private void ts_consultas_inscritosERevalidadosPorEscalao_Click(object sender, EventArgs e)
        {
            InscritosRevalidadosEscalao inscritosRevalidadosEscalao = new InscritosRevalidadosEscalao();
            inscritosRevalidadosEscalao.Show();
            this.Hide();
        }

        private void ts_consultas_inscritosERevalidadosPorGraduacao_Click(object sender, EventArgs e)
        {
            InscritosRevalidadosGraduacao inscritosRevalidadosGraduacao = new InscritosRevalidadosGraduacao();
            inscritosRevalidadosGraduacao.Show();
            this.Hide();
        }

        private void ts_consultas_examesMedicosCaducados_Click(object sender, EventArgs e)
        {
            ExamesMedicosCaducados examesMedicosCaducados = new ExamesMedicosCaducados();
            examesMedicosCaducados.Show();
            this.Hide();
        }

        private void ts_consultas_classificacoesPorDataDeProva_Click(object sender, EventArgs e)
        {
            ClassificacaoDatasProva classificacaoDatasProva = new ClassificacaoDatasProva();
            classificacaoDatasProva.Show();
            this.Hide();
        }

        private void ts_consultas_classificacoesPorTipoDeProva_Click(object sender, EventArgs e)
        {
            ClassificacaoTipoProva classificacaoTipoProva = new ClassificacaoTipoProva();
            classificacaoTipoProva.Show();
            this.Hide();
        }

        private void ts_consultas_pontosPorLicenca_Click(object sender, EventArgs e)
        {
            PontosPorLicenca pontosPorLicenca = new PontosPorLicenca();
            pontosPorLicenca.Show();
            this.Hide();
        }

        private void ts_consultas_totaisPorGraduacao_Click(object sender, EventArgs e)
        {
            TotaisPorGraduacao totaisPorGraduacao = new TotaisPorGraduacao();
            totaisPorGraduacao.Show();
            this.Hide();
        }

        private void ts_consultas_totaisDeGraduacoesPorClube_Click(object sender, EventArgs e)
        {
            TotaisGraduacaoPorClube totaisGraduacaoPorClube = new TotaisGraduacaoPorClube();
            totaisGraduacaoPorClube.Show();
            this.Hide();
        }

        private void ts_listagens_atletasNaoRevalidados_Click(object sender, EventArgs e)
        {
            AtletasNaoRevalidados atletasNaoRevalidados = new AtletasNaoRevalidados();
            atletasNaoRevalidados.Show();
            this.Hide();
        }

        private void ts_listagens_atletasPorSeguro_Click(object sender, EventArgs e)
        {
            AtletasPorSeguro atletasPorSeguro = new AtletasPorSeguro();
            atletasPorSeguro.Show();
            this.Hide();
        }

        private void ts_listagens_datasDeGraduacao_Click(object sender, EventArgs e)
        {
            DatasGraduacao datasGraduacao = new DatasGraduacao();
            datasGraduacao.Show();
            this.Hide();
        }

        private void ts_listagens_geralDeAtletas_Click(object sender, EventArgs e)
        {
            GeralAtletas geralAtletas = new GeralAtletas();
            geralAtletas.Show();
            this.Hide();
        }

        private void ts_listagens_participacoesPorLicenca_Click(object sender, EventArgs e)
        {
            ParticipacoesPorLicenca participacoesPorLicenca = new ParticipacoesPorLicenca();
            participacoesPorLicenca.Show();
            this.Hide();
        }

        private void ts_listagens_recebimentos_Click(object sender, EventArgs e)
        {
            Recebimentos recebimentos = new Recebimentos();
            recebimentos.Show();
            this.Hide();
        }

        private void ts_listagens_recebimentosDeEntidades_Click(object sender, EventArgs e)
        {
            RecebimentoEntidades recebimentosEntidade = new RecebimentoEntidades();
            recebimentosEntidade.Show();
            this.Hide();
        }

        private void ts_listagens_relacoesPorData_Click(object sender, EventArgs e)
        {
            RelacoesPorData relacoesPorData = new RelacoesPorData();
            relacoesPorData.Show();
            this.Hide();
        }

        private void ts_listagens_relacaoDeAniversarios_Click(object sender, EventArgs e)
        {
            RelacoesAniversario relacoesAniversario = new RelacoesAniversario();
            relacoesAniversario.Show();
            this.Hide();
        }

        private void ts_listagens_totaisDePontos_Click(object sender, EventArgs e)
        {
            TotaisPontos totaisPontos = new TotaisPontos();
            totaisPontos.Show();
            this.Hide();
        }

        private void ts_estatisticas_inscritosERevalidadosPorEscalao_Click(object sender, EventArgs e)
        {
            EstatisticasInscritosRevalidadosEscalao estatisticasInscritosRevalidadosEscalao = new EstatisticasInscritosRevalidadosEscalao();
            estatisticasInscritosRevalidadosEscalao.Show();
            this.Hide();
        }

        private void ts_estatisticas_inscritosERevalidadosPorClubes_Click(object sender, EventArgs e)
        {
            EstatisticasInscritosRevalidadosClube estatisticasInscritosRevalidadosClube = new EstatisticasInscritosRevalidadosClube();
            estatisticasInscritosRevalidadosClube.Show();
            this.Hide();
        }

        private void ts_utilitarios_alteracaoACodigosDeSituacao_Click(object sender, EventArgs e)
        {
            AlteracaoCodigoSituacao alteracaoCodigoSituacao = new AlteracaoCodigoSituacao();
            alteracaoCodigoSituacao.Show();
            this.Hide();
        }

        private void ts_informacoes_Click(object sender, EventArgs e)
        {
            Informacoes informacoes = new Informacoes();
            informacoes.Show();
            this.Hide();
        }

        private void ts_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.None) == DialogResult.OK)
                Application.Exit();
            
        }

        private void ts_tabelas_codigosDeArbitros_Click(object sender, EventArgs e)
        {
            CodigoArbitros codigoArbitros = new CodigoArbitros();
            codigoArbitros.Show();
            this.Hide();
        }

        private void ts_tabelas_codigosDeEntidades_Click(object sender, EventArgs e)
        {
            CodigoEntidades codigoEntidades = new CodigoEntidades();
            codigoEntidades.Show();
            this.Hide();
        }

        private void ts_tabelas_codigosDeEscaloes_Click(object sender, EventArgs e)
        {
            CodigoEscaloes codigoEscaloes = new CodigoEscaloes();
            codigoEscaloes.Show();
            this.Hide();
        }

        private void ts_tabelas_codigosDeGraduacoes_Click(object sender, EventArgs e)
        {
            CodigoGraduacoes codigoGraduacoes = new CodigoGraduacoes();
            codigoGraduacoes.Show();
            this.Hide();
        }

        private void ts_tabelas_codigosDeSeguros_Click(object sender, EventArgs e)
        {
            CodigoSeguros codigoSeguros = new CodigoSeguros();
            codigoSeguros.Show();
            this.Hide();
        }

        private void ts_tabelas_codigosDeSituacoes_Click(object sender, EventArgs e)
        {
            CodigoSituacoes codigoSituacoes = new CodigoSituacoes();
            codigoSituacoes.Show();
            this.Hide();
        }

        private void ts_tabelas_codigosDeTreinadores_Click(object sender, EventArgs e)
        {
            CodigoTreinadores codigoTreinadores = new CodigoTreinadores();
            codigoTreinadores.Show();
            this.Hide();
        }

        private void ts_atualizacoes_fichaPontos_listarTodos_Click(object sender, EventArgs e)
        {
            //listagemAtletas PONTOS
        }

        private void ts_atualizacoes_fichaGraduacoes_listarTodos_Click(object sender, EventArgs e)
        {
            //listagemAtletas GRADUACOES
        }

        private void ts_atualizacoes_fichaParticipacoes_listarTodos_Click(object sender, EventArgs e)
        {
            //listagemAtletas PARTICIPACOES
        }

        private void ts_atualiacoes_fichaClassificacoes_listarTodos_Click(object sender, EventArgs e)
        {
            //listagemAtletas CLASSIFICACOES
        }

        private void ts_atualiacoes_fichaRecebimenos_listarTodos_Click(object sender, EventArgs e)
        {
            //listagemAtletas RECEBIMENTOS
        }

        private void ts_atualiacoes_fichaRecebimentosEnvaidos_listarTodos_Click(object sender, EventArgs e)
        {
            //listagemAtletas RECEBIMENTOS ENVIADOS
        }
    }
}
