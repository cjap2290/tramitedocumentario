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
                <td colspan="2">
                </td>
                <td colspan="2">
                    &nbsp;<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                <asp:DropDownList ID="cbotipBusq" runat="server" AutoPostBack="True" Width="295px">
                                <asp:ListItem Value="1">Por Area</asp:ListItem>
                                <asp:ListItem Value="2">PorCargo</asp:ListItem>
                    </asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>                
            </tr>
            <tr>
                <td colspan="2">
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                <td colspan="2">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:DropDownList ID="cboitemBusq" runat="server"   AutoPostBack="True">
                            </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                </td>                
            </tr>
            <tr>
                <td colspan="4">
                    &nbsp; &nbsp; &nbsp;<asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    &nbsp;<asp:GridView ID="gvItem" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                        <EditRowStyle BackColor="#999999" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    </asp:GridView>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                </td>
                
            </tr>
            <tr>
                <td style="height: 62px">
                </td>
                <td style="height: 62px">
                    <asp:Button ID="Button5" runat="server" Text="Button" /></td>
                <td colspan="2" style="height: 62px; width: 85px;">
                    &nbsp;
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                    <asp:ListBox ID="lbRemitentes" runat="server" Height="162px" Width="224px"></asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                
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
