Imports CapaLogicaNegocio
Imports System.Data
Imports System.Data.SqlClient
Partial Class frmBuzonInterno
    Inherits System.Web.UI.Page
    Private oBuzoninterno As New vs_Doc_AsignaDoc_Buzon_Interno

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtBuzon As New DataTable
        dtBuzon = oBuzoninterno.obtBuzonxUsuario("ElvMor")
        crearColBuzonInt(dtBuzon)
        With gvBuzon
            .DataSource = dtBuzon.DefaultView
            .DataBind()
        End With
    End Sub
    Private Sub crearColBuzonInt(ByVal dtBuzon As DataTable)
        Dim remitente As New BoundField
        Dim Asunto As New BoundField
        Dim Fecha As New BoundField
        Dim Estado As New BoundField
        Dim Prioridad As New BoundField

        With remitente
            .DataField = dtBuzon.Columns(15).ColumnName
            .HeaderText = " DE "
            gvBuzon.Columns.Add(remitente)
        End With
    End Sub
End Class
