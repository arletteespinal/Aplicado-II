using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Web.Security;

namespace ControlPacientesWeb
{
    public partial class Login : System.Web.UI.Page
    {
        public Usuarios usu = new Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

            if (usu.Autenticar(NombreUsuarioTextBox.Text, ContrasenaTextBox.Text))
            {
                Session["usuario"] =NombreUsuarioTextBox.Text;
                FormsAuthentication.RedirectFromLoginPage(NombreUsuarioTextBox.Text, true);
            }
            else
            {
                
            }
        }
    }
}