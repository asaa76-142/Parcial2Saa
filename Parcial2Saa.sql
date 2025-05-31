CREATE DATABASE Parcial2Saa;
GO
USE [master]
GO
CREATE LOGIN [usrparcial2] WITH PASSWORD = N'12345678',
	DEFAULT_DATABASE = [Parcial2Saa],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [Parcial2Saa]
GO
CREATE USER [usrparcial2] FOR LOGIN [usrparcial2]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrparcial2]
GO

DROP PROC paSerieListar;

CREATE TABLE Series (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(250) NOT NULL,
	sinopsis VARCHAR(5000) NOT NULL,
	director VARCHAR(100) NOT NULL,
	episodios INT NOT NULL,
	fechaEstreno DATE NOT NULL
);

ALTER TABLE Series ADD estado SMALLINT NOT NULL DEFAULT 1;

GO
ALTER PROC paSerieListar @parametro VARCHAR(100)
AS
SELECT 
		id,
		titulo,
		sinopsis,
		director,
		episodios,
		fechaEstreno,
		estado
	FROM Series
	WHERE estado <> -1 AND (
		titulo LIKE '%' + @parametro + '%' OR
		sinopsis LIKE '%' + @parametro + '%' OR
		director LIKE '%' + @parametro + '%' OR
		CAST(episodios AS NVARCHAR) LIKE '%' + @parametro + '%'
	)
	ORDER BY estado ASC, titulo ASC;

EXEC paSerieListar '';

INSERT INTO Series(titulo, sinopsis, director, episodios, fechaEstreno)
VALUES('El juego del Calamar','Cientos de jugadores cortos de dinero aceptan una extraña invitación a competir en juegos infantiles. Adentro les espera un premio irresistible con un riesgo mortal','Hwang Dong-hyuk', 9, '2021-06-08');
INSERT INTO Series(titulo, sinopsis, director, episodios, fechaEstreno)
VALUES('Invasión secreta','Nick Fury trabaja con Talos, un Skrull, un extraterrestre que cambia de forma, para descubrir una conspiración de un grupo de Skrulls renegados liderados por Gravik que planea hacerse con el control de Tierra haciéndose pasar por diferentes humanos alrededor del mundo','Brian Tucker', 6, '2023-06-21');
INSERT INTO Series(titulo, sinopsis, director, episodios, fechaEstreno)
VALUES('Game of Thrones','La primera temporada comienza quince años después de la guerra civil conocida como la «rebelión de Robert», con la cual Robert Baratheon expulsó del Trono de Hierro a los Targaryen y se proclamó gobernante de Poniente','Mark Huffam', 73, '2011-04-17');

select * from Series;