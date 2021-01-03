CREATE PROCEDURE [dbo].[spEntry_Delete]
	@Id int
AS
begin

	set nocount on;

	delete 
	from Entry
	where Id = @Id;

end
