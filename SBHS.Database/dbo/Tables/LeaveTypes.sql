CREATE TABLE [dbo].[LeaveTypes] (
    [Id]            INT            NOT NULL IDENTITY,
    [LeaveTypeName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_LeaveTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

