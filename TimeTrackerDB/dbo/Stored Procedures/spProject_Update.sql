CREATE PROCEDURE [dbo].[spProject_Update]
	@Name nvarchar(50),
	@Id int,
	@CategoryId int,
	@SubcategoryId int
AS
begin

	set nocount on;

	update Project
	set Name = @Name, CategoryId = @CategoryId, SubcategoryId = @SubcategoryId
	where Id = @Id;

end
