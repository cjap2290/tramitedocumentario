﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmInsertaDocInt.aspx.vb" Inherits="frmInsertaDocInt" MasterPageFile="~/mpInicio.master" %>

<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">--%>
 <asp:content id="InsDocInt" ContentPlaceHolderId="SeccionContenidos" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td colspan="2" style="width: 59px; height: 29px">
                </td>
            </tr>
            <tr>
                <td  colspan="2" style="width: 59px; height: 29px; text-align: center;">
                    Registro de Documento Interno</td>                
            </tr>
            <tr>
                <td colspan="2" style="width: 59px; height: 29px">
                </td>
            </tr>
            <tr>
                <td style="width: 59px; height: 6px; text-align: right;">
                    Tipo de Documento</td>
                <td style="height: 6px">
                    <asp:DropDownList ID="cboTipDoc" runat="server" Width="154px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 59px; height: 14px; text-align: right;">
                    Nro. Documento</td>
                <td style="height: 14px; text-align: left;">
                    <asp:TextBox ID="txtNroDoc" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 59px; text-align: right;">
                    De
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtRemitente" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 59px; height: 25px; text-align: right;">
                    Asunto</td>
                <td style="height: 25px; text-align: left;">
                    <asp:TextBox ID="txtAsunto" runat="server" Width="435px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 59px; text-align: right;">
                    Fecha</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="left" colspan="2">
                    Cuerpo :</td>
            </tr>
            <tr>
                <td colspan="2" align="center" style="height: 161px">
                    <asp:TextBox ID="txtCuerpo" runat="server" Height="128px" Width="697px" TextMode="MultiLine"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td align="left" style="width: 59px" >
                    &nbsp;
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
