
Partial Class DesactUsu
    Inherits System.Web.UI.Page
    Dim sPersona As String
    Dim usuarios As New CapaLogicaNegocio.Usuarios
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnBuscador.Attributes.Add("onclick", "javascript:llamaBuscador();")
        sPersona = Session.Item("IdPersona")
        If sPersona IsNot Nothing Then
            If usuarios.EC_cargaUsuario(sPersona) Then
                txtIdUser.Value = usuarios.obtIdUser
                txtFecIni.Value = usuarios.obtFecIni
                txtFecFin.Value = usuarios.obtFecFin
                txtNivelAcceso.Value = usuarios.obtNomNivAcceso
            End If
        End If
    End Sub
   
End Class
