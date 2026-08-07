-- Creacion de la base de dato

CREATE DATABASE IF NOT EXISTS RentaVideoVHS;
USE RentaVideoVHS;

-- direccon

CREATE TABLE direccion (
id_direccion INT NOT NULL AUTO_INCREMENT,
calle VARCHAR(150) NOT NULL,
ciudad VARCHAR(100) NOT NULL,
departamento VARCHAR(100),
pais VARCHAR(80)  NOT NULL,
PRIMARY KEY (id_direccion)
);

-- empleado
-- Justificación NOT NULL:
--   nombre y puesto son obligatorios para identificar
--   al empleado dentro del sistema.
--   telefono es opcional; un empleado puede no tener
--   teléfono registrado al momento del alta.


CREATE TABLE empleado (
id_empleado  INT NOT NULL AUTO_INCREMENT ,
nombre VARCHAR(100) NOT NULL,
puesto VARCHAR(50)  NOT NULL,
telefono  VARCHAR(20),
PRIMARY KEY (id_empleado)
);

-- tipo_membresia
-- Justificación NOT NULL:
--   tipo y descuento_disponible son los dos atributos
--   que definen completamente esta entidad; ambos
--   son obligatorios.


CREATE TABLE tipo_membresia (
id_tipo_membresia INT NOT NULL AUTO_INCREMENT,
tipo VARCHAR(50) NOT NULL,
descuento_disponible TINYINT(1)  NOT NULL DEFAULT 0,
PRIMARY KEY (id_tipo_membresia),
UNIQUE KEY uq_tipo (tipo)
);

-- video
-- Justificación NOT NULL:
--   titulo es obligatorio para identificar el video.
--   genero es opcional; puede no clasificarse al inicio.
--   precio_renta, stock y estado son obligatorios para
--   que el sistema opere correctamente.
-- Justificación CHECK:
--   precio_renta > 0: no tiene sentido un video gratuito
--   o con precio negativo en un sistema de cobro.
--   stock >= 0: no puede haber unidades negativas físicamente.
--   estado solo acepta valores del dominio definido por
--   el negocio: disponible, rentado, dañado, dado_de_baja.

CREATE TABLE video (
id_video INT AUTO_INCREMENT PRIMARY KEY,
titulo VARCHAR(150) NOT NULL,
genero VARCHAR(50),
precio_renta DECIMAL(10,2) NOT NULL DEFAULT 0,
stock INT NOT NULL DEFAULT 0,
estado VARCHAR(30) NOT NULL DEFAULT 'disponible',
codigo VARCHAR(20) NOT NULL,
director VARCHAR(100) NOT NULL,
anio SMALLINT NOT NULL,
clasificacion VARCHAR(10) NOT NULL,
duracion INT NOT NULL,
idioma VARCHAR(30) NOT NULL DEFAULT 'Español',
CONSTRAINT CHK_video_precio CHECK(precio_renta > 0),
CONSTRAINT CHK_video_stock CHECK(stock >= 0),
CONSTRAINT UQ_video_codigo UNIQUE(codigo)
);

-- Auditoria base de datos (Creada con IA)

CREATE TABLE auditoria (
id_auditoria INT NOT NULL AUTO_INCREMENT,
tabla_afectada VARCHAR(50) NOT NULL,
operacion VARCHAR(10) NOT NULL, -- 'INSERT', 'UPDATE', 'DELETE'
id_registro_afectado INT NOT NULL,
datos_anteriores TEXT, -- Texto simple con los datos previos
datos_nuevos TEXT,     -- Texto simple con los datos nuevos
usuario_app VARCHAR(50),
usuario_db VARCHAR(100) NOT NULL,
fecha_hora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
PRIMARY KEY (id_auditoria)
);

CREATE TABLE usuario (
id_usuario INT NOT NULL AUTO_INCREMENT,
usuario VARCHAR(50) NOT NULL UNIQUE,
contrasena VARCHAR(255) NOT NULL,
id_empleado INT NOT NULL,
rol VARCHAR(20) NOT NULL,
estado BIT NOT NULL DEFAULT 1, 
PRIMARY KEY (id_usuario),
FOREIGN KEY (id_empleado) REFERENCES empleado(id_empleado) ON UPDATE CASCADE ON DELETE CASCADE,

-- esta parte fue con IA

CONSTRAINT chk_usuario_rol CHECK (rol IN ('Empleado', 'Administrador', 'Auditor'))


);

-- cliente
-- Justificación NOT NULL:
--   nombre es obligatorio para identificar al cliente.
--   telefono es opcional; puede registrarse sin él
--   y actualizarse después.
--   id_direccion es opcional (SET NULL en FK) porque
--   puede darse de alta el cliente antes de registrar
--   su dirección completa.

CREATE TABLE cliente (
id_cliente INT AUTO_INCREMENT,
nombre VARCHAR(100) NOT NULL,
dpi VARCHAR(14) NOT NULL,
telefono VARCHAR(8) NOT NULL,
direccion VARCHAR(100) NOT NULL,
correo VARCHAR(50) NOT NULL,
no_rentas INT,
descuento bit,
id_membresia INT NULL,
PRIMARY KEY (id_cliente)
);

-- membresia
-- Justificación NOT NULL:
--   id_cliente e id_tipo_membresia son obligatorios;
--   sin ellos la membresía no tiene sentido.
--   fecha_inicio es obligatoria para saber desde cuándo
--   aplica la membresía.
--   fecha_fin es opcional porque puede ser indefinida
--   (membresía abierta sin vencimiento).
--   videos_acumulados inicia en 0 por defecto.
-- Justificación CHECK:
--   fecha_fin debe ser posterior a fecha_inicio para
--   garantizar coherencia temporal.

CREATE TABLE membresia (
id_membresia INT NOT NULL AUTO_INCREMENT,
id_cliente INT NOT NULL,
id_tipo_membresia INT NOT NULL,
fecha_inicio DATE NOT NULL,
fecha_fin DATE,
videos_acumulados INT  NOT NULL DEFAULT 0,
PRIMARY KEY (id_membresia),
FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY (id_tipo_membresia) REFERENCES tipo_membresia(id_tipo_membresia) ON UPDATE CASCADE,
CONSTRAINT chk_membresia_fechas CHECK (fecha_fin IS NULL OR fecha_fin > fecha_inicio),
CONSTRAINT chk_membresia_videos CHECK (videos_acumulados >= 0)
);

ALTER TABLE cliente ADD CONSTRAINT fk_cliente_membresia 
FOREIGN KEY (id_membresia) REFERENCES membresia(id_membresia) ON UPDATE CASCADE ON DELETE CASCADE;

-- proveedor
-- Justificación NOT NULL:
--   nombre es obligatorio para identificar al proveedor.
--   telefono y id_direccion opcionales por la misma
--   razón que en cliente.

CREATE TABLE proveedor (
id_proveedor INT NOT NULL AUTO_INCREMENT,
nombre VARCHAR(100) NOT NULL,
telefono VARCHAR(20),
id_direccion INT,
PRIMARY KEY (id_proveedor),
FOREIGN KEY (id_direccion) REFERENCES direccion(id_direccion) ON UPDATE CASCADE ON DELETE SET NULL
);

-- compra
-- Justificación CHECK:
--   total > 0: toda compra debe tener un valor positivo.

CREATE TABLE compra (
id_compra INT NOT NULL AUTO_INCREMENT,
fecha DATE NOT NULL,
total DECIMAL(10,2) NOT NULL DEFAULT 0.00,
id_proveedor INT NOT NULL,
id_empleado INT NOT NULL,
PRIMARY KEY (id_compra),
FOREIGN KEY (id_proveedor) REFERENCES proveedor(id_proveedor) ON UPDATE CASCADE,
FOREIGN KEY (id_empleado)  REFERENCES empleado(id_empleado)   ON UPDATE CASCADE,
CONSTRAINT chk_compra_total CHECK (total > 0)
);

-- detalle_compra
-- Justificación CHECK:
--   Misma lógica que detalle_renta; cantidad, precio
--   y subtotal no pueden ser cero ni negativos.

CREATE TABLE detalle_compra (
id_detalle_compra INT NOT NULL AUTO_INCREMENT,
id_compra INT NOT NULL,
id_video INT NOT NULL,
cantidad INT NOT NULL DEFAULT 1,
precio_unitario DECIMAL(10,2) NOT NULL,
subtotal DECIMAL(10,2) NOT NULL,
PRIMARY KEY (id_detalle_compra),
FOREIGN KEY (id_compra) REFERENCES compra(id_compra) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY (id_video)  REFERENCES video(id_video) ON UPDATE CASCADE,
CONSTRAINT chk_detalle_compra_cantidad CHECK (cantidad >= 1),
CONSTRAINT chk_detalle_compra_precio CHECK (precio_unitario > 0),
CONSTRAINT chk_detalle_compra_subtotal CHECK (subtotal > 0)
);

-- renta
-- Justificación NOT NULL:
--   Todos los campos son obligatorios; una renta sin
--   fecha, cliente o empleado es inválida.
-- Justificación CHECK:
--   fecha_limite > fecha_renta: la fecha de devolución
--   esperada siempre debe ser posterior a la fecha de renta.
--   estado solo acepta: activa, completada, cancelada.

CREATE TABLE renta (
id_renta INT NOT NULL AUTO_INCREMENT,
fecha_renta DATE NOT NULL,
fecha_limite DATE NOT NULL,
estado VARCHAR(30) NOT NULL DEFAULT 'activa',
id_cliente INT NOT NULL,
id_empleado INT NOT NULL,
PRIMARY KEY (id_renta),
FOREIGN KEY (id_cliente)  REFERENCES cliente(id_cliente)   ON UPDATE CASCADE,
FOREIGN KEY (id_empleado) REFERENCES empleado(id_empleado) ON UPDATE CASCADE,
CONSTRAINT chk_renta_fechas CHECK (fecha_limite > fecha_renta),
CONSTRAINT chk_renta_estado CHECK (estado IN ('activa', 'completada', 'cancelada'))
);

-- detalle_renta
-- Justificación CHECK:
--   cantidad >= 1: no se puede rentar 0 o menos unidades.
--   precio_unitario > 0: el precio debe ser positivo.
--   subtotal > 0: resultado de cantidad * precio_unitario.

CREATE TABLE detalle_renta (
id_detalle_renta INT NOT NULL AUTO_INCREMENT,
id_renta INT NOT NULL,
id_video INT NOT NULL,
cantidad INT NOT NULL DEFAULT 1,
precio_unitario DECIMAL(10,2) NOT NULL,
subtotal DECIMAL(10,2) NOT NULL,
PRIMARY KEY (id_detalle_renta),
FOREIGN KEY (id_renta) REFERENCES renta(id_renta) ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY (id_video) REFERENCES video(id_video) ON UPDATE CASCADE,
CONSTRAINT chk_detalle_renta_cantidad CHECK (cantidad >= 1),
CONSTRAINT chk_detalle_renta_precio CHECK (precio_unitario > 0),
CONSTRAINT chk_detalle_renta_subtotal CHECK (subtotal > 0)
);

-- factura
-- Justificación NOT NULL:
--   Todos los campos son obligatorios para que la factura
--   sea un documento financiero válido.
-- Justificación CHECK:
--   subtotal > 0: toda factura debe tener un monto base.
--   descuento >= 0: no puede haber descuento negativo.
--   total > 0: el monto final siempre debe ser positivo.

CREATE TABLE factura (
id_factura INT NOT NULL AUTO_INCREMENT,
id_renta INT NOT NULL,
fecha DATE NOT NULL,
subtotal DECIMAL(10,2) NOT NULL DEFAULT 0.00,
descuento DECIMAL(10,2) NOT NULL DEFAULT 0.00,
total DECIMAL(10,2) NOT NULL DEFAULT 0.00,
PRIMARY KEY (id_factura),
FOREIGN KEY (id_renta) REFERENCES renta(id_renta) ON UPDATE CASCADE,
CONSTRAINT chk_factura_subtotal CHECK (subtotal > 0),
CONSTRAINT chk_factura_descuento CHECK (descuento >= 0),
CONSTRAINT chk_factura_total CHECK (total > 0)
);

-- devolucion
-- Justificación NOT NULL:
--   Todos los campos son obligatorios; una devolución
--   sin fecha, renta o empleado es inválida.
-- Justificación CHECK:
--   estado solo acepta: completada, pendiente, rechazada.

CREATE TABLE devolucion (
id_devolucion INT NOT NULL AUTO_INCREMENT,
id_renta INT NOT NULL,
id_empleado INT NOT NULL,
id_mora INT NULL,
fecha_devolucion DATE NOT NULL,
estado VARCHAR(30) NOT NULL,
PRIMARY KEY (id_devolucion),
FOREIGN KEY (id_renta) REFERENCES renta(id_renta) ON UPDATE CASCADE,
FOREIGN KEY (id_empleado) REFERENCES empleado(id_empleado) ON UPDATE CASCADE
);

-- mora
-- Justificación NOT NULL:
--   Todos los campos son obligatorios para registrar
--   correctamente el cobro por atraso.
-- Justificación CHECK:
--   dias_atraso >= 1: si existe una mora, hubo al menos
--   un día de atraso.
--   monto > 0: toda mora tiene un valor a cobrar.
--   estado_pago solo acepta: pendiente, pagado, condonado.

CREATE TABLE mora (
id_mora INT NOT NULL AUTO_INCREMENT,
id_devolucion INT NOT NULL,
dias_atraso INT NOT NULL DEFAULT 0,
monto DECIMAL(10,2) NOT NULL DEFAULT 0.00,
estado_pago  VARCHAR(30) NOT NULL,
PRIMARY KEY (id_mora),
FOREIGN KEY (id_devolucion) REFERENCES devolucion(id_devolucion) ON UPDATE CASCADE ON DELETE CASCADE,
CONSTRAINT chk_mora_dias CHECK (dias_atraso >= 1),
CONSTRAINT chk_mora_monto CHECK (monto > 0),
CONSTRAINT chk_mora_estado CHECK (estado_pago IN ('pendiente', 'pagado', 'condonado'))
);

ALTER TABLE devolucion ADD CONSTRAINT fk_devolucion_mora
FOREIGN KEY (id_mora) REFERENCES mora(id_mora) ON UPDATE CASCADE;

DELIMITER //

-- Trigger de UPDATE para la tabla video
CREATE TRIGGER trg_audit_video_update
AFTER UPDATE ON video
FOR EACH ROW
BEGIN
    INSERT INTO auditoria (
        tabla_afectada,
        operacion,
        id_registro_afectado,
        datos_anteriores,
        datos_nuevos,
        usuario_app,
        usuario_db
    )
    VALUES (
        'video',
        'UPDATE',
        OLD.id_video,
        CONCAT('Código: ', OLD.codigo, ' | Título: ', OLD.titulo, ' | Precio: Q', OLD.precio_renta, ' | Stock: ', OLD.stock, ' | Estado: ', OLD.estado),
        CONCAT('Código: ', NEW.codigo, ' | Título: ', NEW.titulo, ' | Precio: Q', NEW.precio_renta, ' | Stock: ', NEW.stock, ' | Estado: ', NEW.estado),
        @app_usuario,
        CURRENT_USER()
    );
END //

-- triggers creados con IA

-- Trigger de DELETE para la tabla video
CREATE TRIGGER trg_audit_video_delete
AFTER DELETE ON video
FOR EACH ROW
BEGIN
    INSERT INTO auditoria (
        tabla_afectada,
        operacion,
        id_registro_afectado,
        datos_anteriores,
        usuario_app,
        usuario_db
    )
    VALUES (
        'video',
        'DELETE',
        OLD.id_video,
        CONCAT('Código: ', OLD.codigo, ' | Título: ', OLD.titulo, ' | Precio: Q', OLD.precio_renta, ' | Stock: ', OLD.stock),
        @app_usuario,
        CURRENT_USER()
    );
END //

DELIMITER ;