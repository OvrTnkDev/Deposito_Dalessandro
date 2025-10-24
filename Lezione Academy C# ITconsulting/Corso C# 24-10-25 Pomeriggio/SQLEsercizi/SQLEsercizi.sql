/*SELECT Id, Name "Nome", District "Distretto" FROM world.city 
WHERE Name <> "Kabul";
SELECT DISTINCT Name "Nome", District "Distretto" FROM world.city;
SELECT count(DISTINCT Name), count(DISTINCT District) FROM world.city;
SELECT  concat(Continent, " - ", Code) "Continente/Codice", avg(Population) "Media Popolazione"
FROM world.country
WHERE NOT Continent IN ("Asia", "Africa", "Europe")
GROUP BY Continent, Code
ORDER BY Code DESC;*/

/*CREATE DATABASE IF NOT EXISTS DemoDB;
USE DemoDB;
CREATE TABLE IF NOT EXISTS Dipendenti (
    ID INT PRIMARY KEY,        -- chiave primaria
    Nome VARCHAR(50) NOT NULL,
    Cognome VARCHAR(50) NOT NULL,
    DataAssunzione DATE,
    Stipendio DECIMAL(10,2)
);
INSERT INTO Dipendenti (ID, Nome, Cognome, DataAssunzione, Stipendio)
VALUES 
    (1, 'Luca', 'Rossi', '2022-01-15', 2500.00),
    (2, 'Maria', 'Bianchi', '2021-03-10', 2800.50),
    (3, 'Giovanni', 'Verdi', '2023-07-01', 3000.75);*/
    
    -- ESERCIZIO 1
    /*SELECT DISTINCT (case when Continent = "Europe" then Region else null end)
    FROM world.country;*/
    
    -- ESERCIZIO 2
   /* SELECT Name, Population FROM world.city
    WHERE CountryCode = "USA"
    AND Population > 1000000
    ORDER BY Population DESC;*/
    
    -- ESERCIZIO 3
   /* SELECT Continent, count(DISTINCT Region) "Conteggio regioni", sum(Population) "Somma Popolazione"
    FROM world.country
    GROUP BY Continent
    ORDER BY Continent ASC;*/
    
    -- Controllo ESERCIZIO 3
	/*SELECT Continent, Region "Conteggio regioni", Population "Somma Popolazione"
    FROM world.country
    WHERE Continent = "Antarctica"
    ORDER BY Continent ASC;*/
    
/*-- ESERCIZIO DI GRUPPO
-- CREAZIONE DATABASE
CREATE DATABASE IF NOT EXISTS Libreria;
USE Libreria;

-- CREAZIONE TABELLA
CREATE TABLE IF NOT EXISTS Libri (
	ID INT AUTO_INCREMENT PRIMARY KEY,
	Nome VARCHAR(100) NOT NULL,
	Autore VARCHAR(100) NOT NULL,
	Genere VARCHAR(50) NOT NULL,
	Prezzo DECIMAL(5,2),
	AnnoPubblicazione YEAR
);

-- INSERIMENTO DATI CORRETTO
INSERT INTO Libri (Nome, Autore, Genere, Prezzo, AnnoPubblicazione) VALUES
('Sapiens Da animali a dei', 'Yuval Noah Harari', 'Saggio', 19.50, 2011),
('La strada', 'Cormac McCarthy', 'Post-apocalittico', 9.99, 2006),
('Il codice Da Vinci', 'Dan Brown', 'Thriller', 13.90, 2003),
('Harry Potter e la camera dei segreti', 'J.K. Rowling', 'Fantasy', 17.50, 2009),
('Il canto delluniverso', 'Stephen Hawking', 'Saggio', 15.99, 2010),
('La verita sul caso Harry Quebert', 'Joël Dicker', 'Thriller', 18.00, 2013),
('Il trono di spade', 'George R.R. Martin', 'Fantasy', 22.50, 2011),
('La ragazza del treno', 'Paula Hawkins', 'Thriller', 14.99, 2015),
('Hunger Games', 'Suzanne Collins', 'Distopico', 16.50, 2008),
('Ready Player One', 'Ernest Cline', 'Fantascienza', 18.50, 2018);
    
    -- CREAZIONE 1 QUERY
SELECT 
    Genere, 
    COUNT(Nome) AS Conteggio_Libri, 
    AVG(Prezzo) AS Prezzo_Medio
FROM Libri
GROUP BY Genere
ORDER BY Genere;
    
    -- CREAZIONE 2 QUERY
SELECT *
FROM Libri
WHERE AnnoPubblicazione > 2010
ORDER BY AnnoPubblicazione DESC, Prezzo DESC;

    
    select * from Libreria.Libri LIMIT 2;*/
    
-- ESERCIZIO GRUPPO 2
-- CREAZIONE DATABASE
CREATE DATABASE IF NOT EXISTS Magazzino;
USE Magazzino;

-- CREAZIONE TABELLA
CREATE TABLE IF NOT EXISTS Vendite (
	ID INT AUTO_INCREMENT PRIMARY KEY,
	Prodotto VARCHAR(100) NOT NULL,
	Categoria VARCHAR(100) NOT NULL,
	Quantita INT NOT NULL,
	PrezzoUnitario DECIMAL(5,2),
	DataVendita DATE
);

-- INSERIMENTO DATI MOCK
INSERT INTO Vendite (Prodotto, Categoria, Quantita, PrezzoUnitario, DataVendita) VALUES
('Laptop Lenovo ThinkPad', 'Elettronica', 5, 899.99, '2023-01-15'),
('Mouse Logitech M330', 'Elettronica', 20, 19.50, '2023-01-16'),
('Notebook A4', 'Cancelleria', 50, 2.30, '2023-01-17'),
('Penna a sfera Bic', 'Cancelleria', 100, 0.50, '2023-01-18'),
('Tavolo da ufficio', 'Arredamento', 3, 120.00, '2023-02-05'),
('Sedia ergonomica', 'Arredamento', 4, 180.00, '2023-02-06'),
('Smartphone Samsung Galaxy', 'Elettronica', 8, 699.00, '2023-03-10'),
('Cuffie Bluetooth Sony', 'Elettronica', 10, 89.99, '2023-03-12'),
('Cartellina A4', 'Cancelleria', 30, 1.20, '2023-04-01'),
('Lampada da scrivania', 'Arredamento', 6, 45.50, '2023-04-03'),
('Zaino scuola', 'Accessori', 15, 35.00, '2023-05-10'),
('Calcolatrice scientifica', 'Cancelleria', 12, 25.00, '2023-05-15'),
('Monitor 24 pollici', 'Elettronica', 7, 199.99, '2023-06-01'),
('Tastiera meccanica', 'Elettronica', 9, 79.50, '2023-06-05'),
('Agenda 2023', 'Cancelleria', 40, 5.00, '2023-06-10');

-- PROVA
SELECT * FROM Vendite;

-- TOTALE VENDITA PER CATEGORIA
SELECT Categoria, sum(PrezzoUnitario * Quantita) TotaleVendita
FROM Vendite
GROUP BY Categoria
ORDER BY Categoria;

-- PREZZO MEDIO PRODOTTI VENDUTI
SELECT Categoria, avg(PrezzoUnitario * Quantita) PrezzoMedioV, sum(PrezzoUnitario * Quantita) Totalevenduto
FROM Vendite
GROUP BY Categoria
ORDER BY Categoria;

-- NUMERO TOTALE VENDITE
SELECT Categoria, sum(Quantita) PezziVenduti
FROM Vendite
GROUP BY Categoria
ORDER BY Categoria;

-- PREZZO MASSIMO E MINNIMO
SELECT Prodotto, Categoria, min(PrezzoUnitario) PrezzoMin, max(PrezzoUnitario) PrezzoMax
FROM Vendite
GROUP BY Prodotto, Categoria
ORDER BY Categoria;

-- CONTEGGIO VENDITE
SELECT count(*) ConteggioVendite
FROM Vendite;

-- I 5 PRODOTTI PIU' COSTOSI
SELECT Prodotto, Categoria, PrezzoUnitario
FROM Vendite
ORDER BY PrezzoUnitario ASC
LIMIT 5;

-- I 3 PRODOTTI MENO VENDUTI
SELECT Prodotto, Categoria, sum(Quantita) SommaQuantita
FROM Vendite
GROUP BY Prodotto, Categoria
ORDER BY sum(Quantita) ASC
LIMIT 3;