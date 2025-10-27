-- =======================================================
-- CREAZIONE DATABASE E SCHEMA
-- =======================================================
CREATE DATABASE IF NOT EXISTS LibreriaTest;
USE LibreriaTest;

-- =======================================================
-- TABELLA LIBRI
-- =======================================================
CREATE TABLE IF NOT EXISTS LibreriaTest.Libri (
    id INT AUTO_INCREMENT PRIMARY KEY,
   titolo VARCHAR(100),
   autore VARCHAR(100),
   genere VARCHAR(50),
   anno_pubblicazione YEAR,
   prezzo DECIMAL(6,2)
);

-- =======================================================
-- TABELLA VENDITE
-- =======================================================
CREATE TABLE IF NOT EXISTS LibreriaTest.Vendite (
    id INT AUTO_INCREMENT PRIMARY KEY,
   id_libro INT,
   data_vendita DATE,
   quantita INT,
   negozio VARCHAR(100)
);

-- =======================================================
-- MOCK DATI PER TAB. LIBRI
-- =======================================================
INSERT INTO LibreriaTest.Libri (titolo, autore, genere, anno_pubblicazione, prezzo) VALUES
('The Shining', 'Stephen King', 'Horror', 1977, 19.90),
('It', 'Stephen King', 'Horror', 1986, 24.50),
('Misery', 'Stephen King', 'Thriller', 1987, 17.00),
('Harry Potter e la Pietra Filosofale', 'J.K. Rowling', 'Fantasy', 1997, 14.90),
('Il Codice Da Vinci', 'Dan Brown', 'Thriller', 2003, 21.50),
('Game of Thrones', 'George R.R. Martin', 'Fantasy', 1996, 25.00),
('Twilight', 'Stephenie Meyer', 'Fantasy', 2005, 18.00),
('Doctor Sleep', 'Stephen King', 'Horror', 2013, 20.00),
('Animali Fantastici', 'J.K. Rowling', 'Fantasy', 2016, 22.00),
('The ', ' King', 'Horror', 1997, 19.90),
('ItA', 'Stephen ', 'Horror', 1986, 24.50),
('Misery VF', 'Stephen King', 'Thriller', 1999, 17.00),
('Harry Potter e la Pietra Rotta', 'J.K. Rowling', 'Fantasy', 1997, 14.90),
('Il Da Vinci', ' Brown', 'Thriller', 2003, 21.50),
('Game Thrones', 'George R.R.', 'Fantasy', 1996, 29.00),
('Twilight 89', 'Stephenie ', 'Fantasy', 2005, 78.00),
('Doctor sss', 'Stephen 24', 'Horror', 2018, 24.00),
('Animali Fantastici', 'J.K. FF', 'Fantasy', 2012, 25.00);

-- TEST LIBRI
SELECT * FROM LibreriaTest.Libri;

-- =======================================================
-- MOCK DATI PER TAB. VENDITE
-- =======================================================
INSERT INTO LibreriaTest.Vendite (id_libro, data_vendita, quantita, negozio) VALUES
(1, '2021-05-12', 3, 'BookCity Milano'),
(2, '2022-03-08', 2, 'Libreria Centrale'),
(3, '2020-11-23', 1, 'Cartoleria Roma'),
(4, '2021-07-15', 5, 'Book & Co Torino'),
(5, '2019-09-10', 2, 'Libreria Centrale'),
(6, '2022-01-20', 4, 'BookCity Milano'),
(8, '2021-12-05', 2, 'Book & Co Torino'),
(1, '2022-06-18', 1, 'Cartoleria Roma'),
(9, '2023-02-28', 3, 'Libreria Centrale'),
(12, '2022-05-12', 3, 'BookCity Milano'),
(11, '2025-03-08', 2, 'Libreria Centrale'),
(13, '2023-11-23', 1, 'Cartoleria Roma'),
(14, '2025-07-15', 5, 'Book & Co Torino'),
(15, '2015-09-10', 2, 'Libreria Centrale'),
(16, '2025-01-20', 4, 'BookCity Milano'),
(18, '2025-12-05', 2, 'Book & Co Torino'),
(10, '2025-06-18', 1, 'Cartoleria Roma'),
(9, '2024-02-28', 3, 'Libreria Centrale');

-- TEST VENDITE
SELECT * FROM LibreriaTest.Vendite;
-- DROP TABLE LibreriaTest.Vendite;

-- 1. LIBRI VENDUTI IN 1 NEGOZIO
SELECT l.titolo, l.autore, v.data_vendita, v.negozio
FROM LibreriaTest.Vendite AS v
INNER JOIN LibreriaTest.Libri AS l ON l.id = v.id_libro
WHERE lower(autore) LIKE '%king%';

-- 2. LIBRI CON BETWEEN
SELECT l.titolo, l.anno_pubblicazione, l.prezzo, v.data_vendita
FROM LibreriaTest.Vendite AS v
LEFT JOIN LibreriaTest.Libri AS l ON l.id = v.id_libro
WHERE l.anno_pubblicazione BETWEEN 2000 AND 2010;

-- 3. DATI LIBRI VENDUTI LISTA SPECIFICA
SELECT l.titolo, v.negozio, sum(v.quantita) AS Quantita_tot, sum(v.prezzo*v.quantita) AS Valore_tot
FROM LibreriaTest.Vendite AS v
INNER JOIN LibreriaTest.Libri AS l ON l.id = v.id_libro
WHERE v.negozio IN ('Cartoleria Roma', 'Libreria Centrale', 'BookCity Milano')
GROUP BY l.titolo, v.negozio;

-- 4. TUTTI RECORD + ANOMALIA SE PRESENTE
SELECT l.titolo, v.data_vendita, l.prezzo, v.quantita
FROM LibreriaTest.Vendite AS v
RIGHT JOIN LibreriaTest.Libri AS l ON l.id = v.id_libro
WHERE substr(v.data_vendita, 1, 4) BETWEEN 2020 AND 2022
AND v.negozio LIKE '%Book%'
ORDER BY v.data_vendita DESC;

-- 5 INNER + WHERE
SELECT l.titolo, l.autore, l.prezzo, v.data_vendita
FROM LibreriaTest.Vendite AS v
RIGHT JOIN LibreriaTest.Libri AS l ON l.id = v.id_libro
WHERE l.genere IN ('Fantasy', 'Horror', 'Giallo')
AND l.anno_pubblicazione > 2010
AND lower(v.negozio) LIKE '%book%'
ORDER BY l.anno_pubblicazione DESC;