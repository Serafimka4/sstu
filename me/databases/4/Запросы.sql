--/----------------------------------------------------------------------------
--/ 1. Добавление нового сотрудника (для директора).
--/----------------------------------------------------------------------------

DECLARE @имя nvarchar(20) = 'Иван',
        @фамилия nvarchar(20) = 'Иванов',
        @отчество nvarchar(20) = 'Иванович',
        @номер_мобильного_телефона char(11) = '89372294839',
        @пол nchar(3) = 'муж',
		@дата_рождения date = '02.10.2000',
		@адрес_электронной_почты nvarchar(50) = 'example@site.com',
		@паспортные_данные char(11) = '1234 123321',
		@заработная_плата money = '13500',
		@статус nvarchar(20) = 'работает'

INSERT Сотрудник(Имя, Фамилия, Отчество, Номер_мобильного_телефона, Пол, Дата_рождения, Адрес_электронной_почты, Паспортные_данные, Заработная_плата, Статус)
VALUES (@имя, @фамилия, @отчество, @номер_мобильного_телефона, @пол, @дата_рождения, @адрес_электронной_почты, @паспортные_данные, @заработная_плата, @статус)

--/----------------------------------------------------------------------------
-- 2. Удаление сотрудника из базы (для директора).
--/----------------------------------------------------------------------------

DECLARE @id int = 8
DELETE Сотрудник
WHERE ID = @id

--/----------------------------------------------------------------------------
-- 3. Добавление клиента в базу (для директора, сотрудника).
--/----------------------------------------------------------------------------

DECLARE @имя nvarchar(20) = 'Иван',
        @фамилия nvarchar(20) = 'Иванов',
        @отчество nvarchar(20) = 'Иванович',
        @номер_мобильного_телефона char(11) = '89372294839',
        @пол nchar(3) = 'муж',
		@дата_рождения date = '02.10.2000',
		@адрес_электронной_почты nvarchar(50) = 'example@site.com',
		@паспортные_данные char(11) = '1234 123321'

INSERT Клиент(Имя, Фамилия, Отчество, Номер_мобильного_телефона, Пол, Дата_рождения, Адрес_электронной_почты, Паспортные_данные)
VALUES (@имя, @фамилия, @отчество, @номер_мобильного_телефона, @пол, @дата_рождения, @адрес_электронной_почты, @паспортные_данные)

--/----------------------------------------------------------------------------
-- 4. Вывести всех сотрудников, которые находятся в отпуске (для директора).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя], Статус
FROM dbo.Сотрудник
WHERE Статус = 'в отпуске'
ORDER BY [Полное имя]

--/----------------------------------------------------------------------------
-- 5. Вывести всех сотрудников, которые находятся в командировке (для
--    директора).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя], Статус
FROM dbo.Сотрудник
WHERE Статус = 'в командировке'
ORDER BY [Полное имя]

--/----------------------------------------------------------------------------
-- 6. Вывести всех сотрудников, которые находятся на больничном (для
--    директора).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя], Статус
FROM dbo.Сотрудник
WHERE Статус = 'на больничном'
ORDER BY [Полное имя]

--/----------------------------------------------------------------------------
-- 7. Вывести всех сотрудников, которые на данный момент работают (для
--    директора).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя], Статус
FROM dbo.Сотрудник
WHERE Статус = 'работает'
ORDER BY [Полное имя]

--/----------------------------------------------------------------------------
-- 8. Вывести всех сотрудников, количество заключенных ими сделок и суммарный
--    доход, который каждый сотрудник принес фирме в виде процентов от
--    совершенных сделок по купле продаже помещений (для директора).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя],
       SUM(Выручка) AS [Принесенный фирме доход],
	   COUNT(Сотрудник) AS [Количество сделок]
FROM dbo.Купля_продажа_помещения
JOIN dbo.Сотрудник ON dbo.Купля_продажа_помещения.Сотрудник = Сотрудник.ID
GROUP BY Фамилия + ' ' + Имя + ' ' + Отчество
ORDER BY [Принесенный фирме доход] DESC

--/----------------------------------------------------------------------------
-- 9. Вывести список всех сотрудников, у которых день рождения приходится
--    на текущий месяц (для директора).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя],
       Дата_рождения AS [Дата рождения]
FROM dbo.Сотрудник
WHERE DATEPART(MM, Дата_рождения) = DATEPART(MM, GETDATE())

--/----------------------------------------------------------------------------
-- 10. Отправить сотрудника в отпуск (для директора).
--/----------------------------------------------------------------------------

DECLARE @полное_имя nvarchar(60) = 'Никитин Дмитрий Олегович'
UPDATE dbo.Сотрудник
SET Статус = 'в отпуске'
WHERE Фамилия + ' ' + Имя + ' ' + Отчество = @полное_имя

--/----------------------------------------------------------------------------
-- 11. Отправить сотрудника на больничный (для директора).
--/----------------------------------------------------------------------------

DECLARE @полное_имя nvarchar(60) = 'Никитин Дмитрий Олегович'
UPDATE dbo.Сотрудник
SET Статус = 'на больничном'
WHERE Фамилия + ' ' + Имя + ' ' + Отчество = @полное_имя

--/----------------------------------------------------------------------------
-- 12. Список всех клиентов с краткой информацией для связи (для директора,
--     сотрудника).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя], Номер_мобильного_телефона as [Телефон]
FROM dbo.Клиент
ORDER BY Фамилия

--/----------------------------------------------------------------------------
-- 13. Вывести среднюю кадастровую стоимость всех земельных участков (для
--     директора, сотрудника).
--/----------------------------------------------------------------------------

SELECT AVG(Кадастровая_стоимость) as [Средняя кадастровая стоимость земельного участка]
FROM dbo.Земельный_участок

--/----------------------------------------------------------------------------
-- 14. Вывести самое дорогое помещение в базе (для директора, клиента,
--     сотрудника).
--/----------------------------------------------------------------------------

SELECT Адрес, MAX(Стоимость) AS Стоимость
FROM dbo.Помещение
GROUP BY Адрес
ORDER BY Стоимость DESC

--/----------------------------------------------------------------------------
-- 15. Вывести 5 самых дешевых доступных для покупки помещений (для директора,
--     клиента, сотрудника).
--/----------------------------------------------------------------------------

SELECT TOP 5 Адрес, Стоимость
FROM dbo.Помещение
WHERE Доступно_для_покупки = 1
ORDER BY Стоимость

--/----------------------------------------------------------------------------
-- 16. Вывести список всех клиентов и количество помещений, которыми
--    они владеют (для директора, сотрудника).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя],
	   COUNT(Владелец) AS [Количество помещений]
FROM dbo.Помещение
JOIN dbo.Клиент ON dbo.Помещение.Владелец = Клиент.ID
GROUP BY Фамилия + ' ' + Имя + ' ' + Отчество
ORDER BY [Количество помещений] DESC

--/----------------------------------------------------------------------------
-- 17. Вывести список всех клиентов, заключавших договора по купле продаже
--    земельных участков за последний год (для директора, сотрудника).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя]
FROM dbo.Купля_продажа_земельного_участка
JOIN dbo.Сотрудник ON dbo.Купля_продажа_земельного_участка.Сотрудник = Сотрудник.ID
WHERE DATEPART(YY, Дата_заключения_договора) = DATEPART(YY, GETDATE())

--/----------------------------------------------------------------------------
-- 18. Вывести список помещений для которых в этом месяце кончается срок аренды
--     (для директора, сотрудника).
--/----------------------------------------------------------------------------

SELECT Адрес, Дата_окончания_аренды AS [Дата окончания аренды]
FROM dbo.Помещение
JOIN dbo.Аренда_помещения ON dbo.Аренда_помещения.Помещение = Помещение.ID
WHERE DATEPART(MM, Дата_окончания_аренды) = DATEPART(MM, GETDATE())

--/----------------------------------------------------------------------------
-- 19. Вывести список земельных участков, которые в данный момент арендованы
--    определенным клиентом (для директора, сотрудника).
--/----------------------------------------------------------------------------

DECLARE @полное_имя nvarchar(60) = 'Нефедов Данил Вадимович'
SELECT Адрес, Дата_окончания_аренды AS [Дата окончания аренды]
FROM dbo.Аренда_земельного_участка
JOIN dbo.Клиент ON dbo.Клиент.ID = dbo.Аренда_земельного_участка.Арендатор
JOIN dbo.Земельный_участок ON dbo.Земельный_участок.ID = dbo.Аренда_земельного_участка.Земельный_участок
WHERE Фамилия + ' ' + Имя + ' ' + Отчество = @полное_имя

--/----------------------------------------------------------------------------
-- 20. Вывести список всех арендованных на данный момент помещений
--     (для директора, сотрудника).
--/----------------------------------------------------------------------------

SELECT Адрес, Дата_окончания_аренды AS [Дата окончания аренды]
FROM dbo.Аренда_помещения
JOIN dbo.Помещение ON dbo.Аренда_помещения.Помещение = dbo.Помещение.ID
WHERE Дата_окончания_аренды > GETDATE()

--/----------------------------------------------------------------------------
-- 21. Вывести список всех арендованных на данный момент земельных участков
--     (для директора, сотрудника).
--/----------------------------------------------------------------------------

SELECT Адрес, Дата_окончания_аренды AS [Дата окончания аренды]
FROM dbo.Аренда_земельного_участка
JOIN dbo.Земельный_участок ON dbo.Аренда_земельного_участка.Земельный_участок = dbo.Земельный_участок.ID
WHERE Дата_окончания_аренды > GETDATE()

--/----------------------------------------------------------------------------
-- 22. Вывести список помещений, которые в данный момент арендованы
--    определенным клиентом (для директора, сотрудника).
--/----------------------------------------------------------------------------

DECLARE @полное_имя nvarchar(60) = 'Нефедов Данил Вадимович'
SELECT Адрес, Дата_окончания_аренды AS [Дата окончания аренды]
FROM dbo.Аренда_помещения
JOIN dbo.Клиент ON dbo.Клиент.ID = dbo.Аренда_помещения.Арендатор
JOIN dbo.Помещение ON dbo.Помещение.ID = dbo.Аренда_помещения.Помещение
WHERE Фамилия + ' ' + Имя + ' ' + Отчество = @полное_имя

--/----------------------------------------------------------------------------
-- 23. Вывести список всех клиентов и количество земельных участков, которыми
--    они владеют (для директора, сотрудника).
--/----------------------------------------------------------------------------

SELECT Фамилия + ' ' + Имя + ' ' + Отчество AS [Полное имя],
	   COUNT(Владелец) AS [Количество земельных участков]
FROM dbo.Земельный_участок
JOIN dbo.Клиент ON dbo.Земельный_участок.Владелец = Клиент.ID
GROUP BY Фамилия + ' ' + Имя + ' ' + Отчество
ORDER BY [Количество земельных участков] DESC

--/----------------------------------------------------------------------------
-- 24. Вывести список всех доступных для покупки помещений (для директора,
--     сотрудника, клиента).
--/----------------------------------------------------------------------------

SELECT Владелец, Адрес, Кадастровый_номер, Стоимость, Тип, Количество_комнат, Жилплощадь, Общая_площадь
FROM dbo.Помещение
WHERE Доступно_для_покупки = 1

--/----------------------------------------------------------------------------
-- 25. Вывести список всех доступных для покупки земельных участков (для
--     директора, сотрудника, клиента).
--/----------------------------------------------------------------------------

SELECT Владелец, Адрес, Кадастровый_номер, Кадастровая_стоимость, Площадь
FROM dbo.Земельный_участок
WHERE Доступно_для_покупки = 1

--/----------------------------------------------------------------------------
-- 26. Вывести 5 самых дешевых доступных для покупки земельных участков (для
--     директора, клиента, сотрудника).
--/----------------------------------------------------------------------------

SELECT TOP 5 Владелец, Адрес, Кадастровый_номер, Кадастровая_стоимость, Площадь
FROM dbo.Земельный_участок
WHERE Доступно_для_покупки = 1
ORDER BY Кадастровая_стоимость

--/----------------------------------------------------------------------------
-- 27. Вывести все помещения и имена их владельцев (для директора,
--     сотрудника).
--/----------------------------------------------------------------------------

SELECT Адрес, CONCAT(Фамилия, ' ', Имя, ' ', Отчество) AS [Полное имя владельца]
FROM Помещение
LEFT JOIN Клиент
ON Помещение.Владелец = Клиент.ID
