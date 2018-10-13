IF (NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'PLEASE_HELP'))
	BEGIN
		EXEC('CREATE SCHEMA PLEASE_HELP AUTHORIZATION gdEspectaculos2018');
	END;

GO

IF OBJECT_ID('PLEASE_HELP.ROL_FUNCIONALIDAD') IS NOT NULL DROP TABLE PLEASE_HELP.ROL_FUNCIONALIDAD;

IF OBJECT_ID('PLEASE_HELP.FUNCIONALIDAD') IS NOT NULL DROP TABLE PLEASE_HELP.FUNCIONALIDAD;

IF OBJECT_ID('PLEASE_HELP.USUARIO_ROL') IS NOT NULL DROP TABLE PLEASE_HELP.USUARIO_ROL;

IF OBJECT_ID('PLEASE_HELP.ROL') IS NOT NULL DROP TABLE PLEASE_HELP.ROL;

IF OBJECT_ID('PLEASE_HELP.COMPRA') IS NOT NULL DROP TABLE PLEASE_HELP.COMPRA;

IF OBJECT_ID('PLEASE_HELP.UBICACION') IS NOT NULL DROP TABLE PLEASE_HELP.UBICACION;

IF OBJECT_ID('PLEASE_HELP.PUBLICACION') IS NOT NULL DROP TABLE PLEASE_HELP.PUBLICACION;

IF OBJECT_ID('PLEASE_HELP.RUBRO') IS NOT NULL DROP TABLE PLEASE_HELP.RUBRO;

IF OBJECT_ID('PLEASE_HELP.GRADO') IS NOT NULL DROP TABLE PLEASE_HELP.GRADO;

IF OBJECT_ID('PLEASE_HELP.PUNTUACION') IS NOT NULL DROP TABLE PLEASE_HELP.PUNTUACION;

IF OBJECT_ID('PLEASE_HELP.ITEM') IS NOT NULL DROP TABLE PLEASE_HELP.ITEM;

IF OBJECT_ID('PLEASE_HELP.FACTURA') IS NOT NULL DROP TABLE PLEASE_HELP.FACTURA;

IF OBJECT_ID('PLEASE_HELP.EMPRESA') IS NOT NULL DROP TABLE PLEASE_HELP.EMPRESA;

IF OBJECT_ID('PLEASE_HELP.CLIENTE') IS NOT NULL DROP TABLE PLEASE_HELP.CLIENTE;

IF OBJECT_ID('PLEASE_HELP.USUARIO') IS NOT NULL DROP TABLE PLEASE_HELP.USUARIO

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
	Rol_Habilitado bit,
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
	Usuario_Username nvarchar(30) NOT NULL, 
	Usuario_Password nvarchar(100) NOT NULL,
	CONSTRAINT UQ_USUARIO_USERNAME UNIQUE (Usuario_Username),
	CONSTRAINT PK_USUARIO_ID PRIMARY KEY (Usuario_Id)
)

create table PLEASE_HELP.Cliente
(
	Cli_Usuario int,
	Cli_Nombre nvarchar(255),
	Cli_Apellido nvarchar(255),
	Cli_Tipo_Documento nvarchar(255),
	Cli_Nro_Docuemtno numeric(18,0),
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
	Cli_Habilitado bit,
	Cli_Intentos_Fallidos smallint,
	Cli_Baja int,
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
	Emp_Habilitado bit,
	Emp_Intentos_Fallidos smallint,
	Emp_Baja bit,
	CONSTRAINT PK_EMPRESA_USUARIO PRIMARY KEY (Emp_Usuario)
)

create table PLEASE_HELP.Publicacion
(
	Pub_Codigo numeric(18,0),
	Pub_Fecha_Inicio datetime,
	Pub_Fecha_Evento datetime,
	Pub_Descripcion nvarchar(255),
	Pub_Direccion nvarchar(255),
	Pub_Rubro nvarchar(255),
	Pub_Grado int,
	Pub_Empresa int,
	Pub_Estado nvarchar(255),
	CONSTRAINT PK_PUBLICACION_CODIGO PRIMARY KEY (Pub_Codigo),
)

create table PLEASE_HELP.Rubro
(
	Rubro_Id int identity(1,1),
	Rubro_Descripcion nvarchar(255),
	CONSTRAINT PK_RUBRO_ID PRIMARY KEY (Rubro_Id),
	CONSTRAINT UQ_RUBRO_DESCRIPCION UNIQUE (Rubro_Descripcion)
)

create table PLEASE_HELP.Grado
(
	Grado_Id int identity(1,1),
	Grado_Comision numeric(3,2) NOT NULL,
	Grado_Descripcion nvarchar(255),
	CONSTRAINT PK_GRADO_ID PRIMARY KEY (Grado_Id),
	CONSTRAINT UQ_GRADO_DESRCIPCION UNIQUE (Grado_Descripcion)
)

create table PLEASE_HELP.Ubicacion
(
	Ubicacion_Fila varchar(3),
	Ubicacion_Asiento numeric(18,0),
	Ubicacion_Precio numeric(18,0) NOT NULL,
	Ubicacion_Tipo_Codigo numeric(18,0),
	Ubicacion_Descripcion nvarchar(255),
	Ubicacion_Sin_Numerar bit,
	Ubicacion_Publicacion numeric(18,0),
	CONSTRAINT PK_UBICACION_FILAXASIENTOXPUBLICACION 
		PRIMARY KEY (Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Publicacion)
)

create table PLEASE_HELP.Compra
(
	Compra_Id int,
	Compra_Publicacion numeric(18,0),
	Compra_Cliente int,
	Compra_Cantidad numeric(18,0) NOT NULL,
	Compra_Fecha datetime NOT NULL,
	Compra_Metodo_Pago nvarchar(255) NOT NULL,
	Compra_Fecha_Rendida datetime,
	CONSTRAINT PK_COMPRA_ID PRIMARY KEY (Compra_Id),
)

create table PLEASE_HELP.Factura
(
	Factura_Nro numeric(18,0),
	Factura_Fecha datetime NOT NULL,
	Factura_Total numeric(18,2) NOT NULL,
--	Factura_Pago_Descripcion nvarchar(255) NOT NULL,
	Factura_Empresa int,
	CONSTRAINT PK_FACTURA_NRO PRIMARY KEY (Factura_Nro)
)

create table PLEASE_HELP.Item
(
	Item_Id int,
	Item_Monto numeric(18,2) NOT NULL,
	Item_Cantidad numeric(18,0) NOT NULL,
	Item_Descripcion nvarchar(60) NOT NULL,
	Item_Factura numeric(18,0),
	Item_Compra int,
	CONSTRAINT PK_ITEM_ID PRIMARY KEY (Item_Id),
)

create table PLEASE_HELP.Puntuacion
(
	Puntuacion_Id int,
	Puntuacion_Cantidad int DEFAULT 0,
	Puntuacion_Fecha_Vencimiento datetime,
	Puntuacion_Cliente int,
	CONSTRAINT PK_PUNTUACION_ID PRIMARY KEY (Puntuacion_Id), 
)

GO

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
CONSTRAINT FK_PUBLICACION_EMPRESA FOREIGN KEY (Pub_Empresa) REFERENCES PLEASE_HELP.Empresa(Emp_Usuario)

GO

ALTER TABLE PLEASE_HELP.Ubicacion
ADD CONSTRAINT FK_UBICACION_PUBLICACION FOREIGN KEY (Ubicacion_Publicacion) REFERENCES PLEASE_HELP.Publicacion(Pub_Codigo)

GO

ALTER TABLE PLEASE_HELP.Puntuacion
ADD CONSTRAINT FK_PUNTUACION_CLIENTE FOREIGN KEY (Puntuacion_Cliente) REFERENCES PLEASE_HELP.Cliente(Cli_Usuario)

GO

ALTER TABLE PLEASE_HELP.Compra
ADD CONSTRAINT FK_COMPRA_PUBLICACION FOREIGN KEY (Compra_Publicacion) REFERENCES PLEASE_HELP.Publicacion(Pub_Codigo),
CONSTRAINT FK_COMPRA_CLIENTE FOREIGN KEY (Compra_Cliente) REFERENCES PLEASE_HELP.Cliente(Cli_Usuario)

GO

ALTER TABLE PLEASE_HELP.Factura
ADD CONSTRAINT FK_FACTURA_EMPRESA FOREIGN KEY (Factura_Empresa) REFERENCES PLEASE_HELP.Empresa(Emp_Usuario)

GO

ALTER TABLE PLEASE_HELP.Item
ADD CONSTRAINT FK_ITEM_FACTURA FOREIGN KEY (Item_Factura) REFERENCES PLEASE_HELP.Factura(Factura_Nro),
CONSTRAINT FK_ITEM_COMPRA FOREIGN KEY (Item_Compra) REFERENCES PLEASE_HELP.Compra(Compra_Id)

