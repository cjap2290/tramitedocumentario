Imports System.IO
Partial Class frmInsertaDocInt
    Inherits System.Web.UI.Page
    Dim docInt As New CapaLogicaNegocio.DocumentoInterno
    Private Sub GenerarArchivo()
        'Variables para abrir el archivo en modo de escritura
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        Try
            Dim RutaArchivo = "\\svrdesarrollo\PruebasYepo\prueba.txt"
            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(RutaArchivo)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)
            strStreamWriter.WriteLine(txtCuerpo.Text)
            strStreamWriter.Close()
            MsgBox("El archivo se generó con éxito")
        Catch ex As Exception
            strStreamWriter.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        docInt.EC_insertaDocInt(Me.txtNroDoc.Text, 1, "06", "01", "2004", Me.txtNroDoc.Text, " ", "1", "13/11/2008", "JeaCol")
        GenerarArchivo()
    End Sub
End Class
