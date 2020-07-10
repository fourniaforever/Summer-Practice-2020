CREATE PROC AddRate
 @Id INT,
 @IdShop INT,
 @Date date,
 @Rate INT,
 @RateBy INT
 AS
 BEGIN
	INSERT INTO Rates(Id,IdShop,Date,Rate,RateBy)
	VALUES(@Id,@IdShop,@Date,@Rate,@RateBy)
END
