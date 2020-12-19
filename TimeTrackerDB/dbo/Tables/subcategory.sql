CREATE TABLE [dbo].[subcategory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [CategoryId] INT NOT NULL, 
    CONSTRAINT [FK_subcategory_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id])
)
