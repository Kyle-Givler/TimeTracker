CREATE PROCEDURE [dbo].[spSubcategory_Delete]
	@Id int
AS
begin
	set nocount on;

	delete from Subcategory where Id = @Id;
end
