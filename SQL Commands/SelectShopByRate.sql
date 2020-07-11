CREATE PROC SelectShopsByRate
@rate int
as
Begin
SELECT Shops.Name FROM Shops INNER JOIN Rates ON Rates.IdShop = Shops.Id
WHERE Rates.Rate = @rate
end
