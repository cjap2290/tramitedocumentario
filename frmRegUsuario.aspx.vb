
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
        Btn_BuscPers.Attributes.Add("onclick", "javascript:llamaBuscador();")
    End Sub

    Protected Sub Btn_BuscPers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_BuscPers.Click
        'sidpersona = Request.QueryString("idpersona")
    End Sub
End Class
