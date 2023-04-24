CREATE TABLE [dbo].[T_Unit_Composition_Models]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
    [Unit_Id] UNIQUEIDENTIFIER NULL, 
    [Model_Id] UNIQUEIDENTIFIER NULL, 
    [Count] INT NULL,
    [Row_Id] INT IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_T_Unit_Composition_Models_Id] PRIMARY KEY NONCLUSTERED ([Id])
)

GO

CREATE UNIQUE INDEX [CIX_T_Unit_Composition_Models_Column] ON [dbo].[T_Unit_Composition_Models] ([ROW_ID])
