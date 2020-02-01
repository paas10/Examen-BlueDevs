use pabloalvarado;

INSERT INTO registoRegiones(nombre) value ('NULL'); -- X400

SELECT	nombre as 'Pais', COUNT(*) as 'CantidadVisitas'
FROM	registoRegiones
GROUP BY nombre
ORDER BY Count(*) desc, nombre desc;
