
USE [BDGestionDocumentos]
GO

/****** Object:  StoredProcedure [proc_AgenciasLoadByPrimaryKey]    Script Date: 05/11/2008 16:12:22 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AgenciasLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AgenciasLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_AgenciasLoadByPrimaryKey]
(
	@Idagencia char(2)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[Idagencia],
		[Agencia],
		[Fechape],
		[Direccion],
		[Fecpro],
		[Iduser],
		[Hora],
		[Abrev]
	FROM [Agencias]
	WHERE
		([Idagencia] = @Idagencia)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AgenciasLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_AgenciasLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AgenciasLoadAll]    Script Date: 05/11/2008 16:12:22 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AgenciasLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AgenciasLoadAll];
GO

CREATE PROCEDURE [proc_AgenciasLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[Idagencia],
		[Agencia],
		[Fechape],
		[Direccion],
		[Fecpro],
		[Iduser],
		[Hora],
		[Abrev]
	FROM [Agencias]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AgenciasLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_AgenciasLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AgenciasUpdate]    Script Date: 05/11/2008 16:12:23 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AgenciasUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AgenciasUpdate];
GO

CREATE PROCEDURE [proc_AgenciasUpdate]
(
	@Idagencia char(2),
	@Agencia varchar(50),
	@Fechape datetime,
	@Direccion varchar(60) = NULL,
	@Fecpro datetime,
	@Iduser char(6),
	@Hora char(8),
	@Abrev char(4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Agencias]
	SET
		[Agencia] = @Agencia,
		[Fechape] = @Fechape,
		[Direccion] = @Direccion,
		[Fecpro] = @Fecpro,
		[Iduser] = @Iduser,
		[Hora] = @Hora,
		[Abrev] = @Abrev
	WHERE
		[Idagencia] = @Idagencia


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AgenciasUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_AgenciasUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_AgenciasInsert]    Script Date: 05/11/2008 16:12:23 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AgenciasInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AgenciasInsert];
GO

CREATE PROCEDURE [proc_AgenciasInsert]
(
	@Idagencia char(2),
	@Agencia varchar(50),
	@Fechape datetime,
	@Direccion varchar(60) = NULL,
	@Fecpro datetime,
	@Iduser char(6),
	@Hora char(8),
	@Abrev char(4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Agencias]
	(
		[Idagencia],
		[Agencia],
		[Fechape],
		[Direccion],
		[Fecpro],
		[Iduser],
		[Hora],
		[Abrev]
	)
	VALUES
	(
		@Idagencia,
		@Agencia,
		@Fechape,
		@Direccion,
		@Fecpro,
		@Iduser,
		@Hora,
		@Abrev
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AgenciasInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_AgenciasInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AgenciasDelete]    Script Date: 05/11/2008 16:12:23 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AgenciasDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AgenciasDelete];
GO

CREATE PROCEDURE [proc_AgenciasDelete]
(
	@Idagencia char(2)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Agencias]
	WHERE
		[Idagencia] = @Idagencia
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AgenciasDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_AgenciasDelete Error on Creation'
GO
