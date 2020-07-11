ALTER PROC AddShop
 @Name NVARCHAR(150),
 @Address NVARCHAR(150)
 AS
 BEGIN
	INSERT INTO Shops (Name,Address)
	VALUES(@Name,@Address)
END