CREATE TABLE [dbo].[T_Source]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
    [Row_Id] INT IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(MAX) NULL, 
    [Abbreviation] NCHAR(10) NULL, 
    CONSTRAINT [PK_T_Source_Id] PRIMARY KEY NONCLUSTERED ([Id])
    
)

GO

CREATE UNIQUE INDEX [CIX_T_Source_Column] ON [dbo].[T_Source] ([ROW_ID])
