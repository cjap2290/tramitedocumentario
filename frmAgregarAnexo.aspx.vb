Imports System.IO
Partial Class frmEnvioDoc
    Inherits System.Web.UI.Page

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim rutaarchivo = "\\svrdesarrollo\PruebasYepo\" & Path.GetFileName(Me.fuSubeAnexo.PostedFile.FileName)
        fuSubeAnexo.PostedFile.SaveAs(rutaarchivo)

    End Sub
End Class
