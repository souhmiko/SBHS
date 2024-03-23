CREATE TABLE [dbo].[ShiftTypes] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [ShiftTypeName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_ShiftTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);





