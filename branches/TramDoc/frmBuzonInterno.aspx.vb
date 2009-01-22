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
        Dim chk As New HyperLinkField
        Dim remitente As New BoundField
        Dim Asunto As New HyperLinkField
        Dim Fecha As New BoundField
        Dim Estado As New BoundField
        Dim Prioridad As New BoundField
        Dim IdAsignacion As New BoundField
        Dim CamposNavegacion As String() = {"IdAsignacion"}


        'With chk
        '    .data()
        '    .ButtonType = ButtonType.Link
        '    .SelectText = "Selec."
        '    .ShowSelectButton = True
        '    gvBuzon.Columns.Add(chk)
        'End With

        With remitente
            .DataField = "NombreCompleto"  'dtBuzon.Columns(15).ColumnName
            .HeaderText = " DE "
            gvBuzon.Columns.Add(remitente)
        End With
        With IdAsignacion
            .DataField = "IdAsignacion"
            .DataFormatString = "~/frmCuerpo.aspx?id={0}"
            .Visible = True
            gvBuzon.Columns.Add(IdAsignacion)
        End With
        With Asunto
            .DataNavigateUrlFields = CamposNavegacion
            .DataNavigateUrlFormatString = "~/frmCuerpo.aspx?id={0}"
            .DataTextField = "Asunto"  'dtBuzon.Columns(15).ColumnName
            .NavigateUrl = "~/frmCuerpo.aspx" ' ?Parameter=" + txtSearch.Text
            .HeaderText = " Asunto "
            gvBuzon.Columns.Add(Asunto)
        End With
    End Sub

End Class
