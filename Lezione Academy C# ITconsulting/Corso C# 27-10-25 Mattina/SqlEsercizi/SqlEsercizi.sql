-- PROVA GIORNO 2 SQL
USE world;

-- LIKE
SELECT * FROM world.countrylanguage
WHERE CountryCode LIKE 'A%'
AND Language LIKE '_t%';

-- IN
SELECT * FROM world.countrylanguage
WHERE Language in ('Italian','Dutch', 'Spanish')
ORDER BY Language;

-- BETWEEN
SELECT * FROM world.countrylanguage
WHERE Percentage BETWEEN 0.0 AND 2.5
ORDER BY Percentage;

-- ------------------------------ --

-- ESERCIZIO 1
-- CREAZIONE DATABASE
CREATE DATABASE IF NOT EXISTS AziendaClienti;
USE AziendaClienti;

-- CREAZIONE TABELLA
CREATE TABLE IF NOT EXISTS AziendaClienti.Clienti (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    cognome VARCHAR(100),
    email VARCHAR(100),
    eta INT,
    citta VARCHAR(100)
);

-- INSERIMENTO DATI MOCK
INSERT INTO AziendaClienti.Clienti (nome, cognome, email, eta, citta) VALUES
('Alessandro', 'Rossi', 'alessandro.rossi@gmail.com', 28, 'Milano'),
('Giulia', 'Bianchi', 'giulia.bianchi@yahoo.com', 34, 'Roma'),
('Andrea', 'Verdi', 'andrea.verdi@gmail.com', 41, 'Torino'),
('Francesca', 'Costa', 'francesca.costa@outlook.com', 39, 'Napoli'),
('Luca', 'Moretti', 'luca.moretti@gmail.com', 31, 'Bergamo'),
('Anna', 'Ferrari', 'anna.ferrari@gmail.com', 26, 'Firenze'),
('Davide', 'Neri', 'davide.neri@hotmail.com', 44, 'Roma'),
('Martina', 'Gallo', 'martina.gallo@gmail.com', 29, 'Catania'),
('Simone', 'Greco', 'simone.greco@libero.it', 32, 'Padova'),
('Chiara', 'Leone', 'chiara.leone@gmail.com', 36, 'Palermo'),
('Alberto', 'Rizzi', 'alberto.rizzi@gmail.com', 40, 'Verona'),
('Valentina', 'Pace', 'valentina.pace@icloud.com', 33, 'Bologna'),
('Emanuele', 'Villa', 'emanuele.villa@gmail.com', 37, 'Roma Nord'),
('Arianna', 'Fiore', 'arianna.fiore@gmail.com', 24, 'Genova'),
('Carlo', 'Marin', 'carlo.marin@outlook.com', 45, 'Roma Sud'),
('Silvia', 'Conti', 'silvia.conti@gmail.com', 38, 'Perugia'),
('Federico', 'Sarti', 'federico.sarti@yahoo.com', 30, 'Roma Centro'),
('Alice', 'Nardi', 'alice.nardi@gmail.com', 35, 'Pescara'),
('Matteo', 'Lenti', 'matteo.lenti@gmail.com', 42, 'Reggio Emilia'),
('Elena', 'Valli', 'elena.valli@gmail.com', 27, 'Roma Est');

-- PROVA
SELECT * FROM AziendaClienti.Clienti;

-- DOMINIO GMAIL
SELECT * FROM AziendaClienti.Clienti
WHERE email LIKE '%@gmail%';

-- CLIENTI GMAIL
SELECT concat(Nome, '-', Cognome) AS Cliente FROM AziendaClienti.Clienti
WHERE email LIKE '%@gmail.com';

-- CLIENTI CHE CONTIENE CON A
SELECT * FROM AziendaClienti.Clienti
WHERE lower(Nome) LIKE '%a%';

-- CLIENTI CHE INIZIANI CON A
SELECT * FROM AziendaClienti.Clienti
WHERE Nome LIKE 'A%';

-- COGNOME CONTENTE 5 LETTERE
SELECT * FROM AziendaClienti.Clienti
WHERE length(Cognome) = 5;

-- ETA COMPRESA TRA 31 - 40
SELECT * FROM AziendaClienti.Clienti
WHERE Eta BETWEEN 31 AND 40
ORDER BY Eta DESC;

-- ETA COMPRESA TRA 30 - 40
SELECT * FROM AziendaClienti.Clienti
WHERE Eta BETWEEN 30 AND 40
ORDER BY Eta DESC;

-- CLIENTI CHE VIVONO A 'roma'
SELECT * FROM AziendaClienti.Clienti
WHERE Citta LIKE 'roma';

-- CLIENTI CHE VIVONO A ROMA
SELECT * FROM AziendaClienti.Clienti
WHERE lower(Citta) LIKE '%roma%';

-- ------------JOIN----------------- --
-- INNER JOIN
SELECT 
    a.Name AS Citta,
    b.nome AS Cliente,
    b.cognome AS Cognome
FROM world.city a
INNER JOIN AziendaClienti.Clienti b 
    ON a.Name = b.citta;


-- LEFT JOIN
SELECT 
    a.Name AS Citta,
    b.nome AS Cliente,
    b.cognome AS Cognome
FROM world.city a
LEFT JOIN AziendaClienti.Clienti b 
    ON a.Name = b.citta;


-- RIGHT JOIN
SELECT 
    a.Name AS Citta,
    b.nome AS Cliente,
    b.cognome AS Cognome
FROM world.city a
RIGHT JOIN AziendaClienti.Clienti b 
    ON a.Name = b.citta;
