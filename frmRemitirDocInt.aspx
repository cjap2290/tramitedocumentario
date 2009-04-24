<%@ Page  Language="VB" AutoEventWireup="false" CodeFile="frmRemitirDocInt.aspx.vb" Inherits="frmRemitirDocInt"  UICulture="es" Culture= "es-PE"  MasterPageFile="~/mpInicio.master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
                <td colspan="2" style="height: 23px">
                    Tipo de Busqueda</td>
                <td colspan="2" style="height: 23px">
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
<asp:DropDownList id="cboitemBusq" runat="server" Width="152px" AutoPostBack="True"></asp:DropDownList> 
</ContentTemplate>
                            </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                </td>                
            </tr>
            <tr>
                <td colspan="4" align="center">
                    &nbsp; &nbsp; &nbsp;<asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
&nbsp;<asp:GridView id="gvItem" runat="server" GridLines="Horizontal" CellPadding="4" AutoGenerateColumns="False" AllowPaging="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
<FooterStyle BackColor="White" ForeColor="#333333" />
                        <RowStyle BackColor="White" ForeColor="#333333"  Font-Size="Small"  Font-Names="Times New Roman" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#84C225" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#84C225" Font-Bold="True" ForeColor="White"   />
</asp:GridView> 
</ContentTemplate>
                            </asp:UpdatePanel>
                </td>
                
            </tr>
            <tr>
                <td colspan="4" style="height: 25px" class="text">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="height: 62px" colspan="4">
                    &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
&nbsp;<asp:MultiView id="mvConCopia" runat="server" ActiveViewIndex="1">&nbsp; <asp:View id="vDestCC" runat="server">&nbsp; <asp:ListBox id="lbDestCC" runat="server" Height="160px" Width="438px">
                                        </asp:ListBox><BR /><asp:LinkButton id="LnkBtnRem" runat="server">Añadir Remitente
                                        </asp:LinkButton> </asp:View> <asp:View id="vRem" runat="server">REMITENTES : <BR /><asp:ListBox id="lbRemitentes" runat="server" Height="162px" Width="447px"></asp:ListBox> <asp:Button id="btnQuitarRem" runat="server" Text="Quitar Remitente de la Lista" OnClick="btnQuitarRem_Click"></asp:Button> <BR /><asp:LinkButton id="LnkBtnDestCC" runat="server">Añadir Destino "Con Copia"</asp:LinkButton></asp:View> </asp:MultiView> 
</ContentTemplate>
                    </asp:UpdatePanel>
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
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td style="width: 3px;">
                    <asp:TextBox ID="txtiddocint" runat="server" Visible="False"></asp:TextBox></td>
                <td>
                    </td>
                <td style="width: 85px;">
                </td>
                <td>
                <asp:Button ID="btnAceptar" runat="server" Text=" Siguiente >>" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>
            </tr>
            <tr>
                <td colspan="4" style="height: 62px">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </asp:content>
   <%-- </form>
</body>
</html>--%>
