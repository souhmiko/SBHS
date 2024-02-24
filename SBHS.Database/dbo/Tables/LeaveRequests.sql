CREATE TABLE [dbo].[LeaveRequests] (
    [Id]                     INT             NOT NULL IDENTITY,
    [UserDetailId]           INT             NOT NULL,
    [LeaveTypeId]            INT             NOT NULL,
    [StartDate]              DATE            NULL,
    [EndDate]                DATE            NULL,
    [LeaveStatusId]          INT             NOT NULL,
    [Reason]                 NVARCHAR (MAX)  NULL,
    [Days]                   DECIMAL (18, 2) NULL,
    [UploadDocument]         VARBINARY (MAX) NULL,
    [ApprovedByUserDetailId] NVARCHAR (450)  NULL,
    [DateApproved]           DATETIME        NULL,
    [RejectedByUserDetailId] NVARCHAR (450)  NULL,
    [DateRejected]           DATETIME        NULL,
    CONSTRAINT [PK_LeaveRequests] PRIMARY KEY CLUSTERED ([Id] ASC)
);

