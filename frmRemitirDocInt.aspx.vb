Imports CapaLogicaNegocio
Imports System.Data

Partial Class frmRemitirDocInt
    Inherits System.Web.UI.Page

    Private cargos As New Cargos
    Private areas As New Areas
    Private listaTrabxCargo As New vs_Personal_Usuario_PersonNat
    Protected Sub cbotipBusq_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbotipBusq.SelectedIndexChanged
        Select Case cbotipBusq.SelectedValue
            Case 1
                If areas.EC_ListaAreas Then
                    With cboitemBusq
                        .DataSource = areas.lstAreas.DefaultView
                        .DataTextField = areas.lstAreas.Columns(1).ColumnName
                        .DataValueField = areas.lstAreas.Columns(0).ColumnName
                        .DataBind()
                        UpdatePanel2.Update()
                        .SelectedIndex = 1
                        cboitemBusq_SelectedIndexChanged(Me, Nothing)

                    End With

                End If
            Case 2
                If cargos.EC_ListaCargo Then
                    With cboitemBusq
                        .DataSource = cargos.lstCargos.DefaultView
                        .DataTextField = cargos.lstCargos.Columns(1).ColumnName
                        .DataValueField = cargos.lstCargos.Columns(0).ColumnName
                        .DataBind()
                    End With
                End If
            Case 3

            Case Else

        End Select

        If cbotipBusq.SelectedValue = 1 Then
            
        End If
    End Sub

    Protected Sub cboitemBusq_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboitemBusq.SelectedIndexChanged
        Dim dt As DataTable
        dt = listaTrabxCargo.obtListaxArea
        With DataList1
            .DataSource = dt.DefaultView
            .DataBind()
            UpdatePanel3.Update()
        End With
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Label1.Text = "Page Load: " + DateTime.Now.ToString()
        'CargaLista("06")
    End Sub
End Class
