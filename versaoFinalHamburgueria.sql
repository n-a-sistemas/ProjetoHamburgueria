CREATE TABLE cliente (
cod_cliente SMALLINT IDENTITY NOT NULL,
nome_cliente VARCHAR (50),
CONSTRAINT PK_cliente
PRIMARY KEY (cod_cliente),
);

CREATE TABLE pedido (
num_pedido SMALLINT IDENTITY NOT NULL,
num_comanda SMALLINT NOT NULL,
valor_pedido DECIMAL (4,2),
observacoes TEXT,
quant_produto TINYINT NOT NULL,
num_mesa TINYINT NOT NULL,
cod_cliente SMALLINT NOT NULL,

CONSTRAINT PK_pedido
PRIMARY KEY (num_pedido),
CONSTRAINT FK_cod_cliente
FOREIGN KEY (cod_cliente)
REFERENCES cliente (cod_cliente)
);

CREATE TABLE garcom (
cod_garcom SMALLINT IDENTITY NOT NULL,
nome_garcom VARCHAR (50),
cpf_garcom BIGINT NOT NULL,
endereco_garcom VARCHAR (50),
telefone_garcom VARCHAR (14),

CONSTRAINT PK_garcom
PRIMARY KEY (cod_garcom)
);

ALTER TABLE pedido 
ADD cod_garcom SMALLINT NOT NULL;

ALTER TABLE pedido 
ADD CONSTRAINT FK_cod_garcom 
FOREIGN KEY (cod_garcom)
REFERENCES garcom (cod_garcom)

CREATE TABLE pagamento(

num_pagamento SMALLINT IDENTITY NOT NULL,
num_pedido SMALLINT NOT NULL,
tipo_pagamento VARCHAR(50),

CONSTRAINT PK_num_pagamento
PRIMARY KEY (num_pagamento)



);

ALTER TABLE Pagamento
ADD CONSTRAINT FK_num_pedido
FOREIGN KEY (num_pedido)
REFERENCES pedido (num_pedido)






);


CREATE TABLE item_pedido(

num_item SMALLINT IDENTITY NOT NULL,
cod_produto SMALLINT NOT NULL,
quantidade TINYINT NOT NULL,
valor_por_item DECIMAL (4,2),
CONSTRAINT PK_item_pedido
PRIMARY KEY (num_item)


);


CREATE TABLE produto(
cod_produto SMALLINT IDENTITY NOT NULL,
nome_produto VARCHAR(50),
valor_produto DECIMAL(4,2),
CONSTRAINT PK_produto
PRIMARY KEY (cod_produto)
);


ALTER TABLE item_pedido
ADD CONSTRAINT FK_cod_produto
FOREIGN KEY (cod_produto)
REFERENCES produto (cod_produto)


CREATE TABLE comida(

cod_produto SMALLINT NOT NULL,
categoria_comida VARCHAR(50),
descricao_comida VARCHAR(50),
);

CREATE TABLE bebida(

cod_produto SMALLINT NOT NULL,
tipo_bebida VARCHAR(50),
quantidade_bebida TINYINT,
);




-- Populando --


INSERT INTO cliente VALUES ('Eduardo');
INSERT INTO cliente VALUES ('José Alberto');
INSERT INTO cliente VALUES ('Adalberto Jesus');
INSERT INTO cliente VALUES ('Gabriel Aparecido');
INSERT INTO cliente VALUES ('Jesus Nazareno');
INSERT INTO cliente VALUES ('Rafael Lorenzo');
INSERT INTO cliente VALUES ('João Lolis');
INSERT INTO cliente VALUES ('Victor Hugo');
INSERT INTO cliente VALUES ('Natalia Cristina');
INSERT INTO cliente VALUES ('Angela Orlando');


INSERT INTO garcom VALUES ('Maria Aparecida','18126325097','Rua Dona Alexandrina 902','930123231');
INSERT INTO garcom VALUES ('Caio Freitas','18236325097','Rua Dona Francisca 103','930234831');
INSERT INTO garcom VALUES ('Felipe Yuri','12318325097','Rua Angelo Lucato 107','921323231');
INSERT INTO garcom VALUES ('Icaro Marcelo','12126325097','Rua Dona Maria 92','923563231');
INSERT INTO garcom VALUES ('Fabio Teixeira','18766325097','Rua Allan Kardec 32','932123231');


select *from pedido
select *from garcom
select *from cliente
INSERT INTO pedido VALUES (123,20.00,'Mal passado',2,21,1,2)
INSERT INTO pedido VALUES (234,14.00,'Sem Gelo',4,32,3,3)
INSERT INTO pedido VALUES (345,32.00,'Mal passado com Gelo',5,12,5,4)
INSERT INTO pedido VALUES (678,46.00,'Com Molho',1,9,5,4)
INSERT INTO pedido VALUES (789,21.00,'',2,31,6,2)

SELECT *FROM produto

INSERT INTO produto VALUES ('X-SALADA',19.50)
INSERT INTO produto VALUES ('X-BACON',21.50)
INSERT INTO produto VALUES ('X-FRANGO',22.50)
INSERT INTO produto VALUES ('X-Catupiry',20.50)
INSERT INTO produto VALUES ('Coca-cola',5.50)
INSERT INTO produto VALUES ('Fanta',5.50)
INSERT INTO produto VALUES ('Sprite',5.50)
INSERT INTO produto VALUES ('Cerveja Brahma',7.50)
INSERT INTO produto VALUES ('Cerveja Skol',7.50)


INSERT  INTO Pagamento VALUES (1,'Dinheiro')
INSERT  INTO Pagamento VALUES (2,'Débito')
INSERT  INTO Pagamento VALUES (4,'Crédito')
INSERT  INTO Pagamento VALUES (3,'Dinheiro')
INSERT  INTO Pagamento VALUES (5,'Débito')


INSERT INTO item_pedido VALUES(1,3,5.50)
INSERT INTO item_pedido VALUES(2,4,22.50)
INSERT INTO item_pedido VALUES(4,2,20.50)
INSERT INTO item_pedido VALUES(5,1,21.50)
INSERT INTO item_pedido VALUES(3,5,5.50)

























