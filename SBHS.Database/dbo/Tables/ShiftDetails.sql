CREATE TABLE [dbo].[ShiftDetails] (
    [Id]           INT  NOT NULL IDENTITY,
    [UserDetailId] INT  NOT NULL,
    [ShiftTypeId]  INT  NOT NULL,
    [Date]         DATE NULL,
    CONSTRAINT [PK_ShiftDetails] PRIMARY KEY CLUSTERED ([Id] ASC)
);

