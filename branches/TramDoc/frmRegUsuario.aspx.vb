Imports CapaLogicaNegocio
Partial Class Default2
    Inherits System.Web.UI.Page

    'Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_BuscPers.Click
    'Dim popupScript As String = "<script language='JavaScript'>" & _
    '"window.open('PopUp.aspx', 'CustomPopUp', " & _
    '"'width=200, height=200, menubar=yes, resizable=no')" & _
    '"</script>"

    'End Sub
    Dim usuarios As New CapaLogicaNegocio.Usuarios
    Dim personal As New CapaLogicaNegocio.Personal
    Dim sIdpersona As String
    Dim sPersona As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim sIdPersona As String
        Btn_BuscPers.Attributes.Add("onclick", "javascript:llamaBuscador();")
        sPersona = Session.Item("IdPersona")
        If sPersona IsNot Nothing Then
            If personal.obtCargoPersonal(sPersona) Then
                txtIdPersona.Text = sPersona
                txtPersona.Text = personal.NombreCompleto
                txtCargo.Text = personal.NombreCargo
                txtArea.Text = personal.NombreArea
                txtAgencia.Text = personal.NombreAgencia
                'sPersona = Nothing
            End If
            'If personal.obtAreaPersonal(sPersona) Then
            '    txtArea.Text = personal.NombreArea
            'End If

        End If
        'sidpersona = Request.QueryString("variable")-- codigo usando query string
        '*******------------  Metodos utuilizados para pasar variables usando el postback()--*********
        '--Metodo 3 codigo par autilizar interface ifrmbuscador
        'Dim form As IFrmBuscador = TryCast(PreviousPage, IFrmBuscador)
        'If form IsNot Nothing Then
        '    'sIdPersona = txtidpersona.Text
        '    Dim sidpersona As String = form.IdPersona
        'End If
        '-- fin metodo 3
        '--metodo 2 codigo para utilizar interface ifrmbuscador
        'Dim txtidpersona As TextBox = CType(Page.PreviousPage.FindControl("txtselec"), TextBox)
        '-- fin metodo 2
        '*******-------------     FIN     -------------************************************
    End Sub

    'Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    '    sIdpersona = Request.QueryString("variable")
    '    txtIdPersona.Text = sIdpersona
    'End Sub
    Function A_obtCargo() As String
        Dim A_sIdCargo As String
        A_sIdCargo = usuarios.EC_obtIdCargo(txtIdPersona.Text)
        Return A_sIdCargo
    End Function

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If usuarios.activaUsuario(sIdpersona) Then

        End If
    End Sub
End Class
