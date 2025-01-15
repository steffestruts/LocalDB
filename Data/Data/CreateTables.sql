-- This script creates a table called Users and inserts a user into it
IF OBJECT_ID('Users', 'U') IS NULL

	CREATE TABLE Users (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		FirstName NVARCHAR(50) NOT NULL,
		LastName NVARCHAR(50) NOT NULL,
		Email NVARCHAR(100) NOT NULL,
		PhoneNumber NVARCHAR(15) NULL
	)

-- Creating a user with first name, last name, email and phone number
INSERT INTO Users (FirstName, LastName, Email, PhoneNumber)
VALUES (@FirstName, @LastName, @Email, @PhoneNumber)

-- For getting all users:
SELECT * FROM Users