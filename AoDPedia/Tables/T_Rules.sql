﻿CREATE TABLE [dbo].[T_Rules]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
    [Rule_Type] UNIQUEIDENTIFIER NULL, 
    [Parent_Id] UNIQUEIDENTIFIER NULL, 
    [Name] NVARCHAR(50) NULL, 
    [Text] NVARCHAR(MAX) NULL, 
    [Fluff] NVARCHAR(MAX) NULL, 
    [Source_Id] UNIQUEIDENTIFIER NULL, 
    [Source_Page] INT NULL,
    [Row_Id] INT IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_T_Rules_Id] PRIMARY KEY NONCLUSTERED ([Id])
)

GO

CREATE UNIQUE INDEX [CIX_T_Rules_Column] ON [dbo].[T_Rules] ([ROW_ID])
