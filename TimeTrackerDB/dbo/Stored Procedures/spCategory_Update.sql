CREATE PROCEDURE [dbo].[spCategory_Update]
	@Name nvarchar(50),
	@Id int
AS
begin

	set nocount on;

	update Category
	set Name = @Name
	where Id = @Id;

end
