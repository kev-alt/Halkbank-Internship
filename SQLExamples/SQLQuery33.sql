--LEFT, RIGHT, LEN

SELECT LEFT('Kevser Altunbey', 6)

SELECT RIGHT('Kevser Altunbey', 8)

SELECT LEN('Kevser Altunbey')

SELECT LEFT('Kevser Altubey', CHARINDEX(' ', 'Kevser Altunbey')), 
	   RIGHT('Kevser Altubey', LEN('Kevser Altunbey')-CHARINDEX(' ', 'Kevser Altunbey'))


SELECT LEFT(NAMESURNAME, CHARINDEX(' ', NAMESURNAME)), 
	   RIGHT(NAMESURNAME, LEN(NAMESURNAME)-CHARINDEX(' ', NAMESURNAME))
FROM USER_
