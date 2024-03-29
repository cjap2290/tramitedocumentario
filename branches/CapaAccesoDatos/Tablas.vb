
'===============================================================================
'  Generated From - VbNet_SQL_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  **
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'MustInherit' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can Override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  Public Class YourObject
'    Inherits _YourObject
'
'  End Class
'
'===============================================================================

' Generated by MyGeneration Version # (1.3.0.9)

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Specialized

Imports MyGeneration.dOOdads

Public MustInherit Class _Tablas
	Inherits SqlClientEntity

		Public Sub New() 
			Me.QuerySource = "Tablas"
			Me.MappingName = "Tablas"
		End Sub

	'=================================================================
	'  Public Overrides Sub AddNew()
	'=================================================================
	'
	'=================================================================
	Public Overrides Sub AddNew()
		MyBase.AddNew()
				
	End Sub
	
	Public Overrides Sub FlushData()
		Me._whereClause = nothing
		Me._aggregateClause = nothing		
		MyBase.FlushData()
	End Sub
	
		
	'=================================================================
	'  	Public Function LoadAll() As Boolean
	'=================================================================
	'  Loads all of the records in the database, and sets the currentRow to the first row
	'=================================================================
	Public Function LoadAll() As Boolean
	
		Dim parameters As ListDictionary = Nothing
		
		
    	Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_TablasLoadAll]", parameters)
		
	End Function

	'=================================================================
	' Public Overridable Function LoadByPrimaryKey()  As Boolean
	'=================================================================
	'  Loads a single row of via the primary key
	'=================================================================
    Public Overridable Function LoadByPrimaryKey(ByVal Id As Integer) As Boolean

        Dim parameters As ListDictionary = New ListDictionary()
        parameters.Add(_Tablas.Parameters.Id, Id)


        Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_TablasLoadByPrimaryKey]", parameters)

    End Function

#Region "Parameters"
    Protected Class Parameters

        Public Shared ReadOnly Property Id() As SqlParameter
            Get
                Return New SqlParameter("@Id", SqlDbType.Int, 0)
            End Get
        End Property

        Public Shared ReadOnly Property IdTabla() As SqlParameter
            Get
                Return New SqlParameter("@IdTabla", SqlDbType.Int, 0)
            End Get
        End Property

        Public Shared ReadOnly Property Cabecera() As SqlParameter
            Get
                Return New SqlParameter("@Cabecera", SqlDbType.VarChar, 70)
            End Get
        End Property

        Public Shared ReadOnly Property Descripcion() As SqlParameter
            Get
                Return New SqlParameter("@Descripcion", SqlDbType.VarChar, 70)
            End Get
        End Property

        Public Shared ReadOnly Property Valor() As SqlParameter
            Get
                Return New SqlParameter("@Valor", SqlDbType.Char, 7)
            End Get
        End Property

        Public Shared ReadOnly Property Valor2() As SqlParameter
            Get
                Return New SqlParameter("@Valor2", SqlDbType.Char, 7)
            End Get
        End Property

        Public Shared ReadOnly Property Estado() As SqlParameter
            Get
                Return New SqlParameter("@Estado", SqlDbType.Char, 1)
            End Get
        End Property

        Public Shared ReadOnly Property Nombre() As SqlParameter
            Get
                Return New SqlParameter("@Nombre", SqlDbType.Char, 15)
            End Get
        End Property

    End Class
#End Region

#Region "ColumnNames"
    Public Class ColumnNames

        Public Const Id As String = "Id"
        Public Const IdTabla As String = "IdTabla"
        Public Const Cabecera As String = "Cabecera"
        Public Const Descripcion As String = "Descripcion"
        Public Const Valor As String = "Valor"
        Public Const Valor2 As String = "Valor2"
        Public Const Estado As String = "Estado"
        Public Const Nombre As String = "Nombre"

        Public Shared Function ToPropertyName(ByVal columnName As String) As String

            If ht Is Nothing Then

                ht = New Hashtable

                ht(Id) = _Tablas.PropertyNames.Id
                ht(IdTabla) = _Tablas.PropertyNames.IdTabla
                ht(Cabecera) = _Tablas.PropertyNames.Cabecera
                ht(Descripcion) = _Tablas.PropertyNames.Descripcion
                ht(Valor) = _Tablas.PropertyNames.Valor
                ht(Valor2) = _Tablas.PropertyNames.Valor2
                ht(Estado) = _Tablas.PropertyNames.Estado
                ht(Nombre) = _Tablas.PropertyNames.Nombre

            End If

            Return CType(ht(columnName), String)

        End Function

        Private Shared ht As Hashtable = Nothing
    End Class
#End Region

#Region "PropertyNames"
    Public Class PropertyNames

        Public Const Id As String = "Id"
        Public Const IdTabla As String = "IdTabla"
        Public Const Cabecera As String = "Cabecera"
        Public Const Descripcion As String = "Descripcion"
        Public Const Valor As String = "Valor"
        Public Const Valor2 As String = "Valor2"
        Public Const Estado As String = "Estado"
        Public Const Nombre As String = "Nombre"

        Public Shared Function ToColumnName(ByVal propertyName As String) As String

            If ht Is Nothing Then

                ht = New Hashtable

                ht(Id) = _Tablas.ColumnNames.Id
                ht(IdTabla) = _Tablas.ColumnNames.IdTabla
                ht(Cabecera) = _Tablas.ColumnNames.Cabecera
                ht(Descripcion) = _Tablas.ColumnNames.Descripcion
                ht(Valor) = _Tablas.ColumnNames.Valor
                ht(Valor2) = _Tablas.ColumnNames.Valor2
                ht(Estado) = _Tablas.ColumnNames.Estado
                ht(Nombre) = _Tablas.ColumnNames.Nombre

            End If

            Return CType(ht(propertyName), String)

        End Function

        Private Shared ht As Hashtable = Nothing

    End Class
#End Region

#Region "StringPropertyNames"
    Public Class StringPropertyNames

        Public Const Id As String = "s_Id"
        Public Const IdTabla As String = "s_IdTabla"
        Public Const Cabecera As String = "s_Cabecera"
        Public Const Descripcion As String = "s_Descripcion"
        Public Const Valor As String = "s_Valor"
        Public Const Valor2 As String = "s_Valor2"
        Public Const Estado As String = "s_Estado"
        Public Const Nombre As String = "s_Nombre"

    End Class
#End Region

#Region "Properties"
    Public Overridable Property Id() As Integer
        Get
            Return MyBase.GetInteger(ColumnNames.Id)
        End Get
        Set(ByVal Value As Integer)
            MyBase.SetInteger(ColumnNames.Id, Value)
        End Set
    End Property

    Public Overridable Property IdTabla() As Integer
        Get
            Return MyBase.GetInteger(ColumnNames.IdTabla)
        End Get
        Set(ByVal Value As Integer)
            MyBase.SetInteger(ColumnNames.IdTabla, Value)
        End Set
    End Property

    Public Overridable Property Cabecera() As String
        Get
            Return MyBase.GetString(ColumnNames.Cabecera)
        End Get
        Set(ByVal Value As String)
            MyBase.SetString(ColumnNames.Cabecera, Value)
        End Set
    End Property

    Public Overridable Property Descripcion() As String
        Get
            Return MyBase.GetString(ColumnNames.Descripcion)
        End Get
        Set(ByVal Value As String)
            MyBase.SetString(ColumnNames.Descripcion, Value)
        End Set
    End Property

    Public Overridable Property Valor() As String
        Get
            Return MyBase.GetString(ColumnNames.Valor)
        End Get
        Set(ByVal Value As String)
            MyBase.SetString(ColumnNames.Valor, Value)
        End Set
    End Property

    Public Overridable Property Valor2() As String
        Get
            Return MyBase.GetString(ColumnNames.Valor2)
        End Get
        Set(ByVal Value As String)
            MyBase.SetString(ColumnNames.Valor2, Value)
        End Set
    End Property

    Public Overridable Property Estado() As String
        Get
            Return MyBase.GetString(ColumnNames.Estado)
        End Get
        Set(ByVal Value As String)
            MyBase.SetString(ColumnNames.Estado, Value)
        End Set
    End Property

    Public Overridable Property Nombre() As String
        Get
            Return MyBase.GetString(ColumnNames.Nombre)
        End Get
        Set(ByVal Value As String)
            MyBase.SetString(ColumnNames.Nombre, Value)
        End Set
    End Property


#End Region

#Region "String Properties"

    Public Overridable Property s_Id() As String
        Get
            If Me.IsColumnNull(ColumnNames.Id) Then
                Return String.Empty
            Else
                Return MyBase.GetIntegerAsString(ColumnNames.Id)
            End If
        End Get
        Set(ByVal Value As String)
            If String.Empty = Value Then
                Me.SetColumnNull(ColumnNames.Id)
            Else
                Me.Id = MyBase.SetIntegerAsString(ColumnNames.Id, Value)
            End If
        End Set
    End Property

    Public Overridable Property s_IdTabla() As String
        Get
            If Me.IsColumnNull(ColumnNames.IdTabla) Then
                Return String.Empty
            Else
                Return MyBase.GetIntegerAsString(ColumnNames.IdTabla)
            End If
        End Get
        Set(ByVal Value As String)
            If String.Empty = Value Then
                Me.SetColumnNull(ColumnNames.IdTabla)
            Else
                Me.IdTabla = MyBase.SetIntegerAsString(ColumnNames.IdTabla, Value)
            End If
        End Set
    End Property

    Public Overridable Property s_Cabecera() As String
        Get
            If Me.IsColumnNull(ColumnNames.Cabecera) Then
                Return String.Empty
            Else
                Return MyBase.GetStringAsString(ColumnNames.Cabecera)
            End If
        End Get
        Set(ByVal Value As String)
            If String.Empty = Value Then
                Me.SetColumnNull(ColumnNames.Cabecera)
            Else
                Me.Cabecera = MyBase.SetStringAsString(ColumnNames.Cabecera, Value)
            End If
        End Set
    End Property

    Public Overridable Property s_Descripcion() As String
        Get
            If Me.IsColumnNull(ColumnNames.Descripcion) Then
                Return String.Empty
            Else
                Return MyBase.GetStringAsString(ColumnNames.Descripcion)
            End If
        End Get
        Set(ByVal Value As String)
            If String.Empty = Value Then
                Me.SetColumnNull(ColumnNames.Descripcion)
            Else
                Me.Descripcion = MyBase.SetStringAsString(ColumnNames.Descripcion, Value)
            End If
        End Set
    End Property

    Public Overridable Property s_Valor() As String
        Get
            If Me.IsColumnNull(ColumnNames.Valor) Then
                Return String.Empty
            Else
                Return MyBase.GetStringAsString(ColumnNames.Valor)
            End If
        End Get
        Set(ByVal Value As String)
            If String.Empty = Value Then
                Me.SetColumnNull(ColumnNames.Valor)
            Else
                Me.Valor = MyBase.SetStringAsString(ColumnNames.Valor, Value)
            End If
        End Set
    End Property

    Public Overridable Property s_Valor2() As String
        Get
            If Me.IsColumnNull(ColumnNames.Valor2) Then
                Return String.Empty
            Else
                Return MyBase.GetStringAsString(ColumnNames.Valor2)
            End If
        End Get
        Set(ByVal Value As String)
            If String.Empty = Value Then
                Me.SetColumnNull(ColumnNames.Valor2)
            Else
                Me.Valor2 = MyBase.SetStringAsString(ColumnNames.Valor2, Value)
            End If
        End Set
    End Property

    Public Overridable Property s_Estado() As String
        Get
            If Me.IsColumnNull(ColumnNames.Estado) Then
                Return String.Empty
            Else
                Return MyBase.GetStringAsString(ColumnNames.Estado)
            End If
        End Get
        Set(ByVal Value As String)
            If String.Empty = Value Then
                Me.SetColumnNull(ColumnNames.Estado)
            Else
                Me.Estado = MyBase.SetStringAsString(ColumnNames.Estado, Value)
            End If
        End Set
    End Property

    Public Overridable Property s_Nombre() As String
        Get
            If Me.IsColumnNull(ColumnNames.Nombre) Then
                Return String.Empty
            Else
                Return MyBase.GetStringAsString(ColumnNames.Nombre)
            End If
        End Get
        Set(ByVal Value As String)
            If String.Empty = Value Then
                Me.SetColumnNull(ColumnNames.Nombre)
            Else
                Me.Nombre = MyBase.SetStringAsString(ColumnNames.Nombre, Value)
            End If
        End Set
    End Property


#End Region

	#Region "Where Clause"
    Public Class WhereClause

        Public Sub New(ByVal entity As BusinessEntity)
            Me._entity = entity
        End Sub
		
		Public ReadOnly Property TearOff As TearOffWhereParameter
			Get
				If _tearOff Is Nothing Then
					_tearOff = new TearOffWhereParameter(Me)
				End If

				Return _tearOff
			End Get
		End Property

		#Region "TearOff's"
		Public class TearOffWhereParameter

			Public Sub New(ByVal clause As WhereClause)
				Me._clause = clause
			End Sub
		
	
			Public ReadOnly Property Id() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Id, Parameters.Id)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdTabla() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdTabla, Parameters.IdTabla)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Cabecera() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Cabecera, Parameters.Cabecera)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Descripcion() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Descripcion, Parameters.Descripcion)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Valor() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Valor, Parameters.Valor)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Valor2() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Valor2, Parameters.Valor2)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Estado() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Estado, Parameters.Estado)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Nombre() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Nombre, Parameters.Nombre)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property


			Private _clause as WhereClause
		End Class
		#End Region	

		Public ReadOnly Property Id() As WhereParameter 
			Get
				If _Id_W Is Nothing Then
					_Id_W = TearOff.Id
				End If
				Return _Id_W
			End Get
		End Property

		Public ReadOnly Property IdTabla() As WhereParameter 
			Get
				If _IdTabla_W Is Nothing Then
					_IdTabla_W = TearOff.IdTabla
				End If
				Return _IdTabla_W
			End Get
		End Property

		Public ReadOnly Property Cabecera() As WhereParameter 
			Get
				If _Cabecera_W Is Nothing Then
					_Cabecera_W = TearOff.Cabecera
				End If
				Return _Cabecera_W
			End Get
		End Property

		Public ReadOnly Property Descripcion() As WhereParameter 
			Get
				If _Descripcion_W Is Nothing Then
					_Descripcion_W = TearOff.Descripcion
				End If
				Return _Descripcion_W
			End Get
		End Property

		Public ReadOnly Property Valor() As WhereParameter 
			Get
				If _Valor_W Is Nothing Then
					_Valor_W = TearOff.Valor
				End If
				Return _Valor_W
			End Get
		End Property

		Public ReadOnly Property Valor2() As WhereParameter 
			Get
				If _Valor2_W Is Nothing Then
					_Valor2_W = TearOff.Valor2
				End If
				Return _Valor2_W
			End Get
		End Property

		Public ReadOnly Property Estado() As WhereParameter 
			Get
				If _Estado_W Is Nothing Then
					_Estado_W = TearOff.Estado
				End If
				Return _Estado_W
			End Get
		End Property

		Public ReadOnly Property Nombre() As WhereParameter 
			Get
				If _Nombre_W Is Nothing Then
					_Nombre_W = TearOff.Nombre
				End If
				Return _Nombre_W
			End Get
		End Property

		Private _Id_W As WhereParameter = Nothing
		Private _IdTabla_W As WhereParameter = Nothing
		Private _Cabecera_W As WhereParameter = Nothing
		Private _Descripcion_W As WhereParameter = Nothing
		Private _Valor_W As WhereParameter = Nothing
		Private _Valor2_W As WhereParameter = Nothing
		Private _Estado_W As WhereParameter = Nothing
		Private _Nombre_W As WhereParameter = Nothing

			Public Sub WhereClauseReset()

			_Id_W = Nothing
			_IdTabla_W = Nothing
			_Cabecera_W = Nothing
			_Descripcion_W = Nothing
			_Valor_W = Nothing
			_Valor2_W = Nothing
			_Estado_W = Nothing
			_Nombre_W = Nothing
				Me._entity.Query.FlushWhereParameters()

			End Sub
	
		Private _entity As BusinessEntity
		Private _tearOff As TearOffWhereParameter
    End Class	

	Public ReadOnly Property Where() As WhereClause
		Get
			If _whereClause Is Nothing Then
				_whereClause = New WhereClause(Me)
			End If
	
			Return _whereClause
		End Get
	End Property
	
	Private _whereClause As WhereClause = Nothing	
#End Region	

#Region "Aggregate Clause"
    Public Class AggregateClause

        Public Sub New(ByVal entity As BusinessEntity)
            Me._entity = entity
        End Sub
		
		Public ReadOnly Property TearOff As TearOffAggregateParameter
			Get
				If _tearOff Is Nothing Then
					_tearOff = new TearOffAggregateParameter(Me)
				End If

				Return _tearOff
			End Get
		End Property

		#Region "AggregateParameter TearOff's"
		Public class TearOffAggregateParameter

			Public Sub New(ByVal clause As AggregateClause)
				Me._clause = clause
			End Sub
		
	
		Public ReadOnly Property Id() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Id, Parameters.Id)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdTabla() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdTabla, Parameters.IdTabla)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Cabecera() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Cabecera, Parameters.Cabecera)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Descripcion() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Descripcion, Parameters.Descripcion)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Valor() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Valor, Parameters.Valor)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Valor2() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Valor2, Parameters.Valor2)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Estado() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Estado, Parameters.Estado)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Nombre() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Nombre, Parameters.Nombre)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property


			Private _clause as AggregateClause
		End Class
		#End Region	

		Public ReadOnly Property Id() As AggregateParameter 
			Get
				If _Id_W Is Nothing Then
					_Id_W = TearOff.Id
				End If
				Return _Id_W
			End Get
		End Property

		Public ReadOnly Property IdTabla() As AggregateParameter 
			Get
				If _IdTabla_W Is Nothing Then
					_IdTabla_W = TearOff.IdTabla
				End If
				Return _IdTabla_W
			End Get
		End Property

		Public ReadOnly Property Cabecera() As AggregateParameter 
			Get
				If _Cabecera_W Is Nothing Then
					_Cabecera_W = TearOff.Cabecera
				End If
				Return _Cabecera_W
			End Get
		End Property

		Public ReadOnly Property Descripcion() As AggregateParameter 
			Get
				If _Descripcion_W Is Nothing Then
					_Descripcion_W = TearOff.Descripcion
				End If
				Return _Descripcion_W
			End Get
		End Property

		Public ReadOnly Property Valor() As AggregateParameter 
			Get
				If _Valor_W Is Nothing Then
					_Valor_W = TearOff.Valor
				End If
				Return _Valor_W
			End Get
		End Property

		Public ReadOnly Property Valor2() As AggregateParameter 
			Get
				If _Valor2_W Is Nothing Then
					_Valor2_W = TearOff.Valor2
				End If
				Return _Valor2_W
			End Get
		End Property

		Public ReadOnly Property Estado() As AggregateParameter 
			Get
				If _Estado_W Is Nothing Then
					_Estado_W = TearOff.Estado
				End If
				Return _Estado_W
			End Get
		End Property

		Public ReadOnly Property Nombre() As AggregateParameter 
			Get
				If _Nombre_W Is Nothing Then
					_Nombre_W = TearOff.Nombre
				End If
				Return _Nombre_W
			End Get
		End Property

		Private _Id_W As AggregateParameter = Nothing
		Private _IdTabla_W As AggregateParameter = Nothing
		Private _Cabecera_W As AggregateParameter = Nothing
		Private _Descripcion_W As AggregateParameter = Nothing
		Private _Valor_W As AggregateParameter = Nothing
		Private _Valor2_W As AggregateParameter = Nothing
		Private _Estado_W As AggregateParameter = Nothing
		Private _Nombre_W As AggregateParameter = Nothing

		Public Sub AggregateClauseReset()

		_Id_W = Nothing
		_IdTabla_W = Nothing
		_Cabecera_W = Nothing
		_Descripcion_W = Nothing
		_Valor_W = Nothing
		_Valor2_W = Nothing
		_Estado_W = Nothing
		_Nombre_W = Nothing
			Me._entity.Query.FlushAggregateParameters()

		End Sub
	
		Private _entity As BusinessEntity
		Private _tearOff As TearOffAggregateParameter
    End Class	

	Public ReadOnly Property Aggregate() As AggregateClause
		Get
			If _aggregateClause Is Nothing Then
				_aggregateClause = New AggregateClause(Me)
			End If
	
			Return _aggregateClause
		End Get
	End Property
	
	Private _aggregateClause As AggregateClause = Nothing	
#End Region	

	Protected Overrides Function GetInsertCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_TablasInsert]" 
	    
		CreateParameters(cmd)
		
		Dim p As SqlParameter
		p = cmd.Parameters(Parameters.Id.ParameterName)
		p.Direction = ParameterDirection.Output
    
		Return cmd 

  	End Function
	
	Protected Overrides Function GetUpdateCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_TablasUpdate]" 
		
		CreateParameters(cmd) 
		    
		Return cmd
	
	End Function	
	
	Protected Overrides Function GetDeleteCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_TablasDelete]" 
		
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.Id)
		p.SourceColumn = ColumnNames.Id
		p.SourceVersion = DataRowVersion.Current

  
		Return cmd
	
	End Function	
	
	Private Sub CreateParameters(ByVal cmd As SqlCommand)
	
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.Id)
		p.SourceColumn = ColumnNames.Id
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdTabla)
		p.SourceColumn = ColumnNames.IdTabla
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Cabecera)
		p.SourceColumn = ColumnNames.Cabecera
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Descripcion)
		p.SourceColumn = ColumnNames.Descripcion
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Valor)
		p.SourceColumn = ColumnNames.Valor
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Valor2)
		p.SourceColumn = ColumnNames.Valor2
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Estado)
		p.SourceColumn = ColumnNames.Estado
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Nombre)
		p.SourceColumn = ColumnNames.Nombre
		p.SourceVersion = DataRowVersion.Current


	End Sub	

End Class

