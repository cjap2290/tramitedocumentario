<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmBuscador.aspx.vb" Inherits="frmBuscador" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
    <script language="javascript" type="text/javascript">
        function obtValor()
        {
          document.frmBuscador1.txtIdPers.value= document.getElementById("txtidpersona");
        }

    </script>
</head>
<body>
    <form id="frmBuscador" name="frmBuscador1" runat="server" action="frmRegUsuario.aspx" method="post">
    <div>
        <table style="width: 50%; height: 50%">
            <tr>
                <td colspan="6" style="height: 6px">
                    Buscar Personal : <br />
                    <hr id="HR2" style="height: 2px; width: 663px;" />
                 </td>              
            </tr>
            <tr>
                <td style="width: 10%">
                    <asp:DropDownList ID="cboOpcion" runat="server" Width="122px">
                        <asp:ListItem Value="0">Apellido Paterno</asp:ListItem>
                        <asp:ListItem Value="1">Apellido Materno</asp:ListItem>
                        <asp:ListItem Value="2">Nombres</asp:ListItem>
                    </asp:DropDownList></td>
                <td colspan = "5" style="width: 90%" id="txtidpersona">
                    <asp:TextBox ID="txtCadIng" runat="server" Width="239px"></asp:TextBox>
                    <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" /></td>
                
            </tr>
            <tr>
                <td colspan="6" style="width: 100%; height: 275px;">
                    <asp:GridView ID="gdListado" runat="server" AllowPaging="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" PageSize="7" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                    &nbsp;
                </td>                
            </tr>
            <tr>
                <td style="height: 56px; width: 58px;">
                    <asp:TextBox ID="txtselec" runat="server" ></asp:TextBox></td>
                <td style="width: 88px; height: 56px;">
                    &nbsp;<input id="txtIdPers" type="text" name="txtIdPers"  /></td>
                <td style="width: 3px; height: 56px;">
                    <input id="Submit1" type="submit" value="submit"  /></td>
                <td style="width: 27px; height: 56px;">
                </td>
                <td style="width: 13px; height: 56px;">
                    </td>
                <td style="width: 6px; height: 56px;">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
