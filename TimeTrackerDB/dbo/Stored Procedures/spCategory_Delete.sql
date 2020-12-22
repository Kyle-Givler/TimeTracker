CREATE PROCEDURE [dbo].[spCategory_Delete]
	@Id int
AS
begin

	set nocount on;

	delete from Category where Id = @Id;

end
