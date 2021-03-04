CREATE PROCEDURE [dbo].[spEntry_Update]
	@Id int,
	@HoursSpent float,
	@Date datetimeoffset(7),
	@Notes nvarchar(1000)
AS
begin

	set nocount on;

	update Entry
	set HoursSpent = @HoursSpent, Notes = @Notes, Date = @Date
	where Id = @Id;

end
