ALTER PROC AddRate
 @IdShop INT,
 @Date date,
 @Rate INT,
 @RateBy INT
 AS
 BEGIN
	INSERT INTO Rates(IdShop,Date,Rate,RateBy)
	VALUES(@IdShop,@Date,@Rate,@RateBy)
END
