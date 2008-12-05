<%@ Page  Language="VB" AutoEventWireup="false" CodeFile="frmRemitirDocInt.aspx.vb" Inherits="frmRemitirDocInt"  UICulture="es" Culture= "es-PE"  MasterPageFile="~/mpInicio.master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="GridSelectCheckBox" Namespace="solCommon.Web.UI.DataGrid"  Assembly="ProjectAssembly" %>
 <%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body >    
    <form id="form1" runat="server">--%>
 <asp:content id="frmRemDocInt" ContentPlaceHolderId="SeccionContenidos" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <table style="width: 100%; height: 100%" >
            <tr>
                <td colspan="4" class="titlelogin">
                    AGREGAR REMITENTE(s) AL DOCUMENTO&nbsp;</td>                
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
                            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="text"></asp:Label></td>
                <td colspan="2">
                    &nbsp;<asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
<asp:DropDownList id="cboitemBusq" runat="server" AutoPostBack="True" __designer:wfdid="w7">
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
&nbsp;<asp:GridView id="gvItem" runat="server" GridLines="Horizontal" CellPadding="4" AutoGenerateColumns="False" AllowPaging="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
<FooterStyle BackColor="White" ForeColor="#333333"></FooterStyle>

<RowStyle BackColor="White" ForeColor="#333333"></RowStyle>

<SelectedRowStyle BackColor="#339966" ForeColor="White" Font-Bold="True"></SelectedRowStyle>

<PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center"></PagerStyle>

<HeaderStyle BackColor="#336666" ForeColor="White" Font-Bold="True"></HeaderStyle>
</asp:GridView> 
</ContentTemplate>
                            </asp:UpdatePanel>
                </td>
                
            </tr>
            <tr>
                <td colspan="4" style="height: 25px" class="text">
                    REMITENTES :</td>
            </tr>
            <tr>
                <td style="height: 62px" colspan="4">
                    &nbsp;<asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
<asp:ListBox id="lbRemitentes" runat="server" Height="162px" Width="447px" __designer:wfdid="w9"></asp:ListBox> 
</ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Button ID="Button5" runat="server" Text="Button" />
                    &nbsp;&nbsp;
                </td>
                
            </tr>
            <tr>
                <td style="height: 62px; width: 3px;">
                </td>
                <td style="height: 62px">
                </td>
                <td style="width: 85px; height: 62px">
                    </td>
                <td style="height: 62px">
                    <asp:Button ID="Button2" runat="server" Text="Button" />
                    <asp:Button ID="Button3" runat="server" Text="Button" /></td>
            </tr>
            <tr>
                <td style="height: 62px; width: 3px;">
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
    </asp:content>
   <%-- </form>
</body>
</html>--%>
