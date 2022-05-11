CREATE TABLE [dbo].[T_Unit_Option_Weapon]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Unit_Id] UNIQUEIDENTIFIER NULL, 
    [Weapon_Id] UNIQUEIDENTIFIER NULL, 
    [Models_Per_Weapon] INT NULL, 
    [IsExchange] BIT NULL, 
    [Cost] INT NULL
)
