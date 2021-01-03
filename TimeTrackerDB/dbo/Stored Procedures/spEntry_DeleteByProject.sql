CREATE PROCEDURE [dbo].[spEntry_DeleteByProject]
	@ProjectId int
AS
begin

	set nocount on;

	delete 
	from Entry
	Where ProjectId = @ProjectId;

end
