﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="_Default" %>

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
                <td style="text-align: center">
                </td>
                <td style="text-align: center">
                    <table style="width: 286px; height: 168px; text-align: center">
                        <tr>
                            <td style="width: 109px; height: 34px">
                            </td>
                            <td style="width: 116px; height: 34px">
                                Inicio de Sesión</td>
                            <td style="width: 47px; height: 34px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 109px; height: 34px">
                                Agencia</td>
                            <td style="width: 116px; height: 34px">
                                <asp:TextBox ID="txtAgencia" runat="server"></asp:TextBox></td>
                            <td style="width: 47px; height: 34px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 109px; height: 34px">
                                Usuario</td>
                            <td style="width: 116px; height: 34px">
                                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
                            <td style="width: 47px; height: 34px">
                                <asp:Label ID="Label1" runat="server" Text="*"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 109px; height: 34px">
                                Contraseña</td>
                            <td style="width: 116px; height: 34px">
                                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
                            <td style="width: 47px; height: 34px">
                                <asp:Label ID="Label2" runat="server" Text="*"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 109px">
                            </td>
                            <td style="width: 116px">
                                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" /></td>
                            <td style="width: 47px">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height: 22px">
                </td>
                <td style="height: 22px">
                </td>
                <td style="height: 22px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>