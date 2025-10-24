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