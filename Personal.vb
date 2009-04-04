Imports CapaAccesoDatos
' Generated by MyGeneration Version # (1.3.0.3)

Public Class Personal 
    Inherits _Personal
    Dim sNomCargo As String
    Dim sNomArea As String
    Dim sNomAgencia As String
    Dim sNomPersonal As String
    Dim Cargos As New CapaLogicaNegocio.Cargos
    Dim Areas As New CapaLogicaNegocio.Areas
    Dim Agencias As New CapaLogicaNegocio.Agencias
    Dim Personas As New CapaLogicaNegocio.PersonNat
    Private sIdArea As String
    Private sIdAgencia As String
    Public Property p_IdAgencia() As String
        Get
            Return sIdAgencia
        End Get
        Set(ByVal value As String)
            sIdAgencia = value
        End Set
    End Property

    Public Property p_Area() As String
        Get
            Return sIdArea
        End Get
        Set(ByVal value As String)
            sIdArea = value
        End Set
    End Property


    Public ReadOnly Property NombreCompleto()
        Get
            Return sNomPersonal
        End Get
    End Property
    Public ReadOnly Property NombreCargo()
        Get
            Return sNomCargo
        End Get
    End Property
    Public ReadOnly Property NombreArea()
        Get
            Return sNomArea
        End Get
    End Property
    Public ReadOnly Property NombreAgencia()
        Get
            Return sNomAgencia
        End Get
    End Property
    Public Function obtCargoPersonal(ByVal sIdpersona As String) As Boolean
        If EobtCargo_Area_Agencia(sIdpersona) Then
            sNomCargo = Cargos.EC_obtCargo(IdCargo)
            sNomArea = Areas.EC_obtArea(IdArea)
            sNomAgencia = Agencias.EC_obtAgencia(Idagencia)
            sNomPersonal = Personas.ObtNombreCompleto(sIdpersona)
            Return True
        Else
            Return False
        End If

    End Function
    Public Function obtPersonal(ByVal sIdPersona As String) As Boolean
        If LoadByPrimaryKey(sIdPersona) Then
            sIdArea = s_IdArea
            sIdAgencia = s_Idagencia
            Return True
        Else
            Return False
        End If
    End Function
    'Public Function obtAreaPersonal(ByVal sIdpersona As String)
    '    Dim sIdArea As String
    '    If EobtCargo_Area(sIdpersona) Then
    '        sIdArea = Me.IdArea
    '        sNomArea = Areas.EC_obtArea(sIdArea)
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
End Class
