
USE [BDGestionDocumentos]
GO

/****** Object:  StoredProcedure [proc_AnexosLoadByPrimaryKey]    Script Date: 12/12/2008 09:15:48 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnexosLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnexosLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_AnexosLoadByPrimaryKey]
(
	@IdAnexo int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdAnexo],
		[IdDocInterno],
		[NombreAnexo],
		[RutaAnexo],
		[Activo],
		[IdUserR],
		[FechaR]
	FROM [Anexos]
	WHERE
		([IdAnexo] = @IdAnexo)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnexosLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnexosLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnexosLoadAll]    Script Date: 12/12/2008 09:15:48 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnexosLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnexosLoadAll];
GO

CREATE PROCEDURE [proc_AnexosLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdAnexo],
		[IdDocInterno],
		[NombreAnexo],
		[RutaAnexo],
		[Activo],
		[IdUserR],
		[FechaR]
	FROM [Anexos]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnexosLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnexosLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnexosUpdate]    Script Date: 12/12/2008 09:15:48 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnexosUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnexosUpdate];
GO

CREATE PROCEDURE [proc_AnexosUpdate]
(
	@IdAnexo int,
	@IdDocInterno int,
	@NombreAnexo varchar(30),
	@RutaAnexo varchar(30),
	@Activo char(1),
	@IdUserR char(6),
	@FechaR datetime
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Anexos]
	SET
		[IdDocInterno] = @IdDocInterno,
		[NombreAnexo] = @NombreAnexo,
		[RutaAnexo] = @RutaAnexo,
		[Activo] = @Activo,
		[IdUserR] = @IdUserR,
		[FechaR] = @FechaR
	WHERE
		[IdAnexo] = @IdAnexo


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnexosUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnexosUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_AnexosInsert]    Script Date: 12/12/2008 09:15:48 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnexosInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnexosInsert];
GO

CREATE PROCEDURE [proc_AnexosInsert]
(
	@IdAnexo int = NULL output,
	@IdDocInterno int,
	@NombreAnexo varchar(30),
	@RutaAnexo varchar(30),
	@Activo char(1),
	@IdUserR char(6),
	@FechaR datetime
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Anexos]
	(
		[IdDocInterno],
		[NombreAnexo],
		[RutaAnexo],
		[Activo],
		[IdUserR],
		[FechaR]
	)
	VALUES
	(
		@IdDocInterno,
		@NombreAnexo,
		@RutaAnexo,
		@Activo,
		@IdUserR,
		@FechaR
	)

	SET @Err = @@Error

	SELECT @IdAnexo = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnexosInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnexosInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnexosDelete]    Script Date: 12/12/2008 09:15:48 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnexosDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnexosDelete];
GO

CREATE PROCEDURE [proc_AnexosDelete]
(
	@IdAnexo int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Anexos]
	WHERE
		[IdAnexo] = @IdAnexo
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnexosDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnexosDelete Error on Creation'
GO
