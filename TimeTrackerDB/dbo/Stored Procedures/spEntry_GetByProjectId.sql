CREATE PROCEDURE [dbo].[spEntry_GetByProjectId]
	@ProjectId int
AS
begin

	set nocount on;

	select *
	from Entry
	where ProjectId = @ProjectId;

end
