CREATE TABLE [dbo].[LeaveStatus] (
    [Id]              INT            NOT NULL,
    [LeaveStatusName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_LeaveStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);



