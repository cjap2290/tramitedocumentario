Imports Microsoft.VisualBasic
Imports CapaAccesoDatos
Imports MyGeneration.dOOdads

' Generated by MyGeneration Version # (1.3.0.3)

Public Class Usuarios 
    Inherits CapaAccesoDatos._Usuarios
    'Dim oUsuario 
    Public NombreColumna As String
    Dim nivelacceso As New CapaLogicaNegocio.NivelAcceso
    Dim nivaccxusu As New CapaLogicaNegocio.NivelAccesoxUsuario
    Dim sECIdCargo As String
    Private sIdUser As String
    Private sFecIni As String
    Private sFecFin As String
    Private sNomNivAcc As String
    Private EC_IdPersona As String
    Private sActivo As String
    Private sPassword As String

    Public Property p_Password() As String
        Get
            Return sPassword
        End Get
        Set(ByVal value As String)
            sPassword = value
        End Set
    End Property

    Public Property p_Activo() As String
        Get
            Return sActivo
        End Get
        Set(ByVal value As String)
            sActivo = value
        End Set
    End Property

    Public Property pIdPersona() As String
        Get
            Return EC_IdPersona
        End Get
        Set(ByVal value As String)
            EC_IdPersona = value
        End Set
    End Property

    Public Property obtNomNivAcceso() As String
        Get
            Return sNomNivAcc
        End Get
        Set(ByVal value As String)
            sNomNivAcc = value
        End Set
    End Property

    Public Property obtIdUser() As String
        Get
            Return sIdUser
        End Get
        Set(ByVal value As String)
            sIdUser = value
        End Set
    End Property
    Public Property obtFecIni() As String
        Get
            Return sFecIni
        End Get
        Set(ByVal value As String)
            sFecIni = value
        End Set
    End Property
    Public Property obtFecFin() As String
        Get
            Return sFecFin
        End Get
        Set(ByVal value As String)
            sFecFin = value
        End Set
    End Property

    'Public Function ListarDepartment() As DataTable
    '    Dim dcoll As New Collection
    '    'Dim rs As String
    '    Dim b As Integer
    '    Dim dt As DataTable
    '    'Me.Where.Tear()
    '    If Me.LoadAll Then
    '        NombreColumna = Usuarios.ColumnNames.IdPersona
    '        b = Me.cuentafilas

    '    End If
    '    dt = Me.retornaUser
    '    'dcoll.Add(dt, "Tabla")
    '    'dcoll.Add(rs, "NombreCol")
    '    Return dt
    'End Function
    Public Function EC_obtIdCargo(ByVal sEIdPersona As String) As String
        If Me.E_obtIdCargo(sEIdPersona) Then
            sECIdCargo = Me.E_sIdCargo
        End If
        Return sECIdCargo
    End Function
    Public Function EC_ingresaUsuario(ByVal sIdUser As String, ByVal sIdPersona As String, _
                                    ByVal dFecProR As String, ByVal HoraR As String, _
                                    ByVal dFechaIni As String, ByVal dFechaFin As String, _
                                    ByVal sIdUserR As String, ByVal sClave As String _
                                    ) As Boolean
        If sIdUser.Length > 0 Then
            AddNew()
            IdUser = sIdUser
            IdPersona = sIdPersona
            FecProR = CType(dFecProR, Date)
            FechaIni = CType(dFechaIni, Date)
            FechaFin = CType(dFechaFin, Date)
            HoraR = HoraR
            IdUser = sIdUser
            Clave = sClave
            Activo = "1"
            Bloqueo = "0"
            Save()
            Return True
        End If
    End Function
    Public Function EC_cargaUsuario(ByVal sIdPersona As String) As Boolean
        'If Where.IdPersona.Value IsNot Nothing Then

        'End If
        Me.Where.IdPersona.Value = sIdPersona
        Me.Where.IdPersona.Operator = WhereParameter.Operand.Equal
        If Query.Load() Then
            sIdUser = IdUser
            sFecIni = FechaIni.ToShortDateString
            sFecFin = FechaFin.ToShortDateString
            sActivo = Activo
            sPassword = Clave
            If nivaccxusu.EC_cargaNivAccxUsuAct(sIdUser) Then
                If nivelacceso.LoadByPrimaryKey(Trim(nivaccxusu.s_IdNivelAcceso)) Then
                    sNomNivAcc = nivelacceso.Descripcion
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
        Me.Where.WhereClauseReset()
    End Function
    Public Function obtIdpersona(ByVal siduser As String) As Boolean
        'If Where.IdUser.Value IsNot Nothing Then
        Try
            Me.Where.IdUser.Value = siduser
            Me.Where.IdUser.Operator = WhereParameter.Operand.Equal
            If Query.Load() Then
                EC_IdPersona = s_IdPersona
                Return True
            Else
                Return False
            End If
        Catch ex As ApplicationException
            Throw ex
        Finally
            Me.Where.WhereClauseReset()
        End Try

        'End If


    End Function
End Class
