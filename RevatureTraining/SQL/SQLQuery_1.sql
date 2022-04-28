-- 1. list all customers (full names, customer ID, and country) who are not in the US
SELECT FirstName + ' ' + LastName AS FullName, CustomerId, Country FROM Customer WHERE Country != 'USA';

-- 2. list all customers from brazil
SELECT FirstName, LastName, Country = 'Brazil'
FROM Customer;

-- 3. list all sales agents
SELECT FirstName, LastName, Title = 'Sales Agent' FROM Employee;

-- 4. show a list of all countries in billing addresses on invoices.
SELECT BillingCountry FROM Invoice;

-- 5. how many invoices were there in 2009, and what was the sales total for that year?
--    (extra challenge: find the invoice count sales total for every year, using one query)


-- 6. how many line items were there for invoice #37?


-- 7. how many invoices per country?

SELECT BillingCountry, COUNT(*)
FROM Invoice
GROUP BY BillingCountry;

-- 8. show total sales per country, ordered by highest sales first.

SELECT BillingCountry, SUM(Total) AS Total, COUNT(*)
FROM Invoice
GROUP BY BillingCountry
Order By SUM(Total)
DESC, BillingCountry;


SELECT * FROM Album;

SELECT * FROM Artist;

SELECT ArtistId
FROM Artist
WHERE Name = 'Various Artists';

DECLARE @id INT;
SELECT @id = ArtistId
FROM Artist
WHERE Name = 'Various Artists';
-- Highlight the query below along with the query above for this to work. By "work", I mean to see a viewable output.
SELECT *
FROM Album
WHERE ArtistId = @id;

SELECT *
FROM Employee AS e1 CROSS JOIN Employee AS e2
WHERE e1.EmployeeId != e2.EmployeeId;

SELECT al.Title, ar.Name
FROM Artist AS ar
RIGHT JOIN Album AS al ON al.ArtistId = ar.ArtistId;

SELECT COALESCE(Title, 'NONE'), Artist.Name AS Album
FROM Artist AS ar
LEFT JOIN Album AS al ON al.AlbumId = ar.AlbumId
WHERE NULL IS NULL;

-- 1. show all invoices of customers from brazil (mailing address not billing)

SELECT FirstName, LastName, Customer.Address, Country, Invoice.* --This asterix '*' calls all collumns from the desired table.
FROM  Invoice JOIN Customer ON Invoice.CustomerId = Customer.CustomerId
WHERE Country = 'Brazil';


-- 2. show all invoices together with the name of the sales agent of each one

SELECT InvoiceId FROM Customer;

-- 3. show all playlists ordered by the total number of tracks they have

-- 4. which sales agent made the most in sales in 2009?
-- 5. how many customers are assigned to each sales agent?

-- 6. which track was purchased the most since 2010?

-- 7. show the top three best-selling artists.

-- 8. which customers have the same initials as at least one other customer?

SELECT SUBSTRING(FirstName, 1, 1) + SUBSTRING(LastName, 1, 1) FROM Customer
INTERSECT -- Filters dublicates
SELECT SUBSTRING(FirstName, 1, 1) + SUBSTRING(LastName, 1, 1) FROM Employee;

-- Now we compare customers' initials with employees' initials.
SELECT SUBSTRING(FirstName, 1, 1) + SUBSTRING(LastName, 1, 1) FROM Customer
INTERSECT
SELECT SUBSTRING(FirstName, 1, 1) + SUBSTRING(LastName, 1, 1) FROM Employee;



-- Querying all tracks that have never been bought/purchased
SELECT Track.*
FROM Track LEFT JOIN InvoiceLine ON Track.TrackId = InvoiceLine.TrackId
WHERE InvoiceLine.TrackId IS NULL;
-- this is a subquery version of the query above using the operator "NOT IN".
SELECT *
FROM Track --LEFT JOIN InvoiceLine ON Track.TrackId = InvoiceLine.TrackId
WHERE TrackId NOT IN (
    SELECT TrackId FROM InvoiceLine
);

SELECT TrackId FROM Track
EXCEPT
SELECT TrackId FROM InvoiceLine;

-- the artist with the longest album title.
SELECT * FROM Artist WHERE ArtistId = (
    SELECT ArtistId FROM Album 
    WHERE LEN(Title) >= ALL(SELECT LEN(Title) FROM Album)
);


-- 1. which artists did not make any albums at all?

SELECT ArtistId FROM Artist
EXCEPT
SELECT ArtistId FROM Album;
-- Using the EXCEPT operator applies more constrants to how many columns of information you can query from a table when comparing desired columns to other tables.
-- See below, I can ask to see both the artist's ID AND name. Because the artist's name isn't in the album table, I can't use the EXCEPT operator to query that information.
SELECT ArtistId, Artist.Name
FROM Artist
WHERE ArtistId NOT IN (
    SELECT ArtistId FROM Album
);


-- 2. which artists did not record any tracks of the Latin genre?

SELECT TrackId, GenreId
FROM Track
WHERE GenreId = '7';

SELECT *
FROM Genre;

SELECT *
FROM Track;

SELECT * FROM Artist WHERE ArtistId = (
    SELECT ArtistId FROM Album WHERE
        LEN(Title) >= ALL(SELECT LEN(Title) FROM Album)
);

SELECT Artist.*
 FROM Artist WHERE AlbumId = (
    SELECT AlbumId FROM Album WHERE
    AlbumId = ALL(SELECT AlbumId FROM Track WHERE
    Track.GenreId = Genre.GenreId)
);

SELECT *
FROM Artist
WHERE ArtistId NOT IN (
    SELECT ArtistId FROM Album WHERE AlbumId IN(
        SELECT AlbumId
        FROM Track
        WHERE GenreId IN (SELECT GenreId FROM Genre WHERE Name = 'Latin')
    )
);

-- 3. which video track has the longest length? (use media type table)

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.