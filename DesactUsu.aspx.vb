
Partial Class DesactUsu
    Inherits System.Web.UI.Page
    Dim sPersona As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnBuscador.Attributes.Add("onclick", "javascript:llamaBuscador();")
        sPersona = Session.Item("IdPersona")
        If sPersona IsNot Nothing Then
            MsgBox(sPersona)
        End If
    End Sub
End Class
