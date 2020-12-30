CREATE PROCEDURE [dbo].[spEntry_GetAll]
AS
begin

	set nocount on;

	select [Id], [ProjectId], [HoursSpent], [Date], [Notes]
	from dbo.Entry;

end
