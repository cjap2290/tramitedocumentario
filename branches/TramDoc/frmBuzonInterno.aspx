<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmBuzonInterno.aspx.vb" Inherits="frmBuzonInterno" masterpagefile="~/mpInicio.master"  %>

<%-- <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">--%>
<asp:content id="BuzonInterno" ContentPlaceHolderId="SeccionContenidos" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td style="width: 15%">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
                <td style="width: 67px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 15%; height: 116px">
                    Ordenar por &nbsp;&nbsp; : &nbsp;&nbsp;
                </td>
                <td style="width: 67px; height: 116px;">
                    &nbsp;<asp:UpdatePanel ID="upTipo" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                    <asp:DropDownList ID="cboTipo" runat="server" AutoPostBack="True" Width="147px" OnSelectedIndexChanged="cboTipo_SelectedIndexChanged">
                        <asp:ListItem Value="0">Mostrar Todos</asp:ListItem>
                        <asp:ListItem Value="1">Tipo de Documento</asp:ListItem>
                        <asp:ListItem Value="2">Prioridad</asp:ListItem>
                        <asp:ListItem Value="3">Area</asp:ListItem>
                        <asp:ListItem Value="4">Cargo</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtIdBuzon" runat="server" Visible="False"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td style="height: 116px">
                </td>
            </tr>
            <tr>
                <td style="width: 15%">
                    Escoger :</td>
                <td style="width: 67px">
                    &nbsp;<asp:UpdatePanel ID="upItem" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:DropDownList ID="cboItem" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboItem_SelectedIndexChanged"
                                Width="224px">
                            </asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:UpdatePanel ID="upBuzon" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                    <asp:GridView ID="gvBuzon" runat="server" BackColor="White" BorderColor="#336666"
                        BorderStyle="Double" BorderWidth="3px" CellPadding="1" GridLines="Horizontal"
                        Height="199px" Width="879px" AutoGenerateColumns="False" AllowPaging="True">
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <RowStyle BackColor="White" ForeColor="#333333"  Font-Size="Small"  Font-Names="Times New Roman" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#84C225" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#84C225" Font-Bold="True" ForeColor="White"  Height="25px"  />
                    </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    &nbsp;<br />
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                </td>
            </tr>
            <tr>
                <td style="width: 15%">
                    </td>
                <td style="width: 67px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="height: 25px; width: 15%;">
                </td>
                <td style="width: 67px; height: 25px">
                </td>
                <td style="height: 25px">
                </td>
            </tr>
            <tr>
                <td style="width: 15%">
                </td>
                <td style="width: 67px">
                </td>
                <td>
                </td>
            </tr>
        </table>
    
    </div>
 </asp:content>
 <%--    </form>
</body>
</html> --%>
