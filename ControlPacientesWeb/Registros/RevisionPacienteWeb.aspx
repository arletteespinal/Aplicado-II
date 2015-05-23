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
            <td colspan="14" style="font-weight: 700">
                <h1>Registro de Revision de Pacientes</h1>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Codigo:</td>
            <td colspan="4">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td colspan="2">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2">Fecha:</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2">Paciente:</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1" colspan="12">
                

              <fieldset><legend><b>Revision por Sistemas</b></legend>

                   </fieldset>
              
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="6">
                

                Sistema:</td>
            <td colspan="6">
                

                Estado:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="3">
                

                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td colspan="6">
                

                <asp:TextBox ID="TextBox1" runat="server" Width="357px"></asp:TextBox>
            </td>
            <td colspan="3">
                

                <asp:Button ID="Button1" runat="server" Text="Button" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="12">
                

                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="12">
                

                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
             
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
