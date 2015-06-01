<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ControlPacientesWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="UTF-8"/>
    
    
    <link href="../Content/less/style.css" rel="stylesheet" />
    
    
</head>
<body>
   
    <div>
     <div class="wrapper">
	<div class="container">
		<h1>Bienvenido</h1>
		
		<form class="form" runat="server">
			
            <asp:TextBox ID="NombreUsuarioTextBox" runat="server"></asp:TextBox>
            <asp:TextBox ID="ContrasenaTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
		</form>
	</div>
	
	<ul class="bg-bubbles">
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
	</ul>
</div>
   
<script src="../Scripts/jquery-1.8.2.min.js"></script>
        <script src="js/index.js"></script>
    </div>
  
</body>
</html>
