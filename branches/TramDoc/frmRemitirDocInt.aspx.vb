Imports CapaLogicaNegocio
Imports System.Data

Partial Class frmRemitirDocInt
    Inherits System.Web.UI.Page

    Private cargos As New Cargos
    Private areas As New Areas
    Private listaTrabxCargo As New vs_Personal_Usuario_PersonNat
    Dim esRemitente As Boolean
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'CargaLista("06")
        If Not (IsPostBack) Then
            Me.UpdatePanel1.Update()
            Me.UpdatePanel2.Update()
            Me.UpdatePanel3.Update()
            cbotipBusq_SelectedIndexChanged(Me, Nothing)
        End If

    End Sub
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
                        .SelectedIndex = 0
                        Label1.Text = Right(cbotipBusq.SelectedItem.Text, cbotipBusq.SelectedItem.Text.Length - 4)
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
                        .SelectedIndex = 0
                        Label1.Text = Right(cbotipBusq.SelectedItem.Text, cbotipBusq.SelectedItem.Text.Length - 4)
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

   
    Sub iniGrid(ByRef dtPersonas As DataTable)
        Dim idpersona As New BoundField
        Dim apepat As New BoundField
        Dim apemat As New BoundField
        Dim Nombres As New BoundField
        Dim chk As New CheckBoxField
        Dim SelecCol As New CommandField

        With chk
            .Visible = True
            gvItem.Columns.Add(chk)
        End With
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
            .HtmlEncode = True
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
            Dim idpersona As String = gvr.Cells(2).Text
            Dim nombre As String = Page.Server.HtmlDecode(gvr.Cells(3).Text) + " " + Page.Server.HtmlDecode(gvr.Cells(4).Text) + " " + gvr.Cells(5).Text
            'txtIdPers.Value = variable
            'txtPersona.Value = nombre
            'variable = gvItem.SelectedIndex
            itemlbrem.Enabled = True
            itemlbrem.Value = idpersona
            itemlbrem.Text = nombre
            'Call añadeItem(itemlbrem)
            'Se añada a los listbox los items del datagrid ya sea remitente o destino con copia

            If mvConCopia.ActiveViewIndex = 2 Then
                If Not EstaEnLista(idpersona) Then
                    Me.lbRemitentes.Items.Add(itemlbrem)
                End If
                Me.UpdatePanel4.Update()
            Else
                If Not EstaEnLista(idpersona) Then
                    Me.lbDestCC.Items.Add(itemlbrem)
                End If
                Me.UpdatePanel4.Update()
            End If
        End If
    End Sub
    Protected Sub gvItem_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvItem.PageIndexChanging
        Dim gv As New GridView()
        gv = CType(sender, GridView)
        gv.PageIndex = e.NewPageIndex
        cboitemBusq_SelectedIndexChanged(Me, Nothing)
    End Sub
    Protected Function EstaEnLista(ByVal sidpersona As String) As Boolean
        Dim n As Integer
        If mvConCopia.ActiveViewIndex = 2 Then
            For i As Integer = 0 To lbRemitentes.Items.Count - 1
                If sidpersona = lbRemitentes.Items(i).Value Then
                    n = n + 1
                End If
            Next i
        Else
            For i As Integer = 0 To lbDestCC.Items.Count - 1
                If sidpersona = lbDestCC.Items(i).Value Then
                    n = n + 1
                End If
            Next i
        End If
        If n >= 1 Then
            Return True
        Else
            Return False
        End If

    End Function
    Protected Sub LnkBtnRemCC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LnkBtnDestCC.Click
        Me.mvConCopia.SetActiveView(View2)
        UpdatePanel3.Update()
    End Sub

    Protected Sub LnkBtnRem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LnkBtnRem.Click
        Me.mvConCopia.SetActiveView(View3)
        UpdatePanel3.Update()
    End Sub
End Class
