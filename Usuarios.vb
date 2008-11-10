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

        Me.Where.IdPersona.Value = sIdPersona
        Me.Where.IdPersona.Operator = WhereParameter.Operand.Equal
        If Query.Load() Then
            sIdUser = IdUser
            sFecIni = FechaIni.ToShortDateString
            sFecFin = FechaFin.ToShortDateString
            If nivaccxusu.EC_cargaNivAccxUsuAct(sIdUser) Then
                If nivelacceso.LoadByPrimaryKey(nivaccxusu.s_IdNivelAcceso) Then
                    sNomNivAcc = nivelacceso.Descripcion
                End If
            End If
        End If

    End Function
End Class
