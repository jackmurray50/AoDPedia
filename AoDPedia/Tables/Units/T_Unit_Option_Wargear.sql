CREATE TABLE [dbo].[T_Unit_Option_Wargear]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
    [Unit_Id] UNIQUEIDENTIFIER NULL, 
    [Wargear_Id] UNIQUEIDENTIFIER NULL, 
    [Models_Per_Wargear] INT NULL, 
    [IsExchange] BIT NULL, 
    [Cost] INT NULL,
    [Row_Id] INT IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_T_Unit_Option_Wargear_Id] PRIMARY KEY NONCLUSTERED ([Id])
)

GO

CREATE UNIQUE INDEX [CIX_T_Unit_Option_Wargear_Column] ON [dbo].[T_Unit_Option_Wargear] ([ROW_ID])
