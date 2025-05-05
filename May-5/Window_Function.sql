Window Function:

Window functions perform calculations across a set of rows (a window) related to the current row without collapsing rows like GROUP BY.

OVER() CLAUSE Basics
SELECT 
	Name,
	Department,
	Salary,
	AVG(Salary) OVER() AS AvgSalary --calculates average over all rows
FROM Employees;

OVER() defines the "window" over the function operates.