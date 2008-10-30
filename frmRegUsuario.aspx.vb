
Partial Class Default2
    Inherits System.Web.UI.Page

    'Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_BuscPers.Click
    'Dim popupScript As String = "<script language='JavaScript'>" & _
    '"window.open('PopUp.aspx', 'CustomPopUp', " & _
    '"'width=200, height=200, menubar=yes, resizable=no')" & _
    '"</script>"

    'End Sub
    Dim sidpersona As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim sIdPersona As String
        Btn_BuscPers.Attributes.Add("onclick", "javascript:llamaBuscador();")
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

    Protected Sub Btn_BuscPers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_BuscPers.Click

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        sidpersona = Request.QueryString("variable")
        txtIdPersona.Text = sidpersona
    End Sub
End Class
