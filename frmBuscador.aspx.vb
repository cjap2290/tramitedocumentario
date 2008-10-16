Imports CapaLogicaNegocio
Partial Class frmBuscador
    Inherits System.Web.UI.Page
    Dim a As New CapaLogicaNegocio.Usuarios


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TextBox1.Text = a.ListarDepartment
    End Sub
End Class
