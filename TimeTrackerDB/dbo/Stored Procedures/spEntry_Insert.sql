CREATE PROCEDURE [dbo].[spEntry_Insert]
	@ProjectId int,
	@HoursSpent float,
	@Date datetimeoffset(7),
	@Notes nvarchar(1000),
	@Id int = 0 out
AS
begin

	set nocount on;

	insert into Entry (ProjectId, HoursSpent, Date, Notes)
	values (@ProjectId, @HoursSpent, @Date, @Notes);

	select @Id = SCOPE_IDENTITY();

end
