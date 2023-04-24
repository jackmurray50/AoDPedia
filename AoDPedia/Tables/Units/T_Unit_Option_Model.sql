CREATE TABLE [dbo].[T_Unit_Option_Model]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
    [Model_Id] UNIQUEIDENTIFIER NULL, 
    [Cost] INT NULL, 
    [Limit] INT NULL, 
    [IsDedicatedTransport] BIT NULL, 
    [MaxSquadSize] INT NULL,
    [Row_Id] INT IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_T_Unit_Option_Model_Id] PRIMARY KEY NONCLUSTERED ([Id])
)
GO

CREATE UNIQUE INDEX [CIX_T_Unit_Option_Model_Column] ON [dbo].[T_Unit_Option_Model] ([ROW_ID])
