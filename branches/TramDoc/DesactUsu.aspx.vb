
Partial Class DesactUsu
    Inherits System.Web.UI.Page
    Dim sPersona As String
    Dim usuarios As New CapaLogicaNegocio.Usuarios
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnBuscador.Attributes.Add("onclick", "javascript:llamaBuscador();")
        sPersona = Session.Item("IdPersona")
        If sPersona IsNot Nothing Then

        End If
    End Sub
End Class
