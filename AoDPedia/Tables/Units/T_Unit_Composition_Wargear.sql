CREATE TABLE [dbo].[T_Unit_Composition_Wargear]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Unit_Id] UNIQUEIDENTIFIER NULL, 
    [Wargear_Id] UNIQUEIDENTIFIER NULL, 
    [Count] INT NULL
)
