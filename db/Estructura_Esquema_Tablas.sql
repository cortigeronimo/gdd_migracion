USE GD2C2018
GO

-- CREANDO SCHEMA SI NO EXISTE

IF (NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'PLEASE_HELP'))
	BEGIN
		EXEC('CREATE SCHEMA PLEASE_HELP AUTHORIZATION gdEspectaculos2018');
	END;

GO

-- CREANDO TABLAS SI NO EXISTEN

IF OBJECT_ID('PLEASE_HELP.ROL_FUNCIONALIDAD') IS NOT NULL DROP TABLE PLEASE_HELP.ROL_FUNCIONALIDAD;

IF OBJECT_ID('PLEASE_HELP.FUNCIONALIDAD') IS NOT NULL DROP TABLE PLEASE_HELP.FUNCIONALIDAD;

IF OBJECT_ID('PLEASE_HELP.USUARIO_ROL') IS NOT NULL DROP TABLE PLEASE_HELP.USUARIO_ROL;

IF OBJECT_ID('PLEASE_HELP.ROL') IS NOT NULL DROP TABLE PLEASE_HELP.ROL;

IF OBJECT_ID('PLEASE_HELP.ITEM') IS NOT NULL DROP TABLE PLEASE_HELP.ITEM;

IF OBJECT_ID('PLEASE_HELP.COMPRA') IS NOT NULL DROP TABLE PLEASE_HELP.COMPRA;

IF OBJECT_ID('PLEASE_HELP.UBICACION') IS NOT NULL DROP TABLE PLEASE_HELP.UBICACION;

IF OBJECT_ID('PLEASE_HELP.PUBLICACION') IS NOT NULL DROP TABLE PLEASE_HELP.PUBLICACION;

IF OBJECT_ID('PLEASE_HELP.RUBRO') IS NOT NULL DROP TABLE PLEASE_HELP.RUBRO;

IF OBJECT_ID('PLEASE_HELP.ESTADO') IS NOT NULL DROP TABLE PLEASE_HELP.ESTADO;

IF OBJECT_ID('PLEASE_HELP.GRADO') IS NOT NULL DROP TABLE PLEASE_HELP.GRADO;

IF OBJECT_ID('PLEASE_HELP.PUNTUACION') IS NOT NULL DROP TABLE PLEASE_HELP.PUNTUACION;

IF OBJECT_ID('PLEASE_HELP.USUARIO_PREMIO') IS NOT NULL DROP TABLE PLEASE_HELP.USUARIO_PREMIO;

IF OBJECT_ID('PLEASE_HELP.PREMIO') IS NOT NULL DROP TABLE PLEASE_HELP.PREMIO;

IF OBJECT_ID('PLEASE_HELP.FACTURA') IS NOT NULL DROP TABLE PLEASE_HELP.FACTURA;

IF OBJECT_ID('PLEASE_HELP.EMPRESA') IS NOT NULL DROP TABLE PLEASE_HELP.EMPRESA;

IF OBJECT_ID('PLEASE_HELP.CLIENTE') IS NOT NULL DROP TABLE PLEASE_HELP.CLIENTE;

IF OBJECT_ID('PLEASE_HELP.USUARIO') IS NOT NULL DROP TABLE PLEASE_HELP.USUARIO;

-- CREANDO PROCEDURES SI NO EXISTEN

IF OBJECT_ID('PLEASE_HELP.SP_MIGRAR_CLIENTES') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_MIGRAR_CLIENTES;

IF OBJECT_ID('PLEASE_HELP.SP_MIGRAR_EMPRESAS') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_MIGRAR_EMPRESAS;

IF OBJECT_ID('PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS_CLIENTE') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS_CLIENTE;

IF OBJECT_ID('PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS_EMPRESA') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS_EMPRESA;

IF OBJECT_ID('PLEASE_HELP.SP_LISTA_ROLES_USUARIO') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_LISTA_ROLES_USUARIO;

IF OBJECT_ID('PLEASE_HELP.SP_LIMPIAR_INTENTOS_FALLIDOS_CLIENTE') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_LIMPIAR_INTENTOS_FALLIDOS_CLIENTE;

IF OBJECT_ID('PLEASE_HELP.SP_LIMPIAR_INTENTOS_FALLIDOS_EMPRESA') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_LIMPIAR_INTENTOS_FALLIDOS_EMPRESA;

IF OBJECT_ID('PLEASE_HELP.SP_ALTA_CLIENTE') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_ALTA_CLIENTE;

IF OBJECT_ID('PLEASE_HELP.SP_ALTA_EMPRESA') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_ALTA_EMPRESA;

IF OBJECT_ID('PLEASE_HELP.SP_LISTA_FUNCIONALIDADES') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_LISTA_FUNCIONALIDADES;

IF OBJECT_ID('PLEASE_HELP.SP_CREATE_IDENTITY_CONSTRAINT_PUBLICACION') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_CREATE_IDENTITY_CONSTRAINT_PUBLICACION;

IF OBJECT_ID('PLEASE_HELP.SP_CREATE_IDENTITY_CONSTRAINT_FACTURA') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_CREATE_IDENTITY_CONSTRAINT_FACTURA;

IF OBJECT_ID('PLEASE_HELP.SP_GENERAR_PUBLICACION') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_GENERAR_PUBLICACION;

IF OBJECT_ID('PLEASE_HELP.SP_LISTA_PUBLICACIONES') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_LISTA_PUBLICACIONES;

IF OBJECT_ID('PLEASE_HELP.SP_INSERTAR_UBICACION') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_INSERTAR_UBICACION;

IF OBJECT_ID('PLEASE_HELP.SP_CAMBIAR_ESTADO_PUBLICACION') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_CAMBIAR_ESTADO_PUBLICACION;

IF OBJECT_ID('PLEASE_HELP.SP_GET_UBICACIONES_BY_USER') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_GET_UBICACIONES_BY_USER;

IF OBJECT_ID('PLEASE_HELP.SP_DELETE_PUBLICACION_UBICACIONES') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_DELETE_PUBLICACION_UBICACIONES;

IF OBJECT_ID('PLEASE_HELP.SP_UPDATE_PUBLICACION') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_UPDATE_PUBLICACION;

IF OBJECT_ID('PLEASE_HELP.SP_PUBLICACIONES_MISMA_FECHAHORA') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_PUBLICACIONES_MISMA_FECHAHORA;

IF OBJECT_ID('PLEASE_HELP.SP_PRIMER_LOGIN') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_PRIMER_LOGIN;

IF OBJECT_ID('PLEASE_HELP.SP_CAMBIAR_CONTRASEÑA') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_CAMBIAR_CONTRASEÑA;

IF OBJECT_ID('PLEASE_HELP.SP_CANJEAR_PUNTOS') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_CANJEAR_PUNTOS;

IF OBJECT_ID('PLEASE_HELP.SP_GET_HISTORIAL_CLIENTE') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_GET_HISTORIAL_CLIENTE;

IF OBJECT_ID('PLEASE_HELP.SP_GET_PREMIOS') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_GET_PREMIOS;

IF OBJECT_ID('PLEASE_HELP.SP_GET_PUBLICACIONES_ACTIVAS') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_GET_PUBLICACIONES_ACTIVAS;

IF OBJECT_ID('PLEASE_HELP.SP_GET_UBICACIONES_DISPONIBLES') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_GET_UBICACIONES_DISPONIBLES;

IF OBJECT_ID('PLEASE_HELP.SP_ADD_NRO_TARJETA_CREDITO') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_ADD_NRO_TARJETA_CREDITO;

IF OBJECT_ID('PLEASE_HELP.SP_COMPRAR_ENTRADA') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_COMPRAR_ENTRADA;

IF OBJECT_ID('PLEASE_HELP.SP_MODIFICACION_EMPRESA') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_MODIFICACION_EMPRESA;



-- CREANDO TRIGGERS SI NO EXISTEN

IF OBJECT_ID('PLEASE_HELP.TR_INHABILITAR_USUARIO_CLIENTE') IS NOT NULL DROP TRIGGER PLEASE_HELP.TR_INHABILITAR_USUARIO_CLIENTE;

IF OBJECT_ID('PLEASE_HELP.TR_INHABILITAR_USUARIO_EMPRESA') IS NOT NULL DROP TRIGGER PLEASE_HELP.TR_INHABILITAR_USUARIO_EMPRESA;

IF OBJECT_ID('PLEASE_HELP.TR_ADD_ROL_AFTER_INSERT_CLIENTE') IS NOT NULL DROP TRIGGER PLEASE_HELP.TR_ADD_ROL_AFTER_INSERT_CLIENTE;

IF OBJECT_ID('PLEASE_HELP.TR_ADD_ROL_AFTER_INSERT_EMPRESA') IS NOT NULL DROP TRIGGER PLEASE_HELP.TR_ADD_ROL_AFTER_INSERT_EMPRESA;

IF OBJECT_ID('PLEASE_HELP.TR_AFTER_FIRST_LOGIN') IS NOT NULL DROP TRIGGER PLEASE_HELP.TR_AFTER_FIRST_LOGIN;

IF OBJECT_ID('PLEASE_HELP.TR_AFTER_COMPRA_ENTRADA') IS NOT NULL DROP TRIGGER PLEASE_HELP.TR_AFTER_COMPRA_ENTRADA;

-- CREANDO ESTRUCTURAS DE TABLAS

create table PLEASE_HELP.Funcionalidad
(
	Func_Id int identity(1,1), 
	Func_Desc nvarchar(50) NOT NULL, 
	CONSTRAINT UQ_FUNCIONALIDAD_DESC UNIQUE (Func_Desc),
	CONSTRAINT PK_FUNCIONALIDAD_ID PRIMARY KEY (Func_Id)
)

create table PLEASE_HELP.Rol_Funcionalidad
(
	Rol_Id int, 
	Func_Id int,
	CONSTRAINT PK_ROLXFUNC PRIMARY KEY (Rol_Id, Func_Id)
)

create table PLEASE_HELP.Rol
(
	Rol_Id int identity(1,1), 
	Rol_Nombre nvarchar(20) NOT NULL, 
	Rol_Habilitado bit DEFAULT 1,
	CONSTRAINT UQ_ROL_NOMBRE UNIQUE (Rol_Nombre),
	CONSTRAINT PK_ROL_ID PRIMARY KEY (Rol_Id)
)

create table PLEASE_HELP.Usuario_Rol
(
	Usuario_Id int, 
	Rol_Id int,
	CONSTRAINT PK_USUARIOXROL PRIMARY KEY (Usuario_Id, Rol_Id)
)

create table PLEASE_HELP.Usuario
(
	Usuario_Id int identity(1,1), 
	Usuario_Username nvarchar(50) NOT NULL, 
	--Usuario_Password nvarchar(100),
	Usuario_Password varbinary(255),
	CONSTRAINT UQ_USUARIO_USERNAME UNIQUE (Usuario_Username),
	CONSTRAINT PK_USUARIO_ID PRIMARY KEY (Usuario_Id)
)

create table PLEASE_HELP.Cliente
(
	Cli_Usuario int,
	Cli_Nombre nvarchar(255),
	Cli_Apellido nvarchar(255),
	Cli_Tipo_Documento nvarchar(255),
	Cli_Nro_Documento numeric(18,0),
	Cli_Cuil numeric(11,0),
	Cli_Email nvarchar(255),
	Cli_Telefono numeric(15,0),
	Cli_Localidad nvarchar(255),
	Cli_Direccion nvarchar(255),
	Cli_Nro_Piso numeric(18,0),
	Cli_Depto nvarchar(255),
	Cli_Cod_Postal nvarchar(255),
	Cli_Fecha_Nac datetime,
	Cli_Fecha_Creacion datetime,
	Cli_Tarjeta_Credito nvarchar(255),
	Cli_Puntos int NOT NULL DEFAULT 0,
	Cli_Habilitado bit DEFAULT 1,
	Cli_Intentos_Fallidos smallint DEFAULT 0,
	Cli_Baja bit DEFAULT 0,
	Cli_Primer_Login bit DEFAULT 0,
	CONSTRAINT PK_CLIENTE_USUARIO PRIMARY KEY (Cli_Usuario)
)

create table PLEASE_HELP.Empresa
(
	Emp_Usuario int,
	Emp_Razon_Social nvarchar(255),
	Emp_Email nvarchar(50),
	Emp_Telefono numeric(15,0),
	Emp_Localidad nvarchar(255),
	Emp_Direccion nvarchar(50),
	Emp_Piso numeric(18,0),
	Emp_Depto nvarchar(50),
	Emp_Cod_Postal nvarchar(50),
	Emp_Ciudad nvarchar(255),
	Emp_Cuit nvarchar(255),
	Emp_Habilitado bit DEFAULT 1,
	Emp_Intentos_Fallidos smallint DEFAULT 0,
	Emp_Baja bit DEFAULT 0,
	Emp_Primer_Login bit DEFAULT 0,
	CONSTRAINT PK_EMPRESA_USUARIO PRIMARY KEY (Emp_Usuario)
)

create table PLEASE_HELP.Publicacion
(
	Pub_Codigo numeric(18,0) identity(1,1),
	Pub_Fecha_Inicio datetime,
	Pub_Fecha_Evento datetime,
	Pub_Descripcion nvarchar(255),
	Pub_Direccion nvarchar(255),
	Pub_Rubro int,
	Pub_Grado int,
	Pub_Empresa int,
	Pub_Estado int,
	CONSTRAINT PK_PUBLICACION_CODIGO PRIMARY KEY (Pub_Codigo),
)

create table PLEASE_HELP.Rubro
(
	Rubro_Id int identity(1,1),
	Rubro_Descripcion nvarchar(255),
	CONSTRAINT PK_RUBRO_ID PRIMARY KEY (Rubro_Id),
	CONSTRAINT UQ_RUBRO_DESCRIPCION UNIQUE (Rubro_Descripcion)
)

create table PLEASE_HELP.Estado
(
	Estado_Id int identity(1,1),
	Estado_Descripcion nvarchar (255),
	CONSTRAINT PK_ESTADO_ID PRIMARY KEY (Estado_Id),
	CONSTRAINT UQ_ESTADO_DESCRIPCION UNIQUE (Estado_Descripcion)
)

create table PLEASE_HELP.Grado
(
	Grado_Id int identity(1,1),
	Grado_Comision int NOT NULL,
	Grado_Descripcion nvarchar(255),
	CONSTRAINT PK_GRADO_ID PRIMARY KEY (Grado_Id),
	CONSTRAINT UQ_GRADO_DESRCIPCION UNIQUE (Grado_Descripcion)
)

create table PLEASE_HELP.Ubicacion
(
	Ubicacion_Publicacion numeric(18,0),
	Ubicacion_Fila varchar(3),
	Ubicacion_Asiento numeric(18,0),
	Ubicacion_Precio numeric(18,0) NOT NULL,
	Ubicacion_Tipo_Codigo numeric(18,0),
	Ubicacion_Descripcion nvarchar(255),
	Ubicacion_Sin_Numerar bit,
	CONSTRAINT PK_UBICACION_FILAXASIENTOXPUBLICACION 
		PRIMARY KEY (Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Publicacion)
)

create table PLEASE_HELP.Compra
(
--	Compra_Id int,
	Compra_Id int identity(1,1),
	Compra_Cliente int,
	Compra_Cantidad numeric(18,0) NOT NULL,
	Compra_Fecha datetime NOT NULL,
	Compra_Metodo_Pago nvarchar(255) NOT NULL,
	Compra_Email nvarchar(255),
	Compra_Fecha_Rendida datetime,
	Compra_Fila varchar(3) NOT NULL,
	Compra_Asiento numeric(18,0) NOT NULL,
	Compra_Publicacion numeric(18,0),
	CONSTRAINT PK_COMPRA_ID PRIMARY KEY (Compra_Id),
)

create table PLEASE_HELP.Factura
(
	Factura_Nro numeric(18,0) identity(1,1) NOT NULL,
	Factura_Fecha datetime NOT NULL,
	Factura_Total numeric(18,2) NOT NULL,
	Factura_Empresa int,
	CONSTRAINT PK_FACTURA_NRO PRIMARY KEY CLUSTERED (Factura_Nro)
)

create table PLEASE_HELP.Item
(
--	Item_Id int,
	Item_Id int identity(1,1),
	Item_Monto numeric(18,2) NOT NULL,
	Item_Cantidad numeric(18,0) NOT NULL,
	Item_Descripcion nvarchar(60) NOT NULL,
	Item_Factura numeric(18,0),
	Item_Compra int,
	CONSTRAINT PK_ITEM_ID PRIMARY KEY (Item_Id),
)

create table PLEASE_HELP.Puntuacion
(
	Puntuacion_Id int identity(1,1),
	Puntuacion_Cantidad int DEFAULT 0,
	Puntuacion_Fecha_Vencimiento datetime,
	Puntuacion_Cliente int,
	CONSTRAINT PK_PUNTUACION_ID PRIMARY KEY (Puntuacion_Id), 
)

create table PLEASE_HELP.Premio
(
	Premio_Id int identity(1,1),
	Premio_Descripcion nvarchar(50),
	Premio_Puntos int,
	CONSTRAINT PK_PREMIO_ID PRIMARY KEY (Premio_Id),
)

create table PLEASE_HELP.Usuario_Premio
(
	Cli_Usuario int,
	Premio_Id int,
	Premio_Cantidad int DEFAULT 1,
	CONSTRAINT PK_USUARIOXPREMIO PRIMARY KEY (Cli_Usuario, Premio_Id),
)

GO

-- CREANDO FOREIGN KEYS

ALTER TABLE PLEASE_HELP.Rol_Funcionalidad
ADD CONSTRAINT FK_ROLXFUNCIONALIDAD_ROL FOREIGN KEY (Rol_Id) REFERENCES PLEASE_HELP.Rol(Rol_Id),
CONSTRAINT FK_ROLXFUNCIONALIDAD_FUNC FOREIGN KEY (Func_Id) REFERENCES PLEASE_HELP.Funcionalidad(Func_Id)

GO

ALTER TABLE PLEASE_HELP.Usuario_Rol
ADD CONSTRAINT FK_USUARIOXROL_USUARIO FOREIGN KEY (Usuario_Id) REFERENCES PLEASE_HELP.Usuario(Usuario_Id),
CONSTRAINT FK_USUARIOXROL_ROL FOREIGN KEY (Rol_Id) REFERENCES PLEASE_HELP.Rol(Rol_Id)

GO

ALTER TABLE PLEASE_HELP.Cliente
ADD CONSTRAINT FK_CLIENTE_USUARIO FOREIGN KEY (Cli_Usuario) REFERENCES PLEASE_HELP.Usuario(Usuario_Id)

GO

ALTER TABLE PLEASE_HELP.Empresa
ADD CONSTRAINT FK_EMPRESA_USUARIO FOREIGN KEY (Emp_Usuario) REFERENCES PLEASE_HELP.Usuario(Usuario_Id)

GO

ALTER TABLE PLEASE_HELP.Publicacion
ADD CONSTRAINT FK_PUBLICACION_GRADO FOREIGN KEY (Pub_Grado) REFERENCES PLEASE_HELP.Grado(Grado_Id),
CONSTRAINT FK_PUBLICACION_EMPRESA FOREIGN KEY (Pub_Empresa) REFERENCES PLEASE_HELP.Empresa(Emp_Usuario),
CONSTRAINT FK_PUBLICACION_RUBRO FOREIGN KEY (Pub_Rubro) REFERENCES PLEASE_HELP.Rubro(Rubro_Id),
CONSTRAINT FK_PUBLICACION_ESTADO FOREIGN KEY (Pub_Estado) REFERENCES PLEASE_HELP.EStado(Estado_Id)

GO

ALTER TABLE PLEASE_HELP.Ubicacion
ADD CONSTRAINT FK_UBICACION_PUBLICACION FOREIGN KEY (Ubicacion_Publicacion) REFERENCES PLEASE_HELP.Publicacion(Pub_Codigo)

GO

ALTER TABLE PLEASE_HELP.Puntuacion
ADD CONSTRAINT FK_PUNTUACION_CLIENTE FOREIGN KEY (Puntuacion_Cliente) REFERENCES PLEASE_HELP.Cliente(Cli_Usuario)

GO

ALTER TABLE PLEASE_HELP.Compra
ADD CONSTRAINT FK_COMPRA_UBICACION FOREIGN KEY (Compra_Fila, Compra_Asiento, Compra_Publicacion) REFERENCES PLEASE_HELP.Ubicacion(Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Publicacion),
CONSTRAINT FK_COMPRA_CLIENTE FOREIGN KEY (Compra_Cliente) REFERENCES PLEASE_HELP.Cliente(Cli_Usuario)

GO

ALTER TABLE PLEASE_HELP.Factura
ADD CONSTRAINT FK_FACTURA_EMPRESA FOREIGN KEY (Factura_Empresa) REFERENCES PLEASE_HELP.Empresa(Emp_Usuario)

GO

ALTER TABLE PLEASE_HELP.Item
ADD CONSTRAINT FK_ITEM_FACTURA FOREIGN KEY (Item_Factura) REFERENCES PLEASE_HELP.Factura(Factura_Nro),
CONSTRAINT FK_ITEM_COMPRA FOREIGN KEY (Item_Compra) REFERENCES PLEASE_HELP.Compra(Compra_Id)

GO

ALTER TABLE PLEASE_HELP.Usuario_Premio
ADD CONSTRAINT FK_USUARIOXPREMIO_CLIENTE FOREIGN KEY (Cli_Usuario) REFERENCES PLEASE_HELP.Cliente(Cli_Usuario),
CONSTRAINT FK_USUARIOXPREMIO_PREMIO FOREIGN KEY (Premio_Id) REFERENCES PLEASE_HELP.Premio(Premio_Id)

GO

-- CREACION DE FUNCIONALIDADES

INSERT INTO PLEASE_HELP.Funcionalidad (Func_Desc) VALUES ('ABM_ROL'), ('REGISTRO_USUARIO'), ('ABM_CLIENTE'), ('ABM_EMPRESA_ESPECTACULO'),
('ABM_RUBRO'), ('ABM_GRADO_PUBLICACION'), ('GENERAR_PUBLICACION'), ('EDITAR_PUBLICACION'), ('COMPRAR'), ('HISTORIAL_CLIENTE'),
('CANJE_ADMINISTRACION_PUNTOS'), ('GENERAR_PAGOS_COMISIONES'), ('LISTADO_ESTADISTICO');

-- CREACION DE ROLES

INSERT INTO PLEASE_HELP.Rol (Rol_Nombre) VALUES ('EMPRESA'), ('ADMINISTRATIVO'), ('CLIENTE')

--CREACION DE ROLES X FUNCIONALIDADES

INSERT INTO PLEASE_HELP.ROL_FUNCIONALIDAD (Rol_Id, Func_Id) SELECT r.Rol_Id, f.Func_Id FROM PLEASE_HELP.Rol r, PLEASE_HELP.Funcionalidad f WHERE r.Rol_Nombre = 'ADMINISTRATIVO'

INSERT INTO PLEASE_HELP.ROL_FUNCIONALIDAD (Rol_Id, Func_Id) SELECT r.Rol_Id, f.Func_Id FROM PLEASE_HELP.Rol r, PLEASE_HELP.Funcionalidad f WHERE r.Rol_Nombre = 'EMPRESA' AND
f.Func_Desc IN ('REGISTRO_USUARIO', 'ABM_RUBRO', 'ABM_GRADO_PUBLICACION', 'GENERAR_PUBLICACION', 'EDITAR_PUBLICACION')

INSERT INTO PLEASE_HELP.ROL_FUNCIONALIDAD (Rol_Id, Func_Id) SELECT r.Rol_Id, f.Func_Id FROM PLEASE_HELP.Rol r, PLEASE_HELP.Funcionalidad f WHERE r.Rol_Nombre = 'CLIENTE' AND
f.Func_Desc IN ('REGISTRO_USUARIO', 'COMPRAR', 'HISTORIAL_CLIENTE', 'CANJE_ADMINISTRACION_PUNTOS')

GO

-- CREACION DE ADMINISTRADOR DEL SISTEMA

INSERT INTO PLEASE_HELP.Usuario (Usuario_Username, Usuario_Password) VALUES ('admin', HASHBYTES('SHA2_256','w23e'))

-- CREACION DE ADMINISTRADOR X ROL

INSERT INTO PLEASE_HELP.Usuario_Rol (Usuario_Id, Rol_Id) 
SELECT u.Usuario_Id, (SELECT r.Rol_Id FROM PLEASE_HELP.Rol r 
WHERE r.Rol_Nombre = 'ADMINISTRATIVO') FROM PLEASE_HELP.Usuario u WHERE u.Usuario_Username = 'admin'

GO

-- CREACION DE CLIENTES

CREATE PROCEDURE PLEASE_HELP.SP_MIGRAR_CLIENTES AS 
BEGIN
	BEGIN TRANSACTION

		INSERT INTO PLEASE_HELP.Usuario (Usuario_Username, Usuario_Password) 
		SELECT 'USUARIO' + CAST(Cli_Dni AS varchar(225)), HASHBYTES('SHA2_256', CAST(Cli_Dni AS VARCHAR(255)))
		FROM gd_esquema.Maestra 
		WHERE Cli_Dni IS NOT NULL
		GROUP BY Cli_Dni

		

		INSERT INTO PLEASE_HELP.Cliente (
			Cli_Usuario,
			Cli_Nombre,
			Cli_Apellido,
			Cli_Tipo_Documento,
			Cli_Nro_Documento,
			Cli_Cuil,
			Cli_Email,
			Cli_Telefono,
			Cli_Localidad,
			Cli_Direccion,
			Cli_Nro_Piso,
			Cli_Depto,
			Cli_Cod_Postal,
			Cli_Fecha_Nac,
			Cli_Fecha_Creacion,
			Cli_Tarjeta_Credito,
			Cli_Habilitado,
			Cli_Intentos_Fallidos,
			Cli_Baja
		)
		SELECT DISTINCT u.Usuario_Id, m.Cli_Nombre, m.Cli_Apeliido, 'DNI', m.Cli_Dni, NULL, m.Cli_Mail, NULL, NULL, m.Cli_Dom_Calle + CAST(m.Cli_Nro_Calle AS nvarchar(255))
		, m.Cli_Piso, m.Cli_Depto, m.Cli_Cod_Postal, m.Cli_Fecha_Nac, getDate(), NULL, 1, 0, 0 
		FROM PLEASE_HELP.Usuario u, gd_esquema.Maestra m 
		WHERE u.Usuario_Username = ('USUARIO' + CAST(m.Cli_Dni AS varchar(225))) AND m.Cli_Dni IS NOT NULL
		
		INSERT INTO PLEASE_HELP.Usuario_Rol (Usuario_Id, Rol_Id)
		SELECT c.Cli_Usuario, (SELECT r.Rol_Id FROM PLEASE_HELP.Rol r WHERE r.Rol_Nombre = 'CLIENTE') FROM PLEASE_HELP.Cliente c


	COMMIT TRANSACTION
END

GO

EXEC PLEASE_HELP.SP_MIGRAR_CLIENTES

GO

-- CREACION DE EMPRESAS

CREATE PROCEDURE PLEASE_HELP.SP_MIGRAR_EMPRESAS AS 
BEGIN
	BEGIN TRANSACTION

		INSERT INTO PLEASE_HELP.Usuario (Usuario_Username, Usuario_Password) 
		SELECT 'EMPRESA' + CAST(Espec_Empresa_Cuit AS varchar(225)), HASHBYTES('SHA2_256', CAST(Espec_Empresa_Cuit AS varchar(255))) 
		FROM gd_esquema.Maestra 
		WHERE Espec_Empresa_Cuit IS NOT NULL
		GROUP BY Espec_Empresa_Cuit

		INSERT INTO PLEASE_HELP.Empresa (
			Emp_Usuario,
			Emp_Razon_Social,
			Emp_Email,
			Emp_Telefono,
			Emp_Localidad,
			Emp_Direccion,
			Emp_Piso,
			Emp_Depto,
			Emp_Cod_Postal,
			Emp_Ciudad,
			Emp_Cuit,
			Emp_Habilitado,
			Emp_Intentos_Fallidos,
			Emp_Baja
		)
		SELECT DISTINCT u.Usuario_Id, m.Espec_Empresa_Razon_Social, m.Espec_Empresa_Mail, NULL, NULL, m.Espec_Empresa_Dom_Calle + CAST(m.Espec_Empresa_Nro_Calle AS nvarchar(255)),
		m.Espec_Empresa_Piso, m.Espec_Empresa_Depto, m.Espec_Empresa_Cod_Postal, NULL, m.Espec_Empresa_Cuit, 1, 0, 0
		FROM PLEASE_HELP.Usuario u, gd_esquema.Maestra m 
		WHERE u.Usuario_Username = ('EMPRESA' + CAST(m.Espec_Empresa_Cuit AS varchar(225))) AND m.Espec_Empresa_Cuit IS NOT NULL

		INSERT INTO PLEASE_HELP.Usuario_Rol (Usuario_Id, Rol_Id)
		SELECT e.Emp_Usuario, (select r.Rol_Id from PLEASE_HELP.Rol r where r.Rol_Nombre = 'EMPRESA') from PLEASE_HELP.EMPRESA e

	COMMIT TRANSACTION
END

GO

EXEC PLEASE_HELP.SP_MIGRAR_EMPRESAS

GO

-- CREACION DE RUBRO

INSERT INTO PLEASE_HELP.Rubro SELECT DISTINCT Espectaculo_Rubro_Descripcion from gd_esquema.Maestra

GO

-- CREACION DE ESTADO

INSERT INTO PLEASE_HELP.Estado(Estado_Descripcion) VALUES ('BORRADOR'), ('PUBLICADA'), ('FINALIZADA')

GO

-- CREACION DE PUBLICACION

CREATE PROCEDURE PLEASE_HELP.SP_CREATE_IDENTITY_CONSTRAINT_PUBLICACION AS
BEGIN
	SET IDENTITY_INSERT PLEASE_HELP.Publicacion ON
	INSERT INTO PLEASE_HELP.Publicacion (Pub_Codigo, Pub_Fecha_Inicio, Pub_Fecha_Evento, Pub_Descripcion,
	Pub_Direccion, Pub_Rubro, Pub_Grado, Pub_Empresa, Pub_Estado)
	SELECT DISTINCT m.Espectaculo_Cod, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc, m.Espectaculo_Descripcion,
	NULL, 1, NULL, e.Emp_Usuario, (SELECT Estado_Id FROM PLEASE_HELP.Estado WHERE Estado_Descripcion = m.Espectaculo_Estado)
	FROM gd_esquema.Maestra m, PLEASE_HELP.Empresa e WHERE e.Emp_Cuit = m.Espec_Empresa_Cuit
	SET IDENTITY_INSERT PLEASE_HELP.Publicacion OFF
	DECLARE @maxid int;
	SELECT @maxid=MAX(Pub_Codigo) FROM PLEASE_HELP.Publicacion;
	DBCC CHECKIDENT ("PLEASE_HELP.Publicacion", RESEED, @maxid);
END

GO
EXEC PLEASE_HELP.SP_CREATE_IDENTITY_CONSTRAINT_PUBLICACION
GO
-- CREACION DE UBICACION

INSERT INTO PLEASE_HELP.Ubicacion SELECT DISTINCT m.Espectaculo_Cod, m.Ubicacion_Fila, m.Ubicacion_Asiento, m.Ubicacion_Precio, m.Ubicacion_Tipo_Codigo,
m.Ubicacion_Tipo_Descripcion, m.Ubicacion_Sin_Numerar FROM gd_esquema.Maestra m

-- CREACION DE GRADOS
INSERT INTO PLEASE_HELP.Grado (Grado_Comision, Grado_Descripcion) VALUES (30, 'ALTA'), (20, 'MEDIA'), (10, 'BAJA')

-- CREACION DE FACTURA
GO
--inserta las facturas y busca el numero de factura mas alto
--para ponerlo continuar desde ahi
CREATE PROCEDURE PLEASE_HELP.SP_CREATE_IDENTITY_CONSTRAINT_FACTURA AS
BEGIN
	SET IDENTITY_INSERT PLEASE_HELP.Factura ON
	INSERT INTO PLEASE_HELP.Factura (m.Factura_nro, m.Factura_Fecha, m.Factura_Total, Factura_Empresa)
	SELECT m.Factura_nro, m.Factura_Fecha, m.Factura_Total, e.Emp_Usuario 
	FROM (select m.Factura_nro, m.Factura_Fecha, m.Factura_Total, m.Espec_Empresa_Cuit
		FROM gd_esquema.Maestra m 
		WHERE m.Factura_Nro IS NOT NULL 
		GROUP BY m.Factura_nro, m.Factura_Fecha, m.Factura_Total, m.Espec_Empresa_Cuit) 
	m inner join PLEASE_HELP.Empresa e
	ON m.Espec_Empresa_Cuit = e.Emp_Cuit
	SET IDENTITY_INSERT PLEASE_HELP.Factura OFF
	DECLARE @maxid int;
	SELECT @maxid=MAX(Factura_Nro) FROM PLEASE_HELP.Factura;
	DBCC CHECKIDENT ("PLEASE_HELP.Factura", RESEED, @maxid);
END

GO
EXEC PLEASE_HELP.SP_CREATE_IDENTITY_CONSTRAINT_FACTURA
GO

INSERT INTO PLEASE_HELP.Compra
SELECT (SELECT c.Cli_Usuario  FROM PLEASE_HELP.Cliente c WHERE Cli_Nro_Documento = g.Cli_Dni), g.Compra_Cantidad, g.Compra_Fecha, g.Forma_Pago_Desc, g.Cli_Mail, g.Factura_Fecha, g.Ubicacion_Fila, g.Ubicacion_Asiento, g.Espectaculo_Cod
FROM gd_esquema.Maestra g
WHERE g.Cli_Dni IS NOT NULL AND g.Forma_Pago_Desc IS NOT NULL 
ORDER BY g.Compra_Fecha ASC

-- CREACION DE ITEMS

INSERT INTO PLEASE_HELP.Item
SELECT G.Item_Factura_Monto, G.Item_Factura_Cantidad, G.Item_Factura_Descripcion, G.Factura_Nro, (SELECT P.Compra_Id FROM PLEASE_HELP.Compra P WHERE G.Espectaculo_Cod = P.Compra_Publicacion AND G.Ubicacion_Asiento = P.Compra_Asiento AND G.Ubicacion_Fila = P.Compra_Fila)
FROM gd_esquema.Maestra G
WHERE G.Factura_Nro IS NOT NULL

GO

INSERT INTO PLEASE_HELP.Premio 
VALUES ('Heladera', 30000),
('Bicicleta', 1500),
('Pava Eléctrica', 300),
('Juego de Platos', 200),
('Microondas', 1700),
('Ventilador de piso', 2300),
('Pelota de Futbol', 500),
('Viaje a miami', 35000),
('Televisor LCD 60 pulgadas', 32000),
('Plancha', 450),
('Voucher $999 en Falabella', 900),
('Cenicero', 70)

GO

-- STORED PROCEDURES LOGIN

CREATE PROCEDURE PLEASE_HELP.SP_CAMBIAR_CONTRASEÑA(@idUser INT, @password VARBINARY(255))
AS
BEGIN
UPDATE PLEASE_HELP.Usuario SET Usuario_Password = @password WHERE Usuario_Id = @idUser
END
GO

CREATE PROCEDURE PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS_CLIENTE(@userId INT)
AS
BEGIN
UPDATE PLEASE_HELP.Cliente SET Cli_Intentos_Fallidos = Cli_Intentos_Fallidos + 1 WHERE Cli_Usuario = @userId
END
GO

CREATE PROCEDURE PLEASE_HELP.SP_AGREGAR_INTENTOS_FALLIDOS_EMPRESA(@userId INT)
AS
BEGIN
UPDATE PLEASE_HELP.Empresa SET Emp_Intentos_Fallidos = Emp_Intentos_Fallidos + 1 WHERE Emp_Usuario = @userId
END
GO

CREATE PROCEDURE PLEASE_HELP.SP_GET_PREMIOS(@clienteId INT)
AS
BEGIN
SELECT Premio_Cantidad as Cantidad, Premio_Descripcion as Descripcion
from Premio p inner join Usuario_Premio up
on p.Premio_Id = up.Premio_Id and up.Cli_Usuario = @clienteId
END
GO

--CREATE PROCEDURE PLEASE_HELP.SP_VERIFICAR_ADMIN (@username NVARCHAR(50))
--AS
--BEGIN
--	DECLARE @idAdmin INT, @idUsuario INT, @esAdmin BIT
--	SELECT @idAdmin = Rol_Id FROM Rol WHERE Rol_Nombre = 'ADMINISTRATIVO'
--	SELECT @idUsuario = Usuario_Id FROM PLEASE_HELP.Usuario WHERE Usuario_Username = @username
--	IF EXISTS(SELECT 1 FROM PLEASE_HELP.Usuario_Rol UXR WHERE UXR.Usuario_Id = @idUsuario AND UXR.Rol_Id = @idAdmin)
--		BEGIN
--			SET @esAdmin = 1
--		END
--	ELSE
--		BEGIN
--			SET @esAdmin = 0
--		END
--	RETURN @esAdmin
--END
--GO


CREATE PROCEDURE PLEASE_HELP.SP_LISTA_ROLES_USUARIO(@USERNAME NVARCHAR(50))
AS
SELECT UR.Rol_Id, (SELECT R.Rol_Nombre FROM PLEASE_HELP.Rol R WHERE R.Rol_Id = UR.Rol_Id), 
(SELECT R.Rol_Habilitado FROM PLEASE_HELP.Rol R WHERE R.Rol_Id = UR.Rol_Id) 
FROM PLEASE_HELP.Usuario U INNER JOIN PLEASE_HELP.Usuario_Rol UR ON U.Usuario_Id = UR.Usuario_Id
WHERE U.Usuario_Username = @USERNAME
GO


CREATE PROCEDURE PLEASE_HELP.SP_LIMPIAR_INTENTOS_FALLIDOS_CLIENTE(@USERID INT)
AS
BEGIN
	UPDATE PLEASE_HELP.Cliente SET Cli_Intentos_Fallidos = 0 WHERE Cli_Usuario = @USERID;
END
GO


CREATE PROCEDURE PLEASE_HELP.SP_LIMPIAR_INTENTOS_FALLIDOS_EMPRESA(@USERID INT)
AS
BEGIN
	UPDATE PLEASE_HELP.Empresa SET Emp_Intentos_Fallidos = 0 WHERE Emp_Usuario = @USERID;
END
GO


CREATE PROCEDURE PLEASE_HELP.SP_PRIMER_LOGIN(@idUser INT, @idRol INT, @primerLogin BIT output)
AS 
BEGIN
	DECLARE @rolName VARCHAR(50)
	SELECT @rolName = Rol_Nombre FROM PLEASE_HELP.Rol WHERE Rol_Id = @idRol

	IF @rolName = 'ADMINISTRATIVO'
		SET @primerLogin = 0
	IF @rolName = 'EMPRESA'
		SELECT @primerLogin = Emp_Primer_Login FROM PLEASE_HELP.Empresa WHERE Emp_Usuario = @idUser
	IF @rolName = 'CLIENTE'	
		SELECT @primerLogin = Cli_Primer_Login FROM PLEASE_HELP.Cliente WHERE Cli_Usuario = @idUser
	
END
GO

-- STORED PROCEDURES ROL

CREATE PROCEDURE PLEASE_HELP.SP_LISTA_FUNCIONALIDADES(@idRol INT) 
AS
SELECT RF.Rol_Id, (SELECT F.Func_Desc FROM PLEASE_HELP.Funcionalidad F WHERE F.Func_Id = RF.Func_Id)
FROM PLEASE_HELP.Rol R INNER JOIN PLEASE_HELP.Rol_Funcionalidad RF ON R.Rol_Id = RF.Rol_Id
WHERE R.Rol_Id = @idRol
GO

-- STORED PROCEDURES ABM EMPRESA

CREATE PROCEDURE PLEASE_HELP.SP_MODIFICACION_EMPRESA(@id int, @razonSocial NVARCHAR(255), @cuit NVARCHAR(255), @email NVARCHAR(50), @telefono NUMERIC(15,0), @localidad NVARCHAR(255), @direccion NVARCHAR(50), @nropiso NUMERIC(18,0), @depto NVARCHAR(50), @codpostal NVARCHAR(50), @ciudad NVARCHAR(50))
AS
BEGIN
	UPDATE PLEASE_HELP.Empresa SET Emp_Razon_Social = @razonSocial, 
	Emp_Email = @email, Emp_Telefono = @telefono, Emp_Localidad = @localidad, 
	Emp_Direccion = @direccion, Emp_Piso = @nropiso, Emp_Depto = @depto, 
	Emp_Cod_Postal = @codpostal, Emp_Ciudad = @ciudad, Emp_Cuit = @cuit
	WHERE Emp_Usuario = @id;
END
GO

CREATE PROCEDURE PLEASE_HELP.SP_ALTA_EMPRESA(@razonSocial NVARCHAR(255), @cuit NVARCHAR(255), @email NVARCHAR(50), @telefono NUMERIC(15,0), @localidad NVARCHAR(255), @direccion NVARCHAR(50), @nropiso NUMERIC(18,0), @depto NVARCHAR(50), @codpostal NVARCHAR(50), @ciudad NVARCHAR(50), @username NVARCHAR(255), @password VARBINARY(255))
AS
BEGIN
	BEGIN TRANSACTION
		INSERT INTO PLEASE_HELP.Usuario(Usuario_Username, Usuario_Password) 
			VALUES (@username, @password)
		INSERT INTO PLEASE_HELP.Empresa(Emp_Usuario, Emp_Razon_Social, Emp_Email, Emp_Telefono, Emp_Localidad, Emp_Direccion, Emp_Piso, Emp_Depto, Emp_Cod_Postal, Emp_Ciudad, Emp_Cuit)
			VALUES (@@IDENTITY, @razonSocial, @email, @telefono, @localidad, @direccion, @nropiso, @depto, @codpostal, @ciudad, @cuit)  
	COMMIT TRANSACTION
END
GO

-- STORED PROCEDURES ABM CLIENTE
CREATE PROCEDURE PLEASE_HELP.SP_ALTA_CLIENTE(@nombre NVARCHAR(255), @apellido NVARCHAR(255), @tipo_doc NVARCHAR(255), @nro_doc NUMERIC(18,0), @cuil NUMERIC(11,0), @email NVARCHAR(255), @telefono NUMERIC(15,0), @localidad NVARCHAR(255), @direccion NVARCHAR(255), @nropiso NUMERIC(18,0), @depto NVARCHAR(255), @codpostal NVARCHAR(255), @fechanac DATETIME, @fechacreacion DATETIME, @tarjetacredito NVARCHAR(255), @username NVARCHAR(255), @password VARBINARY(255), @firstLogin BIT)
AS
BEGIN
	BEGIN TRANSACTION
		INSERT INTO PLEASE_HELP.Usuario(Usuario_Username, Usuario_Password) 
			VALUES (@username, @password)
		INSERT INTO PLEASE_HELP.Cliente(Cli_Usuario, Cli_Nombre, Cli_Apellido,
		Cli_Tipo_Documento, Cli_Nro_Documento, Cli_Cuil, Cli_Email, Cli_Telefono,
		Cli_Localidad, Cli_Direccion, Cli_Nro_Piso, Cli_Depto, Cli_Cod_Postal, 
		Cli_Fecha_Nac, Cli_Fecha_Creacion, Cli_Tarjeta_Credito, Cli_Primer_Login)
		VALUES (@@IDENTITY, @nombre, @apellido, @tipo_doc, @nro_doc, @cuil, @email, 
		@telefono, @localidad, @direccion, @nropiso, @depto, @codpostal, @fechanac, 
		@fechacreacion, @tarjetacredito, @firstLogin) 
	COMMIT TRANSACTION
END
GO


-- STORED PROCEDURES GENERAR PUBLICACION

CREATE PROCEDURE PLEASE_HELP.SP_GENERAR_PUBLICACION(@fechaInicio DATETIME, @fechaEvento DATETIME, @descripcion NVARCHAR(255), @direccion NVARCHAR(255), @rubroId INT, @gradoId INT, @empresaId INT, @estadoId INT, @idPublicacion INT output)
AS
BEGIN
	BEGIN TRANSACTION
		INSERT INTO PLEASE_HELP.Publicacion (Pub_Fecha_Inicio, Pub_Fecha_Evento, 
		Pub_Descripcion, Pub_Direccion, Pub_Rubro, Pub_Grado, Pub_Empresa, Pub_Estado) 
		VALUES (CONVERT(DATETIME,@fechaInicio,121), CONVERT(DATETIME,@fechaEvento,121), 
		@descripcion, @direccion, @rubroId, @gradoId, @empresaId, @estadoId)		
		SET @idPublicacion = @@IDENTITY
	COMMIT TRANSACTION
END
GO


CREATE PROCEDURE PLEASE_HELP.SP_INSERTAR_UBICACION(@idPublicacion INT, @fila VARCHAR(3), @asiento NUMERIC(18,0), @precio NUMERIC(18,0), @descripcion NVARCHAR(255))
AS
BEGIN
	INSERT INTO PLEASE_HELP.Ubicacion (Ubicacion_Publicacion, Ubicacion_Fila, 
	Ubicacion_Asiento, Ubicacion_Precio, Ubicacion_Descripcion)
	VALUES (@idPublicacion, @fila, @asiento, @precio, @descripcion)
END
GO


-- STORED PROCEDURES EDITAR PUBLICACION

CREATE PROCEDURE PLEASE_HELP.SP_LISTA_PUBLICACIONES(@idUser INT, @descripcion NVARCHAR(255))
AS
SELECT Pub_Codigo, Pub_Fecha_Inicio, Pub_Fecha_Evento, Pub_Descripcion, Pub_Direccion, 
		(SELECT Rubro_Descripcion FROM PLEASE_HELP.Rubro WHERE Rubro_Id = Pub_Rubro) AS Pub_Rubro,
		(SELECT Grado_Descripcion FROM PLEASE_HELP.Grado WHERE Grado_Id = Pub_Grado) AS Pub_Grado,
		Pub_Empresa,
		(SELECT Estado_Descripcion FROM PLEASE_HELP.Estado WHERE Estado_Id = Pub_Estado) AS Pub_Estado
		
FROM PLEASE_HELP.Publicacion
WHERE Pub_Empresa = @idUser AND Pub_Descripcion LIKE CONCAT('%',@descripcion,'%')
GO


CREATE PROCEDURE PLEASE_HELP.SP_CAMBIAR_ESTADO_PUBLICACION(@codigoPublicacion NUMERIC(18,0), @estado NVARCHAR(255))
AS
BEGIN
	UPDATE PLEASE_HELP.Publicacion SET Pub_Estado = (SELECT Estado_Id FROM PLEASE_HELP.Estado WHERE Estado_Descripcion = @estado)
		WHERE Pub_Codigo = @codigoPublicacion
END
GO

CREATE PROCEDURE PLEASE_HELP.SP_GET_UBICACIONES_BY_USER(@idUser INT)
AS
SELECT Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Precio, Ubicacion_Descripcion, Ubicacion_Publicacion
FROM PLEASE_HELP.Publicacion INNER JOIN PLEASE_HELP.Ubicacion ON Pub_Codigo = Ubicacion_Publicacion
WHERE Pub_Empresa = @idUser
GO

CREATE PROCEDURE PLEASE_HELP.SP_DELETE_PUBLICACION_UBICACIONES(@codigoPublicacion NUMERIC(18,0))
AS
BEGIN
	DELETE FROM PLEASE_HELP.Ubicacion WHERE Ubicacion_Publicacion = @codigoPublicacion
END
GO

CREATE PROCEDURE PLEASE_HELP.SP_UPDATE_PUBLICACION(@codigoPublicacion NUMERIC(18,0), @fechaInicio DATETIME, @fechaEvento DATETIME, @descripcion NVARCHAR(255), @direccion NVARCHAR(255), @rubroId INT, @gradoId INT, @estadoId INT)
AS
BEGIN 
	UPDATE PLEASE_HELP.Publicacion SET Pub_Fecha_Inicio = CONVERT(DATETIME,@fechaInicio,121), Pub_Fecha_Evento = CONVERT(DATETIME,@fechaEvento,121), Pub_Descripcion = @descripcion, Pub_Direccion = @direccion, Pub_Rubro = @rubroId, Pub_Grado = @gradoId, Pub_Estado = @estadoId
		WHERE Pub_Codigo = @codigoPublicacion
END
GO


CREATE PROCEDURE PLEASE_HELP.SP_PUBLICACIONES_MISMA_FECHAHORA(@codigoPublicacion NUMERIC(18,0), @descripcion NVARCHAR(255), @fechaEvento DATETIME)
AS 
SELECT * FROM PLEASE_HELP.Publicacion WHERE Pub_Descripcion = @descripcion AND CONVERT(DATE,Pub_Fecha_Evento) = CONVERT(DATE,@fechaEvento) AND DATEPART(hour,Pub_Fecha_Evento) = DATEPART(hour,@fechaEvento) AND DATEPART(minute,Pub_Fecha_Evento) = DATEPART(minute,@fechaEvento)
												AND Pub_Codigo != @codigoPublicacion
GO

CREATE PROCEDURE PLEASE_HELP.SP_CANJEAR_PUNTOS(@idUser NUMERIC(18,0), @idPremio NUMERIC(18,0))
AS
	DECLARE @puntosPremio int 
	IF NOT EXISTS (SELECT 1 FROM PLEASE_HELP.Usuario_Premio up WHERE up.Cli_Usuario = @idUser and up.Premio_Id = @idPremio)
		INSERT INTO PLEASE_HELP.Usuario_Premio (Cli_Usuario, Premio_Id) VALUES (@idUser, @idPremio)
	ELSE
		UPDATE PLEASE_HELP.Usuario_Premio SET Premio_Cantidad = (Premio_Cantidad + 1) WHERE Cli_Usuario = @idUser and Premio_Id = @idPremio
	SELECT @puntosPremio = Premio_Puntos FROM PLEASE_HELP.Premio WHERE Premio_Id = @idPremio
	UPDATE PLEASE_HELP.Cliente SET Cli_Puntos = Cli_Puntos - @puntosPremio WHERE Cli_Usuario = @idUser
GO


-- STORED PROCEDURES COMPRAR

CREATE PROCEDURE PLEASE_HELP.SP_GET_PUBLICACIONES_ACTIVAS(@descripcion NVARCHAR(255) = null, @fechaDesde DATETIME = null, @fechaHasta DATETIME = null)
AS
SELECT Pub_Codigo, Pub_Descripcion, Pub_Fecha_Evento, Pub_Direccion, (SELECT Rubro_Descripcion FROM PLEASE_HELP.Rubro WHERE Rubro_Id = Pub_Rubro) as Pub_Rubro,
	 COUNT(*) as Pub_Stock, (SELECT Grado_Comision FROM PLEASE_HELP.Grado WHERE Grado_Id = Pub_Grado) as Pub_Comision	 
FROM PLEASE_HELP.Publicacion INNER JOIN PLEASE_HELP.Ubicacion ON Pub_Codigo = Ubicacion_Publicacion
WHERE Pub_Estado = (SELECT Estado_Id FROM PLEASE_HELP.Estado WHERE Estado_Descripcion = 'PUBLICADA') AND NOT EXISTS (SELECT 1 FROM PLEASE_HELP.Compra WHERE Compra_Publicacion = Ubicacion_Publicacion AND Compra_Fila = Ubicacion_Fila AND Compra_Asiento = Ubicacion_Asiento)
	AND Pub_Fecha_Evento > CONVERT(DATETIME, '2018-01-01 00:00:00', 121)        --consideramos fecha actual 2018-01-01 00:00:00, aca debería ir un getdate()
	--filtros
	AND (@descripcion is null OR Pub_Descripcion LIKE CONCAT('%',@descripcion,'%'))
	AND (@fechaDesde is null OR Pub_Fecha_Evento >= CONVERT(DATETIME,@fechaDesde,121))
	AND (@fechaHasta is null OR Pub_Fecha_Evento <= CONVERT(DATETIME,@fechaHasta,121))
GROUP BY Pub_Codigo, Pub_Descripcion, Pub_Fecha_Evento, Pub_Direccion, Pub_Rubro, Pub_Grado
ORDER BY (SELECT Grado_Comision FROM PLEASE_HELP.Grado WHERE Grado_Id = Pub_Grado) DESC, Pub_Fecha_Evento ASC
GO

CREATE PROCEDURE PLEASE_HELP.SP_GET_UBICACIONES_DISPONIBLES(@codigoPublicacion NUMERIC(18,0))
AS
SELECT Ubicacion_Publicacion, Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Descripcion, Ubicacion_Precio
FROM  PLEASE_HELP.Ubicacion 
WHERE Ubicacion_Publicacion = @codigoPublicacion 
	AND NOT EXISTS (SELECT 1 FROM PLEASE_HELP.Compra WHERE Compra_Publicacion = Ubicacion_Publicacion AND Compra_Fila = Ubicacion_Fila AND Compra_Asiento = Ubicacion_Asiento) 
ORDER BY Ubicacion_Fila ASC, Ubicacion_Asiento ASC
GO


CREATE PROCEDURE PLEASE_HELP.SP_ADD_NRO_TARJETA_CREDITO(@userId INT, @numeroTarjeta NVARCHAR(255))
AS
BEGIN	
	UPDATE PLEASE_HELP.Cliente SET Cli_Tarjeta_Credito = @numeroTarjeta WHERE Cli_Usuario = @userId
END
GO


CREATE PROCEDURE PLEASE_HELP.SP_COMPRAR_ENTRADA(@compraCliente INT, @compraFecha DATETIME, @compraMedioPago NVARCHAR(255), @compraEmail NVARCHAR(255), @compraFila VARCHAR(3), @compraAsiento NUMERIC(18,0), @compraPublicacion NUMERIC(18,0), @compraPrecio NUMERIC(18,0))
AS
BEGIN
	INSERT PLEASE_HELP.Compra (Compra_Cliente, Compra_Cantidad, Compra_Fecha, Compra_Metodo_Pago, Compra_Email, Compra_Fila, Compra_Asiento, Compra_Publicacion) VALUES (@compraCliente, 1, CONVERT(DATETIME, @compraFecha, 121), @compraMedioPago, @compraEmail, @compraFila, @compraAsiento, @compraPublicacion)

	DECLARE @puntos INT = @compraPrecio/10 
	DECLARE @fechaVencimiento DATETIME = CONVERT(DATETIME, DATEADD(YEAR, 1, @compraFecha), 121)
	INSERT PLEASE_HELP.Puntuacion (Puntuacion_Cantidad, Puntuacion_Fecha_Vencimiento, Puntuacion_Cliente) VALUES (@puntos, @fechaVencimiento, @compraCliente)
END
GO


-- STORED PROCEDURES HISTORIAL CLIENTE

CREATE PROCEDURE PLEASE_HELP.SP_GET_HISTORIAL_CLIENTE(@idUser INT)
AS
SELECT Compra_Fecha, Ubicacion_Precio, Compra_Metodo_Pago, Ubicacion_Descripcion, Ubicacion_Fila, Ubicacion_Asiento, (SELECT Pub_Fecha_Evento FROM PLEASE_HELP.Publicacion WHERE Pub_Codigo = Ubicacion_Publicacion) AS Compra_Fecha_Evento, (SELECT Pub_Descripcion FROM PLEASE_HELP.Publicacion WHERE Pub_Codigo = Ubicacion_Publicacion) AS Compra_Publicacion_Descripcion
FROM PLEASE_HELP.Compra INNER JOIN PLEASE_HELP.Ubicacion ON Compra_Publicacion = Ubicacion_Publicacion AND Compra_Fila = Ubicacion_Fila AND Compra_Asiento = Ubicacion_Asiento
WHERE Compra_Cliente = @idUser
GO
	
-- TRIGGERS LOGIN

CREATE TRIGGER PLEASE_HELP.TR_INHABILITAR_USUARIO_CLIENTE
ON PLEASE_HELP.Cliente
AFTER UPDATE
AS
BEGIN
	IF UPDATE(Cli_Intentos_Fallidos)
		DECLARE @userId INT, @intentosFallidos SMALLINT
		SELECT @userId = Cli_Usuario, @intentosFallidos = Cli_Intentos_Fallidos FROM INSERTED
		IF(@intentosFallidos) >= 3
			UPDATE PLEASE_HELP.Cliente SET Cli_Habilitado = 0, Cli_Intentos_Fallidos = 0 WHERE Cli_Usuario = @userId
END
GO

CREATE TRIGGER PLEASE_HELP.TR_INHABILITAR_USUARIO_EMPRESA
ON PLEASE_HELP.Empresa
AFTER UPDATE
AS
BEGIN
	IF UPDATE(Emp_Intentos_Fallidos)
		DECLARE @userId INT, @intentosFallidos SMALLINT
		SELECT @userId = Emp_Usuario, @intentosFallidos = Emp_Intentos_Fallidos FROM INSERTED
		IF(@intentosFallidos) >= 3
			UPDATE PLEASE_HELP.Empresa SET Emp_Habilitado = 0, Emp_Intentos_Fallidos = 0 WHERE Emp_Usuario = @userId
END
GO


CREATE TRIGGER PLEASE_HELP.TR_ADD_ROL_AFTER_INSERT_CLIENTE
ON PLEASE_HELP.Cliente
AFTER INSERT
AS
BEGIN
	DECLARE @userId INT
	SELECT @userId = Cli_Usuario FROM INSERTED
	INSERT INTO PLEASE_HELP.Usuario_Rol(Usuario_Id, Rol_Id) 
		VALUES (@userId, 3)
END
GO


CREATE TRIGGER PLEASE_HELP.TR_ADD_ROL_AFTER_INSERT_EMPRESA
ON PLEASE_HELP.Empresa
AFTER INSERT
AS
BEGIN
	DECLARE @userId INT
	SELECT @userId = Emp_Usuario FROM INSERTED
	INSERT INTO PLEASE_HELP.Usuario_Rol(Usuario_Id, Rol_Id) 
		VALUES (@userId, 1)
END
GO


CREATE TRIGGER PLEASE_HELP.TR_AFTER_FIRST_LOGIN
ON PLEASE_HELP.Usuario
AFTER UPDATE
AS
BEGIN
	IF EXISTS(SELECT 1 FROM PLEASE_HELP.Cliente INNER JOIN inserted i ON Cli_Usuario = i.Usuario_Id)
	BEGIN
		IF UPDATE(Usuario_Password) AND (SELECT Cli_Primer_Login  FROM inserted INNER JOIN PLEASE_HELP.Cliente ON Usuario_Id = Cli_Usuario) = 1
			UPDATE PLEASE_HELP.Cliente SET Cli_Primer_Login = 0 WHERE Cli_Usuario = (SELECT Usuario_Id FROM inserted)
	END
	
	ELSE

	BEGIN
		IF UPDATE(Usuario_Password) AND (SELECT Emp_Primer_Login  FROM inserted INNER JOIN PLEASE_HELP.Empresa ON Usuario_Id = Emp_Usuario) = 1
			UPDATE PLEASE_HELP.Empresa SET Emp_Primer_Login = 0 WHERE Emp_Usuario = (SELECT Usuario_Id FROM inserted)
	END

END	
GO


CREATE TRIGGER PLEASE_HELP.TR_AFTER_COMPRA_ENTRADA
ON PLEASE_HELP.Compra
AFTER INSERT
AS
BEGIN
	DECLARE @codigoPublicacion NUMERIC(18,0)
	SELECT @codigoPublicacion = Compra_Publicacion FROM inserted 
	IF NOT EXISTS(SELECT 1 FROM PLEASE_HELP.Ubicacion 
					WHERE Ubicacion_Publicacion = @codigoPublicacion 
						AND NOT EXISTS(SELECT 1 FROM PLEASE_HELP.Compra WHERE Compra_Publicacion = Ubicacion_Publicacion AND Compra_Fila = Ubicacion_Fila AND Compra_Asiento = Ubicacion_Asiento))
		UPDATE PLEASE_HELP.Publicacion SET Pub_Estado = (SELECT Estado_Id FROM PLEASE_HELP.Estado WHERE Estado_Descripcion = 'FINALIZADA') WHERE Pub_Codigo = @codigoPublicacion
END
GO