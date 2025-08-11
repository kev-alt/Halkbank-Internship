--SELECT: Retrieves records from the database.

--UPDATE: Updates one or more fields of a record in a table.

--DELETE: Deletes a record from a table.

--INSERT INTO: Adds a new record to a table.

--TRUNCATE TABLE: Empties all data from a table.

--CREATE DATABASE: Creates a new database.

--ALTER DATABASE: Modifies the properties of a database.

--CREATE TABLE: Creates a new table.

--ALTER TABLE: Modifies the structure of a table.

--DROP TABLE: Permanently deletes a table.

--CREATE INDEX: Creates an index.

--DROP INDEX: Deletes an index.


--SELECT

SELECT
ID, CUSTOMERNAME, CITY, DISTRICT, BIRTHDATE, GENDER, AGE
FROM
ETRADE.DBO.CUSTOMER

SELECT
*
FROM
ETRADE.DBO.CUSTOMER

SELECT
CUSTOMERNAME,CITY
FROM
ETRADE.DBO.CUSTOMER


--UPDATE

UPDATE CUSTOMER
SET AGE = DATEDIFF(YEAR, BIRTHDATE, GETDATE())
