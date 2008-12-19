<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmAgregarAnexo.aspx.vb" Inherits="frmEnvioDoc" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<%@ Register Assembly="obout_Editor" Namespace="OboutInc.Editor" TagPrefix="obout" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
    <link href="mvwres:1-OboutInc.Editor.Resources.CSS.style.css,obout_Editor, Version=1.8.1209.1, Culture=neutral, PublicKeyToken=3758f1b5e9d8196b"
        media="all" rel="stylesheet" />
    <link href="mvwres:1-OboutInc.Editor.Resources.CSS.style.css,obout_Editor, Version=1.8.1209.1, Culture=neutral, PublicKeyToken=3758f1b5e9d8196b"
        media="all" rel="stylesheet" />
    <script type="text/javascript" src="/editor/_source/fckeditor.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <table style="width: 100%; height: 100%">
            <tr>
                <td colspan="3">
                </td>
            </tr>
            <tr>
                <td style="height: 11px">
                    Archivo de Anexo</td>
                <td colspan="2" style="height: 11px">
                    &nbsp;&nbsp;
                    <asp:UpdatePanel ID="upBuscarArchivo" runat="server">
                        <ContentTemplate>
                            &nbsp; &nbsp; &nbsp;&nbsp;
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:FileUpload ID="fuSubeAnexo" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 12px">
                    <asp:Button ID="btnAgregAnexo" runat="server" Text="Agregar Anexo a la Lista" Width="191px" />
                    <asp:UpdatePanel ID="upListaAnexo" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            &nbsp; &nbsp;
                            <asp:ListBox ID="lbAnexos" runat="server" Height="97px" Width="434px" AutoPostBack="True"></asp:ListBox><br />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Button ID="btnQuitarAnexo" runat="server" Text="Quitar Anexo de la Lista" /><br />
                    &nbsp; &nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td style="height: 12px">
                    Insertar Comentarios</td>
                <td style="height: 12px">
                    <asp:TextBox ID="txtObservaciones" runat="server" Height="130px" Width="318px" TextMode="MultiLine"></asp:TextBox></td>
                <td style="height: 12px; width: 1px;">
                </td>
            </tr>
            <tr>
                <td style="height: 8px">
                    Fecha Limite
                </td>
                <td style="height: 8px">
                    &nbsp;<asp:TextBox ID="txtFechaLimite" runat="server"></asp:TextBox></td>
                <td style="width: 1px; height: 8px">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" /><asp:Button ID="Button2" runat="server" Text="Cancelar" /></td>
                <td style="width: 1px">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    &nbsp;<FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" BasePath="/editor/" Value="NUevo">
                    </FCKeditorV2:FCKeditor>
                </td>
                <td style="width: 1px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
