
/****** Object:  StoredProcedure [proc_CargosLoadByPrimaryKey]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CargosLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CargosLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_CargosLoadByPrimaryKey]
(
	@IdCargo char(2)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdCargo],
		[Cargo]
	FROM [Cargos]
	WHERE
		([IdCargo] = @IdCargo)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CargosLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CargosLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CargosLoadAll]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CargosLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CargosLoadAll];
GO

CREATE PROCEDURE [proc_CargosLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IdCargo],
		[Cargo]
	FROM [Cargos]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CargosLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CargosLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CargosUpdate]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CargosUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CargosUpdate];
GO

CREATE PROCEDURE [proc_CargosUpdate]
(
	@IdCargo char(2),
	@Cargo varchar(40)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Cargos]
	SET
		[Cargo] = @Cargo
	WHERE
		[IdCargo] = @IdCargo


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CargosUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CargosUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_CargosInsert]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CargosInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CargosInsert];
GO

CREATE PROCEDURE [proc_CargosInsert]
(
	@IdCargo char(2),
	@Cargo varchar(40)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Cargos]
	(
		[IdCargo],
		[Cargo]
	)
	VALUES
	(
		@IdCargo,
		@Cargo
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CargosInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CargosInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CargosDelete]    Script Date: 01/11/2008 2:30:41 ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CargosDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CargosDelete];
GO

CREATE PROCEDURE [proc_CargosDelete]
(
	@IdCargo char(2)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Cargos]
	WHERE
		[IdCargo] = @IdCargo
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CargosDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CargosDelete Error on Creation'
GO
