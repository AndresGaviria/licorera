CREATE DATABASE db_licorera
GO
USE db_licorera
GO

CREATE TABLE Tipos
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Nombre] NVARCHAR(50) NOT NULL,
);
GO

CREATE TABLE Bebidas
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Fecha] SMALLDATETIME NOT NULL,
	[Tipo] INT REFERENCES [Tipos] ([Id]),
	[Activa] BIT NOT NULL DEFAULT 0
);
GO

INSERT INTO [Tipos] ([Nombre]) VALUES ('Ron');
INSERT INTO [Tipos] ([Nombre]) VALUES ('Licor blanco');
GO

SELECT * FROM [Tipos];
GO

INSERT INTO [Bebidas] ([Nombre],[Fecha],[Tipo],[Activa]) 
VALUES ('Ron antioqueño', GETDATE(), 2, 1);
INSERT INTO [Bebidas] ([Nombre],[Fecha],[Tipo],[Activa]) 
VALUES ('Ron viejo de caldas', GETDATE(), 2, 0);
GO

SELECT * 
FROM [Bebidas] B INNER JOIN [Tipos] T ON B.Tipo = T.Id;
GO