CREATE PROC RemoveUsersById
 @Id INT
 AS
 BEGIN
  DELETE FROM Users WHERE Id = @Id
 END