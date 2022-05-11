CREATE TABLE [dbo].[T_Unit_Option_Wargear]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Unit_Id] UNIQUEIDENTIFIER NULL, 
    [Wargear_Id] UNIQUEIDENTIFIER NULL, 
    [Models_Per_Wargear] INT NULL, 
    [IsExchange] BIT NULL, 
    [Cost] INT NULL
)
