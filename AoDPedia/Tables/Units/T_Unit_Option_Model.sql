CREATE TABLE [dbo].[T_Unit_Option_Model]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Model_Id] UNIQUEIDENTIFIER NULL, 
    [Cost] INT NULL, 
    [Limit] INT NULL, 
    [IsDedicatedTransport] BIT NULL, 
    [MaxSquadSize] INT NULL 
)
