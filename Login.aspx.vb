Imports System.Data
Imports System.Data.SqlClient
Imports BusinessLayer.SharedOpe
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports Microsoft.Practices.EnterpriseLibrary.Data.Sql
Imports CapaLogicaNegocio
Partial Class _Default
    Inherits System.Web.UI.Page
    'Dim BSLayer As New BusinessLayer.SharedOpe
    Dim BSLayer As New BusinessLayer.SharedOpe
    Dim nMaxInt As Integer
    Dim LoginOK As Boolean
    Dim xPass As String
    Dim dr As IDataReader = Nothing
    Dim mensaje As String
    Dim usuario As CapaLogicaNegocio.Usuarios
    Private decriptador As CEncriptador
    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Aceptar()
    End Sub
    Private Sub Aceptar()
        usuario = New Usuarios
        decriptador = New CEncriptador
        nMaxInt = 3
        Try
            Me.LoginOK = False
            nMaxInt = 3
            'If Trim(txtUsuario.Text) = "" Then
            '    'MessageBox.Show("Debe llenar el nombre de usuario ...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            'If Trim(txtPassword.Text) = "" Then
            '    'MessageBox.Show("La Clave del usuario no puede ser en blanco...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            '-- Verifica nuevamente --'
            'GetDatosUser(txtUsuario.Text)
            '-------------------------
            If usuario.obtIdpersona(txtUsuario.Text) Then
                If usuario.EC_cargaUsuario(usuario.pIdPersona) Then
                    If usuario.p_Activo = "0" Then
                    Else
                        xPass = decriptador.DecryptData(usuario.p_Password)
                    End If
                End If
            End If
            
            If CInt(usuario.p_Bloqueo) < nMaxInt Then
                If Trim(txtPassword.Text) = Trim(xPass) Then
                    Try
                        usuario.BloqueoUsuario(txtUsuario.Text, "0")
                        Me.LoginOK = True
                        '// todo : redireccionar hacia la pagina de indices
                        Session("IDUSER") = Trim(txtUsuario.Text)
                        Response.Redirect("Inicio.aspx?id=")
                        'Server.Transfer("Inicio.aspx")
                    Catch ex As Exception
                        lblmensaje.Text = "ERROR :" + ex.Message
                    End Try
                Else
                    If CInt(usuario.p_Bloqueo) < nMaxInt - 1 Then
                        Try
                            usuario.BloqueoUsuario(txtUsuario.Text, "1")
                            lblmensaje.Visible = True
                            lblmensaje.Text = "Acceso no permitido:   Clave de Usuario no válida..."
                            txtPassword.Text = ""

                        Catch ex As Exception
                            lblmensaje.Text = "SYSTEM ERROR : " + ex.Message
                        End Try
                    Else
                        Try
                            usuario.BloqueoUsuario(txtUsuario.Text, "2")
                            lblmensaje.Text = "Acceso no permitido  :Su cuenta ha sido bloqueada porque superó el máximo " + Space(10) + vbCrLf & _
                                    Space(16) + "número de intentos permitidos ..." + Space(10) + vbCrLf & _
                                   Space(8) + "Póngase en contacto con el Administrador del Sistema" + Space(10)
                            Me.LoginOK = False
                            'Me.Close()
                        Catch ex As Exception
                            lblmensaje.Text = "SYSTEM ERROR : " + ex.Message
                        End Try
                    End If
                End If
            Else
                lblmensaje.Text = "Acceso no permitido  :Su cuenta ha sido bloqueada porque superó el máximo " + Space(10) + vbCrLf & _
                                                    Space(16) + "número de intentos permitidos ..." + Space(10) + vbCrLf & _
                                                   Space(8) + "Póngase en contacto con el Administrador del Sistema" + Space(10)
                Me.LoginOK = False
                'Me.Close()
            End If
            'End While
            'dr = Nothing
            'FIN ACTUALIZACION JMLP --> 19/03/2007
        Catch ex As Exception
            lblmensaje.Text = "ERROR : " + ex.Message
        End Try
    End Sub

    Private Sub GetDatosUser(ByVal User As String)
        
        'Try
        'dr = BSLayer.GetDatosUser(User)
        'While dr.Read
        'If dr.Item("Activo").ToString = "0" Then
        'MessageBox.Show("El usuario esta desactivado..." + Space(10), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Me.LoginOK = False
        'Else
        'txtAgencia.Text = DR.Item("Agencia")
        'xPass = BSLayer.DecryptData(dr.Item("Clave"))
        'BSLayer.vIdAgencia = dr.Item("IdAgencia")
        'BSLayer.vIdArea = dr.Item("IdArea")
        'BSLayer.vIdCargo = dr.Item("IdCargo")
        'BSLayer.vAgencia = dr.Item("Agencia")
        'BSLayer.vArea = dr.Item("Area")
        'BSLayer.vCargo = dr.Item("Cargo")
        'BSLayer.vDirAgencia = dr.Item("Direccion")
        'BSLayer.vIdPersona = dr.Item("IdPersona")
        'BSLayer.vAgAbrev = Trim(dr.Item("Abrev"))
        'End If
        'End While
        'dr.Close()
        'dr = Nothing
        'Catch ex As Exception
        'dr = Nothing
        'mensaje = ex.Message
        'MessageBox.Show(ex.Message, "SIAF - Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End
        'End Try

    End Sub


    
    Protected Sub form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Load
        If IsPostBack Then

        End If
    End Sub
End Class
