INSERT INTO CD-диск(ID (PK), Исполнитель, Название, Дата_выпуска, Издатель, Общая_длительность, Жанр, Альбом, Дата_записи, Цифровая_копия, Дата_поступления_в_библиотеку, Тираж)
VALUES
('Therion', 'Vovin', '11.12.1998', 'IROND', '01:20', 'Классичекая музыка', 'Therion. Vovin', '01.12.1996', NULL, '06.10.2000', 200),
('Antonio Pappano', 'Greem', '02.02.2000', 'Graciya', '02:02', 'Классичекая музыка', 'Greem Anmon', '01.01.2000', NULL, '06.10.2000', 1210),
('Antonio Vivaldi', 'Vovdin', '11.11.1999', 'Kkk', '03:14', 'Классичекая музыка', 'Tin', '01.04.1997', NULL, '14.11.2001', 10),
('Arnold Bax', 'Violin Sonatas', '11.12.1998', 'IROND', '00:20', 'Классичекая музыка', 'Rhein', '01.04.1997', NULL, '28.02.2001', 130),
('Thelin', 'Sonatas', '11.10.1995', 'IROND', '01:20', 'Классичекая музыка', 'Thein', '01.04.1994', NULL, '22.10.2002', 110),

INSERT INTO Грампластинка(ID (PK), Исполнитель, Название, Дата_выпуска, Дата_записи, Дата_поступления_в_библиотеку, Альбом, Название_музыкального_произведения, Тип, Издатель, Длительность, Типоразмер, Формат_записи, Жанр, Цифровая_копия, Тираж)
VALUES
('Давид Манукян', 'Перезвон колоколов', '11.12.1956', '10.11.1956', '23.10.1998', 'Новогодний', 'Новый год', '', NULL, '06.10.2000', 200),
('Antonio Pappano', 'Greem', '02.02.2000', 'Graciya', '02:02', 'Классичекая музыка', 'Greem Anmon', '01.01.2000', NULL, '06.10.2000', 1210),
('Antonio Vivaldi', 'Vovdin', '11.11.1999', 'Kkk', '03:14', 'Классичекая музыка', 'Tin', '01.04.1997', NULL, '14.11.2001', 10),
('Arnold Bax', 'Violin Sonatas', '11.12.1998', 'IROND', '00:20', 'Классичекая музыка', 'Rhein', '01.04.1997', NULL, '28.02.2001', 130),
('Thelin', 'Sonatas', '11.10.1995', 'IROND', '01:20', 'Классичекая музыка', 'Thein', '01.04.1994', NULL, '22.10.2002', 110),


INSERT INTO Нотное_издание(ID (PK), Заглавие, Издательство, Год_издания, Тираж, Авторы_составители, Список_композиций, Жанр, Список_композиторов, Место_выпуска, Сведения_о_средствах_исполнения, Количество_актов, На_руках)
VALUES
('Therion', 'Vovin', '11.12.1998', 'IROND', '01:20', 'Классичекая музыка', 'Therion. Vovin', '01.12.1996', NULL, '06.10.2000', 200),
('Antonio Pappano', 'Greem', '02.02.2000', 'Graciya', '02:02', 'Классичекая музыка', 'Greem Anmon', '01.01.2000', NULL, '06.10.2000', 1210),
('Antonio Vivaldi', 'Vovdin', '11.11.1999', 'Kkk', '03:14', 'Классичекая музыка', 'Tin', '01.04.1997', NULL, '14.11.2001', 10),
('Arnold Bax', 'Violin Sonatas', '11.12.1998', 'IROND', '00:20', 'Классичекая музыка', 'Rhein', '01.04.1997', NULL, '28.02.2001', 130),
('Thelin', 'Sonatas', '11.10.1995', 'IROND', '01:20', 'Классичекая музыка', 'Thein', '01.04.1994', NULL, '22.10.2002', 110),

INSERT INTO Посетитель(ID (PK), Фамилия, Имя, Отчество, Дата_рождения, Адрес_проживания, Номер_телефона, Адрес_электронной_почты, Пол)
VALUES
('Никитин', 'Дмитрий', 'Олегович', '89376439848', 'муж', '24.01.1993', 'nikitindm@ya.ru', '2489 245913', 15000, 'работает'),
('Яковлев', 'Кирилл', 'Дмитриевич', '89379287654', 'муж', '09.02.2000', 'generatorkills@gmail.com', '1128 152905', 45000, 'работает'),
('Ховрашев', 'Дмитрий', 'Денисович', '89271347010', 'муж', '22.01.2001', 'diman282@ya.ru', '1054 199423', 13000, 'в отпуске'),
('Мортов', 'Денис', 'Олегович', '89379111994', 'муж', '13.02.2000', 'mortaga@ya.ru', '1391 909432', 30000, 'на больничном'),
('Панкова', 'Екатерина', 'Игоревна', '89372413421', 'жен', '11.12.1999', 'katyapankova@mail.ru', '1143 905432', 14500, 'в командировке'),
('Вербина', 'Дарья', 'Евгеньевна', '89379047583', 'жен', '13.05.1999', 'dashaverb13@ya.ru', '9205 055113', 15530, 'работает'),
('Гордеев', 'Николай', 'Петрович', '89379038511', 'муж', '06.09.1990', 'gordeev1990bad@ya.ru', '1943 100415', 65000, 'в отпуске')

INSERT INTO Сотрудник(ID (PK), Фамилия, Имя, Отчество, Дата_рождения, Адрес_проживания, Номер_телефона, Адрес_электронной_почты, Пол, Должность, Дата_трудоустройства)
VALUES
(1, 2, 1, 1, 10013, 130116, NULL, '02.10.2000'),
(3, 4, 2, 2, 7399, 192054, NULL, '06.06.2004'),
(4, 3, 5, 3, 17792, 2505436, NULL, '23.01.2019'),
(5, 1, 3, 3, 89792, 1305143, NULL, '19.03.2017'),
(2, 5, 4, 3, 73715, 8361363, NULL, '09.09.2008'),
(3, 2, 3, 3, 18323, 1137163, NULL, '22.02.2011'),
(1, 4, 5, 3, 13234, 6543134, NULL, '08.08.2019')

INSERT INTO Акт_прослушивания_CD_диска(ID (PK), Дата_прослушивания, Длительность_сеанса, Номер_читального_зала, CD_диск, Посетитель, Сотрудник)
VALUES
(1, 2, 1, 1, 13013, 260146, NULL, '01.09.2003'),
(3, 4, 2, 2, 1399, 242164, NULL, '28.03.2007'),
(4, 3, 5, 3, 9472, 274924, NULL, '19.12.2013'),
(2, 1, 3, 3, 19792, 1305143, NULL, '01.01.2019')

INSERT INTO Акт_прослушивания_Грампластинки(ID (PK), Дата_прослушивания, Длительность_сеанса, Номер_читального_зала, Грампластинка, Посетитель, Сотрудник)
VALUES
(1, 2, 3, 1, 2245, 10300, NULL, '12.11.2019', '12.12.2019'),
(2, 3, 1, 2, 1634, 9200, NULL, '09.11.2019', '09.01.2020'),
(5, 2, 3, 4, 5634, 19450, NULL, '22.11.2019', '22.12.2019'),
(1, 5, 2, 3, 1164, 32241, NULL, '14.11.2019', '14.01.2020')

INSERT INTO Выдача_нотного_издания(ID (PK), Дата_выдачи, Дата_предполагаемого_возврата, Дата_реального_возврата, Сотрудник, Нотное_издание, Посетитель)
(1, 2, 3, 1, 2245, 10300, NULL, '12.11.2019', '12.01.2020'),
(2, 3, 1, 2, 1634, 9200, NULL, '09.11.2019', '09.12.2019'),
(5, 2, 3, 4, 5634, 19450, NULL, '22.11.2019', '22.12.2019'),
(1, 5, 2, 3, 1164, 32241, NULL, '14.11.2019', '14.12.2019')