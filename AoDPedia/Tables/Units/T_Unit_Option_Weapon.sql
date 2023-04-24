CREATE TABLE [dbo].[T_Unit_Option_Weapon]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
    [Unit_Id] UNIQUEIDENTIFIER NULL, 
    [Weapon_Id] UNIQUEIDENTIFIER NULL, 
    [Models_Per_Weapon] INT NULL, 
    [IsExchange] BIT NULL, 
    [Cost] INT NULL,
    [Row_Id] INT IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_T_Unit_Option_Weapon_Id] PRIMARY KEY NONCLUSTERED ([Id])
)

GO

CREATE UNIQUE INDEX [CIX_T_Unit_Option_Weapon_Column] ON [dbo].[T_Unit_Option_Weapon] ([ROW_ID])