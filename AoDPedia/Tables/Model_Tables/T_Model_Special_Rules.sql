﻿CREATE TABLE [dbo].[T_Special_Rules]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(MAX) NULL, 
    [Fluff] VARCHAR(MAX) NULL, 
    [Rules] VARCHAR(MAX) NULL
)
