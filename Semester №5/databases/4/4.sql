--/==========================================================================
--/
--/ Задание 1
--/
--/ Измените, если это возможно, режим аутентификации SQL-сервера на
--/ смешанный режим.
--/==========================================================================

-- Документация: https://stackoverflow.com/questions/1393654/how-can-i-change-from-sql-server-windows-mode-to-mixed-mode-sql-server-2008

-- Меняем режим аутентификации на смешанный:
use master;
exec xp_instance_regwrite N'HKEY_LOCAL_MACHINE', 
     N'Software\Microsoft\MSSQLServer\MSSQLServer',
     N'LoginMode', REG_DWORD, 2
go

-- Устанавливаем пароль для логина `sa`:
alter login sa enable;
go
alter login sa with password = 'password';
go

--/==========================================================================
--/
--/ Задание 2
--/
--/ Создайте локальную учетную запись пользователя Windows на рабочей
--/ станции с SQL-сервером.
--/==========================================================================

-- Создадим локальную учетную запись с именем `guest`
-- и паролем `password`, следуя инструкции на сайте
-- https://support.microsoft.com/en-us/windows/create-a-local-user-or-administrator-account-in-windows-10-20de74e0-ac7f-3502-a866-32915af2a34d

--/==========================================================================
--/
--/ Задание 3
--/
--/ Разрешите вход на SQL-сервер под учётными данными созданного
--/ пользователя в режиме Windows-аутентификации. 
--/==========================================================================

-- Документация: https://stackoverflow.com/a/34716928/8086115

-- Добавляем только что созданного пользователя Windows как
-- логин SQL.
--
-- ВАЖНО!
--
-- Вместо `DESKTOP-A7GM5LG` нужно подставить имя своего ПК.
create login [DESKTOP-A7GM5LG\guest] from windows with default_database = master
go

-- Добавляем этому логину роль администратора:
alter server role [sysadmin]
	add member [DESKTOP-A7GM5LG\guest]
go

--/==========================================================================
--/
--/ Задание 4
--/
--/ Создайте логин для входа на сервер в режиме SQL-аутентификации.
--/==========================================================================

-- Документация: https://stackoverflow.com/a/34716928/8086115

-- Создаем логин sql_guest с паролем `password`:
create login sql_guest
	with password = 'password',
	check_policy = on;
go

--/==========================================================================
--/
--/ Задание 5
--/
--/ В тестовой базе данных создайте двух пользователей, соответствующих
--/ созданным ранее логинам.
--/==========================================================================

-- Документация: https://stackoverflow.com/a/1601275/8086115

-- Создаем тестовую базу данных.
create database TestDB;
go

-- Создаем пользователя для логина с Windows Autentification. 
use TestDB;
create user windows_guest_user for login [DESKTOP-A7GM5LG\guest];
go

-- Создаем пользователя для логина с SQL Autentification. 
use TestDB;
create user sql_guest_user for login sql_guest;
go

--/==========================================================================
--/
--/ Задание 6
--/
--/ Протестируйте подключение к тестовой базе данных с использованием
--/ созданных логинов. Выведите при помощи запроса название логина, который
--/ использовался при аутентификации на сервере, а также название
--/ соответствующего пользователя базы данных. 
--/==========================================================================

-- Выводим название логина:
print original_login();
go

-- Выводим пользователя базы данных:
select current_user;
go

--/==========================================================================
--/
--/ Задание 7
--/
--/ Разрешите доступ на чтение любой из таблиц первому пользователю, а
--/ второму пользователю – запуск любой созданной Вами хранимой процедуры.
--/ Протестируйте выданные разрешения. 
--/==========================================================================

-- Создаем таблицу в БД:
use TestDB;
create table students(
	Id int not null,
	Name varchar(255) not null,
	Age int not null
);
go

-- Добавляем 100 записей в таблицу:
declare @index as int;
set @index = 0;

while (@index < 100) begin
	use TestDB;
	insert into students values (@index, 'Sample Name', 18)
	set @index = @index + 1
end
go

-- Создаем хранимую процедуру:
use TestDB;
go
create procedure TestStoredProcedure as
begin
    select Id, Name from students
    where Id < 10
end;
go

-- Разрешаем пользователю sql_guest_user выполнять
-- select из всех таблиц базы данных.
--
-- Документация: https://dba.stackexchange.com/a/278789
use TestDB;
alter role db_datareader add member sql_guest_user;
go

-- Разрешаем пользователю windows_guest_user выполнять
-- любую хранимую процедуру в БД.
--
-- Документация: https://stackoverflow.com/a/9321592/8086115
create role db_executor;
grant execute to db_executor;
alter role db_executor add member windows_guest_user; 
go

-- ВАЖНО!
--
-- Последующие запросы от имени пользователя
-- `windows_guest_user` должны выполняться, когда
-- вход в SQL Server выполнен из пользователя
-- `guest` Windows, который был создан в задании №2.
--
-- Иначе SQL будет говорить, что такого пользователя
-- не существует.

-- Запрос будет выполнен успешно, так как
-- пользователь `sql_guest_user` имеет роль
-- `db_datareader`, члены которой могут
-- выполнять запросы select.
use TestDB;
execute as user = 'sql_guest_user';
select * from students;
go

-- Запрос не будет выполнен, так как у этого пользователя
-- нет прав на выполнение select.
use TestDB;
execute as user = 'windows_guest_user';
select * from students;
go

-- Запрос не будет выполнен, так как у этого пользователя
-- нет прав на выполнение хранимых процедур.
use TestDB;
execute as user = 'sql_guest_user';
exec dbo.TestStoredProcedure;
go

-- Запрос будет выполнен, так как этот пользователь
-- может выполнять хранимые процедуры.
use TestDB;
execute as user = 'windows_guest_user';
exec dbo.TestStoredProcedure;
go

--/==========================================================================
--/
--/ Задание 8
--/
--/ Создайте роль «students» и включите в неё двух созданных пользователей.
--/ Выдайте разрешение этой роли вставлять записи в ранее использованную
--/ таблицу. 
--/==========================================================================

-- Создаем роль:
use TestDB;
create role students;
go

-- Добавляем эту роль пользователю `windows_guest_user`:
use TestDB;
alter role students add member windows_guest_user;
go

-- Добавляем эту роль пользователю `sql_guest_user`:
use TestDB;
alter role students add member sql_guest_user;
go

-- Разрешаем выполнять insert в таблицу TestDB.students
-- всем пользователем с ролью `students`.
use TestDB;
grant insert on dbo.students to students;
go

--/==========================================================================
--/
--/ Задание 9
--/
--/ Задайте явный запрет вставки записи в ранее использованную таблицу
--/ второму пользователю.
--/==========================================================================

use TestDB;
deny insert on dbo.students to windows_guest_user;
go

--/==========================================================================
--/
--/ Задание 10
--/
--/ Протестируйте все ранее выданные разрешения под учётными данными
--/ обоих созданных пользователей.
--/==========================================================================

-- Тестировали в процессе выполнения работы.

--/==========================================================================
--/
--/ Задание 11
--/
--/ Создайте роль приложения с произвольным именем и выдайте этой роли
--/ разрешение на удаление и чтение записей в используемой таблице.
--/==========================================================================

-- Создаем новую роль приложения.
--
-- Документация: https://docs.microsoft.com/en-us/sql/t-sql/statements/create-application-role-transact-sql?view=sql-server-ver15#examples
create application role TestApplicationRole
	with password = 'password';
go

-- Разрешаем этой роли удалять записи в таблице TestDB.students.
use TestDB;
grant delete on dbo.students to TestApplicationRole;
go

-- Разрешаем этой роли читать из таблицы TestDB.students.
use TestDB;
grant select on dbo.students to TestApplicationRole;
go
