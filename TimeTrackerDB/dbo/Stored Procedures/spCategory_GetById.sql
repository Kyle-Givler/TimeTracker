CREATE PROCEDURE [dbo].[spCategory_GetById]
	@Id int
AS
begin

	set nocount on;

	select [Id], [Name]
	from dbo.Category
	where Id = @Id;

end
