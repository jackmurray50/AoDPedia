﻿CREATE TABLE [dbo].[T_Rule_Category]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Parent_Id] UNIQUEIDENTIFIER NULL, 
    [Name] NVARCHAR(50) NULL
)
