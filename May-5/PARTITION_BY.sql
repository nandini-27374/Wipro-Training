//PARTITION BY(Group-Wise Analysis)
SELECT
	Name,
	Department,
	Salary,
	AVG(Salary) OVER(PARTITION BY Department) AS DeptAvgSalary
FROM Employees;

//partitions the data by department then it will give the average within each group.
