CREATE PROCEDURE [dbo].[spProject_GetAll]
AS
begin

set nocount on;

select [Id], [Name], [CategoryId], [SubcategoryId]
from Project;

end
