-- PROVA GIORNO 2 SQL
USE world;
SELECT * FROM world.countrylanguage
WHERE CountryCode LIKE 'A%'
AND Language LIKE '_t%';