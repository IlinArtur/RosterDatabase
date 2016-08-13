CREATE TABLE [dbo].[Inventory]
(
    [PersonId] INT NOT NULL , 
    [ItemId] INT NOT NULL, 
    CONSTRAINT [PK_Order] PRIMARY KEY ([PersonId], [ItemId]), 
    CONSTRAINT [FK_Order_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]), 
    CONSTRAINT [FK_Order_Item] FOREIGN KEY ([ItemId]) REFERENCES [Item]([Id])
)
