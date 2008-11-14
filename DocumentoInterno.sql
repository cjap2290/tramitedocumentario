
USE [BDGestionDocumentos]
GO

/****** Object:  StoredProcedure [proc_DocumentoInternoLoadByPrimaryKey]    Script Date: 13/11/2008 17:38:10 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DocumentoInternoLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DocumentoInternoLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_DocumentoInternoLoadByPrimaryKey]
(
	@IdDocInterno int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdDocInterno],
		[NroDoc],
		[IdTipoDocumento],
		[IdArea],
		[IdAgencia],
		[Periodo],
		[Asunto],
		[Encabezado],
		[Prioridad],
		[NombreArchivo],
		[RutaArchivo],
		[FechaR],
		[IdUserR],
		[IdEstDoc]
	FROM [DocumentoInterno]
	WHERE
		([IdDocInterno] = @IdDocInterno)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DocumentoInternoLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_DocumentoInternoLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DocumentoInternoLoadAll]    Script Date: 13/11/2008 17:38:10 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DocumentoInternoLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DocumentoInternoLoadAll];
GO

CREATE PROCEDURE [proc_DocumentoInternoLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdDocInterno],
		[NroDoc],
		[IdTipoDocumento],
		[IdArea],
		[IdAgencia],
		[Periodo],
		[Asunto],
		[Encabezado],
		[Prioridad],
		[NombreArchivo],
		[RutaArchivo],
		[FechaR],
		[IdUserR],
		[IdEstDoc]
	FROM [DocumentoInterno]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DocumentoInternoLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_DocumentoInternoLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DocumentoInternoUpdate]    Script Date: 13/11/2008 17:38:10 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DocumentoInternoUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DocumentoInternoUpdate];
GO

CREATE PROCEDURE [proc_DocumentoInternoUpdate]
(
	@IdDocInterno int,
	@NroDoc char(6),
	@IdTipoDocumento int,
	@IdArea char(2),
	@IdAgencia char(2),
	@Periodo char(6) = NULL,
	@Asunto varchar(50) = NULL,
	@Encabezado varchar(30) = NULL,
	@Prioridad char(1) = NULL,
	@NombreArchivo varchar(30) = NULL,
	@RutaArchivo varchar(30) = NULL,
	@FechaR datetime,
	@IdUserR char(6),
	@IdEstDoc int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [DocumentoInterno]
	SET
		[NroDoc] = @NroDoc,
		[IdTipoDocumento] = @IdTipoDocumento,
		[IdArea] = @IdArea,
		[IdAgencia] = @IdAgencia,
		[Periodo] = @Periodo,
		[Asunto] = @Asunto,
		[Encabezado] = @Encabezado,
		[Prioridad] = @Prioridad,
		[NombreArchivo] = @NombreArchivo,
		[RutaArchivo] = @RutaArchivo,
		[FechaR] = @FechaR,
		[IdUserR] = @IdUserR,
		[IdEstDoc] = @IdEstDoc
	WHERE
		[IdDocInterno] = @IdDocInterno


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DocumentoInternoUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_DocumentoInternoUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_DocumentoInternoInsert]    Script Date: 13/11/2008 17:38:10 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DocumentoInternoInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DocumentoInternoInsert];
GO

CREATE PROCEDURE [proc_DocumentoInternoInsert]
(
	@IdDocInterno int = NULL output,
	@NroDoc char(6),
	@IdTipoDocumento int,
	@IdArea char(2),
	@IdAgencia char(2),
	@Periodo char(6) = NULL,
	@Asunto varchar(50) = NULL,
	@Encabezado varchar(30) = NULL,
	@Prioridad char(1) = NULL,
	@NombreArchivo varchar(30) = NULL,
	@RutaArchivo varchar(30) = NULL,
	@FechaR datetime,
	@IdUserR char(6),
	@IdEstDoc int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [DocumentoInterno]
	(
		[NroDoc],
		[IdTipoDocumento],
		[IdArea],
		[IdAgencia],
		[Periodo],
		[Asunto],
		[Encabezado],
		[Prioridad],
		[NombreArchivo],
		[RutaArchivo],
		[FechaR],
		[IdUserR],
		[IdEstDoc]
	)
	VALUES
	(
		@NroDoc,
		@IdTipoDocumento,
		@IdArea,
		@IdAgencia,
		@Periodo,
		@Asunto,
		@Encabezado,
		@Prioridad,
		@NombreArchivo,
		@RutaArchivo,
		@FechaR,
		@IdUserR,
		@IdEstDoc
	)

	SET @Err = @@Error

	SELECT @IdDocInterno = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DocumentoInternoInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_DocumentoInternoInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DocumentoInternoDelete]    Script Date: 13/11/2008 17:38:10 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DocumentoInternoDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DocumentoInternoDelete];
GO

CREATE PROCEDURE [proc_DocumentoInternoDelete]
(
	@IdDocInterno int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [DocumentoInterno]
	WHERE
		[IdDocInterno] = @IdDocInterno
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DocumentoInternoDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_DocumentoInternoDelete Error on Creation'
GO
