<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DesactUsu.aspx.vb" Inherits="DesactUsu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
    <script language="javascript" type="text/javascript">
    // <!CDATA[
    function llamaBuscador()
    {
      aPopUp= window.open('frmBuscador.aspx','popupBuscaPers','scrollbars=yes,width=600,height=400');
    }
    // ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <input id="Text1" type="text" />
                    <asp:Button ID="btnBuscador" runat="server" Text="..." /></td>
                <td>
                    <input id="Text2" style="width: 277px" type="text" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <table style="width: 100%; height: 100%">
                        <tr>                           
                            <td colspan="4">
                                Datos del Usuario</td>                            
                        </tr>
                        <tr>
                            <td>
                                Login</td>
                            <td>
                                <input id="Text3" type="text" /></td>
                            <td>
                                Fecha Inicio</td>
                            <td>
                                <input id="Text5" type="text" /></td>
                        </tr>
                        <tr>
                            <td>
                                Nivel de Acceso</td>
                            <td>
                                <input id="Text4" type="text" /></td>
                            <td>
                                Fecha Fin</td>
                            <td>
                                <input id="Text6" type="text" /></td>
                        </tr>
                    </table>
                </td>
                
            </tr>
            <tr>
                <td style="height: 52px" align="center">
                    <asp:Button ID="Button2" runat="server" Text="Button" /></td>
                <td style="height: 52px" align="center">
                    <asp:Button ID="Button3" runat="server" Text="Button" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
