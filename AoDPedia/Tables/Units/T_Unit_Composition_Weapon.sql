CREATE TABLE [dbo].[T_Unit_Composition_Weapon]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Unit_Id] UNIQUEIDENTIFIER NULL, 
    [Weapon_Id] UNIQUEIDENTIFIER NULL, 
    [Count] INT NULL
)
