CREATE TABLE [dbo].[T_Model]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    [Source] UNIQUEIDENTIFIER NULL, 
    [Source_Page] INT NULL, 
    [Movement] NCHAR(10) NULL, 
    [Weapon_Skill] NCHAR(10) NULL, 
    [Ballistic_Skill] NCHAR(10) NULL, 
    [Strength] NCHAR(10) NULL, 
    [Toughness] NCHAR(10) NULL, 
    [AV_Front] NCHAR(10) NULL, 
    [AV_Side] NCHAR(10) NULL, 
    [AV_Rear] NCHAR(10) NULL, 
    [Wounds] NTEXT NULL, 
    [HullPoints] NTEXT NULL, 
    [Initiative] NCHAR(10) NULL, 
    [Attacks] NCHAR(10) NULL, 
    [Leadership] NCHAR(10) NULL, 
    [Save] NCHAR(10) NULL 
)
