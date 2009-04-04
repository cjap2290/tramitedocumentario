<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmInsertaDocInt.aspx.vb" Inherits="frmInsertaDocInt" MasterPageFile="~/mpInicio.master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">--%>
 <asp:content id="InsDocInt" ContentPlaceHolderId="SeccionContenidos" runat="server">
     <asp:ScriptManager id="ScriptManagerInsDocInt" runat="server">
     </asp:ScriptManager>
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td class="titform" colspan="2" style="width: 400px; height: 29px">
                    Registro de Documento Interno</td>
            </tr>
            <tr>
                <td class="lblform" style="width: 135px; height: 6px; text-align: right;">
                    Tipo de Documento</td>
                <td style="height: 6px">
                    <asp:DropDownList ID="cboTipDoc" runat="server" Width="154px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td class="lblform" style="width: 135px; height: 14px; text-align: right;">
                    Nro. Documento</td>
                <td style="height: 14px; text-align: left;">
                    <asp:TextBox ID="txtNroDoc" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="lblform" style="width: 135px; text-align: right;">
                    De
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtRemitente" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="lblform" style="width: 135px; height: 25px; text-align: right;">
                    Asunto</td>
                <td style="height: 25px; text-align: left;">
                    <asp:TextBox ID="txtAsunto" runat="server" Width="435px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="lblform" style="width: 135px; text-align: right;">
                    Fecha</td>
                <td>                    
                    <asp:TextBox ID="txtfecha" runat="server" Width="79px"></asp:TextBox>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/calendar.gif" />
                       <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtfecha" PopupButtonID="Image1">
                </cc1:CalendarExtender>
            <tr>
                <td class="lblform" align="left" colspan="2" style="height: 11px">
                    Cuerpo :</td>
            </tr>
            <tr>
                <td colspan="2" align="center" style="height: 544px">
                    <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" BasePath="~/fckeditor/" Height="500px">
                    </FCKeditorV2:FCKeditor>
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox></td>             
            </tr>
            <tr>
                <td align="left" style="width: 135px" >
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar Borrador" /></td>
                <td align="right">
                    <asp:Button ID="btnAsignar" runat="server" Text="Siguiente" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /></td>                
            </tr>
        </table>    
    </div>
   </asp:content>
<%--    </form>
</body>
</html>--%>
