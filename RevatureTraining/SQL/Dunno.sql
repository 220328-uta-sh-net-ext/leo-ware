-- 1. insert two new records into the employee table.

INSERT INTO Employee (EmployeeId, FirstName, LastName, ReportsTo, Country) VALUES (9, 'Robert', 'Graves', 1, 'USA');

INSERT INTO Employee (EmployeeId, FirstName, LastName, ReportsTo, Country) VALUES (10, 'DeNali', 'Jiaghert', 6, 'ENGLAND');

SELECT *
FROM Employee;

-- 3. update customer Aaron Mitchell's name to Robert Walter

UPDATE Customer 
SET FirstName = 'Robert'  -- , otherthing = value
WHERE CustomerId = 32;

UPDATE Customer
SET LastName = 'Walter'
WHERE CustomerId = 32;

-- *You can also write this solution like the one below. It does the same thing as both of the solutions above, but all in one solution.

UPDATE Customer
SET LastName = 'Walter', FirstName = 'Robert'
WHERE CustomerId = 32;

SELECT *
FROM Customer
WHERE CustomerId = 32;

-- 4. delete one of the employees you inserted.
SELECT * FROM Employee;


-- 5. delete customer Robert Walter.
-- >> Finding the customer in all tables they would exist in:
SELECT *
FROM Invoice INNER JOIN Customer ON Customer.CustomerId = Invoice.CustomerId
WHERE FirstName = 'Robert' AND LastName = 'Walter';



