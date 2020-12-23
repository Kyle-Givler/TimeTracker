CREATE PROCEDURE [dbo].[spSubcategory_GetByCategoryId]
	@CategoryId int
AS
begin

set nocount on;

select [Id], [Name], [CategoryId]
from dbo.Subcategory
where CategoryId = @CategoryId;

end
