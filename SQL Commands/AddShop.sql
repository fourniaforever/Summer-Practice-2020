CREATE PROC AddShop
 @Id INT,
 @Name NVARCHAR(150),
 @Address NVARCHAR(150)
 AS
 BEGIN
	INSERT INTO Shops (Id,Name,Address)
	VALUES(@Id,@Name,@Address)
END