<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmCuerpoEnviados.aspx.vb" Inherits="frmCuerpoEnviados"   masterpagefile="~/mpInicio.master"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:content id="Cuerpo" ContentPlaceHolderId="SeccionContenidos" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td style="width: 120px">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    </td>
                <td style="width: 281px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 120px">
                    <asp:HyperLink ID="hpResponder" runat="server" NavigateUrl="~/frmInsertaDocInt.aspx"
                        Width="101px">Enviar Alerta</asp:HyperLink></td>
                <td style="width: 281px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;<cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0">
                        <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
                            <ContentTemplate>
                                <asp:GridView ID="gvasignados" runat="server">
                                </asp:GridView>
                            </ContentTemplate>
                        </cc1:TabPanel>
                        <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
                            <ContentTemplate>
                                <asp:GridView ID="gvasignadocopia" runat="server">
                                </asp:GridView>
                            </ContentTemplate>
                        </cc1:TabPanel>
                    </cc1:TabContainer></td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:Label ID="lbTipoDoc" runat="server" Text="Label" Font-Bold="True" Font-Names="Arial" Font-Overline="False" Font-Underline="True"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 120px">
                    PARA &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; :</td>
                <td colspan="2">
                    <asp:Label ID="lblremitente" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 120px">
                </td>
                <td colspan="2">
                    <asp:Label ID="lblCargo" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 120px">
                    ASUNTO &nbsp; &nbsp; :</td>
                <td colspan="2">
                    <asp:Label ID="lblasunto" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 120px; height: 18px">
                    FECHA &nbsp; &nbsp; &nbsp;&nbsp; :</td>
                <td colspan="2" style="height: 18px">
                    <asp:Label ID="lblfecha" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="3" style="height: 12px">
                    <hr />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" BasePath="~/fckeditor/" Height="500px">
                    </FCKeditorV2:FCKeditor>
                </td>
            </tr>
            <tr>
                <td style="height: 10px; width: 120px;">
                    Comentarios :</td>
                <td style="width: 281px; height: 10px;">
                </td>
                <td style="height: 10px;">
                </td>
            </tr>
            <tr>
                <td style="height: 25px; width: 120px;">
                </td>
                <td style="width: 281px; height: 25px">
                    <asp:TextBox ID="txtObservaciones" runat="server" Height="130px" TextMode="MultiLine"
                        Width="318px"></asp:TextBox></td>
                <td style="height: 25px;">
                </td>
            </tr>
            <tr>
                <td style="height: 17px; width: 120px;">
                    Anexos :</td>
                <td style="width: 281px; height: 17px">
                </td>
                <td style="height: 17px;">
                </td>
            </tr>
            <tr>
                <td style="height: 25px; width: 120px;">
                </td>
                <td style="width: 281px; height: 25px">
                    <asp:ListBox ID="lbAnexos" runat="server" AutoPostBack="True" Height="97px" Width="434px">
                    </asp:ListBox></td>
                <td style="height: 25px;">
                </td>
            </tr>
            <tr>
                <td style="width: 120px">
                    FECHA LIMITE :</td>
                <td style="width: 281px">
                    <asp:TextBox ID="txtFechaLimite" runat="server"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 120px">
                    <asp:TextBox ID="txtIdDocInt" runat="server" Visible="False"></asp:TextBox></td>
                <td style="width: 281px">
                </td>
                <td>
                </td>
            </tr>
        </table>
    
    </div>
 </asp:content>
