CREATE DATABASE Агенство_недвижимости
COLLATE Cyrillic_General_CI_AS
GO

USE Агенство_недвижимости;

--=============================================================
--
-- 1. Создание таблиц
--
--=============================================================

CREATE TABLE Клиент(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Фамилия nvarchar(20) NOT NULL,
	Имя nvarchar(20) NOT NULL,
	Отчество nvarchar(20) NULL,
	Номер_мобильного_телефона char(11) NOT NULL,
	Пол nchar(3) NOT NULL,
	Дата_рождения date NOT NULL,
	Адрес_электронной_почты nvarchar(50) NOT NULL,
	Паспортные_данные char(11) NOT NULL
)

CREATE TABLE Земельный_участок(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Владелец int NOT NULL,
	Адрес nchar(100) NOT NULL,
	Доступно_для_покупки bit NOT NULL,
	Кадастровый_номер nchar(15) NOT NULL,
	Кадастровая_стоимость money NOT NULL,
	Площадь int NOT NULL,

	FOREIGN KEY (Владелец) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
)

CREATE TABLE Помещение(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Владелец int NOT NULL,
	Адрес nchar(100) NOT NULL,
	Доступно_для_покупки bit NOT NULL,
	Кадастровый_номер nchar(15) NOT NULL,
	Стоимость money NOT NULL,
	Тип nchar(30) NOT NULL,
	Количество_комнат int NULL,
	Жилплощадь int NULL,
	Общая_площадь int NOT NULL,

	FOREIGN KEY (Владелец) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
)

CREATE TABLE Сотрудник(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Фамилия nvarchar(20) NOT NULL,
	Имя nvarchar(20) NOT NULL,
	Отчество nvarchar(20) NULL,
	Номер_мобильного_телефона char(11) NOT NULL,
	Пол nchar(3) NOT NULL,
	Дата_рождения date NOT NULL,
	Адрес_электронной_почты nvarchar(50) NOT NULL,
	Паспортные_данные char(11) NOT NULL,
	Заработная_плата money NOT NULL,
	Статус nvarchar(20) NOT NULL
)

CREATE TABLE Купля_продажа_помещения(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Продавец int NOT NULL,
	Покупатель int NOT NULL,
	Сотрудник int NOT NULL,
	Помещение int NOT NULL,
	Выручка money NOT NULL,
	Стоимость money NOT NULL,
	Электронная_копия_договора binary(4096) NULL,
	Дата_заключения_договора date NOT NULL,

	FOREIGN KEY (Продавец) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Покупатель) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Сотрудник) REFERENCES Сотрудник(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Помещение) REFERENCES Помещение(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
)

CREATE TABLE Купля_продажа_земельного_участка(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Продавец int NOT NULL,
	Покупатель int NOT NULL,
	Сотрудник int NOT NULL,
	Земельный_участок int NOT NULL,
	Выручка money NOT NULL,
	Стоимость money NOT NULL,
	Электронная_копия_договора binary(4096) NULL,
	Дата_заключения_договора date NOT NULL,

	FOREIGN KEY (Продавец) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Покупатель) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Сотрудник) REFERENCES Сотрудник(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Земельный_участок) REFERENCES Земельный_участок(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
)

CREATE TABLE Аренда_помещения(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Арендатор int NOT NULL,
	Арендодатель int NOT NULL,
	Сотрудник int NOT NULL,
	Помещение int NOT NULL,
	Выручка money NOT NULL,
	Арендная_плата money NOT NULL,
	Электронная_копия_договора binary(4096) NULL,
	Дата_заключения_договора date NOT NULL,
	Дата_окончания_аренды date NOT NULL,

	FOREIGN KEY (Арендатор) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Арендодатель) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Сотрудник) REFERENCES Сотрудник(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Помещение) REFERENCES Помещение(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
)

CREATE TABLE Аренда_земельного_участка(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Арендатор int NOT NULL,
	Арендодатель int NOT NULL,
	Сотрудник int NOT NULL,
	Земельный_участок int NOT NULL,
	Выручка money NOT NULL,
	Арендная_плата money NOT NULL,
	Электронная_копия_договора binary(4096) NULL,
	Дата_заключения_договора date NOT NULL,
	Дата_окончания_аренды date NOT NULL,

	FOREIGN KEY (Арендатор) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Арендодатель) REFERENCES Клиент(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Сотрудник) REFERENCES Сотрудник(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Земельный_участок) REFERENCES Земельный_участок(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
)

--=============================================================
--
-- 2. Создание ограничений на столбцы таблиц.
--
--=============================================================

--/------------------------------------------------------------
-- Ограничения сущности "Клиент"
--/------------------------------------------------------------

ALTER TABLE Клиент
ADD
CHECK (Пол IN ('муж', 'жен'))

-- Номер мобильного телефона должен быть в формате "89371234567".
ALTER TABLE Клиент
ADD
CHECK (Номер_мобильного_телефона LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

-- Все клиенты должны быть старше 18 лет.
ALTER TABLE Клиент
ADD
CHECK (Дата_рождения <= DATEADD(YEAR, -18, GETDATE()))

-- Паспортные данные должны быть в формате "<СЕРИЯ, 4 цифры> <НОМЕР, 6 цифр>".
ALTER TABLE Клиент
ADD
CHECK (Паспортные_данные LIKE '[0-9][0-9][0-9][0-9] [0-9][0-9][0-9][0-9][0-9][0-9]')

-- Адрес электронной почты должен быть в формате "example@mail.ru".
ALTER TABLE Клиент
ADD
CHECK (Адрес_электронной_почты LIKE '%@%.%')

--/------------------------------------------------------------
-- Ограничения сущности "Земельный участок"
--/------------------------------------------------------------

-- Кадастровый номер имеет вид "АА:ВВ:СССССС:КК".
ALTER TABLE Земельный_участок
ADD
CHECK (Кадастровый_номер LIKE '[0-9][0-9]:[0-9][0-9]:[0-9][0-9][0-9][0-9][0-9][0-9]:[0-9][0-9]')

ALTER TABLE Земельный_участок
ADD
CHECK (Кадастровая_стоимость > 0)

ALTER TABLE Земельный_участок
ADD
CHECK (Площадь > 0)

--/------------------------------------------------------------
-- Ограничения сущности "Помещение"
--/------------------------------------------------------------

-- Кадастровый номер имеет вид "АА:ВВ:СССССС:КК".
ALTER TABLE Помещение
ADD
CHECK (Кадастровый_номер LIKE '[0-9][0-9]:[0-9][0-9]:[0-9][0-9][0-9][0-9][0-9][0-9]:[0-9][0-9]')

ALTER TABLE Помещение
ADD
CHECK (Стоимость > 0)

ALTER TABLE Помещение
ADD
CHECK (Тип IN ('офисное', 'складское', 'коммунально-бытовое', 'производственное', 'свободного назначения'))

ALTER TABLE Помещение
ADD
CHECK (Количество_комнат > 0)

ALTER TABLE Помещение
ADD
CHECK (Общая_площадь > 0)

ALTER TABLE Помещение
ADD
CHECK (Жилплощадь > 0)

ALTER TABLE Помещение
ADD
CHECK (Общая_площадь >= Жилплощадь)

--/------------------------------------------------------------
-- Ограничения сущности "Сотрудник"
--/------------------------------------------------------------

ALTER TABLE Сотрудник
ADD
CHECK (Пол IN ('муж', 'жен'))

-- Номер мобильного телефона должен быть в формате "89371234567".
ALTER TABLE Сотрудник
ADD
CHECK (Номер_мобильного_телефона LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

-- Все сотрудники должны быть старше 18 лет.
ALTER TABLE Сотрудник
ADD
CHECK (Дата_рождения <= DATEADD(YEAR, -18, GETDATE()))

-- Паспортные данные должны быть в формате "<СЕРИЯ, 4 цифры> <НОМЕР, 6 цифр>".
ALTER TABLE Сотрудник
ADD
CHECK (Паспортные_данные LIKE '[0-9][0-9][0-9][0-9] [0-9][0-9][0-9][0-9][0-9][0-9]')

-- Адрес электронной почты должен быть в формате "example@mail.ru".
ALTER TABLE Сотрудник
ADD
CHECK (Адрес_электронной_почты LIKE '%@%.%')

ALTER TABLE Сотрудник
ADD
CHECK (Заработная_плата > 0)

ALTER TABLE Сотрудник
ADD
CHECK (Статус IN ('работает', 'в отпуске', 'на больничном', 'в командировке'))

--/------------------------------------------------------------
-- Ограничения сущности "Купля_продажа_помещения"
--/------------------------------------------------------------

ALTER TABLE Купля_продажа_помещения
ADD
CHECK (Выручка > 0)

ALTER TABLE Купля_продажа_помещения
ADD
CHECK (Стоимость > 0)

--/------------------------------------------------------------
-- Ограничения сущности "Купля_продажа_земельного_участка"
--/------------------------------------------------------------

ALTER TABLE Купля_продажа_земельного_участка
ADD
CHECK (Выручка > 0)

ALTER TABLE Купля_продажа_земельного_участка
ADD
CHECK (Стоимость > 0)

--/------------------------------------------------------------
-- Ограничения сущности "Аренда_помещения"
--/------------------------------------------------------------

ALTER TABLE Аренда_помещения
ADD
CHECK (Выручка > 0)

ALTER TABLE Аренда_помещения
ADD
CHECK (Арендная_плата > 0)

ALTER TABLE Аренда_помещения
ADD
CHECK (Дата_заключения_договора < Дата_окончания_аренды)

--/------------------------------------------------------------
-- Ограничения сущности "Аренда_земельного_участка"
--/------------------------------------------------------------

ALTER TABLE Аренда_земельного_участка
ADD
CHECK (Выручка > 0)

ALTER TABLE Аренда_земельного_участка
ADD
CHECK (Арендная_плата > 0)

ALTER TABLE Аренда_земельного_участка
ADD
CHECK (Дата_заключения_договора < Дата_окончания_аренды)