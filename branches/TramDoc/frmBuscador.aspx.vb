Imports CapaLogicaNegocio
Imports system.Data
Imports System.Data.SqlClient
Partial Class frmBuscador
    Inherits System.Web.UI.Page
    Dim a As New CapaLogicaNegocio.PersonNat
    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    'Dim dt As DataTable
    '    Dim ousuario As New Usuarios
    '    'With cboOpcion
    '    '    .DataSource = a.ListarDepartment.DefaultView
    '    '    .DataTextField = a.NombreColumna
    '    '    .DataBind()
    '    'End With

    '    'With gdListado
    '    '    .DataSource = a.ListarDepartment.DefaultView
    '    '    .DataBind()
    '    'End With
    '    Call Cargardatos()
    'End Sub

    Protected Sub gdListado_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdListado.PageIndexChanging
        Dim gv As New GridView()
        gv = CType(sender, GridView)
        gv.PageIndex = e.NewPageIndex
        Call Cargardatos()
    End Sub
    Sub Cargardatos()
        Dim dtPersonas As DataTable
        Dim b As Integer
        dtPersonas = a.ListarPersonas(Me.txtCadIng.Text)
        iniGrid(dtPersonas)
        With gdListado
            .DataSource = dtPersonas.DefaultView
            .DataBind()
            b = .Columns.Count
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
    '--otro metodo para ocultar columnas en un gridview---
    'Public Sub gdListado_OnRowCreated(ByVal sender As Object, ByVal e As Web.UI.WebControls.GridViewRowEventArgs) Handles gdListado.RowCreated
    '    e.Row.Cells(0).Visible = False 'Uid cobranza

    'End Sub
    '--fin------------------------------------------------
    '--metodo para ocultar columnas en un gridview----------
    'Protected Sub gdListado_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gdListado.RowDataBound
    '    If (gdListado.Rows.Count < gdListado.PageSize) & (gdListado.Rows.Count + gdListado.PageSize * gdListado.PageIndex < (CType(gdListado.DataSource, DataTable)).Rows.Count) Then

    '    End If
    '    e.Row.Cells(5).Visible = False
    '    'e.Row.Cells[IndiceCol].Visible = false;

    'End Sub
    '--fin------------------------------------------------------
    Sub iniGrid(ByRef dtPersonas As DataTable)
        Dim idpersona As New BoundField
        Dim apepat As New BoundField
        Dim apemat As New BoundField
        With idpersona
            .DataField = dtPersonas.Columns(0).ColumnName
            .HeaderText = dtPersonas.Columns(0).ColumnName
            gdListado.Columns.Add(idpersona)
        End With
        With apepat
            .DataField = dtPersonas.Columns(1).ColumnName
            .HeaderText = "Apellido Paterno"
            gdListado.Columns.Add(apepat)
        End With
        With apemat
            .DataField = dtPersonas.Columns(2).ColumnName
            .HeaderText = "Apellido Materno"
            gdListado.Columns.Add(apemat)
        End With

    End Sub

    Protected Sub btn_Buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Dim ousuario As New Usuarios
        'gdListado.Columns.Clear()
        Call Cargardatos()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'gdListado.Attributes.Add("onclick", "javascript:'obtValor()'")
        'Me.txtselec.Attributes.Add("ontextchanged", "javascript:'obtValor()'")
    End Sub
End Class


