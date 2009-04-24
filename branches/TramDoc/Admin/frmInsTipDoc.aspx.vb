Imports CapaLogicaNegocio
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI

Partial Class frmInsTipDoc
    Inherits System.Web.UI.Page
    Implements IResultado
    Dim TipDoc As New TipoDocumento
    Dim Area As New Areas
    Dim Agencia As New Agencias
    Dim tipdocxareaxage As New TipoDocumentoxAreasxAgencia
    Private sMensaje As String
    Private variable As String
    Public ReadOnly Property IdPersona() As String Implements IResultado.Mensaje
        Get
            Return sMensaje
        End Get
    End Property
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        TipDoc.EC_insTipDoc(txtDescripcion.Text, "JeaCol", "13/11/2008")
        sMensaje = "El registro del documento " & Me.txtDescripcion.Text & " se realizo correctamente"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarDatos()
        End If
    End Sub
    Sub CargarDatos()
        Dim dtTipoDoc As DataTable

        If TipDoc.EC_ListarTipoDoc Then
            dtTipoDoc = TipDoc.lsTipoDoc
            iniGrid(dtTipoDoc)
            With gvTipDoc
                .DataSource = dtTipoDoc.DefaultView
                .DataBind()
            End With
        End If
        If Area.EC_ListaAreas Then
            With cboAreas
                .DataSource = Area.lstAreas.DefaultView
                .DataTextField = Area.lstAreas.Columns(1).ColumnName
                .DataValueField = Area.lstAreas.Columns(0).ColumnName
                .DataBind()
            End With
        End If
        If Agencia.EC_listaAgencias Then
            With cboAgencia
                .DataSource = Agencia.lsAgencia.DefaultView
                .DataTextField = Agencia.lsAgencia.Columns(1).ColumnName
                .DataValueField = Agencia.lsAgencia.Columns(0).ColumnName
                .DataBind()
            End With
        End If
    End Sub
    Sub iniGrid(ByRef dtTipoDoc As DataTable)
        Dim idtipdoc As New BoundField
        Dim descripcion As New BoundField
        Dim iduserR As New BoundField
        Dim fechaR As New BoundField
        Dim SelecCol As New CommandField
        Dim tfDetalle As New TemplateField



        With SelecCol
            .ButtonType = ButtonType.Link
            .SelectText = "Selec."
            .ShowSelectButton = True
            gvTipDoc.Columns.Add(SelecCol)
        End With
        With idtipdoc
            .DataField = dtTipoDoc.Columns(0).ColumnName
            .HeaderText = dtTipoDoc.Columns(0).ColumnName
            gvTipDoc.Columns.Add(idtipdoc)
        End With
        With descripcion
            .DataField = dtTipoDoc.Columns(1).ColumnName
            .HeaderText = "Descripcion"
            gvTipDoc.Columns.Add(descripcion)
        End With
        With iduserR
            .DataField = dtTipoDoc.Columns(2).ColumnName
            .HeaderText = "Usuario"
            gvTipDoc.Columns.Add(iduserR)
        End With
        With fechaR
            .DataField = dtTipoDoc.Columns(3).ColumnName
            .HeaderText = "Fecha de Registro"
            gvTipDoc.Columns.Add(fechaR)
        End With

    End Sub

    
    Protected Sub gvTipDoc_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvTipDoc.RowCommand
        Dim dtTipDocxAxA As DataTable
        If e.CommandName = "Select" Then
            gvTipDoc.SelectedIndex = Convert.ToInt32(e.CommandArgument)
            Dim gvr As GridViewRow = gvTipDoc.SelectedRow
            variable = gvr.Cells(2).Text
            Me.TextBox1.Text = variable
            dtTipDocxAxA = tipdocxareaxage.obtTipDocxAreaxAge(variable)
            gvTipDocxAreaxAge.DataSource = Nothing
            gvTipDocxAreaxAge.DataBind()
            If dtTipDocxAxA IsNot Nothing Then
                With gvTipDocxAreaxAge
                    .DataSource = dtTipDocxAxA.DefaultView
                    .DataBind()
                End With
            End If
        End If
    End Sub

    'Protected Sub gvTipDoc_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvTipDoc.RowDataBound
    '    Dim dtTipDocxAxA As DataTable
    '    If e.Row.RowType = DataControlRowType.DataRow Then
    '        Dim idtipdoc As String = e.Row.Cells(2).Text
    '        dtTipDocxAxA = tipdocxareaxage.obtTipDocxAreaxAge(idtipdoc)
    '        If dtTipDocxAxA IsNot Nothing Then
    '            dtTipDocxAxA.DefaultView
    '            Dim gdv As GridView = DirectCast(e.Row.Cells(2).FindControl("gdvProductos"), GridView)
    '            gdv.DataSource = vst
    '            gdv.DataBind()
    '        End If
    '    End If
    'End Sub

    Protected Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        Try
            TipDoc.EC_insTipDoc(txtDescripcion.Text, Session("IDUSER"), DateTime.Now.Date.ToString)
            sMensaje = "El registro del documento " & Me.txtDescripcion.Text & " se realizo correctamente"
        Catch ex As Exception
            sMensaje = ex.Message
        End Try

            End Sub

    Protected Sub BtnRegTipDocxArea_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRegTipDocxArea.Click
        Try
            If TextBox1.Text.Length > 0 Then
                With tipdocxareaxage
                    .p_IdTipDoc = CType(TextBox1.Text, Integer)
                    .p_IdArea = cboAreas.SelectedValue
                    .p_IdAgencia = cboAgencia.SelectedValue
                    .p_Activo = "1"
                    .p_IdUser = Session("IDUSER")
                    .p_FechaR = DateTime.Now.Date.ToString
                    .insertaTipDocxAreaxAge(tipdocxareaxage)
                End With
            Else
                MsgBox("Es necesario escoger un elemento de la Lista")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
