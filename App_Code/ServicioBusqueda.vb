Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports AjaxControlToolkit
Imports CapaLogicaNegocio.vs_Personal_Usuario_PersonNat
Imports System.Collections.Generic

<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class ServicioBusqueda
    Inherits System.Web.Services.WebService

    <WebMethod()> _
     Public Function obtEmpleados(ByVal knownCategoryValues As String, ByVal category As String) As CascadingDropDownNameValue()}
        Dim dtEmp As DataTable
        Dim values As New List(Of CascadingDropDownNameValue)()
    End Function


End Class
