Imports CapaLogicaNegocio
Imports System.Data
Imports System.Data.SqlClient
Partial Class frmBuzonInterno
    Inherits System.Web.UI.Page
    Private oBuzoninterno As New vs_Doc_AsignaDoc_Buzon_Interno
    Private tipoDoc As New TipoDocumento
    Private tablas As New Tablas
    Private areas As New Areas
    Private cargos As New Cargos
    Dim borrador As New vs_Borradores
    Dim siduser As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtIdBuzon.Text = Request.QueryString("tipo")
            upTipo.Update()
            upItem.Update()
            upBuzon.Update()
            cboTipo_SelectedIndexChanged(Me, Nothing)
            'CargarDatos()
        End If
        '--Metodo 3 codigo para utilizar interface ifrmbuscador
        'Dim form As IFrmBuscador = TryCast(Master, IFrmBuscador)
        'If form IsNot Nothing Then
        '    'sIdPersona = txtidpersona.Text
        '    Dim sidpersona As String = form.IdPersona
        'End If
        '-- fin metodo 3

    End Sub
    Private Sub crearColBuzonInt(ByVal dtBuzon As DataTable)
        Dim chk As New HyperLinkField
        Dim remitente As New BoundField
        Dim Asunto As New HyperLinkField
        Dim Fecha As New BoundField
        Dim Estado As New BoundField
        Dim Prioridad As New BoundField
        Dim IdAsignacion As New BoundField
        Dim IdDocInterno As New BoundField
        Dim IdBuzonInterno As New BoundField
        Dim CamposNavegacion As String() = {"IdBuzonInterno"}


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
            .ItemStyle.Width = 255
            .ItemStyle.Height = 25
        End With
        With IdAsignacion
            .DataField = "IdAsignacion"
            .Visible = False
            gvBuzon.Columns.Add(IdAsignacion)
        End With
        With IdDocInterno
            .DataField = "IdDocInterno"
            .Visible = False
            gvBuzon.Columns.Add(IdDocInterno)
        End With
        With IdBuzonInterno
            .DataField = "IdBuzonInterno"
            .Visible = False
            gvBuzon.Columns.Add(IdBuzonInterno)
        End With
        With Asunto
            .DataNavigateUrlFields = CamposNavegacion
            .DataNavigateUrlFormatString = "~/frmCuerpo.aspx?id={0}"
            .DataTextField = "Asunto"  'dtBuzon.Columns(15).ColumnName
            .NavigateUrl = "~/frmCuerpo.aspx" ' ?Parameter=" + txtSearch.Text
            .HeaderText = " Asunto "
            .ItemStyle.Height = 25
            gvBuzon.Columns.Add(Asunto)
        End With
        With Fecha
            .DataField = "FechaLLegada"  'dtBuzon.Columns(15).ColumnName
            .HeaderText = " FECHA DE LLEGADA "
            .ItemStyle.Width = 200
            .ItemStyle.Height = 25
            gvBuzon.Columns.Add(Fecha)
        End With
    End Sub
    Protected Sub gvBuzon_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvBuzon.PageIndexChanging
        Dim gv As New GridView
        gv = CType(sender, GridView)
        gv.PageIndex = e.NewPageIndex
        cboTipo_SelectedIndexChanged(Me, Nothing)
    End Sub
    Protected Sub cboTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Try
            If cboItem.Items IsNot Nothing Then
                cboItem.Items.Clear()
            End If
            Select Case cboTipo.SelectedValue
                Case 0
                    cboItem.Items.Insert(0, "Mostrar Todos")
                    upItem.Update()
                    upBuzon.Update()
                    cboItem.SelectedIndex = 0
                    cboItem_SelectedIndexChanged(Me, Nothing)
                Case 1
                    If tipoDoc.EC_ListarTipoDoc Then
                        With cboItem
                            .DataSource = tipoDoc.lsTipoDoc.DefaultView
                            .DataTextField = tipoDoc.lsTipoDoc.Columns(1).ColumnName
                            .DataValueField = tipoDoc.lsTipoDoc.Columns(0).ColumnName
                            .DataBind()
                            upItem.Update()
                            upBuzon.Update()
                            .SelectedIndex = 0
                            cboItem_SelectedIndexChanged(Me, Nothing)
                        End With
                    End If
                Case 2
                    If tablas.obtTablaxIdTabla(1) Then
                        With cboItem
                            .DataSource = tablas.pLsTabla.DefaultView
                            .DataTextField = tablas.pLsTabla.Columns(3).ColumnName
                            .DataValueField = tablas.pLsTabla.Columns(4).ColumnName
                            .DataBind()
                            upItem.Update()
                            upBuzon.Update()
                            .SelectedIndex = 0
                            cboItem_SelectedIndexChanged(Me, Nothing)
                        End With
                    End If
                Case 3
                    If areas.EC_ListaAreas Then
                        With cboItem
                            .DataSource = areas.lstAreas.DefaultView
                            .DataTextField = areas.lstAreas.Columns(1).ColumnName
                            .DataValueField = areas.lstAreas.Columns(0).ColumnName
                            .DataBind()
                            upItem.Update()
                            upBuzon.Update()
                            .SelectedIndex = 0
                            cboItem_SelectedIndexChanged(Me, Nothing)
                        End With
                    End If
                Case 4
                    If cargos.EC_ListaCargo Then
                        With cboItem
                            .DataSource = cargos.lstCargos.DefaultView
                            .DataTextField = cargos.lstCargos.Columns(1).ColumnName
                            .DataValueField = cargos.lstCargos.Columns(0).ColumnName
                            .DataBind()
                            upItem.Update()
                            upBuzon.Update()
                            .SelectedIndex = 0
                            cboItem_SelectedIndexChanged(Me, Nothing)
                        End With
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Protected Sub cboItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dtBuzon As New DataTable
        Dim sidtipo As String
        sidtipo = txtIdBuzon.Text
        siduser = Session.Item("IDUSER")
        Select Case cboTipo.SelectedValue
            Case 0
                Select Case sidtipo
                    Case "1"
                        dtBuzon = oBuzoninterno.obtBuzonxUsuario(siduser, "1", 2)
                    Case "2"
                        dtBuzon = oBuzoninterno.obtBuzonxUsuario(siduser, "6", 2)
                    Case "3"
                        dtBuzon = borrador.obtBuzonxUsuario(siduser)
                End Select
            Case 1
                Select Case sidtipo
                    Case "1"
                        dtBuzon = oBuzoninterno.obtBuzonxtipodoc(siduser, "1", 2, cboItem.SelectedValue)
                    Case "2"
                        dtBuzon = oBuzoninterno.obtBuzonxtipodoc(siduser, "6", 2, cboItem.SelectedValue)
                    Case "3"
                        dtBuzon = borrador.obtBuzonxtipodoc(siduser, cboItem.SelectedValue)
                End Select
            Case 2
                Select Case sidtipo
                    Case "1"
                        dtBuzon = oBuzoninterno.obtBuzonxPrioridad(siduser, "1", 2, cboItem.SelectedValue)
                    Case "2"
                        dtBuzon = oBuzoninterno.obtBuzonxPrioridad(siduser, "6", 2, cboItem.SelectedValue)
                    Case "3"
                        dtBuzon = borrador.obtBuzonxPrioridad(siduser, cboItem.SelectedValue)
                End Select
            Case 3
                Select Case sidtipo
                    Case "1"
                        dtBuzon = oBuzoninterno.obtBuzonxArea(siduser, "1", 2, cboItem.SelectedValue)
                    Case "2"
                        dtBuzon = oBuzoninterno.obtBuzonxArea(siduser, "6", 2, cboItem.SelectedValue)
                    Case "3"
                        dtBuzon = borrador.obtBuzonxArea(siduser, cboItem.SelectedValue)
                End Select
            Case 4
                Select Case sidtipo
                    Case "1"
                        dtBuzon = oBuzoninterno.obtBuzonxCargo(siduser, "1", 2, cboItem.SelectedValue)
                    Case "2"
                        dtBuzon = oBuzoninterno.obtBuzonxCargo(siduser, "6", 2, cboItem.SelectedValue)
                    Case "3"
                        dtBuzon = borrador.obtBuzonxCargo(siduser, cboItem.SelectedValue)
                End Select
        End Select

        If dtBuzon IsNot Nothing Then
            gvBuzon.Columns.Clear()
            crearColBuzonInt(dtBuzon)
            With gvBuzon
                .DataSource = dtBuzon.DefaultView
                .DataBind()
                upBuzon.Update()
            End With
        Else
            With gvBuzon
                .DataSource = Nothing
                .DataBind()
                upBuzon.Update()
            End With
        End If
    End Sub
End Class
