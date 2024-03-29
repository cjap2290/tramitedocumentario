﻿Imports CapaLogicaNegocio
Imports system.Data
Imports System.Data.SqlClient
Imports System
Imports System.Web.Security
Imports System.Configuration
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts

Partial Class frmBuscador
    Inherits System.Web.UI.Page
    '--bloque de codigo utilizado para uso de interface
    'Implements IFrmBuscador
    'Public ReadOnly Property IdPersona() As String Implements IFrmBuscador.IdPersona
    '    Get
    '        Return txtselec.Text
    '    End Get
    'End Property
    '--fin--
    Dim a As New CapaLogicaNegocio.PersonNat
    Dim sidpersona As String
    Dim IdPersonaImp As New Prueba
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
    '#Region "IFrmBuscador Members"

    '    ReadOnly Property IdPersona() As String
    '        Get
    '            Return txtselec.Text
    '        End Get
    '    End Property
    '#End Region
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
            Dim nombre As String = gvr.Cells(5).Text + " " + gvr.Cells(3).Text + " " + gvr.Cells(4).Text
            txtIdPers.Value = variable
            Session("IdPersona") = variable
            txtPersona.Value = nombre
            variable = gdListado.SelectedIndex
            '--funciona con el metodo de pasar variables con interface
            'IdPersonaImp.pasavarIdPers(txtselec.Text)
            '-- fin
            'Response.Redirect("frmRegUsuario.aspx?variable=" + variable + "")
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
        Dim Nombres As New BoundField
        Dim SelecCol As New CommandField

        With SelecCol
            .ButtonType = ButtonType.Link
            .SelectText = "Selec."
            .ShowSelectButton = True
            gdListado.Columns.Add(SelecCol)
        End With
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
        With Nombres
            .DataField = dtPersonas.Columns(3).ColumnName
            .HeaderText = dtPersonas.Columns(3).ColumnName
            gdListado.Columns.Add(Nombres)
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
        'Me.Button2.Attributes.Add("onclick", "javascript:'closeFrmBuscador()'")
    End Sub

    Protected Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        'Response.Redirect("frmRegUsuario.aspx?id=" + txtIdPers.Value)
    End Sub
End Class


