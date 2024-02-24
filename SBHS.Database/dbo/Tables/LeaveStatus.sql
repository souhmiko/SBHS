CREATE TABLE [dbo].[LeaveStatus] (
    [Id]              INT            NOT NULL IDENTITY,
    [LeaveStatusName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_LeaveStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);

