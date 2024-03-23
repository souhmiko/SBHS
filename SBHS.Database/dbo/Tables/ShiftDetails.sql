﻿CREATE TABLE [dbo].[ShiftDetails] (
    [Id]           INT  IDENTITY (1, 1) NOT NULL,
    [UserDetailId] INT  NOT NULL,
    [ShiftTypeId]  INT  NOT NULL,
    [Date]         DATE NULL,
    CONSTRAINT [PK_ShiftDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ShiftDetails_ShiftTypes] FOREIGN KEY ([ShiftTypeId]) REFERENCES [dbo].[ShiftTypes] ([Id]),
    CONSTRAINT [FK_ShiftDetails_UserDetails] FOREIGN KEY ([UserDetailId]) REFERENCES [dbo].[UserDetails] ([Id])
);





