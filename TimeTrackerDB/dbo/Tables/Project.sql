CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [CategoryId] INT NOT NULL, 
    [SubcategoryId] INT NULL, 
    CONSTRAINT [FK_Project_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id]), 
    CONSTRAINT [FK_Project_Subcategory] FOREIGN KEY ([SubcategoryId]) REFERENCES [Subcategory]([Id])
)
