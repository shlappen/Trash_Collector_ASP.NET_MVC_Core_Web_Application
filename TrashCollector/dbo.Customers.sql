CREATE TABLE [dbo].[Customers] (
    [Name]               NVARCHAR (MAX) NULL,
    [IdentityUserId]     NVARCHAR (450) NULL,
    [Address]            NVARCHAR (MAX) NULL,
    [CollectionDay]      INT            NULL,
    [ExtraCollectionDay] INT            DEFAULT ((0)) NULL,
    [Id]                 INT            IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customers_AspNetUsers_IdentityUserId] FOREIGN KEY ([IdentityUserId]) REFERENCES [dbo].[AspNetUsers] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Customers_IdentityUserId]
    ON [dbo].[Customers]([IdentityUserId] ASC);

