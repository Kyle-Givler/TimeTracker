CREATE PROCEDURE [dbo].[spProject_Insert]
	@Name nvarchar(50),
	@CategoryId int,
	@SubcategoryId int,
	@Id int = 0 output
AS
begin

	set nocount on;

	insert into Project (Name, CategoryId, SubcategoryId)
	values (@Name, @CategoryId, @SubcategoryId);

	select @Id = SCOPE_IDENTITY();

end
