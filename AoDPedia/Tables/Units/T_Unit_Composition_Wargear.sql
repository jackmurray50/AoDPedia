CREATE TABLE [dbo].[T_Unit_Composition_Wargear]
(
	[Id] INT NOT NULL, 
    [Unit_Id] UNIQUEIDENTIFIER NULL, 
    [Wargear_Id] UNIQUEIDENTIFIER NULL, 
    [Count] INT NULL,
    [Row_Id] INT IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_T_Unit_Composition_Wargear_Id] PRIMARY KEY NONCLUSTERED ([Id])
)

GO

CREATE UNIQUE INDEX [CIX_T_Unit_Composition_Wargear_Column] ON [dbo].[T_Unit_Composition_Wargear] ([ROW_ID])