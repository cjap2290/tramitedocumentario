<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmBuscador.aspx.vb" Inherits="frmBuscador" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="frmBuscador" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td colspan="6" style="height: 6px">
                    Buscar Por : <br />
                    <hr id="HR2" style="height: 2px; width: 474px;" />
                 </td>              
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList></td>
                <td colspan = "5" style="width: 70%">
                </td>
                
            </tr>
            <tr>
                <td colspan="6" style="width: 100%">
                </td>                
            </tr>
            <tr>
                <td style="height: 64px">
                </td>
                <td style="width: 272px; height: 64px;">
                </td>
                <td style="width: 18px; height: 64px;">
                </td>
                <td style="width: 27px; height: 64px;">
                </td>
                <td style="width: 101px; height: 64px;">
                </td>
                <td style="width: 17px; height: 64px;">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
