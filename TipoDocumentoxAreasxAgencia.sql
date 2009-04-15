
USE [BDGestionDocumentos]
GO

/****** Object:  StoredProcedure [proc_TipoDocumentoxAreasxAgenciaLoadByPrimaryKey]    Script Date: 10/04/2009 06:07:36 p.m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoxAreasxAgenciaLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoxAreasxAgenciaLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_TipoDocumentoxAreasxAgenciaLoadByPrimaryKey]
(
	@IdTipoDocumento int,
	@IdArea char(2),
	@IdAgencia char(2)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdTipoDocumento],
		[IdArea],
		[IdAgencia],
		[Activo],
		[IdUserR],
		[FechaR]
	FROM [TipoDocumentoxAreasxAgencia]
	WHERE
		([IdTipoDocumento] = @IdTipoDocumento) AND
		([IdArea] = @IdArea) AND
		([IdAgencia] = @IdAgencia)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TipoDocumentoxAreasxAgenciaLoadAll]    Script Date: 10/04/2009 06:07:36 p.m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoxAreasxAgenciaLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoxAreasxAgenciaLoadAll];
GO

CREATE PROCEDURE [proc_TipoDocumentoxAreasxAgenciaLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdTipoDocumento],
		[IdArea],
		[IdAgencia],
		[Activo],
		[IdUserR],
		[FechaR]
	FROM [TipoDocumentoxAreasxAgencia]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TipoDocumentoxAreasxAgenciaUpdate]    Script Date: 10/04/2009 06:07:36 p.m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoxAreasxAgenciaUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoxAreasxAgenciaUpdate];
GO

CREATE PROCEDURE [proc_TipoDocumentoxAreasxAgenciaUpdate]
(
	@IdTipoDocumento int,
	@IdArea char(2),
	@IdAgencia char(2),
	@Activo char(1),
	@IdUserR char(6),
	@FechaR datetime
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [TipoDocumentoxAreasxAgencia]
	SET
		[Activo] = @Activo,
		[IdUserR] = @IdUserR,
		[FechaR] = @FechaR
	WHERE
		[IdTipoDocumento] = @IdTipoDocumento
	AND	[IdArea] = @IdArea
	AND	[IdAgencia] = @IdAgencia


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_TipoDocumentoxAreasxAgenciaInsert]    Script Date: 10/04/2009 06:07:36 p.m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoxAreasxAgenciaInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoxAreasxAgenciaInsert];
GO

CREATE PROCEDURE [proc_TipoDocumentoxAreasxAgenciaInsert]
(
	@IdTipoDocumento int,
	@IdArea char(2),
	@IdAgencia char(2),
	@Activo char(1),
	@IdUserR char(6),
	@FechaR datetime
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [TipoDocumentoxAreasxAgencia]
	(
		[IdTipoDocumento],
		[IdArea],
		[IdAgencia],
		[Activo],
		[IdUserR],
		[FechaR]
	)
	VALUES
	(
		@IdTipoDocumento,
		@IdArea,
		@IdAgencia,
		@Activo,
		@IdUserR,
		@FechaR
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TipoDocumentoxAreasxAgenciaDelete]    Script Date: 10/04/2009 06:07:36 p.m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TipoDocumentoxAreasxAgenciaDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TipoDocumentoxAreasxAgenciaDelete];
GO

CREATE PROCEDURE [proc_TipoDocumentoxAreasxAgenciaDelete]
(
	@IdTipoDocumento int,
	@IdArea char(2),
	@IdAgencia char(2)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [TipoDocumentoxAreasxAgencia]
	WHERE
		[IdTipoDocumento] = @IdTipoDocumento AND
		[IdArea] = @IdArea AND
		[IdAgencia] = @IdAgencia
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_TipoDocumentoxAreasxAgenciaDelete Error on Creation'
GO
