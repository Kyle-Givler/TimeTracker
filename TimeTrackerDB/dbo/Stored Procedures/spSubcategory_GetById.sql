CREATE PROCEDURE [dbo].[spSubcategory_GetById]
	@Id int
AS
begin

set nocount on;

	select [Id], [Name], [CategoryId]
	from dbo.Subcategory
	where Id = @Id;

end
