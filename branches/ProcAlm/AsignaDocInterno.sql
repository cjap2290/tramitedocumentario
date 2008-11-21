
USE [BDGestionDocumentos]
GO

/****** Object:  StoredProcedure [proc_AsignaDocInternoLoadByPrimaryKey]    Script Date: 20/11/2008 18:05:13 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AsignaDocInternoLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AsignaDocInternoLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_AsignaDocInternoLoadByPrimaryKey]
(
	@IdAsigDocInterno int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdAsigDocInterno],
		[IdUser],
		[IdDocInterno],
		[IdEstAsigDoc],
		[Condicion],
		[FechaR],
		[IdUserR]
	FROM [AsignaDocInterno]
	WHERE
		([IdAsigDocInterno] = @IdAsigDocInterno)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AsignaDocInternoLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_AsignaDocInternoLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AsignaDocInternoLoadAll]    Script Date: 20/11/2008 18:05:13 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AsignaDocInternoLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AsignaDocInternoLoadAll];
GO

CREATE PROCEDURE [proc_AsignaDocInternoLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdAsigDocInterno],
		[IdUser],
		[IdDocInterno],
		[IdEstAsigDoc],
		[Condicion],
		[FechaR],
		[IdUserR]
	FROM [AsignaDocInterno]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AsignaDocInternoLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_AsignaDocInternoLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AsignaDocInternoUpdate]    Script Date: 20/11/2008 18:05:13 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AsignaDocInternoUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AsignaDocInternoUpdate];
GO

CREATE PROCEDURE [proc_AsignaDocInternoUpdate]
(
	@IdAsigDocInterno int,
	@IdUser char(6),
	@IdDocInterno int,
	@IdEstAsigDoc int,
	@Condicion char(1),
	@FechaR datetime,
	@IdUserR char(6)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [AsignaDocInterno]
	SET
		[IdUser] = @IdUser,
		[IdDocInterno] = @IdDocInterno,
		[IdEstAsigDoc] = @IdEstAsigDoc,
		[Condicion] = @Condicion,
		[FechaR] = @FechaR,
		[IdUserR] = @IdUserR
	WHERE
		[IdAsigDocInterno] = @IdAsigDocInterno


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AsignaDocInternoUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_AsignaDocInternoUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_AsignaDocInternoInsert]    Script Date: 20/11/2008 18:05:13 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AsignaDocInternoInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AsignaDocInternoInsert];
GO

CREATE PROCEDURE [proc_AsignaDocInternoInsert]
(
	@IdAsigDocInterno int = NULL output,
	@IdUser char(6),
	@IdDocInterno int,
	@IdEstAsigDoc int,
	@Condicion char(1),
	@FechaR datetime,
	@IdUserR char(6)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [AsignaDocInterno]
	(
		[IdUser],
		[IdDocInterno],
		[IdEstAsigDoc],
		[Condicion],
		[FechaR],
		[IdUserR]
	)
	VALUES
	(
		@IdUser,
		@IdDocInterno,
		@IdEstAsigDoc,
		@Condicion,
		@FechaR,
		@IdUserR
	)

	SET @Err = @@Error

	SELECT @IdAsigDocInterno = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AsignaDocInternoInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_AsignaDocInternoInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AsignaDocInternoDelete]    Script Date: 20/11/2008 18:05:13 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AsignaDocInternoDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AsignaDocInternoDelete];
GO

CREATE PROCEDURE [proc_AsignaDocInternoDelete]
(
	@IdAsigDocInterno int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [AsignaDocInterno]
	WHERE
		[IdAsigDocInterno] = @IdAsigDocInterno
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AsignaDocInternoDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_AsignaDocInternoDelete Error on Creation'
GO
