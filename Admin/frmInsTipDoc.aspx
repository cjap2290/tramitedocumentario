<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmInsTipDoc.aspx.vb" Inherits="frmInsTipDoc"  MasterPageFile="~/mpInicio.master"%>

<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>--%>
<asp:content id="InsTipDoc" ContentPlaceHolderId="SeccionContenidos" runat="server">
    <%--<form id="form1" runat="server">--%>
    <div class="body#body">
        <table style="width: 100%; height: 100%">
            <tr>
                <td>
                    Nombre del Tipo de Documento :</td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
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
                <td style="height: 126px" colspan="2">
                    <asp:GridView ID="gvTipDoc" runat="server">
                    </asp:GridView>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" PostBackUrl="~/frmMensajeResultado.aspx"
                        Text="Button" /></td>
                <td>
                </td>
            </tr>
        </table>
    
    </div>
    <%--</form>--%>
</asp:content>
<%--</body>
</html>--%>
