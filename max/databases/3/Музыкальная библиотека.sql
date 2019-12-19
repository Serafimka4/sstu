CREATE DATABASE Музыкальная_библиотека
COLLATE Cyrillic_General_CI_AS
GO

USE Музыкальная_библиотека;

CREATE TABLE CD_диск(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Исполнитель nvarchar(30) NOT NULL,
	Название nvarchar(30) NOT NULL,
	Дата_выпуска date NOT NULL,
	Издатель nvarchar(39) NOT NULL,
	Общая_длительность int NOT NULL,
	Жанр nvarchar(20) NOT NULL,
	Альбом nvarchar(11) NOT NULL,
	Дата_записи date NULL,
	Цифровая_копия binary(2048) NULL,
	Дата_поступления_в_библиотеку date NOT NULL,
	Тираж int NOT NULL
)

CREATE TABLE Грампластинка(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Исполнитель nvarchar(30) NOT NULL,
	Название nvarchar(30) NOT NULL,
	Дата_выпуска date NOT NULL,
	Дата_записи date NOT NULL,
	Дата_поступления_в_библиотеку date NOT NULL,
	Альбом nvarchar(30) NOT NULL,
	Название_музыкального_произведения nvarchar(30) NOT NULL,
	Тип nvarchar(20) NOT NULL,
	Издатель nvarchar(20) NOT NULL,
	Длительность int NOT NULL,
	Типоразмер nvarchar(20) NOT NULL,
	Формат_записи nvarchar(20) NOT NULL,
	Жанр nvarchar(20) NOT NULL,
	Цифровая_копия binary(2048) NULL,
	Тираж int NOT NULL
)

CREATE TABLE Нотное_издание(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Заглавие nvarchar(30) NOT NULL,
	Издательство nvarchar(30) NOT NULL,
	Дата_издания date NOT NULL,
	Тираж int NOT NULL,
	Авторы_составители nvarchar(128) NOT NULL,
	Жанр nvarchar(30) NOT NULL,
	Место_выпуска nvarchar(20) NOT NULL,
	Сведения_о_средствах_исполнения nvarchar(20) NOT NULL,
	Количество_актов int NOT NULL,
	На_руках bit NOT NULL
)

CREATE TABLE Посетитель(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Фамилия nvarchar(20) NOT NULL,
	Имя nvarchar(20) NOT NULL,
	Отчество nvarchar(20) NOT NULL,
	Дата_рождения date NOT NULL,
	Адрес_проживания nvarchar(40) NULL,
	Номер_телефона char(11) NOT NULL,
	Адрес_электронной_почты char(20) NOT NULL,
	Пол char(3) NOT NULL
)

CREATE TABLE Сотрудник(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Фамилия nvarchar(20) NOT NULL,
	Имя nvarchar(20) NOT NULL,
	Отчество nvarchar(20) NOT NULL,
	Дата_рождения date NOT NULL,
	Адрес_проживания nvarchar(40) NULL,
	Номер_телефона char(11) NOT NULL,
	Адрес_электронной_почты char(20) NOT NULL,
	Пол char(3) NOT NULL,
	Должность nvarchar(20) NOT NULL,
	Дата_трудоустройства date NOT NULL
)

CREATE TABLE Акт_прослушивания_CD_диска(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	CD_диск int NOT NULL,
	Посетитель int NOT NULL,
	Сотрудник int NOT NULL,
	Дата_прослушивания date NOT NULL,
	Длительность_сеанса int NOT NULL,
	Номер_читального_зала int NOT NULL,

	FOREIGN KEY (Посетитель) REFERENCES Посетитель(ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE,

	FOREIGN KEY (Сотрудник) REFERENCES Сотрудник(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (CD_диск) REFERENCES CD_диск(ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE
)

CREATE TABLE Акт_прослушивания_грампластинки(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Грампластинка int NOT NULL,
	Посетитель int NOT NULL,
	Сотрудник int NOT NULL,
	Дата_прослушивания date NOT NULL,
	Длительность_сеанса int NOT NULL,
	Номер_читального_зала int NOT NULL,

	FOREIGN KEY (Посетитель) REFERENCES Посетитель(ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE,

	FOREIGN KEY (Сотрудник) REFERENCES Сотрудник(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Грампластинка) REFERENCES Грампластинка(ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE
)

CREATE TABLE Выдача_нотного_издания(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Нотное_издание int NOT NULL,
	Посетитель int NOT NULL,
	Сотрудник int NOT NULL,
	Дата_выдачи date NOT NULL,
	Дата_предполагаемого_возврата date NOT NULL,
	Дата_реального_возврата date NULL,

	FOREIGN KEY (Посетитель) REFERENCES Посетитель(ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE,

	FOREIGN KEY (Сотрудник) REFERENCES Сотрудник(ID)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,

	FOREIGN KEY (Нотное_издание) REFERENCES Нотное_издание(ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE
)

ALTER TABLE CD_диск
ADD CHECK (Дата_выпуска <= Дата_поступления_в_библиотеку)

ALTER TABLE CD_диск
ADD CHECK (Дата_записи <= Дата_выпуска)

ALTER TABLE CD_диск
ADD CHECK (Общая_длительность > 0)

ALTER TABLE CD_диск
ADD CHECK (Тираж > 0)

ALTER TABLE Грампластинка
ADD CHECK (Дата_выпуска <= Дата_поступления_в_библиотеку)

ALTER TABLE Грампластинка
ADD CHECK (Дата_записи <= Дата_выпуска)

ALTER TABLE Грампластинка
ADD CHECK (Длительность > 0)

ALTER TABLE Грампластинка
ADD CHECK (Тираж > 0)

ALTER TABLE Грампластинка
ADD CHECK (Тип IN ('жесткая', 'гибкая', 'сувенирная', 'кустарная'))

ALTER TABLE Грампластинка
ADD CHECK (Типоразмер IN ('гигант', 'гранд', 'миньон'))

ALTER TABLE Грампластинка
ADD CHECK (Формат_записи IN ('монофоническая', 'стенофоническая', 'квадрофоническая'))

ALTER TABLE Нотное_издание
ADD CHECK (Тираж > 0)

ALTER TABLE Нотное_издание
ADD CHECK (Сведения_о_средствах_исполнения IN ('для виолончели', 'для фортепиано', 'для скрипки'))

ALTER TABLE Нотное_издание
ADD CHECK (Количество_актов > 0)

ALTER TABLE Посетитель
ADD CHECK (Пол IN ('муж', 'жен'))

-- Номер мобильного телефона должен быть в формате "89371234567".
ALTER TABLE Посетитель
ADD CHECK (Номер_телефона LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

-- Адрес электронной почты должен быть в формате "example@mail.ru".
ALTER TABLE Посетитель
ADD CHECK (Адрес_электронной_почты LIKE '%@%.%')

ALTER TABLE Сотрудник
ADD CHECK (Пол IN ('муж', 'жен'))

ALTER TABLE Сотрудник
ADD CHECK (Номер_телефона LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

ALTER TABLE Сотрудник
ADD CHECK (Адрес_электронной_почты LIKE '%@%.%')

-- Все сотрудники должны быть старше 18 лет.
ALTER TABLE Сотрудник
ADD CHECK (Дата_рождения <= DATEADD(YEAR, -18, GETDATE()))

ALTER TABLE Сотрудник
ADD CHECK (Дата_рождения < Дата_трудоустройства)

ALTER TABLE Акт_прослушивания_CD_диска
ADD CHECK (Номер_читального_зала >= 0 AND Номер_читального_зала <= 5)

ALTER TABLE Акт_прослушивания_CD_диска
ADD CHECK (Длительность_сеанса > 0)

ALTER TABLE Акт_прослушивания_грампластинки
ADD CHECK (Номер_читального_зала >= 0 AND Номер_читального_зала <= 5)

ALTER TABLE Акт_прослушивания_грампластинки
ADD CHECK (Длительность_сеанса > 0)
