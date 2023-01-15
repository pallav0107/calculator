Drop Table [dbo].[Diagnostics]

CREATE TABLE [dbo].[Diagnostics] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Message]   NVARCHAR(MAX)       NULL,
    [Timestamp] DATETIME         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);




