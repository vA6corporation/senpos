create database senpos
go

use senpos
go

create table usuarios(
codigo char(5) primary key,
id varchar(24),
pass varchar(24),
nombres varchar(24),
apellidos varchar(24),
dni char(8),
celular char(9) 
)

drop table usuarios
go

insert into usuarios values('10001', 'vampiroDx', 'x5jy977', 'kelvin edgar', 'romani ollero', '73064758', '935269601')
go

create procedure login_usuarios(@id varchar(24), @pass varchar(24), @respuesta bit output)
as
set @respuesta = (select count(*) from usuarios where id = @id and pass = @pass)
go

drop procedure login_usuarios
go

declare @respuesta int
login_usuarios 'vampiroDx', 'x5jy977', @result = @respuesta output
