﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CPacientesWeb.aspx.cs" Inherits="ControlPacientesWeb.Consultas.CPacientesWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 899px;
        }
        .auto-style8 {
            width: 128px;
        }
        .auto-style9 {
            width: 129px;
        }
        .auto-style10 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td colspan="7" class="auto-style1">
                <h1 class="auto-style10"><strong style="text-align: center">Consulta de Pacientes</strong></h1>
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
                <asp:GridView ID="PacientesGridView" runat="server">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="Codigo" DataNavigateUrlFormatString="~/Registros/PacientesWeb.aspx?Codigo={0}" Text="Editar" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
