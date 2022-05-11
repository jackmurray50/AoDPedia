﻿CREATE TABLE [dbo].[T_Warlord_Traits]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NULL, 
    [Fluff] NVARCHAR(MAX) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Army_Id] UNIQUEIDENTIFIER NULL
)
