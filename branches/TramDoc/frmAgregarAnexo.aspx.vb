Imports System.IO
Imports CapaLogicaNegocio

Partial Class frmEnvioDoc
    Inherits System.Web.UI.Page

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        '// Actualizar documento intenro
        '// Registrar buzon interno

    End Sub

    Protected Sub btnAgregAnexo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregAnexo.Click
        Dim NuevoAnexo As New Anexos
        'Dim itemlbanexos As ListItem       
        Try
            If Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName) <> "" Then
                Dim nombre As String = Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName)
                Dim rutaarchivo = "\\svrdesarrollo\PruebasYepo\" & Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName)
                '// Guardar Anexo  
                With NuevoAnexo
                    .pIdDocInterno = 5 '--- ToDo : insertar codigo correcto
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
                'itemlbanexos.Text = nombre
                'itemlbanexos.Value
                If NuevoAnexo.obtenerAnexosActivo(NuevoAnexo.pIdDocInterno) Then
                    Me.lbAnexos.DataSource = NuevoAnexo.dtListaAnexoActivos.DefaultView
                    lbAnexos.DataTextField = NuevoAnexo.dtListaAnexoActivos.Columns(2).ColumnName
                    lbAnexos.DataValueField = NuevoAnexo.dtListaAnexoActivos.Columns(0).ColumnName
                    upListaAnexo.Update()
                    lbAnexos.DataBind()
                End If
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
       

       
    End Sub

    Protected Sub btnQuitarAnexo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuitarAnexo.Click

        lbAnexos.Items(lbAnexos.SelectedIndex).Value
        'lbAnexos.Items.RemoveAt(lbAnexos.SelectedIndex)
    End Sub
End Class
