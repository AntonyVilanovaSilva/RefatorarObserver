CREATE DATABASE BDObserver
go
USE BDObserver
go

CREATE TABLE Produto(
   Codigo int identity (1,1) primary key,
   Nome varchar(100) not null,
   Preco decimal default 0,
   PermitirEmMassa bit default 0
)
go

--alter table Produto add PermitirEmMassa bit default 0

INSERT Produto (Nome, Preco, PermitirEmMassa) 
            values ('Banana1',10.0,0)
INSERT Produto (Nome, Preco, PermitirEmMassa) 
            values ('Maçã',20.00,1)
INSERT Produto (Nome, Preco, PermitirEmMassa) 
	        values ('Uva',30.00,1)

SELECT * FROM Produto