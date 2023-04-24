CREATE TABLE [dbo].[T_Rule_Category]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
    [Parent_Id] UNIQUEIDENTIFIER NULL, 
    [Name] NVARCHAR(50) NULL,
    [Row_Id] INT IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_T_Rule_Category_Id] PRIMARY KEY NONCLUSTERED ([Id])
)

GO

CREATE UNIQUE INDEX [CIX_T_Rule_Category_Column] ON [dbo].[T_Rule_Category] ([ROW_ID])
