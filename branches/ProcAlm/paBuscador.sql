USE [BDGestionDocumentos]
GO
/****** Objeto:  StoredProcedure [dbo].[paBuscador]    Fecha de la secuencia de comandos: 10/24/2008 18:34:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[paBuscador] 
	-- Add the parameters for the stored procedure here
(  
	@Tabla varchar(40),
    @Campo varchar(40),
	@param varchar(40)
)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @Err int
	declare @iduser2 varchar(40)
	declare @iduser1 varchar(40)
	declare @iduser3 varchar(40)
	declare @query char(240)
	set @iduser1=''''+ @param +''''	
	set @iduser2='' + @Campo + ''
	set @iduser3=''+ @Tabla  +''
--	set @query= 'select * from '+ @Tabla+ 'where '+@Campo + 'like'+   @param
	set @query= 'select * from ' + @iduser3 + ' where ' + @iduser2 + ' like '+   @iduser1
--	select @query
	execute ( @query)

	SET @Err = @@Error

	RETURN @Err
END
