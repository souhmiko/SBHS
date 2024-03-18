CREATE TABLE [dbo].[UserDetails] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [AspNetUserId] NVARCHAR (450) NOT NULL,
    [DepartmentId] INT            NOT NULL,
    [WorkTitleId]  INT            NOT NULL,
    [FullName]     NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UserDetails_AspNetUsers] FOREIGN KEY ([AspNetUserId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    CONSTRAINT [FK_UserDetails_Departments] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Departments] ([Id]),
    CONSTRAINT [FK_UserDetails_WorkTitles] FOREIGN KEY ([WorkTitleId]) REFERENCES [dbo].[WorkTitles] ([Id])
);



