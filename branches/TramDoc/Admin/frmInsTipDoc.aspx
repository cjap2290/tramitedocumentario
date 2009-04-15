<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmInsTipDoc.aspx.vb" Inherits="frmInsTipDoc"  MasterPageFile="~/mpInicio.master"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>--%>
<asp:content id="InsTipDoc" ContentPlaceHolderId="SeccionContenidos" runat="server">
    <%--<form id="form1" runat="server">--%>
    <div class="body#body">
        <table style="width: 100%; height: 100%">
            <tr>
                <td class="titform" colspan="2">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    Mantenimineto de Tipo de Documentos</td>
            </tr>
            <tr>
                <td class="lblform">
                    </td>
                <td style="width: 27px">
                    </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="width: 27px">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="width: 27px">
                </td>
            </tr>
            <tr>
                <td style="height: 126px" colspan="2" align="center">
                    <asp:GridView ID="gvTipDoc" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                       <RowStyle BackColor="White" ForeColor="#333333" />
                       <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                       <PagerStyle BackColor="#84C225" ForeColor="White" HorizontalAlign="Center" />
                       <HeaderStyle BackColor="#84C225" Font-Bold="True" ForeColor="White"   />
                    </asp:GridView>
                    &nbsp; &nbsp;&nbsp;</td>
                
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" PostBackUrl="~/frmMensajeResultado.aspx"
                        Text="Button" />&nbsp;
                </td>
                <td style="width: 27px">
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <cc1:TabContainer ID="tcTareas" runat="server" ActiveTabIndex="1">
                        <cc1:TabPanel ID="tpInsertar" runat="server" HeaderText="Registrar Nuevo Tipo de Documento">
                            <ContentTemplate>
                                &nbsp;&nbsp;<table style="width: 836px">
                                    <tr>
                                        <td>
                    Nombre del Tipo de Documento :</td>
                                        <td colspan="2">
                                            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" /></td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </cc1:TabPanel>
                        <cc1:TabPanel ID="tpActualizar" runat="server" HeaderText="Registrar Tipo Documento por Area">
                            <ContentTemplate>
                                <table style="width: 836px">
                                    <tr>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <asp:GridView ID="gvTipDocxAreaxAge" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                             BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px"
                                             CellPadding="4" GridLines="Horizontal" PageSize="7">
                                                <Columns>
                                                    <asp:BoundField />
                                                    <asp:BoundField DataField="Area" HeaderText="Area" />
                                                    <asp:BoundField  DataField="Agencia" HeaderText="Agencia" />
                                                </Columns>
                                                <FooterStyle BackColor="White" ForeColor="#333333" />
                                                <RowStyle BackColor="White" ForeColor="#333333" />
                                                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#84C225" ForeColor="White" HorizontalAlign="Center" />
                                                <HeaderStyle BackColor="#84C225" Font-Bold="True" ForeColor="White"   />
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Area :</td>
                                        <td>
                                <asp:DropDownList ID="cboAreas" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Agencia :</td>
                                        <td>
                                <asp:DropDownList ID="cboAgencia" runat="server">
                                </asp:DropDownList>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="BtnRegTipDocxArea" runat="server" Text="Registrar" />
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                                <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                            </ContentTemplate>
                        </cc1:TabPanel>
                    </cc1:TabContainer></td>
            </tr>
        </table>
    
    </div>
    <%--</form>--%>
</asp:content>
<%--</body>
</html>--%>
