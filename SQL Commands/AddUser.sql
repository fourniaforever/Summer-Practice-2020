CREATE PROC AddUser
 @Id INT,
 @Name nvarchar(100),
 @Surname nvarchar(150),
 @Login nvarchar(200),
 @Password binary,
 @City nvarchar(100)
 AS
 BEGIN
	INSERT INTO Users(Id,Name,Surname,Login,Password,City)
	VALUES(@Id,@Name,@Surname,@Login,@Password,@City)
END