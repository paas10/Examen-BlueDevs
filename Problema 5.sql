use pabloalvarado; -- correcto, indica con seguridad la tabla.

INSERT INTO registoRegiones(nombre) value ('NULL'); -- X400 // innecesario, ha comprometido la integridad de los datos.


SELECT	nombre as 'Pais', COUNT(*) as 'CantidadVisitas' -- correcto, nombra adecuadamente las columnas
FROM	registoRegiones
GROUP BY nombre -- incompleto, agrupa los nombres pero no genera la sumatoria.
ORDER BY Count(*) desc, nombre desc; -- adecuado, pero se recomienda sustituir Count(*) por 'CantidadVisitas'

-- solucion MySQL

SELECT s.* FROM (
    SELECT nombre AS 'Pais', Count(*) as 'CantidadVisitas'
    FROM registoRegiones
    GROUP BY nombre WITH ROLLUP 
) AS s -- en MySQL (a diferencia de T-SQL[Usado en SQL Server]) es necesario la subconsulta para ordenar los datos.
ORDER BY  s.CantidadVisitas desc, s.Pais desc

-- solucion T-SQL

SELECT nombre AS Pais, COUNT(*) A CantidadVisitas
FROM registoRegiones
GROUP BY nombre WITH ROLLUP 
ORDER BY CantidadVisitas desc, Pais desc