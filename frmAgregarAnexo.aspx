<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmAgregarAnexo.aspx.vb" Inherits="frmEnvioDoc" %>

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
                <td colspan="3">
                </td>
            </tr>
            <tr>
                <td style="height: 17px">
                    Archivo de Anexo</td>
                <td colspan="2" style="height: 17px">
                    <asp:FileUpload ID="fuSubeAnexo" runat="server" /></td>
            </tr>
            <tr>
                <td style="height: 12px">
                    Insertar Comentarios</td>
                <td style="height: 12px">
                    <asp:TextBox ID="TextBox1" runat="server" Height="130px" Width="318px"></asp:TextBox></td>
                <td style="height: 12px">
                </td>
            </tr>
            <tr>
                <td style="height: 12px">
                    Fecha Limite
                </td>
                <td style="height: 12px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                <td style="height: 12px">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                    <asp:Button ID="Button2" runat="server" Text="Cancelar" /></td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
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
                <td>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
