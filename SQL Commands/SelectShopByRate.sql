CREATE PROC SelectShopsByRate
@rate int
as
Begin
SELECT Shops.Name FROM Shops INNER JOIN Rates ON Rates.RateBy = Shops.Id
WHERE Rates.Rate = @rate
end
