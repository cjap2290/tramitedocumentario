<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmBuscador.aspx.vb" Inherits="frmBuscador" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
    <script language="javascript" type="text/javascript">        
        function closeFrmBuscador()
        {
           
          
          //window.opener.location.href = window.opener.location.href;          
          // window.opener.frmRegUsu.txtIdPersona.value=window.frmBuscador.txtIdPers.value ;
           //window.opener.frmRegUsu.txtPersona.value=window.frmBuscador.txtPersona.value ;
          //=;
          //alert("hasta aqui llego"); 
          window.opener.location.href = window.opener.location.href; 
          //document.frmBuscador.submit();        
          //opener.location.reload();
          window.close();
        }



    </script>
</head>
<body>
    <form id="frmBuscador"  runat="server" action="frmRegUsuario.aspx" method="post">
    <div>
        <table style="width: 50%; height: 30%">
            <tr>
                <td colspan="1" style="height: 6px; width: 482px;">
                    Buscar Personal : <br />
                    <hr id="HR2" style="height: 2px; width: 663px;" />
                 </td>              
            </tr>
            <tr>
                <td style="width: 482px">
                    <asp:DropDownList ID="cboOpcion" runat="server" Width="122px">
                        <asp:ListItem Value="0">Apellido Paterno</asp:ListItem>
                        <asp:ListItem Value="1">Apellido Materno</asp:ListItem>
                        <asp:ListItem Value="2">Nombres</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtCadIng" runat="server" Width="239px"></asp:TextBox>
                    <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" UseSubmitBehavior="False" OnClientClick="this.disabled=true" /></td>
                
            </tr>
            <tr>
                <td colspan="1" style="width: 482px; height: 275px;">
                    <asp:GridView ID="gdListado" runat="server" AllowPaging="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" PageSize="7" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField />
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
                <td style="height: 56px; width: 482px;">
                    &nbsp;<input id="txtIdPers" type="text" name="txtIdPers" style="width: 100px" runat="server" />&nbsp;
                    <input id="txtPersona" type="text"  runat="server" />
                    <asp:Button ID="BtnAceptar" runat="server" Text="Button" />
                    <input id="Button1" type="button" value="button" onclick=" closeFrmBuscador()" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
