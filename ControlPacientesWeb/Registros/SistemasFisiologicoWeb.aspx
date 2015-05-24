<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SistemasFisiologicoWeb.aspx.cs" Inherits="ControlPacientesWeb.Registros.SistemasFisiologicoWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 295px;
        }
        .auto-style2 {
            text-align: center;
            height: 126px;
        }
        .auto-style3 {
            height: 126px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2" colspan="22">
                <h1></h1>
                <h1><strong>Registo de Sistemas Fisiologico</strong></h1>
            </td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Codigo:</td>
            <td>
                <asp:TextBox ID="CodigoTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td colspan="3">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Nombre:</td>
            <td colspan="3">
                <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
            </td>
            <td colspan="4">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="19">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1" colspan="2">
                &nbsp;</td>
            <td class="auto-style1" colspan="3">
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
            </td>
            <td class="auto-style1" colspan="2">
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />

            </td>
            <td class="auto-style1" colspan="3">
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" Enabled="False" OnClick="EliminarButton_Click" />
            </td>
            <td class="auto-style1" colspan="2">
                &nbsp;</td>
            <td class="auto-style1" colspan="2">
                &nbsp;</td>
            <td class="auto-style1" colspan="2">
                &nbsp;</td>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
