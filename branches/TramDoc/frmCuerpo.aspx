<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmCuerpo.aspx.vb" Inherits="frmCuerpo"   masterpagefile="~/mpInicio.master"%>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:content id="Cuerpo" ContentPlaceHolderId="SeccionContenidos" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td>
                </td>
                <td style="width: 281px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" BasePath="~/fckeditor/" Height="500px">
                    </FCKeditorV2:FCKeditor>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="width: 281px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="height: 25px">
                </td>
                <td style="width: 281px; height: 25px">
                </td>
                <td style="height: 25px">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="width: 281px">
                </td>
                <td>
                </td>
            </tr>
        </table>
    
    </div>
 </asp:content>
