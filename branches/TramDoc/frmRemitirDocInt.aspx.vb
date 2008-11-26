Imports CapaLogicaNegocio

Partial Class frmRemitirDocInt
    Inherits System.Web.UI.Page

    Private cargos As New Cargos
    Protected Sub cbotipBusq_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbotipBusq.SelectedIndexChanged
        If cbotipBusq.SelectedValue = 1 Then
            With cboitemBusq
                .DataSource= 
            End With
        End If
    End Sub
End Class
