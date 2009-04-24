Imports System.IO
Imports CapaLogicaNegocio
Imports System.Data

Partial Class frmEnvioDoc
    Inherits System.Web.UI.Page
    Dim NuevoAnexo As New Anexos
    Dim NuevoBuzon As New BuzonInterno
    Dim Asignacion As New AsignaDocInterno
    Dim docint As DocumentoInterno

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
        Dim dtRemite As New DataTable
        Dim idestado As Integer
        '// Actualizar documento interno
        '// Registrar buzon interno
        Try
            'With NuevoBuzon
            '    .pIdAsignaDocInterno = CType(IdAsiDocInt.Text, Integer) '// ToDo: numero de asignacion correcto
            '    .pFechaLlegada = DateTime.Now.ToShortDateString
            '    .pFechaLimite = CType(txtFechaLimite.Text, Date)
            '    .pIdCondicionEnvio = 1  '// ToDo: numero de condiciond e envio correcto
            '    .pIdEstBuzoninterno = 1 '// ToDo: estado de buzon correcto
            '    .pObservaciones = txtObservaciones.Text
            '    .pIdUserR = Session("IdUser")
            '    .pFechaR = DateTime.Now.ToShortDateString
            '    .insertarBuzon(NuevoBuzon)
            'End With
            'inserta en buzon de remitentes
            Asignacion.obtAsignacionxDocInt(IdAsiDocInt.Text)
            dtRemite = Asignacion.lsAsixDocI
            If dtRemite IsNot Nothing Then
                For Each fila As DataRow In dtRemite.Rows
                    If fila("IdEstAsigDoc") = 1 Then
                        idestado = 1
                    Else
                        idestado = 6
                    End If
                    With NuevoBuzon
                        .pIdAsignaDocInterno = fila("IdAsigDocInterno") '// ToDo: numero de asignacion correcto
                        .pFechaLlegada = DateTime.Now.ToShortDateString
                        .pFechaLimite = CType(txtFechaLimite.Text, Date)
                        .pIdCondicionEnvio = 1  '// ToDo: numero de condiciond e envio correcto
                        .pIdEstBuzoninterno = idestado '// ToDo: estado de buzon correcto
                        .pObservaciones = txtObservaciones.Text
                        .pIdUserR = Session("IdUser")
                        .pFechaR = DateTime.Now.ToShortDateString
                        .insertarBuzon(NuevoBuzon)
                    End With
                Next
                docint.cambiaestado(IdAsiDocInt.Text, 2)
            End If
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
                'Dim rutaarchivo = "C:\TramiteDocumentario\DocumentoInterno\Documentos\" & Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName)
                Dim rutaarchivo = "C:\" & Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName)
                '// Guardar Anexo  
                With NuevoAnexo
                    .pIdDocInterno = CType(Trim(IdAsiDocInt.Text), Integer)
                    .pNombreAnexo = nombre
                    .pRutaAnexo = rutaarchivo
                    .pActivo = "1"
                    .pIdUserR = Session("IdUser")  '----ToDo  : inserta iduser del usuario que accedio
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
            'ex.InnerException.ToString()
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
        If Not (IsPostBack) Then
            NuevoAnexo.pIdDocInterno = CType(Request.QueryString("id"), Integer)
            IdAsiDocInt.Text = CType(Request.QueryString("id"), Integer)
            CargarAnexos(NuevoAnexo.pIdDocInterno)
        End If
    End Sub
End Class
