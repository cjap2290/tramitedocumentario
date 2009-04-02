
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

Public MustInherit Class _Anexos
	Inherits SqlClientEntity

		Public Sub New() 
			Me.QuerySource = "Anexos"
			Me.MappingName = "Anexos"
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
		
		
    	Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_AnexosLoadAll]", parameters)
		
	End Function

	'=================================================================
	' Public Overridable Function LoadByPrimaryKey()  As Boolean
	'=================================================================
	'  Loads a single row of via the primary key
	'=================================================================
	Public Overridable Function LoadByPrimaryKey(ByVal IdAnexo As Integer) As Boolean

		Dim parameters As ListDictionary = New ListDictionary()
		parameters.Add(_Anexos.Parameters.IdAnexo, IdAnexo)

		
		Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_AnexosLoadByPrimaryKey]", parameters)

	End Function

	#Region "Parameters"
	Protected class Parameters 
		
		Public Shared ReadOnly Property IdAnexo As SqlParameter
			Get
				Return New SqlParameter("@IdAnexo", SqlDbType.Int, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdDocInterno As SqlParameter
			Get
				Return New SqlParameter("@IdDocInterno", SqlDbType.Int, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property NombreAnexo As SqlParameter
			Get
				Return New SqlParameter("@NombreAnexo", SqlDbType.VarChar, 30)
			End Get
		End Property
		
		Public Shared ReadOnly Property RutaAnexo As SqlParameter
			Get
                Return New SqlParameter("@RutaAnexo", SqlDbType.VarChar, 100)
			End Get
		End Property
		
		Public Shared ReadOnly Property Activo As SqlParameter
			Get
				Return New SqlParameter("@Activo", SqlDbType.Char, 1)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdUserR As SqlParameter
			Get
				Return New SqlParameter("@IdUserR", SqlDbType.Char, 6)
			End Get
		End Property
		
		Public Shared ReadOnly Property FechaR As SqlParameter
			Get
				Return New SqlParameter("@FechaR", SqlDbType.DateTime, 0)
			End Get
		End Property
		
	End Class
	#End Region	

	#Region "ColumnNames"
	Public class ColumnNames
		
        Public Const IdAnexo As String = "IdAnexo"
        Public Const IdDocInterno As String = "IdDocInterno"
        Public Const NombreAnexo As String = "NombreAnexo"
        Public Const RutaAnexo As String = "RutaAnexo"
        Public Const Activo As String = "Activo"
        Public Const IdUserR As String = "IdUserR"
        Public Const FechaR As String = "FechaR"

		Shared Public Function ToPropertyName(ByVal columnName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(IdAnexo) = _Anexos.PropertyNames.IdAnexo
				ht(IdDocInterno) = _Anexos.PropertyNames.IdDocInterno
				ht(NombreAnexo) = _Anexos.PropertyNames.NombreAnexo
				ht(RutaAnexo) = _Anexos.PropertyNames.RutaAnexo
				ht(Activo) = _Anexos.PropertyNames.Activo
				ht(IdUserR) = _Anexos.PropertyNames.IdUserR
				ht(FechaR) = _Anexos.PropertyNames.FechaR

			End If
			
			Return CType(ht(columnName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing		 
	End Class
	#End Region	
	
	#Region "PropertyNames"
	Public class PropertyNames
		
        Public Const IdAnexo As String = "IdAnexo"
        Public Const IdDocInterno As String = "IdDocInterno"
        Public Const NombreAnexo As String = "NombreAnexo"
        Public Const RutaAnexo As String = "RutaAnexo"
        Public Const Activo As String = "Activo"
        Public Const IdUserR As String = "IdUserR"
        Public Const FechaR As String = "FechaR"

		Shared Public Function ToColumnName(ByVal propertyName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(IdAnexo) = _Anexos.ColumnNames.IdAnexo
				ht(IdDocInterno) = _Anexos.ColumnNames.IdDocInterno
				ht(NombreAnexo) = _Anexos.ColumnNames.NombreAnexo
				ht(RutaAnexo) = _Anexos.ColumnNames.RutaAnexo
				ht(Activo) = _Anexos.ColumnNames.Activo
				ht(IdUserR) = _Anexos.ColumnNames.IdUserR
				ht(FechaR) = _Anexos.ColumnNames.FechaR

			End If
			
			Return CType(ht(propertyName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing
		
	End Class
	#End Region	
	
	#Region "StringPropertyNames"
	Public class StringPropertyNames
		
        Public Const IdAnexo As String = "s_IdAnexo"
        Public Const IdDocInterno As String = "s_IdDocInterno"
        Public Const NombreAnexo As String = "s_NombreAnexo"
        Public Const RutaAnexo As String = "s_RutaAnexo"
        Public Const Activo As String = "s_Activo"
        Public Const IdUserR As String = "s_IdUserR"
        Public Const FechaR As String = "s_FechaR"

	End Class
	#End Region		
	
	#Region "Properties" 
		Public Overridable Property IdAnexo As Integer
			Get
				Return MyBase.GetInteger(ColumnNames.IdAnexo)
			End Get
			Set(ByVal Value As Integer)
				MyBase.SetInteger(ColumnNames.IdAnexo, Value)
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

		Public Overridable Property NombreAnexo As String
			Get
				Return MyBase.GetString(ColumnNames.NombreAnexo)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.NombreAnexo, Value)
			End Set
		End Property

		Public Overridable Property RutaAnexo As String
			Get
				Return MyBase.GetString(ColumnNames.RutaAnexo)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.RutaAnexo, Value)
			End Set
		End Property

		Public Overridable Property Activo As String
			Get
				Return MyBase.GetString(ColumnNames.Activo)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.Activo, Value)
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

		Public Overridable Property FechaR As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.FechaR)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.FechaR, Value)
			End Set
		End Property


	#End Region  
	
	#Region "String Properties" 

		Public Overridable Property s_IdAnexo As String
			Get
				If Me.IsColumnNull(ColumnNames.IdAnexo) Then
					Return String.Empty
				Else
					Return MyBase.GetIntegerAsString(ColumnNames.IdAnexo)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdAnexo)
				Else
					Me.IdAnexo = MyBase.SetIntegerAsString(ColumnNames.IdAnexo, Value)
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

		Public Overridable Property s_NombreAnexo As String
			Get
				If Me.IsColumnNull(ColumnNames.NombreAnexo) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.NombreAnexo)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.NombreAnexo)
				Else
					Me.NombreAnexo = MyBase.SetStringAsString(ColumnNames.NombreAnexo, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_RutaAnexo As String
			Get
				If Me.IsColumnNull(ColumnNames.RutaAnexo) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.RutaAnexo)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.RutaAnexo)
				Else
					Me.RutaAnexo = MyBase.SetStringAsString(ColumnNames.RutaAnexo, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Activo As String
			Get
				If Me.IsColumnNull(ColumnNames.Activo) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.Activo)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Activo)
				Else
					Me.Activo = MyBase.SetStringAsString(ColumnNames.Activo, Value)
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
		
	
			Public ReadOnly Property IdAnexo() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdAnexo, Parameters.IdAnexo)
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

			Public ReadOnly Property NombreAnexo() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.NombreAnexo, Parameters.NombreAnexo)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property RutaAnexo() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.RutaAnexo, Parameters.RutaAnexo)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Activo() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Activo, Parameters.Activo)
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

			Public ReadOnly Property FechaR() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.FechaR, Parameters.FechaR)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property


			Private _clause as WhereClause
		End Class
		#End Region	

		Public ReadOnly Property IdAnexo() As WhereParameter 
			Get
				If _IdAnexo_W Is Nothing Then
					_IdAnexo_W = TearOff.IdAnexo
				End If
				Return _IdAnexo_W
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

		Public ReadOnly Property NombreAnexo() As WhereParameter 
			Get
				If _NombreAnexo_W Is Nothing Then
					_NombreAnexo_W = TearOff.NombreAnexo
				End If
				Return _NombreAnexo_W
			End Get
		End Property

		Public ReadOnly Property RutaAnexo() As WhereParameter 
			Get
				If _RutaAnexo_W Is Nothing Then
					_RutaAnexo_W = TearOff.RutaAnexo
				End If
				Return _RutaAnexo_W
			End Get
		End Property

		Public ReadOnly Property Activo() As WhereParameter 
			Get
				If _Activo_W Is Nothing Then
					_Activo_W = TearOff.Activo
				End If
				Return _Activo_W
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

		Public ReadOnly Property FechaR() As WhereParameter 
			Get
				If _FechaR_W Is Nothing Then
					_FechaR_W = TearOff.FechaR
				End If
				Return _FechaR_W
			End Get
		End Property

		Private _IdAnexo_W As WhereParameter = Nothing
		Private _IdDocInterno_W As WhereParameter = Nothing
		Private _NombreAnexo_W As WhereParameter = Nothing
		Private _RutaAnexo_W As WhereParameter = Nothing
		Private _Activo_W As WhereParameter = Nothing
		Private _IdUserR_W As WhereParameter = Nothing
		Private _FechaR_W As WhereParameter = Nothing

			Public Sub WhereClauseReset()

			_IdAnexo_W = Nothing
			_IdDocInterno_W = Nothing
			_NombreAnexo_W = Nothing
			_RutaAnexo_W = Nothing
			_Activo_W = Nothing
			_IdUserR_W = Nothing
			_FechaR_W = Nothing
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
		
	
		Public ReadOnly Property IdAnexo() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdAnexo, Parameters.IdAnexo)
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

		Public ReadOnly Property NombreAnexo() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.NombreAnexo, Parameters.NombreAnexo)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property RutaAnexo() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.RutaAnexo, Parameters.RutaAnexo)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Activo() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Activo, Parameters.Activo)
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

		Public ReadOnly Property FechaR() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FechaR, Parameters.FechaR)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property


			Private _clause as AggregateClause
		End Class
		#End Region	

		Public ReadOnly Property IdAnexo() As AggregateParameter 
			Get
				If _IdAnexo_W Is Nothing Then
					_IdAnexo_W = TearOff.IdAnexo
				End If
				Return _IdAnexo_W
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

		Public ReadOnly Property NombreAnexo() As AggregateParameter 
			Get
				If _NombreAnexo_W Is Nothing Then
					_NombreAnexo_W = TearOff.NombreAnexo
				End If
				Return _NombreAnexo_W
			End Get
		End Property

		Public ReadOnly Property RutaAnexo() As AggregateParameter 
			Get
				If _RutaAnexo_W Is Nothing Then
					_RutaAnexo_W = TearOff.RutaAnexo
				End If
				Return _RutaAnexo_W
			End Get
		End Property

		Public ReadOnly Property Activo() As AggregateParameter 
			Get
				If _Activo_W Is Nothing Then
					_Activo_W = TearOff.Activo
				End If
				Return _Activo_W
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

		Public ReadOnly Property FechaR() As AggregateParameter 
			Get
				If _FechaR_W Is Nothing Then
					_FechaR_W = TearOff.FechaR
				End If
				Return _FechaR_W
			End Get
		End Property

		Private _IdAnexo_W As AggregateParameter = Nothing
		Private _IdDocInterno_W As AggregateParameter = Nothing
		Private _NombreAnexo_W As AggregateParameter = Nothing
		Private _RutaAnexo_W As AggregateParameter = Nothing
		Private _Activo_W As AggregateParameter = Nothing
		Private _IdUserR_W As AggregateParameter = Nothing
		Private _FechaR_W As AggregateParameter = Nothing

		Public Sub AggregateClauseReset()

		_IdAnexo_W = Nothing
		_IdDocInterno_W = Nothing
		_NombreAnexo_W = Nothing
		_RutaAnexo_W = Nothing
		_Activo_W = Nothing
		_IdUserR_W = Nothing
		_FechaR_W = Nothing
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
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_AnexosInsert]" 
	    
		CreateParameters(cmd)
		
		Dim p As SqlParameter
		p = cmd.Parameters(Parameters.IdAnexo.ParameterName)
		p.Direction = ParameterDirection.Output
    
		Return cmd 

  	End Function
	
	Protected Overrides Function GetUpdateCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_AnexosUpdate]" 
		
		CreateParameters(cmd) 
		    
		Return cmd
	
	End Function	
	
	Protected Overrides Function GetDeleteCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_AnexosDelete]" 
		
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.IdAnexo)
		p.SourceColumn = ColumnNames.IdAnexo
		p.SourceVersion = DataRowVersion.Current

  
		Return cmd
	
	End Function	
	
	Private Sub CreateParameters(ByVal cmd As SqlCommand)
	
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.IdAnexo)
		p.SourceColumn = ColumnNames.IdAnexo
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdDocInterno)
		p.SourceColumn = ColumnNames.IdDocInterno
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.NombreAnexo)
		p.SourceColumn = ColumnNames.NombreAnexo
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.RutaAnexo)
		p.SourceColumn = ColumnNames.RutaAnexo
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Activo)
		p.SourceColumn = ColumnNames.Activo
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdUserR)
		p.SourceColumn = ColumnNames.IdUserR
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.FechaR)
		p.SourceColumn = ColumnNames.FechaR
		p.SourceVersion = DataRowVersion.Current


	End Sub	

End Class
