-- Bases de datos Renta de Video
Create database RentaVideoVHS

-- TABLA DIRECCION

CREATE TABLE direccion (
    id_direccion INT IDENTITY(1,1) PRIMARY KEY,
    calle VARCHAR(150) NOT NULL,
    ciudad VARCHAR(100) NOT NULL,
    departamento VARCHAR(100),
    pais VARCHAR(80) NOT NULL DEFAULT 'Guatemala'
);
GO

-- ==========================================
-- TABLA EMPLEADO
-- ==========================================

CREATE TABLE empleado (
    id_empleado INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    puesto VARCHAR(50) NOT NULL,
    telefono VARCHAR(20)
);
GO

-- ==========================================
-- TABLA CLIENTE
-- ==========================================

CREATE TABLE cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    telefono VARCHAR(20),
    id_direccion INT,

    CONSTRAINT FK_cliente_direccion
        FOREIGN KEY(id_direccion)
        REFERENCES direccion(id_direccion)
        ON UPDATE CASCADE
        ON DELETE SET NULL
);
GO

-- ==========================================
-- TABLA PROVEEDOR
-- ==========================================

CREATE TABLE proveedor (
    id_proveedor INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    telefono VARCHAR(20),
    id_direccion INT,

    CONSTRAINT FK_proveedor_direccion
        FOREIGN KEY(id_direccion)
        REFERENCES direccion(id_direccion)
        ON UPDATE CASCADE
        ON DELETE SET NULL
);
GO

-- ==========================================
-- TABLA TIPO MEMBRESIA
-- ==========================================

CREATE TABLE tipo_membresia (
    id_tipo_membresia INT IDENTITY(1,1) PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL,
    descuento_disponible BIT NOT NULL DEFAULT 0,

    CONSTRAINT UQ_tipo UNIQUE(tipo)
);
GO

-- ==========================================
-- TABLA MEMBRESIA
-- ==========================================

CREATE TABLE membresia (
    id_membresia INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente INT NOT NULL,
    id_tipo_membresia INT NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE,
    videos_acumulados INT NOT NULL DEFAULT 0,

    CONSTRAINT FK_membresia_cliente
        FOREIGN KEY(id_cliente)
        REFERENCES cliente(id_cliente)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    CONSTRAINT FK_membresia_tipo
        FOREIGN KEY(id_tipo_membresia)
        REFERENCES tipo_membresia(id_tipo_membresia)
        ON UPDATE CASCADE,

    CONSTRAINT CHK_membresia_fechas
        CHECK(fecha_fin IS NULL OR fecha_fin > fecha_inicio),

    CONSTRAINT CHK_membresia_videos
        CHECK(videos_acumulados >= 0)
);
GO

-- ==========================================
-- TABLA VIDEO
-- ==========================================

CREATE TABLE video (
    id_video INT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(150) NOT NULL,
    genero VARCHAR(50),
    precio_renta DECIMAL(10,2) NOT NULL DEFAULT 0,
    stock INT NOT NULL DEFAULT 0,
    estado VARCHAR(30) NOT NULL DEFAULT 'disponible',

    CONSTRAINT CHK_video_precio
        CHECK(precio_renta > 0),

    CONSTRAINT CHK_video_stock
        CHECK(stock >= 0),

    CONSTRAINT CHK_video_estado
        CHECK(estado IN ('disponible','rentado','dañado','dado_de_baja'))
);
GO

-- ==========================================
-- TABLA RENTA
-- ==========================================

CREATE TABLE renta (
    id_renta INT IDENTITY(1,1) PRIMARY KEY,
    fecha_renta DATE NOT NULL,
    fecha_limite DATE NOT NULL,
    estado VARCHAR(30) NOT NULL DEFAULT 'activa',
    id_cliente INT NOT NULL,
    id_empleado INT NOT NULL,

    CONSTRAINT FK_renta_cliente
        FOREIGN KEY(id_cliente)
        REFERENCES cliente(id_cliente)
        ON UPDATE CASCADE,

    CONSTRAINT FK_renta_empleado
        FOREIGN KEY(id_empleado)
        REFERENCES empleado(id_empleado)
        ON UPDATE CASCADE,

    CONSTRAINT CHK_renta_fechas
        CHECK(fecha_limite > fecha_renta),

    CONSTRAINT CHK_renta_estado
        CHECK(estado IN ('activa','completada','cancelada'))
);
GO

-- ==========================================
-- TABLA DETALLE RENTA
-- ==========================================

CREATE TABLE detalle_renta (
    id_detalle_renta INT IDENTITY(1,1) PRIMARY KEY,
    id_renta INT NOT NULL,
    id_video INT NOT NULL,
    cantidad INT NOT NULL DEFAULT 1,
    precio_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_detalle_renta
        FOREIGN KEY(id_renta)
        REFERENCES renta(id_renta)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    CONSTRAINT FK_detalle_video
        FOREIGN KEY(id_video)
        REFERENCES video(id_video)
        ON UPDATE CASCADE,

    CONSTRAINT CHK_detalle_renta_cantidad
        CHECK(cantidad >= 1),

    CONSTRAINT CHK_detalle_renta_precio
        CHECK(precio_unitario > 0),

    CONSTRAINT CHK_detalle_renta_subtotal
        CHECK(subtotal > 0)
);
GO

-- ==========================================
-- TABLA COMPRA
-- ==========================================

CREATE TABLE compra (
    id_compra INT IDENTITY(1,1) PRIMARY KEY,
    fecha DATE NOT NULL,
    total DECIMAL(10,2) NOT NULL DEFAULT 0,
    id_proveedor INT NOT NULL,
    id_empleado INT NOT NULL,

    CONSTRAINT FK_compra_proveedor
        FOREIGN KEY(id_proveedor)
        REFERENCES proveedor(id_proveedor)
        ON UPDATE CASCADE,

    CONSTRAINT FK_compra_empleado
        FOREIGN KEY(id_empleado)
        REFERENCES empleado(id_empleado)
        ON UPDATE CASCADE,

    CONSTRAINT CHK_compra_total
        CHECK(total > 0)
);
GO

-- ==========================================
-- TABLA DETALLE COMPRA
-- ==========================================

CREATE TABLE detalle_compra (
    id_detalle_compra INT IDENTITY(1,1) PRIMARY KEY,
    id_compra INT NOT NULL,
    id_video INT NOT NULL,
    cantidad INT NOT NULL DEFAULT 1,
    precio_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_detalle_compra
        FOREIGN KEY(id_compra)
        REFERENCES compra(id_compra)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    CONSTRAINT FK_detalle_compra_video
        FOREIGN KEY(id_video)
        REFERENCES video(id_video)
        ON UPDATE CASCADE,

    CONSTRAINT CHK_detalle_compra_cantidad
        CHECK(cantidad >= 1),

    CONSTRAINT CHK_detalle_compra_precio
        CHECK(precio_unitario > 0),

    CONSTRAINT CHK_detalle_compra_subtotal
        CHECK(subtotal > 0)
);
GO

-- ==========================================
-- TABLA FACTURA
-- ==========================================

CREATE TABLE factura (
    id_factura INT IDENTITY(1,1) PRIMARY KEY,
    id_renta INT NOT NULL,
    fecha DATE NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL DEFAULT 0,
    descuento DECIMAL(10,2) NOT NULL DEFAULT 0,
    total DECIMAL(10,2) NOT NULL DEFAULT 0,

    CONSTRAINT FK_factura_renta
        FOREIGN KEY(id_renta)
        REFERENCES renta(id_renta)
        ON UPDATE CASCADE,

    CONSTRAINT CHK_factura_subtotal
        CHECK(subtotal > 0),

    CONSTRAINT CHK_factura_descuento
        CHECK(descuento >= 0),

    CONSTRAINT CHK_factura_total
        CHECK(total > 0)
);
GO

CREATE TABLE devolucion (
    id_devolucion INT IDENTITY(1,1) PRIMARY KEY,
    id_renta INT NOT NULL,
    id_empleado INT NOT NULL,
    fecha_devolucion DATE NOT NULL,
    estado VARCHAR(30) NOT NULL,

    CONSTRAINT FK_devolucion_renta
        FOREIGN KEY(id_renta)
        REFERENCES renta(id_renta),

    CONSTRAINT FK_devolucion_empleado
        FOREIGN KEY(id_empleado)
        REFERENCES empleado(id_empleado),

    CONSTRAINT CHK_devolucion_estado
        CHECK (estado IN ('completada','pendiente','rechazada'))
);
GO

-- ==========================================
-- TABLA MORA
-- ==========================================

CREATE TABLE mora (
    id_mora INT IDENTITY(1,1) PRIMARY KEY,
    id_devolucion INT NOT NULL,
    dias_atraso INT NOT NULL DEFAULT 0,
    monto DECIMAL(10,2) NOT NULL DEFAULT 0,
    estado_pago VARCHAR(30) NOT NULL,

    CONSTRAINT FK_mora_devolucion
        FOREIGN KEY(id_devolucion)
        REFERENCES devolucion(id_devolucion)
        ON DELETE CASCADE,

    CONSTRAINT CHK_mora_dias
        CHECK (dias_atraso >= 1),

    CONSTRAINT CHK_mora_monto
        CHECK (monto > 0),

    CONSTRAINT CHK_mora_estado
        CHECK (estado_pago IN ('pendiente','pagado','condonado'))
);
GO
-- ==========================================
-- CONSULTA DE MORA
-- ==========================================

SELECT
    f.id_factura,
    f.total,
    mo.monto AS valor_mora,
    mo.dias_atraso,
    mo.estado_pago
FROM factura f
INNER JOIN renta r
    ON f.id_renta = r.id_renta
INNER JOIN devolucion dv
    ON dv.id_renta = r.id_renta
INNER JOIN mora mo
    ON mo.id_devolucion = dv.id_devolucion;
GO


--MEJORA tabla video 

ALTER TABLE video
ADD
    codigo VARCHAR(20) NOT NULL,
    director VARCHAR(100) NOT NULL,
    anio SMALLINT NOT NULL;
GO

ALTER TABLE video
ADD CONSTRAINT UQ_video_codigo UNIQUE(codigo);
GO