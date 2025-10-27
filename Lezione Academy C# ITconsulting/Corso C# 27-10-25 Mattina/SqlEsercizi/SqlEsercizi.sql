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
    
-- =======================================================
-- CREAZIONE DATABASE E SCHEMA
-- =======================================================
CREATE DATABASE IF NOT EXISTS Negozio;
USE Negozio;

-- =======================================================
-- TABELLA CLIENTI
-- =======================================================
CREATE TABLE IF NOT EXISTS Negozio.Clienti (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    citta VARCHAR(100)
);

-- =======================================================
-- TABELLA ORDINI
-- =======================================================

CREATE TABLE Negozio.Ordini (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    data_ordine DATE,
    importo DECIMAL(7,2)
);

-- =======================================================
-- INSERIMENTO DATI CLIENTI (20 record)
-- =======================================================
INSERT INTO Negozio.Clienti (nome, citta) VALUES
('Luca Rossi', 'Milano'),
('Giulia Bianchi', 'Roma'),
('Marco Verdi', 'Torino'),
('Sara Neri', 'Napoli'),
('Andrea Gallo', 'Firenze'),
('Valentina Riva', 'Bologna'),
('Matteo Greco', 'Palermo'),
('Chiara Ferri', 'Genova'),
('Francesco Conti', 'Verona'),
('Anna Rizzi', 'Padova'),
('Simone Costa', 'Catania'),
('Martina Villa', 'Perugia'),
('Davide Leone', 'Reggio Emilia'),
('Elisa Pavan', 'Trieste'),
('Alessandro Fabbri', 'Parma'),
('Irene Gatti', 'Bergamo'),
('Nicola Serra', 'Salerno'),
('Laura Vitale', 'Cagliari'),
('Stefano De Luca', 'Lecce'),
('Arianna Grassi', 'Pisa');

-- PROVACLIENTI
SELECT * FROM Negozio.Clienti;

-- =======================================================
-- INSERIMENTO DATI ORDINI (20 record)
-- Alcuni ordini hanno id_cliente NULL o non esistente per testare RIGHT JOIN
-- =======================================================
INSERT INTO Negozio.Ordini (id_cliente, data_ordine, importo) VALUES
(1, '2024-01-15', 120.50),
(2, '2024-02-10', 85.00),
(3, '2024-02-12', 150.00),
(4, '2024-03-05', 60.99),
(5, '2024-03-15', 200.75),
(6, '2024-03-22', 300.00),
(7, '2024-04-01', 45.50),
(8, '2024-04-10', 99.99),
(9, '2024-04-25', 75.20),
(10, '2024-05-01', 180.90),
(11, '2024-05-12', 130.00),
(12, '2024-05-30', 49.99),
(13, '2024-06-15', 210.40),
(14, '2024-07-01', 88.80),
(15, '2024-07-10', 310.00),
(16, '2024-07-22', 70.00),
(17, '2024-08-01', 99.99),
(18, '2024-08-15', 140.00),
(NULL, '2024-08-30', 250.00),
(25, '2024-09-05', 199.99);

-- PROVA ORDINI
SELECT * FROM Negozio.Ordini;

-- 	INNER JOIN
SELECT c.nome, o.data_ordine, o.importo FROM Negozio.Clienti as c
INNER JOIN Negozio.Ordini as o ON c.id = o.id_cliente;

-- LEFT JOIN
SELECT c.nome, o.data_ordine, o.importo FROM Negozio.Clienti as c
LEFT JOIN Negozio.Ordini as o ON c.id = o.id_cliente;

-- LEFT JOIN 2
SELECT c.nome, o.data_ordine, o.importo FROM Negozio.Clienti as c
LEFT JOIN Negozio.Ordini as o ON c.id = o.id_cliente
WHERE o.data_ordine IS NULL;

-- RIGHT JOIN
SELECT c.nome, o.data_ordine, o.importo FROM Negozio.Clienti as c
RIGHT JOIN Negozio.Ordini as o ON c.id = o.id_cliente;

-- RIGHT JOIN 2
SELECT c.nome, o.data_ordine, o.importo FROM Negozio.Clienti as c
RIGHT JOIN Negozio.Ordini as o ON c.id = o.id_cliente
WHERE c.nome IS NULL;

-- EXTRA
SELECT 
    c.nome AS NomeCliente,
    o.data_ordine AS DataOrdine,
    o.importo AS Importo,
    CASE
        WHEN c.id IS NOT NULL AND o.id_cliente IS NOT NULL THEN 'Cliente con ordine'
        WHEN c.id IS NOT NULL AND o.id_cliente IS NULL THEN 'Cliente senza ordini'
        WHEN c.id IS NULL AND o.id_cliente IS NOT NULL THEN 'Ordine senza cliente'
    END AS TipoCaso
FROM Negozio.Clienti AS c
LEFT JOIN Negozio.Ordini AS o
    ON c.id = o.id_cliente

UNION

SELECT 
    c.nome AS NomeCliente,
    o.data_ordine AS DataOrdine,
    o.importo AS Importo,
    CASE
        WHEN c.id IS NOT NULL AND o.id_cliente IS NOT NULL THEN 'Cliente con ordine'
        WHEN c.id IS NOT NULL AND o.id_cliente IS NULL THEN 'Cliente senza ordini'
        WHEN c.id IS NULL AND o.id_cliente IS NOT NULL THEN 'Ordine senza cliente'
    END AS TipoCaso
FROM Negozio.Clienti AS c
RIGHT JOIN Negozio.Ordini AS o
    ON c.id = o.id_cliente
ORDER BY NomeCliente;

-- ESERCIZIO 3

-- 	INNER JOIN
SELECT c.nome, count(o.data_ordine), sum(o.importo)
FROM Negozio.Clienti as c
INNER JOIN Negozio.Ordini as o ON c.id = o.id_cliente
GROUP BY c.nome
ORDER BY c.nome;

-- LEFT JOIN
SELECT c.nome, c.citta FROM Negozio.Clienti as c
LEFT JOIN Negozio.Ordini as o ON c.id = o.id_cliente
WHERE o.data_ordine IS NULL;

-- RIGHT JOIN
SELECT c.nome, o.id, o.data_ordine, o.importo FROM Negozio.Clienti as c
RIGHT JOIN Negozio.Ordini as o ON c.id = o.id_cliente
WHERE c.nome IS NULL;