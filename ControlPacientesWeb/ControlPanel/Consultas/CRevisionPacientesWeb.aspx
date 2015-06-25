<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CRevisionPacientesWeb.aspx.cs" Inherits="ControlPacientesWeb.Consultas.CRevisionPacientesWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width:50%;">
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
                    <asp:ListItem Value="3">Fecha</asp:ListItem>
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
                <asp:GridView ID="RevisionGridView" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="Codigo" DataNavigateUrlFormatString="~/ControlPanel/Registros/RevisionPacienteWeb.aspx?Codigo={0}" Text="Editar" />
                        <asp:HyperLinkField DataNavigateUrlFields="Codigo" Text="Ver Detalle" DataNavigateUrlFormatString="~/ControlPanel/Consultas/CRevisionDetalleWeb.aspx?Codigo={0}" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
