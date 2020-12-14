/*
 *
 * 1. Наглядно продемонстрировать влияние параметра xact_abort на атомарность транзакций.
 *
 */

/* Создаем новую тестовую БД. */

if object_id(N'test_db', N'U') is not null
	drop database test_db;
go

create database test_db;
go

use test_db;
go

/* Создаем две таблицы. */

if object_id(N't2', N'U') is not null
	drop table t2;
go

if object_id(N't1', N'U') is not null
	drop table t1;
go

create table t1 (a int not null primary key);
create table t2 (a int not null references t1(a));
go

/* Наполняем первую из них. */

insert into t1 values (1), (2), (3);
go

/* Пытаемся выполнить транзакцию, которая содержит
 * ошибку — foreign key error. */

set xact_abort off;

begin transaction
	insert into t2 values (1);
	insert into t2 values (-42);
commit transaction
go


select * from t2;
go

/* Снова пытаемся выполнить транзакцию, которая
 * содержит ошибку, но в этот раз xact_abort
 * установлен в on. */

set xact_abort on;

begin transaction
	insert into t2 values (2);
	insert into t2 values (-42);
commit transaction
go


select * from t2;
go

/*
 *
 * 2. Наглядно продемонстрировать явные, неявные и автоподтверждённые
 *    транзакции в обоих режимах работы сервера (режим неявного
 *    подтверждения и автоматического подтверждения).
 *
 */

while (@@trancount > 0) commit transaction;
go

/* Autocommit transaction mode. */

print @@trancount;
set implicit_transactions off;
go

select * from t1;
select * from t1;
print @@trancount;
go

begin tran
	select * from t1;
	print @@trancount;
commit

print @@trancount;

/* Implicit transaction mode. */

print @@trancount;
set implicit_transactions on;
go

select * from t1;
select * from t1;
print @@trancount;
commit
print @@trancount;
go

begin tran
	select * from t1;
	print @@trancount;
commit

print @@trancount;

commit
print @@trancount;

/*
 *
 * 3. Создать несколько подключений и наглядно продемонстрировать
 *    на них разницу между различными уровнями изолированности
 *    транзакций (5 уровней).
 *
 */

set implicit_transactions off;
go

use test_db;
create table students(
	id int not null,
	name varchar(255) not null
);
go

insert into students values (1, 'Name 1'), (2, 'Name 2');
go

/* 1. Read uncommited. */

	/* 1st connection: */

	set transaction isolation level
		read uncommitted;
	go

	begin transaction
		use test_db;
		update students
		set name = 'Updated Name 1'
		where id = 1;
	go

	rollback;
	go

	/* 2nd connection: */

	set transaction isolation level
		read uncommitted;
	go

	/* Запрос вернет 'Update Name 1'. */
	use test_db;
	select * from students;
	go

	/* Если выполнить после rollback'а в первом подключении,
	 * запрос вернет 'Name 1'. */
	use test_db;
	select * from students;
	go

/* 2. Read committed. */

	/* 1st connection: */

	set transaction isolation level
		read committed;
	go

	begin tran
	select * from students where id = 1;
	go

	select * from students where id = 1;
	commit
	go

	/* 2nd connection: */

	set transaction isolation level
		read committed;
	go

	begin trans
		update students
		set name = 'Fancy Name'
		where id = 1;
	commit
	go

/* 3. Repeatable read. */

	/* 1st connection: */

	set transaction isolation level
		repeatable read;
	go

	begin tran
	select sum(id) from students;
	go

	select sum(id) from students;
	commit
	go

	/* 2nd connection: */

	set transaction isolation level
		repeatable read;
	go

	begin tran
	insert into students values (12, 'Name');
	commit
	go

/* 4. Snapshot. */

	/* 1st connection: */

	set transaction isolation level
		snapshot;
	go

	alter database test_db
		set allow_snapshot_isolation on;
	go

	begin tran
	select sum(id) from students;
	go

	select sum(id) from students;
	commit
	go

	/* 2nd connection: */

	set transaction isolation level
		snapshot;
	go

	begin tran
	insert into students values (12, 'Name');
	commit
	go

/* 5. Serializable. */

	/* 1st connection: */

	set transaction isolation level
		serializable;
	go

	begin tran
	select sum(id) from students;
	go

	select sum(id) from students;
	commit
	go

	/* 2nd connection: */

	set transaction isolation level
		serializable;
	go

	begin tran
	insert into students values (12, 'Name');
	commit
	go

/*
 *
 * 4. Промоделировать ситуацию взаимоблокировки транзакций.
 *    Объяснить полученные результаты.
 *
 */

/* 1st query. */

create table ##t1 (
	id int not null,
	name varchar(255) not null
);
go

create table ##t2 (
	id int not null,
	name varchar(255) not null
);
go

insert into ##t1 values (1, '1');
insert into ##t2 values (2, '2');
go

/* 2nd query. */

set transaction isolation level
	read committed;
go

begin tran
insert into ##t1 values (3, '3');
go

select * from ##t2;
go

commit
go

/* 3rd query. */

set transaction isolation level
	read committed;
go

begin tran
insert into ##t2 values (4, '4');
go

select * from ##t1;
go

commit
go

/*
 *
 * 5. Наглядно продемонстрировать получение информации
 *    о текущих транзакциях и блокировках, исходя из данных
 *    системного словаря.
 *
 */

select * from sys.sysprocesses where open_tran = 1;
go
