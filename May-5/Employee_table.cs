CREATE TABLE Employees (
	EmpID INT PRIMARY KEY,
	Name VARCHAR(50),
	Department VARCHAR(50),
	Salary DECIMAL(10,2),
	JoinDate DATE
);
INSERT INTO Employees 
VALUES
(1,'Jogn','HR',50000,'2021-06-01'),
(2,'Priya','Finance',60000,'2020-09-15'),
(3,'Amit','IT',75000,'2019-01-10'),
(4,'Sara','IT',72000,'2023-02-25');

SELECT Name,ROUND(Salary,-3) AS RoundSalary FROM Employees;

SELECT Department,MAX(Salary)AS HighestSalary
FROM Employees
GROUP BY Department;

SELECT Name, Salary,
	CASE		
		WHEN Salary >= 70000 THEN 'High'
		WHEN Salary >=50000 THEN 'Medium'
		ELSE 'Low'
	END AS Salaryband
FROM Employees;