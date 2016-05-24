
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/24/2016 18:03:00
-- Generated from EDMX file: C:\Users\Zé-PC\Desktop\EinsteinHospitalAplication\WebService\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EinsteinHospitalBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ExameRececionista]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExameSet] DROP CONSTRAINT [FK_ExameRececionista];
GO
IF OBJECT_ID(N'[dbo].[FK_ExameUtente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExameSet] DROP CONSTRAINT [FK_ExameUtente];
GO
IF OBJECT_ID(N'[dbo].[FK_ExameMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExameSet] DROP CONSTRAINT [FK_ExameMedico];
GO
IF OBJECT_ID(N'[dbo].[FK_UtenteConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_UtenteConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_MedicoConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaMedicacao_Consulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaMedicacao] DROP CONSTRAINT [FK_ConsultaMedicacao_Consulta];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaMedicacao_Medicacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaMedicacao] DROP CONSTRAINT [FK_ConsultaMedicacao_Medicacao];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaSintomas_Consulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSintomas] DROP CONSTRAINT [FK_ConsultaSintomas_Consulta];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaSintomas_Sintomas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSintomas] DROP CONSTRAINT [FK_ConsultaSintomas_Sintomas];
GO
IF OBJECT_ID(N'[dbo].[FK_Rececionista_inherits_Utilizador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UtilizadorSet_Rececionista] DROP CONSTRAINT [FK_Rececionista_inherits_Utilizador];
GO
IF OBJECT_ID(N'[dbo].[FK_Medico_inherits_Utilizador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UtilizadorSet_Medico] DROP CONSTRAINT [FK_Medico_inherits_Utilizador];
GO
IF OBJECT_ID(N'[dbo].[FK_Enfermeiro_inherits_Utilizador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UtilizadorSet_Enfermeiro] DROP CONSTRAINT [FK_Enfermeiro_inherits_Utilizador];
GO
IF OBJECT_ID(N'[dbo].[FK_Administrador_inherits_Utilizador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UtilizadorSet_Administrador] DROP CONSTRAINT [FK_Administrador_inherits_Utilizador];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UtilizadorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtilizadorSet];
GO
IF OBJECT_ID(N'[dbo].[ExameSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExameSet];
GO
IF OBJECT_ID(N'[dbo].[UtenteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtenteSet];
GO
IF OBJECT_ID(N'[dbo].[ConsultaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultaSet];
GO
IF OBJECT_ID(N'[dbo].[MedicacaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedicacaoSet];
GO
IF OBJECT_ID(N'[dbo].[SintomasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SintomasSet];
GO
IF OBJECT_ID(N'[dbo].[UtilizadorSet_Rececionista]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtilizadorSet_Rececionista];
GO
IF OBJECT_ID(N'[dbo].[UtilizadorSet_Medico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtilizadorSet_Medico];
GO
IF OBJECT_ID(N'[dbo].[UtilizadorSet_Enfermeiro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtilizadorSet_Enfermeiro];
GO
IF OBJECT_ID(N'[dbo].[UtilizadorSet_Administrador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtilizadorSet_Administrador];
GO
IF OBJECT_ID(N'[dbo].[ConsultaMedicacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultaMedicacao];
GO
IF OBJECT_ID(N'[dbo].[ConsultaSintomas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultaSintomas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UtilizadorSet'
CREATE TABLE [dbo].[UtilizadorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [tipoUtilizador] nvarchar(max)  NOT NULL,
    [suspensao] bit  NOT NULL
);
GO

-- Creating table 'ExameSet'
CREATE TABLE [dbo].[ExameSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [especialidade] nvarchar(max)  NOT NULL,
    [preco] nvarchar(max)  NOT NULL,
    [data] datetime  NOT NULL,
    [Rececionista_Id] int  NOT NULL,
    [Utente_Id] int  NOT NULL,
    [Medico_Id] int  NOT NULL
);
GO

-- Creating table 'UtenteSet'
CREATE TABLE [dbo].[UtenteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [primeiroNome] nvarchar(max)  NOT NULL,
    [apelido] nvarchar(max)  NOT NULL,
    [dataNascimento] datetime  NOT NULL,
    [morada] nvarchar(max)  NOT NULL,
    [codigoPostal] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [sexo] nvarchar(max)  NOT NULL,
    [contacto] nvarchar(max)  NOT NULL,
    [peso] nvarchar(max)  NULL,
    [altura] nvarchar(max)  NULL,
    [glicemia] nvarchar(max)  NULL,
    [tensao] nvarchar(max)  NULL,
    [colestrol] nvarchar(max)  NULL,
    [saturacao] nvarchar(max)  NULL,
    [batimentoCardiaco] nvarchar(max)  NULL
);
GO

-- Creating table 'ConsultaSet'
CREATE TABLE [dbo].[ConsultaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [data] datetime  NOT NULL,
    [diagnostico] nvarchar(max)  NOT NULL,
    [Utente_Id] int  NOT NULL,
    [Medico_Id] int  NOT NULL
);
GO

-- Creating table 'MedicacaoSet'
CREATE TABLE [dbo].[MedicacaoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nomeMedicacao] nvarchar(max)  NOT NULL,
    [administracao] nvarchar(max)  NOT NULL,
    [preco] nvarchar(max)  NOT NULL,
    [data] datetime  NOT NULL,
    [dosagem] nvarchar(max)  NOT NULL,
    [comparticao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SintomasSet'
CREATE TABLE [dbo].[SintomasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UtilizadorSet_Rececionista'
CREATE TABLE [dbo].[UtilizadorSet_Rececionista] (
    [nome] nvarchar(max)  NOT NULL,
    [nInterno] int  NOT NULL,
    [morada] nvarchar(max)  NOT NULL,
    [dataNascimento] datetime  NOT NULL,
    [cargo] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'UtilizadorSet_Medico'
CREATE TABLE [dbo].[UtilizadorSet_Medico] (
    [nome] nvarchar(max)  NOT NULL,
    [nInterno] int  NOT NULL,
    [morada] nvarchar(max)  NOT NULL,
    [dataNascimento] datetime  NOT NULL,
    [cargo] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'UtilizadorSet_Enfermeiro'
CREATE TABLE [dbo].[UtilizadorSet_Enfermeiro] (
    [nome] nvarchar(max)  NOT NULL,
    [nInterno] int  NOT NULL,
    [morada] nvarchar(max)  NOT NULL,
    [dataNascimento] datetime  NOT NULL,
    [cargo] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'UtilizadorSet_Administrador'
CREATE TABLE [dbo].[UtilizadorSet_Administrador] (
    [nome] nvarchar(max)  NOT NULL,
    [nInterno] int  NOT NULL,
    [morada] nvarchar(max)  NOT NULL,
    [dataNascimento] datetime  NOT NULL,
    [cargo] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'ConsultaMedicacao'
CREATE TABLE [dbo].[ConsultaMedicacao] (
    [Consulta_Id] int  NOT NULL,
    [Medicacao_Id] int  NOT NULL
);
GO

-- Creating table 'ConsultaSintomas'
CREATE TABLE [dbo].[ConsultaSintomas] (
    [Consulta_Id] int  NOT NULL,
    [Sintomas_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UtilizadorSet'
ALTER TABLE [dbo].[UtilizadorSet]
ADD CONSTRAINT [PK_UtilizadorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExameSet'
ALTER TABLE [dbo].[ExameSet]
ADD CONSTRAINT [PK_ExameSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtenteSet'
ALTER TABLE [dbo].[UtenteSet]
ADD CONSTRAINT [PK_UtenteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [PK_ConsultaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedicacaoSet'
ALTER TABLE [dbo].[MedicacaoSet]
ADD CONSTRAINT [PK_MedicacaoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SintomasSet'
ALTER TABLE [dbo].[SintomasSet]
ADD CONSTRAINT [PK_SintomasSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtilizadorSet_Rececionista'
ALTER TABLE [dbo].[UtilizadorSet_Rececionista]
ADD CONSTRAINT [PK_UtilizadorSet_Rececionista]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtilizadorSet_Medico'
ALTER TABLE [dbo].[UtilizadorSet_Medico]
ADD CONSTRAINT [PK_UtilizadorSet_Medico]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtilizadorSet_Enfermeiro'
ALTER TABLE [dbo].[UtilizadorSet_Enfermeiro]
ADD CONSTRAINT [PK_UtilizadorSet_Enfermeiro]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtilizadorSet_Administrador'
ALTER TABLE [dbo].[UtilizadorSet_Administrador]
ADD CONSTRAINT [PK_UtilizadorSet_Administrador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Consulta_Id], [Medicacao_Id] in table 'ConsultaMedicacao'
ALTER TABLE [dbo].[ConsultaMedicacao]
ADD CONSTRAINT [PK_ConsultaMedicacao]
    PRIMARY KEY CLUSTERED ([Consulta_Id], [Medicacao_Id] ASC);
GO

-- Creating primary key on [Consulta_Id], [Sintomas_Id] in table 'ConsultaSintomas'
ALTER TABLE [dbo].[ConsultaSintomas]
ADD CONSTRAINT [PK_ConsultaSintomas]
    PRIMARY KEY CLUSTERED ([Consulta_Id], [Sintomas_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Rececionista_Id] in table 'ExameSet'
ALTER TABLE [dbo].[ExameSet]
ADD CONSTRAINT [FK_ExameRececionista]
    FOREIGN KEY ([Rececionista_Id])
    REFERENCES [dbo].[UtilizadorSet_Rececionista]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExameRececionista'
CREATE INDEX [IX_FK_ExameRececionista]
ON [dbo].[ExameSet]
    ([Rececionista_Id]);
GO

-- Creating foreign key on [Utente_Id] in table 'ExameSet'
ALTER TABLE [dbo].[ExameSet]
ADD CONSTRAINT [FK_ExameUtente]
    FOREIGN KEY ([Utente_Id])
    REFERENCES [dbo].[UtenteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExameUtente'
CREATE INDEX [IX_FK_ExameUtente]
ON [dbo].[ExameSet]
    ([Utente_Id]);
GO

-- Creating foreign key on [Medico_Id] in table 'ExameSet'
ALTER TABLE [dbo].[ExameSet]
ADD CONSTRAINT [FK_ExameMedico]
    FOREIGN KEY ([Medico_Id])
    REFERENCES [dbo].[UtilizadorSet_Medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExameMedico'
CREATE INDEX [IX_FK_ExameMedico]
ON [dbo].[ExameSet]
    ([Medico_Id]);
GO

-- Creating foreign key on [Utente_Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_UtenteConsulta]
    FOREIGN KEY ([Utente_Id])
    REFERENCES [dbo].[UtenteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UtenteConsulta'
CREATE INDEX [IX_FK_UtenteConsulta]
ON [dbo].[ConsultaSet]
    ([Utente_Id]);
GO

-- Creating foreign key on [Medico_Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_MedicoConsulta]
    FOREIGN KEY ([Medico_Id])
    REFERENCES [dbo].[UtilizadorSet_Medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoConsulta'
CREATE INDEX [IX_FK_MedicoConsulta]
ON [dbo].[ConsultaSet]
    ([Medico_Id]);
GO

-- Creating foreign key on [Consulta_Id] in table 'ConsultaMedicacao'
ALTER TABLE [dbo].[ConsultaMedicacao]
ADD CONSTRAINT [FK_ConsultaMedicacao_Consulta]
    FOREIGN KEY ([Consulta_Id])
    REFERENCES [dbo].[ConsultaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Medicacao_Id] in table 'ConsultaMedicacao'
ALTER TABLE [dbo].[ConsultaMedicacao]
ADD CONSTRAINT [FK_ConsultaMedicacao_Medicacao]
    FOREIGN KEY ([Medicacao_Id])
    REFERENCES [dbo].[MedicacaoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaMedicacao_Medicacao'
CREATE INDEX [IX_FK_ConsultaMedicacao_Medicacao]
ON [dbo].[ConsultaMedicacao]
    ([Medicacao_Id]);
GO

-- Creating foreign key on [Consulta_Id] in table 'ConsultaSintomas'
ALTER TABLE [dbo].[ConsultaSintomas]
ADD CONSTRAINT [FK_ConsultaSintomas_Consulta]
    FOREIGN KEY ([Consulta_Id])
    REFERENCES [dbo].[ConsultaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Sintomas_Id] in table 'ConsultaSintomas'
ALTER TABLE [dbo].[ConsultaSintomas]
ADD CONSTRAINT [FK_ConsultaSintomas_Sintomas]
    FOREIGN KEY ([Sintomas_Id])
    REFERENCES [dbo].[SintomasSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaSintomas_Sintomas'
CREATE INDEX [IX_FK_ConsultaSintomas_Sintomas]
ON [dbo].[ConsultaSintomas]
    ([Sintomas_Id]);
GO

-- Creating foreign key on [Id] in table 'UtilizadorSet_Rececionista'
ALTER TABLE [dbo].[UtilizadorSet_Rececionista]
ADD CONSTRAINT [FK_Rececionista_inherits_Utilizador]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UtilizadorSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'UtilizadorSet_Medico'
ALTER TABLE [dbo].[UtilizadorSet_Medico]
ADD CONSTRAINT [FK_Medico_inherits_Utilizador]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UtilizadorSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'UtilizadorSet_Enfermeiro'
ALTER TABLE [dbo].[UtilizadorSet_Enfermeiro]
ADD CONSTRAINT [FK_Enfermeiro_inherits_Utilizador]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UtilizadorSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'UtilizadorSet_Administrador'
ALTER TABLE [dbo].[UtilizadorSet_Administrador]
ADD CONSTRAINT [FK_Administrador_inherits_Utilizador]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UtilizadorSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------