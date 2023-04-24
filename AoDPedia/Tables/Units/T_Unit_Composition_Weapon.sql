CREATE TABLE [dbo].[T_Unit_Composition_Weapon]
(
	[Id] INT NOT NULL,
	[Unit_Id] UNIQUEIDENTIFIER NULL, 
    [Weapon_Id] UNIQUEIDENTIFIER NULL, 
    [Count] INT NULL,
	[Row_Id] INT IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_T_Unit_Composition_Weapon_Id] PRIMARY KEY NONCLUSTERED ([Id])
)
GO

CREATE UNIQUE INDEX [CIX_T_Unit_Composition_Weapon_Column] ON [dbo].[T_Unit_Composition_Weapon] ([ROW_ID])

