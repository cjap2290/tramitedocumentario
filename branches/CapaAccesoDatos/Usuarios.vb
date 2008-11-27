
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

Public MustInherit Class _Usuarios
	Inherits SqlClientEntity
    Public E_sIdCargo As String
		Public Sub New() 
			Me.QuerySource = "Usuarios"
        Me.MappingName = "Usuarios"
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
		
		
    	Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_UsuariosLoadAll]", parameters)
		
	End Function

	'=================================================================
	' Public Overridable Function LoadByPrimaryKey()  As Boolean
	'=================================================================
	'  Loads a single row of via the primary key
	'=================================================================
	Public Overridable Function LoadByPrimaryKey(ByVal IdUser As String) As Boolean

		Dim parameters As ListDictionary = New ListDictionary()
		parameters.Add(_Usuarios.Parameters.IdUser, IdUser)

		
		Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_UsuariosLoadByPrimaryKey]", parameters)

	End Function

	#Region "Parameters"
	Protected class Parameters 
		
		Public Shared ReadOnly Property IdUser As SqlParameter
			Get
				Return New SqlParameter("@IdUser", SqlDbType.Char, 6)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdPersona As SqlParameter
			Get
				Return New SqlParameter("@IdPersona", SqlDbType.Char, 7)
			End Get
		End Property
		
		Public Shared ReadOnly Property NivelAdm As SqlParameter
			Get
				Return New SqlParameter("@NivelAdm", SqlDbType.Char, 1)
			End Get
		End Property
		
		Public Shared ReadOnly Property FecProR As SqlParameter
			Get
				Return New SqlParameter("@FecProR", SqlDbType.DateTime, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property Clave As SqlParameter
			Get
				Return New SqlParameter("@Clave", SqlDbType.VarChar, 142)
			End Get
		End Property
		
		Public Shared ReadOnly Property FechaIni As SqlParameter
			Get
				Return New SqlParameter("@FechaIni", SqlDbType.DateTime, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property FechaFin As SqlParameter
			Get
				Return New SqlParameter("@FechaFin", SqlDbType.DateTime, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property HoraR As SqlParameter
			Get
				Return New SqlParameter("@HoraR", SqlDbType.Char, 8)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdUserR As SqlParameter
			Get
				Return New SqlParameter("@IdUserR", SqlDbType.VarChar, 6)
			End Get
		End Property
		
		Public Shared ReadOnly Property Activo As SqlParameter
			Get
				Return New SqlParameter("@Activo", SqlDbType.Char, 1)
			End Get
		End Property
		
		Public Shared ReadOnly Property Bloqueo As SqlParameter
			Get
				Return New SqlParameter("@Bloqueo", SqlDbType.Char, 1)
			End Get
		End Property
		
	End Class
	#End Region	

	#Region "ColumnNames"
	Public class ColumnNames
		
        Public Const IdUser As String = "IdUser"
        Public Const IdPersona As String = "IdPersona"
        Public Const NivelAdm As String = "NivelAdm"
        Public Const FecProR As String = "FecProR"
        Public Const Clave As String = "Clave"
        Public Const FechaIni As String = "FechaIni"
        Public Const FechaFin As String = "FechaFin"
        Public Const HoraR As String = "HoraR"
        Public Const IdUserR As String = "IdUserR"
        Public Const Activo As String = "Activo"
        Public Const Bloqueo As String = "Bloqueo"

		Shared Public Function ToPropertyName(ByVal columnName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(IdUser) = _Usuarios.PropertyNames.IdUser
				ht(IdPersona) = _Usuarios.PropertyNames.IdPersona
				ht(NivelAdm) = _Usuarios.PropertyNames.NivelAdm
				ht(FecProR) = _Usuarios.PropertyNames.FecProR
				ht(Clave) = _Usuarios.PropertyNames.Clave
				ht(FechaIni) = _Usuarios.PropertyNames.FechaIni
				ht(FechaFin) = _Usuarios.PropertyNames.FechaFin
				ht(HoraR) = _Usuarios.PropertyNames.HoraR
				ht(IdUserR) = _Usuarios.PropertyNames.IdUserR
				ht(Activo) = _Usuarios.PropertyNames.Activo
				ht(Bloqueo) = _Usuarios.PropertyNames.Bloqueo

			End If
			
			Return CType(ht(columnName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing		 
	End Class
	#End Region	
	
	#Region "PropertyNames"
	Public class PropertyNames
		
        Public Const IdUser As String = "IdUser"
        Public Const IdPersona As String = "IdPersona"
        Public Const NivelAdm As String = "NivelAdm"
        Public Const FecProR As String = "FecProR"
        Public Const Clave As String = "Clave"
        Public Const FechaIni As String = "FechaIni"
        Public Const FechaFin As String = "FechaFin"
        Public Const HoraR As String = "HoraR"
        Public Const IdUserR As String = "IdUserR"
        Public Const Activo As String = "Activo"
        Public Const Bloqueo As String = "Bloqueo"

		Shared Public Function ToColumnName(ByVal propertyName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(IdUser) = _Usuarios.ColumnNames.IdUser
				ht(IdPersona) = _Usuarios.ColumnNames.IdPersona
				ht(NivelAdm) = _Usuarios.ColumnNames.NivelAdm
				ht(FecProR) = _Usuarios.ColumnNames.FecProR
				ht(Clave) = _Usuarios.ColumnNames.Clave
				ht(FechaIni) = _Usuarios.ColumnNames.FechaIni
				ht(FechaFin) = _Usuarios.ColumnNames.FechaFin
				ht(HoraR) = _Usuarios.ColumnNames.HoraR
				ht(IdUserR) = _Usuarios.ColumnNames.IdUserR
				ht(Activo) = _Usuarios.ColumnNames.Activo
				ht(Bloqueo) = _Usuarios.ColumnNames.Bloqueo

			End If
			
			Return CType(ht(propertyName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing
		
	End Class
	#End Region	
	
	#Region "StringPropertyNames"
	Public class StringPropertyNames
		
        Public Const IdUser As String = "s_IdUser"
        Public Const IdPersona As String = "s_IdPersona"
        Public Const NivelAdm As String = "s_NivelAdm"
        Public Const FecProR As String = "s_FecProR"
        Public Const Clave As String = "s_Clave"
        Public Const FechaIni As String = "s_FechaIni"
        Public Const FechaFin As String = "s_FechaFin"
        Public Const HoraR As String = "s_HoraR"
        Public Const IdUserR As String = "s_IdUserR"
        Public Const Activo As String = "s_Activo"
        Public Const Bloqueo As String = "s_Bloqueo"

	End Class
	#End Region		
	
	#Region "Properties" 
		Public Overridable Property IdUser As String
			Get
				Return MyBase.GetString(ColumnNames.IdUser)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.IdUser, Value)
			End Set
		End Property

		Public Overridable Property IdPersona As String
			Get
				Return MyBase.GetString(ColumnNames.IdPersona)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.IdPersona, Value)
			End Set
		End Property

		Public Overridable Property NivelAdm As String
			Get
				Return MyBase.GetString(ColumnNames.NivelAdm)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.NivelAdm, Value)
			End Set
		End Property

		Public Overridable Property FecProR As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.FecProR)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.FecProR, Value)
			End Set
		End Property

		Public Overridable Property Clave As String
			Get
				Return MyBase.GetString(ColumnNames.Clave)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.Clave, Value)
			End Set
		End Property

		Public Overridable Property FechaIni As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.FechaIni)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.FechaIni, Value)
			End Set
		End Property

		Public Overridable Property FechaFin As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.FechaFin)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.FechaFin, Value)
			End Set
		End Property

		Public Overridable Property HoraR As String
			Get
				Return MyBase.GetString(ColumnNames.HoraR)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.HoraR, Value)
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

		Public Overridable Property Activo As String
			Get
				Return MyBase.GetString(ColumnNames.Activo)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.Activo, Value)
			End Set
		End Property

		Public Overridable Property Bloqueo As String
			Get
				Return MyBase.GetString(ColumnNames.Bloqueo)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.Bloqueo, Value)
			End Set
		End Property


	#End Region  
	
	#Region "String Properties" 

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

		Public Overridable Property s_IdPersona As String
			Get
				If Me.IsColumnNull(ColumnNames.IdPersona) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.IdPersona)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdPersona)
				Else
					Me.IdPersona = MyBase.SetStringAsString(ColumnNames.IdPersona, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_NivelAdm As String
			Get
				If Me.IsColumnNull(ColumnNames.NivelAdm) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.NivelAdm)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.NivelAdm)
				Else
					Me.NivelAdm = MyBase.SetStringAsString(ColumnNames.NivelAdm, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_FecProR As String
			Get
				If Me.IsColumnNull(ColumnNames.FecProR) Then
					Return String.Empty
				Else
					Return MyBase.GetDateTimeAsString(ColumnNames.FecProR)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FecProR)
				Else
					Me.FecProR = MyBase.SetDateTimeAsString(ColumnNames.FecProR, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Clave As String
			Get
				If Me.IsColumnNull(ColumnNames.Clave) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.Clave)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Clave)
				Else
					Me.Clave = MyBase.SetStringAsString(ColumnNames.Clave, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_FechaIni As String
			Get
				If Me.IsColumnNull(ColumnNames.FechaIni) Then
					Return String.Empty
				Else
					Return MyBase.GetDateTimeAsString(ColumnNames.FechaIni)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FechaIni)
				Else
					Me.FechaIni = MyBase.SetDateTimeAsString(ColumnNames.FechaIni, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_FechaFin As String
			Get
				If Me.IsColumnNull(ColumnNames.FechaFin) Then
					Return String.Empty
				Else
					Return MyBase.GetDateTimeAsString(ColumnNames.FechaFin)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FechaFin)
				Else
					Me.FechaFin = MyBase.SetDateTimeAsString(ColumnNames.FechaFin, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_HoraR As String
			Get
				If Me.IsColumnNull(ColumnNames.HoraR) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.HoraR)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.HoraR)
				Else
					Me.HoraR = MyBase.SetStringAsString(ColumnNames.HoraR, Value)
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

		Public Overridable Property s_Bloqueo As String
			Get
				If Me.IsColumnNull(ColumnNames.Bloqueo) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.Bloqueo)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Bloqueo)
				Else
					Me.Bloqueo = MyBase.SetStringAsString(ColumnNames.Bloqueo, Value)
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
		
	
			Public ReadOnly Property IdUser() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdUser, Parameters.IdUser)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdPersona() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdPersona, Parameters.IdPersona)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property NivelAdm() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.NivelAdm, Parameters.NivelAdm)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property FecProR() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.FecProR, Parameters.FecProR)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Clave() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Clave, Parameters.Clave)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property FechaIni() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.FechaIni, Parameters.FechaIni)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property FechaFin() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.FechaFin, Parameters.FechaFin)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property HoraR() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.HoraR, Parameters.HoraR)
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

			Public ReadOnly Property Activo() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Activo, Parameters.Activo)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Bloqueo() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Bloqueo, Parameters.Bloqueo)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property


			Private _clause as WhereClause
		End Class
		#End Region	

		Public ReadOnly Property IdUser() As WhereParameter 
			Get
				If _IdUser_W Is Nothing Then
					_IdUser_W = TearOff.IdUser
				End If
				Return _IdUser_W
			End Get
		End Property

		Public ReadOnly Property IdPersona() As WhereParameter 
			Get
				If _IdPersona_W Is Nothing Then
					_IdPersona_W = TearOff.IdPersona
				End If
				Return _IdPersona_W
			End Get
		End Property

		Public ReadOnly Property NivelAdm() As WhereParameter 
			Get
				If _NivelAdm_W Is Nothing Then
					_NivelAdm_W = TearOff.NivelAdm
				End If
				Return _NivelAdm_W
			End Get
		End Property

		Public ReadOnly Property FecProR() As WhereParameter 
			Get
				If _FecProR_W Is Nothing Then
					_FecProR_W = TearOff.FecProR
				End If
				Return _FecProR_W
			End Get
		End Property

		Public ReadOnly Property Clave() As WhereParameter 
			Get
				If _Clave_W Is Nothing Then
					_Clave_W = TearOff.Clave
				End If
				Return _Clave_W
			End Get
		End Property

		Public ReadOnly Property FechaIni() As WhereParameter 
			Get
				If _FechaIni_W Is Nothing Then
					_FechaIni_W = TearOff.FechaIni
				End If
				Return _FechaIni_W
			End Get
		End Property

		Public ReadOnly Property FechaFin() As WhereParameter 
			Get
				If _FechaFin_W Is Nothing Then
					_FechaFin_W = TearOff.FechaFin
				End If
				Return _FechaFin_W
			End Get
		End Property

		Public ReadOnly Property HoraR() As WhereParameter 
			Get
				If _HoraR_W Is Nothing Then
					_HoraR_W = TearOff.HoraR
				End If
				Return _HoraR_W
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

		Public ReadOnly Property Activo() As WhereParameter 
			Get
				If _Activo_W Is Nothing Then
					_Activo_W = TearOff.Activo
				End If
				Return _Activo_W
			End Get
		End Property

		Public ReadOnly Property Bloqueo() As WhereParameter 
			Get
				If _Bloqueo_W Is Nothing Then
					_Bloqueo_W = TearOff.Bloqueo
				End If
				Return _Bloqueo_W
			End Get
		End Property

		Private _IdUser_W As WhereParameter = Nothing
		Private _IdPersona_W As WhereParameter = Nothing
		Private _NivelAdm_W As WhereParameter = Nothing
		Private _FecProR_W As WhereParameter = Nothing
		Private _Clave_W As WhereParameter = Nothing
		Private _FechaIni_W As WhereParameter = Nothing
		Private _FechaFin_W As WhereParameter = Nothing
		Private _HoraR_W As WhereParameter = Nothing
		Private _IdUserR_W As WhereParameter = Nothing
		Private _Activo_W As WhereParameter = Nothing
		Private _Bloqueo_W As WhereParameter = Nothing

			Public Sub WhereClauseReset()

			_IdUser_W = Nothing
			_IdPersona_W = Nothing
			_NivelAdm_W = Nothing
			_FecProR_W = Nothing
			_Clave_W = Nothing
			_FechaIni_W = Nothing
			_FechaFin_W = Nothing
			_HoraR_W = Nothing
			_IdUserR_W = Nothing
			_Activo_W = Nothing
			_Bloqueo_W = Nothing
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
		
	
		Public ReadOnly Property IdUser() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdUser, Parameters.IdUser)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdPersona() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdPersona, Parameters.IdPersona)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property NivelAdm() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.NivelAdm, Parameters.NivelAdm)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property FecProR() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FecProR, Parameters.FecProR)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Clave() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Clave, Parameters.Clave)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property FechaIni() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FechaIni, Parameters.FechaIni)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property FechaFin() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FechaFin, Parameters.FechaFin)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property HoraR() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.HoraR, Parameters.HoraR)
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

		Public ReadOnly Property Activo() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Activo, Parameters.Activo)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Bloqueo() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Bloqueo, Parameters.Bloqueo)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property


			Private _clause as AggregateClause
		End Class
		#End Region	

		Public ReadOnly Property IdUser() As AggregateParameter 
			Get
				If _IdUser_W Is Nothing Then
					_IdUser_W = TearOff.IdUser
				End If
				Return _IdUser_W
			End Get
		End Property

		Public ReadOnly Property IdPersona() As AggregateParameter 
			Get
				If _IdPersona_W Is Nothing Then
					_IdPersona_W = TearOff.IdPersona
				End If
				Return _IdPersona_W
			End Get
		End Property

		Public ReadOnly Property NivelAdm() As AggregateParameter 
			Get
				If _NivelAdm_W Is Nothing Then
					_NivelAdm_W = TearOff.NivelAdm
				End If
				Return _NivelAdm_W
			End Get
		End Property

		Public ReadOnly Property FecProR() As AggregateParameter 
			Get
				If _FecProR_W Is Nothing Then
					_FecProR_W = TearOff.FecProR
				End If
				Return _FecProR_W
			End Get
		End Property

		Public ReadOnly Property Clave() As AggregateParameter 
			Get
				If _Clave_W Is Nothing Then
					_Clave_W = TearOff.Clave
				End If
				Return _Clave_W
			End Get
		End Property

		Public ReadOnly Property FechaIni() As AggregateParameter 
			Get
				If _FechaIni_W Is Nothing Then
					_FechaIni_W = TearOff.FechaIni
				End If
				Return _FechaIni_W
			End Get
		End Property

		Public ReadOnly Property FechaFin() As AggregateParameter 
			Get
				If _FechaFin_W Is Nothing Then
					_FechaFin_W = TearOff.FechaFin
				End If
				Return _FechaFin_W
			End Get
		End Property

		Public ReadOnly Property HoraR() As AggregateParameter 
			Get
				If _HoraR_W Is Nothing Then
					_HoraR_W = TearOff.HoraR
				End If
				Return _HoraR_W
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

		Public ReadOnly Property Activo() As AggregateParameter 
			Get
				If _Activo_W Is Nothing Then
					_Activo_W = TearOff.Activo
				End If
				Return _Activo_W
			End Get
		End Property

		Public ReadOnly Property Bloqueo() As AggregateParameter 
			Get
				If _Bloqueo_W Is Nothing Then
					_Bloqueo_W = TearOff.Bloqueo
				End If
				Return _Bloqueo_W
			End Get
		End Property

		Private _IdUser_W As AggregateParameter = Nothing
		Private _IdPersona_W As AggregateParameter = Nothing
		Private _NivelAdm_W As AggregateParameter = Nothing
		Private _FecProR_W As AggregateParameter = Nothing
		Private _Clave_W As AggregateParameter = Nothing
		Private _FechaIni_W As AggregateParameter = Nothing
		Private _FechaFin_W As AggregateParameter = Nothing
		Private _HoraR_W As AggregateParameter = Nothing
		Private _IdUserR_W As AggregateParameter = Nothing
		Private _Activo_W As AggregateParameter = Nothing
		Private _Bloqueo_W As AggregateParameter = Nothing

		Public Sub AggregateClauseReset()

		_IdUser_W = Nothing
		_IdPersona_W = Nothing
		_NivelAdm_W = Nothing
		_FecProR_W = Nothing
		_Clave_W = Nothing
		_FechaIni_W = Nothing
		_FechaFin_W = Nothing
		_HoraR_W = Nothing
		_IdUserR_W = Nothing
		_Activo_W = Nothing
		_Bloqueo_W = Nothing
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
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_UsuariosInsert]" 
	    
		CreateParameters(cmd)
		    
		Return cmd 

  	End Function
	
	Protected Overrides Function GetUpdateCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_UsuariosUpdate]" 
		
		CreateParameters(cmd) 
		    
		Return cmd
	
	End Function	
	
	Protected Overrides Function GetDeleteCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_UsuariosDelete]" 
		
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.IdUser)
		p.SourceColumn = ColumnNames.IdUser
		p.SourceVersion = DataRowVersion.Current

  
		Return cmd
	
	End Function	
	
	Private Sub CreateParameters(ByVal cmd As SqlCommand)
	
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.IdUser)
		p.SourceColumn = ColumnNames.IdUser
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdPersona)
		p.SourceColumn = ColumnNames.IdPersona
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.NivelAdm)
		p.SourceColumn = ColumnNames.NivelAdm
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.FecProR)
		p.SourceColumn = ColumnNames.FecProR
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Clave)
		p.SourceColumn = ColumnNames.Clave
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.FechaIni)
		p.SourceColumn = ColumnNames.FechaIni
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.FechaFin)
		p.SourceColumn = ColumnNames.FechaFin
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.HoraR)
		p.SourceColumn = ColumnNames.HoraR
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdUserR)
		p.SourceColumn = ColumnNames.IdUserR
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Activo)
		p.SourceColumn = ColumnNames.Activo
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Bloqueo)
		p.SourceColumn = ColumnNames.Bloqueo
		p.SourceVersion = DataRowVersion.Current


	End Sub	
    Public Function cuentafilas()
        Return Me.RowCount
    End Function
    Public Function retornaUser() As DataTable
        Dim Parms As ListDictionary = New ListDictionary
        Me.Where.IdUser.Value = "A%"
        Me.Where.IdUser.Operator = WhereParameter.Operand.Like_
        'Me.Where.FecProR.BetweenBeginValue = "'01/01/2002'"
        'Me.Where.FecProR.BetweenEndValue = "'12/31/2006'"
        'Me.Where.FecProR.Operator = WhereParameter.Operand.Between
        'me.LoadFromSql("select * from usuarios where iduser like '%A%'",
        'Dim query = Me.Query.GenerateSQL
        Parms.Add("param", "A%")
        Parms.Add("campo", "[IdUser]")
        Parms.Add("tabla", "[Usuarios]")
        If (Me.LoadFromSql("paBuscador", Parms)) Then

        End If
        Return Me.DataTable

    End Function
    Public Function E_obtIdCargo(ByVal sIdPersona As String) As Boolean
        Me.Where.IdPersona.Value = sIdPersona
        Me.Where.IdPersona.Operator = WhereParameter.Operand.Equal
        If Not (Me.Query.Load) Then
            Return False
        Else
            'E_sIdCargo = Me.DataTable.Rows(0).Item(0).ToString
            'E_sIdCargo = Me.DataTable.Rows(0).Item(1).ToString
            'E_sIdCargo = Me.DataTable.Rows(0).Item(2).ToString
            'E_sIdCargo = Me.DataTable.Rows(0).Item(3).ToString
            'E_sIdCargo = Me.DataTable.Rows(0).Item(4).ToString
            Return True
        End If
    End Function
    Public Function E_actActivo(ByVal sIdUser As String) As Boolean
        If LoadByPrimaryKey(sIdUser) Then
            Activo = "1"
            Save()
            Return True
        Else
            Return False
        End If
    End Function
End Class

