CREATE TABLE Students (
	StudentID INT PRIMARY KEY,
	FirstName VARCHAR(50),
	Marks INT,
	DOB DATE
);
INSERT INTO Students(StudentID, FirstName, Marks, DOB)
VALUES 
(1,'Amit',92,'2003-05-10'),
(2,'Neha',78,'2002-11-15'),
(3,'Rahul',61,'2004-01-20'),
(4,'Sneha',49,'2003-09-01');

SELECT FirstName,Marks,
	CASE
		WHEN Marks>=90 THEN 'A'
		WHEN Marks>=75 THEN 'B'
		WHEN Marks>=90 THEN 'C'
		ELSE 'D'
	END AS Grade
FROM Students;
SELECT AVG(Marks) AS AverageMarks FROM Students;
SELECT COUNT(*) TotalStudents FROM Students;
SELECT FirstName,DATEDIFF(YEAR,DOB,GETDATE()) AS Age FROM Students;
SELECT FirstName,UPPER(FirstName) AS UpperName FROM Students;