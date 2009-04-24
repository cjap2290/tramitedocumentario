Imports CapaLogicaNegocio
Partial Class mpInicio
    Inherits System.Web.UI.MasterPage
    '--bloque de codigo utilizado para uso de interface
    'Implements IFrmBuscador
    'Public ReadOnly Property IdPersona() As String Implements IFrmBuscador.IdPersona
    '    Get
    '        Return lblMenUsu.Text
    '    End Get
    'End Property
    '--fin--
    Private siduser As String
    Private usuario As New Usuarios
    Private persona As New PersonNat
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            siduser = Session("IDUSER")
            If usuario.obtIdpersona(siduser) Then
                lblMenUsu.Text = "Bienvenido, " + persona.ObtNombreCompleto(usuario.pIdPersona)
            End If

        End If
    End Sub
End Class

