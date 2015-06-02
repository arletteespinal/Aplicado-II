using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb
{
    public partial class Registrarse : System.Web.UI.Page
    {
        private Usuarios usu = new Usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        protected void RegistrarButton_Click(object sender, EventArgs e)
        {
                usu.NombreUsuario = NombreTextBox.Text;
                usu.Contrasena = ContrasenaTextBox.Text;
                if (usu.Insertar())
                {

                }
          
        }
    }
}