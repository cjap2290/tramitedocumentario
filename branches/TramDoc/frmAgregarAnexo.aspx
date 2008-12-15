<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmAgregarAnexo.aspx.vb" Inherits="frmEnvioDoc" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <table style="width: 100%; height: 100%">
            <tr>
                <td colspan="3">
                </td>
            </tr>
            <tr>
                <td style="height: 11px">
                    Archivo de Anexo</td>
                <td colspan="2" style="height: 11px">
                    &nbsp;&nbsp;
                    <asp:UpdatePanel ID="upBuscarArchivo" runat="server">
                        <ContentTemplate>
                            &nbsp; &nbsp; &nbsp;&nbsp;
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:FileUpload ID="fuSubeAnexo" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 12px">
                    <asp:Button ID="btnAgregAnexo" runat="server" Text="Agregar Anexo a la Lista" Width="191px" />
                    <asp:UpdatePanel ID="upListaAnexo" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            &nbsp; &nbsp;
                            <asp:ListBox ID="lbAnexos" runat="server" Height="97px" Width="434px" AutoPostBack="True"></asp:ListBox><br />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Button ID="btnQuitarAnexo" runat="server" Text="Quitar Anexo de la Lista" /><br />
                    &nbsp; &nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td style="height: 12px">
                    Insertar Comentarios</td>
                <td style="height: 12px">
                    <asp:TextBox ID="txtObservaciones" runat="server" Height="130px" Width="318px" TextMode="MultiLine"></asp:TextBox></td>
                <td style="height: 12px; width: 5px;">
                </td>
            </tr>
            <tr>
                <td style="height: 8px">
                    Fecha Limite
                </td>
                <td style="height: 8px">
                    &nbsp;<asp:TextBox ID="txtFechaLimite" runat="server"></asp:TextBox></td>
                <td style="width: 5px; height: 8px">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" /><asp:Button ID="Button2" runat="server" Text="Cancelar" /></td>
                <td style="width: 5px">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td style="width: 5px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
