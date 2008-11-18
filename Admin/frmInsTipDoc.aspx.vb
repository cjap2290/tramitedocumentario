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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtTipoDoc As DataTable
        If TipDoc.EC_ListarTipoDoc Then
            dtTipoDoc = TipDoc.lsTipoDoc
            With gvTipDoc
                .DataSource = dtTipoDoc.DefaultView
                .DataBind()
            End With
        End If
    End Sub
End Class
