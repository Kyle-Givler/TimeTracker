CREATE PROCEDURE [dbo].[spProject_GetByCatId]
	@CategoryId int
AS
begin
	set nocount on;

	select * 
	from Project
	where CategoryId = @CategoryId;
end