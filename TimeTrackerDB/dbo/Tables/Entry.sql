CREATE TABLE [dbo].[Entry]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectId] INT NOT NULL, 
    [HoursSpent] FLOAT NOT NULL, 
    [Date] DATETIMEOFFSET NOT NULL, 
    [Notes] NVARCHAR(1000) NOT NULL, 
    CONSTRAINT [FK_Entry_Project] FOREIGN KEY ([ProjectId]) REFERENCES [Project]([Id])
)
