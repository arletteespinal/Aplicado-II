<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RevisionPacienteWeb.aspx.cs" Inherits="ControlPacientesWeb.Registros.RevisionPacienteWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 55px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="18" style="font-weight: 700">
                <h1>Registro de Revision de Pacientes</h1>
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
                <asp:TextBox ID="CodigoTextBox" runat="server"></asp:TextBox>
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
                <asp:TextBox ID="FechaTextBox" runat="server"></asp:TextBox>
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
                

              <fieldset><legend><b>Revision por Sistemas</b></legend>

                   </fieldset>
              
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2">
                

                Sistema:</td>
            <td colspan="2">
                

                &nbsp;</td>
            <td colspan="2">
                

                &nbsp;</td>
            <td colspan="2">
                

                &nbsp;</td>
            <td colspan="2">
                

                &nbsp;</td>
            <td colspan="6">
                

                Estado:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="5">
                

                <asp:DropDownList ID="SistemasDropDownList" runat="server">
                </asp:DropDownList>
            </td>
            <td colspan="8">
                

                <asp:TextBox ID="EstadoTextBox" runat="server" Width="357px"></asp:TextBox>
            </td>
            <td colspan="3">
                

                <asp:Button ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" />
                <asp:Button ID="QuitarButton" runat="server" Text="Quitar" OnClick="QuitarButton_Click" />
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
                

                <asp:GridView ID="DetalleGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" Height="137px" Width="637px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" ForeColor="Black" Enabled="False" OnSelectedIndexChanged="Page_Load">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                        <asp:BoundField DataField="CodigoSistema" HeaderText="CodigoSistema" />
                        <asp:BoundField DataField="Sistema" HeaderText="Sistema" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
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
                

                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" />
             
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
