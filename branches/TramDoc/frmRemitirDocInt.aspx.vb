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
                        UpdatePanel3.Update()
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
                        UpdatePanel2.Update()
                        UpdatePanel3.Update()
                        .SelectedIndex = 1
                        cboitemBusq_SelectedIndexChanged(Me, Nothing)
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
        dt = listaTrabxCargo.obtListaxArea(Me.cbotipBusq.SelectedValue, Me.cboitemBusq.SelectedValue)
        If dt IsNot Nothing Then
            gvItem.Columns.Clear()
            iniGrid(dt)
            With gvItem
                .DataSource = dt.DefaultView
                .DataBind()
                UpdatePanel3.Update()
            End With
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'CargaLista("06")
    End Sub
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
            gvItem.Columns.Add(SelecCol)
        End With
        With idpersona
            .DataField = dtPersonas.Columns(0).ColumnName
            .HeaderText = dtPersonas.Columns(0).ColumnName
            gvItem.Columns.Add(idpersona)
        End With
        With apepat
            .DataField = dtPersonas.Columns(13).ColumnName
            .HeaderText = "Apellido Paterno"
            gvItem.Columns.Add(apepat)
        End With
        With apemat
            .DataField = dtPersonas.Columns(14).ColumnName
            .HeaderText = "Apellido Materno"
            gvItem.Columns.Add(apemat)
        End With
        With Nombres
            .DataField = dtPersonas.Columns(15).ColumnName
            .HeaderText = dtPersonas.Columns(15).ColumnName
            gvItem.Columns.Add(Nombres)
        End With

    End Sub

    Protected Sub gvItem_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvItem.RowCommand
        Dim itemlbrem As New ListItem
        If e.CommandName = "Select" Then
            gvItem.SelectedIndex = Convert.ToInt32(e.CommandArgument)
            Dim gvr As GridViewRow = gvItem.SelectedRow
            Dim idpersona As String = gvr.Cells(1).Text
            Dim nombre As String = gvr.Cells(2).Text + " " + gvr.Cells(3).Text + " " + gvr.Cells(4).Text
            'txtIdPers.Value = variable
            'txtPersona.Value = nombre
            'variable = gvItem.SelectedIndex
            itemlbrem.Enabled = True
            itemlbrem.Value = idpersona
            itemlbrem.Text = nombre
            'Call añadeItem(itemlbrem)
            Me.lbRemitentes.Items.Add(itemlbrem)
            Me.UpdatePanel4.Update()
        End If
    End Sub
    Protected Sub gvItem_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvItem.PageIndexChanging
        Dim gv As New GridView()
        gv = CType(sender, GridView)
        gv.PageIndex = e.NewPageIndex
        cboitemBusq_SelectedIndexChanged(Me, Nothing)
    End Sub
    Protected Sub añadeItem(ByVal item As ListItem)
        'Me.lbRemitentes.Items.Add("monin")
    End Sub
End Class
