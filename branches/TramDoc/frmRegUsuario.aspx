<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmRegUsuario.aspx.vb" Inherits="Default2"  %>

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
    <form id="frmRegUsu" runat="server">
    <div>
        &nbsp;</div>
        <table style="width: 100%; height: 100%">
            <tr >  
                <td colspan="2">
                    <table style="width: 100%; height: 100%">
                        <tr>
                            <td colspan="3">
                                Información <br />
                                <hr id="HR2" style="height: 2px" />
                             </td>                           
                        </tr>
                        <tr>
                            <td style="width: 96px">
                                Personal :</td>
                            <td style="width: 136px">
                                <asp:TextBox ID="txtIdPersona" runat="server" Width="92px"></asp:TextBox>
                                <asp:Button ID="Btn_BuscPers" runat="server" Text="..." /></td>
                            <td style="width: 116px; text-align: center;">
                                &nbsp;<asp:TextBox ID="txtPersona" runat="server" Width="273px"></asp:TextBox></td>
                        </tr>
                    </table>
                </td>                
            </tr>
            <tr>                
                <td  colspan="2" >
                    <table style="width: 100%; height: 100%">
                        <tr>
                            <td colspan="3">
                            Datos del Personal <br />
                            <hr id="HR1" style="height: 2px" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 73px">
                                Area:</td>
                            <td colspan="2">
                                <asp:TextBox ID="txtArea" runat="server" Width="402px"></asp:TextBox></td>                            
                        </tr>
                        <tr>
                            <td style="width: 73px">
                                Cargo:</td>
                            <td colspan="2">
                                <asp:TextBox ID="txtCargo" runat="server" Width="403px"></asp:TextBox></td>  
                        </tr>
                        <tr>
                            <td style="width: 73px">
                                Agencia</td>
                            <td colspan="2">
                                <asp:TextBox ID="txtAgencia" runat="server" Width="402px"></asp:TextBox></td> 
                        </tr>
                    </table>
                </td>
                
            </tr>
            <tr>                
                <td style="width: 405px; text-align: right; height: 21px;">
                    <asp:Button ID="Button2" runat="server" Text="Button" Width="84px" /></td>
                <td style="width: 47px; text-align: center; height: 21px;">
                    <asp:Button ID="Button1" runat="server" Text="Button" Width="84px" />&nbsp;&nbsp;
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
