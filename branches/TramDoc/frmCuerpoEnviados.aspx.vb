Imports System.IO
Imports CapaLogicaNegocio

Partial Class frmCuerpoEnviados
    Inherits System.Web.UI.Page
    Dim docint As New DocumentoInterno
    Dim buzoninterno As New BuzonInterno
    Dim NuevoAnexo As New Anexos
    Dim Asignacion As New AsignaDocInterno
    Dim tipodoc As New TipoDocumento
    Dim usuarios As New Usuarios
    Dim personnat As New PersonNat
    Dim personal As New Personal

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Try
                FCKeditor1.ToolbarSet = "Basic"
                FCKeditor1.ToolbarStartExpanded = False
                txtIdDocInt.Text = Request.QueryString("id")
                If buzoninterno.obtienebuzoninterno(txtIdDocInt.Text) Then
                    txtObservaciones.Text = buzoninterno.pObservaciones
                    txtFechaLimite.Text = buzoninterno.pFechaLimite
                    If Asignacion.obtieneAsignacionDocInt(buzoninterno.pIdAsignaDocInterno) Then
                        CargarAnexos(Asignacion.pIdDocInterno)
                        If docint.obtieneDocumentoInterno(Asignacion.pIdDocInterno) Then
                            lblasunto.Text = docint.pAsunto
                            lblfecha.Text = docint.pFechaR
                            If tipodoc.obtTipoDocumento(docint.pIdTipDocumento) Then
                                lbTipoDoc.Text = tipodoc.pDescripcion + " N° " + docint.pNroDocu
                            End If
                            If usuarios.obtIdpersona(Asignacion.pIdUser) Then
                                lblremitente.Text = personnat.ObtNombreCompleto(usuarios.pIdPersona)
                                If personal.obtCargoPersonal(usuarios.pIdPersona) Then
                                    lblCargo.Text = personal.NombreCargo + " DE " + personal.NombreArea
                                End If
                            End If
                        End If
                    End If
                End If
                RecuperarArchivo(CStr(Asignacion.pIdDocInterno))
                buzoninterno.actualizaEstado(txtIdDocInt.Text, 3)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub RecuperarArchivo(ByVal sIdDocInterno As String)
        'Variables para abrir el archivo en modo de escritura
        Dim lin As String
        lin = Nothing
        'ruta local
        'Dim RutaArchivo As String = "C:\TramiteDocumentario\DocumentoInterno\Documentos\"
        Dim RutaArchivo As String = "C:\" + sIdDocInterno + ".txt"
        'ruta de red
        'Dim RutaArchivo As String = "\\svrdesarrollo\PruebasYepo\prueba.txt"
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
        'MsgBox("El archivo se regeneró con éxito")
    End Sub
    Private Sub CargarAnexos(ByVal sIdDocInterno)
        If NuevoAnexo.obtenerAnexosActivo(sIdDocInterno) Then
            With lbAnexos
                .DataSource = NuevoAnexo.dtListaAnexoActivos.DefaultView
                .DataTextField = NuevoAnexo.dtListaAnexoActivos.Columns(2).ColumnName
                .DataValueField = NuevoAnexo.dtListaAnexoActivos.Columns(0).ColumnName
                .DataBind()
            End With
        End If
    End Sub
End Class
