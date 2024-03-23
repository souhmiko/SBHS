CREATE TABLE [dbo].[LeaveTypes] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [LeaveTypeName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_LeaveTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);





