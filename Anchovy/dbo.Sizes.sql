CREATE TABLE [dbo].[Sizes] (
    [Id]   INT             IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX)  NULL,
    [Cost] DECIMAL (18, 2) NOT NULL,
    [SizeId] INT NOT NULL, 
    CONSTRAINT [PK_dbo.Sizes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

