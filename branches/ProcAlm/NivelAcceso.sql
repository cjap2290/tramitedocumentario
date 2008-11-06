
USE [BDGestionDocumentos]
GO

/****** Object:  StoredProcedure [proc_NivelAccesoLoadByPrimaryKey]    Script Date: 06/11/2008 12:18:35 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NivelAccesoLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NivelAccesoLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_NivelAccesoLoadByPrimaryKey]
(
	@IdNivelAcceso char(3)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdNivelAcceso],
		[Descripcion]
	FROM [NivelAcceso]
	WHERE
		([IdNivelAcceso] = @IdNivelAcceso)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NivelAccesoLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_NivelAccesoLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_NivelAccesoLoadAll]    Script Date: 06/11/2008 12:18:35 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NivelAccesoLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NivelAccesoLoadAll];
GO

CREATE PROCEDURE [proc_NivelAccesoLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdNivelAcceso],
		[Descripcion]
	FROM [NivelAcceso]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NivelAccesoLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_NivelAccesoLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_NivelAccesoUpdate]    Script Date: 06/11/2008 12:18:35 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NivelAccesoUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NivelAccesoUpdate];
GO

CREATE PROCEDURE [proc_NivelAccesoUpdate]
(
	@IdNivelAcceso char(3),
	@Descripcion nchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [NivelAcceso]
	SET
		[Descripcion] = @Descripcion
	WHERE
		[IdNivelAcceso] = @IdNivelAcceso


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NivelAccesoUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_NivelAccesoUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_NivelAccesoInsert]    Script Date: 06/11/2008 12:18:35 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NivelAccesoInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NivelAccesoInsert];
GO

CREATE PROCEDURE [proc_NivelAccesoInsert]
(
	@IdNivelAcceso char(3),
	@Descripcion nchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [NivelAcceso]
	(
		[IdNivelAcceso],
		[Descripcion]
	)
	VALUES
	(
		@IdNivelAcceso,
		@Descripcion
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NivelAccesoInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_NivelAccesoInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_NivelAccesoDelete]    Script Date: 06/11/2008 12:18:35 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NivelAccesoDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NivelAccesoDelete];
GO

CREATE PROCEDURE [proc_NivelAccesoDelete]
(
	@IdNivelAcceso char(3)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [NivelAcceso]
	WHERE
		[IdNivelAcceso] = @IdNivelAcceso
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NivelAccesoDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_NivelAccesoDelete Error on Creation'
GO
