CREATE TABLE [dbo].[ShiftTypes] (
    [Id]            INT            NOT NULL IDENTITY,
    [ShiftTypeName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_ShiftTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

