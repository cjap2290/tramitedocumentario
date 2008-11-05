
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

Public MustInherit Class _Personal
    Inherits SqlClientEntity
    Dim sIdCargo As String
    Dim sIdArea As String

		Public Sub New() 
			Me.QuerySource = "Personal"
			Me.MappingName = "Personal"
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
		
		
    	Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_PersonalLoadAll]", parameters)
		
	End Function

	'=================================================================
	' Public Overridable Function LoadByPrimaryKey()  As Boolean
	'=================================================================
	'  Loads a single row of via the primary key
	'=================================================================
	Public Overridable Function LoadByPrimaryKey(ByVal IdPersona As String) As Boolean

		Dim parameters As ListDictionary = New ListDictionary()
		parameters.Add(_Personal.Parameters.IdPersona, IdPersona)

		
		Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_PersonalLoadByPrimaryKey]", parameters)

	End Function

	#Region "Parameters"
	Protected class Parameters 
		
		Public Shared ReadOnly Property IdPersona As SqlParameter
			Get
				Return New SqlParameter("@IdPersona", SqlDbType.Char, 7)
			End Get
		End Property
		
		Public Shared ReadOnly Property FechaIng As SqlParameter
			Get
				Return New SqlParameter("@FechaIng", SqlDbType.DateTime, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdCargo As SqlParameter
			Get
				Return New SqlParameter("@IdCargo", SqlDbType.Char, 2)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdArea As SqlParameter
			Get
				Return New SqlParameter("@IdArea", SqlDbType.Char, 2)
			End Get
		End Property
		
		Public Shared ReadOnly Property FechaSal As SqlParameter
			Get
				Return New SqlParameter("@FechaSal", SqlDbType.DateTime, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property IngMensual As SqlParameter
			Get
				Return New SqlParameter("@IngMensual", SqlDbType.Money, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property Idagencia As SqlParameter
			Get
				Return New SqlParameter("@Idagencia", SqlDbType.Char, 2)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdEstPers As SqlParameter
			Get
				Return New SqlParameter("@IdEstPers", SqlDbType.Char, 4)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdUser As SqlParameter
			Get
				Return New SqlParameter("@IdUser", SqlDbType.Char, 6)
			End Get
		End Property
		
		Public Shared ReadOnly Property FecPro As SqlParameter
			Get
				Return New SqlParameter("@FecPro", SqlDbType.DateTime, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property Hora As SqlParameter
			Get
				Return New SqlParameter("@Hora", SqlDbType.Char, 8)
			End Get
		End Property
		
		Public Shared ReadOnly Property IdEstPer As SqlParameter
			Get
				Return New SqlParameter("@IdEstPer", SqlDbType.Char, 2)
			End Get
		End Property
		
		Public Shared ReadOnly Property FormaMarcado As SqlParameter
			Get
				Return New SqlParameter("@FormaMarcado", SqlDbType.Char, 4)
			End Get
		End Property
		
	End Class
	#End Region	

	#Region "ColumnNames"
	Public class ColumnNames
		
        Public Const IdPersona As String = "IdPersona"
        Public Const FechaIng As String = "FechaIng"
        Public Const IdCargo As String = "IdCargo"
        Public Const IdArea As String = "IdArea"
        Public Const FechaSal As String = "FechaSal"
        Public Const IngMensual As String = "IngMensual"
        Public Const Idagencia As String = "Idagencia"
        Public Const IdEstPers As String = "IdEstPers"
        Public Const IdUser As String = "IdUser"
        Public Const FecPro As String = "FecPro"
        Public Const Hora As String = "Hora"
        Public Const IdEstPer As String = "IdEstPer"
        Public Const FormaMarcado As String = "FormaMarcado"

		Shared Public Function ToPropertyName(ByVal columnName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(IdPersona) = _Personal.PropertyNames.IdPersona
				ht(FechaIng) = _Personal.PropertyNames.FechaIng
				ht(IdCargo) = _Personal.PropertyNames.IdCargo
				ht(IdArea) = _Personal.PropertyNames.IdArea
				ht(FechaSal) = _Personal.PropertyNames.FechaSal
				ht(IngMensual) = _Personal.PropertyNames.IngMensual
				ht(Idagencia) = _Personal.PropertyNames.Idagencia
				ht(IdEstPers) = _Personal.PropertyNames.IdEstPers
				ht(IdUser) = _Personal.PropertyNames.IdUser
				ht(FecPro) = _Personal.PropertyNames.FecPro
				ht(Hora) = _Personal.PropertyNames.Hora
				ht(IdEstPer) = _Personal.PropertyNames.IdEstPer
				ht(FormaMarcado) = _Personal.PropertyNames.FormaMarcado

			End If
			
			Return CType(ht(columnName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing		 
	End Class
	#End Region	
	
	#Region "PropertyNames"
	Public class PropertyNames
		
        Public Const IdPersona As String = "IdPersona"
        Public Const FechaIng As String = "FechaIng"
        Public Const IdCargo As String = "IdCargo"
        Public Const IdArea As String = "IdArea"
        Public Const FechaSal As String = "FechaSal"
        Public Const IngMensual As String = "IngMensual"
        Public Const Idagencia As String = "Idagencia"
        Public Const IdEstPers As String = "IdEstPers"
        Public Const IdUser As String = "IdUser"
        Public Const FecPro As String = "FecPro"
        Public Const Hora As String = "Hora"
        Public Const IdEstPer As String = "IdEstPer"
        Public Const FormaMarcado As String = "FormaMarcado"

		Shared Public Function ToColumnName(ByVal propertyName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(IdPersona) = _Personal.ColumnNames.IdPersona
				ht(FechaIng) = _Personal.ColumnNames.FechaIng
				ht(IdCargo) = _Personal.ColumnNames.IdCargo
				ht(IdArea) = _Personal.ColumnNames.IdArea
				ht(FechaSal) = _Personal.ColumnNames.FechaSal
				ht(IngMensual) = _Personal.ColumnNames.IngMensual
				ht(Idagencia) = _Personal.ColumnNames.Idagencia
				ht(IdEstPers) = _Personal.ColumnNames.IdEstPers
				ht(IdUser) = _Personal.ColumnNames.IdUser
				ht(FecPro) = _Personal.ColumnNames.FecPro
				ht(Hora) = _Personal.ColumnNames.Hora
				ht(IdEstPer) = _Personal.ColumnNames.IdEstPer
				ht(FormaMarcado) = _Personal.ColumnNames.FormaMarcado

			End If
			
			Return CType(ht(propertyName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing
		
	End Class
	#End Region	
	
	#Region "StringPropertyNames"
	Public class StringPropertyNames
		
        Public Const IdPersona As String = "s_IdPersona"
        Public Const FechaIng As String = "s_FechaIng"
        Public Const IdCargo As String = "s_IdCargo"
        Public Const IdArea As String = "s_IdArea"
        Public Const FechaSal As String = "s_FechaSal"
        Public Const IngMensual As String = "s_IngMensual"
        Public Const Idagencia As String = "s_Idagencia"
        Public Const IdEstPers As String = "s_IdEstPers"
        Public Const IdUser As String = "s_IdUser"
        Public Const FecPro As String = "s_FecPro"
        Public Const Hora As String = "s_Hora"
        Public Const IdEstPer As String = "s_IdEstPer"
        Public Const FormaMarcado As String = "s_FormaMarcado"

	End Class
	#End Region		
	
	#Region "Properties" 
		Public Overridable Property IdPersona As String
			Get
				Return MyBase.GetString(ColumnNames.IdPersona)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.IdPersona, Value)
			End Set
		End Property

		Public Overridable Property FechaIng As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.FechaIng)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.FechaIng, Value)
			End Set
		End Property

		Public Overridable Property IdCargo As String
			Get
				Return MyBase.GetString(ColumnNames.IdCargo)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.IdCargo, Value)
			End Set
		End Property

		Public Overridable Property IdArea As String
			Get
				Return MyBase.GetString(ColumnNames.IdArea)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.IdArea, Value)
			End Set
		End Property

		Public Overridable Property FechaSal As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.FechaSal)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.FechaSal, Value)
			End Set
		End Property

		Public Overridable Property IngMensual As Decimal
			Get
				Return MyBase.GetDecimal(ColumnNames.IngMensual)
			End Get
			Set(ByVal Value As Decimal)
				MyBase.SetDecimal(ColumnNames.IngMensual, Value)
			End Set
		End Property

		Public Overridable Property Idagencia As String
			Get
				Return MyBase.GetString(ColumnNames.Idagencia)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.Idagencia, Value)
			End Set
		End Property

		Public Overridable Property IdEstPers As String
			Get
				Return MyBase.GetString(ColumnNames.IdEstPers)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.IdEstPers, Value)
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

		Public Overridable Property FecPro As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.FecPro)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.FecPro, Value)
			End Set
		End Property

		Public Overridable Property Hora As String
			Get
				Return MyBase.GetString(ColumnNames.Hora)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.Hora, Value)
			End Set
		End Property

		Public Overridable Property IdEstPer As String
			Get
				Return MyBase.GetString(ColumnNames.IdEstPer)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.IdEstPer, Value)
			End Set
		End Property

		Public Overridable Property FormaMarcado As String
			Get
				Return MyBase.GetString(ColumnNames.FormaMarcado)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.FormaMarcado, Value)
			End Set
		End Property


	#End Region  
	
	#Region "String Properties" 

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

		Public Overridable Property s_FechaIng As String
			Get
				If Me.IsColumnNull(ColumnNames.FechaIng) Then
					Return String.Empty
				Else
					Return MyBase.GetDateTimeAsString(ColumnNames.FechaIng)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FechaIng)
				Else
					Me.FechaIng = MyBase.SetDateTimeAsString(ColumnNames.FechaIng, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IdCargo As String
			Get
				If Me.IsColumnNull(ColumnNames.IdCargo) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.IdCargo)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdCargo)
				Else
					Me.IdCargo = MyBase.SetStringAsString(ColumnNames.IdCargo, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IdArea As String
			Get
				If Me.IsColumnNull(ColumnNames.IdArea) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.IdArea)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdArea)
				Else
					Me.IdArea = MyBase.SetStringAsString(ColumnNames.IdArea, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_FechaSal As String
			Get
				If Me.IsColumnNull(ColumnNames.FechaSal) Then
					Return String.Empty
				Else
					Return MyBase.GetDateTimeAsString(ColumnNames.FechaSal)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FechaSal)
				Else
					Me.FechaSal = MyBase.SetDateTimeAsString(ColumnNames.FechaSal, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IngMensual As String
			Get
				If Me.IsColumnNull(ColumnNames.IngMensual) Then
					Return String.Empty
				Else
					Return MyBase.GetDecimalAsString(ColumnNames.IngMensual)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IngMensual)
				Else
					Me.IngMensual = MyBase.SetDecimalAsString(ColumnNames.IngMensual, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Idagencia As String
			Get
				If Me.IsColumnNull(ColumnNames.Idagencia) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.Idagencia)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Idagencia)
				Else
					Me.Idagencia = MyBase.SetStringAsString(ColumnNames.Idagencia, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IdEstPers As String
			Get
				If Me.IsColumnNull(ColumnNames.IdEstPers) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.IdEstPers)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdEstPers)
				Else
					Me.IdEstPers = MyBase.SetStringAsString(ColumnNames.IdEstPers, Value)
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

		Public Overridable Property s_FecPro As String
			Get
				If Me.IsColumnNull(ColumnNames.FecPro) Then
					Return String.Empty
				Else
					Return MyBase.GetDateTimeAsString(ColumnNames.FecPro)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FecPro)
				Else
					Me.FecPro = MyBase.SetDateTimeAsString(ColumnNames.FecPro, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Hora As String
			Get
				If Me.IsColumnNull(ColumnNames.Hora) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.Hora)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Hora)
				Else
					Me.Hora = MyBase.SetStringAsString(ColumnNames.Hora, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IdEstPer As String
			Get
				If Me.IsColumnNull(ColumnNames.IdEstPer) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.IdEstPer)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IdEstPer)
				Else
					Me.IdEstPer = MyBase.SetStringAsString(ColumnNames.IdEstPer, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_FormaMarcado As String
			Get
				If Me.IsColumnNull(ColumnNames.FormaMarcado) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.FormaMarcado)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FormaMarcado)
				Else
					Me.FormaMarcado = MyBase.SetStringAsString(ColumnNames.FormaMarcado, Value)
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
		
	
			Public ReadOnly Property IdPersona() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdPersona, Parameters.IdPersona)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property FechaIng() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.FechaIng, Parameters.FechaIng)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdCargo() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdCargo, Parameters.IdCargo)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdArea() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdArea, Parameters.IdArea)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property FechaSal() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.FechaSal, Parameters.FechaSal)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IngMensual() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IngMensual, Parameters.IngMensual)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Idagencia() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Idagencia, Parameters.Idagencia)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdEstPers() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdEstPers, Parameters.IdEstPers)
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

			Public ReadOnly Property FecPro() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.FecPro, Parameters.FecPro)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Hora() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Hora, Parameters.Hora)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property IdEstPer() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.IdEstPer, Parameters.IdEstPer)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property FormaMarcado() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.FormaMarcado, Parameters.FormaMarcado)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property


			Private _clause as WhereClause
		End Class
		#End Region	

		Public ReadOnly Property IdPersona() As WhereParameter 
			Get
				If _IdPersona_W Is Nothing Then
					_IdPersona_W = TearOff.IdPersona
				End If
				Return _IdPersona_W
			End Get
		End Property

		Public ReadOnly Property FechaIng() As WhereParameter 
			Get
				If _FechaIng_W Is Nothing Then
					_FechaIng_W = TearOff.FechaIng
				End If
				Return _FechaIng_W
			End Get
		End Property

		Public ReadOnly Property IdCargo() As WhereParameter 
			Get
				If _IdCargo_W Is Nothing Then
					_IdCargo_W = TearOff.IdCargo
				End If
				Return _IdCargo_W
			End Get
		End Property

		Public ReadOnly Property IdArea() As WhereParameter 
			Get
				If _IdArea_W Is Nothing Then
					_IdArea_W = TearOff.IdArea
				End If
				Return _IdArea_W
			End Get
		End Property

		Public ReadOnly Property FechaSal() As WhereParameter 
			Get
				If _FechaSal_W Is Nothing Then
					_FechaSal_W = TearOff.FechaSal
				End If
				Return _FechaSal_W
			End Get
		End Property

		Public ReadOnly Property IngMensual() As WhereParameter 
			Get
				If _IngMensual_W Is Nothing Then
					_IngMensual_W = TearOff.IngMensual
				End If
				Return _IngMensual_W
			End Get
		End Property

		Public ReadOnly Property Idagencia() As WhereParameter 
			Get
				If _Idagencia_W Is Nothing Then
					_Idagencia_W = TearOff.Idagencia
				End If
				Return _Idagencia_W
			End Get
		End Property

		Public ReadOnly Property IdEstPers() As WhereParameter 
			Get
				If _IdEstPers_W Is Nothing Then
					_IdEstPers_W = TearOff.IdEstPers
				End If
				Return _IdEstPers_W
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

		Public ReadOnly Property FecPro() As WhereParameter 
			Get
				If _FecPro_W Is Nothing Then
					_FecPro_W = TearOff.FecPro
				End If
				Return _FecPro_W
			End Get
		End Property

		Public ReadOnly Property Hora() As WhereParameter 
			Get
				If _Hora_W Is Nothing Then
					_Hora_W = TearOff.Hora
				End If
				Return _Hora_W
			End Get
		End Property

		Public ReadOnly Property IdEstPer() As WhereParameter 
			Get
				If _IdEstPer_W Is Nothing Then
					_IdEstPer_W = TearOff.IdEstPer
				End If
				Return _IdEstPer_W
			End Get
		End Property

		Public ReadOnly Property FormaMarcado() As WhereParameter 
			Get
				If _FormaMarcado_W Is Nothing Then
					_FormaMarcado_W = TearOff.FormaMarcado
				End If
				Return _FormaMarcado_W
			End Get
		End Property

		Private _IdPersona_W As WhereParameter = Nothing
		Private _FechaIng_W As WhereParameter = Nothing
		Private _IdCargo_W As WhereParameter = Nothing
		Private _IdArea_W As WhereParameter = Nothing
		Private _FechaSal_W As WhereParameter = Nothing
		Private _IngMensual_W As WhereParameter = Nothing
		Private _Idagencia_W As WhereParameter = Nothing
		Private _IdEstPers_W As WhereParameter = Nothing
		Private _IdUser_W As WhereParameter = Nothing
		Private _FecPro_W As WhereParameter = Nothing
		Private _Hora_W As WhereParameter = Nothing
		Private _IdEstPer_W As WhereParameter = Nothing
		Private _FormaMarcado_W As WhereParameter = Nothing

			Public Sub WhereClauseReset()

			_IdPersona_W = Nothing
			_FechaIng_W = Nothing
			_IdCargo_W = Nothing
			_IdArea_W = Nothing
			_FechaSal_W = Nothing
			_IngMensual_W = Nothing
			_Idagencia_W = Nothing
			_IdEstPers_W = Nothing
			_IdUser_W = Nothing
			_FecPro_W = Nothing
			_Hora_W = Nothing
			_IdEstPer_W = Nothing
			_FormaMarcado_W = Nothing
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
		
	
		Public ReadOnly Property IdPersona() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdPersona, Parameters.IdPersona)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property FechaIng() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FechaIng, Parameters.FechaIng)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdCargo() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdCargo, Parameters.IdCargo)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdArea() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdArea, Parameters.IdArea)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property FechaSal() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FechaSal, Parameters.FechaSal)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IngMensual() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IngMensual, Parameters.IngMensual)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Idagencia() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Idagencia, Parameters.Idagencia)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdEstPers() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdEstPers, Parameters.IdEstPers)
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

		Public ReadOnly Property FecPro() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FecPro, Parameters.FecPro)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Hora() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Hora, Parameters.Hora)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IdEstPer() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IdEstPer, Parameters.IdEstPer)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property FormaMarcado() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FormaMarcado, Parameters.FormaMarcado)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property


			Private _clause as AggregateClause
		End Class
		#End Region	

		Public ReadOnly Property IdPersona() As AggregateParameter 
			Get
				If _IdPersona_W Is Nothing Then
					_IdPersona_W = TearOff.IdPersona
				End If
				Return _IdPersona_W
			End Get
		End Property

		Public ReadOnly Property FechaIng() As AggregateParameter 
			Get
				If _FechaIng_W Is Nothing Then
					_FechaIng_W = TearOff.FechaIng
				End If
				Return _FechaIng_W
			End Get
		End Property

		Public ReadOnly Property IdCargo() As AggregateParameter 
			Get
				If _IdCargo_W Is Nothing Then
					_IdCargo_W = TearOff.IdCargo
				End If
				Return _IdCargo_W
			End Get
		End Property

		Public ReadOnly Property IdArea() As AggregateParameter 
			Get
				If _IdArea_W Is Nothing Then
					_IdArea_W = TearOff.IdArea
				End If
				Return _IdArea_W
			End Get
		End Property

		Public ReadOnly Property FechaSal() As AggregateParameter 
			Get
				If _FechaSal_W Is Nothing Then
					_FechaSal_W = TearOff.FechaSal
				End If
				Return _FechaSal_W
			End Get
		End Property

		Public ReadOnly Property IngMensual() As AggregateParameter 
			Get
				If _IngMensual_W Is Nothing Then
					_IngMensual_W = TearOff.IngMensual
				End If
				Return _IngMensual_W
			End Get
		End Property

		Public ReadOnly Property Idagencia() As AggregateParameter 
			Get
				If _Idagencia_W Is Nothing Then
					_Idagencia_W = TearOff.Idagencia
				End If
				Return _Idagencia_W
			End Get
		End Property

		Public ReadOnly Property IdEstPers() As AggregateParameter 
			Get
				If _IdEstPers_W Is Nothing Then
					_IdEstPers_W = TearOff.IdEstPers
				End If
				Return _IdEstPers_W
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

		Public ReadOnly Property FecPro() As AggregateParameter 
			Get
				If _FecPro_W Is Nothing Then
					_FecPro_W = TearOff.FecPro
				End If
				Return _FecPro_W
			End Get
		End Property

		Public ReadOnly Property Hora() As AggregateParameter 
			Get
				If _Hora_W Is Nothing Then
					_Hora_W = TearOff.Hora
				End If
				Return _Hora_W
			End Get
		End Property

		Public ReadOnly Property IdEstPer() As AggregateParameter 
			Get
				If _IdEstPer_W Is Nothing Then
					_IdEstPer_W = TearOff.IdEstPer
				End If
				Return _IdEstPer_W
			End Get
		End Property

		Public ReadOnly Property FormaMarcado() As AggregateParameter 
			Get
				If _FormaMarcado_W Is Nothing Then
					_FormaMarcado_W = TearOff.FormaMarcado
				End If
				Return _FormaMarcado_W
			End Get
		End Property

		Private _IdPersona_W As AggregateParameter = Nothing
		Private _FechaIng_W As AggregateParameter = Nothing
		Private _IdCargo_W As AggregateParameter = Nothing
		Private _IdArea_W As AggregateParameter = Nothing
		Private _FechaSal_W As AggregateParameter = Nothing
		Private _IngMensual_W As AggregateParameter = Nothing
		Private _Idagencia_W As AggregateParameter = Nothing
		Private _IdEstPers_W As AggregateParameter = Nothing
		Private _IdUser_W As AggregateParameter = Nothing
		Private _FecPro_W As AggregateParameter = Nothing
		Private _Hora_W As AggregateParameter = Nothing
		Private _IdEstPer_W As AggregateParameter = Nothing
		Private _FormaMarcado_W As AggregateParameter = Nothing

		Public Sub AggregateClauseReset()

		_IdPersona_W = Nothing
		_FechaIng_W = Nothing
		_IdCargo_W = Nothing
		_IdArea_W = Nothing
		_FechaSal_W = Nothing
		_IngMensual_W = Nothing
		_Idagencia_W = Nothing
		_IdEstPers_W = Nothing
		_IdUser_W = Nothing
		_FecPro_W = Nothing
		_Hora_W = Nothing
		_IdEstPer_W = Nothing
		_FormaMarcado_W = Nothing
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
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_PersonalInsert]" 
	    
		CreateParameters(cmd)
		    
		Return cmd 

  	End Function
	
	Protected Overrides Function GetUpdateCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_PersonalUpdate]" 
		
		CreateParameters(cmd) 
		    
		Return cmd
	
	End Function	
	
	Protected Overrides Function GetDeleteCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_PersonalDelete]" 
		
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.IdPersona)
		p.SourceColumn = ColumnNames.IdPersona
		p.SourceVersion = DataRowVersion.Current

  
		Return cmd
	
	End Function	
	
	Private Sub CreateParameters(ByVal cmd As SqlCommand)
	
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.IdPersona)
		p.SourceColumn = ColumnNames.IdPersona
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.FechaIng)
		p.SourceColumn = ColumnNames.FechaIng
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdCargo)
		p.SourceColumn = ColumnNames.IdCargo
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdArea)
		p.SourceColumn = ColumnNames.IdArea
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.FechaSal)
		p.SourceColumn = ColumnNames.FechaSal
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IngMensual)
		p.SourceColumn = ColumnNames.IngMensual
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Idagencia)
		p.SourceColumn = ColumnNames.Idagencia
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdEstPers)
		p.SourceColumn = ColumnNames.IdEstPers
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdUser)
		p.SourceColumn = ColumnNames.IdUser
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.FecPro)
		p.SourceColumn = ColumnNames.FecPro
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Hora)
		p.SourceColumn = ColumnNames.Hora
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.IdEstPer)
		p.SourceColumn = ColumnNames.IdEstPer
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.FormaMarcado)
		p.SourceColumn = ColumnNames.FormaMarcado
		p.SourceVersion = DataRowVersion.Current


	End Sub	
    Public Function EobtCargo_Area_Agencia(ByVal sIdPersona As String) As Boolean
        Me.Where.IdPersona.Value = sIdPersona
        Me.Where.IdPersona.Operator = WhereParameter.Operand.Equal
        If Not (Me.Query.Load) Then
            Return False
        Else
            Return True
        End If
    End Function
End Class

