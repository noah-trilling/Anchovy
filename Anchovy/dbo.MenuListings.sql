CREATE TABLE [dbo].[MenuListings] (
    [Id]   INT             IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX)  NULL,
    [Cost] DECIMAL (18, 2) NOT NULL,
    [SizeId] INT NULL, 
    CONSTRAINT [PK_dbo.MenuListings] PRIMARY KEY CLUSTERED ([Id] ASC)
);

