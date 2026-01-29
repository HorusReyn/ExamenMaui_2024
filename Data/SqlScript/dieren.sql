IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Dieren')
BEGIN
    CREATE DATABASE Dieren
END
GO

USE Dieren
GO

SET NOCOUNT ON;
GO

DROP TABLE IF EXISTS Eigenaar;
DROP TABLE IF EXISTS Dier;
DROP TABLE IF EXISTS Persoon;
DROP TABLE IF EXISTS Soort;
GO

CREATE TABLE Soort (
    id int NOT NULL IDENTITY (1, 1) PRIMARY KEY,
    naam varchar(50)
);

CREATE TABLE Dier (
    id INT PRIMARY KEY NOT NULL IDENTITY (1, 1),
    naam varchar(40),
    soortId int,
    geslacht varchar(2),
    CONSTRAINT FK_Dier_Soort FOREIGN KEY ([soortId]) references Soort (id)
);

CREATE TABLE Persoon (
    id int PRIMARY KEY NOT NULL IDENTITY (1, 1),
    achternaam varchar(80) NOT NULL,
    voornaam varchar(80) NOT NULL,
    telefoon varchar(15) NOT NULL,
    Email varchar(30)
);

CREATE TABLE Eigenaar (
    id int NOT NULL PRIMARY KEY IDENTITY (1, 1),
    dierId int NOT NULL,
    persoonId int NOT NULL,
    CONSTRAINT FK_Eigenaar_Dier FOREIGN KEY (dierId) REFERENCES Dier (id),
    CONSTRAINT FK_Eigenaar_Persoon FOREIGN KEY (persoonId) REFERENCES Persoon (id)
);

INSERT INTO Soort (naam)
VALUES
    ('Hond'),
    ('Kat'),
    ('Cavia'),
    ('Paard'),
    ('Egel'),
    ('Schaap'),
    ('Konijn');

INSERT INTO Dier ( naam, soortId, geslacht)
VALUES
    ( 'Molly', 6, 'M'),
    ( 'Rocky', 1, 'M'),
    ( 'Luna', 1, 'V'),
    ( 'Wolf', 1, 'M'),
    ( 'Dixie', 2, 'V'),
    ( 'Grumpy', 2, 'M'),
    ( 'Sonic', 5, 'M'),
    ( 'Oreo', 3, 'V'),
    ( 'Fluffy', 3, 'M'),
    ( 'Snickers', 7, 'V'),
    ( 'Blackie', 4, 'M'),
    ( 'Vlinder', 7, 'V');

INSERT INTO Persoon ( achternaam, voornaam, telefoon, email)
VALUES
    ( 'White', 'Johnson', '408 496-7223', 'W.J@hotmail.com'),
    ( 'Green', 'Marjorie', '415 986-7020', 'G.M@gmail.com'),
    ( 'Carson', 'Cheryl', '415 548-7723', 'Cheryl@yahoo.com'),
    ( 'O''Leary', 'Michael', '408 286-2428', 'mol@hmail.com'),
    ( 'Straight', 'Dean', '415 834-2919', 'DeanStr@hotmail.com');

INSERT INTO Eigenaar (dierId, persoonId)
VALUES
    (1, 2),
    (1, 1),
    (2, 3),
    (3, 1),
    (3, 2),
    (4, 3),
    (5, 3),
    (6, 3),
    (7, 3),
    (8, 3),
    (9, 5),
    (9, 4),
    (10, 4),
    (10, 5),
    (11, 4),
    (11, 5),
    (12, 4),
    (12, 5);
