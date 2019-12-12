INSERT INTO Клиент(Фамилия, Имя, Отчество, Номер_мобильного_телефона, Пол, Дата_рождения, Адрес_электронной_почты, Паспортные_данные)
VALUES
('Нефедов', 'Данил', 'Вадимович', '89372294839', 'муж', '02.10.2000', 'ndan@ya.ru', '6314 070135'),
('Аверин', 'Владислав', 'Евгеньевич', '89371293435', 'муж', '01.04.2000', 'averin@mail.ru', '6314 174575'),
('Погосян', 'Генрих', 'Генрихович', '89275434112', 'муж', '06.10.2000', 'henryk@gmail.com', '6313 662153'),
('Попечителева', 'Елизавета', 'Кирилловна', '89371524312', 'жен', '11.11.2001', 'elizp@mail.ru', '6314 124986'),
('Родиков', 'Максим', 'Денисович', '89379756734', 'муж', '23.01.2000', 'rodik@ya.ru', '6314 985765'),
('Прострелов', 'Михаил', 'Михаилович', '89377564332', 'муж', '14.04.2001', 'prostrelov2212@gmail.com', '6314 113895'),
('Кошкина', 'Елена', 'Викторовна', '89379004321', 'жен', '27.11.2000', 'lenakoshkina@mail.ru', '6314 925023'),
('Беляева', 'Инна', 'Андреевна', '89371245545', 'жен', '12.05.1999', 'innnabel1999@yandex.ru', '6312 142373'),
('Егорова', 'Анастасия', 'Александровна', '89371529034', 'жен', '16.12.2000', 'egorova282@ya.com', '6314 164230'),
('Козлов', 'Никита', 'Олегович', '89379139114', 'муж', '24.07.2000', 'pro100kozlov@gmail.com', '6314 934567'),
('Маяковская', 'Ангелина', 'Александровна', '89370948586', 'жен', '07.07.2000', 'angel@ya.ru', '6314 091344'),
('Никитин', 'Дмитрий', 'Геннадьевич', '89377775433', 'муж', '15.03.1998', 'dimanclass@mail.com', '6314 034135'),
('Литовкин', 'Илья', 'Романович', '89372341534', 'муж', '13.11.2001', 'iliyofficial@gmail.com', '6314 190435'),
('Курбанова', 'Руша', 'Геннадьевна', '89371832212', 'жен', '01.02.1999', 'rushacrush@ya.ru', '6314 194321'),
('Сапрыкин', 'Андрей', 'Викторович', '89371983212', 'муж', '28.04.2000', 'saprikevich@gmail.com', '6314 901234')

INSERT INTO Помещение(Владелец, Адрес, Доступно_для_покупки, Кадастровый_номер, Стоимость, Тип, Количество_комнат, Жилплощадь, Общая_площадь)
VALUES
(1, 'г. Саратов, ул. 2-ая Садовая, д. №97, кв. №811', 1, '11:23:483134:30', 135535, 'коммунально-бытовое', 1, 13, 13),
(5, 'г. Саратов, ул. 2-ая Садовая, д. №101, кв. №19', 0, '43:34:124665:14', 253103, 'коммунально-бытовое', 2, 27, 53),
(4, 'г. Саратов, ул. Вавилова, д. №7, кв. №1', 0, '23:14:154161:24', 1343103, 'коммунально-бытовое', 3, 43, 53),
(2, 'г. Саратов, ул. Политехническая, д. №21, кв. №19', 0, '43:34:124665:14', 1243131, 'офисное', NULL, NULL, 133),
(1, 'г. Саратов, ул. Строителей, д. №13, кв. №101', 1, '13:14:415834:42', 7476237, 'складское', NULL, NULL, 190),
(8, 'г. Саратов, ул. Миротворцева, д. №1, кв. №19', 1, '41:13:984643:11', 24414523, 'производственное', NULL, NULL, 351),
(3, 'г. Саратов, ул. Кирова, д. №4, кв. №2', 1, '35:94:472993:98', 9740013, 'свободного назначения', NULL, NULL, 245),
(10, 'г. Саратов, ул. Ленина, д. №11, кв. №52', 1, '98:42:186493:14', 847004614, 'складское', NULL, NULL, 241),
(5, 'г. Саратов, ул. Степана Разина, д. №9, кв. №23', 1, '45:99:193843:93', 37377145, 'офисное', NULL, NULL, 87),
(7, 'г. Саратов, ул. Карла Маркса, д. №13, кв. №101', 1, '13:14:415834:42', 7476237, 'складское', NULL, NULL, 190)

INSERT INTO Земельный_участок(Владелец, Адрес, Доступно_для_покупки, Кадастровый_номер, Кадастровая_стоимость, Площадь)
VALUES
(1, 'г. Саратов, ул. Свободы, 12', 1, '13:94:129003:13', 74728, 8238),
(2, 'г. Саратов, ул. Мирная, 4', 1, '24:10:113905:23', 24512, 4331),
(3, 'г. Саратов, ул. Яблочникова, 13', 1, '55:14:898245:10', 152600, 4056),
(4, 'г. Саратов, ул. Кислая, 93', 1, '10:14:123567:08', 9300, 2050)

INSERT INTO Сотрудник(Фамилия, Имя, Отчество, Номер_мобильного_телефона, Пол, Дата_рождения, Адрес_электронной_почты, Паспортные_данные, Заработная_плата, Статус)
VALUES
('Никитин', 'Дмитрий', 'Олегович', '89376439848', 'муж', '24.01.1993', 'nikitindm@ya.ru', '2489 245913', 15000, 'работает'),
('Яковлев', 'Кирилл', 'Дмитриевич', '89379287654', 'муж', '09.02.2000', 'generatorkills@gmail.com', '1128 152905', 45000, 'работает'),
('Ховрашев', 'Дмитрий', 'Денисович', '89271347010', 'муж', '22.01.2001', 'diman282@ya.ru', '1054 199423', 13000, 'в отпуске'),
('Мортов', 'Денис', 'Олегович', '89379111994', 'муж', '13.02.2000', 'mortaga@ya.ru', '1391 909432', 30000, 'на больничном'),
('Панкова', 'Екатерина', 'Игоревна', '89372413421', 'жен', '11.12.1999', 'katyapankova@mail.ru', '1143 905432', 14500, 'в командировке'),
('Вербина', 'Дарья', 'Евгеньевна', '89379047583', 'жен', '13.05.1999', 'dashaverb13@ya.ru', '9205 055113', 15530, 'работает'),
('Гордеев', 'Николай', 'Петрович', '89379038511', 'муж', '06.09.1990', 'gordeev1990bad@ya.ru', '1943 100415', 65000, 'в отпуске')

INSERT INTO Купля_продажа_помещения(Продавец, Покупатель, Сотрудник, Помещение, Выручка, Стоимость, Электронная_копия_договора, Дата_заключения_договора)
VALUES
(1, 2, 1, 1, 10013, 130116, NULL, '02.10.2000'),
(3, 4, 2, 2, 7399, 192054, NULL, '06.06.2004'),
(4, 3, 5, 3, 17792, 2505436, NULL, '23.01.2019'),
(5, 1, 3, 3, 89792, 1305143, NULL, '19.03.2017'),
(2, 5, 4, 3, 73715, 8361363, NULL, '09.09.2008'),
(3, 2, 3, 3, 18323, 1137163, NULL, '22.02.2011'),
(1, 4, 5, 3, 13234, 6543134, NULL, '08.08.2019')

INSERT INTO Купля_продажа_земельного_участка(Продавец, Покупатель, Сотрудник, Земельный_участок, Выручка, Стоимость, Электронная_копия_договора, Дата_заключения_договора)
VALUES
(1, 2, 1, 1, 13013, 260146, NULL, '01.09.2003'),
(3, 4, 2, 2, 1399, 242164, NULL, '28.03.2007'),
(4, 3, 5, 3, 9472, 274924, NULL, '19.12.2013'),
(2, 1, 3, 3, 19792, 1305143, NULL, '01.01.2019')

INSERT INTO Аренда_помещения(Арендатор, Арендодатель, Сотрудник, Помещение, Выручка, Арендная_плата, Электронная_копия_договора, Дата_заключения_договора, Дата_окончания_аренды)
VALUES
(1, 2, 3, 1, 2245, 10300, NULL, '12.11.2019', '12.12.2019'),
(2, 3, 1, 2, 1634, 9200, NULL, '09.11.2019', '09.01.2020'),
(5, 2, 3, 4, 5634, 19450, NULL, '22.11.2019', '22.12.2019'),
(1, 5, 2, 3, 1164, 32241, NULL, '14.11.2019', '14.01.2020')

INSERT INTO Аренда_земельного_участка(Арендатор, Арендодатель, Сотрудник, Земельный_участок, Выручка, Арендная_плата, Электронная_копия_договора, Дата_заключения_договора, Дата_окончания_аренды)
VALUES
(1, 2, 3, 1, 2245, 10300, NULL, '12.11.2019', '12.01.2020'),
(2, 3, 1, 2, 1634, 9200, NULL, '09.11.2019', '09.12.2019'),
(5, 2, 3, 4, 5634, 19450, NULL, '22.11.2019', '22.12.2019'),
(1, 5, 2, 3, 1164, 32241, NULL, '14.11.2019', '14.12.2019')