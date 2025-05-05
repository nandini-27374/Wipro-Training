CREATE PROCEDURE GetProductByRevenue
	@ProductID INT
AS
BEGIN
	SELECT
	@ProductID as ProductID,
	SUM(o.quantity*p.price) AS Total_Revenue
FROM Orders o
INNER JOIN Products p ON o.ProductID =p.ProductID
WHERE o.ProductId=@ProductID
END;
EXEC GetProductByRevenue @ProductID=1;