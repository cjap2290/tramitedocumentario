<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link href="style.css" rel="stylesheet" type="text/css" />
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td>
                </td>
                <td style="width: 3px">
                </td>
                <td>
                    <div style="width: 776px; height: 119px" class="barloginheader">
                        <table style="width: 280px">
                            <tr>
                                <td colspan="3" style="width: 424px; height: 111px" rowspan="2">
                                    &nbsp;
                                    <img src="Imagenes/LOGOTIPO%20LEON%20XIII.JPG" /></td>
                            </tr>
                            <tr class="text1">
                            </tr>
                        </table>
                    </div>
                    <div style="width: 774px; height: 42px" class="barloginheader2">
                        &nbsp; &nbsp;&nbsp;
                    TU CRECIMIENTO, NUESTRO COMPROMISO
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="width: 3px">
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="text-align: center; width: 3px;">
                </td>
                <td style="text-align: center" align="center">
                    <div id="alert" class="curved" >
                    <table style="width: 436px; height: 160px; text-align: center">
                        <tr>
                            <td align="left" colspan="3" style="font-family: 'Arial Black'; height: 34px">
                                <br />
                                Inicio de Sesión &nbsp;<br />
                                <hr />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 301px; height: 18px">
                                </td>
                            <td style="width: 116px; height: 18px">
                                </td>
                            <td style="width: 47px; height: 18px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 301px; height: 34px; color: green; font-family: Arial;">
                                Nombre de
                                Usuario</td>
                            <td style="width: 116px; height: 34px">
                                <asp:TextBox ID="txtUsuario" runat="server" MaxLength="6"></asp:TextBox></td>
                            <td style="width: 47px; height: 34px">
                                <asp:RequiredFieldValidator ID="rvUsuario" runat="server" ErrorMessage="*" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td style="width: 301px; height: 34px; color: green; font-family: Arial;">
                                Contraseña</td>
                            <td style="width: 116px; height: 34px">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                            <td style="width: 47px; height: 34px">
                                <asp:RequiredFieldValidator ID="rvContraseña" runat="server" ErrorMessage="*" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" /></td>
                        </tr>
                    </table>
                    </div>
                    <asp:Label ID="lblmensaje" runat="server" BackColor="#C0FFC0" ForeColor="Black" Height="65px"
                        Width="450px" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td style="height: 22px">
                </td>
                <td style="height: 22px; width: 3px;">
                </td>
                <td style="height: 22px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
