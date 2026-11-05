db_cliente---------------------------------------------------------------------------------------------------------------

use master

CREATE DATABASE db_cliente
COLLATE Latin1_General_CI_AI;
GO

use db_cliente

create table Cliente(
	Id uniqueidentifier not null primary key default newid(),
	Nome nvarchar(200) not null,
	Cartao nvarchar(200) not null 
)

insert into Cliente (Nome, Cartao) values ('Flávio Couto', 'CARD-29550C89-7587-4177-AB4C-0128F2830CA9')
insert into Cliente (Nome, Cartao) values ('Ellon Musk', 'CARD-77F67444-AE6D-48A5-B22D-C6582CACCF96')

select * from Cliente



db_produto---------------------------------------------------------------------------------------------------------------

use master

CREATE DATABASE db_produto
COLLATE Latin1_General_CI_AI;
GO

use db_produto

create table Produtos (
	Id uniqueidentifier not null primary key default newid(),
	NomeProduto nvarchar(200) not null,
	ValorProduto decimal(18,2) not null,
	EstoqueProduto int not null
)

insert into Produtos (NomeProduto, ValorProduto, EstoqueProduto) values ('Playstation 5', 5000.99, 100)
insert into Produtos (NomeProduto, ValorProduto, EstoqueProduto) values ('Xbox Series X', 7000.99, 1)
insert into Produtos (NomeProduto, ValorProduto, EstoqueProduto) values ('Nintendo Switch 2', 4000.99, 0)

select * from Produtos



db_cartao---------------------------------------------------------------------------------------------------------------

use master

CREATE DATABASE db_cartao
COLLATE Latin1_General_CI_AI;
GO

use db_cartao

create table ConsultaCartao (
	Cartao nvarchar(200) not null,
	CartaoStatus nvarchar(200) not null
)

insert into ConsultaCartao (Cartao, CartaoStatus) values ('CARD-29550C89-7587-4177-AB4C-0128F2830CA9', 'REPROVADO')
insert into ConsultaCartao (Cartao, CartaoStatus) values ('CARD-77F67444-AE6D-48A5-B22D-C6582CACCF96', 'APROVADO')

select * from ConsultaCartao



db_pedido---------------------------------------------------------------------------------------------------------------

use master

CREATE DATABASE db_pedido
COLLATE Latin1_General_CI_AI;
GO

use db_pedido

create table Pedidos(
	Id uniqueidentifier not null primary key default newid(),
	DataCadastro datetime not null default getdate(),
	StatusCadastro bit not null default 1,
	IdCliente uniqueidentifier not null,
	NomeCliente nvarchar(200) not null,
	CartaoCliente nvarchar(200) not null,
	IdProduto uniqueidentifier not null,
	NomeProduto nvarchar(200) not null,
	StatusPedido nvarchar(200) not null
)

insert into Pedidos 
(IdCliente, NomeCliente, CartaoCliente, IdProduto, NomeProduto, StatusPedido)
values
('[IdCliente]', 'Ellon Musk', 'CARD-77F67444-AE6D-48A5-B22D-C6582CACCF96', '[IdProduto]', 'Playstation 5', 'PEDIDO_AGUARDANDO_ENVIO')

select * from Pedidos