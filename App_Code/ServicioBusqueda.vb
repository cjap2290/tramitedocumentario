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
    Public Function obtTipoBusq(ByVal knownCategoryValues As String, ByVal category As String) As CascadingDropDownNameValue()
        Dim values As New List(Of CascadingDropDownNameValue)()
        values.Add(New CascadingDropDownNameValue("Por Area", "".ToString()))
        values.Add(New CascadingDropDownNameValue("Por Cargo", "".ToString()))
        values.Add(New CascadingDropDownNameValue("Por Jefatura", "".ToString()))
        Return values.ToArray()
    End Function
    'Public Function obtEmpleadosxArea(ByVal knownCategoryValues As String, ByVal category As String) As CascadingDropDownNameValue()
    '    Dim usuxcarg As New CapaLogicaNegocio.vs_Personal_Usuario_PersonNat
    '    Dim dtEmp As DataTable
    '    Dim values As New List(Of CascadingDropDownNameValue)()
    '    dtEmp = usuxcarg.obtListaxArea
    '    For Each drEmp As DataRow In dtEmp.Rows
    '        Dim sEmp As String = drEmp("IdPersona").ToString()
    '        Dim iEmp As Integer = CType(drEmp("IDPersona"), Integer)
    '        values.Add(New CascadingDropDownNameValue(sEmp, iEmp.ToString()))
    '    Next

    'End Function


End Class
