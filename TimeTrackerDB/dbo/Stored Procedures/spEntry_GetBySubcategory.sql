CREATE PROCEDURE [dbo].[spEntry_GetBySubcategory]
	@SubcategoryId int
AS
begin

	set nocount on;

	select [e].[Id], [e].[ProjectId], [e].[HoursSpent], [e].[Date], [e].[Notes]
	from entry e
	inner join Project p on e.ProjectId = p.Id
	inner join Subcategory s on p.SubcategoryId = s.Id
	where p.SubcategoryId = @SubcategoryId;

end