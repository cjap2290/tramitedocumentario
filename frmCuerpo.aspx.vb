Imports System.IO

Partial Class frmCuerpo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            FCKeditor1.ToolbarSet = "Basic"
            FCKeditor1.ToolbarStartExpanded = False
            RecuperarArchivo()
        End If
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
