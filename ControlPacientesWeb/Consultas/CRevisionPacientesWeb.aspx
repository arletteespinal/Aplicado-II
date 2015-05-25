<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CRevisionPacientesWeb.aspx.cs" Inherits="ControlPacientesWeb.Consultas.CRevisionPacientesWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="auto-style2">
        <tr>
            <td colspan="7" class="auto-style1">
                <h1 class="auto-style10"><strong style="text-align: center">Consulta de Revision de Pacientes</strong></h1>
            </td>
        </tr>
        <tr>
            <td colspan="7" class="auto-style1"></td>
        </tr>
        <tr>
            <td colspan="7" class="auto-style1"></td>
        </tr>
        <tr>
            <td colspan="5">Filtrar por:</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:DropDownList ID="FiltroDropDownList" runat="server">
                    <asp:ListItem Value="0">Nombres</asp:ListItem>
                    <asp:ListItem Value="1">Apellidos</asp:ListItem>
                    <asp:ListItem Value="2">Cedula</asp:ListItem>
                    <asp:ListItem Value="3">Fecha Ingreso</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="FiltroTextBox" runat="server" Width="291px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:Button ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
            </td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="7">
                <asp:GridView ID="RevisionGridView" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
