<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="ControlPacientesWeb.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/css/jquery-ui.css" rel="stylesheet" />

    <script src="../Scripts/jquery-1.10.2.js"></script>
    <script src="../Scripts/jquery-ui.js"></script>
    <script>
        $(function () {
            $(".datepicker").datepicker();
        });
    </script>


     <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
   


    <!-- Bootstrap core CSS -->
  
    <link href="Content/assets/css/bootstrap.css" rel="stylesheet" />

    <!-- Custom styles for this template -->
 
    <link href="Content/assets/css/main.css" rel="stylesheet" />

    <script src="Content/assets/js/jquery-1.10.2.min.js"></script>
    <script src="Content/assets/js/hover.zoom.js"></script>
    <script src="Content/assets/js/hover.zoom.conf.js"></script>

    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
    <![endif]-->

    <style type="text/css">
        .auto-style1 {
            width: 276px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">

          <!-- Static navbar -->
    <div class="navbar navbar-inverse navbar-static-top">
      <div class="container">
        <div class="navbar-header">
          <a class="navbar-brand" href="index.html">Control Pacientes</a>
        </div>
      </div>

   </div>
        <br />

    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="19">
                    <h1 class="text-center"><strong>Registrarse</strong></h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td colspan="17">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>Nombre Usuario:</td>
                <td colspan="2"><asp:TextBox ID="NombreTextBox" runat="server" Width="418px"></asp:TextBox></td>
                <td colspan="3"> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="NombreTextBox" ErrorMessage="El campo &quot;Nombre Usuario&quot; es obligatorio" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td colspan="3">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td>
                   
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>Contraseña:</td>
                <td colspan="4"><asp:TextBox ID="ContrasenaTextBox" runat="server" Width="223px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="*" ControlToValidate="ContrasenaTextBox" ForeColor="#CC0000" ErrorMessage='El campo "Contraseña" es obligatorio'></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="ContrasenaTextBox" ControlToCompare="ConfirmarContrasenaTextBox" ErrorMessage="No coinciden las contraseñas" ForeColor="#CC0000"></asp:CompareValidator>
                </td>
                <td>
                      
                  
                </td>
                <td>&nbsp;</td>
                <td colspan="4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>Confirmar Contraseña:</td>
                <td><asp:TextBox ID="ConfirmarContrasenaTextBox" runat="server" Width="219px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ConfirmarContrasenaTextBox" ErrorMessage="El campo &quot;Confirmar Contraseña&quot; es obligatorio" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td colspan="2"></td>
                <td colspan="2">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>
                    
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td colspan="17">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    
                </td>
                <td colspan="17">
                    <asp:Button ID="RegistrarButton" runat="server" Text="Registrarse" OnClick="RegistrarButton_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    
                    &nbsp;</td>
                <td colspan="17">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Atras</asp:HyperLink>
                    </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
