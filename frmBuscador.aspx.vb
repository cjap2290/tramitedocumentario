Imports CapaLogicaNegocio
Imports system.Data
Imports System.Data.SqlClient
Partial Class frmBuscador
    Inherits System.Web.UI.Page
    Dim a As New CapaLogicaNegocio.Usuarios


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim dt As DataTable
        Dim ousuario As New Usuarios
        With cboOpcion
            .DataSource = a.ListarDepartment.DefaultView
            .DataTextField = a.NombreColumna
            .DataBind()
        End With
       
        'With gdListado
        '    .DataSource = a.ListarDepartment.DefaultView

        '    .DataBind()
        'End With
    End Sub
End Class
