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
	--	INNER JOIN: registros que tenham correspond�ncia nas duas tabelas presentes na jun��o.
	--	LEFT JOIN: apenas os registros da tabela da esquerda (tabela que est� antes da cl�usula LEFT JOIN) e os registros que tenham correspond�ncia na tabela da direita.
	--	RIGHT JOIN: apenas os registros da tabela da direita(tabela que est� ap�s a cl�usula RIGHT JOIN) e os registros que tenham correspond�ncia na tabela da esquerda.
	--	FULL JOIN: registros que tenham correspond�ncia em qualquer uma das tabelas presentes na jun��o.
	--	CROSS JOIN: registros realizando um cruzamento entre os dados das tabelas presentes na jun��o.