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
                    Buscar Personal : <br />
                    <hr id="HR2" style="height: 2px; width: 663px;" />
                 </td>              
            </tr>
            <tr>
                <td style="width: 15%">
                    <asp:DropDownList ID="cboOpcion" runat="server" Width="157px">
                        <asp:ListItem>Apellidos y Nombres</asp:ListItem>
                    </asp:DropDownList></td>
                <td colspan = "5" style="width: 85%">
                    <asp:TextBox ID="TextBox1" runat="server" Width="545px"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td colspan="6" style="width: 100%">
                    <asp:GridView ID="gdListado" runat="server" AllowPaging="True">
                        <Columns>
                            <asp:BoundField />
                        </Columns>
                    </asp:GridView>
                </td>                
            </tr>
            <tr>
                <td style="height: 56px; width: 67px;">
                </td>
                <td style="width: 272px; height: 56px;">
                    <asp:Button ID="Button1" runat="server" Text="Button" /></td>
                <td style="width: 18px; height: 56px;">
                </td>
                <td style="width: 27px; height: 56px;">
                </td>
                <td style="width: 101px; height: 56px;">
                </td>
                <td style="width: 17px; height: 56px;">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
