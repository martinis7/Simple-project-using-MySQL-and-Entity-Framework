
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/07/2016 09:09:57
-- Generated from EDMX file: C:\Users\Martynas\Documents\Visual Studio 2015\Projects\SqlProject\SqlProject\RouteModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Public transport ];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bus];
GO
IF OBJECT_ID(N'[dbo].[Route]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Route];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Buses'
CREATE TABLE [dbo].[Buses] (
    [Bus_Id] int  NOT NULL,
    [Make] nchar(20)  NULL,
    [Model] nchar(20)  NULL,
    [Capacity] int  NULL,
    [Route] int  NULL,
    [Route1_Route_Id] int  NOT NULL
);
GO

-- Creating table 'Routes'
CREATE TABLE [dbo].[Routes] (
    [Route_Id] int  NOT NULL,
    [Start_stop] int  NULL,
    [End_stop] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Bus_Id] in table 'Buses'
ALTER TABLE [dbo].[Buses]
ADD CONSTRAINT [PK_Buses]
    PRIMARY KEY CLUSTERED ([Bus_Id] ASC);
GO

-- Creating primary key on [Route_Id] in table 'Routes'
ALTER TABLE [dbo].[Routes]
ADD CONSTRAINT [PK_Routes]
    PRIMARY KEY CLUSTERED ([Route_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Route1_Route_Id] in table 'Buses'
ALTER TABLE [dbo].[Buses]
ADD CONSTRAINT [FK_BusRoute]
    FOREIGN KEY ([Route1_Route_Id])
    REFERENCES [dbo].[Routes]
        ([Route_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BusRoute'
CREATE INDEX [IX_FK_BusRoute]
ON [dbo].[Buses]
    ([Route1_Route_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------