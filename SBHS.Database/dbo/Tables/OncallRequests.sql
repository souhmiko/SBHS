CREATE TABLE [dbo].[OncallRequests] (
    [Id]                     INT            NOT NULL IDENTITY,
    [UserDetailId]           INT            NOT NULL,
    [DepartmentId]           INT            NOT NULL,
    [DateTimeOnCall]         DATETIME       NULL,
    [ApprovedByUserDetailId] NVARCHAR (450) NULL,
    [DateApproved]           DATETIME       NULL,
    [RejectedByUserDetailId] NVARCHAR (450) NULL,
    [DateRejected]           DATETIME       NULL,
    [LeaveStatusId]          INT            NOT NULL,
    CONSTRAINT [PK_OncallRequests] PRIMARY KEY CLUSTERED ([Id] ASC)
);

