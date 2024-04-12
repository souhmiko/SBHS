CREATE TABLE [dbo].[OncallConditions] (
    [Id]                    INT            IDENTITY (1, 1) NOT NULL,
    [OncallConditionName]   NVARCHAR (MAX) NULL,
    [WorkTitleId]           INT            NOT NULL,
    [MaxAmountStaffAllowed] INT            NULL,
    CONSTRAINT [PK_OncallConditions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OncallConditions_WorkTitles] FOREIGN KEY ([WorkTitleId]) REFERENCES [dbo].[WorkTitles] ([Id]) ON DELETE CASCADE
);

