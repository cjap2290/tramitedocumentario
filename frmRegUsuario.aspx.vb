
Partial Class Default2
    Inherits System.Web.UI.Page
    
    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim popupScript As String = "<script language='JavaScript'>" & _
        "window.open('PopUp.aspx', 'CustomPopUp', " & _
        "'width=200, height=200, menubar=yes, resizable=no')" & _
        "</script>"

    End Sub
End Class
