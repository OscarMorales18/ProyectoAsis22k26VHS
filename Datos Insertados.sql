--INSERT PARA LA TABLAS 

INSERT INTO video
(codigo,titulo,genero,director,anio,precio_renta,stock,estado)
VALUES
('COD-001','El Retorno del Terror','Terror','Marta Núñez',1998,20.00,4,'disponible'),
('COD-002','Risas de Medianoche','Comedia','Luis Prado',2001,18.00,2,'rentado'),
('COD-003','Sombras del Pasado','Drama','Elena Cruz',1995,22.00,3,'disponible'),
('COD-004','Fuego Cruzado','Acción','Diego Ramos',2004,25.00,1,'rentado'),
('COD-005','Vacaciones en Familia','Familiar','Sofía Vega',1999,15.00,5,'disponible'),
('COD-006','El Enigma Final','Suspenso','Carlos Ibáñez',2002,23.00,0,'rentado'),
('COD-007','Guardianes del Tiempo','Ciencia Ficción','Andrea Molina',2010,24.00,6,'disponible'),
('COD-008','La Maldición del Bosque','Terror','Jorge Castillo',1997,21.00,2,'disponible'),
('COD-009','Operación Centinela','Acción','Ricardo Salazar',2008,26.00,4,'disponible'),
('COD-010','Amor Bajo la Lluvia','Romance','Valeria Méndez',2005,19.00,3,'disponible');

select * from video