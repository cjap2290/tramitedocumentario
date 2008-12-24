
USE [BDGestionDocumentos]
GO

/****** Object:  StoredProcedure [proc_BuzonInternoLoadByPrimaryKey]    Script Date: 22/12/2008 11:19:46 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_BuzonInternoLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_BuzonInternoLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_BuzonInternoLoadByPrimaryKey]
(
	@IdBuzonInterno int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdBuzonInterno],
		[IdAsigDocInterno],
		[FechaLlegada],
		[FechaLeido],
		[FechaLimite],
		[IdCondicionEnvio],
		[IdEstBuzonInterno],
		[Observaciones],
		[IdUserR],
		[FechaR]
	FROM [BuzonInterno]
	WHERE
		([IdBuzonInterno] = @IdBuzonInterno)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_BuzonInternoLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_BuzonInternoLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_BuzonInternoLoadAll]    Script Date: 22/12/2008 11:19:46 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_BuzonInternoLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_BuzonInternoLoadAll];
GO

CREATE PROCEDURE [proc_BuzonInternoLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdBuzonInterno],
		[IdAsigDocInterno],
		[FechaLlegada],
		[FechaLeido],
		[FechaLimite],
		[IdCondicionEnvio],
		[IdEstBuzonInterno],
		[Observaciones],
		[IdUserR],
		[FechaR]
	FROM [BuzonInterno]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_BuzonInternoLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_BuzonInternoLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_BuzonInternoUpdate]    Script Date: 22/12/2008 11:19:46 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_BuzonInternoUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_BuzonInternoUpdate];
GO

CREATE PROCEDURE [proc_BuzonInternoUpdate]
(
	@IdBuzonInterno int,
	@IdAsigDocInterno int,
	@FechaLlegada datetime = NULL,
	@FechaLeido datetime = NULL,
	@FechaLimite datetime = NULL,
	@IdCondicionEnvio int,
	@IdEstBuzonInterno int,
	@Observaciones varchar(250) = NULL,
	@IdUserR char(6),
	@FechaR datetime
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [BuzonInterno]
	SET
		[IdAsigDocInterno] = @IdAsigDocInterno,
		[FechaLlegada] = @FechaLlegada,
		[FechaLeido] = @FechaLeido,
		[FechaLimite] = @FechaLimite,
		[IdCondicionEnvio] = @IdCondicionEnvio,
		[IdEstBuzonInterno] = @IdEstBuzonInterno,
		[Observaciones] = @Observaciones,
		[IdUserR] = @IdUserR,
		[FechaR] = @FechaR
	WHERE
		[IdBuzonInterno] = @IdBuzonInterno


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_BuzonInternoUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_BuzonInternoUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_BuzonInternoInsert]    Script Date: 22/12/2008 11:19:46 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_BuzonInternoInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_BuzonInternoInsert];
GO

CREATE PROCEDURE [proc_BuzonInternoInsert]
(
	@IdBuzonInterno int = NULL output,
	@IdAsigDocInterno int,
	@FechaLlegada datetime = NULL,
	@FechaLeido datetime = NULL,
	@FechaLimite datetime = NULL,
	@IdCondicionEnvio int,
	@IdEstBuzonInterno int,
	@Observaciones varchar(250) = NULL,
	@IdUserR char(6),
	@FechaR datetime
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [BuzonInterno]
	(
		[IdAsigDocInterno],
		[FechaLlegada],
		[FechaLeido],
		[FechaLimite],
		[IdCondicionEnvio],
		[IdEstBuzonInterno],
		[Observaciones],
		[IdUserR],
		[FechaR]
	)
	VALUES
	(
		@IdAsigDocInterno,
		@FechaLlegada,
		@FechaLeido,
		@FechaLimite,
		@IdCondicionEnvio,
		@IdEstBuzonInterno,
		@Observaciones,
		@IdUserR,
		@FechaR
	)

	SET @Err = @@Error

	SELECT @IdBuzonInterno = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_BuzonInternoInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_BuzonInternoInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_BuzonInternoDelete]    Script Date: 22/12/2008 11:19:46 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_BuzonInternoDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_BuzonInternoDelete];
GO

CREATE PROCEDURE [proc_BuzonInternoDelete]
(
	@IdBuzonInterno int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [BuzonInterno]
	WHERE
		[IdBuzonInterno] = @IdBuzonInterno
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_BuzonInternoDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_BuzonInternoDelete Error on Creation'
GO
