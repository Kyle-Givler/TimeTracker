CREATE PROCEDURE [dbo].[spProject_GetBySubCatId]
	@SubcategoryId int
AS
begin

	set nocount on;

	select * 
	from Project
	where SubcategoryId = @SubcategoryId;

end
