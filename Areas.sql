
USE [BDGestionDocumentos]
GO

/****** Object:  StoredProcedure [proc_AreasLoadByPrimaryKey]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AreasLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AreasLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_AreasLoadByPrimaryKey]
(
	@IdArea char(2)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdArea],
		[Area]
	FROM [Areas]
	WHERE
		([IdArea] = @IdArea)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AreasLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_AreasLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AreasLoadAll]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AreasLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AreasLoadAll];
GO

CREATE PROCEDURE [proc_AreasLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdArea],
		[Area]
	FROM [Areas]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AreasLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_AreasLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AreasUpdate]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AreasUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AreasUpdate];
GO

CREATE PROCEDURE [proc_AreasUpdate]
(
	@IdArea char(2),
	@Area varchar(40)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Areas]
	SET
		[Area] = @Area
	WHERE
		[IdArea] = @IdArea


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AreasUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_AreasUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_AreasInsert]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AreasInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AreasInsert];
GO

CREATE PROCEDURE [proc_AreasInsert]
(
	@IdArea char(2),
	@Area varchar(40)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Areas]
	(
		[IdArea],
		[Area]
	)
	VALUES
	(
		@IdArea,
		@Area
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AreasInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_AreasInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AreasDelete]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AreasDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AreasDelete];
GO

CREATE PROCEDURE [proc_AreasDelete]
(
	@IdArea char(2)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Areas]
	WHERE
		[IdArea] = @IdArea
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AreasDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_AreasDelete Error on Creation'
GO
