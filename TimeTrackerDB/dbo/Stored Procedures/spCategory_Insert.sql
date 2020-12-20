CREATE PROCEDURE [dbo].[spCategory_Insert]
	@Name nvarchar(50),
	@Id int = 0 output
AS
begin

	set nocount on;

	insert into dbo.Category (Name)
	values (@Name);

	select @Id = SCOPE_IDENTITY();

end
