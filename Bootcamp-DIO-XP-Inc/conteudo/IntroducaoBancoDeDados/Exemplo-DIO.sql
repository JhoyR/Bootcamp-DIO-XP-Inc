CREATE TABLE Enderecos (
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente int NULL,
	Rua varchar (255) NULL,
	Bairro varchar (255) NULL,
	Cidade varchar (255) NULL,
	Estado char(2) NULL,

	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente)
	REFERENCES Clientes(Id)
	)

	INSERT INTO Enderecos VALUES (4, 'Rua Teste', 'Bairro Teste', 'Cidade Teste', 'SP')

	SELECT * FROM Enderecos

	SELECT
		C.Nome,
		C.Sobrenome,
		C.Email,
		E.Rua,
		E.Bairro,
		E.Cidade,
		E.Estado
	FROM
		Clientes C
	INNER JOIN Enderecos E ON C.Id = E.IdCliente
	WHERE C.Id = 4

	--TIPOS DE JOINS
	--	INNER JOIN: registros que tenham correspondência nas duas tabelas presentes na junção.
	--	LEFT JOIN: apenas os registros da tabela da esquerda (tabela que está antes da cláusula LEFT JOIN) e os registros que tenham correspondência na tabela da direita.
	--	RIGHT JOIN: apenas os registros da tabela da direita(tabela que está após a cláusula RIGHT JOIN) e os registros que tenham correspondência na tabela da esquerda.
	--	FULL JOIN: registros que tenham correspondência em qualquer uma das tabelas presentes na junção.
	--	CROSS JOIN: registros realizando um cruzamento entre os dados das tabelas presentes na junção.