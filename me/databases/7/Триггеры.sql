--/----------------------------------------------------------------------------
-- 1. Уведомить о добавлении нового клиента.
--/----------------------------------------------------------------------------

CREATE TRIGGER Уведомить_о_добавлении_нового_клиента
ON Клиент
AFTER INSERT
AS
BEGIN
	PRINT(N'В базу добавлен новый клиент.')
END

--/----------------------------------------------------------------------------
-- 2. Если при добавлении клиента у него нет отчества, то вывести
--    сообщение об этом.
--/----------------------------------------------------------------------------

CREATE TRIGGER Уведомить_о_добавлении_клиента_без_отчества
ON Клиент
AFTER INSERT
AS
BEGIN
	DECLARE @Отчество nvarchar(20);
	SET @Отчество = (SELECT Отчество FROM inserted)

	IF (@Отчество IS NULL)
	BEGIN
		PRINT(N'У только что добавленного клиента нет отчества.')
	END
END

--/----------------------------------------------------------------------------
-- 3. Нельзя добавить клиента, если в базе уже есть клиент с теми же
--    паспортными данными.
--/----------------------------------------------------------------------------

CREATE TRIGGER Добавление_клиента_с_уже_существующими_паспортными_данными
ON Клиент
AFTER INSERT
AS BEGIN
	IF EXISTS(SELECT * FROM inserted
	    WHERE EXISTS(SELECT * FROM Клиент
		             WHERE Клиент.Паспортные_данные = inserted.Паспортные_данные AND Клиент.ID != inserted.ID))
	BEGIN
		ROLLBACK TRAN
		RAISERROR(N'Паспортные данные клиента уже зарегестрированы в базе.', 1, 1)
	END
END

--/----------------------------------------------------------------------------
-- 4. Обновлять информацию о помещении можно только, если оно не доступно
--    для покупки.
--/----------------------------------------------------------------------------

CREATE TRIGGER Обновлять_помещение_можно_только_если_но_не_доступно_для_покупки
ON Помещение
AFTER UPDATE
AS BEGIN
	IF EXISTS(SELECT inserted.Доступно_для_покупки AS inserted_Доступно_для_покупки,
	                 deleted.Доступно_для_покупки AS deleted_Доступно_для_покупки
	                 FROM deleted JOIN inserted ON deleted.ID = inserted.ID
	                 WHERE inserted.Доступно_для_покупки = 0 AND deleted.Доступно_для_покупки = 0)
	BEGIN
		ROLLBACK TRAN
		RAISERROR(N'Обновлять информацию о помещении можно только, если оно не доступно для покупки.', 1, 1)
	END
END

--/----------------------------------------------------------------------------
-- 5. Обновлять информацию о земельном участке можно только, если оно не
--    доступно для покупки.
--/----------------------------------------------------------------------------

CREATE TRIGGER Обновлять_земельный_участок_можно_только_если_но_не_доступно_для_покупки
ON Земельный_участок
AFTER UPDATE
AS BEGIN
	IF EXISTS(SELECT inserted.Доступно_для_покупки AS inserted_Доступно_для_покупки,
	                 deleted.Доступно_для_покупки AS deleted_Доступно_для_покупки
	                 FROM deleted JOIN inserted ON deleted.ID = inserted.ID
	                 WHERE inserted.Доступно_для_покупки = 0 AND deleted.Доступно_для_покупки = 0)
	BEGIN
		ROLLBACK TRAN
		RAISERROR(N'Обновлять информацию о земельном участке можно только, если оно не доступно для покупки.', 1, 1)
	END
END

--/----------------------------------------------------------------------------
-- 6. Нельзя удалять запись о купле-продаже помещения.
--/----------------------------------------------------------------------------

CREATE TRIGGER Нельзя_удалять_запись_о_купле_продаже_помещения
ON Купля_продажа_помещения
INSTEAD OF DELETE
AS BEGIN
	PRINT(N'Удаление записи о купле-продаже помещения не допускается.')
END

--/----------------------------------------------------------------------------
-- 7. Нельзя удалять запись о купле-продаже земельного участка.
--/----------------------------------------------------------------------------

CREATE TRIGGER Нельзя_удалять_запись_о_купле_продаже_земельного_участка
ON Купля_продажа_земельного_участка
INSTEAD OF DELETE
AS BEGIN
	PRINT(N'Удаление записи о купле-продаже земельного участка не допускается.')
END

--/----------------------------------------------------------------------------
-- 8. Вывести оповещение об изменении зарплаты сотрудника.
--/----------------------------------------------------------------------------

CREATE TRIGGER Оповещение_об_изменении_зарплаты_сотрудника
ON Сотрудник
AFTER UPDATE
AS BEGIN
	IF EXISTS(SELECT inserted.Заработная_плата AS inserted_Заработная_плата,
		             deleted.Заработная_плата AS deleted_Заработная_плата
                  FROM inserted JOIN deleted
                  ON inserted.Заработная_плата != deleted.Заработная_плата)
	BEGIN
		PRINT(N'Заработные платы сотрудников изменены.')
	END
END

--/----------------------------------------------------------------------------
-- 9. Запрет на изменение паспортных данных клиентов.
--/----------------------------------------------------------------------------

CREATE TRIGGER Запрет_на_изменение_паспортных_данных_клиентов
ON Клиент
AFTER UPDATE
AS BEGIN
	IF ((SELECT Паспортные_данные FROM inserted) != (SELECT Паспортные_данные FROM deleted))
	BEGIN
		ROLLBACK TRAN
		RAISERROR(N'Запрещено обновлять паспортные данные клиентов.', 1, 1)
	END
END

--/----------------------------------------------------------------------------
-- 10. Запрет на изменение паспортных данных сотрудников.
--/----------------------------------------------------------------------------

CREATE TRIGGER Запрет_на_изменение_паспортных_данных_сотрудников
ON Сотрудник
AFTER UPDATE
AS BEGIN
	IF ((SELECT Паспортные_данные FROM inserted) != (SELECT Паспортные_данные FROM deleted))
	BEGIN
		ROLLBACK TRAN
		RAISERROR(N'Запрещено обновлять паспортные данные сотрудников.', 1, 1)
	END
END

--/----------------------------------------------------------------------------
-- 11. Запрет на изменение зарплаты сотрудников, которые находятся в отпуске.
--/----------------------------------------------------------------------------

CREATE TRIGGER Запрет_на_изменение_зарплаты_сотрудников_находящихся_в_отпуске
ON Сотрудник
AFTER UPDATE
AS BEGIN
	IF ((SELECT Заработная_плата FROM inserted WHERE Статус = 'в отпуске') !=
		(SELECT Заработная_плата FROM deleted  WHERE Статус = 'в отпуске'))
	BEGIN
		ROLLBACK TRAN
		RAISERROR(N'Запрещено обновлять зарплату сотрудников, находящихся в отпуске.', 1, 1)
	END
END
