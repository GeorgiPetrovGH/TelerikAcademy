--01. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
--Insert few records for testing.
--Write a stored procedure that selects the full names of all persons.
USE PersonAccountTestDB
GO

CREATE TABLE Persons(
	PersonID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50),
	SSN int NOT NULL UNIQUE CHECK(LEN(SSN) = 9)
)

CREATE TABLE Accounts(
	AccountID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	PersonID int FOREIGN KEY(PersonID) REFERENCES Persons(PersonID) NOT NULL,
	Balance money NOT NULL
)

INSERT INTO Persons VALUES
('Pesho', 'Peshov', 111111111),
('John', 'John', 222222222),
('Gosho', 'Goshov', 333333333),
('Penka', 'Penkova', 444444444),
('Jane', '`Jane', 555555555)

INSERT INTO Accounts VALUES
(1, 1000),
(2, 2000),
(3, 3000),
(4, 4000),
(5, 5000)

GO

CREATE PROC usp_PersonsFullNames
AS
	SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM Persons
GO

EXEC usp_PersonsFullNames

--02.Create a stored procedure that accepts a number as a parameter and returns all persons 
--who have more money in their accounts than the supplied number
USE PersonAccountTestDB
GO

CREATE PROC usp_GetPersonsWithMoreMoneyThanSpecified(@balanceQuery money = 0)
AS 
	SELECT p.FirstName + ' ' + p.LastName AS [Person], a.Balance
	FROM Persons p
	JOIN Accounts a
	ON p.PersonID = a.PersonID
	WHERE a.Balance > @balanceQuery

GO

EXEC usp_GetPersonsWithMoreMoneyThanSpecified 2000

--03.Create a function that accepts as parameters � sum, yearly interest rate and number of months.
--It should calculate and return the new sum.
--Write a SELECT to test whether the function works as expected.
USE [PersonAccountTestDB]
GO

CREATE FUNCTION [dbo].[ufn_CalculateInterest] (@currentBalance money, @yearlyInterestRate float, @numberOfMonths float)
	RETURNS money
AS
BEGIN
	RETURN @currentBalance + (@numberOfMonths/12)*@yearlyInterestRate*@currentBalance
END
GO

SELECT p.FirstName + ' ' + p.LastName AS [Person], dbo.ufn_CalculateInterest(a.Balance, 0.07, 8) AS [Balance With applied interest]
FROM Persons p
JOIN Accounts a
ON p.PersonID = a.PersonID

--04.Create a stored procedure that uses the function from the previous example to give an interest 
--to a person's account for one month.
--It should take the AccountId and the interest rate as parameters.
USE PersonAccountTestDB
GO

CREATE PROC usp_GiveInterestForOneMonth (@accountID int, @interestRate float)
AS
	IF(EXISTS(SELECT AccountID FROM Accounts WHERE AccountID = @accountID))
		BEGIN
		UPDATE Accounts SET Balance = dbo.ufn_CalculateInterest(Balance, @interestRate, 1)
		WHERE AccountID = @accountID
		END
	ELSE
		PRINT 'No such account, dude.'
		
GO

SELECT * FROM Accounts

EXEC dbo.usp_GiveInterestForOneMonth 6, 0.1

EXEC dbo.usp_GiveInterestForOneMonth 2, 0.1

SELECT * FROM Accounts

--05.Add two more stored procedures WithdrawMoney(AccountId, money) 
--and DepositMoney(AccountId, money) that operate in transactions.
USE PersonAccountTestDB
GO

CREATE PROC usp_Withdraw(@accountID int, @ammount money)
AS 
	BEGIN TRAN
	IF(NOT EXISTS(SELECT AccountID FROM Accounts WHERE AccountID = @accountID))
		BEGIN
		PRINT ('No such account, dude.')
		ROLLBACK TRAN
		END
	ELSE IF(
		EXISTS(
			SELECT AccountID
			FROM Accounts
			WHERE AccountID = @accountID AND Balance < @ammount))
		BEGIN
		PRINT ('Insufficient funds.')
		ROLLBACK TRAN
		END
	ELSE
		BEGIN
		UPDATE Accounts SET Balance -= @ammount WHERE AccountID = @accountID
		COMMIT TRAN
		END
GO

USE PersonAccountTestDB
GO

CREATE PROC usp_Deposit(@accountID int, @ammount money)
AS 
	BEGIN TRAN
	IF(NOT EXISTS(SELECT AccountID FROM Accounts WHERE AccountID = @accountID))
		BEGIN
		PRINT ('No such account, dude.')
		ROLLBACK TRAN
		END
	ELSE
		BEGIN
		UPDATE Accounts SET Balance += @ammount WHERE AccountID = @accountID
		COMMIT TRAN
		END
GO

SELECT * FROM Accounts
EXEC dbo.usp_Deposit 6, 514
EXEC dbo.usp_Deposit 1, 514
SELECT * FROM Accounts

EXEC dbo.usp_Withdraw 1, 50000
EXEC dbo.usp_Withdraw 1, 1000
SELECT * FROM Accounts

--06.Create another table � Logs(LogID, AccountID, OldSum, NewSum).
--Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.
USE PersonAccountTestDB
GO

CREATE TABLE Logs(
	LogID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	AccountID int FOREIGN KEY(AccountID) REFERENCES Accounts(AccountID) NOT NULL,
	OldSum money,
	NewSum money
)

CREATE TRIGGER tr_AccountUpdate ON Accounts FOR UPDATE
AS
	BEGIN
	INSERT INTO dbo.Logs(AccountID, OldSum, NewSum)
	SELECT inserted.AccountID, deleted.Balance, inserted.Balance
	FROM inserted, deleted
	END
GO

SELECT * FROM Logs
EXEC dbo.usp_Deposit 1, 300
EXEC dbo.usp_Withdraw 5, 3000

SELECT * FROM Logs

--Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) 
--and all town's names that are comprised of given set of letters.
--Example: 'oistmiahf' will return 'Sofia', 'Smith', � but not 'Rob' and 'Guy'.
USE [TelerikAcademy]
GO
CREATE FUNCTION [dbo].[ufn_StringContainsLetters](@string nvarchar(MAX), @letters nvarchar(MAX))
RETURNS bit
AS
	BEGIN
		DECLARE @counter int = 1
		WHILE(@counter <= LEN(@letters))
		BEGIN
			IF(CHARINDEX(SUBSTRING(@letters, @counter, 1), @string) = 0)
				RETURN 0
			ELSE
				SET @counter += 1
		END
		RETURN 1
	END
GO

USE [TelerikAcademy]
GO

CREATE FUNCTION [dbo].[ufn_GetNamesBySetOfLetters](@letterSet nvarchar(50))
RETURNS TABLE
AS
	RETURN(
	SELECT FirstName
	FROM Employees
	WHERE dbo.ufn_StringContainsLetters(@letterSet, FirstName) = 1
	UNION
	SELECT MiddleName
	FROM Employees
	WHERE dbo.ufn_StringContainsLetters(@letterSet, MiddleName) = 1
	UNION
	SELECT LastName
	FROM Employees
	WHERE dbo.ufn_StringContainsLetters(@letterSet, LastName) = 1
	UNION
	SELECT Name
	FROM Towns
	WHERE dbo.ufn_StringContainsLetters(@letterSet, Name) = 1
	)
GO

SELECT * FROM [dbo].[ufn_GetNamesBySetOfLetters]('oistmiahf')

--08.Using database cursor write a T-SQL script that scans all employees 
--and their addresses and prints all pairs of employees that live in the same town
DECLARE empCursor CURSOR READ_ONLY FOR

SELECT e1.FirstName + ' ' + e1.LastName AS Employee,
	   t1.Name AS Town,
	   e2.FirstName + ' ' + e2.LastName AS Employee
FROM Employees e1
JOIN Addresses a1
ON e1.AddressID = a1.AddressID
JOIN Towns t1
ON a1.TownID = t1.TownID,
	 Employees e2
JOIN Addresses a2
ON e2.AddressID = a2.AddressID
JOIN Towns t2
ON a2.TownID = t2.TownID
WHERE t1.Name = t2.Name AND e1.EmployeeID <> e2.EmployeeID
ORDER BY t1.Name

OPEN empCursor
DECLARE @firstEmployee nvarchar(50)
DECLARE @secondEmployee nvarchar(50)
DECLARE @town nvarchar(50)

FETCH NEXT FROM empCursor INTO @firstEmployee, @town, @secondEmployee

WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT @firstEmployee + ' | ' + @town + ' | ' + @secondEmployee
		FETCH NEXT FROM empCursor INTO  @firstEmployee, @town, @secondEmployee
	END
CLOSE empCursor
DEALLOCATE empCursor

--09.Write a T-SQL script that shows for each town a list of all employees that live in it.
DECLARE townCursor CURSOR READ_ONLY FOR
SELECT Name
FROM Towns
ORDER BY Name

OPEN townCursor
DECLARE @town nvarchar(50)
DECLARE @employees nvarchar(MAX)

FETCH NEXT FROM townCursor INTO @town
WHILE @@FETCH_STATUS = 0
	BEGIN
		BEGIN
			DECLARE empNameCursor CURSOR READ_ONLY FOR
			SELECT e.FirstName + ' ' + e.LastName
			FROM Employees e
			JOIN Addresses a
			ON e.AddressID = a.AddressID
			JOIN Towns t
			ON a.TownID = t.TownID
			WHERE t.Name = @town

			OPEN empNameCursor
			DECLARE @employee nvarchar(100)

			FETCH NEXT FROM empNameCursor INTO @employee
			WHILE @@FETCH_STATUS = 0
				BEGIN
					SET @employees += @employee + ', '
					FETCH NEXT FROM empNameCursor INTO @employee
				END
			CLOSE empNameCursor
			DEALLOCATE empNameCursor
		END
		SET @employees = LEFT(@employees, LEN(@employees) - 1)
		PRINT @town + ' -> ' + @employees
		SET @employees = ''
		FETCH NEXT FROM townCursor INTO @town
	END
CLOSE townCursor
DEALLOCATE townCursor
GO

--Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists 
--of the input strings separated by ','.
--For example the following SQL statement should return a single string:
--SELECT StrConcat(FirstName + ' ' + LastName)
--FROM Employees
IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'string_concatenate_assembly')
DROP assembly string_concatenate_assembly;
GO

IF OBJECT_ID('dbo.concat') IS NOT NULL DROP Aggregate concat
GO

CREATE ASSEMBLY string_concatenate_assembly
FROM 'C:\Users\Tsvetan\Documents\GitHub\Telerik-Academy\Homeworks\Software Technologies\Databases\09.TransactSQL\ConcatenationOfStrings.dll'
GO

CREATE AGGREGATE StrConcat (@input nvarchar(MAX)) 
RETURNS nvarchar(MAX)
EXTERNAL NAME string_concatenate_assembly.Concatenate;
GO

--  the clr_enabled option specifies whether user assemblies can be run by SQL Server. Most likely by deafault it is set to 0(disabled). The next 2 lines set it to 1(enabled). 
EXEC sp_configure 'clr enabled' , '1';
RECONFIGURE;
GO

SELECT dbo.StrConcat(FirstName + ' ' + LastName) AS [All names in one looooooooong row...]
FROM Employees
