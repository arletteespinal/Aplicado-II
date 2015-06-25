<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecetaPacientesWeb.aspx.cs" Inherits="ControlPacientesWeb.ControlPanel.Registros.RecetaPacientesWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width:50%;">
        <tr>
            <td colspan="18" style="font-weight: 700">
                <h1>Registro de Receta de Pacientes</h1>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="16">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Codigo:</td>
            <td colspan="8">
                <asp:TextBox ID="CodigoTextBox" runat="server" Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
            <td colspan="2">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="3">Fecha:</td>
            <td colspan="4">
                <asp:TextBox ID="FechaTextBox" runat="server" CssClass="datepicker"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="FechaTextBox" ErrorMessage="El campo &quot;Fecha&quot; es obligatorio." ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            </td>
            <td colspan="3">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="3">Paciente:</td>
            <td colspan="4">
                <asp:DropDownList ID="PacientesDropDownList" runat="server">
                </asp:DropDownList>
            </td>
            <td colspan="3">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="16">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1" colspan="16">
                

              <fieldset><legend>Medicamentos</legend>

                   </fieldset>
              
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2">
                

                Medicamentos:</td>
            <td colspan="2">
                

                &nbsp;</td>
            <td colspan="2">
                

                &nbsp;</td>
            <td colspan="2">
                

                &nbsp;</td>
            <td colspan="2">
                

                &nbsp;</td>
            <td colspan="6">
                

                Frecuencia:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="5">
                

                <asp:DropDownList ID="MedicamentosDropDownList" runat="server">
                </asp:DropDownList>
            </td>
            <td colspan="8">
                

                <asp:TextBox ID="FrecuenciaTextBox" runat="server" Width="357px"></asp:TextBox>
            </td>
            <td colspan="3">
                

                <asp:Button ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="16">
                

                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="16">
                

                <asp:GridView ID="DetalleGridView" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
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
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="16">
                

                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="16">
                

                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" Enabled="False" />
             
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
