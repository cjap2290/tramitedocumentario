Imports System.IO
Imports System.Web.UI.HtmlControls
Imports CapaLogicaNegocio
Imports System.Diagnostics
Partial Class frmInsertaDocInt
    Inherits System.Web.UI.Page
    Dim docInt As New CapaLogicaNegocio.DocumentoInterno
    Dim tipdoc As New CapaLogicaNegocio.TipoDocumento
    Dim asignacion As New AsignaDocInterno
    Dim usuario As New Usuarios
    Dim personal As New Personal
    ' Creates the text file that the trace listener will write to.
    'Dim myTraceLog As New System.IO.FileStream("C:\myTraceLog.txt", _
    '   IO.FileMode.OpenOrCreate)
    '' Creates the new trace listener
    'Dim myListener As New TextWriterTraceListener(myTraceLog)


    Private Sub GenerarArchivo()
        'Variables para abrir el archivo en modo de escritura

        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        Try
            'ruta local
            'Dim RutaArchivo As String = "C:\TramiteDocumentario\DocumentosInternos\Documentos"
            Dim RutaArchivo As String = "C:\" + docInt.IdInsertado.ToString + ".txt"
            'ruta de red
            'Dim RutaArchivo As String = "\\svrdesarrollo\PruebasYepo\prueba.txt"
            'Se abre el archivo y si este no existe se crea
            '------------------------------------------------------
            strStreamW = File.OpenWrite(RutaArchivo)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)
            strStreamWriter.WriteLine(HttpUtility.HtmlEncode(FCKeditor1.Value))
            strStreamWriter.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'strStreamW.Close()
        End Try
    End Sub

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sArea As String
        Dim sIdAgencia As String

        Try
            If usuario.obtIdpersona(Session("IDUSER")) Then
                If personal.obtPersonal(usuario.pIdPersona) Then
                    sArea = personal.p_Area
                    sIdAgencia = personal.p_IdAgencia
                    With docInt
                        .pIdTipDocumento = cboTipDoc.SelectedValue
                        .pNroDocu = txtNroDoc.Text
                        .pIdTipDocumento = 1
                        .pIdArea = sArea
                        .pIdAgencia = sIdAgencia
                        .pPeriodo = "2004"
                        .pAsunto = Me.txtAsunto.Text
                        .pEncabezado = ""
                        .pPrioridad = "1"
                        .pFechaR = "13/03/2009" 'DateTime.Now().Date.ToString
                        .pIdUserR = Session("iduser")
                        .EC_insertaDocInt(False)
                    End With
                    GenerarArchivo()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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
                'RecuperarArchivo()
            End If
        End If
    End Sub

    Protected Sub btnAsignar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Dim sArea As String
        Dim sIdAgencia As String
        Dim surl As String = "frmRemitirDocInt.aspx?id="
        Try
            If usuario.obtIdpersona(Session("IDUSER")) Then
                If personal.obtPersonal(usuario.pIdPersona) Then
                    sArea = personal.p_Area
                    sIdAgencia = personal.p_IdAgencia
                    With docInt
                        .pNroDocu = txtNroDoc.Text
                        .pIdTipDocumento = 1
                        .pIdArea = sArea
                        .pIdAgencia = sIdAgencia
                        .pPeriodo = DateTime.Now().Year.ToString
                        .pAsunto = Me.txtAsunto.Text
                        .pEncabezado = ""
                        .pPrioridad = "1"
                        .pFechaR = DateTime.Now().Date.ToString
                        .pIdUserR = Session("IDUSER")
                        .pIdestDoc = 1
                        '.pAsiDocInt_Condicion = "18"
                        '.pAsiDocInt_IdEstAsigDoc = "3"
                        '.pAsiDocInt_IdUser = Session("IDUSER")
                        .EC_insertaDocInt(True)
                        surl = surl + CType(.IdInsertado, String)
                    End With
                    With asignacion
                        .pIdDocInterno = docInt.IdInsertado
                        .pCondicion = "1"
                        .pIdEstAsigDoc = 1
                        .pIdUserR = Session("IDUSER")
                        .pIdUser = Session("IDUSER")
                        .pFechaR = DateTime.Now().Date.ToString
                        .EC_insertaAigDocInt()
                    End With
                    GenerarArchivo()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Response.Redirect(surl)
        End Try

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
