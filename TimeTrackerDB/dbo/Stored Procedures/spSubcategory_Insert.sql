CREATE PROCEDURE [dbo].[spSubcategory_Insert]
	@Name varchar(50),
	@CategoryId int,
	@Id int = 0 output
AS
begin

set nocount on;

insert into Subcategory (Name, CategoryId)
values (@Name, @CategoryId);

select @Id = SCOPE_IDENTITY();

end
