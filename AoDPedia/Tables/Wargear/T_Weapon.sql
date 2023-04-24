CREATE TABLE [dbo].[T_Weapon]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
    [Name] NCHAR(10) NULL, 
    [Range] NCHAR(10) NULL, 
    [Strength] NCHAR(10) NULL, 
    [AP] NCHAR(10) NULL, 
    [Type] NCHAR(10) NULL, 
    [Army_Id] UNIQUEIDENTIFIER NULL, 
    [Source_Id] UNIQUEIDENTIFIER NULL, 
    [Source_Page] INT NULL,    
    [Row_Id] INT IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_T_Weapon_Id] PRIMARY KEY NONCLUSTERED ([Id])
)

GO

CREATE UNIQUE INDEX [CIX_T_Weapon_Column] ON [dbo].[T_Weapon] ([ROW_ID])
