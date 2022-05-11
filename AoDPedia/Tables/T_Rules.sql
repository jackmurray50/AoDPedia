﻿CREATE TABLE [dbo].[T_Rules]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Rule_Type] UNIQUEIDENTIFIER NULL, 
    [Parent_Id] UNIQUEIDENTIFIER NULL, 
    [Name] NVARCHAR(50) NULL, 
    [Text] NVARCHAR(MAX) NULL, 
    [Fluff] NVARCHAR(MAX) NULL, 
    [Source_Id] UNIQUEIDENTIFIER NULL, 
    [Source_Page] INT NULL
)
