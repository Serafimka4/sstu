--/==========================================================================
--/
--/ Задание 1
--/
--/ Создать тестовую базу данных. База данных должна состоять из 6 файлов
--/ данных и 2 файлов журнала. Файлы данных должны быть распределены
--/ между 3 файловыми группами. Установить полную модель восстановления
--/ базы данных.
--/==========================================================================

-- Документация:
--     1. О моделях восстановления: https://docs.microsoft.com/ru-ru/sql/relational-databases/backup-restore/recovery-models-sql-server?view=sql-server-ver15
--     2. О том, как их устанавливать: https://docs.microsoft.com/en-us/sql/relational-databases/backup-restore/view-or-change-the-recovery-model-of-a-database-sql-server?view=sql-server-ver15
--     3. Файловые группы и файлы: https://docs.microsoft.com/ru-ru/sql/relational-databases/databases/database-files-and-filegroups?view=sql-server-ver15

-- Создаем новую базу данных:
create database TestDB
go

-- Добавляем новую файловую группу в эту БД:
alter database TestDB
add filegroup TestDB_FileGroup_1;
go

-- Добавляем два новых файла данных в файловую группу TestDB_FileGroup_1:
alter database TestDB
add file
(
	name = TestDB_Data_FG_1_1,
	filename = 'C:\Users\Public\TestDB_Data_FG_1_1.ndf',
	size = 5MB,
	maxsize = 100MB,
	filegrowth = 5MB
),
(
	name = TestDB_Data_FG_1_2,
	filename = 'C:\Users\Public\TestDB_Data_FG_1_2.ndf',
	size = 5MB,
	maxsize = 100MB,
	filegrowth = 5MB
)
to filegroup TestDB_FileGroup_1;
go

-- Добавляем еще одну файловую группу:
alter database TestDB
add filegroup TestDB_FileGroup_2;
go

-- Добавляем два новых файла данных в файловую группу TestDB_FileGroup_2:
alter database TestDB
add file
(
	name = TestDB_Data_FG_2_1,
	filename = 'C:\Users\Public\TestDB_FG_2_1.ndf',
	size = 5MB,
	maxsize = 100MB,
	filegrowth = 5MB
),
(
	name = TestDB_Data_FG_2_2,
	filename = 'C:\Users\Public\TestDB_FG_2_2.ndf',
	size = 5MB,
	maxsize = 100MB,
	filegrowth = 5MB
)
to filegroup TestDB_FileGroup_2;
go

-- Добавляем новый файл данных в первичную (primary) файловую группу:
alter database TestDB
add file
(
	name = TestDB_Data_FG_Primary_1,
	filename = 'C:\Users\Public\TestDB_FG_Primary_1.ndf',
	size = 5MB,
	maxsize = 100MB,
	filegrowth = 5MB
)
to filegroup [primary];
go

-- Добавляем новый файл журнала в первичную файловую группу:
alter database TestDB
add log file
(
	name = TestDB_Log_1,
	filename = 'C:\Users\Public\TestDB_Log_1.ldf',
	size = 10MB,
	maxsize = 100MB,
	filegrowth = 5MB
)
to filegroup [primary];
go

-- Проверяем, какие файлы принадлежать нашей БД:
use TestDB
go

select name, physical_name
from sys.database_files;
go

-- У нас получится следующий список файлов:
--
-- 1  TestDB                    C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TestDB.mdf
-- 2  TestDB_log                C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TestDB_log.ldf
-- 3  TestDB_Data_FG_1_1        C:\Users\Public\TestDB_Data_FG_1_1.ndf
-- 4  TestDB_Data_FG_1_2        C:\Users\Public\TestDB_Data_FG_1_2.ndf
-- 5  TestDB_Data_FG_2_1        C:\Users\Public\TestDB_FG_2_1.ndf
-- 6  TestDB_Data_FG_2_2        C:\Users\Public\TestDB_FG_2_2.ndf
-- 7  TestDB_Data_FG_Primary_1  C:\Users\Public\TestDB_FG_Primary_1.ndf
-- 8  TestDB_Log_1              C:\Users\Public\TestDB_Log_1.ldf
--
-- Таким образом, в нашей базе данных 6 файлов данных и
-- еще 2 файла журнала, которые распределены между тремя
-- файловыми группами, что и требовалось выполнить
-- в задании №1.

-- И, наконец, устанавливаем полную модель восстановления базы данных:
alter database TestDB set recovery full;
go

--/==========================================================================
--/
--/ Задание 2
--/
--/ В базе данных создать тестовую таблицу с минимальным количеством
--/ столбцов (2-3). Таблица должна быть размещена в файлах только одной из
--/ файловых групп. Организовать циклическое заполнение таблицы 200000
--/ записями с произвольными значениями полей.
--/==========================================================================

-- Документация:
--
--     1. Добавление строк в таблицу с помощью цикла: https://stackoverflow.com/questions/40744518/while-loop-to-populate-a-table

-- Создаем новую таблицу, которая будет размещена
-- в файлах файловой группы TestDB_FileGroup_1.
--
-- Мы можем посмотреть, в какой файловой группе
-- размещена таблица в Management Studio в свойствах
-- таблице на вкладке „Storage”.
use TestDB;
create table students(
	Id int not null,
	Name varchar(255) not null,
	Age int not null
) on TestDB_FileGroup_1;
go

-- Добавляем 200000 записей в таблицу:
declare @index as int;
set @index = 0;

while (@index < 200000) begin
	use TestDB;
	insert into students values (@index, 'Sample Name', 18)
	set @index = @index + 1
end
go

--/==========================================================================
--/
--/ Задание 3
--/
--/ Создайте логическое устройство копирования на основе файла на жёстком
--/ диске. Название логического устройства и местоположения файла
--/ определите самостоятельно.
--/==========================================================================

-- Создаем новое логические устройство копирования.
-- Документация: https://docs.microsoft.com/ru-ru/sql/relational-databases/backup-restore/define-a-logical-backup-device-for-a-disk-file-sql-server?view=sql-server-ver15#to-define-a-logical-backup-for-a-disk-file
use TestDB;
exec sp_addumpdevice 'disk', 'TestDB_LogicalBackupDevice_0', 'C:\Users\Public\TestDB_LogicalBackupDevice_0.bak';
go

--/==========================================================================
--/
--/ Задание 4
--/
--/ Создайте снимок тестовой базы данных.
--/==========================================================================

-- Создаем снимок БД.
-- Документация: https://docs.microsoft.com/ru-ru/sql/relational-databases/databases/create-a-database-snapshot-transact-sql?view=sql-server-ver15#b-creating-a-snapshot-on-the-sales-database
create database TestDB_Snapshot on
(
	name ='TestDB',
	filename='C:\Users\Public\TestDB_Snapshot.snp'
),
(
	name ='TestDB_Data_FG_Primary_1',
	filename='C:\Users\Public\TestDB_FG_Primary_1.snp'
),
(
	name ='TestDB_Data_FG_1_1',
	filename='C:\Users\Public\TestDB_Snapshot_Data_FG_1_1.snp'
),
(
	name ='TestDB_Data_FG_1_2',
	filename='C:\Users\Public\TestDB_Snapshot_Data_FG_1_2.snp'
),
(
	name ='TestDB_Data_FG_2_1',
	filename='C:\Users\Public\TestDB_Snapshot_Data_FG_2_1.snp'
),
(
	name ='TestDB_Data_FG_2_2',
	filename='C:\Users\Public\TestDB_Snapshot_Data_FG_2_2.snp'
)
as snapshot of TestDB;
go

--/==========================================================================
--/
--/ Задание 5
--/
--/ Смоделируйте порчу данных в тестовой таблице и восстановите БД из снимка.
--/ Убедитесь в успешности восстановления БД.
--/==========================================================================

-- Моделируем порчу данных в таблице: в первые 100 записей
-- пишем в колонку с именем значение 'Bad Name'.
use TestDB;
update students
set Name = 'Bad Name'
where Id < 100;
go

-- Проверяем, что данные действительно «испортились»: у первых
-- ста строк в качестве имени будет строка 'Bad Name', у
-- последующих десяти — 'Sample Name'.
use TestDB;
select Id, Name from students
where Id < 110
go

-- Восстаналиваем БД из ранее созданного снимка.
-- Документация: https://docs.microsoft.com/ru-ru/sql/relational-databases/databases/revert-a-database-to-a-database-snapshot?view=sql-server-ver15#a-reverting-a-snapshot-on-the-adventureworks-database
use master;
restore database TestDB from
	database_snapshot = 'TestDB_Snapshot';
go

-- Проверяем, что данные действительно восстановились: у всех
-- записей в колонке с именем должна быть строка 'Sample Name'.
use TestDB;
select Id, Name from students
where Id < 110
go

--/==========================================================================
--/
--/ Задание 6
--/
--/ Создайте полную резервную копию тестовой БД в созданное
--/ логическое устройство копирования.
--/==========================================================================

-- Создаем полную резервную копию БД.
-- Документация: https://docs.microsoft.com/en-us/sql/relational-databases/backup-restore/backup-devices-sql-server?view=sql-server-ver15#LogicalBackupDevice
backup database TestDB
	to TestDB_LogicalBackupDevice_0;
go

--/==========================================================================
--/
--/ Задание 7
--/
--/ Смоделируйте потерю тестовой БД и запустите процесс восстановления из
--/ созданной полной резервной копии. Убедитесь в успешности
--/ восстановления БД.
--/==========================================================================

-- Удаляем нашу тестовую БД. Перед тем как удалить саму БД
-- нам нужно удалить её снимок.
use master;
drop database TestDB_Snapshot;
drop database TestDB;
go

-- Восстаналиваем БД из логического устройства копирования, который
-- создали ранее.
--
-- Документация: https://docs.microsoft.com/en-us/sql/relational-databases/backup-restore/backup-devices-sql-server?view=sql-server-ver15#LogicalBackupDevice
restore database TestDB
	from TestDB_LogicalBackupDevice_0;
go

--/==========================================================================
--/
--/ Задание 8
--/
--/ Внесите изменения в БД, добавив и изменив несколько строк (100−200).
--/ Создайте разностную резервную копию БД в созданном ранее
--/ логическом устройстве.
--/==========================================================================

-- Внесем изменение в БД:
use TestDB;
update students
set Name = 'Updated Name'
where Id < 100;
go

-- Создаем разностную резервную копию БД и добавляем
-- ее в то же логическое устройство, в котором мы храним
-- полную резервную копию:
--
-- Документация: https://docs.microsoft.com/ru-ru/sql/relational-databases/backup-restore/create-a-differential-database-backup-sql-server?view=sql-server-ver15#example-transact-sql
backup database TestDB
	to TestDB_LogicalBackupDevice_0
	with differential;
go

--/==========================================================================
--/
--/ Задание 9
--/
--/ Смоделируйте потерю тестовой БД и запустите процесс восстановления из
--/ созданной полной резервной копии и разностной копии. Убедитесь в
--/ успешности восстановления БД.
--/==========================================================================

-- Удаляем нашу тестовую БД.
use master;
drop database TestDB;
go

-- Восстанавливаем нашу БД, используя полную резервную копию.
-- Причем указываем norecovery, что позволяет нам
-- выполнять последующие запросы восстановления.
restore database TestDB
	from TestDB_LogicalBackupDevice_0
	with norecovery;
go

-- Теперь восстанавлием разностную резервную копию БД,
-- которая является второй по счету резервной копией
-- в устройстве TestDB_LogicalBackupDevice_0.
restore database TestDB
	from TestDB_LogicalBackupDevice_0
	with file = 2,
	recovery;
go

-- Убедимся, что БД успешно восстановлена:
use TestDB;
select Id, Name from students
where Id < 110;
go

--/==========================================================================
--/
--/ Задание 10
--/
--/ Убедитесь, что транзакции все зафиксированы. Создайте 2 резервных копий
--/ журнала транзакций тестовой БД на созданное ранее логическое устройство.
--/ Между двумя процессами резервного копирования выполните и зафиксируйте
--/ несколько простых транзакций, причем первую из них снабдите
--/ пометкой (with mark).
--/==========================================================================

-- Документация:
--
-- 1. О фиксировании транзакций: https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-transaction-transact-sql?view=sql-server-ver15#remarks
-- 2. О начале транзакций: https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-transaction-transact-sql?view=sql-server-ver15

-- Фиксируем все открытые транзации:
while (@@trancount > 0) commit transaction;
go

-- Создаем первую резервную копию файла журнала:
-- Документация: https://docs.microsoft.com/en-us/sql/t-sql/statements/backup-transact-sql?view=sql-server-ver15#backing_up_db_and_log
backup log TestDB
	to TestDB_LogicalBackupDevice_0;
go

-- Фиксируем новую транзакцию с меткой.
begin transaction [MarkedTransaction]
with mark 'Marked Transaction';
	use TestDB;
	update students
	set Name = 'New Name (the marked transaction)'
	where Id = 0;
commit transaction [MarkedTransaction];
go

-- Фиксируем новую транзакцию без метки.
begin transaction
	use TestDB;
	update students
	set Name = 'New Name (the fist non-marked transaction)'
	where Id = 1;
commit transaction
go

-- Фиксируем еще одну транзакцию без метки.
begin transaction
	use TestDB;
	update students
	set Name = 'New Name (the second non-marked transaction)'
	where Id = 2;
commit transaction
go

-- Создаем еще одну резервную копию файла журнала:
backup log TestDB
	to TestDB_LogicalBackupDevice_0;
go

--/==========================================================================
--/
--/ Задание 11
--/
--/ Смоделируйте потерю тестовой БД и запустите процесс восстановления
--/ данных на момент сбоя. Убедитесь в успешности восстановления БД.
--/==========================================================================

-- Документация:
--
-- 1. Восстановление файла журнала: https://docs.microsoft.com/en-us/sql/relational-databases/backup-restore/restore-a-transaction-log-backup-sql-server?view=sql-server-ver15#b-applying-multiple-transaction-log-backups
-- 2. Восстановление БД до момента сбоя: https://docs.microsoft.com/en-us/sql/relational-databases/backup-restore/restore-database-to-point-of-failure-full-recovery?view=sql-server-ver15

-- Удаляем нашу тестовую БД.
--
-- Перед тем как ее удалить нам нужно закрыть все
-- существующие соединения к ней. В Management Studio нужно
-- закрыть все файлы со скриптами, которые используют нашу БД
-- и создать новый файл (вылезет окошко с переподключением).
drop database TestDB;

-- Сначала восстаналиваем полную резервную копию:
restore database TestDB
	from TestDB_LogicalBackupDevice_0
	with file = 1,
	norecovery;
go

-- Затем разностную резервную копию:
restore database TestDB
	from TestDB_LogicalBackupDevice_0
	with file = 2,
	norecovery;
go

-- Затем первую резервную копию файл журнала:
restore log TestDB
	from TestDB_LogicalBackupDevice_0
	with file = 3,
	norecovery;
go

-- И последнюю:
restore log TestDB
	from TestDB_LogicalBackupDevice_0
	with file = 4,
	norecovery;
go

-- Наконец, завершаем восстановление БД.
restore database TestDB
	with recovery;
go

-- При успешном восстановлении следующий запрос должен вывести:
--
-- 0   New Name (the marked transaction)             18
-- 1   New Name (the fist non-marked transaction)    18
-- 2   New Name (the second non-marked transaction)  18
-- 3   Updated Name                                  18
-- 4   Updated Name                                  18
-- 5   Updated Name                                  18
-- 6   Updated Name                                  18
-- ...
-- 99  Updated Name                                  18
-- 100 Sample Name                                   18
-- 101 Sample Name                                   18
-- ...
use TestDB;
select * from students
where Id < 110;
go

--/==========================================================================
--/
--/ Задание 12
--/
--/ Смоделируйте потерю тестовой БД и запустите процесс восстановления
--/ данных на момент выполнения транзакции, снабженной меткой. Убедитесь
--/ в успешности восстановления БД.
--/==========================================================================

-- Удаляем нашу тестовую БД.
--
-- И снова, перед тем как ее удалить нам нужно закрыть все
-- существующие соединения к ней. В Management Studio нужно
-- закрыть все файлы со скриптами, которые используют нашу БД
-- и создать новый файл (вылезет окошко с переподключением).
drop database TestDB;

-- Сначала восстаналиваем полную резервную копию:
restore database TestDB
	from TestDB_LogicalBackupDevice_0
	with file = 1,
	norecovery;
go

-- Затем разностную резервную копию:
restore database TestDB
	from TestDB_LogicalBackupDevice_0
	with file = 2,
	norecovery;
go

-- Затем первую резервную копию файл журнала:
restore log TestDB
	from TestDB_LogicalBackupDevice_0
	with file = 3,
	norecovery,
	stopatmark = 'MarkedTransaction';
go

-- Теперь восстановливаем последнюю резервную копию журнала,
-- но не полностью, а до транзакции с нашей меткой.
--
-- Документация: https://docs.microsoft.com/en-us/sql/relational-databases/backup-restore/use-marked-transactions-to-recover-related-databases-consistently?view=sql-server-ver15#examples
restore log TestDB
	from TestDB_LogicalBackupDevice_0
	with file = 4,
	recovery,
	stopatmark = 'MarkedTransaction';
go

-- При успешном восстановлении следующий запрос должен вывести:
--
-- 0   New Name (the marked transaction)    18
-- 1   Updated Name                         18
-- 2   Updated Name                         18
-- 3   Updated Name                         18
-- 4   Updated Name                         18
-- 5   Updated Name                         18
-- 6   Updated Name                         18
-- ...
-- 99  Updated Name                         18
-- 100 Sample Name                          18
-- 101 Sample Name                          18
-- ...
use TestDB;
select * from students
where Id < 110;
go
