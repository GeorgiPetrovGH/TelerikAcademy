USE TelerikAcademy

--01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
SELECT FirstName + ' ' + LastName AS [Employee], Salary
FROM dbo.Employees
WHERE Salary =
	(SELECT MIN(Salary) FROM dbo.Employees)

--02. Write a SQL query to find the names and salaries of the employees 
--that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT FirstName + ' ' + LastName AS [Employee], Salary
FROM dbo.Employees
WHERE Salary <=
	(SELECT MIN(Salary) * 1.1 FROM Employees)
ORDER BY Salary

--03.Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
SELECT e.FirstName + ' ' + e.LastName AS [Employee], e.Salary, d.Name
FROM dbo.Employees e
JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE Salary =
	(SELECT MIN(Salary) FROM Employees e
	WHERE e.DepartmentID = d.DepartmentID)

--04.Write a SQL query to find the average salary in the department #1.
SELECT AVG(Salary) AS [Average salary]
FROM dbo.Employees 
WHERE DepartmentID = 1

--05.Write a SQL query to find the average salary in the "Sales" department.
SELECT AVG(Salary) AS [Average salary]
FROM dbo.Employees e
JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--06.Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(*) AS [Employees count]
FROM dbo.Employees e
JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--07.Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(ManagerID) AS [All employees]
FROM dbo.Employees

--08.Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*) AS [Bosses]
FROM dbo.Employees
WHERE ManagerID IS NULL

--09.Write a SQL query to find all departments and the average salary for each of them.
SELECT d.Name AS [Department], AVG(e.Salary) AS [Average salary]
FROM dbo.Employees e
JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

--10.Write a SQL query to find the count of all employees in each department and for each town.
SELECT t.Name AS [Town], d.Name AS [Department], COUNT(*) AS [Employees]
FROM dbo.Employees e
JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
JOIN dbo.Addresses a
ON e.AddressID = a.AddressID
JOIN dbo.Towns t
ON a.TownID = t.TownID
GROUP BY t.Name, d.Name

--11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT m.FirstName + ' ' + m.LastName AS [Manager], COUNT(*) AS [Employees]
FROM dbo.Employees e
JOIN dbo.Employees m
ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName 
HAVING COUNT(*) = 5

--12.Write a SQL query to find all employees along with their managers.
--For employees that do not have manager display the value "(no manager)".
SELECT e.FirstName + ' ' + e.LastName AS [Employee],
	ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') AS [Manager]
FROM dbo.Employees e
LEFT JOIN dbo.Employees m
ON e.ManagerID = m.EmployeeID

--13.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 
SELECT FirstName + ' ' + LastName AS [Employee]
FROM dbo.Employees
WHERE LEN(LastName) = 5

--14.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff') AS [Date]

--15.Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames.
--Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users
(
	UserID int IDENTITY(1,1) PRIMARY KEY,
    Username nvarchar(50) NOT NULL UNIQUE,
    Password nvarchar(50) CHECK(LEN(PassWord) >= 5),
    FullName nvarchar(100) NOT NULL,
    LastLoginTime SMALLDATETIME
)

--16.Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
--CREATE VIEW V_UsersVisitingToday 
--AS
--SELECT Username AS [User], LastLoginTime, GETDATE() AS [Current date] 
--FROM Users
--WHERE DATEDIFF(DAY, LastLoginTime, GETDATE()) = 0

--17.Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
CREATE TABLE Groups (
    GroupID int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(50) NOT NULL UNIQUE
)

--18.Write a SQL statement to add a column GroupID to the table Users.
--Fill some data in this new column and as well in the `Groups table.
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
ALTER TABLE Users 
ADD GroupID int

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY (GroupID) REFERENCES Groups(GroupID)

--19.Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Groups(Name) VALUES('John')
INSERT INTO Groups(Name) VALUES('Jane')

INSERT INTO Users VALUES('Pesho', 'pesho', 'peshopesho', GETDATE(), 1)
INSERT INTO Users VALUES('Gosho', 'gosho', 'goshogosho', GETDATE(), 2)

--20.Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users
SET Username = 'Jane'
WHERE UserID = 2 

UPDATE Users
SET PassWord += 'Jane'
WHERE UserID = 2 

--21.Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users
WHERE Username LIKE '%Jane%'

DELETE FROM Groups
WHERE Name LIKE '%Jane%'

--22.Write SQL statements to insert in the Users table the names of all employees from the Employees table.
--Combine the first and last names as a full name.
--For username use the first letter of the first name + the last name (in lowercase).
--Use the same for the password, and NULL for last login time.
INSERT INTO Users
     SELECT SUBSTRING(FirstName, 0, 5) + LOWER(LastName),
            LOWER(LEFT(FirstName, 1)) + LOWER(LastName) + 'pass',
            LOWER(LEFT(FirstName, 1)) + LOWER(LastName),
            NULL,
            1
     FROM Employees

--23.Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
UPDATE Users
SET [Password] = NULL
WHERE LastLoginTime < CONVERT(smalldatetime, '2010-03-10', 120)

--24.Write a SQL statement that deletes all users without passwords (NULL password).
DELETE FROM Users
WHERE Password IS NULL

--25.Write a SQL query to display the average employee salary by department and job title.
SELECT d.Name AS [Department], 
	e.JobTitle,
    AVG(Salary) AS [Average salary]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle

--26.Write a SQL query to display the minimal employee salary by department and job title 
--along with the name of some of the employees that take it.
SELECT d.Name AS [Department],
       e.JobTitle,
       e.Salary AS [Min salary],
       e.FirstName + ' ' + e.LastName AS [The most miserable ones]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = 
                (SELECT MIN(Salary)
                 FROM Employees em
                 WHERE em.JobTitle = e.JobTitle AND em.DepartmentID = e.DepartmentID)
GROUP BY d.Name, e.JobTitle, e.Salary, e.FirstName + ' ' + e.LastName

--27.Write a SQL query to display the town where maximal number of employees work.
SELECT TOP(1) t.Name,
       COUNT(*) AS [EmployeesCount]
FROM Employees e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY COUNT(*) DESC

--28.Write a SQL query to display the number of managers from each town.
SELECT t.Name AS [Town],
       COUNT(DISTINCT m.EmployeeID)
FROM Employees m
JOIN Employees e
ON e.ManagerID = m.EmployeeID
JOIN Addresses a
ON m.AddressID = a.AddressID
JOIN Towns t
ON a.TownID = t.TownID
GROUP BY t.Name

--29.Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
--Don't forget to define identity, primary key and appropriate foreign key.
--Issue few SQL statements to insert, update and delete of some data in the table.
--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
--For each change keep the old record data, the new record data and the command (insert / update / delete).
CREATE TABLE WorkHours
(
    WorkHoursID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    EmployeeID int FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID) NOT NULL,
    Date SMALLDATETIME NOT NULL,
    Task nvarchar(150),
    Hours int,
    Comments nvarchar(MAX)
)

CREATE TABLE WorkHoursLog
(
    WorkHoursLogID int  IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Command varchar(6) NOT NULL,
    OldWorkHoursID int,
    OldEmployeeID int,
    OldDate SMALLDATETIME,
    OldTask nvarchar(150),
    OldHours int,
    OldComments nvarchar(MAX),
    NewWorkHoursID int,
    NewEmployeeID int,
    NewDate SMALLDATETIME,
    NewTask nvarchar(150),
    NewHours int,
    NewComments nvarchar(MAX),
)

CREATE TRIGGER TR_WorkHoursInsert
ON WorkHours
FOR INSERT
AS
    INSERT INTO WorkHoursLog
        SELECT 'INSERT',
                NULL, NULL, NULL, NULL, NULL, NULL, 
                i.WorkHoursID, i.EmployeeID, i.Date, i.Task, i.Hours, i.Comments
        FROM inserted i
GO

CREATE TRIGGER TR_WorkHoursUpdate
ON WorkHours
FOR UPDATE
AS
    INSERT INTO WorkHoursLog
        SELECT 'UPDATE',
                d.WorkHoursID, d.EmployeeID, d.Date, d.Task, d.Hours, d.Comments,
                i.WorkHoursID, i.EmployeeID, i.Date, i.Task, i.Hours, i.Comments
        FROM deleted d, inserted i
GO

CREATE TRIGGER TR_WorkHoursDelete
ON WorkHours
FOR DELETE
AS
    INSERT INTO WorkHoursLog
        SELECT 'DELETE',                
                d.WorkHoursID, d.EmployeeID, d.Date, d.Task, d.Hours, d.Comments,
                NULL, NULL, NULL, NULL, NULL, NULL 
        FROM deleted d
GO

INSERT INTO WorkHours Values
(1, GETDATE(), 'Changing the tire', 1, 'Hands are greasy.'),
(3, GETDATE(), 'Stacking up beer', 5, 'Much work, WOW.')

UPDATE WorkHours 
SET Comments += ' No joke :)'
WHERE WorkHoursID = 2; 

DELETE FROM WorkHours 
WHERE WorkHoursID = 1;

--30.Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.
--At the end rollback the transaction.
BEGIN TRAN 
    ALTER TABLE Employees DROP FK_Employees_Departments
    ALTER TABLE Departments DROP FK_Departments_Employees
    DELETE FROM Employees
    FROM Employees e
    JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
    WHERE d.Name = 'Sales'
ROLLBACK TRAN

--31.Start a database transaction and drop the table EmployeesProjects.
--Now how you could restore back the lost table data?
BEGIN TRAN
    DROP TABLE EmployeesProjects
COMMIT TRAN

--32.Find how to use temporary tables in SQL Server.
--Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.

CREATE TABLE #TempEmployeesProjects(
    EmployeeID int NOT NULL,
    ProjectID int NOT NULL
)

INSERT INTO #TempEmployeesProjects
    SELECT EmployeeID, ProjectID 
    FROM EmployeesProjects

DROP TABLE EmployeesProjects

CREATE TABLE EmployeesProjects(
    EmployeeID int NOT NULL,
    ProjectID int NOT NULL,
    CONSTRAINT PK_EmployeesProjects PRIMARY KEY(EmployeeID, ProjectID),
    CONSTRAINT FK_EmployeeProjects_Employees FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID),
    CONSTRAINT FK_EmployeeProjects_Projects FOREIGN KEY(ProjectID) REFERENCES Projects(ProjectID)
)

INSERT INTO EmployeesProjects
    SELECT EmployeeID, ProjectID 
    FROM #TempEmployeesProjects

