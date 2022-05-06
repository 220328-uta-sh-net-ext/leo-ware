CREATE TABLE [dbo].[Employee]
(
    [EmployeeId] INT NOT NULL,
    [FirstName] NVARCHAR(40) NOT NULL,
    [LastName] NVARCHAR(40) NOT NULL,
    [SSN] INT NOT NULL,
    [DeptId] INT NOT NULL,
    CONSTRAINT [PK_LastName] PRIMARY KEY CLUSTERED ([EmployeeId]) 
);

CREATE TABLE [dbo].[Department]
(
    [DeptId] INT NOT NULL,
    [DepartmentName] NVARCHAR(40) NOT NULL,
    [Location] NVARCHAR(40) NULL,
    CONSTRAINT [PK_DeptId] PRIMARY KEY CLUSTERED ([DeptId])
);

CREATE TABLE [dbo].[EmployeeDetails]
(
    [EmployeeId] INT NOT NULL,
    [Salary] MONEY NOT NULL,
    [Address1] INT NOT NULL,
    [Address2] INT NULL,
    [City] NVARCHAR(40) NOT NULL,
    [State] NVARCHAR(40) NOT NULL,
    [ZipCode] INT NULL,
    [Country] NVARCHAR(40) NOT NULL,
    CONSTRAINT [PK_EmployeeId] PRIMARY KEY CLUSTERED ([EmployeeId])
);

-- add at least 3 records into each table
-- INSERT INTO () VALUES ();
-- 1. Employee Table
INSERT INTO Employee (EmployeeId, FirstName, LastName, SSN, DeptId) VALUES ();

INSERT INTO Employee (EmployeeId, FirstName, LastName, SSN, DeptId) VALUES ();

SELECT *
FROM Employee;

-- 2. Employee Details
INSERT INTO () VALUES ();
INSERT INTO () VALUES ();
INSERT INTO () VALUES ();

SELECT *
FROM EmployeeDetails;

-- 
INSERT INTO () VALUES ();
INSERT INTO () VALUES ();
INSERT INTO () VALUES ();

SELECT *
FROM Department;

-- add employee: 'Tina' 'Smith'

INSERT INTO () VALUES ();

-- add department 'Marketing'

INSERT INTO () VALUES ();

-- add list all employees in 'Marketing'

-- report ttotal salary of 'Marketing'

-- report total employees by department

-- increase salary of 'Tina' 'Smith' to $90,000

UPDATE