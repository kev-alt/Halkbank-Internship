SELECT USER_.NAMESURNAME, ADDRES.* FROM USER_
INNER JOIN ADDRES ON ADDRES.USERID=USER_.ID  --INNER JOIN: Returns only the records that have matching values in both tables.
WHERE USER_.ID IN (100, 101, 102)

DELETE FROM ADDRES WHERE USERID=102

SELECT USER_.NAMESURNAME, ADDRES.* FROM USER_
LEFT JOIN ADDRES ON ADDRES.USERID=USER_.ID  --LEFT JOIN: Returns all records from the left table, and the matched records from the right table. 
WHERE USER_.ID IN (100, 101, 102) --If no match, the right table fields will be NULL.

SELECT USER_.NAMESURNAME, ADDRES.* FROM USER_ 
RIGHT JOIN ADDRES ON ADDRES.USERID=USER_.ID --RIGHT JOIN: Returns all records from the right table, and the matched records from the left table. 
WHERE USER_.ID IN (100, 101, 102) --If no match, the left table fields will be NULL.

SELECT USER_.NAMESURNAME, ADDRES.* FROM USER_
FULL JOIN ADDRES ON ADDRES.USERID=USER_.ID  --FULL JOIN: Returns all records from both tables, with NULL in places where there is no match.
WHERE USER_.ID IN (100, 101, 102)