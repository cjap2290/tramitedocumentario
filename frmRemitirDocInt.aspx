<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmRemitirDocInt.aspx.vb" Inherits="frmRemitirDocInt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td colspan="4">
                    Agregar Remitente(s) al Documento&nbsp;</td>
                
            </tr>
            <tr>
                <td>
                    Elegir Tipo de Busqueda</td>
                <td>
                    <asp:DropDownList ID="cbotipBusq" runat="server">
                        <asp:ListItem Value="1">Por Area</asp:ListItem>
                        <asp:ListItem Value="2">Por Cargo</asp:ListItem>
                        <asp:ListItem>Por Agencia</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 85px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label" Width="177px"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="cboitemBusq" runat="server">
                    </asp:DropDownList></td>
                <td style="width: 85px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td style="width: 85px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan"
                        BorderWidth="1px" CellPadding="2" ForeColor="Black">
                        <FooterStyle BackColor="Tan" />
                        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                        <AlternatingItemStyle BackColor="PaleGoldenrod" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    </asp:DataList></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" /></td>
                <td colspan="2" style="width: 85px">
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox></td>
                
            </tr>
            <tr>
                <td style="height: 62px">
                </td>
                <td style="height: 62px">
                    <asp:Button ID="Button5" runat="server" Text="Button" /></td>
                <td colspan="2" style="height: 62px; width: 85px;">
                    <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox></td>
                
            </tr>
            <tr>
                <td style="height: 62px">
                </td>
                <td style="height: 62px">
                </td>
                <td style="width: 85px; height: 62px">
                    <asp:Button ID="Button3" runat="server" Text="Button" /></td>
                <td style="height: 62px">
                    <asp:Button ID="Button2" runat="server" Text="Button" /></td>
            </tr>
            <tr>
                <td style="height: 62px">
                </td>
                <td style="height: 62px">
                    <asp:Button ID="Button4" runat="server" Text="Button" /></td>
                <td style="width: 85px; height: 62px">
                </td>
                <td style="height: 62px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
