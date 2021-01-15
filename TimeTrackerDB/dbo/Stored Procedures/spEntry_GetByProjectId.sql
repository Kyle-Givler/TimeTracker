CREATE PROCEDURE [dbo].[spEntry_GetByProjectId]
	@ProjectId int
AS
begin

	set nocount on;

	select [Id], [ProjectId], [HoursSpent], [Date], [Notes]
	from Entry
	where ProjectId = @ProjectId;

end
