
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

' Generated by MyGeneration Version # (1.3.0.3)

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Specialized

Imports MyGeneration.dOOdads

Public MustInherit Class _AsignaDocInterno
	Inherits SqlClientEntity

		Public Sub New() 
			Me.QuerySource = "AsignaDocInterno"
			Me.MappingName = "AsignaDocInterno"
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
		
		
    	Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_AsignaDocInternoLoadAll]", parameters)
		
	End Function

	'=================================================================
	' Public Overridable Function LoadByPrimaryKey()  As Boolean
	'=================================================================
	'  Loads a single row of via the primary key
	'=================================================================
	Public Overridable Function LoadByPrimaryKey(ByVal IdAsigDocInterno As Integer) As Boolean

		Dim parameters As ListDictionary = New ListDictionary()
		parameters.Add(_AsignaDocInterno.Parameters.IdAsigDocInterno, IdAsigDocInterno)

		
		Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_AsignaDocInternoLoadByPrimaryKey]", parameters)

	End Function

	#Region "Parameters"
	Protected class Parameters 
		
		Public Shared ReadOnly Property IdAsigDocInterno As SqlParameter
			Get
				Return New SqlParameter("@IdAsigDocInterno", SqlDbType.Int, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdUser As SqlParameter
			Get
				Return New SqlParameter("@IdUser", SqlDbType.Char, 6)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdDocInterno As SqlParameter
			Get
				Return New SqlParameter("@IdDocInterno", SqlDbType.Int, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdEstAsigDoc As SqlParameter
			Get
				Return New SqlParameter("@IdEstAsigDoc", SqlDbType.Int, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property Condicion As SqlParameter
			Get
				Return New SqlParameter("@Condicion", SqlDbType.Char, 1)
			End Get
		End Property
		
		Public Shared ReadOnly Property FechaR As SqlParameter
			Get
				Return New SqlParameter("@FechaR", SqlDbType.DateTime, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdUserR As SqlParameter
			Get
				Return New SqlParameter("@IdUserR", SqlDbType.Char, 6)
			End Get
		End Property
		
	End Class
	#End Region	

	#Region "ColumnNames"
	Public class ColumnNames
		
        Public Const IdAsigDocInterno As String = "IdAsigDocInterno"
        Public Const IdUser As String = "IdUser"
        Public Const IdDocInterno As String = "IdDocInterno"
        Public Const IdEstAsigDoc As String = "IdEstAsigDoc"
        Public Const Condicion As String = "Condicion"
        Public Const FechaR As String = "FechaR"
        Public Const IdUserR As String = "IdUserR"

		Shared Public Function ToPropertyName(ByVal columnName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(IdAsigDocInterno) = _AsignaDocInterno.PropertyNames.IdAsigDocInterno
				ht(IdUser) = _AsignaDocInterno.PropertyNames.IdUser
				ht(IdDocInterno) = _AsignaDocInterno.PropertyNames.IdDocInterno
				ht(IdEstAsigDoc) = _AsignaDocInterno.PropertyNames.IdEstAsigDoc
				ht(Condicion) = _AsignaDocInterno.PropertyNames.Condicion
				ht(FechaR) = _AsignaDocInterno.PropertyNames.FechaR
				ht(IdUserR) = _AsignaDocInterno.PropertyNames.IdUserR

			End If
			
			Return CType(ht(columnName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing		 
	End Class
	#End Region	
	
	#Region "PropertyNames"
	Public class PropertyNames
		
        Public Const IdAsigDocInterno As String = "IdAsigDocInterno"
        Public Const IdUser As String = "IdUser"
        Public Const IdDocInterno As String = "IdDocInterno"
        Public Const IdEstAsigDoc As String = "IdEstAsigDoc"
        Public Const Condicion As String = "Condicion"
        Public Const FechaR As String = "FechaR"
        Public Const IdUserR As String = "IdUserR"

		Shared Public Function ToColumnName(ByVal propertyName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(IdAsigDocInterno) = _AsignaDocInterno.ColumnNames.IdAsigDocInterno
				ht(IdUser) = _AsignaDocInterno.ColumnNames.IdUser
				ht(IdDocInterno) = _AsignaDocInterno.ColumnNames.IdDocInterno
				ht(IdEstAsigDoc) = _AsignaDocInterno.ColumnNames.IdEstAsigDoc
				ht(Condicion) = _AsignaDocInterno.ColumnNames.Condicion
				ht(FechaR) = _AsignaDocInterno.ColumnNames.FechaR
				ht(IdUserR) = _AsignaDocInterno.ColumnNames.IdUserR

			End If
			
			Return CType(ht(propertyName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing
		
	End Class
	#End Region	
	
	#Region "StringPropertyNames"
	Public class StringPropertyNames
		
        Public Const IdAsigDocInterno As String = "s_IdAsigDocInterno"
        Public Const IdUser As String = "s_IdUser"
        Public Const IdDocInterno As String = "s_IdDocInterno"
        Public Const IdEstAsigDoc As String = "s_IdEstAsigDoc"
        Public Const Condicion As String = "s_Condicion"
        Public Const FechaR As String = "s_FechaR"
        Public Const IdUserR As String = "s_IdUserR"

	End Class
	#End Region		
	
	#Region "Properties" 
		Public Overridable Property IdAsigDocInterno As Integer
			Get
				Return MyBase.GetInteger(ColumnNames.IdAsigDocInterno)
			End Get
			Set(ByVal Value As Integer)
				MyBase.SetInteger(ColumnNames.IdAsigDocInterno, Value)
			End Set
		End Property

		Public Overridable Property IdUser As String
			Get
				Return MyBase.GetString(ColumnNames.IdUser)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.IdUser, Value)
			End Set
		End Property

		Public Overridable Property IdDocInterno As Integer
			Get
				Return MyBase.GetInteger(ColumnNames.IdDocInterno)
			End Get
			Set(ByVal Value As Integer)
				MyBase.SetInteger(ColumnNames.IdDocInterno, Value)
			End Set
		End Property

		Public Overridable Property IdEstAsigDoc As Integer
			Get
				Return MyBase.GetInteger(ColumnNames.IdEstAsigDoc)
			End Get
			Set(ByVal Value As Integer)
				MyBase.SetInteger(ColumnNames.IdEstAsigDoc, Value)
			End Set
		End Property

		Public Overridable Property Condicion As String
			Get
				Return MyBase.GetString(ColumnNames.Condicion)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.Condicion, Value)
			End Set
		End Property

		Public Overridable Property FechaR As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.FechaR)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.FechaR, Value)
			End Set
		End Property

		Public Overridable Property IdUserR As String
			Get
				Return MyBase.GetString(ColumnNames.IdUserR)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.IdUserR, Value)
			End Set
		End Property


	#End Region  
	
	#Region "String Properties" 

		Public Overridable Property s_IdAsigDocInterno As String
			Get
				If Me.IsColumnNull(ColumnNames.IdAsigDocInterno) Then
					Return String.Empty
				Else
					Return MyBase.GetIntegerAsString(ColumnNames.IdAsigDocInterno)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdAsigDocInterno)
				Else
					Me.IdAsigDocInterno = MyBase.SetIntegerAsString(ColumnNames.IdAsigDocInterno, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IdUser As String
			Get
				If Me.IsColumnNull(ColumnNames.IdUser) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.IdUser)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdUser)
				Else
					Me.IdUser = MyBase.SetStringAsString(ColumnNames.IdUser, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IdDocInterno As String
			Get
				If Me.IsColumnNull(ColumnNames.IdDocInterno) Then
					Return String.Empty
				Else
					Return MyBase.GetIntegerAsString(ColumnNames.IdDocInterno)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdDocInterno)
				Else
					Me.IdDocInterno = MyBase.SetIntegerAsString(ColumnNames.IdDocInterno, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IdEstAsigDoc As String
			Get
				If Me.IsColumnNull(ColumnNames.IdEstAsigDoc) Then
					Return String.Empty
				Else
					Return MyBase.GetIntegerAsString(ColumnNames.IdEstAsigDoc)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdEstAsigDoc)
				Else
					Me.IdEstAsigDoc = MyBase.SetIntegerAsString(ColumnNames.IdEstAsigDoc, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Condicion As String
			Get
				If Me.IsColumnNull(ColumnNames.Condicion) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.Condicion)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Condicion)
				Else
					Me.Condicion = MyBase.SetStringAsString(ColumnNames.Condicion, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_FechaR As String
			Get
				If Me.IsColumnNull(ColumnNames.FechaR) Then
					Return String.Empty
				Else
					Return MyBase.GetDateTimeAsString(ColumnNames.FechaR)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FechaR)
				Else
					Me.FechaR = MyBase.SetDateTimeAsString(ColumnNames.FechaR, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IdUserR As String
			Get
				If Me.IsColumnNull(ColumnNames.IdUserR) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.IdUserR)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdUserR)
				Else
					Me.IdUserR = MyBase.SetStringAsString(ColumnNames.IdUserR, Value)
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
		
	
			Public ReadOnly Property IdAsigDocInterno() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdAsigDocInterno, Parameters.IdAsigDocInterno)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdUser() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdUser, Parameters.IdUser)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdDocInterno() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdDocInterno, Parameters.IdDocInterno)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdEstAsigDoc() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdEstAsigDoc, Parameters.IdEstAsigDoc)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Condicion() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Condicion, Parameters.Condicion)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property FechaR() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.FechaR, Parameters.FechaR)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdUserR() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdUserR, Parameters.IdUserR)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property


			Private _clause as WhereClause
		End Class
		#End Region	

		Public ReadOnly Property IdAsigDocInterno() As WhereParameter 
			Get
				If _IdAsigDocInterno_W Is Nothing Then
					_IdAsigDocInterno_W = TearOff.IdAsigDocInterno
				End If
				Return _IdAsigDocInterno_W
			End Get
		End Property

		Public ReadOnly Property IdUser() As WhereParameter 
			Get
				If _IdUser_W Is Nothing Then
					_IdUser_W = TearOff.IdUser
				End If
				Return _IdUser_W
			End Get
		End Property

		Public ReadOnly Property IdDocInterno() As WhereParameter 
			Get
				If _IdDocInterno_W Is Nothing Then
					_IdDocInterno_W = TearOff.IdDocInterno
				End If
				Return _IdDocInterno_W
			End Get
		End Property

		Public ReadOnly Property IdEstAsigDoc() As WhereParameter 
			Get
				If _IdEstAsigDoc_W Is Nothing Then
					_IdEstAsigDoc_W = TearOff.IdEstAsigDoc
				End If
				Return _IdEstAsigDoc_W
			End Get
		End Property

		Public ReadOnly Property Condicion() As WhereParameter 
			Get
				If _Condicion_W Is Nothing Then
					_Condicion_W = TearOff.Condicion
				End If
				Return _Condicion_W
			End Get
		End Property

		Public ReadOnly Property FechaR() As WhereParameter 
			Get
				If _FechaR_W Is Nothing Then
					_FechaR_W = TearOff.FechaR
				End If
				Return _FechaR_W
			End Get
		End Property

		Public ReadOnly Property IdUserR() As WhereParameter 
			Get
				If _IdUserR_W Is Nothing Then
					_IdUserR_W = TearOff.IdUserR
				End If
				Return _IdUserR_W
			End Get
		End Property

		Private _IdAsigDocInterno_W As WhereParameter = Nothing
		Private _IdUser_W As WhereParameter = Nothing
		Private _IdDocInterno_W As WhereParameter = Nothing
		Private _IdEstAsigDoc_W As WhereParameter = Nothing
		Private _Condicion_W As WhereParameter = Nothing
		Private _FechaR_W As WhereParameter = Nothing
		Private _IdUserR_W As WhereParameter = Nothing

			Public Sub WhereClauseReset()

			_IdAsigDocInterno_W = Nothing
			_IdUser_W = Nothing
			_IdDocInterno_W = Nothing
			_IdEstAsigDoc_W = Nothing
			_Condicion_W = Nothing
			_FechaR_W = Nothing
			_IdUserR_W = Nothing
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
		
	
		Public ReadOnly Property IdAsigDocInterno() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdAsigDocInterno, Parameters.IdAsigDocInterno)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdUser() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdUser, Parameters.IdUser)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdDocInterno() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdDocInterno, Parameters.IdDocInterno)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdEstAsigDoc() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdEstAsigDoc, Parameters.IdEstAsigDoc)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Condicion() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Condicion, Parameters.Condicion)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property FechaR() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FechaR, Parameters.FechaR)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdUserR() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdUserR, Parameters.IdUserR)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property


			Private _clause as AggregateClause
		End Class
		#End Region	

		Public ReadOnly Property IdAsigDocInterno() As AggregateParameter 
			Get
				If _IdAsigDocInterno_W Is Nothing Then
					_IdAsigDocInterno_W = TearOff.IdAsigDocInterno
				End If
				Return _IdAsigDocInterno_W
			End Get
		End Property

		Public ReadOnly Property IdUser() As AggregateParameter 
			Get
				If _IdUser_W Is Nothing Then
					_IdUser_W = TearOff.IdUser
				End If
				Return _IdUser_W
			End Get
		End Property

		Public ReadOnly Property IdDocInterno() As AggregateParameter 
			Get
				If _IdDocInterno_W Is Nothing Then
					_IdDocInterno_W = TearOff.IdDocInterno
				End If
				Return _IdDocInterno_W
			End Get
		End Property

		Public ReadOnly Property IdEstAsigDoc() As AggregateParameter 
			Get
				If _IdEstAsigDoc_W Is Nothing Then
					_IdEstAsigDoc_W = TearOff.IdEstAsigDoc
				End If
				Return _IdEstAsigDoc_W
			End Get
		End Property

		Public ReadOnly Property Condicion() As AggregateParameter 
			Get
				If _Condicion_W Is Nothing Then
					_Condicion_W = TearOff.Condicion
				End If
				Return _Condicion_W
			End Get
		End Property

		Public ReadOnly Property FechaR() As AggregateParameter 
			Get
				If _FechaR_W Is Nothing Then
					_FechaR_W = TearOff.FechaR
				End If
				Return _FechaR_W
			End Get
		End Property

		Public ReadOnly Property IdUserR() As AggregateParameter 
			Get
				If _IdUserR_W Is Nothing Then
					_IdUserR_W = TearOff.IdUserR
				End If
				Return _IdUserR_W
			End Get
		End Property

		Private _IdAsigDocInterno_W As AggregateParameter = Nothing
		Private _IdUser_W As AggregateParameter = Nothing
		Private _IdDocInterno_W As AggregateParameter = Nothing
		Private _IdEstAsigDoc_W As AggregateParameter = Nothing
		Private _Condicion_W As AggregateParameter = Nothing
		Private _FechaR_W As AggregateParameter = Nothing
		Private _IdUserR_W As AggregateParameter = Nothing

		Public Sub AggregateClauseReset()

		_IdAsigDocInterno_W = Nothing
		_IdUser_W = Nothing
		_IdDocInterno_W = Nothing
		_IdEstAsigDoc_W = Nothing
		_Condicion_W = Nothing
		_FechaR_W = Nothing
		_IdUserR_W = Nothing
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
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_AsignaDocInternoInsert]" 
	    
		CreateParameters(cmd)
		
		Dim p As SqlParameter
		p = cmd.Parameters(Parameters.IdAsigDocInterno.ParameterName)
		p.Direction = ParameterDirection.Output
    
		Return cmd 

  	End Function
	
	Protected Overrides Function GetUpdateCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_AsignaDocInternoUpdate]" 
		
		CreateParameters(cmd) 
		    
		Return cmd
	
	End Function	
	
	Protected Overrides Function GetDeleteCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_AsignaDocInternoDelete]" 
		
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.IdAsigDocInterno)
		p.SourceColumn = ColumnNames.IdAsigDocInterno
		p.SourceVersion = DataRowVersion.Current

  
		Return cmd
	
	End Function	
	
	Private Sub CreateParameters(ByVal cmd As SqlCommand)
	
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.IdAsigDocInterno)
		p.SourceColumn = ColumnNames.IdAsigDocInterno
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdUser)
		p.SourceColumn = ColumnNames.IdUser
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdDocInterno)
		p.SourceColumn = ColumnNames.IdDocInterno
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdEstAsigDoc)
		p.SourceColumn = ColumnNames.IdEstAsigDoc
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Condicion)
		p.SourceColumn = ColumnNames.Condicion
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.FechaR)
		p.SourceColumn = ColumnNames.FechaR
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdUserR)
		p.SourceColumn = ColumnNames.IdUserR
		p.SourceVersion = DataRowVersion.Current


	End Sub	

End Class

