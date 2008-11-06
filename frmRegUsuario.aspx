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
                            <td colspan="2">
                                Información 
                             </td>                           
                        </tr>
                        <tr>
                            <td style="width: 194px">
                                Personal :
                                <asp:TextBox ID="txtIdPersona" runat="server" Width="92px"></asp:TextBox>
                                <asp:Button ID="Btn_BuscPers" runat="server" Text="..." /></td>
                            <td style="width: 136px">
                                &nbsp;<asp:TextBox ID="txtPersona" runat="server" Width="273px"></asp:TextBox></td>
                        </tr>
                    </table>
                </td>                
            </tr>
            <tr>                
                <td  colspan="2" >
                    <table style="width: 100%; height: 100%">
                        <tr>
                            <td colspan="3" style="height: 21px">
                            Datos del Personal 
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 73px; height: 26px;">
                                Area:</td>
                            <td colspan="2" style="height: 26px">
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
                <td colspan="2">
                    Ingrese Datos de Usuario :</td>
            </tr>
            <tr>
                <td colspan="2" style="height: 26px">
                    <table style="width: 100% ; height: 100%">
                        <tr>
                            <td style="width: 268px">
                                Id Usuario &nbsp;&nbsp; :
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                            <td style="width: 188px">
                                Clave &nbsp; &nbsp; &nbsp;&nbsp; :
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 268px">
                                Fecha Inicio :<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                            <td style="width: 188px">
                                Fecha Fin&nbsp; :
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 268px">
                                Nivel de Acceso &nbsp; :&nbsp;
                                <asp:DropDownList ID="DropDownList1" runat="server" Width="116px">
                                </asp:DropDownList></td>
                            <td style="width: 188px">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 26px">
                </td>
            </tr>
            <tr>                
                <td style="width: 405px; text-align: right; height: 21px;">
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" Width="84px" /></td>
                <td style="width: 47px; text-align: center; height: 21px;">
                    <asp:Button ID="btnSalir" runat="server" Text="Salir" Width="84px" />&nbsp;&nbsp;
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
