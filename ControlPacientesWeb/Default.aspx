<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlPacientesWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 640px;
            height: 384px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
         <h1>
             <asp:Label ID="Label1" runat="server" Text="Control de Pacientes" style="font-weight: 700; text-align: center"></asp:Label>
        <img alt="" class="auto-style1" src="Imagenes/RevisionPacientes.jpg" /></h1></p>
</asp:Content>
