CREATE Procedure GetAllProducts
AS
BEGIN
	SELECT * FROM Products;
END;
EXEC GetAllProducts;
