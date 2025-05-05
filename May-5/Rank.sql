--RANK()

SELECT 
	Name,
	Salary,
	RANK() OVER(ORDER BY Salary DESC) AS RakBySalary
FROM Employees;

--Gives same rank for ties,skips the next number 