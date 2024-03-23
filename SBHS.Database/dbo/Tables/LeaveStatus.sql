CREATE TABLE [dbo].[LeaveStatus] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [LeaveStatusName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_LeaveStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);





