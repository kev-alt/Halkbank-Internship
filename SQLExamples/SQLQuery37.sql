--REPLACE

SELECT 'Kevser Altunbey'
SELECT REPLACE('Kevser Altunbey','Kevser','ben1inegim')



DECLARE @CUMLE AS VARCHAR(MAX)

SET @CUMLE='Denize açıldım sevmeye, sevilmeye, anladım sevmek gibisi yok. 
Yağmura soyundum, yavaş yavaş yağar diye, damlalarda yüzmek gibisi yok. 
Yokluğum, varlığım bir, dünüm yok, yarınım sır. Nasıl inanırım sana? 
Bu yürek ağır bana, sevgin öyle uzaklarda, nefes alsan da yanımda.
Nasıl inanırım sana? Bu yürek ağır bana, sevgin öyle uzaklarda, nefes alsan da yanımda. 
Bu aşk fazla sana. Denize açıldım sevmeye, sevilmeye, anladım sevmek gibisi yok. 
Yağmura soyundum, yavaş yavaş yağar diye, damlalarda yüzmek gibisi yok. 
Yokluğum, varlığım bir, dünüm yok, yarınım sır. Nasıl inanırım sana? 
Bu yürek ağır bana, sevgin öyle uzaklarda, nefes alsan da yanımda. 
Nasıl inanırım sana? Bu yürek ağır bana, sevgin öyle uzaklarda, nefes alsan da yanımda. 
Bu aşk fazla sana. Yokluğum, varlığım bir, dünüm yok, yarınım sır. 
Nasıl inanırım sana? Bu yürek ağır bana, sevgin öyle uzaklarda, nefes alsan da yanımda. 
Nasıl inanırım sana? Bu yürek ağır bana, sevgin öyle uzaklarda, nefes alsan da yanımda. 
Bu aşk fazla sana, bu aşk fazla sana.'

DECLARE @LEN1 AS INT
DECLARE @LEN2 AS INT
SET @LEN1 = LEN(@CUMLE) 
SET @CUMLE = REPLACE(@CUMLE, 'Nasıl', '')
SET @LEN2 = LEN(@CUMLE) 
SELECT (@LEN1 - @LEN2) / LEN('Nasıl')

SET @CUMlE=REPLACE(@CUMLE, 'Aşk', 'Kev')
SELECT @CUMLE
