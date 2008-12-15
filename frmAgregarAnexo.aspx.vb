Imports System.IO
Imports CapaLogicaNegocio

Partial Class frmEnvioDoc
    Inherits System.Web.UI.Page
    Dim NuevoAnexo As New Anexos
    Dim NuevoBuzon As New BuzonInterno

    Private Sub CargarAnexos(ByVal sIdDocInterno)
        If NuevoAnexo.obtenerAnexosActivo(sIdDocInterno) Then
            With lbAnexos
                .DataSource = NuevoAnexo.dtListaAnexoActivos.DefaultView
                .DataTextField = NuevoAnexo.dtListaAnexoActivos.Columns(2).ColumnName
                .DataValueField = NuevoAnexo.dtListaAnexoActivos.Columns(0).ColumnName
                upListaAnexo.Update()
                .DataBind()
            End With
        End If
    End Sub
    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        '// Actualizar documento interno
        '// Registrar buzon interno
        Try
            With NuevoBuzon
                .pIdAsignaDocInterno = 5 '// ToDo: numero de asignacion correcto
                .pFechaLlegada = DateTime.Now.ToShortDateString
                .pFechaLimite = txtFechaLimite.Text
                .pIdCondicionEnvio = "01"  '// ToDo: numero de condiciond e envio correcto
                .pIdEstBuzoninterno = "12" '// ToDo: estado de buzon correcto
                .pObservaciones = txtObservaciones.Text
                .pIdUserR = "JeaCol" '//ToDo :usuairo correcto
                .pFechaR = DateTime.Now.ToShortDateString
                .insertarBuzon(NuevoBuzon)
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Protected Sub btnAgregAnexo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregAnexo.Click
        Try
            If Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName) <> "" Then
                Dim nombre As String = Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName)
                '//ruta de red
                'Dim rutaarchivo = "\\svrdesarrollo\PruebasYepo\" & Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName)
                '//ruta local
                Dim rutaarchivo = "D:\PruebasYepo\" & Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName)
                '// Guardar Anexo  
                With NuevoAnexo
                    '.pIdDocInterno = 5 '--- ToDo : insertar codigo correcto
                    .pNombreAnexo = nombre
                    .pRutaAnexo = rutaarchivo
                    .pActivo = "1"
                    .pIdUserR = "JeaCol"  '----ToDo  : inserta iduser del usuario que accedio
                    .pFechaR = DateTime.Now.ToShortDateString
                    .InsertaAnexo(NuevoAnexo)
                End With
                '// subir archivo
                If Me.fuSubeAnexo.PostedFile.FileName IsNot Nothing Then
                    fuSubeAnexo.PostedFile.SaveAs(rutaarchivo)
                End If
                CargarAnexos(NuevoAnexo.pIdDocInterno)
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Protected Sub btnQuitarAnexo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuitarAnexo.Click
        If lbAnexos.SelectedIndex > 0 Then
            NuevoAnexo.DesactivarAnexo(lbAnexos.Items(lbAnexos.SelectedIndex).Value)
            lbAnexos.Items.RemoveAt(lbAnexos.SelectedIndex)
            CargarAnexos(NuevoAnexo.pIdDocInterno)
        Else
            MsgBox("Seleccione un Anexo por favor")
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        NuevoAnexo.pIdDocInterno = 5 '--- ToDo : insertar codigo correcto
        If Not (IsPostBack) Then
            CargarAnexos(NuevoAnexo.pIdDocInterno)
        End If
    End Sub
End Class
