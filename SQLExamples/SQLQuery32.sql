--FORMAT

SELECT FORMAT(GETDATE(), 'd', 'en-us') AS 'US English Result'
	  ,FORMAT(GETDATE(), 'd', 'en-gb') AS 'Great Britain English Result'
	  ,FORMAT(GETDATE(), 'd', 'de-de') AS 'German Result'
	  ,FORMAT(GETDATE(), 'd', 'zh-ch') AS 'Simplified Chinese (PRC) Result';

SELECT FORMAT(GETDATE(), 'D', 'en-us') AS 'US English Result'
	  ,FORMAT(GETDATE(), 'D', 'en-gb') AS 'Great Britain English Result'
	  ,FORMAT(GETDATE(), 'D', 'de-de') AS 'German Result'
	  ,FORMAT(GETDATE(), 'D', 'zh-ch') AS 'Simplified Chinese (PRC) Result';

