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
    
    -- ESERCIZIO DI GRUPPO
    -- CREAZIONE DB
	CREATE DATABASE IF NOT EXISTS Libreria;
	USE Libreria;
    
    -- CREAZIONE TABELLA
	CREATE TABLE IF NOT EXISTS Libri (
		ID INT AUTO_INCREMENT PRIMARY KEY,
		Nome VARCHAR(100) NOT NULL,
		Autore VARCHAR(100) NOT NULL,
        Genere VARCHAR (50) NOT NULL,
        Prezzo DECIMAL (5,2),
		AnnoPubblicazione YEAR
	);
    
    -- INSERIMENTO DATI
	INSERT INTO Libri (Nome, Autore, Genere, Prezzo, AnnoPubblicazione) VALUES
	('Il nome della rosa', 'Umberto Eco', 'Giallo storico', 14.90, 1980),
	('1984', 'George Orwell', 'Distopico', 12.50, 1949),
	('Cent’anni di solitudine', 'Gabriel García Márquez', 'Realismo magico', 16.00, 1967),
	('Orgoglio e pregiudizio', 'Jane Austen', 'Romanzo', 10.90, 1813),
	('Il signore degli anelli', 'J.R.R. Tolkien', 'Fantasy', 24.99, 1954),
	('La coscienza di Zeno', 'Italo Svevo', 'Letteratura italiana', 11.50, 1923),
	('Harry Potter e la pietra filosofale', 'J.K. Rowling', 'Fantasy', 18.00, 1997),
	('Il codice Da Vinci', 'Dan Brown', 'Thriller', 13.90, 2003),
	('Sapiens: Da animali a dèi', 'Yuval Noah Harari', 'Saggio', 19.50, 2011),
	('La strada', 'Cormac McCarthy', 'Post-apocalittico', 9.99, 2006);
    
    -- CREAZIONE 1 QUERY
    SELECT Genere, count(Nome) "Conteggio Libro", avg(Prezzo) "Prezzo Medio"
    FROM Libreria.Libri
    GROUP BY Genere
    ORDER BY Genere;
    
    -- CREAZIONE 2 QUERY
    SELECT * FROM Libreria.Libri
    WHERE AnnoPubblicazione > 2010
    ORDER BY Anno DESC, Prezzo
    