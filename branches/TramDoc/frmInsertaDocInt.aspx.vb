Imports System.IO
Partial Class frmInsertaDocInt
    Inherits System.Web.UI.Page
    Dim docInt As New CapaLogicaNegocio.DocumentoInterno
    Dim tipdoc As New CapaLogicaNegocio.TipoDocumento
    Private Sub GenerarArchivo()
        'Variables para abrir el archivo en modo de escritura
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        'Try
        Dim RutaArchivo As String = "\\svrdesarrollo\PruebasYepo\prueba.txt"
        'Se abre el archivo y si este no existe se crea
        strStreamW = File.OpenWrite(RutaArchivo)
        strStreamWriter = New StreamWriter(strStreamW, _
                            System.Text.Encoding.UTF8)
        strStreamWriter.WriteLine(txtCuerpo.Text)
        'strStreamWriter.Close()
        MsgBox("El archivo se generó con éxito")
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'Finally
        strStreamWriter.Close()
        'End Try
    End Sub

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        With docInt
            .pNroDocu = txtNroDoc.Text
            .pIdTipDocumento = 1
            .pIdArea = "06"
            .pIdAgencia = "01"
            .pPeriodo = "2004"
            .pAsunto = Me.txtAsunto.Text
            .pEncabezado = ""
            .pPrioridad = "1"
            .pFechaR = DateTime.Now().Date.ToString
            .pIdUserR = "JeaCol"
            .EC_insertaDocInt(False)
        End With
        GenerarArchivo()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If tipdoc.EC_ListarDocMenosReq Then
            cboTipDoc.DataSource = tipdoc.lsTipoDoc.DefaultView
            cboTipDoc.DataTextField = tipdoc.lsTipoDoc.Columns(1).ColumnName
            cboTipDoc.DataValueField = tipdoc.lsTipoDoc.Columns(0).ColumnName
            cboTipDoc.DataBind()
        End If
    End Sub

    Protected Sub btnAsignar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        With docInt
            .pNroDocu = txtNroDoc.Text
            .pIdTipDocumento = 1
            .pIdArea = "06"
            .pIdAgencia = "01"
            .pPeriodo = "2004"
            .pAsunto = Me.txtAsunto.Text
            .pEncabezado = ""
            .pPrioridad = "1"
            .pFechaR = "13/11/2008"
            .pIdUserR = "JeaCol"
            .pAsiDocInt_Condicion = "18"
            .pAsiDocInt_IdEstAsigDoc = "12"
            .pAsiDocInt_IdUser = "JeaCol"
            .EC_insertaDocInt(True)
        End With
        GenerarArchivo()
    End Sub
End Class
