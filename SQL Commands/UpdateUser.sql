CREATE PROC UpdateUser
 @Name nvarchar(100),
 @Surname nvarchar(150),
 @Login nvarchar(200),
 @Password binary,
 @City nvarchar(100)
 AS
 BEGIN
	UPDATE Users
	SET
	Name = @Name,
	Surname = @Surname,
	Login = @Login,
	Password = @Password,
	City = @City
END
