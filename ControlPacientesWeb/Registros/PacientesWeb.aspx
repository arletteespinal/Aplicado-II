<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PacientesWeb.aspx.cs" Inherits="ControlPacientesWeb.Registros.PacientesWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            text-align: center;
            height: 56px;
        }
        .auto-style3 {
        }
        .auto-style4 {
            width: 503px;
        }
        .auto-style5 {
            width: 96px;
        }
        .auto-style6 {
            width: 112px;
        }
        .auto-style7 {
            width: 350px;
        }
        .auto-style8 {
            width: 1097px;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            width: 503px;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="15" class="auto-style2">
                <h1><strong>Registro de Pacientes</strong></h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4" colspan="13">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style9"></td>
            <td class="auto-style10" colspan="13"></td>
        </tr>
        <tr>
            <td class="auto-style1">Código:</td>
            <td class="auto-style3">
                <asp:TextBox ID="CodigoTextBox" runat="server" Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
            <td class="auto-style7" colspan="2">Fecha Ingreso:</td>
            <td class="auto-style7" colspan="2">
                <asp:TextBox ID="FechaIngresoTextBox" runat="server" style="margin-left: 0px" TextMode="Date"></asp:TextBox>
            </td>
            <td class="auto-style7" colspan="5">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Nombres:</td>
            <td class="auto-style3" colspan="14">
                <asp:TextBox ID="NombresTextBox" runat="server" Width="324px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Apellidos"></asp:Label>
                :</td>
            <td class="auto-style3" colspan="14">
                <asp:TextBox ID="ApellidosTextBox" runat="server" Width="321px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Fecha Nacimiento"></asp:Label>
                :</td>
            <td class="auto-style3">
                <asp:TextBox ID="FechaNacimientoTextBox" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td class="auto-style5">Genero:</td>
            <td class="auto-style5" colspan="5">
                <asp:DropDownList ID="GeneroDropDownList" runat="server">
                    <asp:ListItem Value="0">Femenino</asp:ListItem>
                    <asp:ListItem Value="1">Masculino</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style5" colspan="3">&nbsp;</td>
            <td class="auto-style8" colspan="2">
                &nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">C<span id="mt22" class="sentence" data-guid="5ba524387c043f100d3420929437849b" data-source="If you have not already done so, open your solution, (Keyboard: Ctrl + Shift + O) and then open Solution Explorer (Keyboard: Ctrl + Alt + L)." xml:space="preserve">é</span>dula:</td>
            <td class="auto-style3">
                <asp:TextBox ID="CedulaTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4" colspan="13">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Celular:</td>
            <td class="auto-style3">
                <asp:TextBox ID="CelularTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5" colspan="2">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="CelularTextBox" ErrorMessage="Celular no valido" ForeColor="#CC0000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">*</asp:RegularExpressionValidator>
&nbsp;Tel<span id="mt23" class="sentence" data-guid="5ba524387c043f100d3420929437849b" data-source="If you have not already done so, open your solution, (Keyboard: Ctrl + Shift + O) and then open Solution Explorer (Keyboard: Ctrl + Alt + L)." xml:space="preserve">é</span>fono:</td>
            <td class="auto-style5" colspan="3">
                <asp:TextBox ID="TelefonoTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5" colspan="3">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TelefonoTextBox" ErrorMessage="Telefono no valido" ForeColor="#CC0000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">*</asp:RegularExpressionValidator>
            </td>
            <td class="auto-style5" colspan="2">&nbsp;</td>
            <td class="auto-style8" colspan="2">
                &nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Dirección:</td>
            <td class="auto-style3" colspan="14">
                <asp:TextBox ID="DireccionTextBox" runat="server" Width="311px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Ocupación:</td>
            <td class="auto-style3" colspan="14">
                <asp:TextBox ID="OcupacionTextBox" runat="server" Width="311px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4" colspan="13">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
            </td>
            <td class="auto-style4" colspan="3">
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
            </td>
            <td class="auto-style6" colspan="7">
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
            </td>
            <td class="auto-style8" colspan="2">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style4" colspan="3">
                &nbsp;</td>
            <td class="auto-style6" colspan="7">
                &nbsp;</td>
            <td class="auto-style8" colspan="2">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style4" colspan="3">
                &nbsp;</td>
            <td class="auto-style6" colspan="7">
                &nbsp;</td>
            <td class="auto-style8" colspan="2">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="15">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" />
            </td>
        </tr>
    </table>
</asp:Content>
