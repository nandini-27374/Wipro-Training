//CREATING TABLE

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    SalaryDECIMAL(10,2),
    HireDate DATE
);

//INSERTING VALUES INTO THE TABLE

INSERT INTO Employees VALUES (1,'Bhavya', 'Chukka', 'IT',55000.00,'02-04-2022');
INSERT INTO Employees VALUES (1,'Yamuna', 'Pathikonda', 'Mechanical',65000.00,'03-04-2022');

//READING DATA FROM THE TABLE

SELECT * FROMEmployees;

//UPDATING NEW VALUES INTO THE TABLE

UPDATE SET Employees SET Department='Computer Science' WHERE EmployeeID=1;

//TRUNCATING THE TABLE

TRUNCATE TABLE Employees;

//DELETING THE TABLE

DROP TABLE Employees;