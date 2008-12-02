<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmRemitirDocInt.aspx.vb" Inherits="frmRemitirDocInt" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body >    
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td colspan="4">
                    Agregar Remitente(s) al Documento&nbsp;</td>
                
            </tr>
            <tr>
                <td colspan="2" rowspan="3">
                    &nbsp;
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate  >
                    Elegir tipo de Busqueda:<asp:DropDownList ID="cbotipBusq" runat="server" AutoPostBack="True" Width="295px">
                                <asp:ListItem Value="1">a</asp:ListItem>
                                <asp:ListItem Value="2">b</asp:ListItem>
                    </asp:DropDownList><br />
                            &nbsp; &nbsp;
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>&nbsp;<br />
                            <br />
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:DropDownList ID="cboitemBusq" runat="server"   AutoPostBack="True">
                            </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <br />
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    ikikk
                                    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                        <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                        <AlternatingItemStyle BackColor="Gainsboro" />
                                        <ItemStyle BackColor="#EEEEEE" ForeColor="Black" />
                                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                        <ItemTemplate>
                                            &nbsp;<asp:Label ID="Label3" runat="server" Text='<%# bind("ApeMat") %>'></asp:Label>
                                        </ItemTemplate>
                                        <SelectedItemTemplate>
                                            &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" Text='<%# bind("ApeMat") %>'></asp:LinkButton>
                                        </SelectedItemTemplate>
                                    </asp:DataList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            &nbsp; &nbsp; &nbsp;
                        </ContentTemplate>                        
                    </asp:UpdatePanel> &nbsp;&nbsp;
                </td>
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
            </tr>
            <tr>
                <td style="width: 85px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
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
