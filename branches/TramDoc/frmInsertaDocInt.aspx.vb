Imports System.IO
Imports System.Web.UI.HtmlControls
Partial Class frmInsertaDocInt
    Inherits System.Web.UI.Page
    Dim docInt As New CapaLogicaNegocio.DocumentoInterno
    Dim tipdoc As New CapaLogicaNegocio.TipoDocumento
    Private Sub GenerarArchivo()
        'Variables para abrir el archivo en modo de escritura
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        Try
            'ruta local
            'Dim RutaArchivo As String = "D:\prueba.txt"
            'ruta de red
            Dim RutaArchivo As String = "\\svrdesarrollo\PruebasYepo\prueba.txt"
            'Se abre el archivo y si este no existe se crea
            '------------------------------------------------------
            strStreamW = File.OpenWrite(RutaArchivo)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)
            strStreamWriter.WriteLine(HttpUtility.HtmlEncode(FCKeditor1.Value))
            strStreamWriter.Close()
            MsgBox("El archivo se generó con éxito")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'strStreamW.Close()
        End Try
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
        If Not IsPostBack Then
            If tipdoc.EC_ListarDocMenosReq Then
                cboTipDoc.DataSource = tipdoc.lsTipoDoc.DefaultView
                cboTipDoc.DataTextField = tipdoc.lsTipoDoc.Columns(1).ColumnName
                cboTipDoc.DataValueField = tipdoc.lsTipoDoc.Columns(0).ColumnName
                cboTipDoc.DataBind()
                'Dim a As String
                Me.FCKeditor1.ToolbarSet = "Documento"
                RecuperarArchivo()
            End If
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
            .pAsiDocInt_IdEstAsigDoc = "1"
            .pAsiDocInt_IdUser = "JeaCol"
            .EC_insertaDocInt(True)
        End With
        'GenerarArchivo()
    End Sub
    Private Sub RecuperarArchivo()
        'Variables para abrir el archivo en modo de escritura
        Dim lin As String
        lin = Nothing
        'ruta local
        'Dim RutaArchivo As String = "D:\prueba.txt"
        'ruta de red
        Dim RutaArchivo As String = "\\svrdesarrollo\PruebasYepo\prueba.txt"
        '-------------------------------------------------------
        'Se abre el archivo y si este no existe se crea
        '------------------------------------------------------
        Dim sr As StreamReader = New StreamReader(RutaArchivo)

        Do While sr.Peek() >= 0
            lin = lin + sr.ReadLine()
        Loop
        sr.Close()
        FCKeditor1.Value = HttpUtility.HtmlDecode(lin)
        sr.Close()
        MsgBox("El archivo se regeneró con éxito")
    End Sub
End Class
