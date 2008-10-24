Imports CapaLogicaNegocio
Imports system.Data
Imports System.Data.SqlClient
Partial Class frmBuscador
    Inherits System.Web.UI.Page
    Dim a As New CapaLogicaNegocio.PersonNat


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim dt As DataTable
        Dim ousuario As New Usuarios
        'With cboOpcion
        '    .DataSource = a.ListarDepartment.DefaultView
        '    .DataTextField = a.NombreColumna
        '    .DataBind()
        'End With

        'With gdListado
        '    .DataSource = a.ListarDepartment.DefaultView
        '    .DataBind()
        'End With
        Call Cargardatos()
    End Sub

    Protected Sub gdListado_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdListado.PageIndexChanging
        Dim gv As New GridView()
        gv = CType(sender, GridView)
        gv.PageIndex = e.NewPageIndex
        Call Cargardatos()
    End Sub
    Sub Cargardatos()
        Dim dtPersonas As DataTable
        With gdListado
            dtPersonas = a.ListarPersonas(Me.txtselec.Text)
            .DataSource = dtPersonas.DefaultView
            .DataBind()
        End With
    End Sub

    Protected Sub gdListado_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdListado.RowCommand
        If e.CommandName = "Select" Then
            gdListado.SelectedIndex = Convert.ToInt32(e.CommandArgument)
            Dim gvr As GridViewRow = gdListado.SelectedRow
            Dim variable As String = gvr.Cells(2).Text
            txtselec.Text = variable
            variable = gdListado.SelectedIndex
        End If
    End Sub
End Class


