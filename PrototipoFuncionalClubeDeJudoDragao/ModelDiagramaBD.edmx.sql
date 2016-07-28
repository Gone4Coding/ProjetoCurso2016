
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/28/2016 12:00:02
-- Generated from EDMX file: C:\Git\ProjetoCurso2016\PrototipoFuncionalClubeDeJudoDragao\ModelDiagramaBD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PrototipoFuncional];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_InscricaoSocios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoSet] DROP CONSTRAINT [FK_InscricaoSocios];
GO
IF OBJECT_ID(N'[dbo].[FK_SociosQuotas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuotasSet] DROP CONSTRAINT [FK_SociosQuotas];
GO
IF OBJECT_ID(N'[dbo].[FK_QuotasTipoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuotasSet] DROP CONSTRAINT [FK_QuotasTipoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_EntidadesQuotas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuotasSet] DROP CONSTRAINT [FK_EntidadesQuotas];
GO
IF OBJECT_ID(N'[dbo].[FK_ParticipacaoNivel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParticipacaoSet] DROP CONSTRAINT [FK_ParticipacaoNivel];
GO
IF OBJECT_ID(N'[dbo].[FK_ExameInscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoSet] DROP CONSTRAINT [FK_ExameInscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_ArbitroInscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArbitroSet] DROP CONSTRAINT [FK_ArbitroInscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_TreinadoresInscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TreinadoresSet] DROP CONSTRAINT [FK_TreinadoresInscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoParticipacao_Inscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoParticipacao] DROP CONSTRAINT [FK_InscricaoParticipacao_Inscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoParticipacao_Participacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoParticipacao] DROP CONSTRAINT [FK_InscricaoParticipacao_Participacao];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoResultadoCompeticao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoSet] DROP CONSTRAINT [FK_InscricaoResultadoCompeticao];
GO
IF OBJECT_ID(N'[dbo].[FK_ResultadoCompeticaoCompeticao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResultadoCompeticaoSet] DROP CONSTRAINT [FK_ResultadoCompeticaoCompeticao];
GO
IF OBJECT_ID(N'[dbo].[FK_NivelCompeticao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompeticaoSet] DROP CONSTRAINT [FK_NivelCompeticao];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoInscricaoJudo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoJudoSet] DROP CONSTRAINT [FK_InscricaoInscricaoJudo];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoInscricaoJiujitsu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoJiujitsuSet] DROP CONSTRAINT [FK_InscricaoInscricaoJiujitsu];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoInscricaoAikido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoAikidoSet] DROP CONSTRAINT [FK_InscricaoInscricaoAikido];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoJudoEscalaoJudo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoJudoSet] DROP CONSTRAINT [FK_InscricaoJudoEscalaoJudo];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoJiujitsuEscalaoJiujitsu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoJiujitsuSet] DROP CONSTRAINT [FK_InscricaoJiujitsuEscalaoJiujitsu];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoAikidoEscalaoAikido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoAikidoSet] DROP CONSTRAINT [FK_InscricaoAikidoEscalaoAikido];
GO
IF OBJECT_ID(N'[dbo].[FK_ExameGraduacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExameSet] DROP CONSTRAINT [FK_ExameGraduacao];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SociosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SociosSet];
GO
IF OBJECT_ID(N'[dbo].[InscricaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscricaoSet];
GO
IF OBJECT_ID(N'[dbo].[EntidadesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EntidadesSet];
GO
IF OBJECT_ID(N'[dbo].[QuotasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuotasSet];
GO
IF OBJECT_ID(N'[dbo].[TipoPagamentoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoPagamentoSet];
GO
IF OBJECT_ID(N'[dbo].[InscricaoJudoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscricaoJudoSet];
GO
IF OBJECT_ID(N'[dbo].[InscricaoJiujitsuSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscricaoJiujitsuSet];
GO
IF OBJECT_ID(N'[dbo].[InscricaoAikidoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscricaoAikidoSet];
GO
IF OBJECT_ID(N'[dbo].[EscalaoJudoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EscalaoJudoSet];
GO
IF OBJECT_ID(N'[dbo].[EscalaoJiujitsuSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EscalaoJiujitsuSet];
GO
IF OBJECT_ID(N'[dbo].[EscalaoAikidoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EscalaoAikidoSet];
GO
IF OBJECT_ID(N'[dbo].[TreinadoresSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TreinadoresSet];
GO
IF OBJECT_ID(N'[dbo].[ArbitroSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArbitroSet];
GO
IF OBJECT_ID(N'[dbo].[ExameSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExameSet];
GO
IF OBJECT_ID(N'[dbo].[GraduacaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GraduacaoSet];
GO
IF OBJECT_ID(N'[dbo].[ParticipacaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ParticipacaoSet];
GO
IF OBJECT_ID(N'[dbo].[NivelSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NivelSet];
GO
IF OBJECT_ID(N'[dbo].[CompeticaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompeticaoSet];
GO
IF OBJECT_ID(N'[dbo].[ResultadoCompeticaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResultadoCompeticaoSet];
GO
IF OBJECT_ID(N'[dbo].[InscricaoParticipacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscricaoParticipacao];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SociosSet'
CREATE TABLE [dbo].[SociosSet] (
    [NumeroSocio] int IDENTITY(1,1) NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [CodigoPostal] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [DataNascimento] datetime  NOT NULL,
    [Nif] int  NOT NULL,
    [NumeroCC] int  NOT NULL,
    [DataEmissaoCC] datetime  NOT NULL,
    [Nacionalidade] nvarchar(max)  NOT NULL,
    [Profissao] nvarchar(max)  NOT NULL,
    [Freguesia] nvarchar(max)  NOT NULL,
    [Concelho] nvarchar(max)  NOT NULL,
    [Sexo] nvarchar(max)  NOT NULL,
    [EstadoCivil] nvarchar(max)  NOT NULL,
    [Pai] nvarchar(max)  NULL,
    [Mae] nvarchar(max)  NULL,
    [Telefone1] nvarchar(max)  NULL,
    [Telefone2] nvarchar(max)  NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InscricaoSet'
CREATE TABLE [dbo].[InscricaoSet] (
    [IdInscricao] int IDENTITY(1,1) NOT NULL,
    [NumeroSocio] int  NOT NULL,
    [DataInscricao] datetime  NOT NULL,
    [DataRevalidacao] datetime  NOT NULL,
    [DataRevalidacaoAnterior] datetime  NOT NULL,
    [DataExameMedico] datetime  NOT NULL,
    [Estado] varbinary(max)  NOT NULL,
    [Socios_NumeroSocio] int  NOT NULL,
    [Exame_IdExame] int  NOT NULL,
    [ResultadoCompeticao_IdResultadoCompeticao] int  NOT NULL
);
GO

-- Creating table 'EntidadesSet'
CREATE TABLE [dbo].[EntidadesSet] (
    [NumeroEntidade] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodigoPostal] nvarchar(max)  NOT NULL,
    [Contato] nvarchar(max)  NOT NULL,
    [TipoEntidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'QuotasSet'
CREATE TABLE [dbo].[QuotasSet] (
    [NumeroQuota] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Valor] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Socios_NumeroSocio] int  NOT NULL,
    [TipoPagamento_IdTipoPagamento] int  NULL,
    [Entidades_NumeroEntidade] int  NOT NULL
);
GO

-- Creating table 'TipoPagamentoSet'
CREATE TABLE [dbo].[TipoPagamentoSet] (
    [IdTipoPagamento] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InscricaoJudoSet'
CREATE TABLE [dbo].[InscricaoJudoSet] (
    [IdInscricaoJudo] int IDENTITY(1,1) NOT NULL,
    [IdInscricao] int  NOT NULL,
    [LicencaFederativa] int  NOT NULL,
    [Inscricao_IdInscricao] int  NOT NULL,
    [EscalaoJudo_IdEscalaoJudo] int  NULL
);
GO

-- Creating table 'InscricaoJiujitsuSet'
CREATE TABLE [dbo].[InscricaoJiujitsuSet] (
    [IdInscricaoJiujitsu] int IDENTITY(1,1) NOT NULL,
    [IdInscricao] nvarchar(max)  NOT NULL,
    [LicencaFederativa] nvarchar(max)  NOT NULL,
    [Inscricao_IdInscricao] int  NOT NULL,
    [EscalaoJiujitsu_IdEscalaoJiujitsu] int  NULL
);
GO

-- Creating table 'InscricaoAikidoSet'
CREATE TABLE [dbo].[InscricaoAikidoSet] (
    [IdInscricaoAikido] int IDENTITY(1,1) NOT NULL,
    [IdInscricao] nvarchar(max)  NOT NULL,
    [LicencaFederativa] nvarchar(max)  NOT NULL,
    [Inscricao_IdInscricao] int  NOT NULL,
    [EscalaoAikido_IdEscalaoAikido] int  NULL
);
GO

-- Creating table 'EscalaoJudoSet'
CREATE TABLE [dbo].[EscalaoJudoSet] (
    [IdEscalaoJudo] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EscalaoJiujitsuSet'
CREATE TABLE [dbo].[EscalaoJiujitsuSet] (
    [IdEscalaoJiujitsu] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EscalaoAikidoSet'
CREATE TABLE [dbo].[EscalaoAikidoSet] (
    [IdEscalaoAikido] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TreinadoresSet'
CREATE TABLE [dbo].[TreinadoresSet] (
    [IdTreinador] int IDENTITY(1,1) NOT NULL,
    [IdInscricao] int  NOT NULL,
    [Grau] nvarchar(max)  NOT NULL,
    [Inscricao_IdInscricao] int  NOT NULL
);
GO

-- Creating table 'ArbitroSet'
CREATE TABLE [dbo].[ArbitroSet] (
    [IdArbitro] int IDENTITY(1,1) NOT NULL,
    [IdInscricao] int  NOT NULL,
    [Grau] nvarchar(max)  NOT NULL,
    [Inscricao_IdInscricao] int  NOT NULL
);
GO

-- Creating table 'ExameSet'
CREATE TABLE [dbo].[ExameSet] (
    [IdExame] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Graduacao_IdGraduacao] int  NULL
);
GO

-- Creating table 'GraduacaoSet'
CREATE TABLE [dbo].[GraduacaoSet] (
    [IdGraduacao] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ParticipacaoSet'
CREATE TABLE [dbo].[ParticipacaoSet] (
    [IdParticipacao] int IDENTITY(1,1) NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Nivel_IdNivel] int  NULL
);
GO

-- Creating table 'NivelSet'
CREATE TABLE [dbo].[NivelSet] (
    [IdNivel] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CompeticaoSet'
CREATE TABLE [dbo].[CompeticaoSet] (
    [IdCompeticao] int IDENTITY(1,1) NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Categoria] nvarchar(max)  NOT NULL,
    [Nivel_IdNivel] int  NULL
);
GO

-- Creating table 'ResultadoCompeticaoSet'
CREATE TABLE [dbo].[ResultadoCompeticaoSet] (
    [IdResultadoCompeticao] int IDENTITY(1,1) NOT NULL,
    [IdInscricao] int  NOT NULL,
    [Classificacao] nvarchar(max)  NOT NULL,
    [Pontos] int  NOT NULL,
    [Competicao_IdCompeticao] int  NOT NULL
);
GO

-- Creating table 'InscricaoParticipacao'
CREATE TABLE [dbo].[InscricaoParticipacao] (
    [Inscricao_IdInscricao] int  NOT NULL,
    [Participacao_IdParticipacao] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NumeroSocio] in table 'SociosSet'
ALTER TABLE [dbo].[SociosSet]
ADD CONSTRAINT [PK_SociosSet]
    PRIMARY KEY CLUSTERED ([NumeroSocio] ASC);
GO

-- Creating primary key on [IdInscricao] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [PK_InscricaoSet]
    PRIMARY KEY CLUSTERED ([IdInscricao] ASC);
GO

-- Creating primary key on [NumeroEntidade] in table 'EntidadesSet'
ALTER TABLE [dbo].[EntidadesSet]
ADD CONSTRAINT [PK_EntidadesSet]
    PRIMARY KEY CLUSTERED ([NumeroEntidade] ASC);
GO

-- Creating primary key on [NumeroQuota] in table 'QuotasSet'
ALTER TABLE [dbo].[QuotasSet]
ADD CONSTRAINT [PK_QuotasSet]
    PRIMARY KEY CLUSTERED ([NumeroQuota] ASC);
GO

-- Creating primary key on [IdTipoPagamento] in table 'TipoPagamentoSet'
ALTER TABLE [dbo].[TipoPagamentoSet]
ADD CONSTRAINT [PK_TipoPagamentoSet]
    PRIMARY KEY CLUSTERED ([IdTipoPagamento] ASC);
GO

-- Creating primary key on [IdInscricaoJudo] in table 'InscricaoJudoSet'
ALTER TABLE [dbo].[InscricaoJudoSet]
ADD CONSTRAINT [PK_InscricaoJudoSet]
    PRIMARY KEY CLUSTERED ([IdInscricaoJudo] ASC);
GO

-- Creating primary key on [IdInscricaoJiujitsu] in table 'InscricaoJiujitsuSet'
ALTER TABLE [dbo].[InscricaoJiujitsuSet]
ADD CONSTRAINT [PK_InscricaoJiujitsuSet]
    PRIMARY KEY CLUSTERED ([IdInscricaoJiujitsu] ASC);
GO

-- Creating primary key on [IdInscricaoAikido] in table 'InscricaoAikidoSet'
ALTER TABLE [dbo].[InscricaoAikidoSet]
ADD CONSTRAINT [PK_InscricaoAikidoSet]
    PRIMARY KEY CLUSTERED ([IdInscricaoAikido] ASC);
GO

-- Creating primary key on [IdEscalaoJudo] in table 'EscalaoJudoSet'
ALTER TABLE [dbo].[EscalaoJudoSet]
ADD CONSTRAINT [PK_EscalaoJudoSet]
    PRIMARY KEY CLUSTERED ([IdEscalaoJudo] ASC);
GO

-- Creating primary key on [IdEscalaoJiujitsu] in table 'EscalaoJiujitsuSet'
ALTER TABLE [dbo].[EscalaoJiujitsuSet]
ADD CONSTRAINT [PK_EscalaoJiujitsuSet]
    PRIMARY KEY CLUSTERED ([IdEscalaoJiujitsu] ASC);
GO

-- Creating primary key on [IdEscalaoAikido] in table 'EscalaoAikidoSet'
ALTER TABLE [dbo].[EscalaoAikidoSet]
ADD CONSTRAINT [PK_EscalaoAikidoSet]
    PRIMARY KEY CLUSTERED ([IdEscalaoAikido] ASC);
GO

-- Creating primary key on [IdTreinador] in table 'TreinadoresSet'
ALTER TABLE [dbo].[TreinadoresSet]
ADD CONSTRAINT [PK_TreinadoresSet]
    PRIMARY KEY CLUSTERED ([IdTreinador] ASC);
GO

-- Creating primary key on [IdArbitro] in table 'ArbitroSet'
ALTER TABLE [dbo].[ArbitroSet]
ADD CONSTRAINT [PK_ArbitroSet]
    PRIMARY KEY CLUSTERED ([IdArbitro] ASC);
GO

-- Creating primary key on [IdExame] in table 'ExameSet'
ALTER TABLE [dbo].[ExameSet]
ADD CONSTRAINT [PK_ExameSet]
    PRIMARY KEY CLUSTERED ([IdExame] ASC);
GO

-- Creating primary key on [IdGraduacao] in table 'GraduacaoSet'
ALTER TABLE [dbo].[GraduacaoSet]
ADD CONSTRAINT [PK_GraduacaoSet]
    PRIMARY KEY CLUSTERED ([IdGraduacao] ASC);
GO

-- Creating primary key on [IdParticipacao] in table 'ParticipacaoSet'
ALTER TABLE [dbo].[ParticipacaoSet]
ADD CONSTRAINT [PK_ParticipacaoSet]
    PRIMARY KEY CLUSTERED ([IdParticipacao] ASC);
GO

-- Creating primary key on [IdNivel] in table 'NivelSet'
ALTER TABLE [dbo].[NivelSet]
ADD CONSTRAINT [PK_NivelSet]
    PRIMARY KEY CLUSTERED ([IdNivel] ASC);
GO

-- Creating primary key on [IdCompeticao] in table 'CompeticaoSet'
ALTER TABLE [dbo].[CompeticaoSet]
ADD CONSTRAINT [PK_CompeticaoSet]
    PRIMARY KEY CLUSTERED ([IdCompeticao] ASC);
GO

-- Creating primary key on [IdResultadoCompeticao] in table 'ResultadoCompeticaoSet'
ALTER TABLE [dbo].[ResultadoCompeticaoSet]
ADD CONSTRAINT [PK_ResultadoCompeticaoSet]
    PRIMARY KEY CLUSTERED ([IdResultadoCompeticao] ASC);
GO

-- Creating primary key on [Inscricao_IdInscricao], [Participacao_IdParticipacao] in table 'InscricaoParticipacao'
ALTER TABLE [dbo].[InscricaoParticipacao]
ADD CONSTRAINT [PK_InscricaoParticipacao]
    PRIMARY KEY CLUSTERED ([Inscricao_IdInscricao], [Participacao_IdParticipacao] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Socios_NumeroSocio] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [FK_InscricaoSocios]
    FOREIGN KEY ([Socios_NumeroSocio])
    REFERENCES [dbo].[SociosSet]
        ([NumeroSocio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoSocios'
CREATE INDEX [IX_FK_InscricaoSocios]
ON [dbo].[InscricaoSet]
    ([Socios_NumeroSocio]);
GO

-- Creating foreign key on [Socios_NumeroSocio] in table 'QuotasSet'
ALTER TABLE [dbo].[QuotasSet]
ADD CONSTRAINT [FK_SociosQuotas]
    FOREIGN KEY ([Socios_NumeroSocio])
    REFERENCES [dbo].[SociosSet]
        ([NumeroSocio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SociosQuotas'
CREATE INDEX [IX_FK_SociosQuotas]
ON [dbo].[QuotasSet]
    ([Socios_NumeroSocio]);
GO

-- Creating foreign key on [TipoPagamento_IdTipoPagamento] in table 'QuotasSet'
ALTER TABLE [dbo].[QuotasSet]
ADD CONSTRAINT [FK_QuotasTipoPagamento]
    FOREIGN KEY ([TipoPagamento_IdTipoPagamento])
    REFERENCES [dbo].[TipoPagamentoSet]
        ([IdTipoPagamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_QuotasTipoPagamento'
CREATE INDEX [IX_FK_QuotasTipoPagamento]
ON [dbo].[QuotasSet]
    ([TipoPagamento_IdTipoPagamento]);
GO

-- Creating foreign key on [Entidades_NumeroEntidade] in table 'QuotasSet'
ALTER TABLE [dbo].[QuotasSet]
ADD CONSTRAINT [FK_EntidadesQuotas]
    FOREIGN KEY ([Entidades_NumeroEntidade])
    REFERENCES [dbo].[EntidadesSet]
        ([NumeroEntidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EntidadesQuotas'
CREATE INDEX [IX_FK_EntidadesQuotas]
ON [dbo].[QuotasSet]
    ([Entidades_NumeroEntidade]);
GO

-- Creating foreign key on [Nivel_IdNivel] in table 'ParticipacaoSet'
ALTER TABLE [dbo].[ParticipacaoSet]
ADD CONSTRAINT [FK_ParticipacaoNivel]
    FOREIGN KEY ([Nivel_IdNivel])
    REFERENCES [dbo].[NivelSet]
        ([IdNivel])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParticipacaoNivel'
CREATE INDEX [IX_FK_ParticipacaoNivel]
ON [dbo].[ParticipacaoSet]
    ([Nivel_IdNivel]);
GO

-- Creating foreign key on [Exame_IdExame] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [FK_ExameInscricao]
    FOREIGN KEY ([Exame_IdExame])
    REFERENCES [dbo].[ExameSet]
        ([IdExame])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExameInscricao'
CREATE INDEX [IX_FK_ExameInscricao]
ON [dbo].[InscricaoSet]
    ([Exame_IdExame]);
GO

-- Creating foreign key on [Inscricao_IdInscricao] in table 'ArbitroSet'
ALTER TABLE [dbo].[ArbitroSet]
ADD CONSTRAINT [FK_ArbitroInscricao]
    FOREIGN KEY ([Inscricao_IdInscricao])
    REFERENCES [dbo].[InscricaoSet]
        ([IdInscricao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArbitroInscricao'
CREATE INDEX [IX_FK_ArbitroInscricao]
ON [dbo].[ArbitroSet]
    ([Inscricao_IdInscricao]);
GO

-- Creating foreign key on [Inscricao_IdInscricao] in table 'TreinadoresSet'
ALTER TABLE [dbo].[TreinadoresSet]
ADD CONSTRAINT [FK_TreinadoresInscricao]
    FOREIGN KEY ([Inscricao_IdInscricao])
    REFERENCES [dbo].[InscricaoSet]
        ([IdInscricao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TreinadoresInscricao'
CREATE INDEX [IX_FK_TreinadoresInscricao]
ON [dbo].[TreinadoresSet]
    ([Inscricao_IdInscricao]);
GO

-- Creating foreign key on [Inscricao_IdInscricao] in table 'InscricaoParticipacao'
ALTER TABLE [dbo].[InscricaoParticipacao]
ADD CONSTRAINT [FK_InscricaoParticipacao_Inscricao]
    FOREIGN KEY ([Inscricao_IdInscricao])
    REFERENCES [dbo].[InscricaoSet]
        ([IdInscricao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Participacao_IdParticipacao] in table 'InscricaoParticipacao'
ALTER TABLE [dbo].[InscricaoParticipacao]
ADD CONSTRAINT [FK_InscricaoParticipacao_Participacao]
    FOREIGN KEY ([Participacao_IdParticipacao])
    REFERENCES [dbo].[ParticipacaoSet]
        ([IdParticipacao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoParticipacao_Participacao'
CREATE INDEX [IX_FK_InscricaoParticipacao_Participacao]
ON [dbo].[InscricaoParticipacao]
    ([Participacao_IdParticipacao]);
GO

-- Creating foreign key on [ResultadoCompeticao_IdResultadoCompeticao] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [FK_InscricaoResultadoCompeticao]
    FOREIGN KEY ([ResultadoCompeticao_IdResultadoCompeticao])
    REFERENCES [dbo].[ResultadoCompeticaoSet]
        ([IdResultadoCompeticao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoResultadoCompeticao'
CREATE INDEX [IX_FK_InscricaoResultadoCompeticao]
ON [dbo].[InscricaoSet]
    ([ResultadoCompeticao_IdResultadoCompeticao]);
GO

-- Creating foreign key on [Competicao_IdCompeticao] in table 'ResultadoCompeticaoSet'
ALTER TABLE [dbo].[ResultadoCompeticaoSet]
ADD CONSTRAINT [FK_ResultadoCompeticaoCompeticao]
    FOREIGN KEY ([Competicao_IdCompeticao])
    REFERENCES [dbo].[CompeticaoSet]
        ([IdCompeticao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ResultadoCompeticaoCompeticao'
CREATE INDEX [IX_FK_ResultadoCompeticaoCompeticao]
ON [dbo].[ResultadoCompeticaoSet]
    ([Competicao_IdCompeticao]);
GO

-- Creating foreign key on [Nivel_IdNivel] in table 'CompeticaoSet'
ALTER TABLE [dbo].[CompeticaoSet]
ADD CONSTRAINT [FK_NivelCompeticao]
    FOREIGN KEY ([Nivel_IdNivel])
    REFERENCES [dbo].[NivelSet]
        ([IdNivel])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NivelCompeticao'
CREATE INDEX [IX_FK_NivelCompeticao]
ON [dbo].[CompeticaoSet]
    ([Nivel_IdNivel]);
GO

-- Creating foreign key on [Inscricao_IdInscricao] in table 'InscricaoJudoSet'
ALTER TABLE [dbo].[InscricaoJudoSet]
ADD CONSTRAINT [FK_InscricaoInscricaoJudo]
    FOREIGN KEY ([Inscricao_IdInscricao])
    REFERENCES [dbo].[InscricaoSet]
        ([IdInscricao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoInscricaoJudo'
CREATE INDEX [IX_FK_InscricaoInscricaoJudo]
ON [dbo].[InscricaoJudoSet]
    ([Inscricao_IdInscricao]);
GO

-- Creating foreign key on [Inscricao_IdInscricao] in table 'InscricaoJiujitsuSet'
ALTER TABLE [dbo].[InscricaoJiujitsuSet]
ADD CONSTRAINT [FK_InscricaoInscricaoJiujitsu]
    FOREIGN KEY ([Inscricao_IdInscricao])
    REFERENCES [dbo].[InscricaoSet]
        ([IdInscricao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoInscricaoJiujitsu'
CREATE INDEX [IX_FK_InscricaoInscricaoJiujitsu]
ON [dbo].[InscricaoJiujitsuSet]
    ([Inscricao_IdInscricao]);
GO

-- Creating foreign key on [Inscricao_IdInscricao] in table 'InscricaoAikidoSet'
ALTER TABLE [dbo].[InscricaoAikidoSet]
ADD CONSTRAINT [FK_InscricaoInscricaoAikido]
    FOREIGN KEY ([Inscricao_IdInscricao])
    REFERENCES [dbo].[InscricaoSet]
        ([IdInscricao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoInscricaoAikido'
CREATE INDEX [IX_FK_InscricaoInscricaoAikido]
ON [dbo].[InscricaoAikidoSet]
    ([Inscricao_IdInscricao]);
GO

-- Creating foreign key on [EscalaoJudo_IdEscalaoJudo] in table 'InscricaoJudoSet'
ALTER TABLE [dbo].[InscricaoJudoSet]
ADD CONSTRAINT [FK_InscricaoJudoEscalaoJudo]
    FOREIGN KEY ([EscalaoJudo_IdEscalaoJudo])
    REFERENCES [dbo].[EscalaoJudoSet]
        ([IdEscalaoJudo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoJudoEscalaoJudo'
CREATE INDEX [IX_FK_InscricaoJudoEscalaoJudo]
ON [dbo].[InscricaoJudoSet]
    ([EscalaoJudo_IdEscalaoJudo]);
GO

-- Creating foreign key on [EscalaoJiujitsu_IdEscalaoJiujitsu] in table 'InscricaoJiujitsuSet'
ALTER TABLE [dbo].[InscricaoJiujitsuSet]
ADD CONSTRAINT [FK_InscricaoJiujitsuEscalaoJiujitsu]
    FOREIGN KEY ([EscalaoJiujitsu_IdEscalaoJiujitsu])
    REFERENCES [dbo].[EscalaoJiujitsuSet]
        ([IdEscalaoJiujitsu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoJiujitsuEscalaoJiujitsu'
CREATE INDEX [IX_FK_InscricaoJiujitsuEscalaoJiujitsu]
ON [dbo].[InscricaoJiujitsuSet]
    ([EscalaoJiujitsu_IdEscalaoJiujitsu]);
GO

-- Creating foreign key on [EscalaoAikido_IdEscalaoAikido] in table 'InscricaoAikidoSet'
ALTER TABLE [dbo].[InscricaoAikidoSet]
ADD CONSTRAINT [FK_InscricaoAikidoEscalaoAikido]
    FOREIGN KEY ([EscalaoAikido_IdEscalaoAikido])
    REFERENCES [dbo].[EscalaoAikidoSet]
        ([IdEscalaoAikido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoAikidoEscalaoAikido'
CREATE INDEX [IX_FK_InscricaoAikidoEscalaoAikido]
ON [dbo].[InscricaoAikidoSet]
    ([EscalaoAikido_IdEscalaoAikido]);
GO

-- Creating foreign key on [Graduacao_IdGraduacao] in table 'ExameSet'
ALTER TABLE [dbo].[ExameSet]
ADD CONSTRAINT [FK_ExameGraduacao]
    FOREIGN KEY ([Graduacao_IdGraduacao])
    REFERENCES [dbo].[GraduacaoSet]
        ([IdGraduacao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExameGraduacao'
CREATE INDEX [IX_FK_ExameGraduacao]
ON [dbo].[ExameSet]
    ([Graduacao_IdGraduacao]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------