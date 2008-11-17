Imports CapaLogicaNegocio
Imports System.Data
Imports System.Data.SqlClient

Partial Class frmInsTipDoc
    Inherits System.Web.UI.Page
    Implements IResultado
    Dim TipDoc As New TipoDocumento
    Private sMensaje As String
    Public ReadOnly Property IdPersona() As String Implements IResultado.Mensaje
        Get
            Return sMensaje
        End Get
    End Property
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        TipDoc.EC_insTipDoc(txtDescripcion.Text, "JeaCol", "13/11/2008")
        sMensaje = "El registro del documento " & Me.txtDescripcion.Text & " se realizo correctamente"
    End Sub
    Sub iniGrid(ByRef dtTipoDoc As DataTable)
        Dim Descripcion As New BoundField
        Dim IdUser As New BoundField
        Dim FechaR As New BoundField

        With Descripcion
            .DataField = dtTipoDoc.Columns(2).ColumnName
            .HeaderText = "Descripcion"
        End With
        With IdUser
            .DataField = dtTipoDoc.Columns(0).ColumnName
            .HeaderText = dtTipoDoc.Columns(0).ColumnName
        End With
        With FechaR
            .DataField = dtTipoDoc.Columns(1).ColumnName
            .HeaderText = "Fecha de Registro"
        End With
        gvTipDoc.Columns.Add(Descripcion)
        gvTipDoc.Columns.Add(IdUser)
        gvTipDoc.Columns.Add(FechaR)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtTipoDoc As DataTable
        If TipDoc.EC_ListarTipoDoc Then
            dtTipoDoc = TipDoc.lsTipoDoc
            iniGrid(dtTipoDoc)
        End If
    End Sub
End Class
