CREATE PROCEDURE [dbo].[spEntry_GetByCategory]
	@CategoryId int
AS
begin

	set nocount on;

	select [e].[Id], [e].[ProjectId], [e].[HoursSpent], [e].[Date], [e].[Notes]
	from Entry e
	inner join Project p on e.ProjectId = p.Id
	inner join Category c on p.CategoryId = c.Id
	where p.CategoryId = @CategoryId;

end
