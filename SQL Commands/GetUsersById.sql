CREATE PROC GetUsersById
	@Id INT
AS
BEGIN
	SELECT*FROM Users WHERE Id = @Id
END