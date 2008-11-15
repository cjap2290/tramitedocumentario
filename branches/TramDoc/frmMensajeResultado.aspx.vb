
Partial Class frmMnesajeResultado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Page.PreviousPage IsNot Nothing) Then

            Dim nombre As String
            Dim form As IResultado = CType(PreviousPage, IResultado)

            If (form IsNot Nothing) Then
                nombre = form.Mensaje
                lblConfirmacion.Text = String.Format(nombre)
            End If
        End If
    End Sub
End Class
