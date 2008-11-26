Imports CapaLogicaNegocio

Partial Class frmRemitirDocInt
    Inherits System.Web.UI.Page

    Private cargos As New Cargos
    Protected Sub cbotipBusq_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbotipBusq.SelectedIndexChanged

        Select Case cbotipBusq.SelectedValue
            Case 1

            Case 2

            Case Else

        End Select

        If cbotipBusq.SelectedValue = 1 Then
            With cboitemBusq
                .DataSource = cargos.lstCargos.DefaultView
                .DataTextField = cargos.lstCargos.Columns(1).ColumnName
                .DataValueField = cargos.lstCargos.Columns(0).ColumnName
            End With
        End If
    End Sub
End Class
