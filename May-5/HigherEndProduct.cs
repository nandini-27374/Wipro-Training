CREATE PROCEDURE HigherEndProduct
AS
BEGIN
SELECT * FROM Products WHERE Price > 60000;
END;
EXEC HigherEndProduct;
