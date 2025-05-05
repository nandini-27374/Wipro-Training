CREATE PROCEDURE CheckProductExists
	@ProductID INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM PRODUCTS WHERE ProductID=@productID)
		print 'Product exists'
	else
		print 'Product not exists'
	end

EXEC CheckProductExists @ProductID=3;