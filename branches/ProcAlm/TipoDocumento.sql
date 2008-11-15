
USE [BDGestionDocumentos]
GO

/****** Object:  StoredProcedure [proc_TipoDocumentoLoadByPrimaryKey]    Script Date: 14/11/2008 18:42:33 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_TipoDocumentoLoadByPrimaryKey]
(
	@IdTipoDocumento int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdTipoDocumento],
		[Descripcion],
		[IdUserR],
		[FechaR]
	FROM [TipoDocumento]
	WHERE
		([IdTipoDocumento] = @IdTipoDocumento)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TipoDocumentoLoadAll]    Script Date: 14/11/2008 18:42:33 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoLoadAll];
GO

CREATE PROCEDURE [proc_TipoDocumentoLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdTipoDocumento],
		[Descripcion],
		[IdUserR],
		[FechaR]
	FROM [TipoDocumento]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TipoDocumentoUpdate]    Script Date: 14/11/2008 18:42:33 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoUpdate];
GO

CREATE PROCEDURE [proc_TipoDocumentoUpdate]
(
	@IdTipoDocumento int,
	@Descripcion varchar(40),
	@IdUserR char(6),
	@FechaR datetime
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [TipoDocumento]
	SET
		[Descripcion] = @Descripcion,
		[IdUserR] = @IdUserR,
		[FechaR] = @FechaR
	WHERE
		[IdTipoDocumento] = @IdTipoDocumento


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_TipoDocumentoInsert]    Script Date: 14/11/2008 18:42:33 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoInsert];
GO

CREATE PROCEDURE [proc_TipoDocumentoInsert]
(
	@IdTipoDocumento int = NULL output,
	@Descripcion varchar(40),
	@IdUserR char(6),
	@FechaR datetime
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [TipoDocumento]
	(
		[Descripcion],
		[IdUserR],
		[FechaR]
	)
	VALUES
	(
		@Descripcion,
		@IdUserR,
		@FechaR
	)

	SET @Err = @@Error

	SELECT @IdTipoDocumento = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TipoDocumentoDelete]    Script Date: 14/11/2008 18:42:33 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoDelete];
GO

CREATE PROCEDURE [proc_TipoDocumentoDelete]
(
	@IdTipoDocumento int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [TipoDocumento]
	WHERE
		[IdTipoDocumento] = @IdTipoDocumento
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoDelete Error on Creation'
GO
