-- Publicaciones FINALIZADAS para ver en RENDICION DE COMISIONES
IF OBJECT_ID('PLEASE_HELP.SP_DATOS_COMISIONES') IS NOT NULL DROP PROCEDURE PLEASE_HELP.SP_DATOS_COMISIONES;
GO
CREATE PROCEDURE PLEASE_HELP.SP_DATOS_COMISIONES
AS
BEGIN
	DECLARE @IdPublicacion NUMERIC(18,0)
	insert into PLEASE_HELP.Publicacion VALUES
	(DATEADD(MONTH, -3, GETDATE()), DATEADD(DAY, -1, GETDATE()), 'Harry Potter', 'Hoyts Unicenter', null, 1, 773, 3)

	SET @IdPublicacion = @@IDENTITY

	insert into PLEASE_HELP.Ubicacion VALUES
	(@IdPublicacion, 'A', 1, 101, null, 'Asiento Creado por Nosotros', 1)

	insert into PLEASE_HELP.Compra VALUES	
	(2, 1, DATEADD(DAY, -1, GETDATE()), 'TARJETA', 'usuario@dominio.com', NULL, 'A', 1, @IdPublicacion),
	(2, 1, DATEADD(DAY, -1, GETDATE()), 'TARJETA', 'usuario@dominio.com', NULL, 'A', 1, @IdPublicacion),
	(2, 1, DATEADD(DAY, -1, GETDATE()), 'TARJETA', 'usuario@dominio.com', NULL, 'A', 1, @IdPublicacion),
	(3, 1, DATEADD(DAY, -1, GETDATE()), 'TARJETA', 'usuario2@dominio.com', NULL, 'A', 1, @IdPublicacion),
	(3, 1, DATEADD(DAY, -1, GETDATE()), 'TARJETA', 'usuario2@dominio.com', NULL, 'A', 1, @IdPublicacion)
END
GO

EXEC PLEASE_HELP.SP_DATOS_COMISIONES