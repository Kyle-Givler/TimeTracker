CREATE PROCEDURE [dbo].[spSubcategory_Update]
	@Name varchar(50),
	@Id int
AS
begin

	set nocount on;

	update Subcategory
	set Name = @Name
	where Id = @Id;

end