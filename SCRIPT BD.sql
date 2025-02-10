
IF OBJECT_ID('PedidoPizza', 'U') IS NOT NULL
    DROP TABLE PedidoPizza;

IF OBJECT_ID('Pizza_Ingredientes', 'U') IS NOT NULL
    DROP TABLE Pizza_Ingredientes;

IF OBJECT_ID('Pedido', 'U') IS NOT NULL
    DROP TABLE Pedido;

IF OBJECT_ID('Usuarios', 'U') IS NOT NULL
    DROP TABLE Usuarios;

IF OBJECT_ID('Pizza', 'U') IS NOT NULL
    DROP TABLE Pizza;

IF OBJECT_ID('Ingredientes', 'U') IS NOT NULL
    DROP TABLE Ingredientes;

CREATE TABLE Usuarios (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido1 VARCHAR(50) NOT NULL,
    Apellido2 VARCHAR(50) NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    Telefono VARCHAR(15) NOT NULL,
    Contrasena VARCHAR(50) NOT NULL,
    Rol VARCHAR(20) NOT NULL
);

CREATE TABLE Pedido (
    ID_Pedido INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT NOT NULL,
    Fecha DATE NOT NULL,
    PrecioFinal DECIMAL(10, 2) NOT NULL,
    Direccion VARCHAR(100) NOT NULL DEFAULT 'micasa',
    Estado VARCHAR(20) NOT NULL,
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(ID)
);

CREATE TABLE Pizza (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL UNIQUE,
    Tamano VARCHAR(20) NOT NULL
);

CREATE TABLE Ingredientes (
    Id_Ingrediente INT PRIMARY KEY,
    Nombre_ingrediente VARCHAR(50) NOT NULL,
    Precio_ingrediente DECIMAL(10, 2) NOT NULL
);

CREATE TABLE PedidoPizza (
    Id_PedidoPizza INT IDENTITY(1,1) PRIMARY KEY,
    Id_Pedido INT NOT NULL,
    Id_Pizza INT NOT NULL,
    Cantidad INT NOT NULL,
    FOREIGN KEY (Id_Pedido) REFERENCES Pedido(ID_Pedido),
    FOREIGN KEY (Id_Pizza) REFERENCES Pizza(ID)
);

CREATE TABLE Pizza_Ingredientes (
    Id_pizza INT NOT NULL,
    Id_ingrediente INT NOT NULL,
    Cantidad INT NOT NULL,
    FOREIGN KEY (Id_pizza) REFERENCES Pizza(ID),
    FOREIGN KEY (Id_ingrediente) REFERENCES Ingredientes(Id_Ingrediente),
    PRIMARY KEY (Id_pizza, Id_ingrediente)
);

INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES( 1, 'Tomate', 2)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (2, 'Carbonara', 1.5)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (3, 'Barbacoa', 1)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (4, 'Mozzarela', 2.5)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (5, 'Cheddar', 1.7)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (6, 'Suizo', 2)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (7, '4Quesos', 2.3)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (8, 'Ternera', 4)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (9, 'Pollo', 3.6)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (10, 'Cerdo', 4.3)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (11, 'Atun', 3)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (12, 'Pepperoni', 2.3)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (13, 'Champiñon', 1.6)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (14, 'Cebolla', 2.1)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (15, 'Aceitunas', 2.5)
INSERT INTO Ingredientes (Id_ingrediente, Nombre_ingrediente, Precio_ingrediente) VALUES (16, 'Pimieneto', 1.1)

INSERT INTO Usuarios (Nombre,Apellido1,Apellido2,Correo,Telefono,Contrasena,Rol) VALUES('admin','admin','admin','admin@gmail.com','123456789','admin','admin')

INSERT INTO Pizza (Nombre, Tamano) VALUES ('4 Quesos', 'Mediana')
INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (1, 7, 1)

INSERT INTO Pizza (Nombre, Tamano) VALUES ('Barbacoa', 'Mediana')
INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (2, 3, 1)
INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (2, 4, 1)
INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (2, 10, 1)

INSERT INTO Pizza (Nombre, Tamano) VALUES ('Carbonara', 'Mediana')
INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (3, 2, 1)
INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (3, 4, 1)
INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (3, 10, 1)
INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (3, 13, 1)





