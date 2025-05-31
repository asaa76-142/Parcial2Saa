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
Drop Table Series;
DROP table IdiomaOriginal;

CREATE TABLE IdiomaOriginal (
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
descripcion VARCHAR(250) NOT NULL UNIQUE
);

CREATE TABLE Series (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(250) NOT NULL,
	sinopsis VARCHAR(5000) NOT NULL,
	director VARCHAR(100) NOT NULL,
	episodios INT NOT NULL,
	fechaEstreno DATE NOT NULL,
	urlPortada VARCHAR(250) NOT NULL,
	ididiomaOriginal INT NOT NULL,
	CONSTRAINT fk_Series_IdiomaOriginal FOREIGN KEY(ididiomaOriginal) REFERENCES IdiomaOriginal(id)

);

ALTER TABLE Series ADD estado SMALLINT NOT NULL DEFAULT 1;
ALTER TABLE IdiomaOriginal ADD estado SMALLINT NOT NULL DEFAULT 1;

GO
ALTER PROC paSerieListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT 
        s.id,
        s.titulo,
        s.sinopsis,
        s.director,
        s.episodios,
        s.fechaEstreno,
        s.urlPortada,
        s.ididiomaOriginal,
        s.estado
    FROM Series s
    INNER JOIN IdiomaOriginal ID ON ID.id = s.ididiomaOriginal
    WHERE s.estado <> -1 AND (
        s.titulo LIKE '%' + @parametro + '%' OR
        s.sinopsis LIKE '%' + @parametro + '%' OR
        s.director LIKE '%' + @parametro + '%' OR
        s.urlPortada LIKE '%' + @parametro + '%' OR
        ID.descripcion LIKE '%' + @parametro + '%' OR
        CAST(s.ididiomaOriginal AS NVARCHAR) LIKE '%' + @parametro + '%' OR
        CAST(s.episodios AS NVARCHAR) LIKE '%' + @parametro + '%'
    )
    ORDER BY s.estado ASC, s.titulo ASC;
END
GO
EXEC paSerieListar '';

INSERT INTO IdiomaOriginal(descripcion)
VALUES ('Koreano'),('Ingles'),('Español'),('Portugues');
INSERT INTO Series(titulo, sinopsis, director, episodios, fechaEstreno, urlPortada, ididiomaOriginal)
VALUES('El juego del Calamar','Cientos de jugadores cortos de dinero aceptan una extraña invitación a competir en juegos infantiles. Adentro les espera un premio irresistible con un riesgo mortal','Hwang Dong-hyuk', 9, '2021-06-08', 'https://images.app.goo.gl/WK4WvrRFsbyK8uaBA', 1);
INSERT INTO Series(titulo, sinopsis, director, episodios, fechaEstreno, urlPortada, ididiomaOriginal)
VALUES('Invasión secreta','Nick Fury trabaja con Talos, un Skrull, un extraterrestre que cambia de forma, para descubrir una conspiración de un grupo de Skrulls renegados liderados por Gravik que planea hacerse con el control de Tierra haciéndose pasar por diferentes humanos alrededor del mundo','Brian Tucker', 6, '2023-06-21', 'https://images.app.goo.gl/uQUdT1MQinQpWpDZ6', 2);
INSERT INTO Series(titulo, sinopsis, director, episodios, fechaEstreno, urlPortada, ididiomaOriginal)
VALUES('Game of Thrones','La primera temporada comienza quince años después de la guerra civil conocida como la «rebelión de Robert», con la cual Robert Baratheon expulsó del Trono de Hierro a los Targaryen y se proclamó gobernante de Poniente','Mark Huffam', 73, '2011-04-17', 'https://images.app.goo.gl/zDyTy2nDQjhAyABQ9', 2);

select * from Series;