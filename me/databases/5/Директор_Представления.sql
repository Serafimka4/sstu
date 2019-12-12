--/----------------------------------------------------------------------------
-- 1. Сотрудники, которые на данный момент в отпуске.
--/----------------------------------------------------------------------------

CREATE VIEW Сотрудники_в_отпуске
AS
SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя], Статус
FROM dbo.Сотрудник
WHERE Статус = 'в отпуске'
GO

--/----------------------------------------------------------------------------
-- 2. Сотрудники, которые сейчас в командировке.
--/----------------------------------------------------------------------------

CREATE VIEW Сотрудники_в_командировке
AS
SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя], Статус
FROM dbo.Сотрудник
WHERE Статус = 'в командировке'
GO

--/----------------------------------------------------------------------------
-- 3. Сотрудники, которые сейчас на больничном.
--/----------------------------------------------------------------------------

CREATE VIEW Сотрудники_на_больничном
AS
SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя], Статус
FROM dbo.Сотрудник
WHERE Статус = 'на больничном'
GO

--/----------------------------------------------------------------------------
-- 4. Сотрудники, которые на данный момент работают.
--/----------------------------------------------------------------------------

CREATE VIEW Работающие_сотрудники
AS
SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя], Статус
FROM dbo.Сотрудник
WHERE Статус = 'работает'
GO

--/----------------------------------------------------------------------------
-- 5. Cотрудники, которые заключали договора по купле-продаже помещений
--    в текущем году.
--/----------------------------------------------------------------------------

CREATE VIEW Сотрудники_заключавшие_договора_купли_продажи_помещений_в_текущем_году
AS
SELECT DISTINCT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя]
FROM dbo.Сотрудник JOIN dbo.Купля_продажа_помещения ON dbo.Купля_продажа_помещения.Сотрудник = dbo.Сотрудник.ID
WHERE DATEPART(YY, Дата_заключения_договора) = DATEPART(YY, GETDATE())
GO