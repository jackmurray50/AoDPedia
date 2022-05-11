﻿CREATE TABLE [dbo].[T_Weapon]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    [Range] NCHAR(10) NULL, 
    [Strength] NCHAR(10) NULL, 
    [AP] NCHAR(10) NULL, 
    [Type] NCHAR(10) NULL, 
    [Army_Id] UNIQUEIDENTIFIER NULL, 
    [Source_Id] UNIQUEIDENTIFIER NULL, 
    [Source_Page] INT NULL
)
